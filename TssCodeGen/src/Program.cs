/*
 *  Copyright (c) Microsoft Corporation. All rights reserved.
 *  Licensed under the MIT License. See the LICENSE file in the project root for full license information.
 */

using System;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

/*
 * Entry point for the code generator.
 * 
 * This program works in three phases:
 *  1) Parses Part 2 and 3 of the TPM 2.0 spec, extracts tables with the definitions of TPM 2.0 data
 *     structures, constants, unions, and commands and saves them as in an XML file (RawTables.xml).
 *     If RawTables.xml already exists, then this step is skipped by default. It can be enforced 
 *     with the '-extract' command line option.
 *  2) Reads the XML file with extracted definitions and creates internal abstract syntax tree (AST)
 *     of the TPM 2.0 entities.
 *  3) Generates the code for the target program languages (all supported languages by default, or as
 *     specified with the command line options).
 * 
 * */

namespace CodeGen
{
    class Program
    {
        [Flags]
        enum Action
        {
            None = 0,
            ExtractFromDoc = 0x1,
        }

        static void PrintError(string msg, params object[] msgArgs)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg, msgArgs);
            Console.ResetColor();
        }

        enum Option
        {
            ParsingError = 0,
            Matched = 1,
            NotMatched = 2
        }

        static Option ProcessPathOption(string curOpt, string targetOpt, string[] args, ref int i, ref string path)
        {
            if (path != null || 0 != string.Compare(curOpt, targetOpt, StringComparison.OrdinalIgnoreCase))
                return Option.NotMatched;

            if (++i == args.Length)
            {
                PrintError("Option root must be followed by a path name");
                return Option.ParsingError;
            }

            path = args[i];
            if (path[0] == '-' || path[0] == '/')
            {
                PrintError("Option root must be followed by a valid path name");
                return Option.ParsingError;
            }

            if (!path.EndsWith(Path.DirectorySeparatorChar.ToString()))
            {
                path += Path.DirectorySeparatorChar;
            }
            return Option.Matched;
        }

        static void Main(string[] args)
        {
            bool help = false;
            string specPath = null;
            string tssRootPath = null;
            Action actions = Action.None;

            Func<Lang, string> langName = l => Enum.GetName(typeof(Lang), l);

            var allLangs = ((Lang[])Enum.GetValues(typeof(Lang))).ToList();
            var langs = new List<Lang>();

            for (int i = 0; i < args.Length; ++i)
            {
                string opt = args[i];

                if (opt[0] != '-' && opt[0] != '/')
                {
                    help = true;
                    PrintError($"Invalid format for option {i}: {opt}");
                    break;
                }

                opt = opt[1..];

                var res = ProcessPathOption(opt, "spec", args, ref i, ref specPath);
                if (res == Option.ParsingError)
                    return;
                if (res == Option.Matched)
                    continue;

                res = ProcessPathOption(opt, "dest", args, ref i, ref tssRootPath);
                if (res == Option.ParsingError)
                    return;
                if (res == Option.Matched)
                    continue;

                if (opt is "h" or "help" or "?")
                {
                    help = true;
                }
                else if (0 == string.Compare(opt, "extract", StringComparison.OrdinalIgnoreCase))
                {
                    actions |= Action.ExtractFromDoc;
                }
                else if (0 == string.Compare(opt, "noextract", StringComparison.OrdinalIgnoreCase))
                {
                    actions &= ~Action.ExtractFromDoc;
                }
                else
                {
                    Lang lang = allLangs.FirstOrDefault(l => 0 == string.Compare(opt, langName(l), StringComparison.OrdinalIgnoreCase));
                    if (lang != Lang.None)
                    {
                        if (!langs.Contains(lang))
                            langs.Add(lang);
                    }
                    else
                    {
                        lang = allLangs.FirstOrDefault(l => 0 == string.Compare(opt, "no" + langName(l), StringComparison.OrdinalIgnoreCase));
                        if (lang != Lang.None)
                        {
                            langs = allLangs.Where(l => l != lang).ToList();
                        }
                        else
                        {
                            help = true;
                            PrintError($"Unrecognized option '{opt}'");
                        }
                    }
                }
            }

            if (help)
            {
                Console.WriteLine("""
                    TSS Code Generator tool.
                    Copyright (c) Microsoft Corporation. All rights reserved.
                    
                    This tool (re)generates the interface part of the TPM Software Stack (TSS)
                    implementations for all supported programming languages/frameworks (TSS.Net,
                    TSS.CPP, TSS.Java, TSS.JS, TSS.Py)
                    
                    All command line parameters are case-insensitive and optional.
                    Option names are prepended with either dash ('-') or slash ('/') marks (e.g., -help).
                    
                    The following options are supported:
                      h|help|?    - Displays this message
                      spec <path> - Path to the folder containing the TPM 2.0 specification Word
                                    documents and/or intermediate XML representation (RawTables.xml).
                                    By default the TssCodeGen/TpmSpec folder is used.
                      dest <path> - Path to the root folder containing individual TSSes to be updated.
                                    By default the TSS implementations in this repo clone (in the
                                    folders adjacent to the TssCodeGen folder) are updated.
                      extract     - Force parsing the TPM 2.0 spec documents even if the intermediate
                                    XML representation file (RawTables.xml) is available. By default
                                    the tool will always use RawTables.xml if it is present.
                      dotNet,     - Language specifier. Any one or more of these may be provided
                      cpp,          to select TSS implementation(s) to be updated. By default (in the 
                      java,         absence of any language specification), all supported languages
                      node,         are updated.
                      py

                    
                    Note that the default path values used by the tool are selected in expectation
                    that it is run from the Visual Studio after being built from its github repo clone.
                    If however the binary location or folder structure is different, options 'spec'
                    and 'dest' will be required.
                    """);
                return;
            }

            // The TPM 2.0 spec Word docs Part 2 and 3 are parsed to produce an XML representation.
            // This operation is slow. By default (i.e. if no '-extract' option is specified) 
            // CodeGen bypasses the spec parsing stage and proceeds directly off the existing XML.

            if (specPath == null)
            {
                string pwd = Directory.GetCurrentDirectory();
                specPath = Path.GetFullPath(Path.Combine(pwd, @"TpmSpec"));
            }
            string rawTables = Path.GetFullPath(Path.Combine(specPath, "RawTables.xml"));

            if (actions.HasFlag(Action.ExtractFromDoc) || !File.Exists(rawTables))
            {
                // Kill Word processes
                Process[] wordProcesses = Process.GetProcessesByName("WINWORD");
                if (wordProcesses.Length != 0)
                {
                    DialogResult res = MessageBox.Show("There are word processes running.  Kill them?", "Kill Word Processes?", MessageBoxButtons.YesNo);
                    if (res == DialogResult.Yes)
                    {
                        foreach (Process p in wordProcesses) try
                            {
                                p.Kill();
                            }
                            catch (Exception)
                            {
                                // ignored
                            }

                        Thread.Sleep(2000);
                    }
                }

                TableExtractor extractor = new TableExtractor(specPath);
                XmlSerializeToFile(rawTables, RawTables.Tables);
            }

            // Load the XML description of the tables, and extract into in-memory data structures
            List<RawTable> tables = XmlDeserializeFromFile<List<RawTable>>(rawTables);
            TypeExtractor tpe = new TypeExtractor(tables);
            tpe.Extract();

            if (langs.Count == 0)
                langs = allLangs.Skip(1).ToList();

            foreach (var lang in langs)
            {
                if (lang == Lang.DotNet)
                    continue;
                var tssName = "TSS." + langName(lang).Replace("DotNet", "Net");
                Console.WriteLine($"\nGenerating {tssName}...");
                var cg = TargetLang.NewCodeGen(lang, tssRootPath + tssName + '\\');
                TargetLang.SetTargetLang(lang);
                cg.Generate();
            }
            if (langs.Contains(Lang.DotNet))
            {
                Console.WriteLine("\nGenerating TSS.Net...");
                CGenDotNet dotNetGen = new CGenDotNet(tssRootPath + @"TSS.NET\");
                TargetLang.SetTargetLang(Lang.DotNet);
                dotNetGen.Generate();
            }
            Console.WriteLine("\nAll done!");
        }

        public static void XmlSerializeToFile(string FileName, object o)
        {
            // note: the XmlSerializer throws an exception that is caught internally.  
            // it can safely be ignored in the debugger
            XmlSerializer serializer = new XmlSerializer(o.GetType());
            StreamWriter writer = new StreamWriter(FileName);
            serializer.Serialize(writer, o);
            writer.Close();
            writer.Dispose();
        }

        public static T XmlDeserializeFromFile<T>(string FileName)
        {
            // note: the XmlSerializer throws an exception that is caught internally.  
            // it can safely be ignored in the debugger
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            StreamReader reader = new StreamReader(FileName);
            object newObject = serializer.Deserialize(reader);
            reader.Close();
            reader.Dispose();
            return (T)newObject;
        }
    }
}
