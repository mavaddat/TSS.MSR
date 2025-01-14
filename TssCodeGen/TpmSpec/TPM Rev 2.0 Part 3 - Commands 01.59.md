Trusted Platform Module Library

Part 3: Commands

Family “2.0”

Level 00 Revision 01.59

November 8, 2019

**Committee Draft**

Contact: admin@trustedcomputinggroup.org

TCG Confidential

Copyright © TCG 2006-2019

**Licenses and Notices**

**Copyright Licenses**:

- Trusted Computing Group (TCG) grants to the user of the source code in
  this specification (the “Source Code”) a worldwide, irrevocable,
  nonexclusive, royalty free, copyright license to reproduce, create
  derivative works, distribute, display and perform the Source Code and
  derivative works thereof, and to grant others the rights granted
  herein.

- The TCG grants to the user of the other parts of the specification
  (other than the Source Code) the rights to reproduce, distribute,
  display, and perform the specification solely for the purpose of
  developing products based on such documents.

**Source Code Distribution Conditions**:

- Redistributions of Source Code must retain the above copyright
  licenses, this list of conditions and the following disclaimers.

- Redistributions in binary form must reproduce the above copyright
  licenses, this list of conditions and the following disclaimers in the
  documentation and/or other materials provided with the distribution.

**Disclaimers**:

- THE COPYRIGHT LICENSES SET FORTH ABOVE DO NOT REPRESENT ANY FORM OF
  LICENSE OR WAIVER, EXPRESS OR IMPLIED, BY ESTOPPEL OR OTHERWISE, WITH
  RESPECT TO PATENT RIGHTS HELD BY TCG MEMBERS (OR OTHER THIRD PARTIES)
  THAT MAY BE NECESSARY TO IMPLEMENT THIS SPECIFICATION OR OTHERWISE.
  Contact TCG Administration (<admin@trustedcomputinggroup.org>) for
  information on specification licensing rights available through TCG
  membership agreements.

- THIS SPECIFICATION IS PROVIDED "AS IS" WITH NO EXPRESS OR IMPLIED
  WARRANTIES WHATSOEVER, INCLUDING ANY WARRANTY OF MERCHANTABILITY OR
  FITNESS FOR A PARTICULAR PURPOSE, ACCURACY, COMPLETENESS, OR
  NONINFRINGEMENT OF INTELLECTUAL PROPERTY RIGHTS, OR ANY WARRANTY
  OTHERWISE ARISING OUT OF ANY PROPOSAL, SPECIFICATION OR SAMPLE.

- Without limitation, TCG and its members and licensors disclaim all
  liability, including liability for infringement of any proprietary
  rights, relating to use of information in this specification and to
  the implementation of this specification, and TCG disclaims all
  liability for cost of procurement of substitute goods or services,
  lost profits, loss of use, loss of data or any incidental,
  consequential, direct, indirect, or special damages, whether under
  contract, tort, warranty or otherwise, arising in any way out of use
  or reliance upon this specification or any information herein.

Any marks and brands contained herein are the property of their
respective owners.

CONTENTS

1 Scope 1

2 Terms and Definitions 1

3 Symbols and abbreviated terms 1

4 Notation 2

4.1 Introduction 2

4.2 Table Decorations 2

4.3 Handle and Parameter Demarcation 3

4.4 AuthorizationSize and ParameterSize 3

4.5 Return Code Alias 4

5 Command Processing 4

5.1 Introduction 4

5.2 Command Header Validation 4

5.3 Mode Checks 5

5.4 Handle Area Validation 5

5.5 Session Area Validation 6

5.6 Authorization Checks 7

5.7 Parameter Decryption 9

5.8 Parameter Unmarshaling 9

5.9 Command Post Processing 11

6 Response Values 12

6.1 Tag 12

6.2 Response Codes 12

7 Implementation Dependent 15

8 Detailed Actions Assumptions 16

8.1 Introduction 16

8.2 Pre-processing 16

8.3 Post Processing 16

9 Start-up 17

9.1 Introduction 17

9.2 \_TPM_Init 17

9.3 TPM2_Startup 19

9.4 TPM2_Shutdown 24

10 Testing 27

10.1 Introduction 27

10.2 TPM2_SelfTest 28

10.3 TPM2_IncrementalSelfTest 31

10.4 TPM2_GetTestResult 34

11 Session Commands 37

11.1 TPM2_StartAuthSession 37

11.2 TPM2_PolicyRestart 41

12 Object Commands 44

12.1 TPM2_Create 44

12.2 TPM2_Load 49

12.3 TPM2_LoadExternal 52

12.4 TPM2_ReadPublic 56

12.5 TPM2_ActivateCredential 59

12.6 TPM2_MakeCredential 62

12.7 TPM2_Unseal 65

12.8 TPM2_ObjectChangeAuth 68

12.9 TPM2_CreateLoaded 71

13 Duplication Commands 74

13.1 TPM2_Duplicate 74

13.2 TPM2_Rewrap 77

13.3 TPM2_Import 80

14 Asymmetric Primitives 84

14.1 Introduction 84

14.2 TPM2_RSA_Encrypt 84

14.3 TPM2_RSA_Decrypt 88

14.4 TPM2_ECDH_KeyGen 91

14.5 TPM2_ECDH_ZGen 94

14.6 TPM2_ECC_Parameters 97

14.7 TPM2_ZGen_2Phase 100

14.8 TPM2_ECC_Encrypt 103

14.9 TPM2_ECC_Decrypt 106

15 Symmetric Primitives 108

15.1 Introduction 108

15.2 TPM2_EncryptDecrypt 110

15.3 TPM2_EncryptDecrypt2 113

15.4 TPM2_Hash 116

15.5 TPM2_HMAC 119

15.6 TPM2_MAC 122

16 Random Number Generator 125

16.1 TPM2_GetRandom 125

16.2 TPM2_StirRandom 128

17 Hash/HMAC/Event Sequences 131

17.1 Introduction 131

17.2 TPM2_HMAC_Start 131

17.3 TPM2_MAC_Start 134

17.4 TPM2_HashSequenceStart 137

17.5 TPM2_SequenceUpdate 140

17.6 TPM2_SequenceComplete 143

17.7 TPM2_EventSequenceComplete 146

18 Attestation Commands 149

18.1 Introduction 149

18.2 TPM2_Certify 151

18.3 TPM2_CertifyCreation 154

18.4 TPM2_Quote 157

18.5 TPM2_GetSessionAuditDigest 160

18.6 TPM2_GetCommandAuditDigest 163

18.7 TPM2_GetTime 166

18.8 TPM2_CertifyX509 168

19 Ephemeral EC Keys 172

19.1 Introduction 172

19.2 TPM2_Commit 173

19.3 TPM2_EC_Ephemeral 176

20 Signing and Signature Verification 179

20.1 TPM2_VerifySignature 179

20.2 TPM2_Sign 182

21 Command Audit 185

21.1 Introduction 185

21.2 TPM2_SetCommandCodeAuditStatus 186

22 Integrity Collection (PCR) 189

22.1 Introduction 189

22.2 TPM2_PCR_Extend 190

22.3 TPM2_PCR_Event 193

22.4 TPM2_PCR_Read 196

22.5 TPM2_PCR_Allocate 199

22.6 TPM2_PCR_SetAuthPolicy 202

22.7 TPM2_PCR_SetAuthValue 205

22.8 TPM2_PCR_Reset 208

22.9 \_TPM_Hash_Start 211

22.10 \_TPM_Hash_Data 213

22.11 \_TPM_Hash_End 215

23 Enhanced Authorization (EA) Commands 217

23.1 Introduction 217

23.2 Signed Authorization Actions 218

23.3 TPM2_PolicySigned 222

23.4 TPM2_PolicySecret 226

23.5 TPM2_PolicyTicket 229

23.6 TPM2_PolicyOR 232

23.7 TPM2_PolicyPCR 235

23.8 TPM2_PolicyLocality 239

23.9 TPM2_PolicyNV 242

23.10 TPM2_PolicyCounterTimer 245

23.11 TPM2_PolicyCommandCode 248

23.12 TPM2_PolicyPhysicalPresence 251

23.13 TPM2_PolicyCpHash 254

23.14 TPM2_PolicyNameHash 257

23.15 TPM2_PolicyDuplicationSelect 260

23.16 TPM2_PolicyAuthorize 263

23.17 TPM2_PolicyAuthValue 266

23.18 TPM2_PolicyPassword 269

23.19 TPM2_PolicyGetDigest 272

23.20 TPM2_PolicyNvWritten 275

23.21 TPM2_PolicyTemplate 278

23.22 TPM2_PolicyAuthorizeNV 281

24 Hierarchy Commands 284

24.1 TPM2_CreatePrimary 284

24.2 TPM2_HierarchyControl 287

24.3 TPM2_SetPrimaryPolicy 290

24.4 TPM2_ChangePPS 293

24.5 TPM2_ChangeEPS 296

24.6 TPM2_Clear 299

24.7 TPM2_ClearControl 302

24.8 TPM2_HierarchyChangeAuth 305

25 Dictionary Attack Functions 308

25.1 Introduction 308

25.2 TPM2_DictionaryAttackLockReset 308

25.3 TPM2_DictionaryAttackParameters 311

26 Miscellaneous Management Functions 314

26.1 Introduction 314

26.2 TPM2_PP_Commands 314

26.3 TPM2_SetAlgorithmSet 317

27 Field Upgrade 320

27.1 Introduction 320

27.2 TPM2_FieldUpgradeStart 322

27.3 TPM2_FieldUpgradeData 325

27.4 TPM2_FirmwareRead 328

28 Context Management 331

28.1 Introduction 331

28.2 TPM2_ContextSave 331

28.3 TPM2_ContextLoad 334

28.4 TPM2_FlushContext 337

28.5 TPM2_EvictControl 340

29 Clocks and Timers 344

29.1 TPM2_ReadClock 344

29.2 TPM2_ClockSet 347

29.3 TPM2_ClockRateAdjust 350

30 Capability Commands 353

30.1 Introduction 353

30.2 TPM2_GetCapability 353

30.3 TPM2_TestParms 359

31 Non-volatile Storage 362

31.1 Introduction 362

31.2 NV Counters 364

31.3 TPM2_NV_DefineSpace 365

31.4 TPM2_NV_UndefineSpace 369

31.5 TPM2_NV_UndefineSpaceSpecial 372

31.6 TPM2_NV_ReadPublic 375

31.7 TPM2_NV_Write 378

31.8 TPM2_NV_Increment 381

31.9 TPM2_NV_Extend 384

31.10 TPM2_NV_SetBits 387

31.11 TPM2_NV_WriteLock 390

31.12 TPM2_NV_GlobalWriteLock 393

31.13 TPM2_NV_Read 396

31.14 TPM2_NV_ReadLock 399

31.15 TPM2_NV_ChangeAuth 402

31.16 TPM2_NV_Certify 405

32 Attached Components 408

32.1 Introduction 408

32.2 TPM2_AC_GetCapability 409

32.3 TPM2_AC_Send 412

32.4 TPM2_Policy_AC_SendSelect 415

33 Authenticated Countdown Timer 418

33.1 Introduction 418

33.2 TPM2_ACT_SetTimeout 418

34 Vendor Specific 421

34.1 Introduction 421

34.2 TPM2_Vendor_TCG_Test 421

**Tables**

Table 1 — Command Modifiers and Decoration 2

Table 2 — Separators 3

Table 3 — Unmarshaling Errors 10

Table 4 — Command-Independent Response Codes 13

Table 5 — TPM2_Startup Command 22

Table 6 — TPM2_Startup Response 22

Table 7 — TPM2_Shutdown Command 25

Table 8 — TPM2_Shutdown Response 25

Table 9 — TPM2_SelfTest Command 29

Table 10 — TPM2_SelfTest Response 29

Table 11 — TPM2_IncrementalSelfTest Command 32

Table 12 — TPM2_IncrementalSelfTest Response 32

Table 13 — TPM2_GetTestResult Command 35

Table 14 — TPM2_GetTestResult Response 35

Table 15 — TPM2_StartAuthSession Command 39

Table 16 — TPM2_StartAuthSession Response 39

Table 17 — TPM2_PolicyRestart Command 42

Table 18 — TPM2_PolicyRestart Response 42

Table 19 — TPM2_Create Command 47

Table 20 — TPM2_Create Response 47

Table 21 — TPM2_Load Command 50

Table 22 — TPM2_Load Response 50

Table 23 — TPM2_LoadExternal Command 54

Table 24 — TPM2_LoadExternal Response 54

Table 25 — TPM2_ReadPublic Command 57

Table 26 — TPM2_ReadPublic Response 57

Table 27 — TPM2_ActivateCredential Command 60

Table 28 — TPM2_ActivateCredential Response 60

Table 29 — TPM2_MakeCredential Command 63

Table 30 — TPM2_MakeCredential Response 63

Table 31 — TPM2_Unseal Command 66

Table 32 — TPM2_Unseal Response 66

Table 33 — TPM2_ObjectChangeAuth Command 69

Table 34 — TPM2_ObjectChangeAuth Response 69

Table 35 — TPM2_CreateLoaded Command 72

Table 36 — TPM2_CreateLoaded Response 72

Table 37 — TPM2_Duplicate Command 75

Table 38 — TPM2_Duplicate Response 75

Table 39 — TPM2_Rewrap Command 78

Table 40 — TPM2_Rewrap Response 78

Table 41 — TPM2_Import Command 82

Table 42 — TPM2_Import Response 82

Table 43 — Padding Scheme Selection 84

Table 44 — Message Size Limits Based on Padding 85

Table 45 — TPM2_RSA_Encrypt Command 86

Table 46 — TPM2_RSA_Encrypt Response 86

Table 47 — TPM2_RSA_Decrypt Command 89

Table 48 — TPM2_RSA_Decrypt Response 89

Table 49 — TPM2_ECDH_KeyGen Command 92

Table 50 — TPM2_ECDH_KeyGen Response 92

Table 51 — TPM2_ECDH_ZGen Command 95

Table 52 — TPM2_ECDH_ZGen Response 95

Table 53 — TPM2_ECC_Parameters Command 98

Table 54 — TPM2_ECC_Parameters Response 98

Table 55 — TPM2_ZGen_2Phase Command 101

Table 56 — TPM2_ZGen_2Phase Response 101

Table 55 — TPM2_ECC_Encrypt Command 104

Table 55 — TPM2_ECC_Encrypt Response 104

Table 55 — TPM2_ECC \_Decrypt Command 107

Table 55 — TPM2_ECC_Decrypt Response 107

Table 57 — Symmetric Chaining Process 109

Table 58 — TPM2_EncryptDecrypt Command 111

Table 59 — TPM2_EncryptDecrypt Response 111

Table 60 — TPM2_EncryptDecrypt2 Command 114

Table 61 — TPM2_EncryptDecrypt2 Response 114

Table 62 — TPM2_Hash Command 117

Table 63 — TPM2_Hash Response 117

Table 64 — TPM2_HMAC Command 120

Table 65 — TPM2_HMAC Response 120

Table 66 — TPM2_MAC Command 123

Table 67 — TPM2_MAC Response 123

Table 68 — TPM2_GetRandom Command 126

Table 69 — TPM2_GetRandom Response 126

Table 70 — TPM2_StirRandom Command 129

Table 71 — TPM2_StirRandom Response 129

Table 72 — Hash Selection Matrix 131

Table 73 — TPM2_HMAC_Start Command 132

Table 74 — TPM2_HMAC_Start Response 132

Table 75 — Algorithm Selection Matrix 134

Table 76 — TPM2_MAC_Start Command 135

Table 77 — TPM2_MAC_Start Response 135

Table 78 — TPM2_HashSequenceStart Command 138

Table 79 — TPM2_HashSequenceStart Response 138

Table 80 — TPM2_SequenceUpdate Command 141

Table 81 — TPM2_SequenceUpdate Response 141

Table 82 — TPM2_SequenceComplete Command 144

Table 83 — TPM2_SequenceComplete Response 144

Table 84 — TPM2_EventSequenceComplete Command 147

Table 85 — TPM2_EventSequenceComplete Response 147

Table 86 — TPM2_Certify Command 152

Table 87 — TPM2_Certify Response 152

Table 88 — TPM2_CertifyCreation Command 155

Table 89 — TPM2_CertifyCreation Response 155

Table 90 — TPM2_Quote Command 158

Table 91 — TPM2_Quote Response 158

Table 92 — TPM2_GetSessionAuditDigest Command 161

Table 93 — TPM2_GetSessionAuditDigest Response 161

Table 94 — TPM2_GetCommandAuditDigest Command 164

Table 95 — TPM2_GetCommandAuditDigest Response 164

Table 96 — TPM2_GetTime Command 167

Table 97 — TPM2_GetTime Response 167

Table 98 — TPM2_CertifyX509 Command 170

Table 99 — TPM2_CertifyX509 Response 170

Table 100 — TPM2_Commit Command 174

Table 101 — TPM2_Commit Response 174

Table 102 — TPM2_EC_Ephemeral Command 177

Table 103 — TPM2_EC_Ephemeral Response 177

Table 104 — TPM2_VerifySignature Command 180

Table 105 — TPM2_VerifySignature Response 180

Table 106 — TPM2_Sign Command 183

Table 107 — TPM2_Sign Response 183

Table 108 — TPM2_SetCommandCodeAuditStatus Command 187

Table 109 — TPM2_SetCommandCodeAuditStatus Response 187

Table 110 — TPM2_PCR_Extend Command 191

Table 111 — TPM2_PCR_Extend Response 191

Table 112 — TPM2_PCR_Event Command 194

Table 113 — TPM2_PCR_Event Response 194

Table 114 — TPM2_PCR_Read Command 197

Table 115 — TPM2_PCR_Read Response 197

Table 116 — TPM2_PCR_Allocate Command 200

Table 117 — TPM2_PCR_Allocate Response 200

Table 118 — TPM2_PCR_SetAuthPolicy Command 203

Table 119 — TPM2_PCR_SetAuthPolicy Response 203

Table 120 — TPM2_PCR_SetAuthValue Command 206

Table 121 — TPM2_PCR_SetAuthValue Response 206

Table 122 — TPM2_PCR_Reset Command 209

Table 123 — TPM2_PCR_Reset Response 209

Table 124 — TPM2_PolicySigned Command 224

Table 125 — TPM2_PolicySigned Response 224

Table 126 — TPM2_PolicySecret Command 227

Table 127 — TPM2_PolicySecret Response 227

Table 128 — TPM2_PolicyTicket Command 230

Table 129 — TPM2_PolicyTicket Response 230

Table 130 — TPM2_PolicyOR Command 233

Table 131 — TPM2_PolicyOR Response 233

Table 132 — TPM2_PolicyPCR Command 237

Table 133 — TPM2_PolicyPCR Response 237

Table 134 — TPM2_PolicyLocality Command 240

Table 135 — TPM2_PolicyLocality Response 240

Table 136 — TPM2_PolicyNV Command 243

Table 137 — TPM2_PolicyNV Response 243

Table 138 — TPM2_PolicyCounterTimer Command 246

Table 139 — TPM2_PolicyCounterTimer Response 246

Table 140 — TPM2_PolicyCommandCode Command 249

Table 141 — TPM2_PolicyCommandCode Response 249

Table 142 — TPM2_PolicyPhysicalPresence Command 252

Table 143 — TPM2_PolicyPhysicalPresence Response 252

Table 144 — TPM2_PolicyCpHash Command 255

Table 145 — TPM2_PolicyCpHash Response 255

Table 146 — TPM2_PolicyNameHash Command 258

Table 147 — TPM2_PolicyNameHash Response 258

Table 148 — TPM2_PolicyDuplicationSelect Command 261

Table 149 — TPM2_PolicyDuplicationSelect Response 261

Table 150 — TPM2_PolicyAuthorize Command 264

Table 151 — TPM2_PolicyAuthorize Response 264

Table 152 — TPM2_PolicyAuthValue Command 267

Table 153 — TPM2_PolicyAuthValue Response 267

Table 154 — TPM2_PolicyPassword Command 270

Table 155 — TPM2_PolicyPassword Response 270

Table 156 — TPM2_PolicyGetDigest Command 273

Table 157 — TPM2_PolicyGetDigest Response 273

Table 158 — TPM2_PolicyNvWritten Command 276

Table 159 — TPM2_PolicyNvWritten Response 276

Table 160 — TPM2_PolicyTemplate Command 279

Table 161 — TPM2_PolicyTemplate Response 279

Table 162 — TPM2_PolicyAuthorizeNV Command 282

Table 163 — TPM2_PolicyAuthorizeNV Response 282

Table 164 — TPM2_CreatePrimary Command 285

Table 165 — TPM2_CreatePrimary Response 285

Table 166 — TPM2_HierarchyControl Command 288

Table 167 — TPM2_HierarchyControl Response 288

Table 168 — TPM2_SetPrimaryPolicy Command 291

Table 169 — TPM2_SetPrimaryPolicy Response 291

Table 170 — TPM2_ChangePPS Command 294

Table 171 — TPM2_ChangePPS Response 294

Table 172 — TPM2_ChangeEPS Command 297

Table 173 — TPM2_ChangeEPS Response 297

Table 174 — TPM2_Clear Command 300

Table 175 — TPM2_Clear Response 300

Table 176 — TPM2_ClearControl Command 303

Table 177 — TPM2_ClearControl Response 303

Table 178 — TPM2_HierarchyChangeAuth Command 306

Table 179 — TPM2_HierarchyChangeAuth Response 306

Table 180 — TPM2_DictionaryAttackLockReset Command 309

Table 181 — TPM2_DictionaryAttackLockReset Response 309

Table 182 — TPM2_DictionaryAttackParameters Command 312

Table 183 — TPM2_DictionaryAttackParameters Response 312

Table 184 — TPM2_PP_Commands Command 315

Table 185 — TPM2_PP_Commands Response 315

Table 186 — TPM2_SetAlgorithmSet Command 318

Table 187 — TPM2_SetAlgorithmSet Response 318

Table 188 — TPM2_FieldUpgradeStart Command 323

Table 189 — TPM2_FieldUpgradeStart Response 323

Table 190 — TPM2_FieldUpgradeData Command 326

Table 191 — TPM2_FieldUpgradeData Response 326

Table 192 — TPM2_FirmwareRead Command 329

Table 193 — TPM2_FirmwareRead Response 329

Table 194 — TPM2_ContextSave Command 332

Table 195 — TPM2_ContextSave Response 332

Table 196 — TPM2_ContextLoad Command 335

Table 197 — TPM2_ContextLoad Response 335

Table 198 — TPM2_FlushContext Command 338

Table 199 — TPM2_FlushContext Response 338

Table 200 — TPM2_EvictControl Command 342

Table 201 — TPM2_EvictControl Response 342

Table 202 — TPM2_ReadClock Command 345

Table 203 — TPM2_ReadClock Response 345

Table 204 — TPM2_ClockSet Command 348

Table 205 — TPM2_ClockSet Response 348

Table 206 — TPM2_ClockRateAdjust Command 351

Table 207 — TPM2_ClockRateAdjust Response 351

Table 208 — TPM2_GetCapability Command 357

Table 209 — TPM2_GetCapability Response 357

Table 210 — TPM2_TestParms Command 360

Table 211 — TPM2_TestParms Response 360

Table 212 — TPM2_NV_DefineSpace Command 367

Table 213 — TPM2_NV_DefineSpace Response 367

Table 214 — TPM2_NV_UndefineSpace Command 370

Table 215 — TPM2_NV_UndefineSpace Response 370

Table 216 — TPM2_NV_UndefineSpaceSpecial Command 373

Table 217 — TPM2_NV_UndefineSpaceSpecial Response 373

Table 218 — TPM2_NV_ReadPublic Command 376

Table 219 — TPM2_NV_ReadPublic Response 376

Table 220 — TPM2_NV_Write Command 379

Table 221 — TPM2_NV_Write Response 379

Table 222 — TPM2_NV_Increment Command 382

Table 223 — TPM2_NV_Increment Response 382

Table 224 — TPM2_NV_Extend Command 385

Table 225 — TPM2_NV_Extend Response 385

Table 226 — TPM2_NV_SetBits Command 388

Table 227 — TPM2_NV_SetBits Response 388

Table 228 — TPM2_NV_WriteLock Command 391

Table 229 — TPM2_NV_WriteLock Response 391

Table 230 — TPM2_NV_GlobalWriteLock Command 394

Table 231 — TPM2_NV_GlobalWriteLock Response 394

Table 232 — TPM2_NV_Read Command 397

Table 233 — TPM2_NV_Read Response 397

Table 234 — TPM2_NV_ReadLock Command 400

Table 235 — TPM2_NV_ReadLock Response 400

Table 236 — TPM2_NV_ChangeAuth Command 403

Table 237 — TPM2_NV_ChangeAuth Response 403

Table 238 — TPM2_NV_Certify Command 406

Table 239 — TPM2_NV_Certify Response 406

Table 240 — TPM2_AC_GetCapability Command 410

Table 241 — TPM2_AC_GetCapability Response 410

Table 242 — TPM2_AC_Send Command 413

Table 243 — TPM2_AC_Send Response 413

Table 244 — TPM2_Policy_AC_SendSelect Command 416

Table 245 — TPM2_Policy_AC_SendSelect Response 416

Table 246 — TPM2_ACT_SetTimeout Command 419

Table 247 — TPM2_ACT_SetTimeout Response 419

Table 248 — TPM2_Vendor_TCG_Test Command 422

Table 249 — TPM2_Vendor_TCG_Test Response 422

Trusted Platform Module Library

Part 3: Commands

# Scope

This TPM 2.0 Part 3 of the *Trusted Platform Module Library*
specification contains the definitions of the TPM commands. These
commands make use of the constants, flags, structures, and union
definitions defined in TPM 2.0 Part 2.

The detailed description of the operation of the commands is written in
the C language with extensive comments. The behavior of the C code in
this TPM 2.0 Part 3 is normative but does not fully describe the
behavior of a TPM. The combination of this TPM 2.0 Part 3 and TPM 2.0
Part 4 is sufficient to fully describe the required behavior of a TPM.

The code in parts 3 and 4 is written to define the behavior of a
compliant TPM. In some cases (e.g., firmware update), it is not possible
to provide a compliant implementation. In those cases, any
implementation provided by the vendor that meets the general description
of the function provided in TPM 2.0 Part 3 would be compliant.

The code in parts 3 and 4 is not written to meet any particular level of
conformance nor does this specification require that a TPM meet any
particular level of conformance.

# Terms and Definitions

For the purposes of this document, the terms and definitions given in
TPM 2.0 Part 1 apply.

# Symbols and abbreviated terms

For the purposes of this document, the symbols and abbreviated terms
given in TPM 2.0 Part 1 apply.

# Notation

## Introduction

For the purposes of this document, the notation given in TPM 2.0 Part 1
applies.

Command and response tables use various decorations to indicate the
fields of the command and the allowed types. These decorations are
described in this clause.

## Table Decorations

The symbols and terms in the Notation column of Table 1 are used in the
tables for the command schematics. These values indicate various
qualifiers for the parameters or descriptions with which they are
associated.

Table 1 — Command Modifiers and Decoration

<table>
<colgroup>
<col style="width: 13%" />
<col style="width: 86%" />
</colgroup>
<thead>
<tr class="header">
<th>Notation</th>
<th>Meaning</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>+</td>
<td><p>A Type decoration – When appended to a value in the Type column
of a command, this symbol indicates that the parameter is allowed to use
the “null” value of the data type (see in TPM 2.0 Part 2,
<em>Conditional Types</em>). The null value is usually TPM_RH_NULL for a
handle or TPM_ALG_NULL for an algorithm selector.</p>
<p>NOTE This decoration is not appended to response parameters.</p></td>
</tr>
<tr class="even">
<td>@</td>
<td>A Name decoration – When this symbol precedes a handle parameter in
the “Name” column, it indicates that an authorization session is
required for use of the entity associated with the handle. If a handle
does not have this symbol, then an authorization session is not
allowed.</td>
</tr>
<tr class="odd">
<td>+PP</td>
<td>A Description modifier – This modifier may follow TPM_RH_PLATFORM in
the “Description” column to indicate that Physical Presence is required
when <em>platformAuth</em>/<em>platformPolicy</em> is provided.</td>
</tr>
<tr class="even">
<td>+{PP}</td>
<td>A Description modifier – This modifier may follow TPM_RH_PLATFORM to
indicate that Physical Presence may be required when
<em>platformAuth</em>/<em>platformPolicy</em> is provided. The commands
with this notation may be in the <em>setList</em> or <em>clearList</em>
of TPM2_PP_Commands().</td>
</tr>
<tr class="odd">
<td>{NV}</td>
<td><p>A Description modifier – This modifier may follow the
<em>commandCode</em> in the “Description” column to indicate that the
command may result in an update of NV memory and be subject to rate
throttling by the TPM. If the command code does not have this notation,
then a write to NV memory does not occur as part of the command
actions.</p>
<p>NOTE Any command that uses authorization may cause a write to NV if
there is an authorization failure. A TPM may use the occasion of command
execution to update the NV copy of clock.</p></td>
</tr>
<tr class="even">
<td>{F}</td>
<td><p>A Description modifier – This modifier indicates that the
“flushed” attribute will be SET in the TPMA_CC for the command. The
modifier may follow the <em>commandCode</em> in the “Description” column
to indicate that any transient handle context used by the command will
be flushed from the TPM when the command completes. This may be combined
with the {NV} modifier but not with the {E} modifier.</p>
<p>EXAMPLE 1 {NV F}</p>
<p>EXAMPLE 2 TPM2_SequenceComplete() will flush the context associated
with the <em>sequenceHandle</em>.</p></td>
</tr>
<tr class="odd">
<td>{E}</td>
<td><p>A Description modifier – This modifier indicates that the
“extensive” attribute will be SET in the TPMA_CC for the command. This
modifier may follow the <em>commandCode</em> in the “Description” column
to indicate that the command may flush many objects and re-enumeration
of the loaded context likely will be required. This may be combined with
the {NV} modifier but not with the {F} modifier.</p>
<p>EXAMPLE 1 {NV E}</p>
<p>EXAMPLE 2 TPM2_Clear() will flush all contexts associated with the
Storage hierarchy and the Endorsement hierarchy.</p></td>
</tr>
<tr class="even">
<td>Auth Index:</td>
<td>A Description modifier – When a handle has a “@” decoration, the
“Description” column will contain an “Auth Index:” entry for the handle.
This entry indicates the number of the authorization session. The
authorization sessions associated with handles will occur in the session
area in the order of the handles with the “@” modifier. Sessions used
only for encryption/decryption or only for audit will follow the handles
used for authorization.</td>
</tr>
<tr class="odd">
<td>Auth Role:</td>
<td><p>A Description modifier – This will be in the “Description” column
of a handle with the “@” decoration. It may have a value of USER, ADMIN
or DUP.</p>
<p>If the handle has the Auth Role of USER and the handle is an Object,
the type of authorization is determined by the setting of
<em>userWithAuth</em> in the Object's attributes. If the handle is
TPM_RH_OWNER, TPM_RH_ENDORSEMENT, or TPM_RH_PLATFORM, operation is as if
<em>userWithAuth</em> is SET. If the handle references an NV Index, then
the allowed authorizations are determined by the settings of the
attributes of the NV Index as described in TPM 2.0 Part 2, "TPMA_NV (NV
Index Attributes)."</p>
<p>If the Auth Role is ADMIN and the handle is an Object, the type of
authorization is determined by the setting of <em>adminWithPolicy</em>
in the Object's attributes. If the handle is TPM_RH_OWNER,
TPM_RH_ENDORSEMENT, or TPM_RH_PLATFORM, operation is as if
<em>adminWithPolicy</em> is SET. If the handle is an NV index, operation
is as if <em>adminWithPolicy</em> is SET (see 5.6 e)2)).</p>
<p>If the DUP role is selected, authorization may only be with a policy
session (DUP role only applies to Objects).</p>
<p>When either ADMIN or DUP role is selected, a policy command that
selects the command being authorized is required to be part of the
policy.</p>
<p>EXAMPLE TPM2_Certify requires the ADMIN role for the first handle
(<em>objectHandle</em>). The policy authorization for objectHandle is
required to contain TPM2_PolicyCommandCode(<em>commandCode</em> ==
TPM_CC_Certify). This sets the state of the policy so that it can be
used for ADMIN role authorization in TPM2_Certify().</p></td>
</tr>
</tbody>
</table>

## Handle and Parameter Demarcation

The demarcations between the header, handle, and parameter parts are
indicated by:

Table 2 — Separators

|     | Separator |     | Meaning                                                    |
|-----|-----------|-----|------------------------------------------------------------|
|     |           |     | the values immediately following are in the handle area    |
|     |           |     |                                                            |
|     |           |     | the values immediately following are in the parameter area |
|     |           |     |                                                            |

## AuthorizationSize and ParameterSize

Authorization sessions are not shown in the command or response
schematics. When the tag of a command or response is TPM_ST_SESSIONS,
then a 32-bit value will be present in the command/response buffer to
indicate the size of the authorization field or the parameter field.
This value shall immediately follow the handle area (which may contain
no handles). For a command, this value (*authorizationSize*) indicates
the size of the Authorization Area and shall have a value of 9 or more.
For a response, this value (*parameterSize*) indicates the size of the
parameter area and may have a value of zero.

If the *authorizationSize* field is present in the command,
*parameterSize* will be present in the response, but only if the
*responseCode* is TPM_RC_SUCCESS.

When authorization is required to use the TPM entity associated with a
handle, then at least one session will be present. To indicate this, the
command *tag* Description field contains TPM_ST_SESSIONS. Addional
sessions for audit, encrypt, and decrypt may be present.

When the command *tag* Description field contains TPM_ST_NO_SESSIONS,
then no sessions are allowed and the *authorizationSize* field is not
present.

When a command allows use of sessions when not required, the command
*tag* Description field will indicate the types of sessions that may be
used with the command.

## Return Code Alias

For the RC_FMT1 return codes that may add a parameter, handle, or
session number, the prefix TPM_RCS\_ is an alias for TPM_RC\_.

TPM_RC_n is added, where n is the parameter, handle, or session number.
In addition, TPM_RC_H is added for handle, TPM_RC_P for parameter, and
TPM_RC_S for session errors.

> NOTE TPM_RCS\_ is a programming convention. Programmers should only
> add numbers to TPM_RCS\_ return codes, never TPM_RC\_ return codes.
> Only return codes that can have a number added have the TPM_RCS\_
> alias defined. Attempting to use a TPM_RCS\_ return code that does not
> have the TPM_RCS\_ alias will cause a compiler error.
>
> EXAMPLE 1 Since TPM_RC_VALUE can have a number added, TPM_RCS_VALUE is
> defined. A program can use the construct "TPM_RCS_VALUE + number".
> Since TPM_RC_SIGNATURE cannot have a number added, TPM_RCS_SIGNATURE
> is not defined. A program using the construct "TPM_RCS_SIGNATURE +
> number" will not compile, alerting the programmer that the construct
> is incorrect.

By convention, the number to be added is of the form
RC_CommandName_ParameterName where CommmandName is the name of the
command with the TPM2\_ prefix removed. The parameter name alone is
insufficient because the same parameter name could be in a different
position in different commands.

> EXAMPLE 2 TPM2_HMAC_Start with parameters that result in TPM_ALG_NULL
> as the hash algorithm will returns TPM_RC_VALUE plus the parameter
> number. Since *hashAlg* is the second parameter, This code results:
>
> \#define RC_HMAC_Start_hashAlg (TPM_RC_P + TPM_RC_2)
>
> return TPM_RCS_VALUE + RC_HMAC_Start_hashAlg;

# Command Processing

## Introduction

This clause defines the command validations that are required of any
implementation and the response code returned if the indicated check
fails. Unless stated otherwise, the order of the checks is not normative
and different TPM may give different responses when a command has
multiple errors.

In the description below, some statements that describe a check may be
followed by a response code in parentheses. This is the normative
response code should the indicated check fail. A normative response code
may also be included in the statement.

## Command Header Validation

Before a TPM may begin the actions associated with a command, a set of
command format and consistency checks shall be performed. These checks
are listed below and should be performed in the indicated order.

1)  The TPM shall successfully unmarshal a TPMI_ST_COMMAND_TAG and
    verify that it is either TPM_ST_SESSIONS or TPM_ST_NO_SESSIONS
    (TPM_RC_BAD_TAG).

2)  The TPM shall successfully unmarshal a UINT32 as the *commandSize*.
    If the TPM has an interface buffer that is loaded by some hardware
    process, the number of octets in the input buffer for the command
    reported by the hardware process shall exactly match the value in
    *commandSize* (TPM_RC_COMMAND_SIZE).

> NOTE A TPM may have direct access to system memory and unmarshal
> directly from that memory.

3)  The TPM shall successfully unmarshal a TPM_CC and verify that the
    command is implemented (TPM_RC_COMMAND_CODE).

## Mode Checks

The following mode checks shall be performed in the order listed:

1)  If the TPM is in Failure mode, then the *commandCode* is
    TPM_CC_GetTestResult or TPM_CC_GetCapability (TPM_RC_FAILURE) and
    the command *tag* is TPM_ST_NO_SESSIONS (TPM_RC_FAILURE).

> NOTE 1 In Failure mode, the TPM has no cryptographic capability and
> processing of sessions is not supported.

4)  The TPM is in Field Upgrade mode (FUM), the *commandCode* is
    TPM_CC_FieldUpgradeData (TPM_RC_UPGRADE).

5)  If the TPM has not been initialized (TPM2_Startup()), then the
    *commandCode* is TPM_CC_Startup (TPM_RC_INITIALIZE).

> NOTE 2 The TPM may enter Failure mode during \_TPM_Init processing,
> before TPM2_Startup(). Since the platform firmware cannot know that
> the TPM is in Failure mode without accessing it, and since the first
> command is required to be TPM2_Startup(), the expected sequence will
> be that platform firmware (the CRTM) will issue TPM2_Startup() and
> receive TPM_RC_FAILURE indicating that the TPM is in Failure mode.
>
> There may be failures where a TPM cannot record that it received
> TPM2_Startup(). In those cases, a TPM in failure mode may process
> TPM2_GetTestResult(), TPM2_GetCapability(), or the field upgrade
> commands. As a side effect, that TPM may process TPM2_GetTestResult(),
> TPM2_GetCapability() or the field upgrade commands before
> TPM2_Startup().
>
> This is a corner case exception to the rule that TPM2_Startup() must
> be the first command.

The mode checks may be performed before or after the command header
validation.

## Handle Area Validation

After successfully unmarshaling and validating the command header, the
TPM shall perform the following checks on the handles and sessions.
These checks may be performed in any order.

NOTE 1 A TPM is required to perform the handle area validation before
the authorization checks because an authorization cannot be performed
unless the authorization values and attributes for the referenced entity
are known by the TPM. For them to be known, the referenced entity must
be in the TPM and accessible.

1)  The TPM shall successfully unmarshal the number of handles required
    by the command and validate that the value of the handle is
    consistent with the command syntax. If not, the TPM shall return
    TPM_RC_VALUE.

> NOTE 2 The TPM may unmarshal a handle and validate that it references
> an entity on the TPM before unmarshaling a subsequent handle.
>
> NOTE 3 If the submitted command contains fewer handles than required
> by the syntax of the command, the TPM may continue to read into the
> next area and attempt to interpret the data as a handle.

6)  For all handles in the handle area of the command, the TPM will
    validate that the referenced entity is present in the TPM.

7)  If the handle references a transient object, the handle shall
    reference a loaded object (TPM_RC_REFERENCE_H0 + N where N is the
    number of the handle in the command).

> NOTE 4 If the hierarchy for a transient object is disabled, then the
> transient objects will be flushed so this check will fail.

8)  If the handle references a persistent object, then

9)  the hierarchy associated with the object (platform or storage, based
    on the handle value) is enabled (TPM_RC_HANDLE);

10) the handle shall reference a persistent object that is currently in
    TPM non-volatile memory (TPM_RC_HANDLE);

11) if the handle references a persistent object that is associated with
    the endorsement hierarchy, that the endorsement hierarchy is not
    disabled (TPM_RC_HANDLE); and

> NOTE 5 The reference implementation keeps an internal attribute,
> passed down from a primary key to its descendents, indicating the
> object's hierarchy.

12) if the TPM implementation moves a persistent object to RAM for
    command processing then sufficient RAM space is available
    (TPM_RC_OBJECT_MEMORY).

13) If the handle references an NV Index, then

14) an Index exists that corresponds to the handle (TPM_RC_HANDLE); and

15) the hierarchy associated with the existing NV Index is not disabled
    (TPM_RC_HANDLE).

16) If the command requires write access to the index data then
    TPMA_NV_WRITELOCKED is not SET (TPM_RC_NV_LOCKED)

17) If the command requires read access to the index data then
    TPMA_NV_READLOCKED is not SET (TPM_RC_NV_LOCKED)

18) If the handle references a session, then the session context shall
    be present in TPM memory (TPM_RC_REFERENCE_H0 + N).

19) If the handle references a primary seed for a hierarchy
    (TPM_RH_ENDORSEMENT, TPM_RH_OWNER, or TPM_RH_PLATFORM) then the
    enable for the hierarchy is SET (TPM_RC_HIERARCHY).

20) If the handle references a PCR, then the value is within the range
    of PCR supported by the TPM (TPM_RC_VALUE)

> NOTE 6 In the reference implementation, this TPM_RC_VALUE is returned
> by the unmarshaling code for a TPMI_DH_PCR.

## Session Area Validation

1)  If the tag is TPM_ST_SESSIONS and the command requires
    TPM_ST_NO_SESSIONS, the TPM will return TPM_RC_AUTH_CONTEXT.

2)  If the tag is TPM_ST_NO_SESSIONS and the command requires
    TPM_ST_SESSIONS, the TPM will return TPM_RC_AUTH_MISSING.

<!-- -->

21) If the tag is TPM_ST_SESSIONS, the TPM will attempt to unmarshal an
    *authorizationSize* and return TPM_RC_AUTHSIZE if the value is not
    within an acceptable range.

22) The minimum value is (sizeof(TPM_HANDLE) + sizeof(UINT16) +
    sizeof(TPMA_SESSION) + sizeof(UINT16)).

23) The maximum value of authorizationSize is equal to commandSize –
    (sizeof(TPM_ST) + sizeof(UINT32) + sizeof(TPM_CC) + (N \*
    sizeof(TPM_HANDLE)) + sizeof(UINT32)) where N is the number of
    handles associated with the *commandCode* and may be zero.

> NOTE 1 (sizeof(TPM_ST) + sizeof(UINT32) + sizeof(TPM_CC)) is the size
> of a command header. The last UINT32 contains the authorizationSize
> octets, which are not counted as being in the authorization session
> area.

24) The TPM will unmarshal the authorization sessions and perform the
    following validations:

25) If the session handle is not a handle for an HMAC session, a handle
    for a policy session, or, TPM_RS_PW then the TPM shall return
    TPM_RC_HANDLE.

26) If the session is not loaded, the TPM will return the warning
    TPM_RC_REFERENCE_S0 + N where N is the number of the session. The
    first session is session zero, N = 0.

> NOTE 2 If the HMAC and policy session contexts use the same memory,
> the type of the context must match the type of the handle.

27) If the maximum allowed number of sessions have been unmarshaled and
    fewer octets than indicated in *authorizationSize* were unmarshaled
    (that is, *authorizationSize* is too large), the TPM shall return
    TPM_RC_AUTHSIZE.

28) The consistency of the authorization session attributes is checked.

29) Only one session is allowed for:

    1.  session auditing (TPM_RC_ATTRIBUTES) – this session may be used
        for encrypt or decrypt but may not be a session that is also
        used for authorization;

    2.  decrypting a command parameter (TPM_RC_ATTRIBUTES) – this may be
        any of the authorization sessions, or the audit session, or a
        session may be added for the single purpose of decrypting a
        command parameter, as long as the total number of sessions does
        not exceed three; and

    3.  encrypting a response parameter (TPM_RC_ATTRIBUTES) – this may
        be any of the authorization sessions, or the audit session if
        present, ora session may be added for the single purpose of
        encrypting a response parameter, as long as the total number of
        sessions does not exceed three.

> NOTE 3 A session used for decrypting a command parameter may also be
> used for encrypting a response parameter.

30) If a session is not being used for authorization, at least one of
    decrypt, encrypt, or audit must be SET. (TPM_RC_ATTRIBUTES).

31) An authorization session is present for each of the handles with the
    “@” decoration (TPM_RC_AUTH_MISSING).

## Authorization Checks

After unmarshaling and validating the handles and the consistency of the
authorization sessions, the authorizations shall be checked.
Authorization checks only apply to handles if the handle in the command
schematic has the “@” decoration. Authorization checks must be performed
in this order.

1)  The public and sensitive portions of the object shall be present on
    the TPM (TPM_RC_AUTH_UNAVAILABLE).

<!-- -->

32) If the associated handle is TPM_RH_PLATFORM, and the command
    requires confirmation with physical presence, then physical presence
    is asserted (TPM_RC_PP).

33) If the object or NV Index is subject to DA protection, and the
    authorization is with an HMAC or password, then the TPM is not in
    lockout (TPM_RC_LOCKOUT).

> NOTE 1 An object is subject to DA protection if its *noDA* attribute
> is CLEAR. An NV Index is subject to DA protection if its TPMA_NV_NO_DA
> attribute is CLEAR.
>
> NOTE 2 An HMAC or password is required in a policy session when the
> policy contains TPM2_PolicyAuthValue() or TPM2_PolicyPassword().

34) If the command requires a handle to have DUP role authorization,
    then the associated authorization session is a policy session
    (TPM_RC_AUTH_TYPE).

35) If the command requires a handle to have ADMIN role authorization:

36) If the entity being authorized is an object and its
    *adminWithPolicy* attribute is SET, or a hierarchy, then the
    authorization session is a policy session (TPM_RC_AUTH_TYPE).

> NOTE 3 If adminWithPolicy is CLEAR, then any type of authorization
> session is allowed.

37) If the entity being authorized is an NV Index, then the associated
    authorization session is a policy session.

> NOTE 4 The only commands that are currently defined that require use
> of ADMIN role authorization are commands that operate on objects and
> NV Indices.

38) If the command requires a handle to have USER role authorization:

39) If the entity being authorized is an object and its *userWithAuth*
    attribute is CLEAR, then the associated authorization session is a
    policy session (TPM_RC_POLICY_FAIL).

> NOTE 5 There is no check for a hierarchy, because a hierarchy operates
> as if userWithAuth is SET.

40) If the entity being authorized is an NV Index;

41) if the authorization session is a policy session;

    1.  the TPMA_NV_POLICYWRITE attribute of the NV Index is SET if the
        command modifies the NV Index data (TPM_RC_AUTH_UNAVAILABLE);

    2.  the TPMA_NV_POLICYREAD attribute of the NV Index is SET if the
        command reads the NV Index data (TPM_RC_AUTH_UNAVAILABLE);

42) if the authorization is an HMAC session or a password;

    1.  the TPMA_NV_AUTHWRITE attribute of the NV Index is SET if the
        command modifies the NV Index data (TPM_RC_AUTH_UNAVAILABLE);

    2.  the TPMA_NV_AUTHREAD attribute of the NV Index is SET if the
        command reads the NV Index data (TPM_RC_AUTH_UNAVAILABLE).

43) If the authorization is provided by a policy session, then:

44) if *policySession*→*timeOut* has been set, the session shall not
    have expired (TPM_RC_EXPIRED);

45) if *policySession*→*cpHash* has been set, it shall match the
    *cpHash* of the command (TPM_RC_POLICY_FAIL);

46) if *policySession*→*commandCode* has been set, then *commandCode* of
    the command shall match (TPM_RC_POLICY_CC);

47) *policySession*→*policyDigest* shall match the *authPolicy*
    associated with the handle (TPM_RC_POLICY_FAIL);

48) if *policySession*→*pcrUpdateCounter* has been set, then it shall
    match the value of *pcrUpdateCounter* (TPM_RC_PCR_CHANGED);

49) if *policySession*→*commandLocality* has been set, it shall match
    the locality of the command (TPM_RC_LOCALITY),

50) if *policySession→cpHash* contains a template, and the command is
    TPM2_Create(), TPM2_CreatePrimary(), or TPM2_CreateLoaded(), then
    the *inPublic* parmeter matches the contents of
    *policySession→cpHash;* and

51) if the policy requires that an authValue be provided in order to
    satisfy the policy, then *session.hmac* is not an Empty Buffer.

52) If the authorization uses an HMAC, then the HMAC is properly
    constructed using the *authValue* associated with the handle and/or
    the session secret (TPM_RC_AUTH_FAIL or TPM_RC_BAD_AUTH).

> NOTE 6 A policy session may require proof of knowledge of the
> authValue of the object being authorized.

53) If the authorization uses a password, then the password matches the
    *authValue* associated with the handle (TPM_RC_AUTH_FAIL or
    TPM_RC_BAD_AUTH).

If the TPM returns an error other than TPM_RC_AUTH_FAIL then the TPM
shall not alter any TPM state. If the TPM return TPM_RC_AUTH_FAIL, then
the TPM shall not alter any TPM state other than *lockoutCount*.

NOTE 7 The TPM may decrease failedTries regardless of any other
processing performed by the TPM. That is, the TPM may exit Lockout mode,
regardless of the return code.

## Parameter Decryption

If an authorization session has the TPMA_SESSION.*decrypt* attribute
SET, and the command does not allow a command parameter to be encrypted,
then the TPM will return TPM_RC_ATTRIBUTES. Otherwise, the TPM will
decrypt the parameter using the values associated with the session
before parsing parameters.

NOTE The size of the parameter to be encrypted can be zero.

## Parameter Unmarshaling

### Introduction

The detailed actions for each command assume that the input parameters
of the command have been unmarshaled into a command-specific structure
with the structure defined by the command schematic. Additionally, a
response-specific output structure is assumed which will receive the
values produced by the detailed actions.

NOTE An implementation is not required to process parameters in this
manner or to separate the parameter parsing from the command actions.
This method was chosen for the specification so that the normative
behavior described by the detailed actions would be clear and
unencumbered.

Unmarshaling is the process of processing the parameters in the input
buffer and preparing the parameters for use by the command-specific
action code. No data movement need take place but it is required that
the TPM validate that the parameters meet the requirements of the
expected data type as defined in TPM 2.0 Part 2.

### Unmarshaling Errors

When an error is encountered while unmarshaling a command parameter, an
error response code is returned and no command processing occurs. A
table defining a data type may have response codes embedded in the table
to indicate the error returned when the input value does not match the
parameters of the table.

NOTE In the reference implementation, a parameter number is added to the
response code so that the offending parameter can be isolated. This is
optional.

In many cases, the table contains no specific response code value and
the return code will be determined as defined in Table 3.

Table 3 — Unmarshaling Errors

| Response Code       | Meaning                                                                                                               |
|---------------------|-----------------------------------------------------------------------------------------------------------------------|
| TPM_RC_ASYMMETRIC   | a parameter that should be an asymmetric algorithm selection does not have a value that is supported by the TPM       |
| TPM_RC_BAD_TAG      | a parameter that should be a command tag selection has a value that is not supported by the TPM                       |
| TPM_RC_COMMAND_CODE | a parameter that should be a command code does not have a value that is supported by the TPM                          |
| TPM_RC_HASH         | a parameter that should be a hash algorithm selection does not have a value that is supported by the TPM              |
| TPM_RC_INSUFFICIENT | the input buffer did not contain enough octets to allow unmarshaling of the expected data type;                       |
| TPM_RC_KDF          | a parameter that should be a key derivation scheme (KDF) selection does not have a value that is supported by the TPM |
| TPM_RC_KEY_SIZE     | a parameter that is a key size has a value that is not supported by the TPM                                           |
| TPM_RC_MODE         | a parameter that should be a symmetric encryption mode selection does not have a value that is supported by the TPM   |
| TPM_RC_RESERVED     | a non-zero value was found in a reserved field of an attribute structure (TPMA\_)                                     |
| TPM_RC_SCHEME       | a parameter that should be signing or encryption scheme selection does not have a value that is supported by the TPM  |
| TPM_RC_SIZE         | the value of a size parameter is larger or smaller than allowed                                                       |
| TPM_RC_SYMMETRIC    | a parameter that should be a symmetric algorithm selection does not have a value that is supported by the TPM         |
| TPM_RC_TAG          | a parameter that should be a structure tag has a value that is not supported by the TPM                               |
| TPM_RC_TYPE         | The type parameter of a TPMT_PUBLIC or TPMT_SENSITIVE has a value that is not supported by the TPM                    |
| TPM_RC_VALUE        | a parameter does not have one of its allowed values                                                                   |

In some commands, a parameter may not be used because of various options
of that command. However, the unmarshaling code is required to validate
that all parameters have values that are allowed by the TPM 2.0 Part 2
definition of the parameter type even if that parameter is not used in
the command actions.

## Command Post Processing

When the code that implements the detailed actions of the command
completes, it returns a response code. If that code is not
TPM_RC_SUCCESS, the post processing code will not update any session or
audit data and will return a 10-octet response packet.

If the command completes successfully, the tag of the command determines
if any authorization sessions will be in the response. If so, the TPM
will encrypt the first parameter of the response if indicated by the
authorization attributes. The TPM will then generate a new nonce value
for each session and, if appropriate, generate an HMAC.

If authorization HMAC computations are performed on the response, the
HMAC keys used in the response will be the same as the HMAC keys used in
processing the HMAC in the command.

NOTE 1 This primarily affects authorizations associated with a first
write to an NV Index using a bound session. The computation of the HMAC
in the response is performed as if the Name of the Index did not change
as a consequence of the command actions. The session binding to the NV
Index will not persist to any subsequent command.

NOTE 2 The authorization attributes were validated during the session
area validation to ensure that only one session was used for parameter
encryption of the response and that the command allowed encryption in
the response.

NOTE 3 No session nonce value is used for a password authorization but
the session data is present.

Additionally, if the command is being audited by Command Audit, the
audit digest is updated with the *cpHash* of the command and *rpHash* of
the response.

# Response Values

## Tag

When a command completes successfully, the *tag* parameter in the
response shall have the same value as the *tag* parameter in the command
(TPM_ST_SESSIONS or TPM_ST_NO_SESSIONS). When a command fails (the
responseCode is not TPM_RC_SUCCESS), then the *tag* parameter in the
response shall be TPM_ST_NO_SESSIONS.

A special case exists when the command *tag* parameter is not an allowed
value (TPM_ST_SESSIONS or TPM_ST_NO_SESSIONS). For this case, it is
assumed that the system software is attempting to send a command
formatted for a TPM 1.2 but the TPM is not capable of executing TPM 1.2
commands. So that the TPM 1.2 compatible software will have a
recognizable response, the TPM sets *tag* to TPM_ST_RSP_COMMAND,
*responseSize* to 00 00 00 0A<sub>16</sub> and *responseCode* to
TPM_RC_BAD_TAG. This is the same response as the TPM 1.2 fatal error for
TPM_BADTAG.

## Response Codes

The normal response for any command is TPM_RC_SUCCESS. Any other value
indicates that the command did not complete and the state of the TPM is
unchanged. An exception to this general rule is that the logic
associated with dictionary attack protection is allowed to be modified
when an authorization failure occurs.

Commands have response codes that are specific to that command, and
those response codes are enumerated in the detailed actions of each
command. The codes associated with the unmarshaling of parameters are
documented Table 3. Another set of response code values are not command
specific and indicate a problem that is not specific to the command.
That is, if the indicated problem is remedied, the same command could be
resubmitted and may complete normally.

The response codes that are not command specific are listed and
described in Table 4.

The reference code for the command actions may have code that generates
specific response codes associated with a specific check but the listing
of responses may not have that response code listed.

Table 4 — Command-Independent Response Codes

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 70%" />
</colgroup>
<thead>
<tr class="header">
<th>Response Code</th>
<th>Meaning</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>TPM_RC_CANCELED</td>
<td>This response code may be returned by a TPM that supports command
cancel. When the TPM receives an indication that the current command
should be cancelled, the TPM may complete the command or return this
code. If this code is returned, then the TPM state is not changed and
the same command may be retried.</td>
</tr>
<tr class="even">
<td>TPM_RC_CONTEXT_GAP</td>
<td>This response code can be returned for commands that manage session
contexts. It indicates that the gap between the lowest numbered active
session and the highest numbered session is at the limits of the session
tracking logic. The remedy is to load the session context with the
lowest number so that its tracking number can be updated.</td>
</tr>
<tr class="odd">
<td>TPM_RC_LOCKOUT</td>
<td>This response indicates that authorizations for objects subject to
DA protection are not allowed at this time because the TPM is in DA
lockout mode. The remedy is to wait or to exeucte
TPM2_DictionaryAttackLockoutReset().</td>
</tr>
<tr class="even">
<td>TPM_RC_MEMORY</td>
<td>A TPM may use a common pool of memory for objects, sessions, and
other purposes. When the TPM does not have enough memory available to
perform the actions of the command, it may return TPM_RC_MEMORY. This
indicates that the TPM resource manager may flush either sessions or
objects in order to make memory available for the command execution. A
TPM may choose to return TPM_RC_OBJECT_MEMORY or TPM_RC_SESSION_MEMORY
if it needs contexts of a particular type to be flushed.</td>
</tr>
<tr class="odd">
<td>TPM_RC_NV_RATE</td>
<td>This response code indicates that the TPM is rate-limiting writes to
the NV memory in order to prevent wearout. This response is possible for
any command that explicity writes to NV or commands that incidentally
use NV such as a command that uses authorization session that may need
to update the dictionary attack logic.</td>
</tr>
<tr class="even">
<td>TPM_RC_NV_UNAVAILABLE</td>
<td>This response code is similar to TPM_RC_NV_RATE but indicates that
access to NV memory is currently not available and the command is not
allowed to proceed until it is. This would occur in a system where the
NV memory used by the TPM is not exclusive to the TPM and is a shared
system resource.</td>
</tr>
<tr class="odd">
<td>TPM_RC_OBJECT_HANDLES</td>
<td>This response code indicates that the TPM has exhausted its handle
space and no new objects can be loaded unless the TPM is rebooted. This
does not occur in the reference implementation because of the way that
object handles are allocated. However, other implementations are allowed
to assign each object a unique handle each time the object is loaded. A
TPM using this implementation would be able to load 2<sup>24</sup>
objects before the object space is exhausted.</td>
</tr>
<tr class="even">
<td>TPM_RC_OBJECT_MEMORY</td>
<td>This response code can be returned by any command that causes the
TPM to need an object 'slot'. The most common case where this might be
returned is when an object is loaded (TPM2_Load, TPM2_CreatePrimary(),
or TPM2_ContextLoad()). However, the TPM implementation is allowed to
use object slots for other reasons. In the reference implementation, the
TPM copies a referenced persistent object into RAM for the duration of
the commannd. If all the slots are previously occupied, the TPM may
return this value. A TPM is allowed to use object slots for other
purposes and return this value. The remedy when this response is
returned is for the TPM resource manager to flush a transient
object.</td>
</tr>
<tr class="odd">
<td>TPM_RC_REFERENCE_Hx</td>
<td><p>This response code indicates that a handle in the handle area of
the command is not associated with a loaded object. The value of 'x' is
in the range 0 to 6 with a value of 0 indicating the 1<sup>st</sup>
handle and 6 representing the 7<sup>th</sup>. Upper values are provided
for future use. The TPM resource manager needs to find the correct
object and load it. It may then adjust the handle and retry the
command.</p>
<p>NOTE Usually, this error indicates that the TPM resource manager has
a corrupted database.</p></td>
</tr>
<tr class="even">
<td>TPM_RC_REFERENCE_Sx</td>
<td><p>This response code indicates that a handle in the session area of
the command is not associated with a loaded session. The value of 'x' is
in the range 0 to 6 with a value of 0 indicating the 1<sup>st</sup>
session handle and 6 representing the 7<sup>th</sup>. Upper values are
provided for future use. The TPM resource manager needs to find the
correct session and load it. It may then retry the command.</p>
<p>NOTE Usually, this error indicates that the TPM resource manager has
a corrupted database.</p></td>
</tr>
<tr class="odd">
<td>TPM_RC_RETRY</td>
<td>the TPM was not able to start the command</td>
</tr>
<tr class="even">
<td>TPM_RC_SESSION_HANDLES</td>
<td>This response code indicates that the TPM does not have a handle to
assign to a new session. This respose is only returned by
TPM2_StartAuthSession(). It is listed here because the command is not in
error and the TPM resource manager can remedy the situation by flushing
a session (TPM2_FlushContext().</td>
</tr>
<tr class="odd">
<td>TPM_RC_SESSION_MEMORY</td>
<td>This response code can be returned by any command that causes the
TPM to need a session 'slot'. The most common case where this might be
returned is when a session is loaded (TPM2_StartAuthSession() or
TPM2_ContextLoad()). However, the TPM implementation is allowed to use
object slots for other purposes. The remedy when this response is
returned is for the TPM resource manager to flush a transient
object.</td>
</tr>
<tr class="even">
<td>TPM_RC_SUCCESS</td>
<td>Normal completion for any command. If the responseCode is
TPM_RC_SUCCESS, then the rest of the response has the format indicated
in the response schematic. Otherwise, the response is a 10 octet value
indicating an error.</td>
</tr>
<tr class="odd">
<td>TPM_RC_TESTING</td>
<td>This response code indicates that the TPM is performing tests and
cannot respond to the request at this time. The command may be
retried.</td>
</tr>
<tr class="even">
<td>TPM_RC_YIELDED</td>
<td><p>the TPM has suspended operation on the command; forward progress
was made and the command may be retried.</p>
<p>See TPM 2.0 Part 1, “Multi-tasking.”</p>
<p>NOTE This cannot occur on the reference implementation.</p></td>
</tr>
</tbody>
</table>

# Implementation Dependent

The actions code for each command makes assumptions about the behavior
of various sub-systems. There are many possible implementations of the
subsystems that would achieve equivalent results. The actions code is
not written to anticipate all possible implementations of the
sub-systems. Therefore, it is the responsibility of the implementer to
ensure that the necessary changes are made to the actions code when the
sub-system behavior changes.

# Detailed Actions Assumptions

## Introduction

The C code in the Detailed Actions for each command is written with a
set of assumptions about the processing performed before the action code
is called and the processing that will be done after the action code
completes.

## Pre-processing

Before calling the command actions code, the following actions have
occurred.

- Verification that the handles in the handle area reference entities
  that are resident on the TPM.

- NOTE If a handle is in the parameter portion of the command, the
  associated entity does not have to be loaded, but the handle is
  required to be the correct type.

- If use of a handle requires authorization, the Password, HMAC, or
  Policy session associated with the handle has been verified.

- If a command parameter was encrypted using parameter encryption, it
  was decrypted before being unmarshaled.

- If the command uses handles or parameters, the calling stack contains
  a pointer to a data structure (*in*) that holds the unmarshaled values
  for the handles and command parameters. If the response has handles or
  parameters, the calling stack contains a pointer to a data structure
  (*out*) to hold the handles and response parameters generated by the
  command.

- All parameters of the *in* structure have been validated and meet the
  requirements of the parameter type as defined in TPM 2.0 Part 2.

- Space set aside for the out structure is sufficient to hold the
  largest *out* structure that could be produced by the command

## Post Processing

When the function implementing the command actions completes,

- response parameters that require parameter encryption will be
  encrypted after the command actions complete;

- audit and session contexts will be updated if the command response is
  TPM_RC_SUCCESS; and

- the command header and command response parameters will be marshaled
  to the response buffer.

# Start-up

## Introduction

This clause contains the commands used to manage the startup and restart
state of a TPM.

## \_TPM_Init

### General Description

\_TPM_Init initializes a TPM.

Initialization actions include testing code required to execute the next
expected command. If the TPM is in FUM, the next expected command is
TPM2_FieldUpgradeData(); otherwise, the next expected command is
TPM2_Startup().

NOTE 1 If the TPM performs self-tests after receiving \_TPM_Init() and
the TPM enters Failure mode before receiving TPM2_Startup() or
TPM2_FieldUpgradeData(), then the TPM may be able to accept
TPM2_GetTestResult() or TPM2_GetCapability().

The means of signaling \_TPM_Init shall be defined in the
platform-specific specifications that define the physical interface to
the TPM. The platform shall send this indication whenever the platform
starts its boot process and only when the platform starts its boot
process.

There shall be no software method of generating this indication that
does not also reset the platform and begin execution of the CRTM.

NOTE 2 In the reference implementation, this signal causes an internal
flag (*s_initialized*) to be CLEAR. While this flag is CLEAR, the TPM
will only accept the next expected command described above.

### Detailed Actions

\[\[\_TPM_Init\]\]

## TPM2_Startup

### General Description

TPM2_Startup() is always preceded by \_TPM_Init, which is the physical
indication that TPM initialization is necessary because of a system-wide
reset. TPM2_Startup() is only valid after \_TPM_Init. Additional
TPM2_Startup() commands are not allowed after it has completed
successfully. If a TPM requires TPM2_Startup() and another command is
received, or if the TPM receives TPM2_Startup() when it is not required,
the TPM shall return TPM_RC_INITIALIZE.

NOTE 1 See 9.2.1 for other command options for a TPM supporting field
upgrade mode.

NOTE 2 \_TPM_Hash_Start, \_TPM_Hash_Data, and \_TPM_Hash_End are not
commands and a platform-specific specification may allow these
indications between \_TPM_Init and TPM2_Startup().

If in Failure mode, the TPM shall accept TPM2_GetTestResult() and
TPM2_GetCapability() even if TPM2_Startup() is not completed
successfully or processed at all.

A platform-specific specification may restrict the localities at which
TPM2_Startup() may be received.

A Shutdown/Startup sequence determines the way in which the TPM will
operate in response to TPM2_Startup(). The three sequences are:

1)  TPM Reset – This is a Startup(CLEAR) preceded by either
    Shutdown(CLEAR) or no TPM2_Shutdown(). On TPM Reset, all variables
    go back to their default initialization state.

> NOTE 3 Only those values that are specified as having a default
> initialization state are changed by TPM Reset. Persistent values that
> have no default initialization state are not changed by this command.
> Values such as seeds have no default initialization state and only
> change due to specific commands.

2)  TPM Restart – This is a Startup(CLEAR) preceded by Shutdown(STATE).
    This preserves much of the previous state of the TPM except that PCR
    and the controls associated with the Platform hierarchy are all
    returned to their default initialization state;

3)  TPM Resume – This is a Startup(STATE) preceded by Shutdown(STATE).
    This preserves the previous state of the TPM including the static
    Root of Trust for Measurement (S-RTM) PCR and the platform controls
    other than the *phEnable*.

If a TPM receives Startup(STATE) and that was not preceded by
Shutdown(STATE), the TPM shall return TPM_RC_VALUE.

If, during TPM Restart or TPM Resume, the TPM fails to restore the state
saved at the last Shutdown(STATE), the TPM shall enter Failure Mode and
return TPM_RC_FAILURE.

On any TPM2_Startup(),

- *phEnable* shall be SET;

- all transient contexts (objects, sessions, and sequences) shall be
  flushed from TPM memory;

NOTE 4 See Part 1 Time for a description of the TPMS_TIME_INFO.*time*
behaviour.

- use of *lockoutAuth* shall be enabled if *lockoutRecovery* is zero.

Additional actions are performed based on the Shutdown/Startup sequence.

On TPM Reset:

- *platformAuth* and *platformPolicy* shall be set to the Empty Buffer,

- For each NV Index with TPMA_NV_WRITEDEFINE CLEAR or TPMA_NV_WRITTEN
  CLEAR, TPMA_NV_WRITELOCKED shall be CLEAR,

- For each NV Index with TPMA_NV_ORDERLY SET, TPMA_NV_WRITTEN shall be
  CLEAR unless the type is TPM_NT_COUNTER,

- On a disorderly reset, advance the orderly counters,

- For each NV Index with TPMA_NV_CLEAR_STCLEAR SET, TPMA_NV_WRITTEN
  shall be CLEAR,

- tracking data for saved session contexts shall be set to its initial
  value,

- the object context sequence number is reset to zero,

- a new context encryption key shall be generated,

- TPMS_CLOCK_INFO.*restartCount* shall be reset to zero,

- TPMS_CLOCK_INFO.*resetCount* shall be incremented,

- the PCR Update Counter shall be clear to zero,

> NOTE 5 Because the PCR update counter may be incremented when a PCR is
> reset, the PCR resets performed as part of this command can result in
> the PCR update counter being non-zero at the end of this command.

- *phEnableNV, shEnable* and *ehEnable* shall be SET, and

- PCR in all banks are reset to their default initial conditions as
  determined by the relevant platform-specific specification and the
  H-CRTM state (for exceptions, see TPM 2.0 Part 1*, H-CRTM before
  TPM2_Startup() and TPM2_Startup without H-CRTM*),

- For each ACT the timeout is reset to zero, the *signaled* attribute is
  set to CLEAR (if *preserveSignaled* is CLEAR), and the *authPolicy* is
  set to the Empty Buffer and its hashAlg is set to TPM_ALG_NULL.

> NOTE 6 PCR may be initialized any time between \_TPM_Init and the end
> of TPM2_Startup(). PCR that are preserved by TPM Resume will need to
> be restored during TPM2_Startup().
>
> NOTE 7 See "Initializing PCR" in TPM 2.0 Part 1 for a description of
> the default initial conditions for a PCR.

On TPM Restart:

- TPMS_CLOCK_INFO.*restartCount* shall be incremented,

- *phEnableNV, shEnable* and *ehEnable* shall be SET,

- *platformAuth* and *platformPolicy* shall be set to the Empty Buffer,

- For each NV index with TPMA_NV_WRITEDEFINE CLEAR or TPMA_NV_WRITTEN
  CLEAR, TPMA_NV_WRITELOCKED shall be CLEAR,

- For each NV index with TPMA_NV_CLEAR_STCLEAR SET, TPMA_NV_WRITTEN
  shall be CLEAR, and

- PCR in all banks are reset to their default initial conditions.

- If an H-CRTM Event Sequence is active, extend the PCR designated by
  the platform-specific specification.

- For each ACT the timeout is reset to zero, the *signaled* attribute is
  set to CLEAR (if *preserveSignaled* is CLEAR), and the *authPolicy* is
  set to the Empty Buffer and its hashAlg is set to TPM_ALG_NULL.

On TPM Resume:

- the H-CRTM startup method is the same for this TPM2_Startup() as for
  the previous TPM2_Startup(); (TPM_RC_LOCALITY)

- TPMS_CLOCK_INFO.*restartCount* shall be incremented; and

- PCR that are specified in a platform-specific specification to be
  preserved on TPM Resume are restored to their saved state and other
  PCR are set to their initial value as determined by a
  platform-specific specification. For constraints, see TPM 2.0 Part 1,
  *H-CRTM before TPM2_Startup() and TPM2_Startup without H-CRTM.*

- The ACT timeout, the ACT *signaled* attribute and the ACT specific
  *authPolic*y values are preserved.

Other TPM state may change as required to meet the needs of the
implementation.

If the *startupType* is TPM_SU_STATE and the TPM requires TPM_SU_CLEAR,
then the TPM shall return TPM_RC_VALUE.

NOTE 8 The TPM will require TPM_SU_CLEAR when no shutdown was performed
or after Shutdown(CLEAR).

NOTE 9 If *startupType* is neither TPM_SU_STATE nor TPM_SU_CLEAR, then
the unmarshaling code returns TPM_RC_VALUE.

### Command and Response

Table 5 — TPM2_Startup Command

|                     |             |                              |
|---------------------|-------------|------------------------------|
| Type                | Name        | Description                  |
| TPMI_ST_COMMAND_TAG | tag         | TPM_ST_NO_SESSIONS           |
| UINT32              | commandSize |                              |
| TPM_CC              | commandCode | TPM_CC_Startup {NV}          |
| TPM_SU              | startupType | TPM_SU_CLEAR or TPM_SU_STATE |

Table 6 — TPM2_Startup Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[Startup\]\]

## TPM2_Shutdown

### General Description

This command is used to prepare the TPM for a power cycle. The
*shutdownType* parameter indicates how the subsequent TPM2_Startup()
will be processed.

For a *shutdownType* of any type, the volatile portion of Clock is saved
to NV memory and the orderly shutdown indication is SET. NV Indexes with
the TPMA_NV_ORDERLY attribute will be updated.

For a *shutdownType* of TPM_SU_STATE, the following additional items are
saved:

- tracking information for saved session contexts;

- the session context counter;

- PCR that are designated as being preserved by
  TPM2_Shutdown(TPM_SU_STATE);

- the PCR Update Counter;

- flags associated with supporting the TPMA_NV_WRITESTCLEAR and
  TPMA_NV_READSTCLEAR attributes;

- the counter value and authPolicy for each ACT; and

> NOTE If a counter has not been updated since the last TPM2_Startup(),
> then the saved value will be one half of the current counter value.

- the command audit digest and count.

The following items shall not be saved and will not be in TPM memory
after the next TPM2_Startup:

- TPM-memory-resident session contexts;

- TPM-memory-resident transient objects; or

- TPM-memory-resident hash contexts created by TPM2_HashSequenceStart().

Some values may be either derived from other values or saved to NV
memory.

This command saves TPM state but does not change the state other than
the internal indication that the context has been saved. The TPM shall
continue to accept commands. If a subsequent command changes TPM state
saved by this command, then the effect of this command is nullified. The
TPM MAY nullify this command for any subsequent command rather than
check whether the command changed state saved by this command. If this
command is nullified. and if no TPM2_Shutdown() occurs before the next
TPM2_Startup(), then the next TPM2_Startup() shall be
TPM2_Startup(CLEAR).

### Command and Response

Table 7 — TPM2_Shutdown Command

|                     |              |                                                                               |
|---------------------|--------------|-------------------------------------------------------------------------------|
| Type                | Name         | Description                                                                   |
| TPMI_ST_COMMAND_TAG | tag          | TPM_ST_SESSIONS if an audit session is present; otherwise, TPM_ST_NO_SESSIONS |
| UINT32              | commandSize  |                                                                               |
| TPM_CC              | commandCode  | TPM_CC_Shutdown {NV}                                                          |
| TPM_SU              | shutdownType | TPM_SU_CLEAR or TPM_SU_STATE                                                  |

Table 8 — TPM2_Shutdown Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[Shutdown\]\]

# Testing

## Introduction

Compliance to standards for hardware security modules may require that
the TPM test its functions before the results that depend on those
functions may be returned. The TPM may perform operations using testable
functions before those functions have been tested as long as the TPM
returns no value that depends on the correctness of the testable
function.

EXAMPLE TPM2_PCR_Extend() may be executed before the hash algorithms
have been tested. However, until the hash algorithms have been tested,
the contents of a PCR may not be used in any command if that command may
result in a value being returned to the TPM user. This means that
TPM2_PCR_Read() or TPM2_PolicyPCR() could not complete until the hashes
have been checked but other TPM2_PCR_Extend() commands may be executed
even though the operation uses previous PCR values.

If a command is received that requires return of a value that depends on
untested functions, the TPM shall test the required functions before
completing the command.

Once the TPM has received TPM2_SelfTest() and before completion of all
tests, the TPM is required to return TPM_RC_TESTING for any command that
uses a function that requires a test.

If a self-test fails at any time, the TPM will enter Failure mode. While
in Failure mode, the TPM will return TPM_RC_FAILURE for any command
other than TPM2_GetTestResult() and TPM2_GetCapability(). The TPM will
remain in Failure mode until the next \_TPM_Init.

## TPM2_SelfTest

### General Description

This command causes the TPM to perform a test of its capabilities. If
the *fullTest* is YES, the TPM will test all functions. If *fullTest* =
NO, the TPM will only test those functions that have not previously been
tested.

If any tests are required, the TPM shall either

- return TPM_RC_TESTING and begin self-test of the required functions,
  or

> NOTE 1 If *fullTest* is NO, and all functions have been tested, the
> TPM shall return TPM_RC_SUCCESS.

- perform the tests and return the test result when complete. On
  failure, the TPM shall return TPM_RC_FAILURE.

If the TPM uses option a), the TPM shall return TPM_RC_TESTING for any
command that requires use of a testable function, even if the functions
required for completion of the command have already been tested.

NOTE 2 This command may cause the TPM to continue processing after it
has returned the response. So that software can be notified of the
completion of the testing, the interface may include controls that would
allow the TPM to generate an interrupt when the “background” processing
is complete. This would be in addition to the interrupt that may be
available for signaling normal command completion. It is not necessary
that there be two interrupts, but the interface should provide a way to
indicate the nature of the interrupt (normal command or deferred
command).

NOTE 3 The PC Client platform specific TPM, in response to *fullTest*
YES, will not return TPM_RC_TESTING. It will block until all tests are
complete.

### Command and Response

Table 9 — TPM2_SelfTest Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<thead>
<tr class="header">
<th>Type</th>
<th>Name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS if an audit session is present; otherwise,
TPM_ST_NO_SESSIONS</td>
</tr>
<tr class="even">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="odd">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_SelfTest {NV}</td>
</tr>
<tr class="even">
<td>TPMI_YES_NO</td>
<td>fullTest</td>
<td><p>YES if full test to be performed</p>
<p>NO if only test of untested functions required</p></td>
</tr>
</tbody>
</table>

Table 10 — TPM2_SelfTest Response

| Type   | Name         | Description  |
|--------|--------------|--------------|
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[SelfTest\]\]

## TPM2_IncrementalSelfTest

### General Description

This command causes the TPM to perform a test of the selected
algorithms.

NOTE 1 The *toTest* list indicates the algorithms that software would
like the TPM to test in anticipation of future use. This allows tests to
be done so that a future commands will not be delayed due to testing.

The implementation may treat algorithms on the *toTest* list as either
'test each completely' or 'test this combination.'

EXAMPLE If the *toTest* list includes AES and CTR mode, it may be
interpreted as a request to test only AES in CTR mode. Alternatively, it
may be interpreted as a request to test AES in all modes and CTR mode
for all symmetric algorithms.

If *toTest* contains an algorithm that has already been tested, it will
not be tested again.

NOTE 2 The only way to force retesting of an algorithm is with
TPM2_SelfTest(*fullTest* = YES).

The TPM will return in *toDoList* a list of algorithms that are yet to
be tested. This list is not the list of algorithms that are scheduled to
be tested but the algorithms/functions that have not been tested. Only
the algorithms on the *toTest* list are scheduled to be tested by this
command.

NOTE 3 An algorithm remains on the *toDoList* while any part of it
remains untested.

EXAMPLE A symmetric algorithm remains untested until it is tested with
all its modes.

Making *toTest* an empty list allows the determination of the algorithms
that remain untested without triggering any testing.

If *toTest* is not an empty list, the TPM shall return TPM_RC_SUCCESS
for this command and then return TPM_RC_TESTING for any subsequent
command (including TPM2_IncrementalSelfTest()) until the requested
testing is complete.

NOTE 4 If *toDoList* is empty, then no additional tests are required and
TPM_RC_TESTING will not be returned in subsequent commands and no
additional delay will occur in a command due to testing.

NOTE 5 If none of the algorithms listed in *toTest* is in the
*toDoList*, then no tests will be performed.

NOTE 6 The TPM cannot return TPM_RC_TESTING for the first call to this
command even when testing is not complete, because response parameters
can only returned with the TPM_RC_SUCCESS return code.

If all the parameters in this command are valid, the TPM returns
TPM_RC_SUCCESS and the *toDoList* (which may be empty).

NOTE 7 An implementation may perform all requested tests before
returning TPM_RC_SUCCESS, or it may return TPM_RC_SUCCESS for this
command and then return TPM_RC_TESTING for all subsequence commands
(including TPM2_IncrementatSelfTest()) until the requested tests are
complete.

### Command and Response

Table 11 — TPM2_IncrementalSelfTest Command

| Type                | Name        | Description                                                                   |
|---------------------|-------------|-------------------------------------------------------------------------------|
| TPMI_ST_COMMAND_TAG | tag         | TPM_ST_SESSIONS if an audit session is present; otherwise, TPM_ST_NO_SESSIONS |
| UINT32              | commandSize |                                                                               |
| TPM_CC              | commandCode | TPM_CC_IncrementalSelfTest {NV}                                               |
| TPML_ALG            | toTest      | list of algorithms that should be tested                                      |

Table 12 — TPM2_IncrementalSelfTest Response

| Type     | Name         | Description                          |
|----------|--------------|--------------------------------------|
| TPM_ST   | tag          | see clause 6                         |
| UINT32   | responseSize |                                      |
| TPM_RC   | responseCode |                                      |
| TPML_ALG | toDoList     | list of algorithms that need testing |

### Detailed Actions

\[\[IncrementalSelfTest\]\]

## TPM2_GetTestResult

### General Description

This command returns manufacturer-specific information regarding the
results of a self-test and an indication of the test status.

If TPM2_SelfTest() has not been executed and a testable function has not
been tested, *testResult* will be TPM_RC_NEEDS_TEST. If TPM2_SelfTest()
has been received and the tests are not complete, *testResult* will be
TPM_RC_TESTING.

If testing of all functions is complete without functional failures,
*testResult* will be TPM_RC_SUCCESS. If any test failed, *testResult*
will be TPM_RC_FAILURE.

This command will operate when the TPM is in Failure mode so that
software can determine the test status of the TPM and so that diagnostic
information can be obtained for use in failure analysis. If the TPM is
in Failure mode, then *tag* is required to be TPM_ST_NO_SESSIONS or the
TPM shall return TPM_RC_FAILURE.

NOTE The reference implementation may return a 32-bit value
*s_failFunction*. This simply gives a unique value to each of the
possible places where a failure could occur. It is not intended to
provide a pointer to the function. \_\_func\_\_ is a pointer to a
character string but the failure mode code can only return 32-bit
values. It is expected that the manufacturer can disambiguate this value
if a customer’s TPM goes into failure mode.

### Command and Response

Table 13 — TPM2_GetTestResult Command

| Type                | Name        | Description                                                                   |
|---------------------|-------------|-------------------------------------------------------------------------------|
| TPMI_ST_COMMAND_TAG | tag         | TPM_ST_SESSIONS if an audit session is present; otherwise, TPM_ST_NO_SESSIONS |
| UINT32              | commandSize |                                                                               |
| TPM_CC              | commandCode | TPM_CC_GetTestResult                                                          |

Table 14 — TPM2_GetTestResult Response

<table>
<colgroup>
<col style="width: 28%" />
<col style="width: 21%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th>Type</th>
<th>Name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>TPM_ST</td>
<td>tag</td>
<td>see clause 6</td>
</tr>
<tr class="even">
<td>UINT32</td>
<td>responseSize</td>
<td></td>
</tr>
<tr class="odd">
<td>TPM_RC</td>
<td>responseCode</td>
<td></td>
</tr>
<tr class="even">
<td>TPM2B_MAX_BUFFER</td>
<td>outData</td>
<td><p>test result data</p>
<p>contains manufacturer-specific information</p></td>
</tr>
<tr class="odd">
<td>TPM_RC</td>
<td>testResult</td>
<td></td>
</tr>
</tbody>
</table>

### Detailed Actions

\[\[GetTestResult\]\]

# Session Commands

## TPM2_StartAuthSession

### General Description

This command is used to start an authorization session using alternative
methods of establishing the session key (*sessionKey*). The session key
is then used to derive values used for authorization and for encrypting
parameters.

This command allows injection of a secret into the TPM using either
asymmetric or symmetric encryption. The type of *tpmKey* determines how
the value in *encryptedSalt* is encrypted. The decrypted secret value is
used to compute the *sessionKey*.

NOTE 1 If *tpmKey* Is TPM_RH_NULL, then *encryptedSalt* is required to
be an Empty Buffer.

The label value of “SECRET” (see “Terms and Definitions” in TPM 2.0
Part 1) is used in the recovery of the secret value.

The TPM generates the *sessionKey* from the recovered secret value.

No authorization is required for *tpmKey* or *bind*.

NOTE 2 The justification for using *tpmKey* without providing
authorization is that the result of using the key is not available to
the caller, except indirectly through the *sessionKey*. This does not
represent a point of attack on the value of the key. If the caller
attempts to use the session without knowing the *sessionKey* value, it
is an authorization failure that will trigger the dictionary attack
logic.

The entity referenced with the *bind* parameter contributes an
authorization value to the *sessionKey* generation process.

If both *tpmKey* and *bind* are TPM_RH_NULL, then *sessionKey* is set to
the Empty Buffer. If *tpmKey* is not TPM_RH_NULL, then *encryptedSalt*
is used in the computation of *sessionKey*. If *bind* is not
TPM_RH_NULL, the *authValue* of *bind* is used in the *sessionKey*
computation.

If *symmetric* specifies a block cipher, then TPM_ALG_CFB is the only
allowed value for the *mode* field in the *symmetric* parameter
(TPM_RC_MODE).

This command starts an authorization session and returns the session
handle along with an initial *nonceTPM* in the response.

If the TPM does not have a free slot for an authorization session, it
shall return TPM_RC_SESSION_HANDLES.

If the TPM implements a “gap” scheme for assigning *contextID* values,
then the TPM shall return TPM_RC_CONTEXT_GAP if creating the session
would prevent recycling of old saved contexts (See “Context Management”
in TPM 2.0 Part 1).

If *tpmKey* is not TPM_ALG_NULL then *encryptedSalt* shall be a
TPM2B_ENCRYPTED_SECRET of the proper type for *tpmKey*. The TPM shall
return TPM_RC_HANDLE if the sensitive portion of *tpmKey* is not loaded.
The TPM shall return TPM_RC_VALUE if:

1)  *tpmKey* references an RSA key and

<!-- -->

54) the size of *encryptedSalt* is not the same as the size of the
    public modulus of *tpmKey*,

55) *encryptedSalt* has a value that is greater than the public modulus
    of *tpmKey*,

56) *encryptedSalt* is not a properly encoded OAEP value, or

57) the decrypted *salt* value is larger than the size of the digest
    produced by the *nameAlg* of *tpmKey*; or

> NOTE 3 The asymScheme of the key object is ignored in this case and
> TPM_ALG_OAEP is used, even if asymScheme is set to TPM_ALG_NULL.

58) *tpmKey* references an ECC key and *encryptedSalt*

59) does not contain a TPMS_ECC_POINT or

60) is not a point on the curve of *tpmKey*;

> NOTE 4 When ECC is used, the point multiply process produces a value
> (Z) that is used in a KDF to produce the final secret value. The size
> of the secret value is an input parameter to the KDF and the result
> will be set to be the size of the digest produced by the *nameAlg* of
> *tpmKey*.

The TPM shall return TPM_RC_KEY if *tpmkey* does not reference an
asymmetric key. The TPM shall return TPM_RC_VALUE if the scheme of the
key is not TPM_ALG_OAEP or TPM_ALG_NULL. The TPM shall return
TPM_RC_ATTRIBUTES if tpmKey does not have the *decrypt* attribute SET.

NOTE While TPM_RC_VALUE is preferred, TPM_RC_SCHEME is acceptable.

If *bind* references a transient object, then the TPM shall return
TPM_RC_HANDLE if the sensitive portion of the object is not loaded.

For all session types, this command will cause initialization of the
*sessionKey* and may establish binding between the session and an object
(the *bind* object). If *sessionType* is TPM_SE_POLICY or TPM_SE_TRIAL,
the additional session initialization is:

- set *policySession*→*policyDigest* to a Zero Digest (the digest size
  for *policySession*→*policyDigest* is the size of the digest produced
  by *authHash*);

- authorization may be given at any locality;

- authorization may apply to any command code;

- authorization may apply to any command parameters or handles;

- the authorization has no time limit;

- an authValue is not needed when the authorization is used;

- the session is not bound;

- the session is not an audit session; and

- the time at which the policy session was created is recorded.

Additionally, if *sessionType* is TPM_SE_TRIAL, the session will not be
usable for authorization but can be used to compute the *authPolicy* for
an object.

NOTE 5 Although this command changes the session allocation information
in the TPM, it does not invalidate a saved context. That is,
TPM2_Shutdown() is not required after this command in order to
re-establish the orderly state of the TPM. This is because the created
context will occupy an available slot in the TPM and sessions in the TPM
do not survive any TPM2_Startup(). However, if a created session is
context saved, the orderly state does change.

The TPM shall return TPM_RC_SIZE if *nonceCaller* is less than 16 octets
or is greater than the size of the digest produced by *authHash*.

### Command and Response

Table 15 — TPM2_StartAuthSession Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS if an audit, decrypt, or encrypt session is present;
otherwise, TPM_ST_NO_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_StartAuthSession</td>
</tr>
<tr class="odd">
<td>TPMI_DH_OBJECT+</td>
<td>tpmKey</td>
<td><p>handle of a loaded decrypt key used to encrypt <em>salt</em></p>
<p>may be TPM_RH_NULL</p>
<p>Auth Index: None</p></td>
</tr>
<tr class="even">
<td>TPMI_DH_ENTITY+</td>
<td>bind</td>
<td><p>entity providing the <em>authValue</em></p>
<p>may be TPM_RH_NULL</p>
<p>Auth Index: None</p></td>
</tr>
<tr class="odd">
<td>TPM2B_NONCE</td>
<td>nonceCaller</td>
<td><p>initial <em>nonceCaller,</em> sets nonceTPM size for the
session</p>
<p>shall be at least 16 octets</p></td>
</tr>
<tr class="even">
<td>TPM2B_ENCRYPTED_SECRET</td>
<td>encryptedSalt</td>
<td><p>value encrypted according to the type of <em>tpmKey</em></p>
<p>If <em>tpmKey</em> is TPM_RH_NULL, this shall be the Empty
Buffer.</p></td>
</tr>
<tr class="odd">
<td>TPM_SE</td>
<td>sessionType</td>
<td>indicates the type of the session; simple HMAC or policy (including
a trial policy)</td>
</tr>
<tr class="even">
<td>TPMT_SYM_DEF+</td>
<td>symmetric</td>
<td><p>the algorithm and key size for parameter encryption</p>
<p>may select TPM_ALG_NULL</p></td>
</tr>
<tr class="odd">
<td>TPMI_ALG_HASH</td>
<td>authHash</td>
<td><p>hash algorithm to use for the session</p>
<p>Shall be a hash algorithm supported by the TPM and not
TPM_ALG_NULL</p></td>
</tr>
</tbody>
</table>

Table 16 — TPM2_StartAuthSession Response

|                      |               |                                                                             |
|----------------------|---------------|-----------------------------------------------------------------------------|
| Type                 | Name          | Description                                                                 |
| TPM_ST               | tag           | see clause 6                                                                |
| UINT32               | responseSize  |                                                                             |
| TPM_RC               | responseCode  |                                                                             |
| TPMI_SH_AUTH_SESSION | sessionHandle | handle for the newly created session                                        |
| TPM2B_NONCE          | nonceTPM      | the initial nonce from the TPM, used in the computation of the *sessionKey* |

### Detailed Actions

\[\[StartAuthSession\]\]

## TPM2_PolicyRestart

### General Description

This command allows a policy authorization session to be returned to its
initial state. This command is used after the TPM returns
TPM_RC_PCR_CHANGED. That response code indicates that a policy will fail
because the PCR have changed after TPM2_PolicyPCR() was executed.
Restarting the session allows the authorizations to be replayed because
the session restarts with the same *nonceTPM*. If the PCR are valid for
the policy, the policy may then succeed.

This command does not reset the policy ID or the policy start time.

### Command and Response

Table 17 — TPM2_PolicyRestart Command

|                     |               |                                                                               |
|---------------------|---------------|-------------------------------------------------------------------------------|
| Type                | Name          | Description                                                                   |
| TPMI_ST_COMMAND_TAG | tag           | TPM_ST_SESSIONS if an audit session is present; otherwise, TPM_ST_NO_SESSIONS |
| UINT32              | commandSize   |                                                                               |
| TPM_CC              | commandCode   | TPM_CC_PolicyRestart                                                          |
| TPMI_SH_POLICY      | sessionHandle | the handle for the policy session                                             |

Table 18 — TPM2_PolicyRestart Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[PolicyRestart\]\]

# Object Commands

## TPM2_Create

### General Description

This command is used to create an object that can be loaded into a TPM
using TPM2_Load(). If the command completes successfully, the TPM will
create the new object and return the object’s creation data
(*creationData*), its public area (*outPublic*), and its encrypted
sensitive area (*outPrivate*). Preservation of the returned data is the
responsibility of the caller. The object will need to be loaded
(TPM2_Load()) before it may be used. The only difference between the
*inPublic* TPMT_PUBLIC template and the *outPublic* TPMT_PUBLIC object
is in the *unique* field.

NOTE 1 This command may require temporary use of a transient resource,
even though the object does not remain loaded after the command. See
Part 1 Transient Resources.

TPM2B_PUBLIC template (*inPublic*) contains all of the fields necessary
to define the properties of the new object. The setting for these fields
is defined in “Public Area Template” in Part 1 of this specification and
in “TPMA_OBJECT” in Part 2 of this specification. The size of the
*unique* field shall not be checked for consistency with the other
object parameters.

NOTE 2 For interoperability, the *unique* field should not be set to a
value that is larger than allowed by object parameters, so that the
unmarshaling will not fail. A size of zero is recommended. After
unmarshaling, the TPM does not use the input *unique* field. It is,
however, used in TPM2_CreatePrimary() and TPM2_CreateLoaded.

EXAMPLE 1 A TPM_ALG_RSA object with a *keyBits* of 2048 in the object’s
parameters should have a *unique* field that is no larger than 256
bytes.

EXAMPLE 2 TPM_ALG_KEYEDHASH or a TPM_ALG_SYMCIPHER object should have a
*unique* field that is no larger than the digest produced by the
object’s *nameAlg*.

The *parentHandle* parameter shall reference a loaded decryption key
that has both the public and sensitive area loaded.

When defining the object, the caller provides a template structure for
the object in a TPM2B_PUBLIC structure (*inPublic*), an initial value
for the object’s *authValue (inSensitive.userAuth),* and, if the object
is a symmetric object, an optional initial data value
(*inSensitive.data*). The TPM shall validate the consistency of the
attributes of *inPublic* according to the Creation rules in
“TPMA_OBJECT” in TPM 2.0 Part 2.

The *inSensitive* parameter may be encrypted using parameter encryption.

The methods in this clause are used by both TPM2_Create() and
TPM2_CreatePrimary(). When a value is indicated as being TPM-generated,
the value is filled in by bits from the RNG if the command is
TPM2_Create() and with values from **KDFa**() if the command is
TPM2_CreatePrimary(). The parameters of each creation value are
specified in TPM 2.0 Part 1.

The *sensitiveDataOrigin* attribute of *inPublic* shall be SET if
*inSensitive.data* is an Empty Buffer and CLEAR if *inSensitive.data* is
not an Empty Buffer or the TPM shall return TPM_RC_ATTRIBUTES.

If the Object is a not a *keyedHash* object, and the *sign* and
*encrypt* attributes are CLEAR, the TPM shall return TPM_RC_ATTRIBUTES.

The TPM will create new data for the sensitive area and compute a
TPMT_PUBLIC.*unique* from the sensitive area based on the object type:

1)  For a symmetric key:

<!-- -->

61) If *inSensitive*.sensitive.*data* is the Empty Buffer, a
    TPM-generated key value is placed in the new object’s
    TPMT_SENSITIVE.*sensitive.sym*. The size of the key will be
    determined by *inPublic.publicArea.parameters*.

62) If *inSensitive*.sensitive.*data* is not the Empty Buffer, the TPM
    will validate that the size of *inSensitive.data* is no larger than
    the key size indicated in the *inPublic template* (TPM_RC_SIZE) and
    copy the *inSensitive.data* to TPMT_SENSITIVE.*sensitive*.*sym* of
    the new object.

63) A TPM-generated obfuscation value is placed in
    TPMT_SENSITIVE.*sensitive.seedValue*. The size of the obfuscation
    value is the size of the digest produced by the nameAlg in
    *inPublic*. This value prevents the public *unique* value from
    leaking information about the *sensitive* area.

64) The TPMT_PUBLIC.*unique.sym* value for the new object is then
    generated, as shown in equation (1) below, by hashing the key and
    obfuscation values in the TPMT_SENSITIVE with the *nameAlg* of the
    object.

unique ≔ **H**<sub>nameAlg</sub>(sensitive.seedValue.buffer \|\|
sensitive.any.buffer) 1

65) If the Object is an asymmetric key:

66) If *in*S*ensitive.sensitive.data* is not the Empty Buffer, then the
    TPM shall return TPM_RC_VALUE.

67) A TPM-generated private key value is created with the size
    determined by the parameters of inPublic.publicArea.parameters.

68) If the key is a Storage Key, a TPM-generated
    TPMT_SENSITIVE.*seedValue* value is created; otherwise,
    TPMT_SENSITIVE.*seedValue.size* is set to zero.

> NOTE 3 An Object that is not a storage key has no child Objects to
> encrypt, so it does not need a symmetric key.

69) The public *unique* value is computed from the private key according
    to the methods of the key type.

70) If the key is an ECC key and the scheme required by the curveID is
    not the same as *scheme* in the public area of the template, then
    the TPM shall return TPM_RC_SCHEME.

71) If the key is an ECC key and the KDF required by the curveID is not
    the same as *kdf* in the pubic area of the template, then the TPM
    shall return TPM_RC_KDF.

> NOTE 4 There is currently no command in which the caller may specify
> the KDF to be used with an ECC decryption key. Since there is no use
> for this capability, the reference implementation requires that the
> *kdf* in the template be set to TPM_ALG_NULL or TPM_RC_KDF is
> returned.

72) If the Object is a *keyedHash* object:

73) If *inSensitive.sensitive.data* is an Empty Buffer, and both *sign*
    and *decrypt* are CLEAR in the attributes of *inPublic*, the TPM
    shall return TPM_RC_ATTRIBUTES. This would be a data object with no
    data.

> NOTE 5 Revisions 134 and earlier reference code did not check the
> error case of *sensitiveDataOrigin* SET and an Empty Buffer. Thus,
> some TPM implementations may also not have included this error check.

74) If *sign* and *decrypt* are both CLEAR, or if *sign* and *decrypt*
    are both SET and the *scheme* in the public area of the template is
    not TPM_ALG_NULL, the TPM shall return TPM_RC_SCHEME.

> NOTE 6 Revisions 138 and earlier did not enforce this error case.

75) If *inSensitive.sensitive.data* is not an Empty Buffer, the TPM will
    copy the *inSensitive.sensitive.data* to
    TPMT_SENSITIVE.*sensitive.bits* of the new object.

> NOTE 7 The size of inSensitive.sensitive.data is limited to be no
> larger than MAX_SYM_DATA.

76) If *inSensitive.sensitive.data* is an Empty Buffer, a TPM-generated
    key value that is the size of the digest produced by the *nameAlg*
    in *inPublic* is placed in TPMT_SENSITIVE.*sensitive.bits*.

77) A TPM-generated obfuscation value that is the size of the digest
    produced by the *nameAlg* of *inPublic* is placed in
    TPMT_SENSITIVE.*seedValue*.

78) The TPMT_PUBLIC.*unique.keyedHash* value for the new object is then
    generated, as shown in equation (1) above, by hashing the key and
    obfuscation values in the TPMT_SENSITIVE with the *nameAlg* of the
    object.

For TPM2_Load(), the TPM will apply normal symmetric protections to the
created TPMT_SENSITIVE to create *outPublic*.

NOTE 8 The encryption key is derived from the symmetric seed in the
sensitive area of the parent.

In addition to *outPublic* and *outPrivate*, the TPM will build a
TPMS_CREATION_DATA structure for the object.
TPMS_CREATION_DATA.*outsideInfo* is set to *outsideInfo*. This structure
is returned in *creationData*. Additionally, the digest of this
structure is returned in *creationHash*, and, finally, a
TPMT_TK_CREATION is created so that the association between the creation
data and the object may be validated by TPM2_CertifyCreation().

If the object being created is a Storage Key and *fixedParent* is SET in
the attributes of *inPublic*, then the symmetric algorithms and
parameters of *inPublic* are required to match those of the parent. The
algorithms that must match are *inPublic.nameAlg*, and the values in
*inPublic.parameters* that select the symmetric scheme. If
*inPublic.nameAlg* does not match, the TPM shall return TPM_RC_HASH.If
the symmetric scheme of the key does not match, the parent, the TPM
shall return TPM_RC_SYMMETRIC. The TPM shall not use different response
code to differentiate between mismatches of the components of
*inPublic.parameters*. However, after this verification, when using the
scheme to encrypt child objects, the TPM ignores the symmetric mode and
uses TPM_ALG_CFB.

NOTE 9 The symmetric scheme is a TPMT_SYM_DEF_OBJECT. In a symmetric
block ciphier, it is at *inPublic.parameters.symDetail.sym* and in an
asymmetric object is at *inPublic.parameters.asymDetail.symmetric.*

NOTE 10 Prior to revision 01.34, the parent asymmetric algorithms were
also checked for *fixedParent* storage keys.

### Command and Response

Table 19 — TPM2_Create Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_Create</td>
</tr>
<tr class="odd">
<td>TPMI_DH_OBJECT</td>
<td>@parentHandle</td>
<td><p>handle of parent for new object</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPM2B_SENSITIVE_CREATE</td>
<td>inSensitive</td>
<td>the sensitive data</td>
</tr>
<tr class="odd">
<td>TPM2B_PUBLIC</td>
<td>inPublic</td>
<td>the public template</td>
</tr>
<tr class="even">
<td>TPM2B_DATA</td>
<td>outsideInfo</td>
<td>data that will be included in the creation data for this object to
provide permanent, verifiable linkage between this object and some
object owner data</td>
</tr>
<tr class="odd">
<td>TPML_PCR_SELECTION</td>
<td>creationPCR</td>
<td>PCR that will be used in creation data</td>
</tr>
</tbody>
</table>

Table 20 — TPM2_Create Response

|                     |                |                                                                                                  |
|---------------------|----------------|--------------------------------------------------------------------------------------------------|
| Type                | Name           | Description                                                                                      |
| TPM_ST              | tag            | see clause 6                                                                                     |
| UINT32              | responseSize   |                                                                                                  |
| TPM_RC              | responseCode   |                                                                                                  |
| TPM2B_PRIVATE       | outPrivate     | the private portion of the object                                                                |
| TPM2B_PUBLIC        | outPublic      | the public portion of the created object                                                         |
| TPM2B_CREATION_DATA | creationData   | contains a TPMS_CREATION_DATA                                                                    |
| TPM2B_DIGEST        | creationHash   | digest of *creationData* using *nameAlg* of *outPublic*                                          |
| TPMT_TK_CREATION    | creationTicket | ticket used by TPM2_CertifyCreation() to validate that the creation data was produced by the TPM |

### Detailed Actions

\[\[Create\]\]

## TPM2_Load

### General Description

This command is used to load objects into the TPM. This command is used
when both a TPM2B_PUBLIC and TPM2B_PRIVATE are to be loaded. If only a
TPM2B_PUBLIC is to be loaded, the TPM2_LoadExternal command is used.

NOTE 1 Loading an object is not the same as restoring a saved object
context.

The object’s TPMA_OBJECT attributes will be checked according to the
rules defined in “TPMA_OBJECT” in TPM 2.0 Part 2 of this specification.
If the Object is a not a *keyedHash* object, and the *sign* and
*encrypt* attributes are CLEAR, the TPM shall return TPM_RC_ATTRIBUTES.

Objects loaded using this command will have a Name. The Name is the
concatenation of *nameAlg* and the digest of the public area using the
*nameAlg.*

NOTE 2 *nameAlg* is a parameter in the public area of the inPublic
structure.

If *inPrivate.size* is zero, the load will fail.

After *inPrivate.buffer* is decrypted using the symmetric key of the
parent, the integrity value shall be checked before the sensitive area
is used, or unmarshaled.

NOTE 3 Checking the integrity before the data is used prevents attacks
on the sensitive area by fuzzing the data and looking at the differences
in the response codes.

The command returns a handle for the loaded object and the Name that the
TPM computed for *inPublic.public* (that is, the digest of the
TPMT_PUBLIC structure in *inPublic*).

NOTE 4 The TPM-computed Name is provided as a convenience to the caller
for those cases where the caller does not implement the hash algorithms
specified in the *nameAlg* of the object.

NOTE 5 The returned handle is associated with the object until the
object is flushed (TPM2_FlushContext) or until the next TPM2_Startup.

For all objects, the size of the key in the sensitive area shall be
consistent with the key size indicated in the public area or the TPM
shall return TPM_RC_KEY_SIZE.

Before use, a loaded object shall be checked to validate that the public
and sensitive portions are properly linked, cryptographically. Use of an
object includes use in any policy command. If the parts of the object
are not properly linked, the TPM shall return TPM_RC_BINDING. If a weak
symmetric key is in the sensitive portion, the TPM shall return
TPM_RC_KEY.

EXAMPLE 1 For a symmetric object, the unique value in the public area
shall be the digest of the sensitive key and the obfuscation value.

EXAMPLE 2 For a two-prime RSA key, the remainder when dividing the
public modulus by the private key shall be zero and it shall be possible
to form a private exponent from the two prime factors of the public
modulus.

EXAMPLE 3 For an ECC key, the public point shall be f(x) where x is the
private key.

### Command and Response

Table 21 — TPM2_Load Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_Load</td>
</tr>
<tr class="odd">
<td>TPMI_DH_OBJECT</td>
<td>@parentHandle</td>
<td><p>TPM handle of parent key; shall not be a reserved handle</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPM2B_PRIVATE</td>
<td>inPrivate</td>
<td>the private portion of the object</td>
</tr>
<tr class="odd">
<td>TPM2B_PUBLIC</td>
<td>inPublic</td>
<td>the public portion of the object</td>
</tr>
</tbody>
</table>

Table 22 — TPM2_Load Response

|            |              |                                                       |
|------------|--------------|-------------------------------------------------------|
| Type       | Name         | Description                                           |
| TPM_ST     | tag          | see clause 6                                          |
| UINT32     | responseSize |                                                       |
| TPM_RC     | responseCode |                                                       |
| TPM_HANDLE | objectHandle | handle of type TPM_HT_TRANSIENT for the loaded object |
| TPM2B_NAME | name         | Name of the loaded object                             |

### Detailed Actions

\[\[Load\]\]

## TPM2_LoadExternal

### General Description

This command is used to load an object that is not a Protected Object
into the TPM. The command allows loading of a public area or both a
public and sensitive area.

NOTE 1 Typical use for loading a public area is to allow the TPM to
validate an asymmetric signature. Typical use for loading both a public
and sensitive area is to allow the TPM to be used as a crypto
accelerator.

Load of a public external object area allows the object to be associated
with a hierarchy so that the correct algorithms may be used when
creating tickets. The *hierarchy* parameter provides this association.
If the public and sensitive portions of the object are loaded,
*hierarchy* is required to be TPM_RH_NULL.

NOTE 2 If both the public and private portions of an object are loaded,
the object is not allowed to appear to be part of a hierarchy.

The object’s TPMA_OBJECT attributes will be checked according to the
rules defined in “TPMA_OBJECT” in TPM 2.0 Part 2. In particular,
*fixedTPM*, *fixedParent*, and *restricted* shall be CLEAR if
*inPrivate* is not the Empty Buffer.

NOTE 3 The duplication status of a public key needs to be able to be the
same as the full key which may be resident on a different TPM. If both
the public and private parts of the key are loaded, then it is not
possible for the key to be either *fixedTPM* or *fixedParent*, since,
its private area would not be available in the clear to load.

Objects loaded using this command will have a Name. The Name is the
*nameAlg* of the object concatenated with the digest of the public area
using the *nameAlg.* The Qualified Name for the object will be the same
as its Name. The TPM will validate that the *authPolicy* is either the
size of the digest produced by *nameAlg* or the Empty Buffer.

NOTE 4 If *nameAlg* is TPM_ALG_NULL, then the Name is the Empty Buffer.
When the authorization value for an object with no Name is computed, no
Name value is included in the HMAC. To ensure that these unnamed
entities are not substituted, they should have an *authValue* that is
statistically unique.

NOTE 5 The digest size for TPM_ALG_NULL is zero.

If the *nameAlg* is TPM_ALG_NULL, the TPM shall not verify the
cryptographic binding between the public and sensitive areas, but the
TPM will validate that the size of the key in the sensitive area is
consistent with the size indicated in the public area. If it is not, the
TPM shall return TPM_RC_KEY_SIZE.

NOTE 6 For an ECC object, the TPM will verify that the public key is on
the curve of the key before the public area is used.

If *nameAlg* is not TPM_ALG_NULL, then the same consistency checks
between *inPublic* and *inPrivate* are made as for TPM2_Load().

NOTE 7 Consistency checks are necessary because an object with a Name
needs to have the public and sensitive portions cryptographically bound
so that an attacker cannot mix pubic and sensitive areas.

The command returns a handle for the loaded object and the Name that the
TPM computed for *inPublic.public* (that is, the TPMT_PUBLIC structure
in *inPublic*).

NOTE 8 The TPM-computed Name is provided as a convenience to the caller
for those cases where the caller does not implement the hash algorithm
specified in the *nameAlg* of the object.

The *hierarchy* parameter associates the external object with a
hierarchy. External objects are flushed when their associated hierarchy
is disabled. If *hierarchy* is TPM_RH_NULL, the object is part of no
hierarchy, and there is no implicit flush.

If *hierarchy* is TPM_RH_NULL or *nameAlg* is TPM_ALG_NULL, a ticket
produced using the object shall be a NULL Ticket.

EXAMPLE If a key is loaded with hierarchy set to TPM_RH_NULL, then
TPM2_VerifySignature() will produce a NULL Ticket of the required type.

External objects are Temporary Objects. The saved external object
contexts shall be invalidated at the next TPM Reset.

If a weak symmetric key is in the sensitive area, the TPM shall return
TPM_RC_KEY.

For an RSA key, the private exponent is computed using the two prime
factors of the public modulus. One of the primes is P, and the second
prime (Q) is found by dividing the public modulus by P. A TPM may return
an error (TPM_RC_BINDING) if the bit size of P and Q are not the same.”

### Command and Response

Table 23 — TPM2_LoadExternal Command

|                     |             |                                                                                                    |
|---------------------|-------------|----------------------------------------------------------------------------------------------------|
| Type                | Name        | Description                                                                                        |
| TPMI_ST_COMMAND_TAG | tag         | TPM_ST_SESSIONS if an audit, encrypt, or decrypt session is present; otherwise, TPM_ST_NO_SESSIONS |
| UINT32              | commandSize |                                                                                                    |
| TPM_CC              | commandCode | TPM_CC_LoadExternal                                                                                |
| TPM2B_SENSITIVE     | inPrivate   | the sensitive portion of the object (optional)                                                     |
| TPM2B_PUBLIC+       | inPublic    | the public portion of the object                                                                   |
| TPMI_RH_HIERARCHY+  | hierarchy   | hierarchy with which the object area is associated                                                 |

Table 24 — TPM2_LoadExternal Response

|            |              |                                                       |
|------------|--------------|-------------------------------------------------------|
| Type       | Name         | Description                                           |
| TPM_ST     | tag          | see clause 6                                          |
| UINT32     | responseSize |                                                       |
| TPM_RC     | responseCode |                                                       |
| TPM_HANDLE | objectHandle | handle of type TPM_HT_TRANSIENT for the loaded object |
| TPM2B_NAME | name         | name of the loaded object                             |

### Detailed Actions

\[\[LoadExternal\]\]

## TPM2_ReadPublic

### General Description

This command allows access to the public area of a loaded object.

Use of the *objectHandle* does not require authorization.

NOTE Since the caller is not likely to know the public area of the
object associated with *objectHandle*, it would not be possible to
include the Name associated with *objectHandle* in the *cpHash*
computation.

If *objectHandle* references a sequence object, the TPM shall return
TPM_RC_SEQUENCE.

### Command and Response

Table 25 — TPM2_ReadPublic Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS if an audit or encrypt session is present;
otherwise, TPM_ST_NO_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_ReadPublic</td>
</tr>
<tr class="odd">
<td>TPMI_DH_OBJECT</td>
<td>objectHandle</td>
<td><p>TPM handle of an object</p>
<p>Auth Index: None</p></td>
</tr>
</tbody>
</table>

Table 26 — TPM2_ReadPublic Response

|              |               |                                                   |
|--------------|---------------|---------------------------------------------------|
| Type         | Name          | Description                                       |
| TPM_ST       | tag           | see clause 6                                      |
| UINT32       | responseSize  |                                                   |
| TPM_RC       | responseCode  |                                                   |
| TPM2B_PUBLIC | outPublic     | structure containing the public area of an object |
| TPM2B_NAME   | name          | name of the object                                |
| TPM2B_NAME   | qualifiedName | the Qualified Name of the object                  |

### Detailed Actions

\[\[ReadPublic\]\]

## TPM2_ActivateCredential

### General Description

This command enables the association of a credential with an object in a
way that ensures that the TPM has validated the parameters of the
credentialed object.

If both the public and private portions of *activateHandle* and
*keyHandle* are not loaded, then the TPM shall return
TPM_RC_AUTH_UNAVAILABLE.

If *keyHandle* is not a Storage Key, then the TPM shall return
TPM_RC_TYPE.

Authorization for *activateHandle* requires the ADMIN role.

The key associated with *keyHandle* is used to recover a seed from
secret, which is the encrypted seed. The Name of the object associated
with activateHandle and the recovered seed are used in a KDF to recover
the symmetric key. The recovered seed (but not the Name) is used in a
KDF to recover the HMAC key.

The HMAC is used to validate that the *credentialBlob* is associated
with *activateHandle* and that the data in *credentialBlob* has not been
modified. The linkage to the object associated with activateHandle is
achieved by including the Name in the HMAC calculation.

If the integrity checks succeed, *credentialBlob* is decrypted and
returned as *certInfo*.

NOTE The output *certInfo* parameter is an application defined value. It
is typically a symmetric key or seed that is used to decrypt a
certificate. See the TPM2_MakeCredential *credential* input parameter.

### Command and Response

Table 27 — TPM2_ActivateCredential Command

<table>
<colgroup>
<col style="width: 30%" />
<col style="width: 20%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_ActivateCredential</td>
</tr>
<tr class="odd">
<td>TPMI_DH_OBJECT</td>
<td>@activateHandle</td>
<td><p>handle of the object associated with certificate in
<em>credentialBlob</em></p>
<p>Auth Index: 1</p>
<p>Auth Role: ADMIN</p></td>
</tr>
<tr class="even">
<td>TPMI_DH_OBJECT</td>
<td>@keyHandle</td>
<td><p>loaded key used to decrypt the TPMS_SENSITIVE in
<em>credentialBlob</em></p>
<p>Auth Index: 2</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="odd">
<td>TPM2B_ID_OBJECT</td>
<td>credentialBlob</td>
<td>the credential</td>
</tr>
<tr class="even">
<td>TPM2B_ENCRYPTED_SECRET</td>
<td>secret</td>
<td><em>keyHandle</em> algorithm-dependent encrypted seed that protects
<em>credentialBlob</em></td>
</tr>
</tbody>
</table>

Table 28 — TPM2_ActivateCredential Response

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPM_ST</td>
<td>tag</td>
<td>see clause 6</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>responseSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_RC</td>
<td>responseCode</td>
<td></td>
</tr>
<tr class="odd">
<td>TPM2B_DIGEST</td>
<td>certInfo</td>
<td><p>the decrypted certificate information</p>
<p>the data should be no larger than the size of the digest of the
<em>nameAlg</em> associated with <em>keyHandle</em></p></td>
</tr>
</tbody>
</table>

### Detailed Actions

\[\[ActivateCredential\]\]

## TPM2_MakeCredential

### General Description

This command allows the TPM to perform the actions required of a
Certificate Authority (CA) in creating a TPM2B_ID_OBJECT containing an
activation credential.

NOTE The input *credential* parameter is an application defined value.
It is typically a symmetric key or seed that is used to encrypt a
certificate. See the TPM2_ActivateCredential *certInfo* output
parameter.

The TPM will produce a TPM2B_ID_OBJECT according to the methods in
“Credential Protection” in TPM 2.0 Part 1.

The loaded public area referenced by *handle* is required to be the
public area of a Storage key, otherwise, the credential cannot be
properly sealed.

This command does not use any TPM secrets nor does it require
authorization. It is a convenience function, using the TPM to perform
cryptographic calculations that could be done externally.

### Command and Response

Table 29 — TPM2_MakeCredential Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS if an audit, encrypt, or decrypt session is present;
otherwise, TPM_ST_NO_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_MakeCredential</td>
</tr>
<tr class="odd">
<td>TPMI_DH_OBJECT</td>
<td>handle</td>
<td><p>loaded public area, used to encrypt the sensitive area containing
the credential key</p>
<p>Auth Index: None</p></td>
</tr>
<tr class="even">
<td>TPM2B_DIGEST</td>
<td>credential</td>
<td>the credential information</td>
</tr>
<tr class="odd">
<td>TPM2B_NAME</td>
<td>objectName</td>
<td>Name of the object to which the credential applies</td>
</tr>
</tbody>
</table>

Table 30 — TPM2_MakeCredential Response

|                        |                |                                                                                     |
|------------------------|----------------|-------------------------------------------------------------------------------------|
| Type                   | Name           | Description                                                                         |
| TPM_ST                 | tag            | see clause 6                                                                        |
| UINT32                 | responseSize   |                                                                                     |
| TPM_RC                 | responseCode   |                                                                                     |
| TPM2B_ID_OBJECT        | credentialBlob | the credential                                                                      |
| TPM2B_ENCRYPTED_SECRET | secret         | *handle* algorithm-dependent data that wraps the key that encrypts *credentialBlob* |

### Detailed Actions

\[\[MakeCredential\]\]

## TPM2_Unseal

### General Description

This command returns the data in a loaded Sealed Data Object.

NOTE 1 A random, TPM-generated, Sealed Data Object may be created by the
TPM with TPM2_Create() or TPM2_CreatePrimary() using the template for a
Sealed Data Object.

NOTE 2 TPM 1.2 hard coded PCR authorization. TPM 2.0 PCR authorization
requires a policy.

The returned value may be encrypted using authorization session
encryption.

If either *restricted*, *decrypt,* or *sign* is SET in the attributes of
*itemHandle,* then the TPM shall return TPM_RC_ATTRIBUTES. If the *type*
of *itemHandle* is not TPM_ALG_KEYEDHASH, then the TPM shall return
TPM_RC_TYPE.

### Command and Response

Table 31 — TPM2_Unseal Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_Unseal</td>
</tr>
<tr class="odd">
<td>TPMI_DH_OBJECT</td>
<td>@itemHandle</td>
<td><p>handle of a loaded data object</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
</tbody>
</table>

Table 32 — TPM2_Unseal Response

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPM_ST</td>
<td>tag</td>
<td>see clause 6</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>responseSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_RC</td>
<td>responseCode</td>
<td></td>
</tr>
<tr class="odd">
<td>TPM2B_SENSITIVE_DATA</td>
<td>outData</td>
<td><p>unsealed data</p>
<p>Size of <em>outData</em> is limited to be no more than 128
octets.</p></td>
</tr>
</tbody>
</table>

### Detailed Actions

\[\[Unseal\]\]

## TPM2_ObjectChangeAuth

### General Description

This command is used to change the authorization secret for a
TPM-resident object.

If successful, a new private area for the TPM-resident object associated
with *objectHandle* is returned, which includes the new authorization
value.

This command does not change the authorization of the TPM-resident
object on which it operates. Therefore, the old authValue (of the
TPM-resident object) is used when generating the response HMAC key if
required.

NOTE 1 The returned *outPrivate* will need to be loaded before the new
authorization will apply.

NOTE 2 The TPM-resident object may be persistent and changing the
authorization value of the persistent object could prevent other users
from accessing the object. This is why this command does not change the
TPM-resident object.

EXAMPLE If a persistent key is being used as a Storage Root Key and the
authorization of the key is a well-known value so that the key can be
used generally, then changing the authorization value in the persistent
key would deny access to other users.

This command may not be used to change the authorization value for an NV
Index or a Primary Object.

NOTE 3 If an NV Index is to have a new authorization, it is done with
TPM2_NV_ChangeAuth().

NOTE 4 If a Primary Object is to have a new authorization, it needs to
be recreated (TPM2_CreatePrimary()).

### Command and Response

Table 33 — TPM2_ObjectChangeAuth Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_ObjectChangeAuth</td>
</tr>
<tr class="odd">
<td>TPMI_DH_OBJECT</td>
<td>@objectHandle</td>
<td><p>handle of the object</p>
<p>Auth Index: 1</p>
<p>Auth Role: ADMIN</p></td>
</tr>
<tr class="even">
<td>TPMI_DH_OBJECT</td>
<td>parentHandle</td>
<td><p>handle of the parent</p>
<p>Auth Index: None</p></td>
</tr>
<tr class="odd">
<td>TPM2B_AUTH</td>
<td>newAuth</td>
<td>new authorization value</td>
</tr>
</tbody>
</table>

Table 34 — TPM2_ObjectChangeAuth Response

|               |              |                                                     |
|---------------|--------------|-----------------------------------------------------|
| Type          | Name         | Description                                         |
| TPM_ST        | tag          | see clause 6                                        |
| UINT32        | responseSize |                                                     |
| TPM_RC        | responseCode |                                                     |
| TPM2B_PRIVATE | outPrivate   | private area containing the new authorization value |

### Detailed Actions

\[\[ObjectChangeAuth\]\]

## TPM2\_CreateLoaded

### General Description

This command creates an object and loads it in the TPM. This command
allows creation of any type of object (Primary, Ordinary, or Derived)
depending on the type of *parentHandle.* If *parentHandle* references a
Primary Seed, then a Primary Object is created; if *parentHandle*
references a Storage Parent, then an Ordinary Object is created; and if
*parentHandle* references a Derivation Parent, then a Derived Object is
generated.

The input validation is the same as for TPM2_Create() and
TPM2_CreatePrimary() with one exception: when *parentHandle* references
a Derivation Parent, then *sensitiveDataOrigin* in *inPublic* is
required to be CLEAR.

Note 1 In the general descriptions of TPM2_Create() and
TPM2_CreatePrimary() the validations refer to a TPMT_PUBLIC structure
that is in *inPublic.* For TPM2_CreateLoaded(), *inPublic* is a
TPM2B_TEMPLATE that may contain a TPMT_PUBLIC that is used for object
creation. For object derivation, the *unique* field can contain a
*label* and *context* that are used in the derivation process. To allow
both the TPMT_PUBLIC and the derivation variation, a TPM2B_TEMPLATE is
used. When referring to the checks in TPM2_Create() and
TPM2_CreatePrimary(), TPM2B_TEMPLATE should be assumed to contain a
TPMT_PUBLIC.

If *parentHandle* references a Derivation Parent, then the TPM may
return TPM_RC_TYPE if the key type to be generated is an RSA key.

If *parentHandle* references a Derivation Parent or a Primary Seed, then
*outPrivate* will be an Empty Buffer.

NOTE 2 Returning outPrivate would imply that the returned primary or
derived object can be loaded and it cannot. It can only be re-derived.

A primary key cannot be loaded is because loading a key is a way to
attack the protections of a key (e.g. using DPA). A saved context for a
primary object is protected. The TPM will go into failure mode if the
integrity of a saved context is good but the fingerprint doesn’t
decrypt. It is not possible to have these protections on loaded objects
because this would be a simple way for an attacker to put the TPM into
failure mode Saved contexts are assumed to be under control of the
driver but loaded objects are not.

If all objects were derived from their parents then, load could not be
used as an attack. However, that would preclude importation of objects
and key hierarchies.

NOTE 3 Unlike TPM2_Create() and TPM2_CreatePrimary(), this command does
not return creation data. If creation data is needed, then TPM2_Create()
or TPM2_CreatePrimary() should be used.

###  Command and Response

Table 35 — TPM2_CreateLoaded Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_CreateLoade</td>
</tr>
<tr class="odd">
<td>TPMI_DH_PARENT+</td>
<td>@parentHandle</td>
<td><p>Handle of a transient storage key, a persistent storage key,
TPM_RH_ENDORSEMENT, TPM_RH_OWNER, TPM_RH_PLATFORM+{PP}, or
TPM_RH_NULL</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPM2B_SENSITIVE_CREATE</td>
<td>inSensitive</td>
<td>the sensitive data, see TPM 2.0 Part 1 Sensitive Values</td>
</tr>
<tr class="odd">
<td>TPM2B_TEMPLATE</td>
<td>inPublic</td>
<td>the public template</td>
</tr>
</tbody>
</table>

Table 36 — TPM2_CreateLoaded Response

|               |              |                                                    |
|---------------|--------------|----------------------------------------------------|
| Type          | Name         | Description                                        |
| TPM_ST        | tag          | see clause 6                                       |
| UINT32        | responseSize |                                                    |
| TPM_RC        | responseCode |                                                    |
| TPM_HANDLE    | objectHandle | handle of type TPM_HT_TRANSIENT for created object |
| TPM2B_PRIVATE | outPrivate   | the sensitive area of the object (optional)        |
| TPM2B_PUBLIC  | outPublic    | the public portion of the created object           |
| TPM2B_NAME    | name         | the name of the created object                     |

### Detailed Actions

\[\[CreateLoaded\]\]

# Duplication Commands

## TPM2_Duplicate

### General Description

This command duplicates a loaded object so that it may be used in a
different hierarchy. The new parent key for the duplicate may be on the
same or different TPM or TPM_RH_NULL. Only the public area of
*newParentHandle* is required to be loaded.

NOTE 1 Since the new parent may only be extant on a different TPM, it is
likely that the new parent’s sensitive area could not be loaded in the
TPM from which *objectHandle* is being duplicated.

If *encryptedDuplication* is SET in the object being duplicated, then
the TPM shall return TPM_RC_SYMMETRIC if *symmetricAlg.algorithm* is
TPM_ALG_NULL or TPM_RC_HIERARCHY if *newParentHandle* is TPM_RH_NULL.

The authorization for this command shall be with a policy session.

If *fixedParent* of *objectHandle*→*attributes* is SET, the TPM shall
return TPM_RC_ATTRIBUTES. If *objectHandle*→*nameAlg* is TPM_ALG_NULL,
the TPM shall return TPM_RC_TYPE.

The *policySession*→*commandCode* parameter in the policy session is
required to be TPM_CC_Duplicate to indicate that authorization for
duplication has been provided. This indicates that the policy that is
being used is a policy that is for duplication, and not a policy that
would approve another use. That is, authority to use an object does not
grant authority to duplicate the object.

The policy is likely to include cpHash in order to restrict where
duplication can occur. If TPM2_PolicyCpHash() has been executed as part
of the policy, the *policySession→cpHash* is compared to the cpHash of
the command.

If TPM2_PolicyDuplicationSelect() has been executed as part of the
policy, the *policySession*→*nameHash* is compared to

**H**<sub>policyAlg</sub>(objectHandle→Name \|\| newParentHandle→Name) 1

If the compared hashes are not the same, then the TPM shall return
TPM_RC_POLICY_FAIL.

NOTE 2 It is allowed that policySesion→nameHash and policySession→cpHash
share the same memory space.

NOTE 3 A duplication policy is not required to have either
TPM2_PolicyDuplicationSelect() or TPM2_PolicyCpHash() as part of the
policy. If neither is present, then the duplication policy may be
satisfied with a policy that only contains TPM2_PolicyCommandCode(*code*
= TPM_CC_Duplicate).

The TPM shall follow the process of encryption defined in the
“Duplication” subclause of “Protected Storage Hierarchy” in TPM 2.0 Part
1.

### Command and Response

Table 37 — TPM2_Duplicate Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_Duplicate</td>
</tr>
<tr class="odd">
<td>TPMI_DH_OBJECT</td>
<td>@objectHandle</td>
<td><p>loaded object to duplicate</p>
<p>Auth Index: 1</p>
<p>Auth Role: DUP</p></td>
</tr>
<tr class="even">
<td>TPMI_DH_OBJECT+</td>
<td>newParentHandle</td>
<td><p>shall reference the public area of an asymmetric key</p>
<p>Auth Index: None</p></td>
</tr>
<tr class="odd">
<td>TPM2B_DATA</td>
<td>encryptionKeyIn</td>
<td><p>optional symmetric encryption key</p>
<p>The size for this key is set to zero when the TPM is to generate the
key. This parameter may be encrypted.</p></td>
</tr>
<tr class="even">
<td>TPMT_SYM_DEF_OBJECT+</td>
<td>symmetricAlg</td>
<td><p>definition for the symmetric algorithm to be used for the inner
wrapper</p>
<p>may be TPM_ALG_NULL if no inner wrapper is applied</p></td>
</tr>
</tbody>
</table>

Table 38 — TPM2_Duplicate Response

|                        |                  |                                                                                                                                                                                                                    |
|------------------------|------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Type                   | Name             | Description                                                                                                                                                                                                        |
| TPM_ST                 | tag              | see clause 6                                                                                                                                                                                                       |
| UINT32                 | responseSize     |                                                                                                                                                                                                                    |
| TPM_RC                 | responseCode     |                                                                                                                                                                                                                    |
| TPM2B_DATA             | encryptionKeyOut | If the caller provided an encryption key or if *symmetricAlg* was TPM_ALG_NULL, then this will be the Empty Buffer; otherwise, it shall contain the TPM-generated, symmetric encryption key for the inner wrapper. |
| TPM2B_PRIVATE          | duplicate        | private area that may be encrypted by *encryptionKeyIn*; and may be doubly encrypted                                                                                                                               |
| TPM2B_ENCRYPTED_SECRET | outSymSeed       | seed protected by the asymmetric algorithms of new parent (NP)                                                                                                                                                     |

### Detailed Actions

\[\[Duplicate\]\]

## TPM2_Rewrap

### General Description

This command allows the TPM to serve in the role as a Duplication
Authority. If proper authorization for use of the *oldParent* is
provided, then an HMAC key and a symmetric key are recovered from
*inSymSeed* and used to integrity check and decrypt *inDuplicate.* A new
protection seed value is generated according to the methods appropriate
for *newParent* and the blob is re-encrypted and a new integrity value
is computed. The re-encrypted blob is returned in *outDuplicate* and the
symmetric key returned in *outSymKey*.

In the rewrap process, L is “DUPLICATE” (see TPM 2.0 Part 1, *Terms and
Definitions*).

If *inSymSeed* has a zero length, then *oldParent* is required to be
TPM_RH_NULL and no decryption of *inDuplicate* takes place.

If *newParent* is TPM_RH_NULL, then no encryption is performed on
*outDuplicate. outSymSeed* will have a zero length. See TPM 2.0 Part 2
*encryptedDuplication*.

### Command and Response

Table 39 — TPM2_Rewrap Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_Rewrap</td>
</tr>
<tr class="odd">
<td>TPMI_DH_OBJECT+</td>
<td>@oldParent</td>
<td><p>parent of object</p>
<p>Auth Index: 1</p>
<p>Auth Role: User</p></td>
</tr>
<tr class="even">
<td>TPMI_DH_OBJECT+</td>
<td>newParent</td>
<td><p>new parent of the object</p>
<p>Auth Index: None</p></td>
</tr>
<tr class="odd">
<td>TPM2B_PRIVATE</td>
<td>inDuplicate</td>
<td>an object encrypted using symmetric key derived from
<em>inSymSeed</em></td>
</tr>
<tr class="even">
<td>TPM2B_NAME</td>
<td>name</td>
<td>the Name of the object being rewrapped</td>
</tr>
<tr class="odd">
<td>TPM2B_ENCRYPTED_SECRET</td>
<td>inSymSeed</td>
<td><p>the seed for the symmetric key and HMAC key</p>
<p>needs <em>oldParent</em> private key to recover the seed and generate
the symmetric key</p></td>
</tr>
</tbody>
</table>

Table 40 — TPM2_Rewrap Response

|                        |              |                                                                   |
|------------------------|--------------|-------------------------------------------------------------------|
| Type                   | Name         | Description                                                       |
| TPM_ST                 | tag          | see clause 6                                                      |
| UINT32                 | responseSize |                                                                   |
| TPM_RC                 | responseCode |                                                                   |
| TPM2B_PRIVATE          | outDuplicate | an object encrypted using symmetric key derived from *outSymSeed* |
| TPM2B_ENCRYPTED_SECRET | outSymSeed   | seed for a symmetric key protected by *newParent* asymmetric key  |

### Detailed Actions

\[\[Rewrap\]\]

## TPM2_Import

### General Description

This command allows an object to be encrypted using the symmetric
encryption values of a Storage Key. After encryption, the object may be
loaded and used in the new hierarchy. The imported object (*duplicate*)
may be singly encrypted, multiply encrypted, or unencrypted.

If *fixedTPM* or *fixedParent* is SET in *objectPublic*, the TPM shall
return TPM_RC_ATTRIBUTES.

If *encryptedDuplication* is SET in the object referenced by
*parentHandle* and *encryptedDuplication* is CLEAR in *objectPublic,*
the TPM may return TPM_RC_ATTRIBUTES.

If encryptedDuplication is SET in objectPublic, then *inSymSeed* and
*encryptionKey* shall not be Empty buffers (TPM_RC_ATTRIBUTES). Recovery
of the sensitive data of the object occurs in the TPM in a multi--step
process in the following order:

1)  If *inSymSeed* has a non-zero size:

<!-- -->

79) The asymmetric parameters and private key of *parentHandle* are used
    to recover the seed used in the creation of the HMAC key and
    encryption keys used to protect the duplication blob.

> NOTE 1 When recovering the seed from *inSymSeed*, *L* is “DUPLICATE”.

80) The integrity value in *duplicate.buffer.integrityOuter* is used to
    verify the integrity of the data blob, which is the remainder of
    *duplicate.buffer* (TPM_RC_INTEGRITY)*.*

> NOTE 2 The data blob will contain a TPMT_SENSITIVE and may contain a
> TPM2B_DIGEST for the *innerIntegrity.*

81) The symmetric key recovered in 1) is used to decrypt the data blob.

> NOTE 3 Checking the integrity before the data is used prevents attacks
> on the sensitive area by fuzzing the data and looking at the
> differences in the response codes.

82) If *encryptionKey* is not an Empty Buffer:

83) Use *encryptionKey* to decrypt the inner blob.

84) Use the TPM2B_DIGEST at the start of the inner blob to verify the
    integrity of the inner blob (TPM_RC_INTEGRITY).

85) Unmarshal the sensitive area

NOTE 4 It is not necessary to validate that the sensitive area data is
cryptographically bound to the public area other than that the Name of
the public area is included in the HMAC. However, if the binding is not
validated by this command, the binding must be checked each time the
object is loaded. For an object that is imported under a parent with
*fixedTPM* SET, binding need only be checked at import. If the parent
has *fixedTPM* CLEAR, then the binding needs to be checked each time the
object is loaded, or before the TPM performs an operation for which the
binding affects the outcome of the operation (for example,
TPM2_PolicySigned() or TPM2_Certify()).

Similarly, if the new parent's *fixedTPM* is set, the
*encryptedDuplication* state need only be checked at import.

If the new parent is not *fixedTPM*, then that object will be loadable
on any TPM (including SW versions) on which the new parent exists. This
means that, each time an object is loaded under a parent that is not
*fixedTPM*, it is necessary to validate all of the properties of that
object. If the parent is *fixedTPM*, then the new private blob is
integrity protected by the TPM that “owns” the parent. So, it is
sufficient to validate the object’s properties (attribute and
public-private binding) on import and not again.

If a weak symmetric key is being imported, the TPM shall return
TPM_RC_KEY.

After integrity checks and decryption, the TPM will create a new
symmetrically encrypted private area using the encryption key of the
parent.

NOTE 5 The symmetric re-encryption is the normal integrity generation
and symmetric encryption applied to a child object.

NOTE 6 Revision 01.16 of this specification required the ECC private key
in *duplicate* to be padded.

### Command and Response

Table 41 — TPM2_Import Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_Import</td>
</tr>
<tr class="odd">
<td>TPMI_DH_OBJECT</td>
<td>@parentHandle</td>
<td><p>the handle of the new parent for the object</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPM2B_DATA</td>
<td>encryptionKey</td>
<td><p>the optional symmetric encryption key used as the inner wrapper
for <em>duplicate</em></p>
<p>If <em>symmetricAlg</em> is TPM_ALG_NULL, then this parameter shall
be the Empty Buffer.</p></td>
</tr>
<tr class="odd">
<td>TPM2B_PUBLIC</td>
<td>objectPublic</td>
<td><p>the public area of the object to be imported</p>
<p>This is provided so that the integrity value for <em>duplicate</em>
and the object attributes can be checked.</p>
<p>NOTE Even if the integrity value of the object is not checked on
input, the object Name is required to create the integrity value for the
imported object.</p></td>
</tr>
<tr class="even">
<td>TPM2B_PRIVATE</td>
<td>duplicate</td>
<td>the symmetrically encrypted duplicate object that may contain an
inner symmetric wrapper</td>
</tr>
<tr class="odd">
<td>TPM2B_ENCRYPTED_SECRET</td>
<td>inSymSeed</td>
<td><p>the seed for the symmetric key and HMAC key</p>
<p><em>inSymSeed</em> is encrypted/encoded using the algorithms of
<em>newParent</em>.</p></td>
</tr>
<tr class="even">
<td>TPMT_SYM_DEF_OBJECT+</td>
<td>symmetricAlg</td>
<td><p>definition for the symmetric algorithm to use for the inner
wrapper</p>
<p>If this algorithm is TPM_ALG_NULL, no inner wrapper is present and
<em>encryptionKey</em> shall be the Empty Buffer.</p></td>
</tr>
</tbody>
</table>

Table 42 — TPM2_Import Response

|               |              |                                                                       |
|---------------|--------------|-----------------------------------------------------------------------|
| Type          | Name         | Description                                                           |
| TPM_ST        | tag          | see clause 6                                                          |
| UINT32        | responseSize |                                                                       |
| TPM_RC        | responseCode |                                                                       |
| TPM2B_PRIVATE | outPrivate   | the sensitive area encrypted with the symmetric key of *parentHandle* |

### Detailed Actions

\[\[Import\]\]

# Asymmetric Primitives

## Introduction

The commands in this clause provide low-level primitives for access to
the asymmetric algorithms implemented in the TPM. Many of these commands
are only allowed if the asymmetric key is an unrestricted key.

## TPM2_RSA_Encrypt

### General Description

This command performs RSA encryption using the indicated padding scheme
according to IETF RFC 8017. If the *scheme* of *keyHandle* is
TPM_ALG_NULL, then the caller may use *inScheme* to specify the padding
scheme. If *scheme* of keyHandle is not TPM_ALG_NULL, then *inScheme*
shall either be TPM_ALG_NULL or be the same as *scheme* (TPM_RC_SCHEME).

The key referenced by *keyHandle* is required to be an RSA key
(TPM_RC_KEY).

The three types of allowed padding are:

1)  TPM_ALG_OAEP – Data is OAEP padded as described in 7.1 of IETF RFC
    8017 (PKCS#1). The only supported mask generation is MGF1.

2)  TPM_ALG_RSAES – Data is padded as described in 7.2 of IETF RFC 8017
    (PKCS#1).

3)  TPM_ALG_NULL – Data is not padded by the TPM and the TPM will treat
    *message* as an unsigned integer and perform a modular
    exponentiation of *message* using the public exponent of the key
    referenced by *keyHandle*. This scheme is only used if both the
    *scheme* in the key referenced by *keyHandle* is TPM_ALG_NULL, and
    the *inScheme* parameter of the command is TPM_ALG_NULL. The input
    value cannot be larger than the public modulus of the key referenced
    by *keyHandle*.

Table 43 — Padding Scheme Selection

| *keyHandle→scheme* | *inScheme*    | padding scheme used   |
|--------------------|---------------|-----------------------|
| TPM_ALG_NULL       | TPM_ALG_NULL  | none                  |
|                    | TPM_ALG_RSAES | RSAES                 |
|                    | TPM_ALG_OAEP  | OAEP                  |
| TPM_ALG_RSAES      | TPM_ALG_NULL  | RSAES                 |
|                    | TPM_ALG_RSAES | RSAES                 |
|                    | TPM_ALG_OAEP  | error (TPM_RC_SCHEME) |
| TPM_ALG_OAEP       | TPM_ALG_NULL  | OAEP                  |
|                    | TPM_ALG_RSAES | error (TPM_RC_SCHEME) |
|                    | TPM_ALG_OAEP  | OAEP                  |

After padding, the data is RSAEP encrypted according to 5.1.1 of IETF
RFC 8017 (PKCS#1).

If *inScheme* is used, and the scheme requires a hash algorithm it may
not be TPM_ALG_NULL.

NOTE 1 Because only the public portion of the key needs to be loaded for
this command, the caller can manipulate the attributes of the key in any
way desired. As a result, the TPM shall not check the consistency of the
attributes. The only property checking is that the key is an RSA key and
that the padding scheme is supported.

The *message* parameter is limited in size by the padding scheme
according to the following table:

Table 44 — Message Size Limits Based on Padding

<table>
<colgroup>
<col style="width: 24%" />
<col style="width: 36%" />
<col style="width: 39%" />
</colgroup>
<thead>
<tr class="header">
<th>Scheme</th>
<th>Maximum Message Length (<em>mLen</em>) in Octets</th>
<th>Comments</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>TPM_ALG_OAEP</td>
<td><em>mLen</em> ≤ <em>k</em> – 2<em>hLen</em> – 2</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_ALG_RSAES</td>
<td><em>mLen</em> ≤ <em>k</em> – 11</td>
<td></td>
</tr>
<tr class="odd">
<td>TPM_ALG_NULL</td>
<td><em>mLen</em> ≤ <em>k</em></td>
<td>The numeric value of the message must be less than the numeric value
of the public modulus (<em>n</em>).</td>
</tr>
<tr class="even">
<td colspan="3"><p>NOTES</p>
<ol type="1">
<li><p><em>k</em> ≔ the number of byes in the public modulus</p></li>
<li><p><em>hLen</em> ≔ the number of octets in the digest produced by
the hash algorithm used in the process</p></li>
</ol></td>
</tr>
</tbody>
</table>

The *label* parameter is optional. If provided (*label.size* != 0) then
the TPM shall return TPM_RC_VALUE if the last octet in *label* is not
zero. The terminating octet of zero is included in the *label* used in
the padding scheme.

NOTE 2 If the scheme does not use a label, the TPM will still verify
that label is properly formatted if label is present.

NOTE 3 Specifications before version 1.54 stated that *label* is
truncated after the first zero octet. Applications should not include
embedded zero bytes for compatibility.

The function returns padded and encrypted value *outData*.

The *message* parameter in the command may be encrypted using parameter
encryption.

NOTE 4 Only the public area of *keyHandle* is required to be loaded. A
public key may be loaded with any desired scheme. If the scheme is to be
changed, a different public area must be loaded.

### Command and Response

Table 45 — TPM2_RSA_Encrypt Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS if an audit, encrypt, or decrypt session is present;
otherwise, TPM_ST_NO_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_RSA_Encrypt</td>
</tr>
<tr class="odd">
<td>TPMI_DH_OBJECT</td>
<td>keyHandle</td>
<td><p>reference to public portion of RSA key to use for encryption</p>
<p>Auth Index: None</p></td>
</tr>
<tr class="even">
<td>TPM2B_PUBLIC_KEY_RSA</td>
<td>message</td>
<td><p>message to be encrypted</p>
<p>NOTE 1 The data type was chosen because it limits the overall size of
the input to no greater than the size of the largest RSA public key.
This may be larger than allowed for <em>keyHandle</em>.</p></td>
</tr>
<tr class="odd">
<td>TPMT_RSA_DECRYPT+</td>
<td>inScheme</td>
<td>the padding scheme to use if <em>scheme</em> associated with
<em>keyHandle</em> is TPM_ALG_NULL</td>
</tr>
<tr class="even">
<td>TPM2B_DATA</td>
<td>label</td>
<td><p>optional label <em>L</em> to be associated with the message</p>
<p>Size of the buffer is zero if no label is present</p>
<p>NOTE 2 See description of label above.</p></td>
</tr>
</tbody>
</table>

Table 46 — TPM2_RSA_Encrypt Response

|                      |              |                  |
|----------------------|--------------|------------------|
| Type                 | Name         | Description      |
| TPM_ST               | tag          | see clause 6     |
| UINT32               | responseSize |                  |
| TPM_RC               | responseCode |                  |
| TPM2B_PUBLIC_KEY_RSA | outData      | encrypted output |

### Detailed Actions

\[\[RSA_Encrypt\]\]

## TPM2_RSA_Decrypt

### General Description

This command performs RSA decryption using the indicated padding scheme
according to IETF RFC 8017 ((PKCS#1).

The scheme selection for this command is the same as for
TPM2_RSA_Encrypt() and is shown in Table 43.

The key referenced by *keyHandle* shall be an RSA key (TPM_RC_KEY) with
*restricted* CLEAR and *decrypt* SET (TPM_RC_ATTRIBUTES).

This command uses the private key of *keyHandle* for this operation and
authorization is required.

The TPM will perform a modular exponentiation of ciphertext using the
private exponent associated with *keyHandle* (this is described in IETF
RFC 8017 (PKCS#1), clause 5.1.2). It will then validate the padding
according to the selected scheme. If the padding checks fail,
TPM_RC_VALUE is returned. Otherwise, the data is returned with the
padding removed. If no padding is used, the returned value is an
unsigned integer value that is the result of the modular exponentiation
of *cipherText* using the private exponent of *keyHandle*. The returned
value may include leading octets zeros so that it is the same size as
the public modulus. For the other padding schemes, the returned value
will be smaller than the public modulus but will contain all the data
remaining after padding is removed and this may include leading zeros if
the original encrypted value contained leading zeros.

If a label is used in the padding process of the scheme during
encryption, the *label* parameter is required to be present in the
decryption process and *label* is required to be the same in both cases.
If label is not the same, the decrypt operation is very likely to fail
((TPM_RC_VALUE). If *label* is present (*label.size* != 0), it shall be
a byte stream whose last byte is zero or the TPM will return
TPM_RC_VALUE.

NOTE 1 The size of *label* includes the terminating null.

The *message* parameter in the response may be encrypted using parameter
encryption.

If *inScheme* is used, and the scheme requires a hash algorithm it may
not be TPM_ALG_NULL.

If the scheme does not require a label, the value in *label* is not used
but the size of the label field is checked for consistency with the
indicated data type (TPM2B_DATA). That is, the field may not be larger
than allowed for a TPM2B_DATA.

### Command and Response

Table 47 — TPM2_RSA_Decrypt Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_RSA_Decrypt</td>
</tr>
<tr class="odd">
<td>TPMI_DH_OBJECT</td>
<td>@keyHandle</td>
<td><p>RSA key to use for decryption</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPM2B_PUBLIC_KEY_RSA</td>
<td>cipherText</td>
<td><p>cipher text to be decrypted</p>
<p>NOTE An encrypted RSA data block is the size of the public
modulus.</p></td>
</tr>
<tr class="odd">
<td>TPMT_RSA_DECRYPT+</td>
<td>inScheme</td>
<td>the padding scheme to use if <em>scheme</em> associated with
<em>keyHandle</em> is TPM_ALG_NULL</td>
</tr>
<tr class="even">
<td>TPM2B_DATA</td>
<td>label</td>
<td>label whose association with the message is to be verified</td>
</tr>
</tbody>
</table>

Table 48 — TPM2_RSA_Decrypt Response

|                      |              |                  |
|----------------------|--------------|------------------|
| Type                 | Name         | Description      |
| TPM_ST               | tag          | see clause 6     |
| UINT32               | responseSize |                  |
| TPM_RC               | responseCode |                  |
| TPM2B_PUBLIC_KEY_RSA | message      | decrypted output |

### Detailed Actions

\[\[RSA_Decrypt\]\]

## TPM2_ECDH_KeyGen

### General Description

This command uses the TPM to generate an ephemeral key pair
(*d<sub>e</sub>*, *Q<sub>e</sub>* where *Q<sub>e</sub>* ≔
\[*d<sub>e</sub>*\]*G*). It uses the private ephemeral key and a loaded
public key (*Q<sub>S</sub>*) to compute the shared secret value (*P* ≔
\[*hd<sub>e</sub>*\]*Q<sub>S</sub>*).

*keyHandle* shall refer to a loaded, ECC key (TPM_RC_KEY). The sensitive
portion of this key need not be loaded.

The curve parameters of the loaded ECC key are used to generate the
ephemeral key.

NOTE This function is the equivalent of encrypting data to another
object’s public key. The *seed* value is used in a KDF to generate a
symmetric key and that key is used to encrypt the data. Once the data is
encrypted and the symmetric key discarded, only the object with the
private portion of the *keyHandle* will be able to decrypt it.

The *zPoint* in the response may be encrypted using parameter
encryption.

### Command and Response

Table 49 — TPM2_ECDH_KeyGen Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS if an audit or encrypt session is present;
otherwise, TPM_ST_NO_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_ECDH_KeyGen</td>
</tr>
<tr class="odd">
<td>TPMI_DH_OBJECT</td>
<td>keyHandle</td>
<td><p>Handle of a loaded ECC key public area.</p>
<p>Auth Index: None</p></td>
</tr>
</tbody>
</table>

Table 50 — TPM2_ECDH_KeyGen Response

|                 |              |                                                        |
|-----------------|--------------|--------------------------------------------------------|
| Type            | Name         | Description                                            |
| TPM_ST          | tag          | see clause 6                                           |
| UINT32          | responseSize |                                                        |
| TPM_RC          | responseCode |                                                        |
| TPM2B_ECC_POINT | zPoint       | results of *P* ≔ *h*\[*d<sub>e</sub>*\]*Q<sub>s</sub>* |
| TPM2B_ECC_POINT | pubPoint     | generated ephemeral public point (*Q<sub>e</sub>*)     |

### Detailed Actions

\[\[ECDH_KeyGen\]\]

## TPM2_ECDH_ZGen

### General Description

This command uses the TPM to recover the *Z* value from a public point
(*Q<sub>B</sub>*) and a private key (*d<sub>s</sub>*). It will perform
the multiplication of the provided *inPoint* (*Q<sub>B</sub>*) with the
private key (*d<sub>s</sub>*) and return the coordinates of the
resultant point (*Z =* (*x<sub>Z</sub> , y<sub>Z</sub>*) ≔
\[*hd<sub>s</sub>*\]*Q<sub>B</sub>*; where *h* is the cofactor of the
curve).

*keyHandle* shall refer to a loaded, ECC key (TPM_RC_KEY) with the
*restricted* attribute CLEAR and the *decrypt* attribute SET
(TPM_RC_ATTRIBUTES).

NOTE While TPM_RC_ATTRIBUTES is preferred, TPM_RC_KEY is acceptable.

The *scheme* of the key referenced by *keyHandle* is required to be
either TPM_ALG_ECDH or TPM_ALG_NULL (TPM_RC_SCHEME).

*inPoint* is required to be on the curve of the key referenced by
*keyHandle* (TPM_RC_ECC_POINT).

The parameters of the key referenced by *keyHandle* are used to perform
the point multiplication.

### Command and Response

Table 51 — TPM2_ECDH_ZGen Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_ECDH_ZGen</td>
</tr>
<tr class="odd">
<td>TPMI_DH_OBJECT</td>
<td>@keyHandle</td>
<td><p>handle of a loaded ECC key</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPM2B_ECC_POINT</td>
<td>inPoint</td>
<td>a public key</td>
</tr>
</tbody>
</table>

Table 52 — TPM2_ECDH_ZGen Response

|                 |              |                                                                                                                                        |
|-----------------|--------------|----------------------------------------------------------------------------------------------------------------------------------------|
| Type            | Name         | Description                                                                                                                            |
| TPM_ST          | tag          | see clause 6                                                                                                                           |
| UINT32          | responseSize |                                                                                                                                        |
| TPM_RC          | responseCode |                                                                                                                                        |
| TPM2B_ECC_POINT | outPoint     | X and Y coordinates of the product of the multiplication *Z* = (*x<sub>Z</sub> , y<sub>Z</sub>*) ≔ \[*hd<sub>S</sub>*\]*Q<sub>B</sub>* |

### Detailed Actions

\[\[ECDH_ZGen\]\]

## TPM2_ECC_Parameters

### General Description

This command returns the parameters of an ECC curve identified by its
TCG-assigned *curveID*.

The value returned is the same as that from the TCG Algorithm Registry,
but may not be the same size.

EXAMPLE The value 01 may be returned as 00000001.

### Command and Response

Table 53 — TPM2_ECC_Parameters Command

|                     |             |                                                                               |
|---------------------|-------------|-------------------------------------------------------------------------------|
| Type                | Name        | Description                                                                   |
| TPMI_ST_COMMAND_TAG | tag         | TPM_ST_SESSIONS if an audit session is present; otherwise, TPM_ST_NO_SESSIONS |
| UINT32              | commandSize |                                                                               |
| TPM_CC              | commandCode | TPM_CC_ECC_Parameters                                                         |
| TPMI_ECC_CURVE      | curveID     | parameter set selector                                                        |

Table 54 — TPM2_ECC_Parameters Response

|                           |              |                                       |
|---------------------------|--------------|---------------------------------------|
| Type                      | Name         | Description                           |
| TPM_ST                    | tag          | see clause 6                          |
| UINT32                    | responseSize |                                       |
| TPM_RC                    | responseCode |                                       |
| TPMS_ALGORITHM_DETAIL_ECC | parameters   | ECC parameters for the selected curve |

### Detailed Actions

\[\[ECC_Parameters\]\]

## TPM2_ZGen_2Phase

### General Description

This command supports two-phase key exchange protocols. The command is
used in combination with TPM2_EC_Ephemeral(). TPM2_EC_Ephemeral()
generates an ephemeral key and returns the public point of that
ephemeral key along with a numeric value that allows the TPM to
regenerate the associated private key.

The input parameters for this command are a static public key (*inQsU*),
an ephemeral key (*inQeU*) from party B, and the *commitCounter*
returned by TPM2_EC_Ephemeral(). The TPM uses the counter value to
regenerate the ephemeral private key (*d<sub>e,V</sub>*) and the
associated public key (*Q<sub>e,V</sub>*). *keyA* provides the static
ephemeral elements *d<sub>s,V</sub>* and *Q<sub>s,V</sub>*. This
provides the two pairs of ephemeral and static keys that are required
for the schemes supported by this command.

The TPM will compute *Z or Z<sub>s</sub>* and *Z<sub>e</sub>* according
to the selected scheme. If the scheme is not a two-phase key exchange
scheme or if the scheme is not supported, the TPM will return
TPM_RC_SCHEME.

It is an error if *inQsB* or *inQeB* are not on the curve of *keyA*
(TPM_RC_ECC_POINT).

The two-phase key schemes that were assigned an algorithm ID as of the
time of the publication of this specification are TPM_ALG_ECDH,
TPM_ALG_ECMQV, and TPM_ALG_SM2.

If this command is supported, then support for TPM_ALG_ECDH is required.
Support for TPM_ALG_ECMQV or TPM_ALG_SM2 is optional.

NOTE 1 If SM2 is supported and this command is supported, then the
implementation is required to support the key exchange protocol of SM2,
part 3.

For TPM_ALG_ECDH *outZ1* will be Zs and *outZ2* will Ze as defined in
6.1.1.2 of SP800-56A.

NOTE 2 An unrestricted decryption key using ECDH may be used in either
TPM2_ECDH_ZGen() or TPM2_ZGen_2Phase as the computation done with the
private part of *keyA* is the same in both cases.

For TPM_ALG_ECMQV or TPM_ALG_SM2 *outZ1* will be *Z* and *outZ2* will be
an Empty Point.

NOTE 3 An Empty Point has two Empty Buffers as coordinates meaning the
minimum *size* value for *outZ2* will be four.

If the input scheme is TPM_ALG_ECDH, then *outZ1* will be
*Z<sub>s</sub>* and outZ2 will be *Z<sub>e</sub>*. For schemes like MQV
(including SM2), *outZ1* will contain the computed value and *outZ2*
will be an Empty Point.

NOTE 4 The Z values returned by the TPM are a full point and not just an
x-coordinate.

If a computation of either Z produces the point at infinity, then the
corresponding Z value will be an Empty Point.

### Command and Response

Table 55 — TPM2_ZGen_2Phase Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_ZGen_2Phase</td>
</tr>
<tr class="odd">
<td>TPMI_DH_OBJECT</td>
<td>@keyA</td>
<td><p>handle of an unrestricted decryption key ECC</p>
<p>The private key referenced by this handle is used as
<em>d<sub>S,A</sub></em></p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPM2B_ECC_POINT</td>
<td>inQsB</td>
<td>other party’s static public key (<em>Q<sub>s,B </sub></em>=
(<em>X<sub>s,B</sub>, Y<sub>s,B</sub></em>))</td>
</tr>
<tr class="odd">
<td>TPM2B_ECC_POINT</td>
<td>inQeB</td>
<td>other party's ephemeral public key (<em>Q<sub>e,B </sub></em>=
(<em>X<sub>e,B</sub>, Y<sub>e,B</sub></em>))</td>
</tr>
<tr class="even">
<td>TPMI_ECC_KEY_EXCHANGE</td>
<td>inScheme</td>
<td>the key exchange scheme</td>
</tr>
<tr class="odd">
<td>UINT16</td>
<td>counter</td>
<td>value returned by TPM2_EC_Ephemeral()</td>
</tr>
</tbody>
</table>

Table 56 — TPM2_ZGen_2Phase Response

|                 |              |                                                                     |
|-----------------|--------------|---------------------------------------------------------------------|
| Type            | Name         | Description                                                         |
| TPM_ST          | tag          |                                                                     |
| UINT32          | responseSize |                                                                     |
| TPM_RC          | responseCode |                                                                     |
| TPM2B_ECC_POINT | outZ1        | X and Y coordinates of the computed value (scheme dependent)        |
| TPM2B_ECC_POINT | outZ2        | X and Y coordinates of the second computed value (scheme dependent) |

### Detailed Actions

\[\[ZGen_2Phase\]\]

## TPM2_ECC_Encrypt

### General Description

This command performs ECC encryption as described in Part 1, Annex D.

The key referenced by *keyHandle* is required to be an ECC key
(TPM_RC_KEY) with the *decrypt* attribute SET (TPM_RC_ATTRIBUTES).

NOTE Because only the public portion of the key needs to be loaded for
this command, the caller can manipulate the attributes of the key in any
way desired

If the default key scheme is TPM_ALG_NULL, an appropriate *inscheme* is
required, and if the default key scheme is not TPM_ALG_NULL, the key
scheme and *inschem*e have to be the same, and the scheme must be a
valid encryption scheme.

The function returns encrypted value *cipherText.*

The *plainText* parameter in the command may be encrypted using
parameter encryption.

### Command and Response

Table 57 — TPM2_ECC_Encrypt Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS if an audit, encrypt, or decrypt session is present;
otherwise, TPM_ST_NO_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_ECC_Encrypt</td>
</tr>
<tr class="odd">
<td>TPMI_DH_OBJECT</td>
<td>keyHandle</td>
<td><p>reference to public portion of ECC key to use for encryption</p>
<p>Auth Index: None</p></td>
</tr>
<tr class="even">
<td>TPM2B_MAX_BUFFER</td>
<td>plainText</td>
<td><p>Plaintext to be encrypted</p>
<p>NOTE 1 The data type was chosen because it limits the overall size of
the input to no greater than MAX_ECC_MESSAGE_BYTES.</p></td>
</tr>
<tr class="odd">
<td>TPMT_KDF_SCHEME+</td>
<td>inScheme</td>
<td>the KDF to use if <em>scheme</em> associated with <em>keyHandle</em>
is TPM_ALG_NULL</td>
</tr>
</tbody>
</table>

Table 58 — TPM2_ECC_Encrypt Response

|                  |              |                                            |
|------------------|--------------|--------------------------------------------|
| Type             | Name         | Description                                |
| TPM_ST           | tag          | see clause 6                               |
| UINT32           | responseSize |                                            |
| TPM_RC           | responseCode |                                            |
| TPM2B_ECC_POINT  | C1           | the public ephemeral key used for ECDH     |
| TPM2B_MAX_BUFFER | C2           | the data block produced by the XOR process |
| TPM2B_DIGEST     | C3           | the integrity value                        |

### Detailed Actions

\[\[TPM2_ECC_Encrypt\]\]

## TPM2_ECC_Decrypt

### General Description

This command performs ECC decryption.

The key referenced by *keyHandle* shall be an ECC key (TPM_RC_KEY) with
*restricted* CLEAR and *decrypt* SET (TPM_RC_ATTRIBUTES).

This command uses the private key of *keyHandle* for this operation and
authorization is required.

If the default key scheme is TPM_ALG_NULL, an appropriate *inscheme* is
required, and if the default key scheme is not TPM_ALG_NULL, the key
scheme and *inschem*e have to be the same,and the scheme must be a valid
decryption scheme.

The function returns decrypted value *plainText.*

The *ciphertext* parameter in the command may be encrypted using
parameter encryption.

### Command and Response

Table 59 — TPM2_ECC_Decrypt Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_ECC_Decrypt</td>
</tr>
<tr class="odd">
<td>TPMI_DH_OBJECT</td>
<td>@keyHandle</td>
<td><p>ECC key to use for decryption</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPM2B_ECC_POINT</td>
<td>C1</td>
<td>the public ephemeral key used for ECDH</td>
</tr>
<tr class="odd">
<td>TPM2B_MAX_BUFFER</td>
<td>C2</td>
<td>the data block produced by the XOR process</td>
</tr>
<tr class="even">
<td>TPM2B_DIGEST</td>
<td>C3</td>
<td>the integrity value</td>
</tr>
<tr class="odd">
<td>TPMT_KDF_SCHEME+</td>
<td>inScheme</td>
<td>the KDF to use if <em>scheme</em> associated with <em>keyHandle</em>
is TPM_ALG_NULL</td>
</tr>
</tbody>
</table>

Table 60 — TPM2_ECC_Decrypt Response

|                  |              |                  |
|------------------|--------------|------------------|
| Type             | Name         | Description      |
| TPM_ST           | tag          | see clause 6     |
| UINT32           | responseSize |                  |
| TPM_RC           | responseCode |                  |
| TPM2B_MAX_BUFFER | plainText    | decrypted output |

### Symmetric Primitives

## Introduction

The commands in this clause provide low-level primitives for access to
the symmetric algorithms implemented in the TPM that operate on blocks
of data. These include symmetric encryption and decryption as well as
hash and HMAC. All of the commands in this group are stateless. That is,
they have no persistent state that is retained in the TPM when the
command is complete.

For hashing, HMAC, and Events that require large blocks of data with
retained state, the sequence commands are provided (see clause 17).

Some of the symmetric encryption/decryption modes use an IV. When an IV
is used, it may be an initiation value or a chained value from a
previous stage. The chaining for each mode is:

Table 61 — Symmetric Chaining Process

<table>
<colgroup>
<col style="width: 20%" />
<col style="width: 79%" />
</colgroup>
<tbody>
<tr class="odd">
<td><strong>Mode</strong></td>
<td><strong>Chaining process</strong></td>
</tr>
<tr class="even">
<td>TPM_ALG_CTR</td>
<td><p>The TPM will increment the entire IV provided by the caller. The
next count value will be returned to the caller as <em>ivOut</em>. This
can be the input value to the next encrypt or decrypt operation.</p>
<p><em>ivIn</em> is required to be the size of a block encrypted by the
selected algorithm and key combination. If the size of <em>ivIn</em> is
not correct, the TPM shall return TPM_RC_SIZE.</p>
<p>EXAMPLE 1 AES requires that <em>ivIn</em> be 128 bits (16
octets).</p>
<p><em>ivOut</em> will be the size of a cipher block and not the size of
the last encrypted block.</p>
<p>NOTE <em>ivOut</em> will be the value of the counter after the last
block is encrypted.</p>
<p>EXAMPLE 2 If <em>ivIn</em> were
00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00<sub>16</sub> and four
data blocks were encrypted, <em>ivOut</em> will have a value of
00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 04<sub>16</sub>.</p>
<p>All the bits of the IV are incremented as if it were an unsigned
integer.</p></td>
</tr>
<tr class="odd">
<td>TPM_ALG_OFB</td>
<td><p>In Output Feedback (OFB), the output of the pseudo-random
function (the block encryption algorithm) is XORed with a plaintext
block to produce a ciphertext block. <em>ivOut</em> will be the value
that was XORed with the last plaintext block. That value can be used as
the <em>ivIn</em> for a next buffer.</p>
<p><em>ivIn</em> is required to be the size of a block encrypted by the
selected algorithm and key combination. If the size of <em>ivIn</em> is
not correct, the TPM shall return TPM_RC_SIZE.</p>
<p><em>ivOut</em> will be the size of a cipher block and not the size of
the last encrypted block.</p></td>
</tr>
<tr class="even">
<td>TPM_ALG_CBC</td>
<td><p>For Cipher Block Chaining (CBC), a block of ciphertext is XORed
with the next plaintext block and that block is encrypted. The encrypted
block is then input to the encryption of the next block. The last
ciphertext block then is used as an IV for the next buffer.</p>
<p>Even though the last ciphertext block is evident in the encrypted
data, it is also returned in <em>ivOut</em>.</p>
<p><em>ivIn</em> is required to be the size of a block encrypted by the
selected algorithm and key combination. If the size of <em>ivIn</em> is
not correct, the TPM shall return TPM_RC_SIZE.</p>
<p><em>inData</em> is required to be an even multiple of the block
encrypted by the selected algorithm and key combination. If the size of
<em>inData</em> is not correct, the TPM shall return
TPM_RC_SIZE.</p></td>
</tr>
<tr class="odd">
<td>TPM_ALG_CFB</td>
<td><p>Similar to CBC in that the last ciphertext block is an input to
the encryption of the next block. <em>ivOut</em> will be the value that
was XORed with the last plaintext block. That value can be used as the
<em>ivIn</em> for a next buffer.</p>
<p><em>ivIn</em> is required to be the size of a block encrypted by the
selected algorithm and key combination. If the size of <em>ivIn</em> is
not correct, the TPM shall return TPM_RC_SIZE.</p>
<p><em>ivOut</em> will be the size of a cipher block and not the size of
the last encrypted block.</p></td>
</tr>
<tr class="even">
<td>TPM_ALG_ECB</td>
<td><p>Electronic Codebook (ECB) has no chaining. Each block of
plaintext is encrypted using the key. ECB does not support chaining and
<em>ivIn</em> shall be the Empty Buffer. <em>ivOut</em> will be the
Empty Buffer.</p>
<p><em>inData</em> is required to be an even multiple of the block
encrypted by the selected algorithm and key combination. If the size of
<em>inData</em> is not correct, the TPM shall return
TPM_RC_SIZE.</p></td>
</tr>
</tbody>
</table>

## TPM2_EncryptDecrypt

### General Description

NOTE 1 This command is deprecated, and TPM2_EncryptDecrypt2() is
preferred. This should be reflected in platform-specific specifications.

This command performs symmetric encryption or decryption using the
symmetric key referenced by keyHandle and the selected mode.

*keyHandle* shall reference a symmetric cipher object (TPM_RC_KEY) with
the *restricted* attribute CLEAR (TPM_RC_ATTRIBUTES).

If the *decrypt* parameter of the command is TRUE, then the *decrypt*
attribute of the key is required to be SET (TPM_RC_ATTRIBUTES). If the
*decrypt* parameter of the command is FALSE, then the *sign* attribute
of the key is required to be SET (TPM_RC_ATTRIBUTES).

NOTE 2 A key may have both *decrypt* and *sign* SET.

If the mode of the key is not TPM_ALG_NULL, then that is the only mode
that can be used with the key and the caller is required to set *mode*
either to TPM_ALG_NULL or to the same mode as the key (TPM_RC_MODE). If
the mode of the key is TPM_ALG_NULL, then the caller may set *mode* to
any valid symmetric encryption/decryption mode but may not select
TPM_ALG_NULL (TPM_RC_MODE).

If the TPM allows this command to be canceled before completion, then
the TPM may produce incremental results and return TPM_RC_SUCCESS rather
than TPM_RC_CANCELED. In such case, *outData* may be less than *inData*.

NOTE 3 If all the data is encrypted/decrypted, the size of outData will
be the same as inData.

### Command and Response

Table 62 — TPM2_EncryptDecrypt Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_EncryptDecrypt</td>
</tr>
<tr class="odd">
<td>TPMI_DH_OBJECT</td>
<td>@keyHandle</td>
<td><p>the symmetric key used for the operation</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPMI_YES_NO</td>
<td>decrypt</td>
<td>if YES, then the operation is decryption; if NO, the operation is
encryption</td>
</tr>
<tr class="odd">
<td>TPMI_ALG_CIPHER_MODE+</td>
<td>mode</td>
<td><p>symmetric encryption/decryption mode</p>
<p>this field shall match the default mode of the key or be
TPM_ALG_NULL.</p></td>
</tr>
<tr class="even">
<td>TPM2B_IV</td>
<td>ivIn</td>
<td>an initial value as required by the algorithm</td>
</tr>
<tr class="odd">
<td>TPM2B_MAX_BUFFER</td>
<td>inData</td>
<td>the data to be encrypted/decrypted</td>
</tr>
</tbody>
</table>

Table 63 — TPM2_EncryptDecrypt Response

|                  |              |                                            |
|------------------|--------------|--------------------------------------------|
| Type             | Name         | Description                                |
| TPM_ST           | tag          | see clause 6                               |
| UINT32           | responseSize |                                            |
| TPM_RC           | responseCode |                                            |
| TPM2B_MAX_BUFFER | outData      | encrypted or decrypted output              |
| TPM2B_IV         | ivOut        | chaining value to use for IV in next round |

### Detailed Actions

\[\[EncryptDecrypt\]\]

## TPM2_EncryptDecrypt2

### General Description

This command is identical to TPM2_EncryptDecrypt(), except that the
*inData* parameter is the first parameter. This permits *inData* to be
parameter encrypted.

NOTE In platform specification updates, this command is preferred and
TPM2_EncryptDecrypt() should be deprecated.

### Comand and Response

Table 64 — TPM2_EncryptDecrypt2 Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_EncryptDecrypt2</td>
</tr>
<tr class="odd">
<td>TPMI_DH_OBJECT</td>
<td>@keyHandle</td>
<td><p>the symmetric key used for the operation</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPM2B_MAX_BUFFER</td>
<td>inData</td>
<td>the data to be encrypted/decrypted</td>
</tr>
<tr class="odd">
<td>TPMI_YES_NO</td>
<td>decrypt</td>
<td>if YES, then the operation is decryption; if NO, the operation is
encryption</td>
</tr>
<tr class="even">
<td>TPMI_ALG_CIPHER_MODE+</td>
<td>mode</td>
<td><p>symmetric mode</p>
<p>this field shall match the default mode of the key or be
TPM_ALG_NULL.</p></td>
</tr>
<tr class="odd">
<td>TPM2B_IV</td>
<td>ivIn</td>
<td>an initial value as required by the algorithm</td>
</tr>
</tbody>
</table>

Table 65 — TPM2_EncryptDecrypt2 Response

|                  |              |                                            |
|------------------|--------------|--------------------------------------------|
| Type             | Name         | Description                                |
| TPM_ST           | tag          | see clause 6                               |
| UINT32           | responseSize |                                            |
| TPM_RC           | responseCode |                                            |
| TPM2B_MAX_BUFFER | outData      | encrypted or decrypted output              |
| TPM2B_IV         | ivOut        | chaining value to use for IV in next round |

### Detailed Actions

\[\[EncryptDecrypt2\]\]

## TPM2_Hash

### General Description

This command performs a hash operation on a data buffer and returns the
results.

NOTE If the data buffer to be hashed is larger than will fit into the
TPM’s input buffer, then the sequence hash commands will need to be
used.

If the results of the hash will be used in a signing operation that uses
a restricted signing key, then the ticket returned by this command can
indicate that the hash is safe to sign.

If the digest is not safe to sign, then the TPM will return a
TPMT_TK_HASHCHECK with the hierarchy set to TPM_RH_NULL and *digest* set
to the Empty Buffer.

If *hierarchy* is TPM_RH_NULL, then *digest* in the ticket will be the
Empty Buffer*.*

### Command and Response

Table 66 — TPM2_Hash Command

|                     |             |                                                                                                    |
|---------------------|-------------|----------------------------------------------------------------------------------------------------|
| Type                | Name        | Description                                                                                        |
| TPMI_ST_COMMAND_TAG | tag         | TPM_ST_SESSIONS if an audit, decrypt, or encrypt session is present; otherwise, TPM_ST_NO_SESSIONS |
| UINT32              | commandSize |                                                                                                    |
| TPM_CC              | commandCode | TPM_CC_Hash                                                                                        |
| TPM2B_MAX_BUFFER    | data        | data to be hashed                                                                                  |
| TPMI_ALG_HASH       | hashAlg     | algorithm for the hash being computed – shall not be TPM_ALG_NULL                                  |
| TPMI_RH_HIERARCHY+  | hierarchy   | hierarchy to use for the ticket (TPM_RH_NULL allowed)                                              |

Table 67 — TPM2_Hash Response

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPM_ST</td>
<td>tag</td>
<td>see clause 6</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>responseSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_RC</td>
<td>responseCode</td>
<td></td>
</tr>
<tr class="odd">
<td>TPM2B_DIGEST</td>
<td>outHash</td>
<td>results</td>
</tr>
<tr class="even">
<td>TPMT_TK_HASHCHECK</td>
<td>validation</td>
<td><p>ticket indicating that the sequence of octets used to compute
<em>outDigest</em> did not start with TPM_GENERATED_VALUE</p>
<p>will be a NULL ticket if the digest may not be signed with a
restricted key</p></td>
</tr>
</tbody>
</table>

### Detailed Actions

\[\[HASH\]\]

## TPM2_HMAC

### General Description

This command performs an HMAC on the supplied data using the indicated
hash algorithm.

NOTE 1 A TPM may implement either TPM2_HMAC() or TPM2_MAC() but not
both, as they have the same command code and there is no way to
distinguish them. A TPM that supports TPM2_MAC() will support any code
that was written to use TPM2_HMAC(), but a TPM that supports TPM2_HMAC()
will not support a MAC based on symmetric block ciphers.

The caller shall provide proper authorization for use of *handle*.

If the *sign* attribute is not SET in the key referenced by *handle*
then the TPM shall return TPM_RC_KEY. If the key type is not
TPM_ALG_KEYEDHASH then the TPM shall return TPM_RC_TYPE. If the key
referenced by *handle* has the *restricted* attribute SET, the TPM shall
return TPM_RC_ATTRIBUTES.

NOTE 2 For symmetric signing with a restricted key, see TPM2_Sign.

If the default scheme of the key referenced by *handle* is not
TPM_ALG_NULL, then the *hashAlg* parameter is required to be either the
same as the key’s default or TPM_ALG_NULL (TPM_RC_VALUE). If the default
scheme of the key is TPM_ALG_NULL, then hashAlg is required to be a
valid hash and not TPM_ALG_NULL (TPM_RC_VALUE) (see hash selection
matrix in

Table 76 ).

NOTE 3 A key may only have both sign and decrypt SET if the key is
unrestricted. When both sign and decrypt are set, there is no default
scheme for the key and the hash algorithm must be specified.

### Command and Response

Table 68 — TPM2_HMAC Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_HMAC</td>
</tr>
<tr class="odd">
<td>TPMI_DH_OBJECT</td>
<td>@handle</td>
<td><p>handle for the symmetric signing key providing the HMAC key</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPM2B_MAX_BUFFER</td>
<td>buffer</td>
<td>HMAC data</td>
</tr>
<tr class="odd">
<td>TPMI_ALG_HASH+</td>
<td>hashAlg</td>
<td>algorithm to use for HMAC</td>
</tr>
</tbody>
</table>

Table 69 — TPM2_HMAC Response

|              |              |                                     |
|--------------|--------------|-------------------------------------|
| Type         | Name         | Description                         |
| TPM_ST       | tag          | see clause 6                        |
| UINT32       | responseSize |                                     |
| TPM_RC       | responseCode |                                     |
| TPM2B_DIGEST | outHMAC      | the returned HMAC in a sized buffer |

### Detailed Actions

\[\[HMAC\]\]

## TPM2_MAC

### General Description

This command performs an HMAC or a block cipher MAC on the supplied data
using the indicated algorithm.

NOTE 1 A TPM may implement either TPM2_HMAC() or TPM2_MAC() but not both
as they have the same command code and there is no way to distinguish
them. A TPM that supports TPM2_MAC() will support any code that was
written to use TPM2_HMAC() but a TPM that supports TPM2_HMAC () will not
support a MAC based on symmetric block ciphers.

The caller shall provide proper authorization for use of *handle*.

If the *sign* attribute is not SET in the key referenced by *handle*
then the TPM shall return TPM_RC_KEY. If the key type is neither
TPM_ALG_KEYEDHASH nor TPM_ALG_SYMCIPHER then the TPM shall return
TPM_RC_TYPE. If the key referenced by *handle* has the *restricted*
attribute SET, the TPM shall return TPM_RC_ATTRIBUTES.

NOTE 2 For symmetric signing with a restricted key, see TPM2_Sign.

If the default scheme or mode of the key referenced by *handle* is not
TPM_ALG_NULL, then the *inScheme* parameter is required to be either the
same as the key’s default or TPM_ALG_NULL (TPM_RC_VALUE).

If the default scheme of an HMAC key is TPM_ALG_NULL, then *inScheme* is
required to be a valid hash and not TPM_ALG_NULL (TPM_RC_VALUE) (see
algorithm selection matrix in

Table 79 ).

If the default mode of a symmetric cipher key is TPM_ALG_NULL, then
*inScheme* is required to be a valid block cipher mode for
authentication and not TPM_ALG_NULL (TPM_RC_VALUE)

NOTE 3 A key may only have both sign and decrypt SET if the key is
unrestricted. When both sign and decrypt are set, there is no default
scheme for the key and *inScheme* may not be TPM_ALG_NULL.

NOTE 4 TPM2_MAC() was added in revision 01.43.

### Command and Response

Table 70 — TPM2_MAC Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_MAC</td>
</tr>
<tr class="odd">
<td>TPMI_DH_OBJECT</td>
<td>@handle</td>
<td><p>handle for the symmetric signing key providing the MAC key</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPM2B_MAX_BUFFER</td>
<td>buffer</td>
<td>MAC data</td>
</tr>
<tr class="odd">
<td>TPMI_ALG_MAC_SCHEME+</td>
<td>inScheme</td>
<td>algorithm to use for MAC</td>
</tr>
</tbody>
</table>

Table 71 — TPM2_MAC Response

|              |              |                                    |
|--------------|--------------|------------------------------------|
| Type         | Name         | Description                        |
| TPM_ST       | tag          | see clause 6                       |
| UINT32       | responseSize |                                    |
| TPM_RC       | responseCode |                                    |
| TPM2B_DIGEST | outMAC       | the returned MAC in a sized buffer |

### Detailed Actions

\[\[MAC\]\]

# Random Number Generator

## TPM2_GetRandom

### General Description

This command returns the next *bytesRequested* octets from the random
number generator (RNG).

NOTE 1 It is recommended that a TPM implement the RNG in a manner that
would allow it to return RNG octets such that, as long as the value of
*bytesRequested* is not greater than the maximum digest size, the
frequency of *bytesRequested* being more than the number of octets
available is an infrequent occurrence.

If *bytesRequested* is more than will fit into a TPM2B_DIGEST on the
TPM, no error is returned but the TPM will only return as much data as
will fit into a TPM2B_DIGEST buffer for the TPM.

NOTE 2 TPM2B_DIGEST is large enough to hold the largest digest that may
be produced by the TPM. Because that digest size changes according to
the implemented hashes, the maximum amount of data returned by this
command is TPM implementation-dependent.

### Command and Response

Table 72 — TPM2_GetRandom Command

|                     |                |                                                                                          |
|---------------------|----------------|------------------------------------------------------------------------------------------|
| Type                | Name           | Description                                                                              |
| TPMI_ST_COMMAND_TAG | tag            | TPM_ST_SESSIONS if an audit or encrypt session is present; otherwise, TPM_ST_NO_SESSIONS |
| UINT32              | commandSize    |                                                                                          |
| TPM_CC              | commandCode    | TPM_CC_GetRandom                                                                         |
| UINT16              | bytesRequested | number of octets to return                                                               |

Table 73 — TPM2_GetRandom Response

|              |              |                   |
|--------------|--------------|-------------------|
| Type         | Name         | Description       |
| TPM_ST       | tag          | see clause 6      |
| UINT32       | responseSize |                   |
| TPM_RC       | responseCode |                   |
| TPM2B_DIGEST | randomBytes  | the random octets |

### Detailed Actions

\[\[GetRandom\]\]

## TPM2_StirRandom

### General Description

This command is used to add "additional information" to the RNG state.

NOTE The "additional information" is as defined in SP800-90A.

The *inData* parameter may not be larger than 128 octets.

### Command and Response

Table 74 — TPM2_StirRandom Command

|                      |             |                                                                                          |
|----------------------|-------------|------------------------------------------------------------------------------------------|
| Type                 | Name        | Description                                                                              |
| TPMI_ST_COMMAND_TAG  | tag         | TPM_ST_SESSIONS if an audit or decrypt session is present; otherwise, TPM_ST_NO_SESSIONS |
| UINT32               | commandSize |                                                                                          |
| TPM_CC               | commandCode | TPM_CC_StirRandom {NV}                                                                   |
| TPM2B_SENSITIVE_DATA | inData      | additional information                                                                   |

Table 75 — TPM2_StirRandom Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[StirRandom\]\]

# Hash/HMAC/Event Sequences

## Introduction

All of the commands in this group are to support sequences for which an
intermediate state must be maintained. For a description of sequences,
see “Hash, MAC, and Event Sequences” in TPM 2.0 Part 1.

A TPM may implement either TPM2_HMAC_Start() or TPM2_MAC_Start() but not
both as they have the same command code and there is no way to
distinguish them. A TPM that supports TPM2_MAC_Start() will support any
code that was written to use TPM2_HMAC_Start() but a TPM that supports
TPM2_HMAC_Start() will not support a MAC based on symmetric block
ciphers.

## TPM2_HMAC_Start

### General Description

This command starts an HMAC sequence. The TPM will create and initialize
an HMAC sequence structure, assign a handle to the sequence, and set the
*authValue* of the sequence object to the value in *auth*.

NOTE 1 The structure of a sequence object is vendor-dependent.

The caller shall provide proper authorization for use of *handle*.

If the *sign* attribute is not SET in the key referenced by *handle*
then the TPM shall return TPM_RC_KEY. If the key type is not
TPM_ALG_KEYEDHASH then the TPM shall return TPM_RC_TYPE. If the key
referenced by *handle* has the *restricted* attribute SET, the TPM shall
return TPM_RC_ATTRIBUTES.

NOTE 2 For symmetric signing with a restricted key, see TPM2_Sign.

If the default scheme of the key referenced by *handle* is not
TPM_ALG_NULL, then the *hashAlg* parameter is required to be either the
same as the key’s default or TPM_ALG_NULL (TPM_RC_VALUE). If the default
scheme of the key is TPM_ALG_NULL, then hashAlg is required to be a
valid hash and not TPM_ALG_NULL (TPM_RC_VALUE).

Table 76 — Hash Selection Matrix

<table>
<colgroup>
<col style="width: 20%" />
<col style="width: 22%" />
<col style="width: 28%" />
<col style="width: 27%" />
</colgroup>
<thead>
<tr class="header">
<th><p><em>handle→restricted</em></p>
<p>(key's restricted attribute)</p></th>
<th><p><em>handle→scheme</em></p>
<p>(hash algorithm from key's <em>scheme</em>)</p></th>
<th><em>hashAlg</em></th>
<th>hash used</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>CLEAR (unrestricted)</td>
<td>TPM_ALG_NULL<sup>(1)</sup></td>
<td>TPM_ALG_NULL</td>
<td>error<sup>(1)</sup> (TPM_RC_VALUE)</td>
</tr>
<tr class="even">
<td>CLEAR</td>
<td>TPM_ALG_NULL</td>
<td>valid hash</td>
<td><em>hashAlg</em></td>
</tr>
<tr class="odd">
<td>CLEAR</td>
<td>valid hash</td>
<td>TPM_ALG_NULL or same as <em>handle→scheme</em></td>
<td><em>handle→scheme</em></td>
</tr>
<tr class="even">
<td>CLEAR</td>
<td>valid hash</td>
<td>valid hash</td>
<td>error (TPM_RC_VALUE) if <em>hashAlg</em> !=
<em>handle-&gt;scheme</em></td>
</tr>
<tr class="odd">
<td>SET (restricted)</td>
<td>don't care</td>
<td>don't care</td>
<td>TPM_RC_ATTRIBUTES</td>
</tr>
<tr class="even">
<td colspan="4"><p>NOTES:</p>
<p>1) A hash algorithm is required for the HMAC.</p></td>
</tr>
</tbody>
</table>

NOTE 1 A TPM may implement either TPM2_HMAC_Start() or TPM2_MAC_Start()
but not both, as they have the same command code and there is no way to
distinguish them. A TPM that supports TPM2_MAC_Start() will support any
code that was written to use TPM2_HMAC_Start(), but a TPM that supports
TPM2_HMAC_Start() will not support a MAC based on symmetric block
ciphers.

### Command and Response

Table 77 — TPM2_HMAC_Start Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_HMAC_Start</td>
</tr>
<tr class="odd">
<td>TPMI_DH_OBJECT</td>
<td>@handle</td>
<td><p>handle of an HMAC key</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPM2B_AUTH</td>
<td>auth</td>
<td>authorization value for subsequent use of the sequence</td>
</tr>
<tr class="odd">
<td>TPMI_ALG_HASH+</td>
<td>hashAlg</td>
<td>the hash algorithm to use for the HMAC</td>
</tr>
</tbody>
</table>

Table 78 — TPM2_HMAC_Start Response

|                |                |                                    |
|----------------|----------------|------------------------------------|
| Type           | Name           | Description                        |
| TPM_ST         | tag            | see clause 6                       |
| UINT32         | responseSize   |                                    |
| TPM_RC         | responseCode   |                                    |
| TPMI_DH_OBJECT | sequenceHandle | a handle to reference the sequence |

### Detailed Actions

\[\[HMAC_Start\]\]

## TPM2_MAC_Start

### General Description

This command starts a MAC sequence. The TPM will create and initialize a
MAC sequence structure, assign a handle to the sequence, and set the
*authValue* of the sequence object to the value in *auth*.

NOTE 1 The structure of a sequence object is vendor-dependent.

The caller shall provide proper authorization for use of *handle*.

If the *sign* attribute is not SET in the key referenced by *handle*
then the TPM shall return TPM_RC_KEY. If the key type is not
TPM_ALG_KEYEDHASH or TPM_ALG_SYMCIPHER then the TPM shall return
TPM_RC_TYPE. If the key referenced by *handle* has the *restricted*
attribute SET, the TPM shall return TPM_RC_ATTRIBUTES.

NOTE 2 For symmetric signing with a restricted key, see TPM2_Sign.

If the default scheme of the key referenced by *handle* is not
TPM_ALG_NULL, then the *inScheme* parameter is required to be either the
same as the key’s default or TPM_ALG_NULL (TPM_RC_VALUE). If the default
scheme of the key is TPM_ALG_NULL, then *inScheme*is required to be a
valid hash or symmetric MAC scheme and not TPM_ALG_NULL (TPM_RC_VALUE).

Table 79 — Algorithm Selection Matrix

<table>
<colgroup>
<col style="width: 20%" />
<col style="width: 22%" />
<col style="width: 28%" />
<col style="width: 27%" />
</colgroup>
<thead>
<tr class="header">
<th><p><em>handle→restricted</em></p>
<p>(key's restricted attribute)</p></th>
<th><p><em>handle→scheme</em></p>
<p>(algorithm from key's <em>scheme</em>)</p></th>
<th><em>inScheme</em></th>
<th>algorithm used</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>CLEAR (unrestricted)</td>
<td>TPM_ALG_NULL<sup>(1)</sup></td>
<td>TPM_ALG_NULL</td>
<td>error<sup>(1)</sup> (TPM_RC_VALUE)</td>
</tr>
<tr class="even">
<td>CLEAR</td>
<td>TPM_ALG_NULL</td>
<td>valid hash or symmetric MAC</td>
<td><em>inScheme</em></td>
</tr>
<tr class="odd">
<td>CLEAR</td>
<td>not TPM_ALG_NULL</td>
<td>TPM_ALG_NULL or same as <em>handle→scheme</em></td>
<td><em>handle→scheme</em></td>
</tr>
<tr class="even">
<td>CLEAR</td>
<td>not TPM_ALG_NULL</td>
<td>not TPM_AGL_NULL</td>
<td>error (TPM_RC_VALUE) if<em>inScheme</em>!=
<em>handle-&gt;scheme</em></td>
</tr>
<tr class="odd">
<td>SET (restricted)</td>
<td>don't care</td>
<td>don't care</td>
<td>TPM_RC_ATTRIBUTES</td>
</tr>
<tr class="even">
<td colspan="4"><p>NOTES:</p>
<p>1) A hash algorithm is required for the HMAC.</p>
<p>2) hashAlg shall be TPM_ALG_NULL for handle referencing a CMAC
key.</p></td>
</tr>
</tbody>
</table>

NOTE 3 For a TPM_ALG_SYMCIPHER key, the symmetric block cipher algorithm
is part of the key definition.

NOTE 4 TPM2_MAC_Start() was added in revision 01.43.

### Command and Response

Table 80 — TPM2_MAC_Start Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_MAC_Start</td>
</tr>
<tr class="odd">
<td>TPMI_DH_OBJECT</td>
<td>@handle</td>
<td><p>handle of a MAC key</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPM2B_AUTH</td>
<td>auth</td>
<td>authorization value for subsequent use of the sequence</td>
</tr>
<tr class="odd">
<td>TPMI_ALG_MAC_SCHEME+</td>
<td>inScheme</td>
<td>the algorithm to use for the MAC</td>
</tr>
</tbody>
</table>

Table 81 — TPM2_MAC_Start Response

|                |                |                                    |
|----------------|----------------|------------------------------------|
| Type           | Name           | Description                        |
| TPM_ST         | tag            | see clause 6                       |
| UINT32         | responseSize   |                                    |
| TPM_RC         | responseCode   |                                    |
| TPMI_DH_OBJECT | sequenceHandle | a handle to reference the sequence |

### Detailed Actions

\[\[MAC_Start\]\]

## TPM2_HashSequenceStart

### General Description

This command starts a hash or an Event Sequence. If *hashAlg* is an
implemented hash, then a hash sequence is started. If *hashAlg* is
TPM_ALG_NULL, then an Event Sequence is started. If *hashAlg* is neither
an implemented algorithm nor TPM_ALG_NULL, then the TPM shall return
TPM_RC_HASH.

Depending on *hashAlg*, the TPM will create and initialize a Hash
Sequence context or an Event Sequence context. Additionally, it will
assign a handle to the context and set the *authValue* of the context to
the value in *auth*. A sequence context for an Event (*hashAlg* =
TPM_ALG_NULL) contains a hash context for each of the PCR banks
implemented on the TPM.

### Command and Response

Table 82 — TPM2_HashSequenceStart Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS if an audit or decrypt session is present;
otherwise, TPM_ST_NO_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_HashSequenceStart</td>
</tr>
<tr class="odd">
<td>TPM2B_AUTH</td>
<td>auth</td>
<td>authorization value for subsequent use of the sequence</td>
</tr>
<tr class="even">
<td>TPMI_ALG_HASH+</td>
<td>hashAlg</td>
<td><p>the hash algorithm to use for the hash sequence</p>
<p>An Event Sequence starts if this is TPM_ALG_NULL.</p></td>
</tr>
</tbody>
</table>

Table 83 — TPM2_HashSequenceStart Response

|                |                |                                    |
|----------------|----------------|------------------------------------|
| Type           | Name           | Description                        |
| TPM_ST         | tag            | see clause 6                       |
| UINT32         | responseSize   |                                    |
| TPM_RC         | responseCode   |                                    |
| TPMI_DH_OBJECT | sequenceHandle | a handle to reference the sequence |

### Detailed Actions

\[\[HashSequenceStart\]\]

## TPM2_SequenceUpdate

### General Description

This command is used to add data to a hash or HMAC sequence. The amount
of data in buffer may be any size up to the limits of the TPM.

NOTE 1 In all TPM, a *buffer* size of 1,024 octets is allowed.

Proper authorization for the sequence object associated with
*sequenceHandle* is required. If an authorization or audit of this
command requires computation of a *cpHash* and an *rpHash*, the Name
associated with *sequenceHandle* will be the Empty Buffer.

If the command does not return TPM_RC_SUCCESS, the state of the sequence
is unmodified.

If the sequence is intended to produce a digest that will be signed by a
restricted signing key, then the first block of data shall contain
sizeof(TPM_GENERATED) octets and the first octets shall not be
TPM_GENERATED_VALUE.

NOTE 2 This requirement allows the TPM to validate that the first block
is safe to sign without having to accumulate octets over multiple calls.

### Command and Response

Table 84 — TPM2_SequenceUpdate Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_SequenceUpdate</td>
</tr>
<tr class="odd">
<td>TPMI_DH_OBJECT</td>
<td>@sequenceHandle</td>
<td><p>handle for the sequence object</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPM2B_MAX_BUFFER</td>
<td>buffer</td>
<td>data to be added to hash</td>
</tr>
</tbody>
</table>

Table 85 — TPM2_SequenceUpdate Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[SequenceUpdate\]\]

## TPM2_SequenceComplete

### General Description

This command adds the last part of data, if any, to a hash/HMAC sequence
and returns the result.

NOTE 1 This command is not used to complete an Event Sequence.
TPM2_EventSequenceComplete() is used for that purpose.

For a hash sequence, if the results of the hash will be used in a
signing operation that uses a restricted signing key, then the ticket
returned by this command can indicate that the hash is safe to sign.

If the *digest* is not safe to sign, then *validation* will be a
TPMT_TK_HASHCHECK with the hierarchy set to TPM_RH_NULL and *digest* set
to the Empty Buffer.

If *hierarchy* is TPM_RH_NULL, then *digest* in the ticket will be the
Empty Buffer*.*

NOTE 2 Regardless of the contents of the first octets of the hashed
message, if the first buffer sent to the TPM had fewer than
sizeof(TPM_GENERATED) octets, then the TPM will operate as if *digest*
is not safe to sign.

NOTE 3 The ticket is only required for a signing operation that uses a
restricted signing key. It is always returned, but can be ignored if not
needed.

If *sequenceHandle* references an Event Sequence, then the TPM shall
return TPM_RC_MODE.

Proper authorization for the sequence object associated with
*sequenceHandle* is required. If an authorization or audit of this
command requires computation of a *cpHash* and an *rpHash*, the Name
associated with *sequenceHandle* will be the Empty Buffer.

If this command completes successfully, the *sequenceHandle* object will
be flushed.

### Command and Response

Table 86 — TPM2_SequenceComplete Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_SequenceComplete {F}</td>
</tr>
<tr class="odd">
<td>TPMI_DH_OBJECT</td>
<td>@sequenceHandle</td>
<td><p>authorization for the sequence</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPM2B_MAX_BUFFER</td>
<td>buffer</td>
<td>data to be added to the hash/HMAC</td>
</tr>
<tr class="odd">
<td>TPMI_RH_HIERARCHY+</td>
<td>hierarchy</td>
<td>hierarchy of the ticket for a hash</td>
</tr>
</tbody>
</table>

Table 87 — TPM2_SequenceComplete Response

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPM_ST</td>
<td>tag</td>
<td>see clause 6</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>responseSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_RC</td>
<td>responseCode</td>
<td></td>
</tr>
<tr class="odd">
<td>TPM2B_DIGEST</td>
<td>result</td>
<td>the returned HMAC or digest in a sized buffer</td>
</tr>
<tr class="even">
<td>TPMT_TK_HASHCHECK</td>
<td>validation</td>
<td><p>ticket indicating that the sequence of octets used to compute
<em>outDigest</em> did not start with TPM_GENERATED_VALUE</p>
<p>This is a NULL Ticket when the sequence is HMAC.</p></td>
</tr>
</tbody>
</table>

### Detailed Actions

\[\[SequenceComplete\]\]

## TPM2_EventSequenceComplete

### General Description

This command adds the last part of data, if any, to an Event Sequence
and returns the result in a digest list. If *pcrHandle* references a PCR
and not TPM_RH_NULL, then the returned digest list is processed in the
same manner as the digest list input parameter to TPM2_PCR_Extend().
That is, if a bank contains a PCR associated with *pcrHandle,* it is
extended with the associated digest value from the list.

If *sequenceHandle* references a hash or HMAC sequence, the TPM shall
return TPM_RC_MODE.

Proper authorization for the sequence object associated with
*sequenceHandle* is required. If an authorization or audit of this
command requires computation of a *cpHash* and an *rpHash*, the Name
associated with *sequenceHandle* will be the Empty Buffer.

If this command completes successfully, the *sequenceHandle* object will
be flushed.

NOTE: Unlike TPM2_PCR_Event(), a digest is always returned for each
implemented hash algorithm. There is no option to only return digests
for which *pcrHandle* is allocated.

### Command and Response

Table 88 — TPM2_EventSequenceComplete Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_EventSequenceComplete {NV F}</td>
</tr>
<tr class="odd">
<td>TPMI_DH_PCR+</td>
<td>@pcrHandle</td>
<td><p>PCR to be extended with the Event data</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPMI_DH_OBJECT</td>
<td>@sequenceHandle</td>
<td><p>authorization for the sequence</p>
<p>Auth Index: 2</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="odd">
<td>TPM2B_MAX_BUFFER</td>
<td>buffer</td>
<td>data to be added to the Event</td>
</tr>
</tbody>
</table>

Table 89 — TPM2_EventSequenceComplete Response

|                    |              |                                      |
|--------------------|--------------|--------------------------------------|
| Type               | Name         | Description                          |
| TPM_ST             | tag          | see clause 6                         |
| UINT32             | responseSize |                                      |
| TPM_RC             | responseCode |                                      |
| TPML_DIGEST_VALUES | results      | list of digests computed for the PCR |

### Detailed Actions

\[\[EventSequenceComplete\]\]

# Attestation Commands

## Introduction

The attestation commands cause the TPM to sign an internally generated
data structure. The contents of the data structure vary according to the
command.

If the *sign* attribute is not SET in the key referenced by *signHandle*
then the TPM shall return TPM_RC_KEY.

All signing commands include a parameter (typically *inScheme*) for the
caller to specify a scheme to be used for the signing operation. This
scheme will be applied only if the scheme of the key is TPM_ALG_NULL or
the key handle is TPM_RH_NULL. If the scheme for *signHandle* is not
TPM_ALG_NULL, then *inScheme.scheme* shall be TPM_ALG_NULL or the same
as *scheme* in the public area of the key. If the scheme for
*signHandle* is TPM_ALG_NULL or the key handle is TPM_RH_NULL, then
*inScheme* will be used for the signing operation and may not be
TPM_ALG_NULL. The TPM shall return TPM_RC_SCHEME to indicate that the
scheme is not appropriate.

For a signing key that is not restricted, the caller may specify the
scheme to be used as long as the scheme is compatible with the family of
the key (for example, TPM_ALG_RSAPSS cannot be selected for an ECC key).
If the caller sets *scheme* to TPM_ALG_NULL, then the default scheme of
the key is used. For a restricted signing key, the key's scheme cannot
be TPM_ALG_NULL and cannot be overridden.

If the handle for the signing key (*signHandle*) is TPM_RH_NULL, then
all of the actions of the command are performed and the attestation
block is “signed” with the NULL Signature.

NOTE 1 This mechanism is provided so that additional commands are not
required to access the data that might be in an attestation structure.

NOTE 2 When *signHandle* is TPM_RH_NULL, *scheme* is still required to
be a valid signing scheme (may be TPM_ALG_NULL), but the scheme will
have no effect on the format of the signature. It will always be the
NULL Signature.

TPM2_NV_Certify() is an attestation command that is documented in 31.16.
The remaining attestation commands are collected in the remainder of
this clause.

Each of the attestation structures contains a TPMS_CLOCK_INFO structure
and a firmware version number. These values may be considered
privacy-sensitive, because they would aid in the correlation of
attestations by different keys. To provide improved privacy, the
*resetCount*, *restartCount*, and *firmwareV*ersion numbers are
obfuscated when the signing key is not in the Endorsement or Platform
hierarchies.

The obfuscation value is computed by:

obfuscation ≔ **KDFa**(signHandle→nameAlg, shProof, “OBFUSCATE”,
signHandle→QN, 0, 128) 1

Of the returned 128 bits, 64 bits are added to the *versionNumber* field
of the attestation structure; 32 bits are added to the
*clockInfo.resetCount* and 32 bits are added to the
*clockInfo.restartCount*. The order in which the bits are added is
implementation-dependent.

NOTE 3 The obfuscation value for each signing key will be unique to that
key in a specific location. That is, each version of a duplicated
signing key will have a different obfuscation value.

When the signing key is TPM_RH_NULL, the data structure is produced but
not signed; and the values in the signed data structure are obfuscated.
When computing the obfuscation value for TPM_RH_NULL, the hash used for
context integrity is used.

NOTE 4 The QN for TPM_RH_NULL is TPM_RH_NULL.

If the signing scheme of *signHandle* is an anonymous scheme, then the
attestation blocks will not contain the Qualified Name of the
*signHandle*.

Each of the attestation structures allows the caller to provide some
qualifying data (*qualifyingData*). For most signing schemes, this value
will be placed in the TPMS_ATTEST.*extraData* parameter that is then
hashed and signed. However, for some schemes such as ECDAA, the
*qualifyingData* is used in a different manner (for details, see “ECDAA”
in TPM 2.0 Part 1).

## TPM2_Certify

### General Description

The purpose of this command is to prove that an object with a specific
Name is loaded in the TPM. By certifying that the object is loaded, the
TPM warrants that a public area with a given Name is self-consistent and
associated with a valid sensitive area. If a relying party has a public
area that has the same Name as a Name certified with this command, then
the values in that public area are correct.

NOTE 1 See 18.1 for description of how the signing scheme is selected.

Authorization for *objectHandle* requires ADMIN role authorization. If
performed with a policy session, the session shall have a
policySession→*commandCode* set to TPM_CC_Certify. This indicates that
the policy that is being used is a policy that is for certification, and
not a policy that would approve another use. That is, authority to use
an object does not grant authority to certify the object.

The object may be any object that is loaded with TPM2_Load() or
TPM2_CreatePrimary(). An object that only has its public area loaded
cannot be certified.

NOTE 2 The restriction occurs because the Name is used to identify the
object being certified. If the TPM has not validated that the public
area is associated with a matched sensitive area, then the public area
may not represent a valid object and cannot be certified.

The certification includes the Name and Qualified Name of the certified
object as well as the Name and the Qualified Name of the certifying
object.

NOTE 3 If *signHandle* is TPM_RH_NULL, the TPMS_ATTEST structure is
returned and *signature* is a NULL Signature.

### Command and Response

Table 90 — TPM2_Certify Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_Certify</td>
</tr>
<tr class="odd">
<td>TPMI_DH_OBJECT</td>
<td>@objectHandle</td>
<td><p>handle of the object to be certified</p>
<p>Auth Index: 1</p>
<p>Auth Role: ADMIN</p></td>
</tr>
<tr class="even">
<td>TPMI_DH_OBJECT+</td>
<td>@signHandle</td>
<td><p>handle of the key used to sign the attestation structure</p>
<p>Auth Index: 2</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="odd">
<td>TPM2B_DATA</td>
<td>qualifyingData</td>
<td>user provided qualifying data</td>
</tr>
<tr class="even">
<td>TPMT_SIG_SCHEME+</td>
<td>inScheme</td>
<td>signing scheme to use if the <em>scheme</em> for <em>signHandle</em>
is TPM_ALG_NULL</td>
</tr>
</tbody>
</table>

Table 91 — TPM2_Certify Response

|                |              |                                                                                      |
|----------------|--------------|--------------------------------------------------------------------------------------|
| Type           | Name         | Description                                                                          |
| TPM_ST         | tag          | see clause 6                                                                         |
| UINT32         | responseSize |                                                                                      |
| TPM_RC         | responseCode | .                                                                                    |
| TPM2B_ATTEST   | certifyInfo  | the structure that was signed                                                        |
| TPMT_SIGNATURE | signature    | the asymmetric signature over *certifyInfo* using the key referenced by *signHandle* |

### Detailed Actions

\[\[Certify\]\]

## TPM2_CertifyCreation

### General Description

This command is used to prove the association between an object and its
creation data. The TPM will validate that the ticket was produced by the
TPM and that the ticket validates the association between a loaded
public area and the provided hash of the creation data (*creationHash*).

NOTE 1 See 18.1 for description of how the signing scheme is selected.

The TPM will create a test ticket using the Name associated with
*objectHandle* and *creationHash* as:

**HMAC**(proof, (TPM_ST_CREATION \|\| objectHandle→Name \|\|
creationHash)) 1

This ticket is then compared to creation ticket. If the tickets are not
the same, the TPM shall return TPM_RC_TICKET.

If the ticket is valid, then the TPM will create a TPMS_ATTEST structure
and place *creationHash* of the command in the *creationHash* field of
the structure. The Name associated with *objectHandle* will be included
in the attestation data that is then signed using the key associated
with *signHandle*.

NOTE 2 If *signHandle* is TPM_RH_NULL, the TPMS_ATTEST structure is
returned and *signature* is a NULL Signature.

*objectHandle* may be any object that is loaded with TPM2_Load() or
TPM2_CreatePrimary().

### Command and Response

Table 92 — TPM2_CertifyCreation Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_CertifyCreation</td>
</tr>
<tr class="odd">
<td>TPMI_DH_OBJECT+</td>
<td>@signHandle</td>
<td><p>handle of the key that will sign the attestation block</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPMI_DH_OBJECT</td>
<td>objectHandle</td>
<td><p>the object associated with the creation data</p>
<p>Auth Index: None</p></td>
</tr>
<tr class="odd">
<td>TPM2B_DATA</td>
<td>qualifyingData</td>
<td>user-provided qualifying data</td>
</tr>
<tr class="even">
<td>TPM2B_DIGEST</td>
<td>creationHash</td>
<td>hash of the creation data produced by TPM2_Create() or
TPM2_CreatePrimary()</td>
</tr>
<tr class="odd">
<td>TPMT_SIG_SCHEME+</td>
<td>inScheme</td>
<td>signing scheme to use if the <em>scheme</em> for <em>signHandle</em>
is TPM_ALG_NULL</td>
</tr>
<tr class="even">
<td>TPMT_TK_CREATION</td>
<td>creationTicket</td>
<td>ticket produced by TPM2_Create() or TPM2_CreatePrimary()</td>
</tr>
</tbody>
</table>

Table 93 — TPM2_CertifyCreation Response

|                |              |                                  |
|----------------|--------------|----------------------------------|
| Type           | Name         | Description                      |
| TPM_ST         | tag          | see clause 6                     |
| UINT32         | responseSize |                                  |
| TPM_RC         | responseCode |                                  |
| TPM2B_ATTEST   | certifyInfo  | the structure that was signed    |
| TPMT_SIGNATURE | signature    | the signature over *certifyInfo* |

### Detailed Actions

\[\[CertifyCreation\]\]

## TPM2_Quote

### General Description

This command is used to quote PCR values.

The TPM will hash the list of PCR selected by *PCRselect* using the hash
algorithm in the selected signing scheme. If the selected signing scheme
or the scheme hash algorithm is TPM_ALG_NULL, then the TPM shall return
TPM_RC_SCHEME.

NOTE 1 See 18.1 for description of how the signing scheme is selected.

The digest is computed as the hash of the concatenation of all of the
digest values of the selected PCR.

The concatenation of PCR is described in TPM 2.0 Part 1, *Selecting
Multiple PCR.*

NOTE 2 If *signHandle* is TPM_RH_NULL, the TPMS_ATTEST structure is
returned and *signature* is a NULL Signature.

NOTE 3 A TPM may optionally return TPM_RC_SCHEME if *signHandle* is
TPM_RH_NULL.

NOTE 4 Unlike TPM 1.2, TPM2_Quote does not return the PCR values. See
Part 1, “Attesting to PCR” for a discussion of this issue.

### Command and Response

Table 94 — TPM2_Quote Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_Quote</td>
</tr>
<tr class="odd">
<td>TPMI_DH_OBJECT+</td>
<td>@signHandle</td>
<td><p>handle of key that will perform signature</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPM2B_DATA</td>
<td>qualifyingData</td>
<td>data supplied by the caller</td>
</tr>
<tr class="odd">
<td>TPMT_SIG_SCHEME+</td>
<td>inScheme</td>
<td>signing scheme to use if the <em>scheme</em> for <em>signHandle</em>
is TPM_ALG_NULL</td>
</tr>
<tr class="even">
<td>TPML_PCR_SELECTION</td>
<td>PCRselect</td>
<td>PCR set to quote</td>
</tr>
</tbody>
</table>

Table 95 — TPM2_Quote Response

|                |              |                             |
|----------------|--------------|-----------------------------|
| Type           | Name         | Description                 |
| TPM_ST         | tag          | see clause 6                |
| UINT32         | responseSize |                             |
| TPM_RC         | responseCode |                             |
| TPM2B_ATTEST   | quoted       | the quoted information      |
| TPMT_SIGNATURE | signature    | the signature over *quoted* |

### Detailed Actions

\[\[Quote\]\]

## TPM2_GetSessionAuditDigest

### General Description

This command returns a digital signature of the audit session digest.

NOTE 1 See 18.1 for description of how the signing scheme is selected.

If *sessionHandle* is not an audit session, the TPM shall return
TPM_RC_TYPE.

NOTE 2 A session does not become an audit session until the successful
completion of the command in which the session is first used as an audit
session.

This command requires authorization from the privacy administrator of
the TPM (expressed with Endorsement Authorization) as well as
authorization to use the key associated with *signHandle*.

If this command is audited, then the audit digest that is signed will
not include the digest of this command because the audit digest is only
updated when the command completes successfully.

This command does not cause the audit session to be closed and does not
reset the digest value.

NOTE 3 If sessionHandle is used as an audit session for this command,
the command is audited in the same manner as any other command.

NOTE 4 If *signHandle* is TPM_RH_NULL, the TPMS_ATTEST structure is
returned and *signature* is a NULL Signature.

### Command and Response

Table 96 — TPM2_GetSessionAuditDigest Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_GetSessionAuditDigest</td>
</tr>
<tr class="odd">
<td>TPMI_RH_ENDORSEMENT</td>
<td>@privacyAdminHandle</td>
<td><p>handle of the privacy administrator (TPM_RH_ENDORSEMENT)</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPMI_DH_OBJECT+</td>
<td>@signHandle</td>
<td><p>handle of the signing key</p>
<p>Auth Index: 2</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="odd">
<td>TPMI_SH_HMAC</td>
<td>sessionHandle</td>
<td><p>handle of the audit session</p>
<p>Auth Index: None</p></td>
</tr>
<tr class="even">
<td>TPM2B_DATA</td>
<td>qualifyingData</td>
<td>user-provided qualifying data – may be zero-length</td>
</tr>
<tr class="odd">
<td>TPMT_SIG_SCHEME+</td>
<td>inScheme</td>
<td>signing scheme to use if the <em>scheme</em> for <em>signHandle</em>
is TPM_ALG_NULL</td>
</tr>
</tbody>
</table>

Table 97 — TPM2_GetSessionAuditDigest Response

|                |              |                                       |
|----------------|--------------|---------------------------------------|
| Type           | Name         | Description                           |
| TPM_ST         | tag          | see clause 6                          |
| UINT32         | responseSize |                                       |
| TPM_RC         | responseCode |                                       |
| TPM2B_ATTEST   | auditInfo    | the audit information that was signed |
| TPMT_SIGNATURE | signature    | the signature over *auditInfo*        |

### Detailed Actions

\[\[GetSessionAuditDigest\]\]

## TPM2_GetCommandAuditDigest

### General Description

This command returns the current value of the command audit digest, a
digest of the commands being audited, and the audit hash algorithm.
These values are placed in an attestation structure and signed with the
key referenced by *signHandle*.

NOTE 1 See 18.1 for description of how the signing scheme is selected.

When this command completes successfully, and *signHandle* is not
TPM_RH_NULL, the audit digest is cleared. If signHandle is TPM_RH_NULL,
*signature* is the Empty Buffer and the audit digest is not cleared.

NOTE 2 The way that the TPM tracks that the digest is clear is
vendor-dependent. The reference implementation resets the size of the
digest to zero.

If this command is being audited, then the signed digest produced by the
command will not include the command. At the end of this command, the
audit digest will be extended with *cpHash* and the *rpHash* of the
command, which would change the command audit digest signed by the next
invocation of this command.

This command requires authorization from the privacy administrator of
the TPM (expressed with Endorsement Authorization) as well as
authorization to use the key associated with *signHandle*.

### Command and Response

Table 98 — TPM2_GetCommandAuditDigest Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_GetCommandAuditDigest {NV}</td>
</tr>
<tr class="odd">
<td>TPMI_RH_ENDORSEMENT</td>
<td>@privacyHandle</td>
<td><p>handle of the privacy administrator (TPM_RH_ENDORSEMENT)</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPMI_DH_OBJECT+</td>
<td>@signHandle</td>
<td><p>the handle of the signing key</p>
<p>Auth Index: 2</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="odd">
<td>TPM2B_DATA</td>
<td>qualifyingData</td>
<td>other data to associate with this audit digest</td>
</tr>
<tr class="even">
<td>TPMT_SIG_SCHEME+</td>
<td>inScheme</td>
<td>signing scheme to use if the <em>scheme</em> for <em>signHandle</em>
is TPM_ALG_NULL</td>
</tr>
</tbody>
</table>

Table 99 — TPM2_GetCommandAuditDigest Response

|                |              |                                |
|----------------|--------------|--------------------------------|
| Type           | Name         | Description                    |
| TPM_ST         | tag          | see clause 6                   |
| UINT32         | responseSize |                                |
| TPM_RC         | responseCode |                                |
| TPM2B_ATTEST   | auditInfo    | the auditInfo that was signed  |
| TPMT_SIGNATURE | signature    | the signature over *auditInfo* |

### Detailed Actions

\[\[GetCommandAuditDigest\]\]

## TPM2_GetTime

### General Description

This command returns the current values of *Time* and *Clock*.

NOTE 1 See 18.1 for description of how the signing scheme is selected.

The values of *Clock*, *resetCount* and *restartCount* appear in two
places in *timeInfo*: once in TPMS_ATTEST.*clockInfo* and again in
TPMS_ATTEST.*attested.time.clockInfo.* The firmware version number also
appears in two places (TPMS_ATTEST.*firmwareVersion* and
TPMS_ATTEST.*attested.time.firmwareVersion*). If *signHandle* is in the
endorsement or platform hierarchies, both copies of the data will be the
same. However, if *signHandle* is in the storage hierarchy or is
TPM_RH_NULL, the values in TPMS_ATTEST.*clockInfo* and
TPMS_ATTEST.*firmwareVersion* are obfuscated but the values in
TPMS_ATTEST.*attested.time* are not.

NOTE 2 The purpose of this duplication is to allow an entity who is
trusted by the privacy Administrator to correlate the obfuscated values
with the clear-text values. This command requires Endorsement
Authorization.

NOTE 3 If *signHandle* is TPM_RH_NULL, the TPMS_ATTEST structure is
returned and *signature* is a NULL Signature.

### Command and Response

Table 100 — TPM2_GetTime Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_GetTime</td>
</tr>
<tr class="odd">
<td>TPMI_RH_ENDORSEMENT</td>
<td>@privacyAdminHandle</td>
<td><p>handle of the privacy administrator (TPM_RH_ENDORSEMENT)</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPMI_DH_OBJECT+</td>
<td>@signHandle</td>
<td><p>the <em>keyHandle</em> identifier of a loaded key that can
perform digital signatures</p>
<p>Auth Index: 2</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="odd">
<td>TPM2B_DATA</td>
<td>qualifyingData</td>
<td>data to tick stamp</td>
</tr>
<tr class="even">
<td>TPMT_SIG_SCHEME+</td>
<td>inScheme</td>
<td>signing scheme to use if the <em>scheme</em> for <em>signHandle</em>
is TPM_ALG_NULL</td>
</tr>
</tbody>
</table>

Table 101 — TPM2_GetTime Response

|                |              |                                          |
|----------------|--------------|------------------------------------------|
| Type           | Name         | Description                              |
| TPM_ST         | tag          | see clause 6                             |
| UINT32         | responseSize |                                          |
| TPM_RC         | responseCode | .                                        |
| TPM2B_ATTEST   | timeInfo     | standard TPM-generated attestation block |
| TPMT_SIGNATURE | signature    | the signature over *timeInfo*            |

### Detailed Actions

\[\[GetTime\]\]

## TPM2_CertifyX509

### General Description

The purpose of this command is to generate an X.509 certificate that
proves an object with a specific public key and attributes is loaded in
the TPM. In contrast to TPM2_Certify, which uses a TCG-defined data
structure to convey attestation information, TPM2_CertifyX509 encodes
the attestation information in a DER-encoded X.509 certificate that is
compliant with RFC5280 *Internet X.509 Public Key Infrastructure
Certificate and Certificate Revocation List (CRL) Profile.*

As described in RFC, an X.509 certificate contains a collection of data
that is hashed and signed. The full signature is the combination of the
*to be signed* (TBS) data, a description of the signature algorithm, and
the signature over the TBS data. The elements of the TBS data structure
are DER-encoded values. They are:

1)  Version \[0\] – integer value of 2 indicating version 3

<!-- -->

4)  Certificate Serial Number – integer value

5)  Signature Algorithm Identifier – values (usually a collection of
    OIDs) identifying the algorithm used for the signature

6)  Issuer Name – X.501 type *Name* to identify the entity that has
    authorized the use of *signHandle* to create the certificate.

7)  Validity – two time values indicating the period during which the
    certificate is valid

8)  Subject Name – X.501 type *Name* that identifies the entity that
    authorized the use of *objectHandle*

9)  Subject Public Key Info – the public key associated with
    *objectHandle*,

10) Extensions \[3\] – a set of values that “provide methods for
    associating additional attributes with users or public keys and for
    managing relationships between CAs.”

NOTE 1: The numbers in square brackets (e.g., \[0\]) indicate
application-specific tag values that are used to identify the type of
the field.

NOTE 2: RFC 5280 describes two fields (issuerUniqueID and
subjectUniqueID) but goes on to say: “CAs conforming to this profile
MUST NOT generate certificates with unique identifiers.” The TPM does
not allow them to be present.

The caller provides a partial certificate (*partialCertificate*)
parameter that contains four or five of the elements enumerated above in
a DER encoded SEQUENCE. They are:

1)  Signature Algorithm Identifier (optional)

<!-- -->

11) Issuer (mandatory)

12) Validity (mandatory)

13) Subject Name (mandatory)

14) Extensions (mandatory)

The fields are required to be in the order in which they are listed
above.

NOTE 3: The TPM determines if the Signature Algorithm Identifier element
is present by counting the elements.

The optional Signature Algorithm Identifier may be provided by the
caller. If it is not present, the TPM will generate the value based on
the selected signing scheme. If the caller provides this value, then the
TPM will use it in the completed TBS. The TPM will not validate that the
provided values are compatible with the signing scheme. If the caller
does not provide this field and the TPM does not have OID values for the
signing scheme, then the TPM will return an error (TPM_RC_SCHEME).

NOTE 4: The TPM may implement signing schemes for which OIDs are not
defined at the time the TPM was manufactured. Those schemes may still be
used if the caller can provide the Signature Algorithm Identifier.

The Extensions element is required to contain a Key Usage extension. The
TPM will extract the Key Usage values and verify that the attributes of
*objectHandle* are consistent with the selected values
(TPM_RC_ATTRIBUTES)(See Part 2, *TPMA_X509_KEY_USAGE*).

The Extensions element may contain a TPMA_OBJECT extension. If present,
the TPM will extract the value and verify that the extension value
exactly matches the TPMA_OBJECT of *objectKey* (TPM_RC_ATTRIBUTES). The
element uses the TCG OID tcg-tpmaObject, 2.23.133.10.1.1.1. It is a
SEQUENCE containing that OID and an OCTET STRING encapsulating a 4-byte
BIT STRING holding the big endian TPMA_OBJECT.

*signHandle* is required to have the *sign* attribute SET (TPM_RC_KEY).

NOTE 5: See 18.1 for description of how the signing scheme is selected.

Authorization for *objectHandle* requires ADMIN role authorization. If
performed with a policy session, the session shall have a
policySession→*commandCode* set to TPM_CC_CertifyX509. This indicates
that the policy that is being used is a policy that is for
certification, and not a policy that would approve another use. That is,
authority to use an object does not grant authority to certify the
object.

If *objectHandle* does not have a sensitive area loaded, the TPM will
return an error (TPM_RC_AUTH_UNAVAILABLE).

NOTE 6: The command requires that authorization be provided for use of
*objectHandle.* An object that only has its *publicArea* loaded does not
have an authorization value and the *authPolicy* has no meaning as the
sensitive area is not present.

The TPM will create the Version, the Certificate Serial Number, the
Subject Public Key Info*,* and, if not provided by the caller, the
Signature Algorithm Identifier. These TPM-created values will be
combined with the provided values to make a full TBSCerfificate
structure (See RFC 5280, clause 4.1). The TPM will then sign the
certificate using the selected signing scheme.

The TPM-created values will be returned in *addedToCertificate.* If the
TPM creates the Signature Algorithm Identifier, it will be in
*addedToCertificate* before the Subject Public Key Info. The TPM returns
*tbsDigest* as a debugging aid.

NOTE 7: These returned fields allow the caller to unambiguously create a
full RFC5280-defined TBSCertificate.

NOTE 8: This command was added in revision 01.53.

### Command and Response

Table 102 — TPM2_CertifyX509 Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_CertifyX509</td>
</tr>
<tr class="odd">
<td>TPMI_DH_OBJECT</td>
<td>@objectHandle</td>
<td><p>handle of the object to be certified</p>
<p>Auth Index: 1</p>
<p>Auth Role: ADMIN</p></td>
</tr>
<tr class="even">
<td>TPMI_DH_OBJECT+</td>
<td>@signHandle</td>
<td><p>handle of the key used to sign the attestation structure</p>
<p>Auth Index: 2</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="odd">
<td>TPM2B_DATA</td>
<td>reserved</td>
<td>shall be an Empty Buffer</td>
</tr>
<tr class="even">
<td>TPMT_SIG_SCHEME+</td>
<td>inScheme</td>
<td>signing scheme to use if the <em>scheme</em> for <em>signHandle</em>
is TPM_ALG_NULL</td>
</tr>
<tr class="odd">
<td>TPM2B_MAX_BUFFER</td>
<td>partialCertificate</td>
<td>a DER encoded partial certificate</td>
</tr>
</tbody>
</table>

Table 103 — TPM2_CertifyX509 Response

|                  |                    |                                                                                                                                    |
|------------------|--------------------|------------------------------------------------------------------------------------------------------------------------------------|
| Type             | Name               | Description                                                                                                                        |
| TPM_ST           | tag                | see clause 6                                                                                                                       |
| UINT32           | responseSize       |                                                                                                                                    |
| TPM_RC           | responseCode       | .                                                                                                                                  |
| TPM2B_MAX_BUFFER | addedToCertificate | a DER encoded SEQUENCE containing the DER encoded fields added to partialCertificate to make it a complete RFC5280 TBSCertificate. |
| TPM2B_DIGEST     | tbsDigest          | the digest that was signed                                                                                                         |
| TPMT_SIGNATURE   | signature          | The signature over *tbsDigest*                                                                                                     |

### Detailed Actions

\[\[certifyX509\]\]

# Ephemeral EC Keys

## Introduction

The TPM generates keys that have different lifetimes. TPM keys in a
hierarchy can be persistent for as long as the seed of the hierarchy is
unchanged and these keys may be used multiple times. Other TPM-generated
keys are only useful for a single operation. Some of these single-use
keys are used in the command in which they are created. Examples of this
use are TPM2_Duplicate() where an ephemeral key is created for a single
pass key exchange with another TPM. However, there are other cases, such
as anonymous attestation, where the protocol requires two passes where
the public part of the ephemeral key is used outside of the TPM before
the final command "consumes" the ephemeral key.

For these uses, TPM2_Commit() or TPM2_EC_Ephemeral() may be used to have
the TPM create an ephemeral EC key and return the public part of the key
for external use. Then in a subsequent command, the caller provides a
reference to the ephemeral key so that the TPM can retrieve or recreate
the associated private key.

When an ephemeral EC key is created, it is assigned a number and that
number is returned to the caller as the identifier for the key. This
number is not a handle. A handle is assigned to a key that may be
context saved but these ephemeral EC keys may not be saved and do not
have a full key context. When a subsequent command uses the ephemeral
key, the caller provides the number of the ephemeral key. The TPM uses
that number to either look up or recompute the associated private key.
After the key is used, the TPM records the fact that the key has been
used so that it cannot be used again.

As mentioned, the TPM can keep each assigned private ephemeral key in
memory until it is used. However, this could consume a large amount of
memory. To limit the memory size, the TPM is allowed to restrict the
number of pending private keys – keys that have been allocated but not
used.

NOTE The minimum number of ephemeral keys is determined by a platform
specific specification

To further reduce the memory requirements for the ephemeral private
keys, the TPM is allowed to use pseudo-random values for the ephemeral
keys. Instead of keeping the full value of the key in memory, the TPM
can use a counter as input to a KDF. Incrementing the counter will cause
the TPM to generate a new pseudo-random value.

Using the counter to generate pseudo-random private ephemeral keys
greatly simplifies tracking of key usage. When a counter value is used
to create a key, a bit in an array may be set to indicate that the key
use is pending. When the ephemeral key is consumed, the bit is cleared.
This prevents the key from being used more than once.

Since the TPM is allowed to restrict the number of pending ephemeral
keys, the array size can be limited. For example, a 128 bit array would
allow 128 keys to be "pending".

The management of the array is described in greater detail in the *Split
Operations* clause in Annex C of TPM 2.0 Part 1.

## TPM2_Commit

### General Description

TPM2_Commit() performs the first part of an ECC anonymous signing
operation. The TPM will perform the point multiplications on the
provided points and return intermediate signing values. The *signHandle*
parameter shall refer to an ECC key and the signing scheme must be
anonymous (TPM_RC_SCHEME).

NOTE 1 Currently, TPM_ALG_ECDAA is the only defined anonymous scheme.

NOTE 2 This command cannot be used with a sign+decrypt key because that
type of key is required to have a scheme of TPM_ALG_NULL.

For this command, *p1*, *s2* and *y2* are optional parameters. If *s2*
is an Empty Buffer, then the TPM shall return TPM_RC_SIZE if *y2* is not
an Empty Buffer.

The algorithm is specified in the TPM 2.0 Part 1 Annex for ECC,
TPM2_Commit().

### Command and Response

Table 104 — TPM2_Commit Command

<table>
<colgroup>
<col style="width: 30%" />
<col style="width: 20%" />
<col style="width: 48%" />
</colgroup>
<thead>
<tr class="header">
<th>Type</th>
<th>Name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="even">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="odd">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_Commit</td>
</tr>
<tr class="even">
<td>TPMI_DH_OBJECT</td>
<td>@signHandle</td>
<td><p>handle of the key that will be used in the signing operation</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="odd">
<td>TPM2B_ECC_POINT</td>
<td>P1</td>
<td>a point (<em>M</em>) on the curve used by <em>signHandle</em></td>
</tr>
<tr class="even">
<td>TPM2B_SENSITIVE_DATA</td>
<td>s2</td>
<td>octet array used to derive x-coordinate of a base point</td>
</tr>
<tr class="odd">
<td>TPM2B_ECC_PARAMETER</td>
<td>y2</td>
<td>y coordinate of the point associated with <em>s2</em></td>
</tr>
</tbody>
</table>

Table 105 — TPM2_Commit Response

| Type            | Name         | Description                                   |
|-----------------|--------------|-----------------------------------------------|
| TPM_ST          | tag          | see 6                                         |
| UINT32          | responseSize |                                               |
| TPM_RC          | responseCode |                                               |
| TPM2B_ECC_POINT | K            | ECC point *K* ≔ \[*d<sub>s</sub>*\]*(x2, y2)* |
| TPM2B_ECC_POINT | L            | ECC point *L* ≔ \[*r*\]*(x2, y2)*             |
| TPM2B_ECC_POINT | E            | ECC point *E* ≔ \[*r*\]*P1*                   |
| UINT16          | counter      | least-significant 16 bits of *commitCount*    |

### Detailed Actions

\[\[Commit\]\]

## TPM2_EC_Ephemeral

### General Description

TPM2_EC_Ephemeral() creates an ephemeral key for use in a two-phase key
exchange protocol.

The TPM will use the commit mechanism to assign an ephemeral key *r* and
compute a public point *Q* ≔ \[*r*\]*G* where *G* is the generator point
associated with *curveID*.

### Command and Response

Table 106 — TPM2_EC_Ephemeral Command

| Type                | Name        | Description                                                                              |
|---------------------|-------------|------------------------------------------------------------------------------------------|
| TPMI_ST_COMMAND_TAG | tag         | TPM_ST_SESSIONS if an audit or encrypt session is present; otherwise, TPM_ST_NO_SESSIONS |
| UINT32              | commandSize |                                                                                          |
| TPM_CC              | commandCode | TPM_CC_EC_Ephemeral                                                                      |
| TPMI_ECC_CURVE      | curveID     | The curve for the computed ephemeral point                                               |

Table 107 — TPM2_EC_Ephemeral Response

| Type            | Name         | Description                                |
|-----------------|--------------|--------------------------------------------|
| TPM_ST          | tag          | see 6                                      |
| UINT32          | responseSize |                                            |
| TPM_RC          | responseCode |                                            |
| TPM2B_ECC_POINT | Q            | ephemeral public key *Q* ≔ \[*r*\]*G*      |
| UINT16          | counter      | least-significant 16 bits of *commitCount* |

### Detailed Actions

\[\[EC_Ephemeral\]\]

# Signing and Signature Verification

## TPM2_VerifySignature

### General Description

This command uses loaded keys to validate a signature on a message with
the message digest passed to the TPM.

If the signature check succeeds, then the TPM will produce a
TPMT_TK_VERIFIED. Otherwise, the TPM shall return TPM_RC_SIGNATURE.

If the key is in the NULL hierarchy, then *digest* in the ticket will be
the Empty Buffer*.*

NOTE 1 A valid ticket may be used in subsequent commands to provide
proof to the TPM that the TPM has validated the signature over the
message using the key referenced by *keyHandle*.

If *keyHandle* references an asymmetric key, only the public portion of
the key needs to be loaded. If *keyHandle* references a symmetric key,
both the public and private portions need to be loaded.

NOTE 2 The sensitive area of the symmetric object is required to allow
verification of the symmetric signature (the HMAC).

### Command and Response

Table 108 — TPM2_VerifySignature Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS if an audit or encrypt session is present;
otherwise, TPM_ST_NO_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_VerifySignature</td>
</tr>
<tr class="odd">
<td>TPMI_DH_OBJECT</td>
<td>keyHandle</td>
<td><p>handle of public key that will be used in the validation</p>
<p>Auth Index: None</p></td>
</tr>
<tr class="even">
<td>TPM2B_DIGEST</td>
<td>digest</td>
<td>digest of the signed message</td>
</tr>
<tr class="odd">
<td>TPMT_SIGNATURE</td>
<td>signature</td>
<td>signature to be tested</td>
</tr>
</tbody>
</table>

Table 109 — TPM2_VerifySignature Response

|                  |              |              |
|------------------|--------------|--------------|
| Type             | Name         | Description  |
| TPM_ST           | tag          | see clause 6 |
| UINT32           | responseSize |              |
| TPM_RC           | responseCode |              |
| TPMT_TK_VERIFIED | validation   |              |

### Detailed Actions

\[\[VerifySignature\]\]

## TPM2_Sign

### General Description

This command causes the TPM to sign an externally provided hash with the
specified symmetric or asymmetric signing key.

NOTE 1 If *keyhandle* references an unrestricted signing key, a digest
can be signed using either this command or an HMAC command.

If *keyHandle* references a restricted signing key, then *validation*
shall be provided, indicating that the TPM performed the hash of the
data and *validation* shall indicate that hashed data did not start with
TPM_GENERATED_VALUE.

NOTE 2 If the hashed data did start with TPM_GENERATED_VALUE, then the
validation will be a NULL ticket.

The *x509sign* attribute of keyHandle may not be SET
(TPM_RC_ATTRIBUTES).

If the scheme of *keyHandle* is not TPM_ALG_NULL, then *inScheme* shall
either be the same scheme as *keyHandle* or TPM_ALG_NULL. If the *sign*
attribute is not SET in the key referenced by *handle* then the TPM
shall return TPM_RC_KEY.

If the scheme of *keyHandle* is TPM_ALG_NULL, the TPM will sign using
*inScheme*; otherwise, it will sign using the scheme of *keyHandle*.

NOTE 3 When the signing scheme uses a hash algorithm, the algorithm is
defined in the qualifying data of the scheme. This is the same algorithm
that is required to be used in producing *digest*. The size of *digest*
must match that of the hash algorithm in the scheme.

If *inScheme* is not a valid signing scheme for the type of keyHandle
(or TPM_ALG_NULL), then the TPM shall return TPM_RC_SCHEME.

If the scheme of *keyHandle* is an anonymous *scheme*, then *inScheme*
shall have the same scheme algorithm as *keyHandle* and *inScheme* will
contain a counter value that will be used in the signing process.

EXAMPLE For ECDAA, *inScheme.details.ecdaa.count* will contain the count
value.

If *validation* is provided, then the hash algorithm used in computing
the digest is required to be the hash algorithm specified in the scheme
of *keyHandle* (TPM_RC_TICKET).

If the *validation* parameter is not the Empty Buffer*,* then it will be
checked even if the key referenced by *keyHandle* is not a restricted
signing key.

NOTE 4 If *keyHandle* is both a sign and decrypt key, *keyHandle* will
have a scheme of TPM_ALG_NULL. If *validation* is provided, then it must
be a NULL validation ticket or the ticket validation will fail.

### Command and Response

Table 110 — TPM2_Sign Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_Sign</td>
</tr>
<tr class="odd">
<td>TPMI_DH_OBJECT</td>
<td>@keyHandle</td>
<td><p>Handle of key that will perform signing</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPM2B_DIGEST</td>
<td>digest</td>
<td>digest to be signed</td>
</tr>
<tr class="odd">
<td>TPMT_SIG_SCHEME+</td>
<td>inScheme</td>
<td>signing scheme to use if the <em>scheme</em> for <em>keyHandle</em>
is TPM_ALG_NULL</td>
</tr>
<tr class="even">
<td>TPMT_TK_HASHCHECK</td>
<td>validation</td>
<td><p>proof that digest was created by the TPM</p>
<p>If <em>keyHandle</em> is not a restricted signing key, then this may
be a NULL Ticket with <em>tag</em> = TPM_ST_CHECKHASH.</p></td>
</tr>
</tbody>
</table>

Table 111 — TPM2_Sign Response

|                |              |               |
|----------------|--------------|---------------|
| Type           | Name         | Description   |
| TPM_ST         | tag          | see clause 6  |
| UINT32         | responseSize |               |
| TPM_RC         | responseCode |               |
| TPMT_SIGNATURE | signature    | the signature |

### Detailed Actions

\[\[Sign\]\]

# Command Audit

## Introduction

If a command has been selected for command audit, the command audit
status will be updated when that command completes successfully. The
digest is updated as:

commandAuditDigest<sub>new</sub> ≔
**H**<sub>auditAlg</sub>(commandAuditDigest<sub>old</sub> \|\| cpHash
\|\| rpHash) 1

where

**H**<sub>auditAlg</sub> hash function using the algorithm of the audit
sequence

commandAuditDigest accumulated digest

cpHash the command parameter hash

*rpHash* the response parameter hash

*auditAlg*, the hash algorithm, is set using
TPM2_SetCommandCodeAuditStatus().

TPM2_Shutdown() cannot be audited but TPM2_Startup() can be audited. If
the *cpHash* of the TPM2_Startup() is TPM_SU_STATE, that would indicate
that a TPM2_Shutdown() had been successfully executed.

TPM2_SetCommandCodeAuditStatus() is always audited, except when it is
used to change *auditAlg*.

If the TPM is in Failure mode, command audit is not functional.

## TPM2_SetCommandCodeAuditStatus

### General Description

This command may be used by the Privacy Administrator or platform to
change the audit status of a command or to set the hash algorithm used
for the audit digest, but not both at the same time.

If the *auditAlg* parameter is a supported hash algorithm and not the
same as the current algorithm, then the TPM will check both *setList*
and *clearList* are empty (zero length). If so, then the algorithm is
changed, and the audit digest is cleared. If *auditAlg* is TPM_ALG_NULL
or the same as the current algorithm, then the algorithm and audit
digest are unchanged and the *setList* and *clearList* will be
processed.

NOTE 1 Because the audit digest is cleared, the audit counter will
increment the next time that an audited command is executed.

Use of TPM2_SetCommandCodeAuditStatus() to change the list of audited
commands is an audited event. If TPM_CC_SetCommandCodeAuditStatus is in
*clearList,* the fact that it is in *clearList* is ignored.

NOTE 2 Use of this command to change the audit hash algorithm is not
audited and the digest is reset when the command completes. The change
in the audit hash algorithm is the evidence that this command was used
to change the algorithm.

The commands in *setList* indicate the commands to be added to the list
of audited commands and the commands in *clearList* indicate the
commands that will no longer be audited. It is not an error if a command
in *setList* is already audited or is not implemented. It is not an
error if a command in *clearList* is not currently being audited or is
not implemented.

If a command code is in both *setList* and *clearList*, then it will not
be audited (that is, *setList* shall be processed first).

### Command and Response

Table 112 — TPM2_SetCommandCodeAuditStatus Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_SetCommandCodeAuditStatus {NV}</td>
</tr>
<tr class="odd">
<td>TPMI_RH_PROVISION</td>
<td>@auth</td>
<td><p>TPM_RH_OWNER or TPM_RH_PLATFORM+{PP}</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPMI_ALG_HASH+</td>
<td>auditAlg</td>
<td>hash algorithm for the audit digest; if TPM_ALG_NULL, then the hash
is not changed</td>
</tr>
<tr class="odd">
<td>TPML_CC</td>
<td>setList</td>
<td>list of commands that will be added to those that will be
audited</td>
</tr>
<tr class="even">
<td>TPML_CC</td>
<td>clearList</td>
<td>list of commands that will no longer be audited</td>
</tr>
</tbody>
</table>

Table 113 — TPM2_SetCommandCodeAuditStatus Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[SetCommandCodeAuditStatus\]\]

# Integrity Collection (PCR)

## Introduction

In TPM 1.2, an Event was hashed using SHA-1 and then the 20-octet digest
was extended to a PCR using TPM_Extend(). This specification allows the
use of multiple PCR at a given Index, each using a different hash
algorithm. Rather than require that the external software generate
multiple hashes of the Event with each being extended to a different
PCR, the Event data may be sent to the TPM for hashing. This ensures
that the resulting digests will properly reflect the algorithms chosen
for the PCR even if the calling software is unable to implement the hash
algorithm.

NOTE 1 There is continued support for software hashing of events with
TPM2_PCR_Extend().

To support recording of an Event that is larger than the TPM input
buffer, the caller may use the command sequence described in clause 17.

Change to a PCR requires authorization. The authorization may be with
either an authorization value or an authorization policy. The
platform-specific specifications determine which PCR may be controlled
by policy. All other PCR are controlled by authorization.

If a PCR may be associated with a policy, then the algorithm ID of that
policy determines whether the policy is to be applied. If the algorithm
ID is not TPM_ALG_NULL, then the policy digest associated with the PCR
must match the *policySession*→*policyDigest* in a policy session. If
the algorithm ID is TPM_ALG_NULL, then no policy is present and the
authorization requires an EmptyAuth.

If a platform-specific specification indicates that PCR are grouped,
then all the PCR in the group use the same authorization policy or
authorization value.

*pcrUpdateCounter* counter will be incremented on the successful
completion of any command that modifies (Extends or resets) a PCR unless
the platform-specific specification explicitly excludes the PCR from
being counted.

NOTE 2 If a command causes PCR in multiple banks to change, the PCR
Update Counter must be incremented once for each bank. The commands that
extend PCR are: TPM2_PCR_Extend, TPM2_PCR_Event, and
TPM2_EventSequenceComplete.

If a command resets PCR in multiple banks, the PCR Update Counter must
be incremented only once. The commands that reset PCR are:
TPM2_PCR_Reset, and TPM2_Startup.

A platform-specific specification may designate a set of PCR that are
under control of the TCB. These PCR may not be modified without the
proper authorization. Updates of these PCR shall not cause the PCR
Update Counter to increment.

EXAMPLE Updates of the TCB PCR will not cause the PCR update counter to
increment because these PCR are changed at the whim of the TCB and may
not represent the trust state of the platform.

## TPM2_PCR_Extend

### General Description

This command is used to cause an update to the indicated PCR. The
*digests* parameter contains one or more tagged digest values identified
by an algorithm ID. For each digest, the PCR associated with *pcrHandle*
is Extended into the bank identified by the tag (*hashAlg*).

EXAMPLE A SHA1 digest would be Extended into the SHA1 bank and a SHA256
digest would be Extended into the SHA256 bank.

For each list entry, the TPM will check to see if *pcrNum* is
implemented for that algorithm. If so, the TPM shall perform the
following operation:

PCR.digest<sub>new</sub> \[pcrNum\]\[alg\] ≔
**H**<sub>alg</sub>(PCR.digest<sub>old</sub> \[pcrNum\]\[alg\] \|\|
data\[alg\].buffer)) 1

where

**H**<sub>alg</sub>() hash function using the hash algorithm associated
with the PCR instance

PCR.digest the digest value in a PCR

pcrNum the PCR numeric selector (pcrHandle)

alg the PCR algorithm selector for the digest

*data*\[*alg*\]*.buffer* the bank-specific data to be extended

If no digest value is specified for a bank, then the PCR in that bank is
not modified.

NOTE 1 This allows consistent operation of the digests list for all of
the Event recording commands.

If a digest is present and the PCR in that bank is not implemented, the
digest value is not used.

NOTE 2 If the caller includes digests for algorithms that are not
implemented, then the TPM will fail the call because the unmarshalling
of *digests* will fail. Each of the entries in the list is a TPMT_HA,
which is a hash algorithm followed by a digest. If the algorithm is not
implemented, unmarshalling of the *hashAlg* will fail and the TPM will
return TPM_RC_HASH.

If the TPM unmarshals the *hashAlg* of a list entry and the unmarshaled
value is not a hash algorithm implemented on the TPM, the TPM shall
return TPM_RC_HASH.

The *pcrHandle* parameter is allowed to reference TPM_RH_NULL. If so,
the input parameters are processed but no action is taken by the TPM.
This permits the caller to probe for implemented hash algorithms as an
alternative to TPM2_GetCapability.

NOTE 3 This command allows a list of digests so that PCR in all banks
may be updated in a single command. While the semantics of this command
allow multiple extends to a single PCR bank, this is not the preferred
use and the limit on the number of entries in the list make this use
somewhat impractical.

### Command and Response

Table 114 — TPM2_PCR_Extend Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_PCR_Extend {NV}</td>
</tr>
<tr class="odd">
<td>TPMI_DH_PCR+</td>
<td>@pcrHandle</td>
<td><p>handle of the PCR</p>
<p>Auth Handle: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPML_DIGEST_VALUES</td>
<td>digests</td>
<td>list of tagged digest values to be extended</td>
</tr>
</tbody>
</table>

Table 115 — TPM2_PCR_Extend Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode | .            |

### Detailed Actions

\[\[PCR_Extend\]\]

## TPM2_PCR_Event

### General Description

This command is used to cause an update to the indicated PCR.

The data in *eventData* is hashed using the hash algorithm associated
with each bank in which the indicated PCR has been allocated. After the
data is hashed, the *digests* list is returned. If the *pcrHandle*
references an implemented PCR and not TPM_RH_NULL, the *digests* list is
processed as in TPM2_PCR_Extend().

A TPM shall support an *Event.size* of zero through 1,024 inclusive
(*Event.size* is an octet count). An *Event.size* of zero indicates that
there is no data but the indicated operations will still occur,

EXAMPLE 1 If the command implements PCR\[2\] in a SHA1 bank and a SHA256
bank, then an extend to PCR\[2\] will cause *eventData* to be hashed
twice, once with SHA1 and once with SHA256. The SHA1 hash of *eventData*
will be Extended to PCR\[2\] in the SHA1 bank and the SHA256 hash of
*eventData* will be Extended to PCR\[2\] of the SHA256 bank.

On successful command completion, *digests* will contain the list of
tagged digests of *eventData* that was computed in preparation for
extending the data into the PCR. At the option of the TPM, the list may
contain a digest for each bank, or it may only contain a digest for each
bank in which *pcrHandle* is extant. If *pcrHandle* is TPM_RH_NULL, the
TPM may return either an empty list or a digest for each bank.

EXAMPLE 2 Assume a TPM that implements a SHA1 bank and a SHA256 bank and
that PCR\[22\] is only implemented in the SHA1 bank. If *pcrHandle*
references PCR\[22\], then *digests* may contain either a SHA1 and a
SHA256 digest or just a SHA1 digest.

### Command and Response

Table 116 — TPM2_PCR_Event Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_PCR_Event {NV}</td>
</tr>
<tr class="odd">
<td>TPMI_DH_PCR+</td>
<td>@pcrHandle</td>
<td><p>Handle of the PCR</p>
<p>Auth Handle: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPM2B_EVENT</td>
<td>eventData</td>
<td>Event data in sized buffer</td>
</tr>
</tbody>
</table>

Table 117 — TPM2_PCR_Event Response

|                    |              |              |
|--------------------|--------------|--------------|
| Type               | Name         | Description  |
| TPM_ST             | tag          | see clause 6 |
| UINT32             | responseSize |              |
| TPM_RC             | responseCode | .            |
| TPML_DIGEST_VALUES | digests      |              |

### Detailed Actions

\[\[PCR_Event\]\]

## TPM2_PCR_Read

### General Description

This command returns the values of all PCR specified in
*pcrSelectionIn*.

The TPM will process the list of TPMS_PCR_SELECTION in *pcrSelectionIn*
in order. Within each TPMS_PCR_SELECTION, the TPM will process the bits
in the *pcrSelect* array in ascending PCR order (see TPM 2.0 Part 1,
*Selecting Multiple PCR*). If a bit is SET, and the indicated PCR is
present, then the TPM will add the digest of the PCR to the list of
values to be returned in *pcrValues.*

The TPM will continue processing bits until all have been processed or
until *pcrValues* would be too large to fit into the output buffer if
additional values were added.

The returned *pcrSelectionOut* will have a bit SET in its *pcrSelect*
structures for each value present in *pcrValues*.

The current value of the PCR Update Counter is returned in
*pcrUpdateCounter*.

The returned list may be empty if none of the selected PCR are
implemented.

NOTE If no PCR are returned from a bank, the selector for the bank will
be present in *pcrSelectionOut*.

No authorization is required to read a PCR and any implemented PCR may
be read from any locality.

### Command and Response

Table 118 — TPM2_PCR_Read Command

|                     |                |                                                                               |
|---------------------|----------------|-------------------------------------------------------------------------------|
| Type                | Name           | Description                                                                   |
| TPMI_ST_COMMAND_TAG | tag            | TPM_ST_SESSIONS if an audit session is present; otherwise, TPM_ST_NO_SESSIONS |
| UINT32              | commandSize    |                                                                               |
| TPM_CC              | commandCode    | TPM_CC_PCR_Read                                                               |
| TPML_PCR_SELECTION  | pcrSelectionIn | The selection of PCR to read                                                  |

Table 119 — TPM2_PCR_Read Response

|                    |                  |                                                                                           |
|--------------------|------------------|-------------------------------------------------------------------------------------------|
| Type               | Name             | Description                                                                               |
| TPM_ST             | tag              | see clause 6                                                                              |
| UINT32             | responseSize     |                                                                                           |
| TPM_RC             | responseCode     |                                                                                           |
| UINT32             | pcrUpdateCounter | the current value of the PCR update counter                                               |
| TPML_PCR_SELECTION | pcrSelectionOut  | the PCR in the returned list                                                              |
| TPML_DIGEST        | pcrValues        | the contents of the PCR indicated in *pcrSelectOut-\> pcrSelection\[\]* as tagged digests |

### Detailed Actions

\[\[PCR_Read\]\]

## TPM2_PCR_Allocate

### General Description

This command is used to set the desired PCR allocation of PCR and
algorithms. This command requires Platform Authorization.

The TPM will evaluate the request and, if sufficient memory is available
for the requested allocation, the TPM will store the allocation request
for use during the next \_TPM_Init operation. The PCR allocation in
place when this command is executed will be retained until the next
\_TPM_Init. If this command is received multiple times before a
\_TPM_Init, each one overwrites the previous stored allocation.

This command will only change the allocations of banks that are listed
in *pcrAllocation*.

EXAMPLE 1 If a TPM supports SHA1 and SHA256, then it maintains an
allocation for two banks (one of which could be empty). If
*pcrAllocation* only has a selector for the SHA1 bank, then only the
allocation of the SHA1 bank will be changed and the SHA256 bank will
remain unchanged. To change the allocation of a TPM from 24 SHA1 PCR and
no SHA256 PCR to 24 SHA256 PCR and no SHA1 PCR, the *pcrAllocation*
would have to have two selections: one for the empty SHA1 bank and one
for the SHA256 bank with 24 PCR.

If a bank is listed more than once, then the last selection in the
*pcrAllocation* list is the one that the TPM will attempt to allocate.

NOTE 1 This does not mean to imply that *pcrAllocation*.*count* can
exceed HASH_COUNT, the number of digests implemented in the TPM.

EXAMPLE 2 If HASH_COUNT is 2, *pcrAllocation* can specify SHA-256 twice,
and the second one is used. However, if SHA_256 is specified three
times, the unmarshaling may fail and the TPM may return an error.

This command shall not allocate more PCR in any bank than there are PCR
attribute definitions. The PCR attribute definitions indicate how a PCR
is to be managed – if it is resettable, the locality for update, etc. In
the response to this command, the TPM returns the maximum number of PCR
allowed for any bank.

When PCR are allocated, if DRTM_PCR is defined, the resulting allocation
must have at least one bank with the D-RTM PCR allocated. If HCRTM_PCR
is defined, the resulting allocation must have at least one bank with
the HCRTM_PCR allocated. If not, the TPM returns TPM_RC_PCR.

The TPM may return TPM_RC_SUCCESS even though the request fails. This is
to allow the TPM to return information about the size needed for the
requested allocation and the size available. If the *sizeNeeded*
parameter in the return is less than or equal to the *sizeAvailable*
parameter, then the *allocationSuccess* parameter will be YES.
Alternatively, if the request fails, The TPM may return
TPM_RC_NO_RESULT.

NOTE 2 An example for this type of failure is a TPM that can only
support one bank at a time and cannot support arbitrary distribution of
PCR among banks.

After this command, TPM2_Shutdown() is only allowed to have a
*startupType* equal to TPM_SU_CLEAR until after the next \_TPM_Init.

NOTE 3 Even if this command does not cause the PCR allocation to change,
the TPM cannot have its state saved. This is done in order to simplify
the implementation. There is no need to optimize this command as it is
not expected to be used more than once in the lifetime of the TPM (it
can be used any number of times but there is no justification for
optimization).

### Command and Response

Table 120 — TPM2_PCR_Allocate Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_PCR_Allocate {NV}</td>
</tr>
<tr class="odd">
<td>TPMI_RH_PLATFORM</td>
<td>@authHandle</td>
<td><p>TPM_RH_PLATFORM+{PP}</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPML_PCR_SELECTION</td>
<td>pcrAllocation</td>
<td>the requested allocation</td>
</tr>
</tbody>
</table>

Table 121 — TPM2_PCR_Allocate Response

|             |                   |                                                             |
|-------------|-------------------|-------------------------------------------------------------|
| Type        | Name              | Description                                                 |
| TPM_ST      | tag               | see clause 6                                                |
| UINT32      | responseSize      |                                                             |
| TPM_RC      | responseCode      |                                                             |
| TPMI_YES_NO | allocationSuccess | YES if the allocation succeeded                             |
| UINT32      | maxPCR            | maximum number of PCR that may be in a bank                 |
| UINT32      | sizeNeeded        | number of octets required to satisfy the request            |
| UINT32      | sizeAvailable     | Number of octets available. Computed before the allocation. |

### Detailed Actions

\[\[PCR_Allocate\]\]

## TPM2_PCR_SetAuthPolicy

### General Description

This command is used to associate a policy with a PCR or group of PCR.
The policy determines the conditions under which a PCR may be extended
or reset.

A policy may only be associated with a PCR that has been defined by a
platform-specific specification as allowing a policy. If the TPM
implementation does not allow a policy for *pcrNum*, the TPM shall
return TPM_RC_VALUE.

A platform-specific specification may group PCR so that they share a
common policy. In such case, a *pcrNum* that selects any of the PCR in
the group will change the policy for all PCR in the group.

The policy setting is persistent and may only be changed by
TPM2_PCR_SetAuthPolicy() or by TPM2_ChangePPS().

Before this command is first executed on a TPM or after
TPM2_ChangePPS(), the access control on the PCR will be set to the
default value defined in the platform-specific specification.

NOTE 1 It is expected that the typical default will be with the policy
hash set to TPM_ALG_NULL and an Empty Buffer for the *authPolicy* value.
This will allow an *EmptyAuth* to be used as the authorization value.

If the size of the data buffer in *authPolicy* is not the size of a
digest produced by *hashAlg*, the TPM shall return TPM_RC_SIZE.

NOTE 2 If *hashAlg* is TPM_ALG_NULL, then the size is required to be
zero.

This command requires platformAuth/platformPolicy.

NOTE 3 If the PCR is in multiple policy sets, the policy will be changed
in only one set. The set that is changed will be implementation
dependent.

### Command and Response

Table 122 — TPM2_PCR_SetAuthPolicy Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_PCR_SetAuthPolicy {NV}</td>
</tr>
<tr class="odd">
<td>TPMI_RH_PLATFORM</td>
<td>@authHandle</td>
<td><p>TPM_RH_PLATFORM+{PP}</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPM2B_DIGEST</td>
<td>authPolicy</td>
<td>the desired <em>authPolicy</em></td>
</tr>
<tr class="odd">
<td>TPMI_ALG_HASH+</td>
<td>hashAlg</td>
<td>the hash algorithm of the policy</td>
</tr>
<tr class="even">
<td>TPMI_DH_PCR</td>
<td>pcrNum</td>
<td>the PCR for which the policy is to be set</td>
</tr>
</tbody>
</table>

Table 123 — TPM2_PCR_SetAuthPolicy Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[PCR_SetAuthPolicy\]\]

## TPM2_PCR_SetAuthValue

### General Description

This command changes the *authValue* of a PCR or group of PCR.

An *authValue* may only be associated with a PCR that has been defined
by a platform-specific specification as allowing an authorization value.
If the TPM implementation does not allow an authorization for *pcrNum*,
the TPM shall return TPM_RC_VALUE. A platform-specific specification may
group PCR so that they share a common authorization value. In such case,
a *pcrNum* that selects any of the PCR in the group will change the
*authValue* value for all PCR in the group.

The authorization setting is set to EmptyAuth on each STARTUP(CLEAR) or
by TPM2_Clear(). The authorization setting is preserved by
SHUTDOWN(STATE).

### Command and Response

Table 124 — TPM2_PCR_SetAuthValue Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_PCR_SetAuthValue</td>
</tr>
<tr class="odd">
<td>TPMI_DH_PCR</td>
<td>@pcrHandle</td>
<td><p>handle for a PCR that may have an authorization value set</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPM2B_DIGEST</td>
<td>auth</td>
<td>the desired authorization value</td>
</tr>
</tbody>
</table>

Table 125 — TPM2_PCR_SetAuthValue Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[PCR_SetAuthValue\]\]

## TPM2_PCR_Reset

### General Description

If the attribute of a PCR allows the PCR to be reset and proper
authorization is provided, then this command may be used to set the PCR
in all banks to zero. The attributes of the PCR may restrict the
locality that can perform the reset operation.

NOTE 1 The definition of TPMI_DH_PCR in TPM 2.0 Part 2 indicates that if
pcrHandle is out of the allowed range for PCR, then the appropriate
return value is TPM_RC_VALUE.

If *pcrHandle* references a PCR that cannot be reset, the TPM shall
return TPM_RC_LOCALITY.

NOTE 2 TPM_RC_LOCALITY is returned because the reset attributes are
defined on a per-locality basis.

### Command and Response

Table 126 — TPM2_PCR_Reset Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_PCR_Reset {NV}</td>
</tr>
<tr class="odd">
<td>TPMI_DH_PCR</td>
<td>@pcrHandle</td>
<td><p>the PCR to reset</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
</tbody>
</table>

Table 127 — TPM2_PCR_Reset Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[PCR_Reset\]\]

## \_TPM_Hash_Start

### Description

This indication from the TPM interface indicates the start of an H-CRTM
measurement sequence. On receipt of this indication, the TPM will
initialize an H-CRTM Event Sequence context.

If no object memory is available for creation of the sequence context,
the TPM will flush the context of an object so that creation of the
sequence context will always succeed.

A platform-specific specification may allow this indication before
TPM2_Startup().

NOTE If this indication occurs after TPM2_Startup(), it is the
responsibility of software to ensure that an object context slot is
available or to deal with the consequences of having the TPM select an
arbitrary object to be flushed. If this indication occurs before
TPM2_Startup() then all context slots are available.

### Detailed Actions

\[\[\_TPM_Hash_Start\]\]

## \_TPM_Hash_Data

### Description

This indication from the TPM interface indicates arrival of one or more
octets of data that are to be included in the H-CRTM Event Sequence
sequence context created by the \_TPM_Hash_Start indication. The context
holds data for each hash algorithm for each PCR bank implemented on the
TPM.

If no H-CRTM Event Sequence context exists, this indication is discarded
and no other action is performed.

### Detailed Actions

\[\[\_TPM_Hash_Data\]\]

## \_TPM_Hash_End

### Description

This indication from the TPM interface indicates the end of the H-CRTM
measurement. This indication is discarded and no other action performed
if the TPM does not contain an H-CRTM Event Sequence context.

NOTE 1 An H-CRTM Event Sequence context is created by
\_TPM_Hash_Start().

If the H-CRTM Event Sequence occurs after TPM2_Startup(), the TPM will
set all of the PCR designated in the platform-specific specifications as
resettable by this event to the value indicated in the platform specific
specification and increment *restartCount*. The TPM will then Extend the
Event Sequence digest/digests into the designated D-RTM PCR (PCR\[17\]).

PCR\[17\]\[hashAlg\] ≔ **H**<sub>hashAlg</sub> (initial_value \|\|
**H**<sub>hashAlg</sub> (hash_data))

where

hashAlg hash algorithm associated with a bank of PCR

initial_value initialization value specified in the platform-specific
specification (should be 0…0)

hash_data all the octets of data received in \_TPM_Hash_Data indications

A \_TPM_Hash_End indication that occurs after TPM2_Startup() will
increment *pcrUpdateCounter* unless a platform-specific specification
excludes modifications of PCR\[DRTM\] from causing an increment*.*

A platform-specific specification may allow an H-CRTM Event Sequence
before TPM2_Startup(). If so, \_TPM_Hash_End will complete the digest,
initialize PCR\[0\] with a digest-size value of 4, and then extend the
H-CRTM Event Sequence data into PCR\[0\].

PCR\[0\]\[hashAlg\] ≔ **H**<sub>hashAlg</sub> (0…04 \|\|
**H**<sub>hashAlg</sub> (hash_data))

NOTE 2 The entire sequence of \_TPM_Hash_Start, \_TPM_Hash_Data, and
\_TPM_Hash_End are required to complete before TPM2_Startup() or the
sequence will have no effect on the TPM.

NOTE 3 PCR\[0\] does not need to be updated according to (8) until the
end of TPM2_Startup().

### Detailed Actions

\[\[\_TPM_Hash_End\]\]

# Enhanced Authorization (EA) Commands

## Introduction

The commands in this clause 23 are used for policy evaluation. When
successful, each command will update the *policySession*→*policyDigest*
in a policy session context in order to establish that the
authorizations required to use an object have been provided. Many of the
commands will also modify other parts of a policy context so that the
caller may constrain the scope of the authorization that is provided.

NOTE 1 Many of the terms used in this clause are described in detail in
TPM 2.0 Part 1 and are not redefined in this clause.

The *policySession* parameter of the command is the handle of the policy
session context to be modified by the command.

If the *policySession* parameter indicates a trial policy session, then
the *policySession*→*policyDigest* will be updated and the indicated
validations are not performed. However, any authorizations required to
perform the policy command will be checked and dictionary attack logic
invoked as necessary.

NOTE 2 If software is used to create policies, no authorization values
are used. For example, TPM_PolicySecret requires an authorization in a
trial policy session, but not in a policy calculation outside the TPM.

NOTE 3 A policy session is set to a trial policy by
TPM2_StartAuthSession(*sessionType* = TPM_SE_TRIAL).

NOTE 4 Unless there is an unmarshaling error in the parameters of the
command, these commands will return TPM_RC_SUCCESS when *policySession*
references a trial session.

NOTE 5 Policy context other than the *policySession*→*policyDigest* may
be updated for a trial policy but it is not required.

## Signed Authorization Actions

### Introduction

The TPM2_PolicySigned, TPM_PolicySecret, and TPM2_PolicyTicket commands
use many of the same functions. This clause consolidates those functions
to simplify the document and to ensure uniformity of the operations.

### Policy Parameter Checks

These parameter checks will be performed when indicated in the
description of each of the commands:

1)  *nonceTPM* – If this parameter is not the Empty Buffer, and it does
    not match *policySession*→*nonceTPM*, then the TPM shall return
    TPM_RC_VALUE.

<!-- -->

86) *expiration* – If this parameter is not zero, then:

87) if *nonceTPM* is not an Empty Buffer, then the absolute value of
    *expiration* is converted to milliseconds and added to
    *policySession→startTime* to create the *timeout* value and proceed
    to c).

88) If *nonceTPM* is an Empty Buffer, then the absolute value of
    *expiration* is converted to milliseconds and used as the *timeout*
    value and proceed to c).

    However, *timeout* can only be changed to a smaller value.

89) *timeout* – If *timeout* is less than the current value of *Time*,
    or the current *timeEpoch* is not the same as
    *policySession→timeEpoch, the* TPM shall return TPM_RC_EXPIRED

90) *cpHashA* – If this parameter is not an Empty Buffer

> NOTE 2 *cpHashA* is the hash of the command to be executed using this
> policy session in the authorization. The algorithm used to compute
> this hash is required to be the algorithm of the policy session.

91) the TPM shall return TPM_RC_CPHASH if *policySession*→*cpHash* is
    set and the contents of *policySession*→*cpHash* are not the same as
    *cpHashA*; or

> NOTE 3 cpHash is the expected cpHash value held in the policy session
> context.

92) the TPM shall return TPM_RC_SIZE if *cpHashA* is not the same size
    as *policySession*→*policyDigest*.

> NOTE 4 policySession→policyDigest is the size of the digest produced
> by the hash algorithm used to compute policyDigest.

### Policy Digest Update Function (PolicyUpdate())

This is the update process for *policySession*→*policyDigest* used by
TPM2_PolicySigned(), TPM2_PolicySecret(), TPM2_PolicyTicket(), and
TPM2_PolicyAuthorize(). The function prototype for the update function
is:

**PolicyUpdate**(commandCode, arg2, arg3) 1

where

arg2 a TPM2B_NAME

arg3 a TPM2B

These parameters are used to update *policySession*→*policyDigest* by

policyDigest<sub>new</sub> ≔
**H**<sub>policyAlg</sub>(policyDigest<sub>old</sub> \|\| commandCode
\|\| arg2.name) 1

followed by

policyDigest<sub>new+1</sub> ≔
**H**<sub>policyAlg</sub>(policyDigest<sub>new</sub> \|\| arg3.buffer) 1

where

**H***<sub>policyAlg</sub>*() the hash algorithm chosen when the policy
session was started

NOTE 1 If *arg3* is a TPM2B_NAME, then *arg3.buffer* will actually be an
*arg3.name*.

NOTE 2 The *arg2.size* and *arg3.size* fields are not included in the
hashes.

NOTE 3 **PolicyUpdate**() uses two hash operations because *arg2* and
*arg3* are variable-sized and the concatenation of *arg2* and *arg3* in
a single hash could produce the same digest even though *arg2* and
*arg3* are different. For example, arg2 = 1 2 3 and arg3 = 4 5 6 would
produce the same digest as arg2 = 1 2 and arg3 = 3 4 5 6. Processing of
the arguments separately in different Extend operation ensures that the
digest produced by **PolicyUpdate**() will be different if *arg2* and
*arg3* are different.

### Policy Context Updates

When a policy command modifies some part of the policy session context
other than the *policySession*→*policyDigest*, the following rules
apply.

- ***cpHash*** – this parameter may only be changed if it contains its
  initialization value (an Empty Buffer). If *cpHash* is not the Empty
  Buffer when a policy command attempts to update it, the TPM will
  return an error (TPM_RC_CPHASH) if the current and update values are
  not the same.

- ***timeOut*** – this parameter may only be changed to a smaller value.
  If a command attempts to update this value with a larger value (longer
  into the future), the TPM will discard the update value. This is not
  an error condition.

- ***commandCode*** – once set by a policy command, this value may not
  be changed except by TPM2_PolicyRestart(). If a policy command tries
  to change this to a different value, an error is returned
  (TPM_RC_POLICY_CC).

- ***pcrUpdateCounter*** – this parameter is updated by
  TPM2_PolicyPCR(). This value may only be set once during a policy.
  Each time TPM2_PolicyPCR() executes, it checks to see if
  *policySession*→*pcrUpdateCounter* has its default state, indicating
  that this is the first TPM2_PolicyPCR(). If it has its default value,
  then *policySession*→*pcrUpdateCounter* is set to the current value of
  *pcrUpdateCounter*. If *policySession*→*pcrUpdateCounter* does not
  have its default value and its value is not the same as
  *pcrUpdateCounter*, the TPM shall return TPM_RC_PCR_CHANGED.

> NOTE 1 If this parameter and *pcrUpdateCounter* are not the same, it
> indicates that PCR have changed since checked by the previous
> TPM2_PolicyPCR(). Since they have changed, the previous PCR validation
> is no longer valid.

- ***commandLocality*** – this parameter is the logical AND of all
  enabled localities. All localities are enabled for a policy when the
  policy session is created. TPM2_PolicyLocalities() selectively
  disables localities. Once use of a policy for a locality has been
  disabled, it cannot be enabled except by TPM2_PolicyRestart().

- ***isPPRequired*** – once SET, this parameter may only be CLEARed by
  TPM2_PolicyRestart().

- ***isAuthValueNeeded*** – once SET, this parameter may only be CLEARed
  by TPM2_PolicyPassword() or TPM2_PolicyRestart().

- ***isPasswordNeeded*** – once SET, this parameter may only be CLEARed
  by TPM2_PolicyAuthValue() or TPM2_PolicyRestart(),

NOTE 2 Both TPM2_PolicyAuthValue() and TPM2_PolicyPassword() change
*policySession*→*policyDigest* in the same way. The different commands
simply indicate to the TPM the format used for the *authValue* (HMAC or
clear text). Both commands could be in the same policy. The final
instance of these commands determines the format.

### Policy Ticket Creation

For TPM2_PolicySigned() or TPM2_PolicySecret(), if the caller specified
a negative value for *expiration*, then the TPM will return a ticket
that includes a value indicating when the authorization expires.
Otherwise, the TPM will return a NULL Ticket.

NOTE 1 If the *authHandle* in TPM2_PolicySecret() references a PIN Pass
Index, then the command may succeed but a NULL Ticket will be returned.

The required computation for the digest in the authorization ticket is:

**HMAC**<sub>contextAlg</sub>(proof, (TPM_ST_AUTH_xxx \|\| cpHash \|\|
policyRef \|\| authName

\|\| timeout \|\| \[timeEpoch\] \|\| \[resetCount\])) 1

where

**HMAC**<sub>contextAlg</sub>() an HMAC using the context integrity hash

proof a TPM secret value associated with the hierarchy of the object
associated with authName

TPM_ST_AUTH_xxx either TPM_ST_AUTH_SIGNED or TPM_ST_AUTH_SECRET; used to
ensure that the ticket is properly used

cpHash optional hash of the authorized command

policyRef optional reference to a policy value

authName Name of the object that signed the authorization

timeout implementation-specific value indicating when the authorization
expires

timeEpoch implementation-specific representation of the timeEpoch at the
time the ticket was created

> NOTE 2 Not included if *timeout* is zero.

resetCount implementation-specific representation of the TPM’s
totalResetCount

> NOTE 3 Not included it *timeout* is zero or if *nonceTPM* was include
> in the authorization.

## TPM2_PolicySigned

### General Description

This command includes a signed authorization in a policy. The command
ties the policy to a signing key by including the Name of the signing
key in the *policyDigest*

If *policySession* is a trial session, the TPM will not check the
signature and will update *policySession*→*policyDigest* as described in
23.2.3 as if a properly signed authorization was received, but no ticket
will be produced.

If *policySession* is not a trial session, the TPM will validate *auth*
and only perform the update if it is a valid signature over the fields
of the command.

The authorizing entity will sign a digest of the authorization
qualifiers: *nonceTPM*, *expiration*, *cpHashA*, and *policyRef*. The
digest is computed as:

aHash ≔ **H**<sub>authAlg</sub>(nonceTPM \|\| expiration \|\| cpHashA
\|\| policyRef) 1

where

**H**<sub>authAlg</sub>() the hash associated with the auth parameter of
this command

> NOTE 1 Each signature and key combination indicates the scheme and
> each scheme has an associated hash.

nonceTPM the nonceTPM parameter from the TPM2_StartAuthSession()
response. If the authorization is not limited to this session, the size
of this value is zero.

expiration time limit on authorization set by authorizing object. This
32-bit value is set to zero if the expiration time is not being set.

cpHashA digest of the command parameters for the command being approved
using the hash algorithm of the policy session. Set to an Empty Digest
if the authorization is not limited to a specific command.

> NOTE 3 This is not the *cpHash* of this TPM2_PolicySigned() command.

policyRef an opaque value determined by the authorizing entity. Set to
the Empty Buffer if no value is present.

NOTE 4 The *nonceTPM*, *cpHashA*, and *policyRef* qualifiers used to
compute *aHash* use the TPM2B buffer but do not prepend the size.

EXAMPLE The computation for an *aHash* if there are no restrictions is:

aHash ≔ **H**<sub>authAlg</sub>(00 00 00 00<sub>16</sub>)

which is the hash of an expiration time of zero.

The *aHash* is signed by the key associated with a key whose handle is
*authObject*. The signature and signing parameters are combined to
create the *auth* parameter.

The TPM will perform the parameter checks listed in 23.2.2

If the parameter checks succeed, the TPM will construct a test digest
(*tHash*) over the provided parameters using the same formulation as
shown in equation (13) above.

If *tHash* does not match the digest of the signed *aHash,* then the
authorization fails and the TPM shall return TPM_RC_POLICY_FAIL and make
no change to *policySession*→*policyDigest*.

When all validations have succeeded, *policySession*→*policyDigest* is
updated by **PolicyUpdate**() (see 23.2.3).

**PolicyUpdate**(TPM_CC_PolicySigned, authObject→Name, policyRef) 1

*authObject*→*Name* is a TPM2B_NAME. *policySession* is updated as
described in 23.2.4. The TPM will optionally produce a ticket as
described in 23.2.5.

Authorization to use *authObject* is not required.

### Command and Response

Table 128 — TPM2_PolicySigned Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS if an audit, encrypt, or decrypt session is present;
otherwise, TPM_ST_NO_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_PolicySigned</td>
</tr>
<tr class="odd">
<td>TPMI_DH_OBJECT</td>
<td>authObject</td>
<td><p>handle for a key that will validate the signature</p>
<p>Auth Index: None</p></td>
</tr>
<tr class="even">
<td>TPMI_SH_POLICY</td>
<td>policySession</td>
<td><p>handle for the policy session being extended</p>
<p>Auth Index: None</p></td>
</tr>
<tr class="odd">
<td>TPM2B_NONCE</td>
<td>nonceTPM</td>
<td><p>the policy nonce for the session</p>
<p>This can be the Empty Buffer.</p></td>
</tr>
<tr class="even">
<td>TPM2B_DIGEST</td>
<td>cpHashA</td>
<td><p>digest of the command parameters to which this authorization is
limited</p>
<p>This is not the <em>cpHash</em> for this command but the
<em>cpHash</em> for the command to which this policy session will be
applied. If it is not limited, the parameter will be the Empty
Buffer.</p></td>
</tr>
<tr class="odd">
<td>TPM2B_NONCE</td>
<td>policyRef</td>
<td><p>a reference to a policy relating to the authorization – may be
the Empty Buffer</p>
<p>Size is limited to be no larger than the nonce size supported on the
TPM.</p></td>
</tr>
<tr class="even">
<td>INT32</td>
<td>expiration</td>
<td><p>time when authorization will expire, measured in seconds from the
time that <em>nonceTPM</em> was generated</p>
<p>If <em>expiration</em> is non-negative, a NULL Ticket is returned.
See 23.2.5.</p></td>
</tr>
<tr class="odd">
<td>TPMT_SIGNATURE</td>
<td>auth</td>
<td>signed authorization (not optional)</td>
</tr>
</tbody>
</table>

Table 129 — TPM2_PolicySigned Response

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPM_ST</td>
<td>tag</td>
<td>see clause 6</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>responseSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_RC</td>
<td>responseCode</td>
<td></td>
</tr>
<tr class="odd">
<td>TPM2B_TIMEOUT</td>
<td>timeout</td>
<td><p>implementation-specific time value, used to indicate to the TPM
when the ticket expires</p>
<p>NOTE If <em>policyTicket</em> is a NULL Ticket, then this shall be
the Empty Buffer.</p></td>
</tr>
<tr class="even">
<td>TPMT_TK_AUTH</td>
<td>policyTicket</td>
<td>produced if the command succeeds and <em>expiration</em> in the
command was non-zero; this ticket will use the TPMT_ST_AUTH_SIGNED
structure tag. See 23.2.5</td>
</tr>
</tbody>
</table>

### Detailed Actions

\[\[PolicySigned\]\]

## TPM2_PolicySecret

### General Description

This command includes a secret-based authorization to a policy. The
caller proves knowledge of the secret value using an authorization
session using the *authValue* associated with *authHandle*. A password
session, an HMAC session, or a policy session containing
TPM2_PolicyAuthValue() or TPM2_PolicyPassword() will satisfy this
requirement.

If a policy session is used and use of the *authValue* of *authHandle*
is not required, the TPM will return TPM_RC_MODE. That is, the session
for *authHandle* must have either *isAuthValueNeeded* or
*isPasswordNeeded* SET.

The secret is the *authValue* of the entity whose handle is
*authHandle,* which may be any TPM entity with a handle and an
associated *authValue*. This includes the reserved handles (for example,
Platform, Storage, and Endorsement), NV Indexes, and loaded objects.
*authEntity* is the entity referenced by *authHandle*. If *authEntity*
references an Ordinary object, it must have *userWithAuth* SET.

NOTE 1 The *userWithAuth* requirement permits the implementation to use
common authorization code.

If <u>*authEntity* references a non-PIN Index.</u> TPMA_NV_AUTHREAD is
required to be SET in the Index. If *authEntity* references an NV PIN
index, TPMA_NV_WRITTEN is required to be SET and *pinCount* must be less
than *pinLimit*.

NOTE 2 The authorization value for a hierarchy cannot be used in this
command if the hierarchy is disabled.

If the authorization check fails, then the normal dictionary attack
logic is invoked.

If the authorization provided by the authorization session is valid, the
command parameters are checked as described in 23.2.2.

When all validations have succeeded, *policySession*→*policyDigest* is
updated by **PolicyUpdate**() (see 23.2.3).

**PolicyUpdate**(TPM_CC_PolicySecret, authEntity→Name, policyRef) 1

*authEntity*→*Name* is a TPM2B_NAME*. policySession* is updated as
described in 23.2.4. The TPM will optionally produce a ticket as
described in 23.2.5.

If the session is a trial session, *policySession*→*policyDigest* is
updated if the authorization is valid.

NOTE 2 If an HMAC is used to convey the authorization, a separate
session is needed for the authorization. Because the HMAC in that
authorization will include a nonce that prevents replay of the
authorization, the value of the *nonceTPM* parameter in this command is
limited. It is retained mostly to provide processing consistency with
TPM2_PolicySigned().

### Command and Response

Table 130 — TPM2_PolicySecret Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_PolicySecret</td>
</tr>
<tr class="odd">
<td>TPMI_DH_ENTITY</td>
<td>@authHandle</td>
<td><p>handle for an entity providing the authorization</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPMI_SH_POLICY</td>
<td>policySession</td>
<td><p>handle for the policy session being extended</p>
<p>Auth Index: None</p></td>
</tr>
<tr class="odd">
<td>TPM2B_NONCE</td>
<td>nonceTPM</td>
<td><p>the policy nonce for the session</p>
<p>This can be the Empty Buffer.</p></td>
</tr>
<tr class="even">
<td>TPM2B_DIGEST</td>
<td>cpHashA</td>
<td><p>digest of the command parameters to which this authorization is
limited</p>
<p>This not the <em>cpHash</em> for this command but the <em>cpHash</em>
for the command to which this policy session will be applied. If it is
not limited, the parameter will be the Empty Buffer.</p></td>
</tr>
<tr class="odd">
<td>TPM2B_NONCE</td>
<td>policyRef</td>
<td><p>a reference to a policy relating to the authorization – may be
the Empty Buffer</p>
<p>Size is limited to be no larger than the nonce size supported on the
TPM.</p></td>
</tr>
<tr class="even">
<td>INT32</td>
<td>expiration</td>
<td><p>time when authorization will expire, measured in seconds from the
time that <em>nonceTPM</em> was generated</p>
<p>If <em>expiration</em> is non-negative, a NULL Ticket is returned.
See 23.2.5.</p></td>
</tr>
</tbody>
</table>

Table 131 — TPM2_PolicySecret Response

|               |              |                                                                                                                                                         |
|---------------|--------------|---------------------------------------------------------------------------------------------------------------------------------------------------------|
| Type          | Name         | Description                                                                                                                                             |
| TPM_ST        | tag          | see clause 6                                                                                                                                            |
| UINT32        | responseSize |                                                                                                                                                         |
| TPM_RC        | responseCode |                                                                                                                                                         |
| TPM2B_TIMEOUT | timeout      | implementation-specific time value used to indicate to the TPM when the ticket expires                                                                  |
| TPMT_TK_AUTH  | policyTicket | produced if the command succeeds and *expiration* in the command was non-zero ( See 23.2.5). This ticket will use the TPMT_ST_AUTH_SECRET structure tag |

### Detailed Actions

\[\[PolicySecret\]\]

## TPM2_PolicyTicket

### General Description

This command is similar to TPM2_PolicySigned() except that it takes a
ticket instead of a signed authorization. The ticket represents a
validated authorization that had an expiration time associated with it.

The parameters of this command are checked as described in 23.2.2.

If the checks succeed, the TPM uses the *timeout*, *cpHashA*,
*policyRef*, and *authName* to construct a ticket to compare with the
value in *ticket*. If these tickets match, then the TPM will create a
TPM2B_NAME (*objectName*) using *authName* and update the context of
*policySession* by **PolicyUpdate**() (see 23.2.3).

**PolicyUpdate**(commandCode, authName, policyRef) 1

If the structure tag of ticket is TPM_ST_AUTH_SECRET, then *commandCode*
will be TPM_CC_PolicySecret. If the structure tag of ticket is
TPM_ST_AUTH_SIGNED, then *commandCode* will be TPM_CC_PolicySIgned.

*policySession* is updated as described in 23.2.4.

### Command and Response

Table 132 — TPM2_PolicyTicket Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS if an audit or decrypt session is present;
otherwise, TPM_ST_NO_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_PolicyTicket</td>
</tr>
<tr class="odd">
<td>TPMI_SH_POLICY</td>
<td>policySession</td>
<td><p>handle for the policy session being extended</p>
<p>Auth Index: None</p></td>
</tr>
<tr class="even">
<td>TPM2B_TIMEOUT</td>
<td>timeout</td>
<td><p>time when authorization will expire</p>
<p>The contents are TPM specific. This shall be the value returned when
ticket was produced.</p></td>
</tr>
<tr class="odd">
<td>TPM2B_DIGEST</td>
<td>cpHashA</td>
<td><p>digest of the command parameters to which this authorization is
limited</p>
<p>If it is not limited, the parameter will be the Empty
Buffer.</p></td>
</tr>
<tr class="even">
<td>TPM2B_NONCE</td>
<td>policyRef</td>
<td>reference to a qualifier for the policy – may be the Empty
Buffer</td>
</tr>
<tr class="odd">
<td>TPM2B_NAME</td>
<td>authName</td>
<td>name of the object that provided the authorization</td>
</tr>
<tr class="even">
<td>TPMT_TK_AUTH</td>
<td>ticket</td>
<td>an authorization ticket returned by the TPM in response to a
TPM2_PolicySigned() or TPM2_PolicySecret()</td>
</tr>
</tbody>
</table>

Table 133 — TPM2_PolicyTicket Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[PolicyTicket\]\]

## TPM2_PolicyOR

### General Description

This command allows options in authorizations without requiring that the
TPM evaluate all of the options. If a policy may be satisfied by
different sets of conditions, the TPM need only evaluate one set that
satisfies the policy. This command will indicate that one of the
required sets of conditions has been satisfied.

*PolicySession*→*policyDigest* is compared against the list of provided
values. If the current *policySession*→*policyDigest* does not match any
value in the list, the TPM shall return TPM_RC_VALUE. Otherwise, the TPM
will reset *policySession*→*policyDigest* to a Zero Digest. Then
*policySession*→*policyDigest* is extended by the concatenation of
TPM_CC_PolicyOR and the concatenation of all of the digests.

If *policySession* is a trial session, the TPM will assume that
*policySession*→*policyDigest* matches one of the list entries and
compute the new value of *policyDigest*.

The algorithm for computing the new value for *policyDigest* of
*policySession* is:

1)  Concatenate all the digest values in *pHashList*:

digests ≔ pHashList.digests\[1\].buffer \|\| … \|\|
pHashList.digests\[n\].buffer 1

> NOTE 1 The TPM will not return an error if the size of an entry is not
> the same as the size of the digest of the policy. However, that entry
> cannot match *policyDigest*.

93) Reset *policyDigest* to a Zero Digest.

94) Extend the command code and the hashes computed in step a) above:

policyDigest<sub>new</sub> ≔
**H**<sub>policyAlg</sub>(policyDigest<sub>old</sub> \|\|
TPM_CC_PolicyOR \|\| digests) 1

> NOTE 2 The computation in b) and c) above is equivalent to:

policyDigest<sub>new</sub> ≔ **H**<sub>policyAlg</sub>(0…0 \|\|
TPM_CC_PolicyOR \|\| digests)

A TPM shall support a list with at least eight tagged digest values.

NOTE 3 If policies are to be portable between TPMs, then they should not
use more than eight values.

### Command and Response

Table 134 — TPM2_PolicyOR Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS if an audit session is present; otherwise,
TPM_ST_NO_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_PolicyOR</td>
</tr>
<tr class="odd">
<td>TPMI_SH_POLICY</td>
<td>policySession</td>
<td><p>handle for the policy session being extended</p>
<p>Auth Index: None</p></td>
</tr>
<tr class="even">
<td>TPML_DIGEST</td>
<td>pHashList</td>
<td>the list of hashes to check for a match</td>
</tr>
</tbody>
</table>

Table 135 — TPM2_PolicyOR Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[PolicyOR\]\]

## TPM2_PolicyPCR

### General Description

This command is used to cause conditional gating of a policy based on
PCR. This command together with TPM2_PolicyOR() allows one group of
authorizations to occur when PCR are in one state and a different set of
authorizations when the PCR are in a different state.

The TPM will modify the *pcrs* parameter so that bits that correspond to
unimplemented PCR are CLEAR. If *policySession* is not a trial policy
session, the TPM will use the modified value of pcrs to select PCR
values to hash according to TPM 2.0 Part 1, *Selecting Multiple PCR.*
The hash algorithm of the policy session is used to compute a digest
(*digestTPM*) of the selected PCR. If *pcrDigest* does not have a length
of zero, then it is compared to *digestTPM*; and if the values do not
match, the TPM shall return TPM_RC_VALUE and make no change to
*policySession*→*policyDigest*. If the values match, or if the length of
*pcrDigest* is zero, then *policySession*→*policyDigest* is extended by:

policyDigest<sub>new</sub> ≔
**H**<sub>policyAlg</sub>(policyDigest<sub>old</sub> \|\|
TPM_CC_PolicyPCR \|\| pcrs \|\| digestTPM) 1

where

pcrs the pcrs parameter with bits corresponding to unimplemented PCR set
to 0

*digestTPM* the digest of the selected PCR using the hash algorithm of
the policy session

NOTE 1 If the caller provides the expected PCR value, the intention is
that the policy evaluation stop at that point if the PCR do not match.
If the caller does not provide the expected PCR value, then the validity
of the settings will not be determined until an attempt is made to use
the policy for authorization. If the policy is constructed such that the
PCR check comes before user authorization checks, this early termination
would allow software to avoid unnecessary prompts for user input to
satisfy a policy that would fail later due to incorrect PCR values.

After this command completes successfully, the TPM shall return
TPM_RC_PCR_CHANGED if the policy session is used for authorization and
the PCR are not known to be correct.

The TPM uses a “generation” number (*pcrUpdateCounter*) that is
incremented each time PCR are updated (unless the PCR being changed is
specified not to cause a change to this counter). The value of this
counter is stored in the policy session context
(*policySession*→*pcrUpdateCounter*) when this command is executed. When
the policy is used for authorization, the current value of the counter
is compared to the value in the policy session context and the
authorization will fail if the values are not the same.

When this command is executed, *policySession*→*pcrUpdateCounter* is
checked to see if it has been previously set (in the reference
implementation, it has a value of zero if not previously set). If it has
been set, it will be compared with the current value of
*pcrUpdateCounter* to determine if any PCR changes have occurred. If the
values are different, the TPM shall return TPM_RC_PCR_CHANGED.

NOTE 2 Since the pcrUpdateCounter is updated if any PCR is extended
(except those specified not to do so), this means that the command will
fail even if a PCR not specified in the policy is updated. This is an
optimization for the purposes of conserving internal TPM memory. This
would be a rare occurrence, and, if this should occur, the policy could
be reset using the TPM2_PolicyRestart command and rerun.

If *policySession*→*pcrUpdateCounter* has not been set, then it is set
to the current value of *pcrUpdateCounter*.

If this command is used for a trial *policySession*,
*policySession*→*policyDigest* will be updated using the values from the
command rather than the values from a digest of the TPM PCR. If the
caller does not provide PCR settings (*pcrDigest* has a length of zero),
the TPM may (and it is preferred to) use the current TPM PCR settings
(*digestTPM)* in the calculation for the new *policyDigest*. The TPM may
return an error if the caller does not provide a PCR digest for a trial
policy session but this is not the preferred behavior.

The TPM will not check any PCR and will compute:

policyDigest<sub>new</sub> ≔
**H**<sub>policyAlg</sub>(policyDigest<sub>old</sub> \|\|
TPM_CC_PolicyPCR \|\| pcrs \|\| pcrDigest) 1

In this computation, pcrs is the input parameter without modification.

NOTE 3 The pcrs parameter is expected to match the configuration of the
TPM for which the policy is being computed which may not be the same as
the TPM on which the trial policy is being computed.

NOTE 4 Although no PCR are checked in a trial policy session,
*pcrDigest* is expected to correspond to some useful PCR values. It is
legal, but pointless, to have the TPM aid in calculating a
*policyDigest* corresponding to PCR values that are not useful in
practice.

### Command and Response

Table 136 — TPM2_PolicyPCR Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS if an audit or decrypt session is present;
otherwise, TPM_ST_NO_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_PolicyPCR</td>
</tr>
<tr class="odd">
<td>TPMI_SH_POLICY</td>
<td>policySession</td>
<td><p>handle for the policy session being extended</p>
<p>Auth Index: None</p></td>
</tr>
<tr class="even">
<td>TPM2B_DIGEST</td>
<td>pcrDigest</td>
<td>expected digest value of the selected PCR using the hash algorithm
of the session; may be zero length</td>
</tr>
<tr class="odd">
<td>TPML_PCR_SELECTION</td>
<td>pcrs</td>
<td>the PCR to include in the check digest</td>
</tr>
</tbody>
</table>

Table 137 — TPM2_PolicyPCR Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[PolicyPCR\]\]

## TPM2_PolicyLocality

### General Description

This command indicates that the authorization will be limited to a
specific locality.

*policySession→commandLocality* is a parameter kept in the session
context. When the policy session is started, this parameter is
initialized to a value that allows the policy to apply to any locality.

If *locality* has a value greater than 31, then an extended locality is
indicated. For an extended locality, the TPM will validate that
*policySession*→*commandLocality* has not previously been set or that
the current value of *policySession*→*commandLocality* is the same as
*locality* (TPM_RC_RANGE).

When *locality* is not an extended locality, the TPM will validate that
the *policySession*→*commandLocality* is not set to an extended locality
value (TPM_RC_RANGE). If not the TPM will disable any locality not SET
in the *locality* parameter. If the result of disabling localities
results in no locality being enabled, the TPM will return TPM_RC_RANGE.

If no error occurred in the validation of *locality*,
*policySession*→*policyDigest* is extended with

policyDigest<sub>new</sub> ≔
**H**<sub>policyAlg</sub>(policyDigest<sub>old</sub> \|\|
TPM_CC_PolicyLocality \|\| locality) 1

Then *policySession→commandLocality* is updated to indicate which
localities are still allowed after execution of TPM2_PolicyLocality().

When the policy session is used to authorize a command, the
authorization will fail if the locality used for the command is not one
of the enabled localities in *policySession*→*commandLocality*.

### Command and Response

Table 138 — TPM2_PolicyLocality Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS if an audit session is present; otherwise,
TPM_ST_NO_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_PolicyLocality</td>
</tr>
<tr class="odd">
<td>TPMI_SH_POLICY</td>
<td>policySession</td>
<td><p>handle for the policy session being extended</p>
<p>Auth Index: None</p></td>
</tr>
<tr class="even">
<td>TPMA_LOCALITY</td>
<td>locality</td>
<td>the allowed localities for the policy</td>
</tr>
</tbody>
</table>

Table 139 — TPM2_PolicyLocality Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[PolicyLocality\]\]

## TPM2_PolicyNV

### General Description

This command is used to cause conditional gating of a policy based on
the contents of an NV Index. It is an immediate assertion. The NV index
is validated during the TPM2_PolicyNV() command, not when the session is
used for authorization.

The authorization to read the NV Index must succeed even if
*policySession* is a trial policy session.

If *policySession* is a trial policy session, the TPM will update
*policySession*→*policyDigest* as shown in equations (22) and (23) below
and return TPM_RC_SUCCESS. It will not perform any further validation.
The remainder of this general description would apply only if
*policySession* is not a trial policy session.

An authorization session providing authorization to read the NV Index
shall be provided.

If TPMA_NV_WRITTEN is not SET in the NV Index, the TPM shall return
TPM_RC_NV_UNINITIALIZED. If TPMA_NV_READLOCKED of the NV Index is SET,
then the TPM shall return TPM_RC_NV_LOCKED.

For an NV Index with the TPM_NT_COUNTER or TPM_NT_BITS attribute SET,
the TPM may ignore the *offset* parameter and use an offset of 0.
Therefore, it is recommended that the caller set the *offset* parameter
to 0 for interoperability.

If *offset* and the *size* field of *data* add to a value that is
greater than the *dataSize* field of the NV Index referenced by
*nvIndex*, the TPM shall return an error (TPM_RC_NV_RANGE). The
implementation may return an error (TPM_RC_VALUE) if it performs an
additional check and determines that *offset* is greater than the
*dataSize* field of the NV Index.

operandA begins at *offset* into the NV index contents and has a size
equal to the size of *operandB*. The TPM will perform the indicated
arithmetic check using *operandA* and *operandB*. If the check fails,
the TPM shall return TPM_RC_POLICY and not change
*policySession*→*policyDigest*. If the check succeeds, the TPM will hash
the arguments:

args ≔ **H**<sub>policyAlg</sub>(operandB.buffer \|\| offset \|\|
operation) 1

where

**H**<sub>policyAlg</sub>() hash function using the algorithm of the
policy session

operandB the value used for the comparison

offset offset from the start of the NV Index data to start the
comparison

*operation* the operation parameter indicating the comparison being
performed

The value of args and the Name of the NV Index are extended to
*policySession*→*policyDigest* by

policyDigest<sub>new</sub> ≔
**H**<sub>policyAlg</sub>(policyDigest<sub>old</sub> \|\|
TPM_CC_PolicyNV \|\| args \|\| nvIndex→Name) 1

where

**H**<sub>policyAlg</sub>() hash function using the algorithm of the
policy session

args value computed in equation (22)

*nvIndex*→*Name* the Name of the NV Index

The signed arithmetic operations are performed using twos-compliment.

Magnitude comparisons assume that the octet at offset zero in the
referenced NV location and in *operandB* contain the most significant
octet of the data.

### Command and Response

Table 140 — TPM2_PolicyNV Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_PolicyNV</td>
</tr>
<tr class="odd">
<td>TPMI_RH_NV_AUTH</td>
<td>@authHandle</td>
<td><p>handle indicating the source of the authorization value</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPMI_RH_NV_INDEX</td>
<td>nvIndex</td>
<td><p>the NV Index of the area to read</p>
<p>Auth Index: None</p></td>
</tr>
<tr class="odd">
<td>TPMI_SH_POLICY</td>
<td>policySession</td>
<td><p>handle for the policy session being extended</p>
<p>Auth Index: None</p></td>
</tr>
<tr class="even">
<td>TPM2B_OPERAND</td>
<td>operandB</td>
<td>the second operand</td>
</tr>
<tr class="odd">
<td>UINT16</td>
<td>offset</td>
<td>the octet offset in the NV Index for the start of operand A</td>
</tr>
<tr class="even">
<td>TPM_EO</td>
<td>operation</td>
<td>the comparison to make</td>
</tr>
</tbody>
</table>

Table 141 — TPM2_PolicyNV Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[PolicyNV\]\]

## TPM2_PolicyCounterTimer

### General Description

This command is used to cause conditional gating of a policy based on
the contents of the TPMS_TIME_INFO structure.

If *policySession* is a trial policy session, the TPM will update
*policySession*→*policyDigest* as shown in equations (24) and (25) below
and return TPM_RC_SUCCESS. It will not perform any validation. The
remainder of this general description would apply only if
*policySession* is not a trial policy session.

The TPM will perform the indicated arithmetic check on the indicated
portion of the TPMS_TIME_INFO structure. If the check fails, the TPM
shall return TPM_RC_POLICY and not change
*policySession*→*policyDigest*. If the check succeeds, the TPM will hash
the arguments:

args ≔ **H**<sub>policyAlg</sub>(operandB.buffer \|\| offset \|\|
operation) 1

where

**H**<sub>policyAlg</sub>() hash function using the algorithm of the
policy session

operandB.buffer the value used for the comparison

offset offset from the start of the TPMS_TIME_INFO structure at which
the comparison starts

*operation* the operation parameter indicating the comparison being
performed

NOTE There is no security related reason for the double hash.

The value of *args* is extended to *policySession*→*policyDigest* by

policyDigest<sub>new</sub> ≔
**H**<sub>policyAlg</sub>(policyDigest<sub>old</sub> \|\|
TPM_CC_PolicyCounterTimer \|\| args) 1

where

**H**<sub>policyAlg</sub>() hash function using the algorithm of the
policy session

*args* value computed in equation (24)

The signed arithmetic operations are performed using twos-compliment.
The indicated portion of the TPMS_TIME_INFO structure begins at *offset*
and has a length of *operandB*.*size*. If the number of octets to be
compared overflows the TPMS_TIME_INFO structure, the TPM returns
TPM_RC_RANGE. If *offset* is greater than the size of the marshaled
TPMS_TIME_INFO structure, the TPM returns TPM_RC_VALUE. The structure is
marshaled into its canonical form with no padding. The TPM does not
check for alignment of the offset with a TPMS_TIME_INFO structure
member.

Magnitude comparisons assume that the octet at offset zero in the
referenced location and in *operandB* contain the most significant octet
of the data.

### Command and Response

Table 142 — TPM2_PolicyCounterTimer Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS if an audit or decrypt session is present;
otherwise, TPM_ST_NO_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_PolicyCounterTimer</td>
</tr>
<tr class="odd">
<td>TPMI_SH_POLICY</td>
<td>policySession</td>
<td><p>handle for the policy session being extended</p>
<p>Auth Index: None</p></td>
</tr>
<tr class="even">
<td>TPM2B_OPERAND</td>
<td>operandB</td>
<td>the second operand</td>
</tr>
<tr class="odd">
<td>UINT16</td>
<td>offset</td>
<td>the octet offset in the TPMS_TIME_INFO structure for the start of
operand A</td>
</tr>
<tr class="even">
<td>TPM_EO</td>
<td>operation</td>
<td>the comparison to make</td>
</tr>
</tbody>
</table>

Table 143 — TPM2_PolicyCounterTimer Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[PolicyCounterTimer\]\]

## TPM2_PolicyCommandCode

### General Description

This command indicates that the authorization will be limited to a
specific command code.

If *policySession*→*commandCode* has its default value, then it will be
set to *code.* If *policySession*→*commandCode* does not have its
default value, then the TPM will return TPM_RC_VALUE if the two values
are not the same.

If *code* is not implemented, the TPM will return TPM_RC_POLICY_CC.

If the TPM does not return an error, it will update
*policySession*→*policyDigest* by

policyDigest<sub>new</sub> ≔
**H**<sub>policyAlg</sub>(policyDigest<sub>old</sub> \|\|
TPM_CC_PolicyCommandCode \|\| code) 1

NOTE 1 If a previous TPM2_PolicyCommandCode() had been executed, then it
is probable that the policy expression is improperly formed but the TPM
does not return an error if *code* is the same.

NOTE 2 A TPM2_PolicyOR() would be used to allow an authorization to be
used for multiple commands.

When the policy session is used to authorize a command, the TPM will
fail the command if the *commandCode* of that command does not match
*policySession*→*commandCode*.

This command, or TPM2_PolicyDuplicationSelect(), is required to enable
the policy to be used for ADMIN role authorization.

EXAMPLE Before TPM2_Certify() can be executed, TPM2_PolicyCommandCode()
with code set to TPM_CC_Certify is required.

### Command and Response

Table 144 — TPM2_PolicyCommandCode Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS if an audit session is present; otherwise,
TPM_ST_NO_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_PolicyCommandCode</td>
</tr>
<tr class="odd">
<td>TPMI_SH_POLICY</td>
<td>policySession</td>
<td><p>handle for the policy session being extended</p>
<p>Auth Index: None</p></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>code</td>
<td>the allowed <em>commandCode</em></td>
</tr>
</tbody>
</table>

Table 145 — TPM2_PolicyCommandCode Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[PolicyCommandCode\]\]

## TPM2_PolicyPhysicalPresence

### General Description

This command indicates that physical presence will need to be asserted
at the time the authorization is performed.

If this command is successful, *policySession*→*isPPRequired* will be
SET to indicate that this check is required when the policy is used for
authorization. Additionally, *policySession*→*policyDigest* is extended
with

policyDigest<sub>new</sub> ≔
**H**<sub>policyAlg</sub>(policyDigest<sub>old</sub> \|\|
TPM_CC_PolicyPhysicalPresence) 1

### Command and Response

Table 146 — TPM2_PolicyPhysicalPresence Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS if an audit session is present; otherwise,
TPM_ST_NO_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_PolicyPhysicalPresence</td>
</tr>
<tr class="odd">
<td>TPMI_SH_POLICY</td>
<td>policySession</td>
<td><p>handle for the policy session being extended</p>
<p>Auth Index: None</p></td>
</tr>
</tbody>
</table>

Table 147 — TPM2_PolicyPhysicalPresence Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[PolicyPhysicalPresence\]\]

## TPM2_PolicyCpHash

### General Description

This command is used to allow a policy to be bound to a specific command
and command parameters.

TPM2_PolicySigned(), TPM2_PolicySecret(), and TPM2_PolicyTIcket() are
designed to allow an authorizing entity to execute an arbitrary command
as the *cpHashA* parameter of those commands is not included in
*policySession*→*policyDigest*. TPM2_PolicyCommandCode() allows the
policy to be bound to a specific Command Code so that only certain
entities may authorize specific command codes. This command allows the
policy to be restricted such that an entity may only authorize a command
with a specific set of parameters.

If *policySession*→*cpHash* is already set and not the same as
*cpHashA*, then the TPM shall return TPM_RC_CPHASH. If *cpHashA* does
not have the size of the *policySession*→*policyDigest*, the TPM shall
return TPM_RC_SIZE.

NOTE 1 If a previous TPM2_PolicyCpHash() had been executed, then it is
probable that the policy expression is improperly formed but the TPM
does not return an error if *cpHash* is the same.

If the *cpHashA* checks succeed, *policySession*→*cpHash* is set to
*cpHashA* and *policySession*→*policyDigest* is updated with

policyDigest<sub>new</sub> ≔
**H**<sub>policyAlg</sub>(policyDigest<sub>old</sub> \|\|
TPM_CC_PolicyCpHash \|\| cpHashA) 1

### Command and Response

Table 148 — TPM2_PolicyCpHash Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS if an audit or decrypt session is present;
otherwise, TPM_ST_NO_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_PolicyCpHash</td>
</tr>
<tr class="odd">
<td>TPMI_SH_POLICY</td>
<td>policySession</td>
<td><p>handle for the policy session being extended</p>
<p>Auth Index: None</p></td>
</tr>
<tr class="even">
<td>TPM2B_DIGEST</td>
<td>cpHashA</td>
<td>the <em>cpHash</em> added to the policy</td>
</tr>
</tbody>
</table>

Table 149 — TPM2_PolicyCpHash Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[PolicyCpHash\]\]

## TPM2_PolicyNameHash

### General Description

This command allows a policy to be bound to a specific set of TPM
entities without being bound to the parameters of the command. This is
most useful for commands such as TPM2_Duplicate() and for
TPM2_PCR_Event() when the referenced PCR requires a policy.

The *nameHash* parameter should contain the digest of the Names
associated with the handles to be used in the authorized command.

EXAMPLE For the TPM2_Duplicate() command, two handles are provided. One
is the handle of the object being duplicated and the other is the handle
of the new parent. For that command, *nameHash* would contain:

*nameHash* ≔ **H***<sub>policyAlg</sub>(objectHandle→Name* \|\|
*newParentHandle→Name)*

If *policySession*→*cpHash* is already set, the TPM shall return
TPM_RC_CPHASH. If the size of *nameHash* is not the size of
*policySession*→*policyDigest*, the TPM shall return TPM_RC_SIZE.
Otherwise, *policySession*→*cpHash* is set to *nameHash*.

If this command completes successfully, the *cpHash* of the authorized
command will not be used for validation. Only the digest of the Names
associated with the handles in the command will be used.

NOTE 1 This allows the space normally used to hold
*policySession*→*cpHash* to be used for *policySession*→*nameHash*
instead.

The *policySession*→*policyDigest* will be updated with

policyDigest<sub>new</sub> ≔
**H**<sub>policyAlg</sub>(policyDigest<sub>old</sub> \|\|
TPM_CC_PolicyNameHash \|\| nameHash) 1

NOTE 2 This command can only be used with TPM2_PolicyAuthorize() or
TPM2_PolicyAuthorizeNV. The owner of the object being duplicated
provides approval for their object to be migrated to a specific new
parent.

Without this approval, the Name of the Object would need to be known at
the time that Object's policy is created. However, since the Name of the
Object includes its policy, the Name is not known. The Name can be known
by the authorizing entity.

### Command and Response

Table 150 — TPM2_PolicyNameHash Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS if an audit or decrypt session is present;
otherwise, TPM_ST_NO_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_PolicyNameHash</td>
</tr>
<tr class="odd">
<td>TPMI_SH_POLICY</td>
<td>policySession</td>
<td><p>handle for the policy session being extended</p>
<p>Auth Index: None</p></td>
</tr>
<tr class="even">
<td>TPM2B_DIGEST</td>
<td>nameHash</td>
<td>the digest to be added to the policy</td>
</tr>
</tbody>
</table>

Table 151 — TPM2_PolicyNameHash Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[PolicyNameHash\]\]

## TPM2_PolicyDuplicationSelect

### General Description

This command allows qualification of duplication to allow duplication to
a selected new parent.

If this command not used in conjunction with a PolicyAuthorize Command,
then only the new parent is selected and *includeObject* should be
CLEAR.

EXAMPLE When an object is created when the list of allowed duplication
targets is known, the policy would be created with *includeObject*
CLEAR.

NOTE 1 Only the new parent may be selected because, without
TPM2_PolicyAuthorize(), the Name of the Object to be duplicated would
need to be known at the time that Object's policy is created. However,
since the Name of the Object includes its policy, the Name is not known.
The Name can be known by the authorizing entity (a PolicyAuthorize
Command) in which case *includeObject* may be SET.

If used in conjunction with TPM2_PolicyAuthorize(), then the authorizer
of the new policy has the option of selecting just the new parent or of
selecting both the new parent and the duplication Object.

NOTE 2 If the authorizing entity for an TPM2_PolicyAuthorize() only
specifies the new parent, then that authorization may be applied to the
duplication of any number of other Objects. If the authorizing entity
specifies both a new parent and the duplicated Object, then the
authorization only applies to that pairing of Object and new parent.

If either *policySession→cpHash* or *policySession*→*nameHash* has been
previously set, the TPM shall return TPM_RC_CPHASH. Otherwise,
*policySession*→*nameHash* will be set to:

nameHash ≔ **H**<sub>policyAlg</sub>(objectName.name \|\|
newParentName.name) 1

NOTE 3 It is allowed that policySesion→nameHash and policySession→cpHash
share the same memory space.

NOTE 4 The Name in these equations uses Name.name, indicating that the
UINT16 size is not included in the hash.

The *policySession*→*policyDigest* will be updated according to the
setting of *includeObject*. If equal to YES,
*policySession*→*policyDigest* is updated by:

policyDigest<sub>new</sub> ≔
**H**<sub>policyAlg</sub>(policyDigest<sub>old</sub> \|\|
TPM_CC_PolicyDuplicationSelect \|\|

objectName .name \|\| newParentName.name \|\| includeObject) 1

If includeObject is NO, *policySession*→*policyDigest* is updated by:

policyDigest<sub>new</sub> ≔
**H**<sub>policyAlg</sub>(policyDigest<sub>old</sub> \|\|
TPM_CC_PolicyDuplicationSelect \|\|

newParentName.name \|\| includeObject) 1

NOTE 5 *policySession*→*nameHash* receives the digest of both Names so
that the check performed in TPM2_Duplicate() may be the same regardless
of which Names are included in *policySession*→*policyDigest*. This
means that, when TPM2_PolicyDuplicationSelect() is executed, it is only
valid for a specific pair of duplication object and new parent.

If the command succeeds, *policySession*→*commandCode* is set to
TPM_CC_Duplicate.

NOTE 6 The normal use of this command is before a
TPM2_PolicyAuthorize(). An authorized entity would approve a
*policyDigest* that allowed duplication to a specific new parent. The
authorizing entity may want to limit the authorization so that the
approval allows only a specific object to be duplicated to the new
parent. In that case, the authorizing entity would approve the
*policyDigest* of *equation* (31).

### Command and Response

Table 152 — TPM2_PolicyDuplicationSelect Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS if an audit or decrypt session is present;
otherwise, TPM_ST_NO_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_PolicyDuplicationSelect</td>
</tr>
<tr class="odd">
<td>TPMI_SH_POLICY</td>
<td>policySession</td>
<td><p>handle for the policy session being extended</p>
<p>Auth Index: None</p></td>
</tr>
<tr class="even">
<td>TPM2B_NAME</td>
<td>objectName</td>
<td>the Name of the object to be duplicated</td>
</tr>
<tr class="odd">
<td>TPM2B_NAME</td>
<td>newParentName</td>
<td>the Name of the new parent</td>
</tr>
<tr class="even">
<td>TPMI_YES_NO</td>
<td>includeObject</td>
<td>if YES, the <em>objectName</em> will be included in the value in
<em>policySession</em>→<em>policyDigest</em></td>
</tr>
</tbody>
</table>

Table 153 — TPM2_PolicyDuplicationSelect Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[PolicyDuplicationSelect\]\]

## TPM2_PolicyAuthorize

### General Description

This command allows policies to change. If a policy were static, then it
would be difficult to add users to a policy. This command lets a policy
authority sign a new policy so that it may be used in an existing
policy.

The authorizing entity signs a structure that contains

aHash ≔ **H**<sub>aHashAlg</sub>(approvedPolicy \|\| policyRef) 1

The *aHashAlg* is required to be the *nameAlg* of the key used to sign
the *aHash*. The *aHash* value is then signed (symmetric or asymmetric)
by *keySign*. That signature is then checked by the TPM in 20.1
TPM2_VerifySignature() which produces a ticket by

**HMAC**(proof, (TPM_ST_VERIFIED \|\| aHash \|\| keySign→Name)) 1

NOTE 1 The reason for the validation is because of the expectation that
the policy will be used multiple times and it is more efficient to check
a ticket than to load an object each time to check a signature.

The ticket is then used in TPM2_PolicyAuthorize() to validate the
parameters.

The *keySign* parameter is required to be a valid object name using
nameAlg other than TPM_ALG_NULL. If the first two octets of *keySign*
are not a valid hash algorithm, the TPM shall return TPM_RC_HASH. If the
remainder of the Name is not the size of the indicated digest, the TPM
shall return TPM_RC_SIZE.

The TPM validates that the *approvedPolicy* matches the current value of
*policySession*→*policyDigest* and if not, shall return TPM_RC_VALUE.

The TPM then validates that the parameters to TPM2_PolicyAuthorize()
match the values used to generate the ticket. If so, the TPM will reset
*policySession*→*policyDigest* to a Zero Digest. Then it will update
*policySession*→*policyDigest* with **PolicyUpdate**() (see 23.2.3).

**PolicyUpdate**(TPM_CC_PolicyAuthorize, keySign, policyRef) 1

If the ticket is not valid, the TPM shall return TPM_RC_POLICY.

If *policySession* is a trial session, *policySession*→*policyDigest* is
extended as if the ticket is valid without actual verification.

NOTE 2 The unmarshaling process requires that a proper TPMT_TK_VERIFIED
be provided for *checkTicket* but it may be a NULL Ticket. A NULL ticket
is useful in a trial policy, where the caller uses the TPM to perform
policy calculations but does not have a valid authorization ticket.

### Command and Response

Table 154 — TPM2_PolicyAuthorize Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS if an audit or decrypt session is present;
otherwise, TPM_ST_NO_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_PolicyAuthorize</td>
</tr>
<tr class="odd">
<td>TPMI_SH_POLICY</td>
<td>policySession</td>
<td><p>handle for the policy session being extended</p>
<p>Auth Index: None</p></td>
</tr>
<tr class="even">
<td>TPM2B_DIGEST</td>
<td>approvedPolicy</td>
<td>digest of the policy being approved</td>
</tr>
<tr class="odd">
<td>TPM2B_NONCE</td>
<td>policyRef</td>
<td>a policy qualifier</td>
</tr>
<tr class="even">
<td>TPM2B_NAME</td>
<td>keySign</td>
<td>Name of a key that can sign a policy addition</td>
</tr>
<tr class="odd">
<td>TPMT_TK_VERIFIED</td>
<td>checkTicket</td>
<td>ticket validating that <em>approvedPolicy</em> and
<em>policyRef</em> were signed by <em>keySign</em></td>
</tr>
</tbody>
</table>

Table 155 — TPM2_PolicyAuthorize Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[PolicyAuthorize\]\]

## TPM2_PolicyAuthValue

### General Description

This command allows a policy to be bound to the authorization value of
the authorized entity.

When this command completes successfully,
*policySession*→*isAuthValueNeeded* is SET to indicate that the
*authValue* will be included in *hmacKey* when the authorization HMAC is
computed for the command being authorized using this session.
Additionally, *policySession*→*isPasswordNeeded* will be CLEAR.

NOTE If a policy does not use this command, then the *hmacKey* for the
authorized command would only use *sessionKey.* If *sessionKey* is not
present, then the *hmacKey* is an Empty Buffer and no HMAC would be
computed.

If successful, *policySession*→*policyDigest* will be updated with

policyDigest<sub>new</sub> ≔
**H**<sub>policyAlg</sub>(policyDigest<sub>old</sub> \|\|
TPM_CC_PolicyAuthValue) 1

### Command and Response

Table 156 — TPM2_PolicyAuthValue Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS if an audit session is present; otherwise,
TPM_ST_NO_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_PolicyAuthValue</td>
</tr>
<tr class="odd">
<td>TPMI_SH_POLICY</td>
<td>policySession</td>
<td><p>handle for the policy session being extended</p>
<p>Auth Index: None</p></td>
</tr>
</tbody>
</table>

Table 157 — TPM2_PolicyAuthValue Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[PolicyAuthValue\]\]

## TPM2_PolicyPassword

### General Description

This command allows a policy to be bound to the authorization value of
the authorized object.

When this command completes successfully,
*policySession*→*isPasswordNeeded* is SET to indicate that *authValue*
of the authorized object will be checked when the session is used for
authorization. The caller will provide the *authValue* in clear text in
the *hmac* parameter of the authorization. The comparison of *hmac* to
*authValue* is performed as if the authorization is a password.

NOTE 1 The parameter field in the policy session where the authorization
value is provided is called *hmac*. If TPM2_PolicyPassword() is part of
the sequence, then the field will contain a password and not an HMAC.

If successful, *policySession*→*policyDigest* will be updated with

policyDigest<sub>new</sub> ≔
**H**<sub>policyAlg</sub>(policyDigest<sub>old</sub> \|\|
TPM_CC_PolicyAuthValue) 1

NOTE 2 This is the same extend value as used with TPM2_PolicyAuthValue
so that the evaluation may be done using either an HMAC or a password
with no change to the *authPolicy* of the object. The reason that two
commands are present is to indicate to the TPM if the *hmac* field in
the authorization will contain an HMAC or a password value.

When this command is successful, *policySession*→*isAuthValueNeeded*
will be CLEAR.

### Command and Response

Table 158 — TPM2_PolicyPassword Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS if an audit session is present; otherwise,
TPM_ST_NO_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_PolicyPassword</td>
</tr>
<tr class="odd">
<td>TPMI_SH_POLICY</td>
<td>policySession</td>
<td><p>handle for the policy session being extended</p>
<p>Auth Index: None</p></td>
</tr>
</tbody>
</table>

Table 159 — TPM2_PolicyPassword Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[PolicyPassword\]\]

## TPM2_PolicyGetDigest

### General Description

This command returns the current *policyDigest* of the session. This
command allows the TPM to be used to perform the actions required to
pre-compute the *authPolicy* for an object.

### Command and Response

Table 160 — TPM2_PolicyGetDigest Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS if an audit or encrypt session is present;
otherwise, TPM_ST_NO_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_PolicyGetDigest</td>
</tr>
<tr class="odd">
<td>TPMI_SH_POLICY</td>
<td>policySession</td>
<td><p>handle for the policy session</p>
<p>Auth Index: None</p></td>
</tr>
</tbody>
</table>

Table 161 — TPM2_PolicyGetDigest Response

|              |              |                                                         |
|--------------|--------------|---------------------------------------------------------|
| Type         | Name         | Description                                             |
| TPM_ST       | tag          | see clause 6                                            |
| UINT32       | responseSize |                                                         |
| TPM_RC       | responseCode |                                                         |
| TPM2B_DIGEST | policyDigest | the current value of the *policySession*→*policyDigest* |

### Detailed Actions

\[\[PolicyGetDigest\]\]

## TPM2_PolicyNvWritten

### General Description

This command allows a policy to be bound to the TPMA_NV_WRITTEN
attributes. This is a deferred assertion. Values are stored in the
policy session context and checked when the policy is used for
authorization.

If *policySession→checkNVWritten* is CLEAR, it is SET and
*policySession→nvWrittenState* is set to *writtenSet*. If
*policySession→checkNVWritten* is SET, the TPM will return TPM_RC_VALUE
if *policySession→nvWrittenState* and *writtenSet* are not the same.

If the TPM does not return an error, it will update
*policySession*→*policyDigest* by

policyDigest<sub>new</sub> ≔
**H**<sub>policyAlg</sub>(policyDigest<sub>old</sub> \|\|
TPM_CC_PolicyNvWritten \|\| writtenSet) 1

When the policy session is used to authorize a command, the TPM will
fail the command if *policySession→checkNVWritten* is SET and
*nvIndex→attributes→TPMA_NV_WRITTEN does not match
policySession→nvWrittenState.*

NOTE 1 A typical use case is a simple policy for the first write during
manufacturing provisioning that would require TPMA_NV_WRITTEN CLEAR and
a more complex policy for later use that would require TPMA_NV_WRITTEN
SET.

NOTE 2 When an Index is written, it has a different authorization name
than an Index that has not been written. It is possible to use this
change in the NV Index to create a write-once Index.

### Command and Response

Table 162 — TPM2_PolicyNvWritten Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS if an audit session is present; otherwise,
TPM_ST_NO_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_PolicyNvWritten</td>
</tr>
<tr class="odd">
<td>TPMI_SH_POLICY</td>
<td>policySession</td>
<td><p>handle for the policy session being extended</p>
<p>Auth Index: None</p></td>
</tr>
<tr class="even">
<td>TPMI_YES_NO</td>
<td>writtenSet</td>
<td><p>YES if NV Index is required to have been written</p>
<p>NO if NV Index is required not to have been written</p></td>
</tr>
</tbody>
</table>

Table 163 — TPM2_PolicyNvWritten Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[PolicyNvWRitten\]\]

## TPM2_PolicyTemplate

### General Description

This command allows a policy to be bound to a specific creation
template. This is most useful for an object creation command such as
TPM2_Create(), TPM2_CreatePrimary(), or TPM2_CreateLoaded().

The *templateHash* parameter should contain the digest of the template
that will be required for the *inPublic* parameter of an Object creation
command.

If *policySession*→*isTemplateHash* is SET and *policySession*→*cpHash*
is not equal to *templateHash,* the TPM shall return TPM_RC_VALUE.

NOTE 1 Revision 01.38 of this specification permitted the TPM to return
TPM_RC_CPHASH.

Otherwise, if *policySession*→*cpHash* is already set, the TPM shall
return TPM_RC_CPHASH.

NOTE 2 Revision 01.38 of this specification permitted the TPM to return
TPM_RC_VALUE.

If the size of *templateHash* is not the size of
*policySession*→*policyDigest*, the TPM shall return TPM_RC_SIZE.
Otherwise, *policySession*→*cpHash* is set to *templateHash*.

NOTE 3 The digest calculation includes the TPM2B buffer but not the
TPM2B size.

If this command completes successfully, the *cpHash* of the authorized
command will not be used for validation. Only the digest of the
*inPublic* parameter will be used.

NOTE 4 This allows the space normally used to hold
*policySession*→*cpHash* to be used for *policySession*→*templateHash*
instead.

The *policySession*→*policyDigest* will be updated with

policyDigest<sub>new</sub> ≔
**H**<sub>policyAlg</sub>(policyDigest<sub>old</sub> \|\|
TPM_CC_PolicyTemplate \|\| templateHash) 1

### Command and Response

Table 164 — TPM2_PolicyTemplate Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS if an audit or decrypt session is present;
otherwise, TPM_ST_NO_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_PolicyTemplate</td>
</tr>
<tr class="odd">
<td>TPMI_SH_POLICY</td>
<td>policySession</td>
<td><p>handle for the policy session being extended</p>
<p>Auth Index: None</p></td>
</tr>
<tr class="even">
<td>TPM2B_DIGEST</td>
<td>templateHash</td>
<td>the digest to be added to the policy</td>
</tr>
</tbody>
</table>

Table 165 — TPM2_PolicyTemplate Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[PolicyTemplate\]\]

## TPM2_PolicyAuthorizeNV

### General Description

This command provides a capability that is the equivalent of a revocable
policy. With TPM2_PolicyAuthorize(), the authorization ticket never
expires, so the authorization may not be withdrawn. With this command,
the approved policy is kept in an NV Index location so that the policy
may be changed as needed to render the old policy unusable.

NOTE 1 This command is useful for Objects but of limited value for other
policies that are persistently stored in TPM NV, such as the
OwnerPolicy.

An authorization session providing authorization to read the NV Index
shall be provided.

The authorization to read the NV Index must succeed even if
*policySession* is a trial policy session.

If *policySession* is a trial policy session, the TPM will update
*policySession*→*policyDigest* as shown in equation (40) below and
return TPM_RC_SUCCESS. It will not perform any further validation. The
remainder of this general description would apply only if
*policySession* is not a trial policy session.

NOTE 2 If read access is controlled by policy, the policy should include
a branch that authorizes a TPM2_PolicyAuthorizeNV().

If TPMA_NV_WRITTEN is not SET in the Index referenced by *nvIndex*, the
TPM shall return TPM_RC_NV_UNINITIALIZED. If TPMA_NV_READLOCKED of the
NV Index is SET, then the TPM shall return TPM_RC_NV_LOCKED.

The *dataSize* of the NV Index referenced by *nvIndex* is required to be
at least large enough to hold a properly formatted TPMT_HA
(TPM_RC_INSUFFICIENT).

NOTE 3 A TPMT_HA contains a TPM_ALG_ID followed a digest that is
consistent in size with the hash algorithm indicated by the TPM_ALG_ID.

It is an error (TPM_RC_HASH) if the first two octets of the Index are
not a TPM_ALG_ID for a hash algorithm implemented on the TPM or if the
indicated hash algorithm does not match *policySession*→*authHash*.

NOTE 4 The TPM_ALG_ID is stored in the first two octets in big endian
format.

The TPM will compare *policySession*→*policyDigest* to the contents of
the NV Index, starting at the first octet after the TPM_ALG_ID (the
third octet) and return TPM_RC_VALUE if they are not the same.

NOTE 5 If the Index does not contain enough bytes for the compare, then
TPM_RC_INSUFFICENT is generated as indicated above.

NOTE 6 The *dataSize* of the Index may be larger than is required for
this command. This permits the Index to include metadata.

If the comparison is successful, the TPM will reset
*policySession*→*policyDigest* to a Zero Digest. Then it will update
*policySession*→*policyDigest* with

policyDigest<sub>new</sub> ≔
**H**<sub>policyAlg</sub>(policyDigest<sub>old</sub> \|\|
TPM_CC_PolicyAuthorizeNV \|\| nvIndex→Name) 1

### Command and Response

Table 166 — TPM2_PolicyAuthorizeNV Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
<col style="width: 0%" />
</colgroup>
<thead>
<tr class="header">
<th>Type</th>
<th>Name</th>
<th colspan="2">Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td colspan="2">TPM_ST_SESSIONS</td>
</tr>
<tr class="even">
<td>UINT32</td>
<td>commandSize</td>
<td colspan="2"></td>
</tr>
<tr class="odd">
<td>TPM_CC</td>
<td>commandCode</td>
<td colspan="2">TPM_CC_PolicyAuthorizeNV</td>
</tr>
<tr class="even">
<td>TPMI_RH_NV_AUTH</td>
<td>@authHandle</td>
<td><p>handle indicating the source of the authorization value</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
<td></td>
</tr>
<tr class="odd">
<td>TPMI_RH_NV_INDEX</td>
<td>nvIndex</td>
<td><p>the NV Index of the area to read</p>
<p>Auth Index: None</p></td>
<td></td>
</tr>
<tr class="even">
<td>TPMI_SH_POLICY</td>
<td>policySession</td>
<td><p>handle for the policy session being extended</p>
<p>Auth Index: None</p></td>
<td></td>
</tr>
</tbody>
</table>

Table 167 — TPM2_PolicyAuthorizeNV Response

| Type   | Name         | Description  |
|--------|--------------|--------------|
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[PolicyAuthorizeNV\]\]

# Hierarchy Commands

## TPM2_CreatePrimary

### General Description

This command is used to create a Primary Object under one of the Primary
Seeds or a Temporary Object under TPM_RH_NULL. The command uses a
TPM2B_PUBLIC as a template for the object to be created. The size of the
*unique* field shall not be checked for consistency with the other
object parameters. The command will create and load a Primary Object.
The sensitive area is not returned.

NOTE 1 Since the sensitive data is not returned, the key cannot be
reloaded. It can either be made persistent or it can be recreated.

NOTE 2 For interoperability, the *unique* field should not be set to a
value that is larger than allowed by object parameters, so that the
unmarshaling will not fail.

NOTE 3 An Empty Buffer is a legal *unique* field value.

EXAMPLE 1 A TPM_ALG_RSA object with a *keyBits* of 2048 in the objects
parameters should have a *unique* field that is no larger than 256
bytes.

EXAMPLE 2 A TPM_ALG_KEYEDHASH or a TPM_ALG_SYMCIPHER object should have
a *unique* field this is no larger than the digest produced by the
object’s *nameAlg*.

Any type of object and attributes combination that is allowed by
TPM2_Create() may be created by this command. The constraints on
templates and parameters are the same as TPM2_Create() except that a
Primary Storage Key and a Temporary Storage Key are not constrained to
use the algorithms of their parents.

For setting of the attributes of the created object, *fixedParent*,
*fixedTPM*, decrypt, and restricted are implied to be SET in the parent
(a Permanent Handle). The remaining attributes are implied to be CLEAR.

The TPM will derive the object from the Primary Seed indicated in
*primaryHandle* using an approved KDF. All of the bits of the template
are used in the creation of the Primary Key. Methods for creating a
Primary Object from a Primary Seed are described in TPM 2.0 Part 1 and
implemented in TPM 2.0 Part 4.

If this command is called multiple times with the same *inPublic*
parameter, *inSensitive.data*, and Primary Seed, the TPM shall produce
the same Primary Object.

NOTE 4 If the Primary Seed is changed, the Primary Objects generated
with the new seed shall be statistically unique even if the parameters
of the call are the same.

This command requires authorization. Authorization for a Primary Object
attached to the Platform Primary Seed (PPS) shall be provided by
*platformAuth* or *platformPolicy*. Authorization for a Primary Object
attached to the Storage Primary Seed (SPS) shall be provided by
*ownerAuth* or *ownerPolicy*. Authorization for a Primary Key attached
to the Endorsement Primary Seed (EPS) shall be provided by
*endorsementAuth* or *endorsementPolicy*.

### Command and Response

Table 168 — TPM2_CreatePrimary Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_CreatePrimary</td>
</tr>
<tr class="odd">
<td>TPMI_RH_HIERARCHY+</td>
<td>@primaryHandle</td>
<td><p>TPM_RH_ENDORSEMENT, TPM_RH_OWNER, TPM_RH_PLATFORM+{PP}, or
TPM_RH_NULL</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPM2B_SENSITIVE_CREATE</td>
<td>inSensitive</td>
<td>the sensitive data, see TPM 2.0 Part 1 Sensitive Values</td>
</tr>
<tr class="odd">
<td>TPM2B_PUBLIC</td>
<td>inPublic</td>
<td>the public template</td>
</tr>
<tr class="even">
<td>TPM2B_DATA</td>
<td>outsideInfo</td>
<td>data that will be included in the creation data for this object to
provide permanent, verifiable linkage between this object and some
object owner data</td>
</tr>
<tr class="odd">
<td>TPML_PCR_SELECTION</td>
<td>creationPCR</td>
<td>PCR that will be used in creation data</td>
</tr>
</tbody>
</table>

Table 169 — TPM2_CreatePrimary Response

|                     |                |                                                                                                  |
|---------------------|----------------|--------------------------------------------------------------------------------------------------|
| Type                | Name           | Description                                                                                      |
| TPM_ST              | tag            | see clause 6                                                                                     |
| UINT32              | responseSize   |                                                                                                  |
| TPM_RC              | responseCode   |                                                                                                  |
| TPM_HANDLE          | objectHandle   | handle of type TPM_HT_TRANSIENT for created Primary Object                                       |
| TPM2B_PUBLIC        | outPublic      | the public portion of the created object                                                         |
| TPM2B_CREATION_DATA | creationData   | contains a TPMT_CREATION_DATA                                                                    |
| TPM2B_DIGEST        | creationHash   | digest of *creationData* using *nameAlg* of *outPublic*                                          |
| TPMT_TK_CREATION    | creationTicket | ticket used by TPM2_CertifyCreation() to validate that the creation data was produced by the TPM |
| TPM2B_NAME          | name           | the name of the created object                                                                   |

### Detailed Actions

\[\[CreatePrimary\]\]

## TPM2_HierarchyControl

### General Description

This command enables and disables use of a hierarchy and its associated
NV storage. The command allows *phEnable*, *phEnableNV*, *shEnable*, and
*ehEnable* to be changed when the proper authorization is provided.

This command may be used to CLEAR *phEnable* and *phEnableNV* if
*platformAuth/platformPolicy* is provided. *phEnable* may not be SET
using this command.

This command may be used to CLEAR *shEnable* if either
*platformAuth/platformPolicy* or *ownerAuth/ownerPolicy* is provided.
*shEnable* may be SET if *platformAuth*/*platformPolicy* is provided.

This command may be used to CLEAR *ehEnable* if either
*platformAuth*/*platformPolicy* or *endorsementAuth*/*endorsementPolicy*
is provided. *ehEnable* may be SET if *platformAuth*/*platformPolicy* is
provided.

When this command is used to CLEAR *phEnable*, *shEnable*, or
*ehEnable*, the TPM will disable use of any persistent entity associated
with the disabled hierarchy and will flush any transient objects
associated with the disabled hierarchy.

When this command is used to CLEAR *shEnable,* the TPM will disable
access to any NV index that has TPMA_NV_PLATFORMCREATE CLEAR (indicating
that the NV Index was defined using Owner Authorization). As long as
*shEnable* is CLEAR, the TPM will return an error in response to any
command that attempts to operate upon an NV index that has
TPMA_NV_PLATFORMCREATE CLEAR.

When this command is used to CLEAR *phEnableNV*, the TPM will disable
access to any NV index that has TPMA_NV_PLATFORMCREATE SET (indicating
that the NV Index was defined using Platform Authorization). As long as
*phEnableNV* is CLEAR, the TPM will return an error in response to any
command that attempts to operate upon an NV index that has
TPMA_NV_PLATFORMCREATE SET.

### Command and Response

Table 170 — TPM2_HierarchyControl Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_HierarchyControl {NV E}</td>
</tr>
<tr class="odd">
<td>TPMI_RH_HIERARCHY</td>
<td>@authHandle</td>
<td><p>TPM_RH_ENDORSEMENT, TPM_RH_OWNER or TPM_RH_PLATFORM+{PP}</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPMI_RH_ENABLES</td>
<td>enable</td>
<td><p>the enable being modified</p>
<p>TPM_RH_ENDORSEMENT, TPM_RH_OWNER, TPM_RH_PLATFORM, or
TPM_RH_PLATFORM_NV</p></td>
</tr>
<tr class="odd">
<td>TPMI_YES_NO</td>
<td>state</td>
<td>YES if the enable should be SET, NO if the enable should be
CLEAR</td>
</tr>
</tbody>
</table>

Table 171 — TPM2_HierarchyControl Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[HierarchyControl\]\]

## TPM2_SetPrimaryPolicy

### General Description

This command allows setting of the authorization policy for the lockout
(*lockoutPolicy*), the platform hierarchy (*platformPolicy*), the
storage hierarchy (*ownerPolicy*), and the endorsement hierarchy
(*endorsementPolicy*). On TPMs implementing Authenticated Countdown
Timers (ACT), this command may also be used to set the authorization
policy for an ACT.

The command requires an authorization session. The session shall use the
current *authValue* or satisfy the current *authPolicy* for the
referenced hierarchy, or the ACT.

The policy that is changed is the policy associated with *authHandle*.

If the enable associated with *authHandle* is not SET, then the
associated authorization values (*authValue* or *authPolicy*) may not be
used, and the TPM returns TPM_RC_HIERARCHY.

When *hashAlg* is not TPM_ALG_NULL, if the size of *authPolicy* is not
consistent with the hash algorithm, the TPM returns TPM_RC_SIZE.

### Command and Response

Table 172 — TPM2_SetPrimaryPolicy Command

<table>
<colgroup>
<col style="width: 31%" />
<col style="width: 19%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_SetPrimaryPolicy {NV}</td>
</tr>
<tr class="odd">
<td>TPMI_RH_HIERARCHY_POLICY</td>
<td>@authHandle</td>
<td><p>TPM_RH_LOCKOUT, TPM_RH_ENDORSEMENT, TPM_RH_OWNER, TPMI_RH_ACT or
TPM_RH_PLATFORM+{PP}</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPM2B_DIGEST</td>
<td>authPolicy</td>
<td><p>an authorization policy digest; may be the Empty Buffer</p>
<p>If <em>hashAlg</em> is TPM_ALG_NULL, then this shall be an Empty
Buffer.</p></td>
</tr>
<tr class="odd">
<td>TPMI_ALG_HASH+</td>
<td>hashAlg</td>
<td><p>the hash algorithm to use for the policy</p>
<p>If the <em>authPolicy</em> is an Empty Buffer, then this field shall
be TPM_ALG_NULL.</p></td>
</tr>
</tbody>
</table>

Table 173 — TPM2_SetPrimaryPolicy Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[SetPrimaryPolicy\]\]

## TPM2_ChangePPS

### General Description

This replaces the current platform primary seed (PPS) with a value from
the RNG and sets *platformPolicy* to the default initialization value
(the Empty Buffer).

NOTE 1 A policy that is the Empty Buffer can match no policy.

NOTE 2 Platform Authorization is not changed.

All resident transient and persistent objects in the Platform hierarchy
are flushed.

Saved contexts in the Platform hierarchy that were created under the old
PPS will no longer be able to be loaded.

The policy hash algorithm for PCR is reset to TPM_ALG_NULL.

This command does not clear any NV Index values.

NOTE 3 Index values belonging to the Platform are preserved because the
indexes may have configuration information that will be the same after
the PPS changes. The Platform may remove the indexes that are no longer
needed using TPM2_NV_UndefineSpace().

This command requires Platform Authorization*.*

### Command and Response

Table 174 — TPM2_ChangePPS Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_ChangePPS {NV E}</td>
</tr>
<tr class="odd">
<td>TPMI_RH_PLATFORM</td>
<td>@authHandle</td>
<td><p>TPM_RH_PLATFORM+{PP}</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
</tbody>
</table>

Table 175 — TPM2_ChangePPS Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[ChangePPS\]\]

## TPM2_ChangeEPS

### General Description

This replaces the current endorsement primary seed (EPS) with a value
from the RNG and sets the Endorsement hierarchy controls to their
default initialization values: *ehEnable* is SET, *endorsementAuth* and
*endorsementPolicy* are both set to the Empty Buffer. It will flush any
resident objects (transient or persistent) in the Endorsement hierarchy
and not allow objects in the hierarchy associated with the previous EPS
to be loaded.

NOTE In the reference implementation, *ehProof* is a non-volatile value
from the RNG. It is allowed that the *ehProof* be generated by a KDF
using both the EPS and SPS as inputs. If generated with a KDF, the
ehProof can be generated on an as-needed basis or made a non-volatile
value.

This command requires Platform Authorization*.*

### Command and Response

Table 176 — TPM2_ChangeEPS Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_ChangeEPS {NV E}</td>
</tr>
<tr class="odd">
<td>TPMI_RH_PLATFORM</td>
<td>@authHandle</td>
<td><p>TPM_RH_PLATFORM+{PP}</p>
<p>Auth Handle: 1</p>
<p>Auth Role: USER</p></td>
</tr>
</tbody>
</table>

Table 177 — TPM2_ChangeEPS Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[ChangeEPS\]\]

## TPM2_Clear

### General Description

This command removes all TPM context associated with a specific Owner.

The clear operation will:

- flush resident objects (persistent and volatile) in the Storage and
  Endorsement hierarchies;

- delete any NV Index with TPMA_NV_PLATFORMCREATE == CLEAR;

- change the storage primary seed (SPS) to a new value from the TPM’s
  random number generator (RNG),

- change *shProof* and *ehProof*,

> NOTE 1 The proof values may be set from the RNG or derived from the
> associated new Primary Seed. If derived from the Primary Seeds, the
> derivation of *ehProof* shall use both the SPS and EPS. The
> computation shall use the SPS as an HMAC key and the derived value may
> then be a parameter in a second HMAC in which the EPS is the HMAC key.
> The reference design uses values from the RNG.

- SET *shEnable* and *ehEnable*;

- set *ownerAuth*, *endorsementAuth*, and *lockoutAuth* to the Empty
  Buffer;

- set *ownerPolicy,* *endorsementPolicy,* and *lockoutPolicy* to the
  Empty Buffer;

- set *Clock* to zero;

- set *resetCount* to zero;

- set *restartCount* to zero; and

- set *Safe* to YES.

- increment *pcrUpdateCounter*

> NOTE 2 This permits an application to create a policy session that is
> invalidated on TPM2_Clear. The policy needs, ideally as the first
> term, TPM2_PolicyPCR(). The session is invalidated even if the PCR
> selection is empty.

This command requires Platform Authorization or Lockout Authorization.
If TPM2_ClearControl() has disabled this command, the TPM shall return
TPM_RC_DISABLED.

If this command is authorized using *lockoutAuth*, the HMAC in the
response shall use the new *lockoutAuth* value (that is, the Empty
Buffer) when computing the response HMAC.

### Command and Response

Table 178 — TPM2_Clear Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_Clear {NV E}</td>
</tr>
<tr class="odd">
<td>TPMI_RH_CLEAR</td>
<td>@authHandle</td>
<td><p>TPM_RH_LOCKOUT or TPM_RH_PLATFORM+{PP}</p>
<p>Auth Handle: 1</p>
<p>Auth Role: USER</p></td>
</tr>
</tbody>
</table>

Table 179 — TPM2_Clear Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[Clear\]\]

## TPM2_ClearControl

### General Description

TPM2_ClearControl() disables and enables the execution of TPM2_Clear().

The TPM will SET the TPM’s TPMA_PERMANENT.*disableClear* attribute if
*disable* is YES and will CLEAR the attribute if *disable* is NO. When
the attribute is SET, TPM2_Clear() may not be executed.

NOTE This is to simplify the logic of TPM2_Clear(). TPM2_ClearControl()
can be called using Platform Authorization to CLEAR the *disableClear*
attribute and then execute TPM2_Clear().

Lockout Authorization may be used to SET *disableClear* but not to CLEAR
it.

Platform Authorization may be used to SET or CLEAR *disableClear*.

### Command and Response

Table 180 — TPM2_ClearControl Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_ClearControl {NV}</td>
</tr>
<tr class="odd">
<td>TPMI_RH_CLEAR</td>
<td>@auth</td>
<td><p>TPM_RH_LOCKOUT or TPM_RH_PLATFORM+{PP}</p>
<p>Auth Handle: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPMI_YES_NO</td>
<td>disable</td>
<td>YES if the <em>disableOwnerClear</em> flag is to be SET, NO if the
flag is to be CLEAR.</td>
</tr>
</tbody>
</table>

Table 181 — TPM2_ClearControl Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[ClearControl\]\]

## TPM2_HierarchyChangeAuth

### General Description

This command allows the authorization secret for a hierarchy or lockout
to be changed using the current authorization value as the command
authorization.

If *authHandle* is TPM_RH_PLATFORM, then *platformAuth* is changed. If
*authHandle* is TPM_RH_OWNER, then o*wnerAuth* is changed. If
*authHandle* is TPM_RH_ENDORSEMENT, then e*ndorsementAuth* is changed.
If *authHandle* is TPM_RH_LOCKOUT, then *lockoutAuth* is changed. The
HMAC in the response shall use the new authorization value when
computing the response HMAC.

If *authHandle* is TPM_RH_PLATFORM, then Physical Presence may need to
be asserted for this command to succeed (see 26.2, *TPM2_PP_Commands*).

The authorization value may be no larger than the digest produced by the
hash algorithm used for context integrity.

EXAMPLE If SHA384 is used in the computation of the integrity values for
saved contexts, then the largest authorization value is 48 octets.

### Command and Response

Table 182 — TPM2_HierarchyChangeAuth Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_HierarchyChangeAuth {NV}</td>
</tr>
<tr class="odd">
<td>TPMI_RH_HIERARCHY_AUTH</td>
<td>@authHandle</td>
<td><p>TPM_RH_LOCKOUT, TPM_RH_ENDORSEMENT, TPM_RH_OWNER or
TPM_RH_PLATFORM+{PP}</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPM2B_AUTH</td>
<td>newAuth</td>
<td>new authorization value</td>
</tr>
</tbody>
</table>

Table 183 — TPM2_HierarchyChangeAuth Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[HierarchyChangeAuth\]\]

# Dictionary Attack Functions

## Introduction

A TPM is required to have support for logic that will help prevent a
dictionary attack on an authorization value. The protection is provided
by a counter that increments when a password authorization or an HMAC
authorization fails. When the counter reaches a predefined value, the
TPM will not accept, for some time interval, further requests that
require authorization and the TPM is in Lockout mode. While the TPM is
in Lockout mode, the TPM will return TPM_RC_LOCKOUT if the command
requires use of an object’s or Index’s *authValue* unless the
authorization applies to an entry in the Platform hierarchy.

NOTE 1 Authorizations for objects and NV Index values in the Platform
hierarchy are never locked out. However, a command that requires
multiple authorizations will not be accepted when the TPM is in Lockout
mode unless all of the authorizations reference objects and indexes in
the Platform hierarchy.

If the TPM is continuously powered for the duration of *newRecoveryTime*
and no authorization failures occur, the authorization failure counter
will be decremented by one. This property is called “self-healing.”
Self-healing shall not cause the count of failed attempts to decrement
below zero.

The count of failed attempts, the lockout interval, and self-healing
interval are settable using TPM2_DictionaryAttackParameters(). The
lockout parameters and the current value of the lockout counter can be
read with TPM2_GetCapability().

Dictionary attack protection does not apply to an entity associated with
a permanent handle (handle type == TPM_HT_PERMANENT) other than
TPM_RH_LOCKOUT

## TPM2_DictionaryAttackLockReset

### General Description

This command cancels the effect of a TPM lockout due to a number of
successive authorization failures. If this command is properly
authorized, the lockout counter is set to zero.

Only one *lockoutAuth* authorization failure is allowed for this command
during a *lockoutRecovery* interval (set using
TPM2_DictionaryAttackParameters().

### Command and Response

Table 184 — TPM2_DictionaryAttackLockReset Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_DictionaryAttackLockReset {NV}</td>
</tr>
<tr class="odd">
<td>TPMI_RH_LOCKOUT</td>
<td>@lockHandle</td>
<td><p>TPM_RH_LOCKOUT</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
</tbody>
</table>

Table 185 — TPM2_DictionaryAttackLockReset Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[DictionaryAttackLockReset\]\]

## TPM2_DictionaryAttackParameters

### General Description

This command changes the lockout parameters.

The command requires Lockout Authorization.

The timeout parameters (*newRecoveryTime* and *lockoutRecovery*)
indicate values that are measured with respect to the *Time* and not
*Clock*.

NOTE Use of *Time* means that the TPM shall be continuously powered for
the duration of a timeout.

If *newRecoveryTime* is zero, then DA protection is disabled.
Authorizations are checked but authorization failures will not cause the
TPM to enter lockout.

If *newMaxTries* is zero, the TPM will be in lockout and use of DA
protected entities will be disabled.

If *lockoutRecovery* is zero, then the recovery interval is \_TPM_Init
followed by TPM2_Startup().

Only one *lockoutAuth* authorization failure is allowed for this command
during a *lockoutRecovery* interval.

### Command and Response

Table 186 — TPM2_DictionaryAttackParameters Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_DictionaryAttackParameters {NV}</td>
</tr>
<tr class="odd">
<td>TPMI_RH_LOCKOUT</td>
<td>@lockHandle</td>
<td><p>TPM_RH_LOCKOUT</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>UINT32</td>
<td>newMaxTries</td>
<td>count of authorization failures before the lockout is imposed</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>newRecoveryTime</td>
<td><p>time in seconds before the authorization failure count is
automatically decremented</p>
<p>A value of zero indicates that DA protection is disabled.</p></td>
</tr>
<tr class="even">
<td>UINT32</td>
<td>lockoutRecovery</td>
<td><p>time in seconds after a <em>lockoutAuth</em> failure before use
of <em>lockoutAuth</em> is allowed</p>
<p>A value of zero indicates that a reboot is required.</p></td>
</tr>
</tbody>
</table>

Table 187 — TPM2_DictionaryAttackParameters Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[DictionaryAttackParameters\]\]

# Miscellaneous Management Functions

## Introduction

This clause contains commands that do not logically group with any other
commands.

## TPM2_PP_Commands

### General Description

This command is used to determine which commands require assertion of
Physical Presence (PP) in addition to *platformAuth*/*platformPolicy*.

This command requires that *auth* is TPM_RH_PLATFORM and that Physical
Presence be asserted.

After this command executes successfully, the commands listed in
*setList* will be added to the list of commands that require that
Physical Presence be asserted when the handle associated with the
authorization is TPM_RH_PLATFORM. The commands in *clearList* will no
longer require assertion of Physical Presence in order to authorize a
command.

If a command is not in either list, its state is not changed. If a
command is in both lists, then it will no longer require Physical
Presence (for example, *setList* is processed first).

Only commands with handle types of TPMI_RH_PLATFORM, TPMI_RH_PROVISION,
TPMI_RH_CLEAR, or TPMI_RH_HIERARCHY can be gated with Physical Presence.
If any other command is in either list, it is discarded.

When a command requires that Physical Presence be provided, then
Physical Presence shall be asserted for either an HMAC or a Policy
authorization.

NOTE 1 Physical Presence may be made a requirement of any policy.

NOTE 2 If the TPM does not implement this command, the command list is
vendor specific. A platform-specific specification may require that the
command list be initialized in a specific way.

TPM2_PP_Commands() always requires assertion of Physical Presence.

### Command and Response

Table 188 — TPM2_PP_Commands Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_PP_Commands {NV}</td>
</tr>
<tr class="odd">
<td>TPMI_RH_PLATFORM</td>
<td>@auth</td>
<td><p>TPM_RH_PLATFORM+PP</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER + Physical Presence</p></td>
</tr>
<tr class="even">
<td>TPML_CC</td>
<td>setList</td>
<td>list of commands to be added to those that will require that
Physical Presence be asserted</td>
</tr>
<tr class="odd">
<td>TPML_CC</td>
<td>clearList</td>
<td>list of commands that will no longer require that Physical Presence
be asserted</td>
</tr>
</tbody>
</table>

Table 189 — TPM2_PP_Commands Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[PP_Commands\]\]

## TPM2_SetAlgorithmSet

### General Description

This command allows the platform to change the set of algorithms that
are used by the TPM. The *algorithmSet* setting is a vendor-dependent
value.

If the changing of the algorithm set results in a change of the
algorithms of PCR banks, then the TPM will need to be reset (\_TPM_Init
and TPM2_Startup(TPM_SU_CLEAR)) before the new PCR settings take effect.
After this command executes successfully, if *startupType* in the next
TPM2_Startup() is not TPM_SU_CLEAR, the TPM shall return TPM_RC_VALUE
and may enter Failure mode.

Other than PCR, when an algorithm is no longer supported, the behavior
of this command is vendor-dependent.

EXAMPLE Entities may remain resident. Persistent objects, transient
objects, or sessions may be flushed. NV Indexes may be undefined.
Policies may be erased.

NOTE The reference implementation does not have support for this
command. In particular, it does not support use of this command to
selectively disable algorithms. Proper support would require
modification of the unmarshaling code so that each time an algorithm is
unmarshaled, it would be verified as being enabled.

### Command and Response

Table 190 — TPM2_SetAlgorithmSet Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_SetAlgorithmSet {NV}</td>
</tr>
<tr class="odd">
<td>TPMI_RH_PLATFORM</td>
<td>@authHandle</td>
<td><p>TPM_RH_PLATFORM</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>UINT32</td>
<td>algorithmSet</td>
<td>a TPM vendor-dependent value indicating the algorithm set
selection</td>
</tr>
</tbody>
</table>

Table 191 — TPM2_SetAlgorithmSet Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[SetAlgorithmSet\]\]

# Field Upgrade

## Introduction

This clause contains the commands for managing field upgrade of the
firmware in the TPM. The field upgrade scheme may be used for
replacement or augmentation of the firmware installed in the TPM.

EXAMPLE 1 If an algorithm is found to be flawed, a patch of that
algorithm might be installed using the firmware upgrade process. The
patch might be a replacement of a portion of the code or a complete
replacement of the firmware.

EXAMPLE 2 If an additional set of ECC parameters is needed, the firmware
process may be used to add the parameters to the TPM data set.

The field upgrade process uses two commands (TPM2_FieldUpgradeStart()
and TPM2_FieldUpgradeData()). TPM2_FieldUpgradeStart() validates that a
signature on the provided digest is from the TPM manufacturer and that
proper authorization is provided using *platformPolicy*.

NOTE 1 The *platformPolicy* for field upgraded is defined by the PM and
may include requirements that the upgrade be signed by the PM or the TPM
owner and include any other constraints that are desired by the PM.

If the proper authorization is given, the TPM will retain the signed
digest and enter the Field Upgrade mode (FUM). While in FUM, the TPM
will accept TPM2_FieldUpgradeData() commands. It may accept other
commands if it is able to complete them using the previously installed
firmware. Otherwise, it will return TPM_RC_UPGRADE.

Each block of the field upgrade shall contain the digest of the next
block of the field upgrade data. That digest shall be included in the
digest of the previous block. The digest of the first block is signed by
the TPM manufacturer. That signature and first block digest are the
parameters for TPM2_FieldUpgradeStart(). The digest is saved in the TPM
as the required digest for the next field upgrade data block and as the
identifier of the field upgrade sequence.

For each field upgrade data block that is sent to the TPM by
TPM2_FieldUpgradeData(), the TPM shall validate that the digest matches
the required digest and if not, shall return TPM_RC_VALUE. The TPM shall
extract the digest of the next expected block and return that value to
the caller, along with the digest of the first data block of the update
sequence.

The system may attempt to abandon the firmware upgrade by using a
zero-length buffer in TPM2_FieldUpdateData(). If the TPM is able to
resume operation using the firmware present when the upgrade started,
then the TPM will indicate that it has abandon the update by setting the
digest of the next block to the Empty Buffer. If the TPM cannot abandon
the update, it will return the expected next digest.

The system may also attempt to abandon the update because of a power
interruption. If the TPM is able to resume normal operations, then it
will respond normally to TPM2_Startup(). If the TPM is not able to
resume normal operations, then it will respond to any command but
TPM2_FieldUpgradeData() with TPM_RC_UPGRADE.

After a \_TPM_Init, system software may not be able to resume the field
upgrade that was in process when the power interruption occurred. In
such case, the TPM firmware may be reset to one of two other values:

- the original firmware that was installed at the factory (“initial
  firmware”); or

- the firmware that was in the TPM when the field upgrade process
  started (“previous firmware”).

The TPM retains the digest of the first block for these firmware images
and checks to see if the first block after \_TPM_Init matches either of
those digests. If so, the firmware update process restarts and the
original firmware may be loaded.

NOTE 2 The TPM is required to accept the previous firmware as either a
vendor-provided update or as recovered from the TPM using
TPM2_FirmwareRead().

When the last block of the firmware upgrade is loaded into the TPM
(indicated to the TPM by data in the data block in a TPM vendor-specific
manner), the TPM will complete the upgrade process. If the TPM is able
to resume normal operations without a reboot, it will set the hash
algorithm of the next block to TPM_ALG_NULL and return TPM_RC_SUCCESS.
If a reboot is required, the TPM shall return TPM_RC_REBOOT in response
to the last TPM2_FieldUpgradeData() and all subsequent TPM commands
until a \_TPM_Init is received.

NOTE 3 Because no additional data is allowed when the response code is
not TPM_RC_SUCCESS, the TPM returns TPM_RC_SUCCESS for all calls to
TPM2_FieldUpgradeData() except the last. In this manner, the TPM is able
to indicate the digest of the next block. If a \_TPM_Init occurs while
the TPM is in FUM, the next block may be the digest for the first block
of the original firmware. If it is not, then the TPM will not accept the
original firmware until the next \_TPM_Init when the TPM is in FUM.

During the field upgrade process, either the one specified in this
clause or a vendor proprietary field upgrade process, the TPM should
preserve:

- Primary Seeds;

- Hierarchy *authValue*, *authPolicy*, and *proof* values;

- Lockout *authValue* and authorization failure count values;

- PCR authValue and authPolicy values;

- NV Index allocations and contents;

- Persistent object allocations and contents; and

- Clock.

NOTE 4 A platform manufacturer may provide a means to change preserved
data to accommodate a case where a field upgrade fixes a flaw that might
have compromised TPM secrets.

## TPM2_FieldUpgradeStart

### General Description

This command uses *platformPolicy* and a TPM Vendor Authorization Key to
authorize a Field Upgrade Manifest.

If the signature checks succeed, the authorization is valid and the TPM
will accept TPM2_FieldUpgradeData().

This signature is checked against the loaded key referenced by
*keyHandle*. This key will have a Name that is the same as a value that
is part of the TPM firmware data. If the signature is not valid, the TPM
shall return TPM_RC_SIGNATURE.

NOTE A loaded key is used rather than a hard-coded key to reduce the
amount of memory needed for this key data in case more than one vendor
key is needed.

### Command and Response

Table 192 — TPM2_FieldUpgradeStart Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_FieldUpgradeStart</td>
</tr>
<tr class="odd">
<td>TPMI_RH_PLATFORM</td>
<td>@authorization</td>
<td><p>TPM_RH_PLATFORM+{PP}</p>
<p>Auth Index:1</p>
<p>Auth Role: ADMIN</p></td>
</tr>
<tr class="even">
<td>TPMI_DH_OBJECT</td>
<td>keyHandle</td>
<td><p>handle of a public area that contains the TPM Vendor
Authorization Key that will be used to validate
<em>manifestSignature</em></p>
<p>Auth Index: None</p></td>
</tr>
<tr class="odd">
<td>TPM2B_DIGEST</td>
<td>fuDigest</td>
<td>digest of the first block in the field upgrade sequence</td>
</tr>
<tr class="even">
<td>TPMT_SIGNATURE</td>
<td>manifestSignature</td>
<td>signature over <em>fuDigest</em> using the key associated with
<em>keyHandle</em> (not optional)</td>
</tr>
</tbody>
</table>

Table 193 — TPM2_FieldUpgradeStart Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[FieldUpgradeStart\]\]

## TPM2_FieldUpgradeData

### General Description

This command will take the actual field upgrade image to be installed on
the TPM. The exact format of *fuData* is vendor-specific. This command
is only possible following a successful TPM2_FieldUpgradeStart(). If the
TPM has not received a properly authorized TPM2_FieldUpgradeStart(),
then the TPM shall return TPM_RC_FIELDUPGRADE.

The TPM will validate that the digest of *fuData* matches an expected
value. If so, the TPM may buffer or immediately apply the update. If the
digest of *fuData* does not match an expected value, the TPM shall
return TPM_RC_VALUE.

### Command and Response

Table 194 — TPM2_FieldUpgradeData Command

|                     |             |                                                                                          |
|---------------------|-------------|------------------------------------------------------------------------------------------|
| Type                | Name        | Description                                                                              |
| TPMI_ST_COMMAND_TAG | tag         | TPM_ST_SESSIONS if an audit or decrypt session is present; otherwise, TPM_ST_NO_SESSIONS |
| UINT32              | commandSize |                                                                                          |
| TPM_CC              | commandCode | TPM_CC_FieldUpgradeData {NV}                                                             |
| TPM2B_MAX_BUFFER    | fuData      | field upgrade image data                                                                 |

Table 195 — TPM2_FieldUpgradeData Response

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPM_ST</td>
<td>tag</td>
<td>see clause 6</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>responseSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_RC</td>
<td>responseCode</td>
<td></td>
</tr>
<tr class="odd">
<td>TPMT_HA+</td>
<td>nextDigest</td>
<td><p>tagged digest of the next block</p>
<p>TPM_ALG_NULL if field update is complete</p></td>
</tr>
<tr class="even">
<td>TPMT_HA</td>
<td>firstDigest</td>
<td>tagged digest of the first block of the sequence</td>
</tr>
</tbody>
</table>

### Detailed Actions

\[\[FieldUpgradeData\]\]

## TPM2_FirmwareRead

### General Description

This command is used to read a copy of the current firmware installed in
the TPM.

The presumption is that the data will be returned in reverse order so
that the last block in the sequence would be the first block given to
the TPM in case of a failure recovery. If the TPM2_FirmwareRead sequence
completes successfully, then the data provided from the TPM will be
sufficient to allow the TPM to recover from an abandoned upgrade of this
firmware.

To start the sequence of retrieving the data, the caller sets
*sequenceNumber* to zero. When the TPM has returned all the firmware
data, the TPM will return the Empty Buffer as *fuData*.

The contents of *fuData* are opaque to the caller.

NOTE 1 The caller should retain the ordering of the update blocks so
that the blocks sent to the TPM have the same size and inverse order as
the blocks returned by a sequence of calls to this command.

NOTE 2 Support for this command is optional even if the TPM implements
TPM2_FieldUpgradeStart() and TPM2_FieldUpgradeData().

### Command and Response

Table 196 — TPM2_FirmwareRead Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS if an audit or encrypt session is present;
otherwise, TPM_ST_NO_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_FirmwareRead</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>sequenceNumber</td>
<td><p>the number of previous calls to this command in this sequence</p>
<p>set to 0 on the first call</p></td>
</tr>
</tbody>
</table>

Table 197 — TPM2_FirmwareRead Response

|                  |              |                          |
|------------------|--------------|--------------------------|
| Type             | Name         | Description              |
| TPM_ST           | tag          | see clause 6             |
| UINT32           | responseSize |                          |
| TPM_RC           | responseCode |                          |
| TPM2B_MAX_BUFFER | fuData       | field upgrade image data |

### Detailed Actions

\[\[FirmwareRead\]\]

# Context Management

## Introduction

Three of the commands in this clause (TPM2_ContextSave(),
TPM2_ContextLoad(), and TPM2_FlushContext()) implement the resource
management described in the "Context Management" clause in TPM 2.0 Part
1.

The fourth command in this clause (TPM2_EvictControl()) is used to
control the persistence of loadable objects in TPM memory. Background
for this command may be found in the "Owner and Platform Evict Objects"
clause in TPM 2.0 Part 1.

## TPM2_ContextSave

### General Description

This command saves a session context, object context, or sequence object
context outside the TPM.

No authorization sessions of any type are allowed with this command and
tag is required to be TPM_ST_NO_SESSIONS.

NOTE This preclusion avoids complex issues of dealing with the same
session in *handle* and in the session area. While it might be possible
to provide specificity, it would add unnecessary complexity to the TPM
and, because this capability would provide no application benefit, use
of authorization sessions for audit or encryption is prohibited.

The TPM shall encrypt and integrity protect the TPM2B_CONTEXT_SENSITIVE
*context* as described in the "Context Protections" clause in TPM 2.0
Part 1.

See the “Context Data” clause in TPM 2.0 Part 2 for a description of the
*context* structure in the response.

### Command and Response

Table 198 — TPM2_ContextSave Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_NO_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_ContextSave</td>
</tr>
<tr class="odd">
<td>TPMI_DH_CONTEXT</td>
<td>saveHandle</td>
<td><p>handle of the resource to save</p>
<p>Auth Index: None</p></td>
</tr>
</tbody>
</table>

Table 199 — TPM2_ContextSave Response

|              |              |              |
|--------------|--------------|--------------|
| Type         | Name         | Description  |
| TPM_ST       | tag          | see clause 6 |
| UINT32       | responseSize |              |
| TPM_RC       | responseCode |              |
| TPMS_CONTEXT | context      |              |

### Detailed Actions

\[\[ContextSave\]\]

## TPM2_ContextLoad

### General Description

This command is used to reload a context that has been saved by
TPM2_ContextSave().

No authorization sessions of any type are allowed with this command and
tag is required to be TPM_ST_NO_SESSIONS (see note in 28.2.1).

The TPM will return TPM_RC_HIERARCHY if the context is associated with a
hierarchy that is disabled.

NOTE Contexts for authorization sessions and for sequence objects belong
to the NULL hierarchy, which is never disabled.

See the “Context Data” clause in TPM 2.0 Part 2 for a description of the
values in the *context* parameter.

If the integrity HMAC of the saved context is not valid, the TPM shall
return TPM_RC_INTEGRITY.

The TPM shall perform a check on the decrypted context as described in
the "Context Confidentiality Protection" clause of TPM 2.0 Part 1 and
enter failure mode if the check fails.

### Command and Response

Table 200 — TPM2_ContextLoad Command

|                     |             |                    |
|---------------------|-------------|--------------------|
| Type                | Name        | Description        |
| TPMI_ST_COMMAND_TAG | tag         | TPM_ST_NO_SESSIONS |
| UINT32              | commandSize |                    |
| TPM_CC              | commandCode | TPM_CC_ContextLoad |
| TPMS_CONTEXT        | context     | the context blob   |

Table 201 — TPM2_ContextLoad Response

|                 |              |                                                                           |
|-----------------|--------------|---------------------------------------------------------------------------|
| Type            | Name         | Description                                                               |
| TPM_ST          | tag          | see clause 6                                                              |
| UINT32          | responseSize |                                                                           |
| TPM_RC          | responseCode |                                                                           |
| TPMI_DH_CONTEXT | loadedHandle | the handle assigned to the resource after it has been successfully loaded |

### Detailed Actions

\[\[ContextLoad\]\]

## TPM2_FlushContext

### General Description

This command causes all context associated with a loaded object,
sequence object, or session to be removed from TPM memory.

This command may not be used to remove a persistent object from the TPM.
Use TPM2_EvictControl to remove a persistent object.

A session does not have to be loaded in TPM memory to have its context
flushed. The saved session context associated with the indicated handle
is invalidated. When flushing a session, the upper byte of the handle is
ignored.

EXAMPLE A command to flush session handle 0x20000000 will flush session
handle 0x03000000.

No sessions of any type are allowed with this command and tag is
required to be TPM_ST_NO_SESSIONS (see note in 28.2.1).

If the handle is for a Transient Object and the handle is not associated
with a loaded object, then the TPM shall return TPM_RC_HANDLE.

If the handle is for an authorization session and the handle does not
reference a loaded or active session, then the TPM shall return
TPM_RC_HANDLE.

NOTE *flushHandle* is a parameter and not a handle. If it were in the
handle area, the TPM would validate that the context for the referenced
entity is in the TPM. When a TPM2_FlushContext references a saved
session context, it is not necessary for the context to be in the TPM.
When the *flushHandle* is in the parameter area, the TPM does not
validate that associated context is actually in the TPM.

### Command and Response

Table 202 — TPM2_FlushContext Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_NO_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_FlushContext</td>
</tr>
<tr class="odd">
<td>TPMI_DH_CONTEXT</td>
<td>flushHandle</td>
<td><p>the handle of the item to flush</p>
<p>NOTE This is a use of a handle as a parameter.</p></td>
</tr>
</tbody>
</table>

Table 203 — TPM2_FlushContext Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[FlushContext\]\]

## TPM2_EvictControl

### General Description

This command allows certain Transient Objects to be made persistent or a
persistent object to be evicted.

NOTE 1 A transient object is one that may be removed from TPM memory
using either TPM2_FlushContext or TPM2_Startup(). A persistent object is
not removed from TPM memory by TPM2_FlushContext() or TPM2_Startup().

If *objectHandle* is a Transient Object, then this call makes a
persistent copy of the object and assigns *persistentHandle* to the
persistent version of the object. If *objectHandle* is a persistent
object, then the call evicts the persistent object. The call does not
affect the transient object.

Before execution of TPM2_EvictControl code below, the TPM verifies that
*objectHandle* references an object that is resident on the TPM and that
*persistentHandle* is a valid handle for a persistent object.

NOTE 2 This requirement simplifies the unmarshaling code so that it only
need check that *persistentHandle* is always a persistent object.

If *objectHandle* references a Transient Object:

1)  The TPM shall return TPM_RC_ATTRIBUTES if

<!-- -->

95) it is in the hierarchy of TPM_RH_NULL,

96) only the public portion of the object is loaded, or

> NOTE 3 This is for NV space efficiency. Loading an object whose
> private part is empty would unnecessarily consume NV resources.

97) the *stClear* is SET in the object or in an ancestor key.

98) The TPM shall return TPM_RC_HIERARCHY if the object is not in the
    proper hierarchy as determined by *auth*.

99) If *auth* is TPM_RH_PLATFORM, the proper hierarchy is the Platform
    hierarchy.

100) If *auth* is TPM_RH_OWNER, the proper hierarchy is either the
     Storage or the Endorsement hierarchy.

101) The TPM shall return TPM_RC_RANGE if *persistentHandle* is not in
     the proper range as determined by *auth*.

102) If *auth* is TPM_RH_OWNER, then *persistentHandle* shall be in the
     inclusive range of 81 00 00 00<sub>16</sub> to
     81 7F FF FF<sub>16</sub>.

103) If *auth* is TPM_RH_PLATFORM, then *persistentHandle* shall be in
     the inclusive range of 81 80 00 00<sub>16</sub> to
     81 FF FF FF<sub>16</sub>.

> NOTE 4 This separation permits the platform (the platform OEM) a range
> of indexes that will not interfere with indexes used by the TPM owner
> (the OS or applications).

104) The TPM shall return TPM_RC_NV_DEFINED if a persistent object
     exists with the same handle as *persistentHandle*.

105) The TPM shall return TPM_RC_NV_SPACE if insufficient space is
     available to make the object persistent.

106) The TPM shall return TPM_RC_NV_SPACE if execution of this command
     will prevent the TPM from being able to hold two transient objects
     of any kind.

> NOTE 5 This requirement anticipates that a TPM may be implemented such
> that all TPM memory is non-volatile and not subject to endurance
> issues. In such case, there is no movement of an object between memory
> of different types and it is necessary that the TPM ensure that it is
> always possible for the management software to move objects to/from
> TPM memory in order to ensure that the objects required for command
> execution can be context restored.

107) If the TPM returns TPM_RC_SUCCESS, the object referenced by
     *objectHandle* will not be flushed and both *objectHandle* and
     *persistentHandle* may be used to access the object.

If *objectHandle* references a persistent object:

1)  The TPM shall return TPM_RC_RANGE if *objectHandle* is not in the
    proper range as determined by *auth*. If *auth* is TPM_RC_OWNER,
    *objectHandle* shall be in the inclusive range of
    81 00 00 00<sub>16</sub> to 81 7F FF FF<sub>16</sub>. If *auth* is
    TPM_RC_PLATFORM, *objectHandle* may be any valid persistent object
    handle.

2)  If objectHandle is not the same value as persistentHandle, return
    TPM_RC_HANDLE.

<!-- -->

108) If the TPM returns TPM_RC_SUCCESS, *objectHandle* will be removed
     from persistent memory and no longer be accessible.

NOTE 5 The persistent object is not converted to a transient object, as
this would prevent the immediate revocation of an object by removing it
from persistent memory.

### Command and Response

Table 204 — TPM2_EvictControl Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_EvictControl {NV}</td>
</tr>
<tr class="odd">
<td>TPMI_RH_PROVISION</td>
<td>@auth</td>
<td><p>TPM_RH_OWNER or TPM_RH_PLATFORM+{PP}</p>
<p>Auth Handle: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPMI_DH_OBJECT</td>
<td>objectHandle</td>
<td><p>the handle of a loaded object</p>
<p>Auth Index: None</p></td>
</tr>
<tr class="odd">
<td>TPMI_DH_PERSISTENT</td>
<td>persistentHandle</td>
<td><p>if <em>objectHandle</em> is a transient object handle, then this
is the persistent handle for the object</p>
<p>if <em>objectHandle</em> is a persistent object handle, then it shall
be the same value as <em>persistentHandle</em></p></td>
</tr>
</tbody>
</table>

Table 205 — TPM2_EvictControl Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[EvictControl\]\]

# Clocks and Timers

## TPM2_ReadClock

### General Description

This command reads the current TPMS_TIME_INFO structure that contains
the current setting of *Time*, *Clock*, *resetCount*, and
*restartCount*.

### Command and Response

Table 206 — TPM2_ReadClock Command

| Type                | Name        | Description                                                                   |
|---------------------|-------------|-------------------------------------------------------------------------------|
| TPMI_ST_COMMAND_TAG | tag         | TPM_ST_SESSIONS if an audit session is present; otherwise, TPM_ST_NO_SESSIONS |
| UINT32              | commandSize |                                                                               |
| TPM_CC              | commandCode | TPM_CC_ReadClock                                                              |

Table 207 — TPM2_ReadClock Response

| Type           | Name         | Description  |
|----------------|--------------|--------------|
| TPM_ST         | tag          | see clause 6 |
| UINT32         | responseSize |              |
| TPM_RC         | responseCode |              |
| TPMS_TIME_INFO | currentTime  |              |

### Detailed Actions

\[\[ReadClock\]\]

## TPM2_ClockSet

### General Description

This command is used to advance the value of the TPM’s *Clock*. The
command will fail if *newTime* is less than the current value of *Clock*
or if the new time is greater than FF FF 00 00 00 00 00 00<sub>16</sub>.
If both of these checks succeed, *Clock* is set to *newTime*. If either
of these checks fails, the TPM shall return TPM_RC_VALUE and make no
change to *Clock*.

NOTE This maximum setting would prevent *Clock* from rolling over to
zero for approximately 8,000 years at the real time *Clock* update rate.
If the *Clock* update rate was set so that TPM time was passing 33
percent faster than real time, it would still be more than 6,000 years
before *Clock* would roll over to zero. Because *Clock* will not roll
over in the lifetime of the TPM, there is no need for external software
to deal with the possibility that *Clock* may wrap around.

If the value of *Clock* after the update makes the volatile and
non-volatile versions of TPMS_CLOCK_INFO.*clock* differ by more than the
reported update interval, then the TPM shall update the non-volatile
version of TPMS_CLOCK_INFO.*clock* before returning.

This command requires Platform Authorization or Owner Authorization.

### Command and Response

Table 208 — TPM2_ClockSet Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<thead>
<tr class="header">
<th>Type</th>
<th>Name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="even">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="odd">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_ClockSet {NV}</td>
</tr>
<tr class="even">
<td>TPMI_RH_PROVISION</td>
<td>@auth</td>
<td><p>TPM_RH_OWNER or TPM_RH_PLATFORM+{PP}</p>
<p>Auth Handle: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="odd">
<td>UINT64</td>
<td>newTime</td>
<td>new <em>Clock</em> setting in milliseconds</td>
</tr>
</tbody>
</table>

Table 209 — TPM2_ClockSet Response

| Type   | Name         | Description  |
|--------|--------------|--------------|
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[ClockSet\]\]

## TPM2_ClockRateAdjust

### General Description

This command adjusts the rate of advance of *Clock* and *Time* to
provide a better approximation to real time.

The *rateAdjust* value is relative to the current rate and not the
nominal rate of advance.

EXAMPLE 1 If this command had been called three times with *rateAdjust*
= TPM_CLOCK_COARSE_SLOWER and once with *rateAdjust* =
TPM_CLOCK_COARSE_FASTER, the net effect will be as if the command had
been called twice with *rateAdjust* = TPM_CLOCK_COARSE_SLOWER.

The range of adjustment shall be sufficient to allow *Clock* and *Time*
to advance at real time but no more. If the requested adjustment would
make the rate advance faster or slower than the nominal accuracy of the
input frequency, the TPM shall return TPM_RC_VALUE.

EXAMPLE 2 If the frequency tolerance of the TPM's input clock is +/-10
percent, then the TPM will return TPM_RC_VALUE if the adjustment would
make *Clock* run more than 10 percent faster or slower than nominal.
That is, if the input oscillator were nominally 100 megahertz (MHz),
then 1 millisecond (ms) would normally take 100,000 counts. The update
*Clock* should be adjustable so that 1 ms is between 90,000 and 110,000
counts.

The interpretation of “fine” and “coarse” adjustments is
implementation-specific.

The nominal rate of advance for *Clock* and *Time* shall be accurate to
within 15 percent. That is, with no adjustment applied, *Clock* and
*Time* shall be advanced at a rate within 15 percent of actual time.

NOTE If the adjustments are incorrect, it will be possible to make the
difference between advance of *Clock/Time* and real time to be as much
as 1.15<sup>2</sup> or ~1.33.

Changes to the current *Clock* update rate adjustment need not be
persisted across TPM power cycles.

### Command and Response

Table 210 — TPM2_ClockRateAdjust Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<thead>
<tr class="header">
<th>Type</th>
<th>Name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="even">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="odd">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_ClockRateAdjust</td>
</tr>
<tr class="even">
<td>TPMI_RH_PROVISION</td>
<td>@auth</td>
<td><p>TPM_RH_OWNER or TPM_RH_PLATFORM+{PP}</p>
<p>Auth Handle: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="odd">
<td>TPM_CLOCK_ADJUST</td>
<td>rateAdjust</td>
<td>Adjustment to current <em>Clock</em> update rate</td>
</tr>
</tbody>
</table>

Table 211 — TPM2_ClockRateAdjust Response

| Type   | Name         | Description  |
|--------|--------------|--------------|
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[ClockRateAdjust\]\]

# Capability Commands

## Introduction

The TPM has numerous values that indicate the state, capabilities, and
properties of the TPM. These values are needed for proper management of
the TPM. The TPM2_GetCapability() command is used to access these
values.

TPM2_GetCapability() allows reporting of multiple values in a single
call. The values are grouped according to type.

NOTE TPM2_TestParms()is used to determine if a TPM supports a particular
combination of algorithm parameters

## TPM2_GetCapability

### General Description

This command returns various information regarding the TPM and its
current state.

The *capability* parameter determines the category of data returned. The
*property* parameter selects the first value of the selected category to
be returned. If there is no property that corresponds to the value of
*property*, the next higher value is returned, if it exists.

EXAMPLE 1 The list of handles of transient objects currently loaded in
the TPM may be read one at a time. On the first read, set the property
to TRANSIENT_FIRST and *propertyCount* to one. If a transient object is
present, the lowest numbered handle is returned and *moreData* will be
YES if transient objects with higher handles are loaded. On the
subsequent call, use returned handle value plus 1 in order to access the
next higher handle.

The *propertyCount* parameter indicates the number of capabilities in
the indicated group that are requested. The TPM will return no more than
the number of requested values (*propertyCount*) or until the last
property of the requested type has been returned.

NOTE 1 The type of the capability is derived from a combination of
*capability* and *property*.

NOTE 2 If the *property* selects an unimplemented property, the next
higher implemented property is returned.

When all of the properties of the requested type have been returned, the
*moreData* parameter in the response will be set to NO. Otherwise, it
will be set to YES.

NOTE 3 The *moreData* parameter will be YES if there are more properties
even if the requested number of capabilities has been returned.

The TPM is not required to return more than one value at a time. It is
not required to provide the same number of values in response to
subsequent requests.

EXAMPLE 2 A TPM may return 4 properties in response to a
TPM2_GetCapability(*capability* = TPM_CAP_TPM_PROPERTY, *property* =
TPM_PT_MANUFACTURER, *propertyCount* = 8 ) and for a latter request with
the same parameters, the TPM may return as few as one and as many as 8
values.

When the TPM is in Failure mode, a TPM is required to allow use of this
command for access of the following capabilities:

- TPM_PT_MANUFACTURER

- TPM_PT_VENDOR_STRING_1

- TPM_PT_VENDOR_STRING_2 <sup>(NOTE 4)</sup>

- TPM_PT_VENDOR_STRING_3 <sup>(NOTE 4)</sup>

- TPM_PT_VENDOR_STRING_4 <sup>(NOTE 4)</sup>

- TPM_PT_VENDOR_TPM_TYPE

- TPM_PT_FIRMWARE_VERSION_1

- TPM_PT_FIRMWARE_VERSION_2

NOTE 4 If the vendor string does not require one of these values, the
property type does not need to exist.

A vendor may optionally allow the TPM to return other values.

If in Failure mode and a capability is requested that is not available
in Failure mode, the TPM shall return no value.

EXAMPLE 3 Assume the TPM is in Failure mode and the TPM only supports
reporting of the minimum required set of properties (the limited subset
of TPML_TAGGED_TPM_PROPERTY values). If a TPM2_GetCapability is received
requesting a capability that has a property type value greater than
TPM_PT_FIRMWARE_VERSION_2, the TPM may return a zero length list with
the moreData parameter set to NO or return the property
TPM_PT_FIRMWARE_VERSION_2. If the property type is less than
TPM_PT_MANUFACTURER, the TPM will return properties beginning with
TPM_PT_MANUFACTURER.

In Failure mode, *tag* is required to be TPM_ST_NO_SESSIONS or the TPM
shall return TPM_RC_FAILURE.

The capability categories and the types of the return values are:

<table>
<colgroup>
<col style="width: 33%" />
<col style="width: 23%" />
<col style="width: 42%" />
</colgroup>
<tbody>
<tr class="odd">
<td><em>capability</em></td>
<td><em>property</em></td>
<td>Return Type</td>
</tr>
<tr class="even">
<td>TPM_CAP_ALGS</td>
<td>TPM_ALG_ID<sup>(1)</sup></td>
<td>TPML_ALG_PROPERTY</td>
</tr>
<tr class="odd">
<td>TPM_CAP_HANDLES</td>
<td>TPM_HANDLE</td>
<td>TPML_HANDLE</td>
</tr>
<tr class="even">
<td>TPM_CAP_COMMANDS</td>
<td>TPM_CC</td>
<td>TPML_CCA</td>
</tr>
<tr class="odd">
<td>TPM_CAP_PP_COMMANDS</td>
<td>TPM_CC</td>
<td>TPML_CC</td>
</tr>
<tr class="even">
<td>TPM_CAP_AUDIT_COMMANDS</td>
<td>TPM_CC</td>
<td>TPML_CC</td>
</tr>
<tr class="odd">
<td>TPM_CAP_PCRS</td>
<td>Reserved</td>
<td>TPML_PCR_SELECTION</td>
</tr>
<tr class="even">
<td>TPM_CAP_TPM_PROPERTIES</td>
<td>TPM_PT</td>
<td>TPML_TAGGED_TPM_PROPERTY</td>
</tr>
<tr class="odd">
<td>TPM_CAP_PCR_PROPERTIES</td>
<td>TPM_PT_PCR</td>
<td>TPML_TAGGED_PCR_PROPERTY</td>
</tr>
<tr class="even">
<td>TPM_CAP_ECC_CURVES</td>
<td>TPM_ECC_CURVE<sup>(1)</sup></td>
<td>TPML_ECC_CURVE</td>
</tr>
<tr class="odd">
<td>TPM_CAP_AUTH_POLICIES <sup>(3)</sup></td>
<td>TPM_HANDLE<sup>(2)</sup></td>
<td>TPML_TAGGED_POLICY</td>
</tr>
<tr class="even">
<td>TPM_CAP_ACT<sup>(4)</sup></td>
<td>TPM_HANDLE<sup>(2)</sup></td>
<td>TPML_ACT_DATA</td>
</tr>
<tr class="odd">
<td>TPM_CAP_VENDOR_PROPERTY</td>
<td>manufacturer specific</td>
<td>manufacturer-specific values</td>
</tr>
<tr class="even">
<td colspan="3"><p>NOTES:</p>
<p>(1) The TPM_ALG_ID or TPM_ECC_CURVE is cast to a UINT32</p>
<p>(2) The TPM will return TPM_RC_VALUE if the handle does not reference
the range for permanent handles.</p>
<p>(3) TPM_CAP_AUTH_POLICIES was added in revision 01.32.</p>
<p>(4) TPM_CAP_ACT was added in revision 01.56.</p></td>
</tr>
</tbody>
</table>

- TPM_CAP_ALGS – Returns a list of TPMS_ALG_PROPERTIES. Each entry is an
  algorithm ID and a set of properties of the algorithm.

- TPM_CAP_HANDLES – Returns a list of all of the handles within the
  handle range of the *property* parameter. The range of the returned
  handles is determined by the handle type (the most-significant octet
  (MSO) of the *property)*. Any of the defined handle types is allowed

> EXAMPLE 4 If the MSO of *property* is TPM_HT_NV_INDEX, then the TPM
> will return a list of NV Index values.
>
> EXAMPLE 5 If the MSO of property is TPM_HT_PCR, then the TPM will
> return a list of PCR.

- For this capability, use of TPM_HT_LOADED_SESSION and
  TPM_HT_SAVED_SESSION is allowed. Requesting handles with a handle type
  of TPM_HT_LOADED_SESSION will return handles for loaded sessions. The
  returned handle values will have a handle type of either
  TPM_HT_HMAC_SESSION or TPM_HT_POLICY_SESSION. If saved sessions are
  requested, all returned values will have the TPM_HT_HMAC_SESSION
  handle type because the TPM does not track the session type of saved
  sessions.

> NOTE 5 TPM_HT_LOADED_SESSION and TPM_HT_HMAC_SESSION have the same
> value, as do TPM_HT_SAVED_SESSION and TPM_HT_POLICY_SESSION. It is not
> possible to request that the TPM return a list of loaded HMAC sessions
> without including the policy sessions.

- TPM_CAP_COMMANDS – Returns a list of the command attributes for all of
  the commands implemented in the TPM, starting with the TPM_CC
  indicated by the *property* parameter. If vendor specific commands are
  implemented, the vendor-specific command attribute with the lowest
  *commandIndex*, is returned after the non-vendor-specific (base)
  command.

> NOTE 6 The type of the property parameter is a TPM_CC while the type
> of the returned list is TPML_CCA.

- TPM_CAP_PP_COMMANDS – Returns a list of all of the commands currently
  requiring Physical Presence for confirmation of platform
  authorization. The list will start with the TPM_CC indicated by
  *property*.

- TPM_CAP_AUDIT_COMMANDS – Returns a list of all of the commands
  currently set for command audit.

- TPM_CAP_PCRS – Returns the current allocation of PCR in a
  TPML_PCR_SELECTION. The *property* parameter shall be zero. The TPM
  will always respond to this command with the full PCR allocation and
  *moreData* will be NO.

  The TPML_PCR_SELECTION must include a TPMS_PCR_SELECTION for each PCR
  bank in which there is at least one allocated PCR. The
  TPML_PCR_SELECTION may return a TPMS_PCR_SELECTION for each
  implemented PCR bank. The TPML_PCR_SELECTION may return a
  TPMS_PCR_SELECTION for each implemented hash algorithm.

- TPM_CAP_TPM_PROPERTIES – Returns a list of tagged properties. The tag
  is a TPM_PT and the property is a 32-bit value. The properties are
  returned in groups. Each property group is on a 256-value boundary
  (that is, the boundary occurs when the TPM_PT is evenly divisible by
  256). The TPM will only return values in the same group as the
  *property* parameter in the command.

- TPM_CAP_PCR_PROPERTIES – Returns a list of tagged PCR properties. The
  tag is a TPM_PT_PCR and the property is a TPMS_PCR_SELECT.

> The input command property is a TPM_PT_PCR (see TPM 2.0 Part 2 for PCR
> properties to be requested) that specifies the first property to be
> returned. If propertyCount is greater than 1, the list of properties
> begins with that property and proceeds in TPM_PT_PCR sequence.
>
> Each item in the list is a TPMS_PCR_SELECT structure that contains a
> bitmap of all PCR.
>
> NOTE 7 A PCR index in all banks (all hash algorithms) has the same
> properties, so the hash algorithm is not specified here.

- TPM_CAP_TPM_ECC_CURVES – Returns a list of ECC curve identifiers
  currently available for use in the TPM.

- TPM_CAP_AUTH_POLICIES - Returns a list of tagged policies reporting
  the authorization policies for the permanent handles.

- TPM_CAP_ACT – Returns a list of TPMS_ACT_DATA, each of which contains
  the handle for the ACT, the remaining time before it expires, and the
  ACT attributes.

The *moreData* parameter will have a value of YES if there are more
values of the requested type that were not returned.

If no next capability exists, the TPM will return a zero-length list and
*moreData* will have a value of NO.

### Command and Response

Table 212 — TPM2_GetCapability Command

|                     |               |                                                                               |
|---------------------|---------------|-------------------------------------------------------------------------------|
| Type                | Name          | Description                                                                   |
| TPMI_ST_COMMAND_TAG | tag           | TPM_ST_SESSIONS if an audit session is present; otherwise, TPM_ST_NO_SESSIONS |
| UINT32              | commandSize   |                                                                               |
| TPM_CC              | commandCode   | TPM_CC_GetCapability                                                          |
| TPM_CAP             | capability    | group selection; determines the format of the response                        |
| UINT32              | property      | further definition of information                                             |
| UINT32              | propertyCount | number of properties of the indicated type to return                          |

Table 213 — TPM2_GetCapability Response

|                      |                |                                                        |
|----------------------|----------------|--------------------------------------------------------|
| Type                 | Name           | Description                                            |
| TPM_ST               | tag            | see clause 6                                           |
| UINT32               | responseSize   |                                                        |
| TPM_RC               | responseCode   |                                                        |
| TPMI_YES_NO          | moreData       | flag to indicate if there are more values of this type |
| TPMS_CAPABILITY_DATA | capabilityData | the capability data                                    |

### Detailed Actions

\[\[GetCapability\]\]

## TPM2_TestParms

### General Description

This command is used to check to see if specific combinations of
algorithm parameters are supported.

The TPM will unmarshal the provided TPMT_PUBLIC_PARMS. If the parameters
unmarshal correctly, then the TPM will return TPM_RC_SUCCESS, indicating
that the parameters are valid for the TPM. The TPM will return the
appropriate unmarshaling error if a parameter is not valid.

### Command and Response

Table 214 — TPM2_TestParms Command

|                     |             |                                                                               |
|---------------------|-------------|-------------------------------------------------------------------------------|
| Type                | Name        | Description                                                                   |
| TPMI_ST_COMMAND_TAG | tag         | TPM_ST_SESSIONS if an audit session is present; otherwise, TPM_ST_NO_SESSIONS |
| UINT32              | commandSize |                                                                               |
| TPM_CC              | commandCode | TPM_CC_TestParms                                                              |
| TPMT_PUBLIC_PARMS   | parameters  | algorithm parameters to be validated                                          |

Table 215 — TPM2_TestParms Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode | TPM_RC       |

### Detailed Actions

\[\[TestParms\]\]

# Non-volatile Storage

## Introduction

The NV commands are used to create, update, read, and delete allocations
of space in NV memory. Before an Index may be used, it must be defined
(TPM2_NV_DefineSpace()).

An Index may be modified if the proper write authorization is provided
or read if the proper read authorization is provided. Different controls
are available for reading and writing.

An Index may have an Index-specific *authValue* and *authPolicy*. The
*authValue* may be used to authorize reading if TPMA_NV_AUTHREAD is SET
and writing if TPMA_NV_AUTHWRITE is SET. The *authPolicy* may be used to
authorize reading if TPMA_NV_POLICYREAD is SET and writing if
TPMA_NV_POLICYWRITE is SET.

For commands that have both *authHandle* and *nvIndex* parameters,
*authHandle* can be an NV Index, Platform Authorization, or Owner
Authorization. If *authHandle* is an NV Index, it must be the same as
*nvIndex* (TPM_RC_NV_AUTHORIZATION).

TPMA_NV_PPREAD and TPMA_NV_PPWRITE indicate if reading or writing of the
NV Index may be authorized by *platformAuth* or *platformPolicy*.

TPMA_NV_OWNERREAD and TPMA_NV_OWNERWRITE indicate if reading or writing
of the NV Index may be authorized by *ownerAuth* or *ownerPolicy*.

If an operation on an NV index requires authorization, and the
authHandle parameter is the handle of an NV Index, then the nvIndex
parameter must have the same value or the TPM will return
TPM_RC_NV_AUTHORIZATION.

NOTE 1 This check ensures that the authorization that was provided is
associated with the NV Index being authorized.

For creating an Index, Owner Authorization may not be used if *shEnable*
is CLEAR and Platform Authorization may not be used if *phEnableNV* is
CLEAR.

If an Index was defined using Platform Authorization, then that Index is
not accessible when *phEnableNV* is CLEAR. If an Index was defined using
Owner Authorization, then that Index is not accessible when *shEnable*
is CLEAR.

For read access control, any combination of TPMA_NV_PPREAD,
TPMA_NV_OWNERREAD, TPMA_NV_AUTHREAD, or TPMA_NV_POLICYREAD is allowed as
long as at least one is SET.

For write access control, any combination of TPMA_NV_PPWRITE,
TPMA_NV_OWNERWRITE, TPMA_NV_AUTHWRITE, or TPMA_NV_POLICYWRITE is allowed
as long as at least one is SET.

If an Index has been defined and not written, then any operation on the
NV Index that requires read authorization will fail
(TPM_RC_NV_INITIALIZED). This check may be made before or after other
authorization checks but shall be performed before checking the NV Index
*authValue*. An authorization failure due to the NV Index not having
been written shall not be logged by the dictionary attack logic.

If TPMA_NV_CLEAR_STCLEAR is SET, then the TPMA_NV_WRITTEN will be CLEAR
on each TPM2_Startup(TPM_SU_CLEAR). TPMA_NV_CLEAR_STCLEAR shall not be
SET if the *nvIndexType* is TPM_NT_COUNTER.

The code in the “Detailed Actions” clause of each command is written to
interface with an implementation-dependent library that allows access to
NV memory. The actions assume no specific layout of the structure of the
NV data.

Only one NV Index may be directly referenced in a command.

NOTE 2 This means that, if *authHandle* references an NV Index, then
*nvIndex* will have the same value. However, this does not limit the
number of changes that may occur as side effects. For example, any
number of NV Indexes might be relocated as a result of deleting or
adding a NV Index.

## NV Counters

When an Index has the TPM_NT_COUNTER attribute, it behaves as a
monotonic counter and may only be updated using TPM2_NV_Increment().

When an NV counter is created, the TPM shall initialize the 8-octet
counter value with a number that is greater than any count value for any
NV counter on the TPM since the time of TPM manufacture.

An NV counter may be defined with the TPMA_NV_ORDERLY attribute to
indicate that the NV Index is expected to be modified at a high
frequency and that the data is only required to persist when the TPM
goes through an orderly shutdown process. The TPM may update the counter
value in RAM and occasionally update the non-volatile version of the
counter. An orderly shutdown is one occasion to update the non-volatile
count. If the difference between the volatile and non-volatile version
of the counter becomes as large as MAX_ORDERLY_COUNT, this shall be
another occasion for updating the non-volatile count.

Before an NV counter can be used, the TPM shall validate that the count
is not less than a previously reported value. If the TPMA_NV_ORDERLY
attribute is not SET, or if the TPM experienced an orderly shutdown,
then the count is assumed to be correct. If the TPMA_NV_ORDERLY
attribute is SET, and the TPM shutdown was not orderly, then the TPM
shall OR MAX_ORDERLY_COUNT to the contents of the non-volatile counter
and set that as the current count.

NOTE 1 Because the TPM would have updated the NV Index if the difference
between the count values was equal to MAX_ORDERLY_COUNT + 1, the highest
value that could have been in the NV Index is MAX_ORDERLY_COUNT so it is
safe to restore that value.

NOTE 2 The TPM may implement the RAM portion of the counter such that
the effective value of the NV counter is the sum of both the volatile
and non-volatile parts. If so, then the TPM may initialize the RAM
version of the counter to MAX_ORDERLY_COUNT and no update of NV is
necessary.

NOTE 3 When a new NV counter is created, the TPM may search all the
counters to determine which has the highest value. In this search, the
TPM would use the sum of the non-volatile and RAM portions of the
counter. The RAM portion of the counter shall be properly initialized to
reflect shutdown process (orderly or not) of the TPM.

## TPM2_NV_DefineSpace

### General Description

This command defines the attributes of an NV Index and causes the TPM to
reserve space to hold the data associated with the NV Index. If a
definition already exists at the NV Index, the TPM will return
TPM_RC_NV_DEFINED.

The TPM will return TPM_RC_ATTRIBUTES if *nvIndexType* has a reserved
value in *publicInfo.*

NOTE 1 It is not required that any of these three attributes be set.

The TPM shall return TPM_RC_ATTRIBUTES if TPMA_NV_WRITTEN,
TPMA_NV_READLOCKED, or TPMA_NV_WRITELOCKED is SET.

If *nvIndexType* is TPM_NT_COUNTER, TPM_NT_BITS, TPM_NT_PIN_FAIL, or
TPM_NT_PIN_PASS, then *publicInfo→dataSize* shall be set to eight (8) or
the TPM shall return TPM_RC_SIZE.

If *nvIndexType* is TPM_NT_EXTEND, then *publicInfo→dataSize* shall
match the digest size of the *publicInfo.nameAlg* or the TPM shall
return TPM_RC_SIZE.

NOTE 2 TPM_RC_ATTRIBUTES could be returned by a TPM that is based on the
reference code of older versions of the specification but the correct
response for this error is TPM_RC_SIZE.

If the NV Index is an ordinary Index and *publicInfo→dataSize* is larger
than supported by the TPM implementation then the TPM shall return
TPM_RC_SIZE.

NOTE 3 The limit for the data size may vary according to the type of the
index. For example, if the index has TPMA_NV_ORDERLY SET, then the
maximum size of an ordinary NV Index may be less than the size of an
ordinary NV Index that has TPMA_NV_ORDERLY CLEAR.

At least one of TPMA_NV_PPREAD, TPMA_NV_OWNERREAD, TPMA_NV_AUTHREAD, or
TPMA_NV_POLICYREAD shall be SET or the TPM shall return
TPM_RC_ATTRIBUTES.

At least one of TPMA_NV_PPWRITE, TPMA_NV_OWNERWRITE, TPMA_NV_AUTHWRITE,
or TPMA_NV_POLICYWRITE shall be SET or the TPM shall return
TPM_RC_ATTRIBUTES.

If TPMA_NV_CLEAR_STCLEAR is SET, then *nvIndexType* shall not be
TPM_NT_COUNTER or the TPM shall return TPM_RC_ATTRIBUTES.

If *platformAuth/platformPolicy* is used for authorization, then
TPMA_NV_PLATFORMCREATE shall be SET in *publicInfo*. If
*ownerAuth/ownerPolicy* is used for authorization,
TPMA_NV_PLATFORMCREATE shall be CLEAR in *publicInfo.* If
TPMA_NV_PLATFORMCREATE is not set correctly for the authorization, the
TPM shall return TPM_RC_ATTRIBUTES.

If TPMA_NV_POLICY_DELETE is SET, then the authorization shall be with
Platform Authorization or the TPM shall return TPM_RC_ATTRIBUTES.

If *nvIndexType* is TPM_NT_PIN_FAIL, then TPMA_NV_NO_DA shall be SET.
Otherwise, the TPM shall return TPM_RC_ATTRIBUTES.

NOTE 4 The intent of a PIN Fail index is that its DA protection is on a
per-index basis, not based on the global DA protection. This avoids
conflict over which type of dictionary attack protection is in use.

If *nvIndexType* is TPM_NT_PIN_FAIL or TPM_NT_PIN_PASS, then at least
one of TPMA_NV_PPWRITE, TPMA_NV_OWNERWRITE, or TPMA_NV_POLICYWRITE shall
be SET or the TPM shall return TPM_RC_ATTRIBUTES. TPMA_NV_AUTHWRITE
shall be CLEAR. Otherwise, the TPM shall return TPM_RC_ATTRIBUTES.

NOTE 5 If TPMA_NV_AUTHWRITE was SET for a PIN Pass index, a user knowing
the authorization value could decrease pinCount or increase pinLimit,
defeating the purpose of a PIN Pass index. The requirement is also
enforced for a PIN Fail index for consistency.

If the implementation does not support TPM2_NV_Increment(), the TPM
shall return TPM_RC_ATTRIBUTES if *nvIndexType* is TPM_NT_COUNTER.

If the implementation does not support TPM2_NV_SetBits(), the TPM shall
return TPM_RC_ATTRIBUTES if *nvIndexType* is TPM_NT_BITS.

If the implementation does not support TPM2_NV_Extend(), the TPM shall
return TPM_RC_ATTRIBUTES if *nvIndexType* is TPM_NT_EXTEND.

If the implementation does not support TPM2_NV_UndefineSpaceSpecial(),
the TPM shall return TPM_RC_ATTRIBUTES if TPMA_NV_POLICY_DELETE is SET.

After the successful completion of this command, the NV Index exists but
TPMA_NV_WRITTEN will be CLEAR. Any access of the NV data will return
TPM_RC_NV_UNINITIALIZED.

In some implementations, an NV Index with the TPM_NT_COUNTER attribute
may require special TPM resources that provide higher endurance than
regular NV. For those implementations, if this command fails because of
lack of resources, the TPM will return TPM_RC_NV_SPACE.

The value of *auth* is saved in the created structure. The size of
*auth* is limited to be no larger than the size of the digest produced
by the NV Index's *nameAlg* (TPM_RC_SIZE).

### Command and Response

Table 216 — TPM2_NV_DefineSpace Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_NV_DefineSpace {NV}</td>
</tr>
<tr class="odd">
<td>TPMI_RH_PROVISION</td>
<td>@authHandle</td>
<td><p>TPM_RH_OWNER or TPM_RH_PLATFORM+{PP}</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPM2B_AUTH</td>
<td>auth</td>
<td>the authorization value</td>
</tr>
<tr class="odd">
<td>TPM2B_NV_PUBLIC</td>
<td>publicInfo</td>
<td>the public parameters of the NV area</td>
</tr>
</tbody>
</table>

Table 217 — TPM2_NV_DefineSpace Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[NV_DefineSpace\]\]

## TPM2_NV_UndefineSpace

### General Description

This command removes an Index from the TPM.

If *nvIndex* is not defined, the TPM shall return TPM_RC_HANDLE.

If *nvIndex* references an Index that has its TPMA_NV_PLATFORMCREATE
attribute SET, the TPM shall return TPM_RC_NV_AUTHORIZATION unless
Platform Authorization is provided.

If *nvIndex* references an Index that has its TPMA_NV_POLICY_DELETE
attribute SET, the TPM shall return TPM_RC_ATTRIBUTES.

NOTE An Index with TPMA_NV_PLATFORMCREATE CLEAR may be deleted with
Platform Authorization as long as shEnable is SET. If shEnable is CLEAR,
indexes created using Owner Authorization are not accessible even for
deletion by the platform.

### Command and Response

Table 218 — TPM2_NV_UndefineSpace Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_NV_UndefineSpace {NV}</td>
</tr>
<tr class="odd">
<td>TPMI_RH_PROVISION</td>
<td>@authHandle</td>
<td><p>TPM_RH_OWNER or TPM_RH_PLATFORM+{PP}</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPMI_RH_NV_INDEX</td>
<td>nvIndex</td>
<td><p>the NV Index to remove from NV space</p>
<p>Auth Index: None</p></td>
</tr>
</tbody>
</table>

Table 219 — TPM2_NV_UndefineSpace Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[NV_UndefineSpace\]\]

## TPM2_NV_UndefineSpaceSpecial

### General Description

This command allows removal of a platform-created NV Index that has
TPMA_NV_POLICY_DELETE SET.

This command requires that the policy of the NV Index be satisfied
before the NV Index may be deleted. Because administrative role is
required, the policy must contain a command that sets the policy command
code to TPM_CC_NV_UndefineSpaceSpecial. This indicates that the policy
that is being used is a policy that is for this command, and not a
policy that would approve another use. That is, authority to use an
entity does not grant authority to undefine the entity.

Since the index is deleted, the Empty Buffer is used as the authValue
when generating the response HMAC.

If *nvIndex* is not defined, the TPM shall return TPM_RC_HANDLE.

If *nvIndex* references an Index that has its TPMA_NV_PLATFORMCREATE or
TPMA_NV_POLICY_DELETE attribute CLEAR, the TPM shall return
TPM_RC_ATTRIBUTES.

NOTE An Index with TPMA_NV_PLATFORMCREATE CLEAR may be deleted with
TPM2_UndefineSpace()as long as shEnable is SET. If shEnable is CLEAR,
indexes created using Owner Authorization are not accessible even for
deletion by the platform.

### Command and Response

Table 220 — TPM2_NV_UndefineSpaceSpecial Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_NV_UndefineSpaceSpecial {NV}</td>
</tr>
<tr class="odd">
<td>TPMI_RH_NV_INDEX</td>
<td>@nvIndex</td>
<td><p>Index to be deleted</p>
<p>Auth Index: 1</p>
<p>Auth Role: ADMIN</p></td>
</tr>
<tr class="even">
<td>TPMI_RH_PLATFORM</td>
<td>@platform</td>
<td><p>TPM_RH_PLATFORM + {PP}</p>
<p>Auth Index: 2</p>
<p>Auth Role: USER</p></td>
</tr>
</tbody>
</table>

Table 221 — TPM2_NV_UndefineSpaceSpecial Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[NV_UndefineSpaceSpecial\]\]

## TPM2_NV_ReadPublic

### General Description

This command is used to read the public area and Name of an NV Index.
The public area of an Index is not privacy-sensitive and no
authorization is required to read this data.

### Command and Response

Table 222 — TPM2_NV_ReadPublic Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS if an audit or encrypt session is present;
otherwise, TPM_ST_NO_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_NV_ReadPublic</td>
</tr>
<tr class="odd">
<td>TPMI_RH_NV_INDEX</td>
<td>nvIndex</td>
<td><p>the NV Index</p>
<p>Auth Index: None</p></td>
</tr>
</tbody>
</table>

Table 223 — TPM2_NV_ReadPublic Response

|                 |              |                                 |
|-----------------|--------------|---------------------------------|
| Type            | Name         | Description                     |
| TPM_ST          | tag          | see clause 6                    |
| UINT32          | responseSize |                                 |
| TPM_RC          | responseCode |                                 |
| TPM2B_NV_PUBLIC | nvPublic     | the public area of the NV Index |
| TPM2B_NAME      | nvName       | the Name of the *nvIndex*       |

### Detailed Actions

\[\[NV_ReadPublic\]\]

## TPM2_NV_Write

### General Description

This command writes a value to an area in NV memory that was previously
defined by TPM2_NV_DefineSpace().

Proper authorizations are required for this command as determined by
TPMA_NV_PPWRITE; TPMA_NV_OWNERWRITE; TPMA_NV_AUTHWRITE; and, if
TPMA_NV_POLICY_WRITE is SET, the *authPolicy* of the NV Index.

If the TPMA_NV_WRITELOCKED attribute of the NV Index is SET, then the
TPM shall return TPM_RC_NV_LOCKED.

NOTE 1 If authorization sessions are present, they are checked before
checks to see if writes to the NV Index are locked.

If *nvIndexType* is TPM_NT_COUNTER, TPM_NT_BITS or TPM_NT_EXTEND, then
the TPM shall return TPM_RC_ATTRIBUTES.

If *offset* and the *size* field of *data* add to a value that is
greater than the *dataSize* field of the NV Index referenced by
*nvIndex*, the TPM shall return an error (TPM_RC_NV_RANGE). The
implementation may return an error (TPM_RC_VALUE) if it performs an
additional check and determines that *offset* is greater than the
*dataSize* field of the NV Index.

If the TPMA_NV_WRITEALL attribute of the NV Index is SET, then the TPM
shall return TPM_RC_NV_RANGE if the size of the *data* parameter of the
command is not the same as the *data* field of the NV Index.

If all checks succeed, the TPM will merge the *data.size* octets of
*data.buffer* value into the *nvIndex→data* starting at
*nvIndex→data\[offset\].* If the NV memory is implemented with a
technology that has endurance limitations, the TPM shall check that the
merged data is different from the current contents of the NV Index and
only perform a write to NV memory if they differ.

After successful completion of this command, TPMA_NV_WRITTEN for the NV
Index will be SET.

NOTE 2 Once SET, TPMA_NV_WRITTEN remains SET until the NV Index is
undefined or the NV Index is cleared.

### Command and Response

Table 224 — TPM2_NV_Write Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_NV_Write {NV}</td>
</tr>
<tr class="odd">
<td>TPMI_RH_NV_AUTH</td>
<td>@authHandle</td>
<td><p>handle indicating the source of the authorization value</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPMI_RH_NV_INDEX</td>
<td>nvIndex</td>
<td><p>the NV Index of the area to write</p>
<p>Auth Index: None</p></td>
</tr>
<tr class="odd">
<td>TPM2B_MAX_NV_BUFFER</td>
<td>data</td>
<td>the data to write</td>
</tr>
<tr class="even">
<td>UINT16</td>
<td>offset</td>
<td>the octet offset into the NV Area</td>
</tr>
</tbody>
</table>

Table 225 — TPM2_NV_Write Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[NV_Write\]\]

## TPM2_NV_Increment

### General Description

This command is used to increment the value in an NV Index that has the
TPM_NT_COUNTER attribute. The data value of the NV Index is incremented
by one.

NOTE 1 The NV Index counter is an unsigned value.

If *nvIndexType* is not TPM_NT_COUNTER in the indicated NV Index, the
TPM shall return TPM_RC_ATTRIBUTES.

If TPMA_NV_WRITELOCKED is SET, the TPM shall return TPM_RC_NV_LOCKED.

If TPMA_NV_WRITTEN is CLEAR, it will be SET.

If TPMA_NV_ORDERLY is SET, and the difference between the volatile and
non-volatile versions of this field is greater than MAX_ORDERLY_COUNT,
then the non-volatile version of the counter is updated.

NOTE 2 If a TPM implements TPMA_NV_ORDERLY and an Index is defined with
TPMA_NV_ORDERLY and TPM_NT_COUNTER both SET, then in the Event of a
non-orderly shutdown, the non-volatile value for the counter Index will
be advanced by MAX_ORDERLY_COUNT at the next TPM2_Startup().

NOTE 3 An allowed implementation would keep a counter value in NV and a
resettable counter in RAM. The reported value of the NV Index would be
the sum of the two values. When the RAM count increments past the
maximum allowed value (MAX_ORDERLY_COUNT), the non-volatile version of
the count is updated with the sum of the values and the RAM count is
reset to zero.

### Command and Response

Table 226 — TPM2_NV_Increment Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_NV_Increment {NV}</td>
</tr>
<tr class="odd">
<td>TPMI_RH_NV_AUTH</td>
<td>@authHandle</td>
<td><p>handle indicating the source of the authorization value</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPMI_RH_NV_INDEX</td>
<td>nvIndex</td>
<td><p>the NV Index to increment</p>
<p>Auth Index: None</p></td>
</tr>
</tbody>
</table>

Table 227 — TPM2_NV_Increment Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[NV_Increment\]\]

## TPM2_NV_Extend

### General Description

This command extends a value to an area in NV memory that was previously
defined by TPM2_NV_DefineSpace.

If *nvIndexType* is not TPM_NT_EXTEND, then the TPM shall return
TPM_RC_ATTRIBUTES.

Proper write authorizations are required for this command as determined
by TPMA_NV_PPWRITE, TPMA_NV_OWNERWRITE, TPMA_NV_AUTHWRITE, and the
*authPolicy* of the NV Index.

After successful completion of this command, TPMA_NV_WRITTEN for the NV
Index will be SET.

NOTE 1 Once SET, TPMA_NV_WRITTEN remains SET until the NV Index is
undefined, unless the TPMA_NV_CLEAR_STCLEAR attribute is SET and a TPM
Reset or TPM Restart occurs.

If the TPMA_NV_WRITELOCKED attribute of the NV Index is SET, then the
TPM shall return TPM_RC_NV_LOCKED.

NOTE 2 If authorization sessions are present, they are checked before
checks to see if writes to the NV Index are locked.

The *data*.*buffer* parameter may be larger than the defined size of the
NV Index.

The Index will be updated by:

nvIndex→data<sub>new</sub> ≔
**H**<sub>nameAkg</sub>(nvIndex→data<sub>old</sub> \|\| data.buffer) 1

where

nvIndex→data<sub>new</sub> the value of the data field in the NV Index
after the command returns

**H**<sub>nameAkg</sub>() the hash algorithm indicated in
nvIndex→nameAlg

> *nvIndex→data<sub>old</sub>* the value of the data field in the NV
> Index before the command is called

*data.buffer* the data buffer of the command parameter

NOTE 3 If TPMA_NV_WRITTEN is CLEAR, then *nvIndex→data<sub>old</sub>* is
a Zero Digest.

### Command and Response

Table 228 — TPM2_NV_Extend Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_NV_Extend {NV}</td>
</tr>
<tr class="odd">
<td>TPMI_RH_NV_AUTH</td>
<td>@authHandle</td>
<td><p>handle indicating the source of the authorization value</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPMI_RH_NV_INDEX</td>
<td>nvIndex</td>
<td><p>the NV Index to extend</p>
<p>Auth Index: None</p></td>
</tr>
<tr class="odd">
<td>TPM2B_MAX_NV_BUFFER</td>
<td>data</td>
<td>the data to extend</td>
</tr>
</tbody>
</table>

Table 229 — TPM2_NV_Extend Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[NV_Extend\]\]

## TPM2_NV_SetBits

### General Description

This command is used to SET bits in an NV Index that was created as a
bit field. Any number of bits from 0 to 64 may be SET. The contents of
*bits* are ORed with the current contents of the NV Index.

If TPMA_NV_WRITTEN is not SET, then, for the purposes of this command,
the NV Index is considered to contain all zero bits and *data* is ORed
with that value.

If TPM_NT_BITS is not SET, then the TPM shall return TPM_RC_ATTRIBUTES.

After successful completion of this command, TPMA_NV_WRITTEN for the NV
Index will be SET.

NOTE TPMA_NV_WRITTEN will be SET even if no bits were SET.

### Command and Response

Table 230 — TPM2_NV_SetBits Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_NV_SetBits {NV}</td>
</tr>
<tr class="odd">
<td>TPMI_RH_NV_AUTH</td>
<td>@authHandle</td>
<td><p>handle indicating the source of the authorization value</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPMI_RH_NV_INDEX</td>
<td>nvIndex</td>
<td><p>NV Index of the area in which the bit is to be set</p>
<p>Auth Index: None</p></td>
</tr>
<tr class="odd">
<td>UINT64</td>
<td>bits</td>
<td>the data to OR with the current contents</td>
</tr>
</tbody>
</table>

Table 231 — TPM2_NV_SetBits Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[NV_SetBits\]\]

## TPM2_NV_WriteLock

### General Description

If the TPMA_NV_WRITEDEFINE or TPMA_NV_WRITE_STCLEAR attributes of an NV
location are SET, then this command may be used to inhibit further
writes of the NV Index.

Proper write authorization is required for this command as determined by
TPMA_NV_PPWRITE, TPMA_NV_OWNERWRITE, TPMA_NV_AUTHWRITE, and the
*authPolicy* of the NV Index.

It is not an error if TPMA_NV_WRITELOCKED for the NV Index is already
SET.

If neither TPMA_NV_WRITEDEFINE nor TPMA_NV_WRITE_STCLEAR of the NV Index
is SET, then the TPM shall return TPM_RC_ATTRIBUTES.

If the command is properly authorized and TPMA_NV_WRITE_STCLEAR or
TPMA_NV_WRITEDEFINE is SET, then the TPM shall SET TPMA_NV_WRITELOCKED
for the NV Index. TPMA_NV_WRITELOCKED will be clear on the next
TPM2_Startup(TPM_SU_CLEAR) if either TPMA_NV_WRITEDEFINE is CLEAR or
TPMA_NV_WRITTEN is CLEAR.

### Command and Response

Table 232 — TPM2_NV_WriteLock Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_NV_WriteLock {NV}</td>
</tr>
<tr class="odd">
<td>TPMI_RH_NV_AUTH</td>
<td>@authHandle</td>
<td><p>handle indicating the source of the authorization value</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPMI_RH_NV_INDEX</td>
<td>nvIndex</td>
<td><p>the NV Index of the area to lock</p>
<p>Auth Index: None</p></td>
</tr>
</tbody>
</table>

Table 233 — TPM2_NV_WriteLock Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[NV_WriteLock\]\]

## TPM2_NV_GlobalWriteLock

### General Description

The command will SET TPMA_NV_WRITELOCKED for all indexes that have their
TPMA_NV_GLOBALLOCK attribute SET.

If an Index has both TPMA_NV_GLOBALLOCK and TPMA_NV_WRITEDEFINE SET,
then this command will permanently lock the NV Index for writing unless
TPMA_NV_WRITTEN is CLEAR.

NOTE If an Index is defined with TPMA_NV_GLOBALLOCK SET, then the global
lock does not apply until the next time this command is executed.

This command requires either platformAuth/platformPolicy or
ownerAuth/ownerPolicy.

### Command and Response

Table 234 — TPM2_NV_GlobalWriteLock Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_NV_GlobalWriteLock {NV}</td>
</tr>
<tr class="odd">
<td>TPMI_RH_PROVISION</td>
<td>@authHandle</td>
<td><p>TPM_RH_OWNER or TPM_RH_PLATFORM+{PP}</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
</tbody>
</table>

Table 235 — TPM2_NV_GlobalWriteLock Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[NV_GlobalWriteLock\]\]

## TPM2_NV_Read

### General Description

This command reads a value from an area in NV memory previously defined
by TPM2_NV_DefineSpace().

Proper authorizations are required for this command as determined by
TPMA_NV_PPREAD, TPMA_NV_OWNERREAD, TPMA_NV_AUTHREAD, and the
*authPolicy* of the NV Index.

If TPMA_NV_READLOCKED of the NV Index is SET, then the TPM shall return
TPM_RC_NV_LOCKED.

If *offset* and the *size* field of *data* add to a value that is
greater than the *dataSize* field of the NV Index referenced by
*nvIndex*, the TPM shall return an error (TPM_RC_NV_RANGE). The
implementation may return an error (TPM_RC_VALUE) if it performs an
additional check and determines that *offset* is greater than the
*dataSize* field of the NV Index.

For an NV Index with the TPM_NT_COUNTER or TPM_NT_BITS attribute SET,
the TPM may ignore the *offset* parameter and use an offset of 0.
Therefore, it is recommended that the caller set the *offset* parameter
to 0 for interoperability.

NOTE 1 If authorization sessions are present, they are checked before
the read-lock status of the NV Index is checked.

If the NV Index has been defined but the TPMA_NV_WRITTEN attribute is
CLEAR, then this command shall return TPM_RC_NV_UNINITIALIZED even if
*size* is zero.

The *data* parameter in the response may be encrypted using parameter
encryption.

### Command and Response

Table 236 — TPM2_NV_Read Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_NV_Read</td>
</tr>
<tr class="odd">
<td>TPMI_RH_NV_AUTH</td>
<td>@authHandle</td>
<td><p>the handle indicating the source of the authorization value</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPMI_RH_NV_INDEX</td>
<td>nvIndex</td>
<td><p>the NV Index to be read</p>
<p>Auth Index: None</p></td>
</tr>
<tr class="odd">
<td>UINT16</td>
<td>size</td>
<td>number of octets to read</td>
</tr>
<tr class="even">
<td>UINT16</td>
<td>offset</td>
<td><p>octet offset into the NV area</p>
<p>This value shall be less than or equal to the size of the
<em>nvIndex</em> data.</p></td>
</tr>
</tbody>
</table>

Table 237 — TPM2_NV_Read Response

|                     |              |               |
|---------------------|--------------|---------------|
| Type                | Name         | Description   |
| TPM_ST              | tag          | see clause 6  |
| UINT32              | responseSize |               |
| TPM_RC              | responseCode |               |
| TPM2B_MAX_NV_BUFFER | data         | the data read |

### Detailed Actions

\[\[NV_Read\]\]

## TPM2_NV_ReadLock

### General Description

If TPMA_NV_READ_STCLEAR is SET in an Index, then this command may be
used to prevent further reads of the NV Index until the next
TPM2_Startup (TPM_SU_CLEAR).

Proper authorizations are required for this command as determined by
TPMA_NV_PPREAD, TPMA_NV_OWNERREAD, TPMA_NV_AUTHREAD, and the
*authPolicy* of the NV Index.

NOTE Only an entity that may read an Index is allowed to lock the NV
Index for read.

If the command is properly authorized and TPMA_NV_READ_STCLEAR of the NV
Index is SET, then the TPM shall SET TPMA_NV_READLOCKED for the NV
Index. If TPMA_NV_READ_STCLEAR of the NV Index is CLEAR, then the TPM
shall return TPM_RC_ATTRIBUTES. TPMA_NV_READLOCKED will be CLEAR by the
next TPM2_Startup(TPM_SU_CLEAR).

It is not an error to use this command for an Index that is already
locked for reading.

An Index that had not been written may be locked for reading.

### Command and Response

Table 238 — TPM2_NV_ReadLock Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_NV_ReadLock {NV}</td>
</tr>
<tr class="odd">
<td>TPMI_RH_NV_AUTH</td>
<td>@authHandle</td>
<td><p>the handle indicating the source of the authorization value</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPMI_RH_NV_INDEX</td>
<td>nvIndex</td>
<td><p>the NV Index to be locked</p>
<p>Auth Index: None</p></td>
</tr>
</tbody>
</table>

Table 239 — TPM2_NV_ReadLock Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[NV_ReadLock\]\]

## TPM2_NV_ChangeAuth

### General Description

This command allows the authorization secret for an NV Index to be
changed.

If successful, the authorization secret (*authValue*) of the NV Index
associated with *nvIndex* is changed.

This command requires that a policy session be used for authorization of
*nvIndex* so that the ADMIN role may be asserted and that *commandCode*
in the policy session context shall be TPM_CC_NV_ChangeAuth. That is,
the policy must contain a specific authorization for changing the
authorization value of the referenced entity.

NOTE The reason for this restriction is to ensure that the
administrative actions on *nvIndex* require explicit approval while
other commands may use policy that is not command-dependent.

The size of the *newAuth* value may be no larger than the size of the
digest produced by the *nameAlg* of the NV Index.

Since the NV Index authorization is changed before the response HMAC is
calculated, the newAuth value is used when generating the response HMAC
key if required. See TPM 2.0 Part 4 ComputeResponseHMAC().

### Command and Response

Table 240 — TPM2_NV_ChangeAuth Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_NV_ChangeAuth {NV}</td>
</tr>
<tr class="odd">
<td>TPMI_RH_NV_INDEX</td>
<td>@nvIndex</td>
<td><p>handle of the entity</p>
<p>Auth Index: 1</p>
<p>Auth Role: ADMIN</p></td>
</tr>
<tr class="even">
<td>TPM2B_AUTH</td>
<td>newAuth</td>
<td>new authorization value</td>
</tr>
</tbody>
</table>

Table 241 — TPM2_NV_ChangeAuth Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[NV_ChangeAuth\]\]

## TPM2_NV_Certify

### General Description

The purpose of this command is to certify the contents of an NV Index or
portion of an NV Index.

If the *sign* attribute is not SET in the key referenced by *signHandle*
then the TPM shall return TPM_RC_KEY.

If the NV Index has been defined but the TPMA_NV_WRITTEN attribute is
CLEAR, then this command shall return TPM_RC_NV_UNINITIALIZED even if
*size* is zero.

If proper authorization for reading the NV Index is provided, the
portion of the NV Index selected by *size* and *offset* are included in
an attestation block and signed using the key indicated by *signHandle*.
The attestation includes *size* and *offset* so that the range of the
data can be determined. It also includes the NV index Name.

For an NV Index with the TPM_NT_COUNTER or TPM_NT_BITS attribute SET,
the TPM may ignore the *offset* parameter and use an offset of 0.
Therefore, it is recommended that the caller set the *offset* parameter
to 0 for interoperability.

If *offset* and *size* add to a value that is greater than the
*dataSize* field of the NV Index referenced by *nvIndex*, the TPM shall
return an error (TPM_RC_NV_RANGE). The implementation may return an
error (TPM_RC_VALUE) if it performs an additional check and determines
that *offset* is greater than the *dataSize* field of the NV Index, or
if *size* is greater than MAX_NV_BUFFER_SIZE.

NOTE 1 See 18.1 for description of how the signing scheme is selected.

NOTE 2 If *signHandle* is TPM_RH_NULL, the TPMS_ATTEST structure is
returned and *signature* is a NULL Signature.

If *size* and *offset* are both zero (0), then *certifyInfo* in the
response will contain a TPMS_NV_DIGEST_CERTIFY_INFO, otherwise, it will
contain a TPMS_NV_CERTIFY_INFO. The digest in the
TPMS_NV_DIGEST_CERTIFY_INFO is created using the digest of the selected
signing scheme.

NOTE 3 TPMS_NV_DIGEST_CERTIFY_INFO was added in revision 01.53. It
permits TPM2_NV_Certify() to certify NV Index contents that are larger
than MAX_NV_BUFFER_SIZE.

### Command and Response

Table 242 — TPM2_NV_Certify Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_NV_Certify</td>
</tr>
<tr class="odd">
<td>TPMI_DH_OBJECT+</td>
<td>@signHandle</td>
<td><p>handle of the key used to sign the attestation structure</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>TPMI_RH_NV_AUTH</td>
<td>@authHandle</td>
<td><p>handle indicating the source of the authorization value for the
NV Index</p>
<p>Auth Index: 2</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="odd">
<td>TPMI_RH_NV_INDEX</td>
<td>nvIndex</td>
<td><p>Index for the area to be certified</p>
<p>Auth Index: None</p></td>
</tr>
<tr class="even">
<td>TPM2B_DATA</td>
<td>qualifyingData</td>
<td>user-provided qualifying data</td>
</tr>
<tr class="odd">
<td>TPMT_SIG_SCHEME+</td>
<td>inScheme</td>
<td>signing scheme to use if the <em>scheme</em> for <em>signHandle</em>
is TPM_ALG_NULL</td>
</tr>
<tr class="even">
<td>UINT16</td>
<td>size</td>
<td>number of octets to certify</td>
</tr>
<tr class="odd">
<td>UINT16</td>
<td>offset</td>
<td><p>octet offset into the NV area</p>
<p>This value shall be less than or equal to the size of the
<em>nvIndex</em> data.</p></td>
</tr>
</tbody>
</table>

Table 243 — TPM2_NV_Certify Response

|                |              |                                                                                      |
|----------------|--------------|--------------------------------------------------------------------------------------|
| Type           | Name         | Description                                                                          |
| TPM_ST         | tag          | see clause 6                                                                         |
| UINT32         | responseSize |                                                                                      |
| TPM_RC         | responseCode | .                                                                                    |
| TPM2B_ATTEST   | certifyInfo  | the structure that was signed                                                        |
| TPMT_SIGNATURE | signature    | the asymmetric signature over *certifyInfo* using the key referenced by *signHandle* |

### Detailed Actions

\[\[NV_Certify\]\]

# Attached Components

## Introduction

This section contains commands that allow interaction with an Attached
Component (AC).

NOTE The Attached Component feature was added in revision 01.40.

## TPM2_AC_GetCapability

### General Description

The purpose of this command is to obtain information about an Attached
Component referenced by an AC handle.

The returned list contains 0 or more values starting at the first tagged
value that is equal to or greater than *capability*.

The list returned in *capabilitiesData* contains tagged values that
indicate the type of the value.

The TPM will return the lesser of a) the available values, b) the number
requested in *count,* or c) the number that will fit within the
available response buffer. If additional values with higher *capability*
numbers are available, *moreData* will be YES.

NOTE TPM2_AC_GetCapability() was added in revision 01.40.

### Command and Response

Table 244 — TPM2_AC_GetCapability Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS if an audit session is present; otherwise,
TPM_ST_NO_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_AC_GetCapability</td>
</tr>
<tr class="odd">
<td>TPMI_RH_AC</td>
<td>ac</td>
<td><p>handle indicating the Attached Component</p>
<p>Auth Index: None</p></td>
</tr>
<tr class="even">
<td>TPM_AT</td>
<td>capability</td>
<td>starting info type</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>count</td>
<td>maximum number of values to return</td>
</tr>
</tbody>
</table>

Table 245 — TPM2_AC_GetCapability Response

|                      |                  |                                                |
|----------------------|------------------|------------------------------------------------|
| Type                 | Name             | Description                                    |
| TPM_ST               | tag              | see clause 6                                   |
| UINT32               | responseSize     |                                                |
| TPM_RC               | responseCode     | .                                              |
| TPMI_YES_NO          | moreData         | flag to indicate whether there are more values |
| TPML_AC_CAPABILITIES | capabilitiesData | list of capabilities                           |

### Detailed Actions

\[\[AC_GetCapability\]\]

## TPM2_AC_Send

### General Description

The purpose of this command is to send (copy) a loaded object from the
TPM to an Attached Component.

The Object referenced by *sendObject* is required to have *fixedTpm,
fixedParent,* and *encryptedDuplication* attributes CLEAR
(TPM_RC_ATTRIBUTES). Authorization for *sendObject* is required to be a
policy session. The *policySession*→*commandCode* of the policy session
context is required to be TPM_CC_AC_Send (TPM_RC_POLICY_FAIL) to
demonstrate that the policy is specific for this command.

Authorization to send to the *ac* is provided by the session associated
with *authHandle*.

If an NV Alias is not defined for *ac,* then *authHandle* is required to
be either TPM_RH_OWNER or TPM_RH_PLATFORM (TPM_RC_HANDLE).

If an NV Alias is defined for *ac*, then the authorization for
*authHandle* is required to be compatible with the write authorization
attributes (TPMA_NV_PPWRITE, TPMA_NV_OWNERWRITE TPMA_NV_AUTHWRITE, and
TPMA_NV_POLICYWRITE) in the NV Alias (TPM_RC_NV_AUTHORIZATION).

NOTE 1 If authorization for *authHandle* is the handle of an NV Index,
then it is required to be the NV Alias value for *ac*
(TPM_RC_NV_AUTHORIZATION).

If authorization succeeds, the TPM will attempt to send *acDataIn* and
relevant portions of *sendObject* to the AC referenced by *ac*.

The TPM will return TPM_RC_SUCCESS if it succeeds in performing all the
required authorizations and validations. If problems occur in the
process of sending the object from the TPM to the AC, the response code
will be TPM_RC_SUCCESS with the AC-dependent error reported in
acDataOut.

NOTE 2 TPM2_AC_Send() was added in revision 01.40.

### Command and Response

Table 246 — TPM2_AC_Send Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>Tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_AC_Send</td>
</tr>
<tr class="odd">
<td>TPMI_DH_OBJECT</td>
<td>@sendObject</td>
<td><p>handle of the object being sent to ac</p>
<p>Auth Index: 1</p>
<p>Auth Role: DUP</p></td>
</tr>
<tr class="even">
<td>TPMI_RH_NV_AUTH</td>
<td>@authHandle</td>
<td><p>the handle indicating the source of the authorization value</p>
<p>Auth Index: 2</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="odd">
<td>TPMI_RH_AC</td>
<td>ac</td>
<td><p>handle indicating the Attached Component to which the object will
be sent</p>
<p>Auth Index: None</p></td>
</tr>
<tr class="even">
<td>TPM2B_MAX_BUFFER</td>
<td>acDataIn</td>
<td>Optional non sensitive information related to the object</td>
</tr>
</tbody>
</table>

Table 247 — TPM2_AC_Send Response

|                |              |                                                             |
|----------------|--------------|-------------------------------------------------------------|
| Type           | Name         | Description                                                 |
| TPM_ST         | Tag          | see clause 6                                                |
| UINT32         | responseSize |                                                             |
| TPM_RC         | responseCode |                                                             |
| TPMS_AC_OUTPUT | acDataOut    | May include AC specific data or information about an error. |

### Detailed Actions

\[\[AC_Send\]\]

## TPM2_Policy_AC_SendSelect

### General Description

This command allows qualification of the sending (copying) of an Object
to an Attached Component (AC). Qualification includes selection of the
receiving AC and the method of authentication for the AC, and, in
certain circumstances, the Object to be sent may be specified.

If this command is not used in conjunction with TPM2_PolicyAuthorize(),
then only the *authHandleName* and *acName* are selected and
*includeObject* should be CLEAR.

NOTE 1 In the absence of TPM2_PolicyAuthorize(), a policy session cannot
create a *policyDigest* that simultaneously equals the *authPolicy* in
an Object and names that Object. This is because the *authPolicy*
recorded in an Object is unable to include the Name of the Object as the
Name of an Object depends on the Object’s *authPolicy*.

NOTE 2 An object’s *authPolicy* can incorporate the use of
TPM2_PolicyAuthorize(). If the authorizing entity for the
TPM2_PolicyAuthorize() command specifies only the *ac* and the
*authHandle*, then the resultant *policyDigest* may be applied to the
sending of any number of Objects. If the authorizing entity for the
TPM2_PolicyAuthorize() specifies also the Name of the Object to be sent,
then the resultant *policyDigest* applies only to that specific Object.

> If either policySession→cpHash or policySession→nameHash has been
> previously set, the TPM shall return TPM_RC_CPHASH. Otherwise,
> policySession→nameHash will be set to:nameHash ≔
> **H**<sub>policyAlg</sub>(objectName \|\| authHandleName \|\| acName)
> 1

NOTE 3 A policy cannot specify both *cpHash* and *nameHash* because
*policySession*→*nameHash* and *policySession→cpHash* may share the same
memory space.

If the command succeeds, *policySession*→*policyDigest* will be updated
according to the setting of the input parameter *includeObject*. If
*includeObject* is SET, *policySession*→*policyDigest* is updated by:

policyDigest<sub>new</sub> ≔
**H**<sub>policyAlg</sub>(policyDigest<sub>old</sub> \|\|
TPM_CC_Policy_AC_SendSelect \|\|

objectName \|\| authHandleName \|\| acName \|\| includeObject) 1

but if includeObject is CLEAR, *policySession*→*policyDigest* is updated
by:

policyDigest<sub>new</sub> ≔
**H**<sub>policyAlg</sub>(policyDigest<sub>old</sub> \|\|
TPM_CC_Policy_AC_SendSelect \|\|

authHandleName \|\| acName \|\| includeObject) 1

NOTE 4 *policySession*→*nameHash* receives the digest of all Names so
that the check performed in TPM2_AC_Send() may be the same regardless of
which Names are included in *policySession*→*policyDigest*. This means
that, when TPM2_Policy_AC_SendSelect() is executed, it is only valid for
a specific triple of *objectName*, *authHandleName*, and *acName*.

If the command succeeds, *policySession*→*commandCode* is set to
TPM_CC_AC_Send.

NOTE 5 The normal use of TPM2_Policy_AC_SendSelect() is before a
TPM2_PolicyAuthorize(). An authorized entity would approve a
*policyDigest* that allows sending to a specific Attached Component. The
authorizing entity may want to limit the authorization so that the
approval allows only a specific Object to be sent to the Attached
Component. In that case, the authorizing entity would approve the
*policyDigest* of *equation* (44).

NOTE 6 TPM2_Policy_AC_SendSelect() was added in revision 01.40.

### Command and Response

Table 248 — TPM2_Policy_AC_SendSelect Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 0%" />
<col style="width: 21%" />
<col style="width: 0%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td colspan="2">Name</td>
<td colspan="2">Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td colspan="2">Tag</td>
<td colspan="2">TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td colspan="2">commandSize</td>
<td colspan="2"></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td colspan="2">commandCode</td>
<td colspan="2">TPM_CC_Policy_AC_SendSelect</td>
</tr>
<tr class="odd">
<td colspan="2">TPMI_SH_POLICY</td>
<td colspan="2">policySession</td>
<td><p>handle for the policy session being extended</p>
<p>Auth Index: None</p></td>
</tr>
<tr class="even">
<td colspan="2">TPM2B_NAME</td>
<td colspan="2">objectName</td>
<td>the Name of the Object to be sent</td>
</tr>
<tr class="odd">
<td colspan="2">TPM2B_NAME</td>
<td colspan="2">authHandleName</td>
<td>the Name associated with <em>authHandle</em> used in the
TPM2_AC_Send() command</td>
</tr>
<tr class="even">
<td colspan="2">TPM2B_NAME</td>
<td colspan="2">acName</td>
<td>the Name of the Attached Component to which the Object will be
sent</td>
</tr>
<tr class="odd">
<td colspan="2">TPMI_YES_NO</td>
<td colspan="2">includeObject</td>
<td>if SET, <em>objectName</em> will be included in the value in
<em>policySession</em>→<em>policyDigest</em></td>
</tr>
</tbody>
</table>

Table 249 — TPM2_Policy_AC_SendSelect Response

|        |              |              |
|--------|--------------|--------------|
| Type   | Name         | Description  |
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[Policy_AC_SendSelect\]\]

# Authenticated Countdown Timer

## Introduction

This section contains commands that allow interaction with an
Authenticated Countdown Timer (ACT).

NOTE The Authenticated Countdown Timer was added in revision 01.56.

## TPM2_ACT_SetTimeout

### General Description

This command is used to set the time remaining before an Authenticated
Countdown Timer (ACT) expires.

This command sets TPMS_ACT_DATA.*timeout* (ACT Timeout) to
*startTimeout*. The *startTimeout* value is an integer number of seconds
and may be zero. The *startTimeout* parameter may be greater, equal, or
less than the current value of ACT Timeout.

When ACT Timeout is non-zero, it will count down, once per second until
it reaches zero, at which time the *signaled* attribute of the TPMA_ACT
associated with *actHandle* is SET.

When ACT Timeout is zero and the *signaled* attribute is SET, writing a
*startTimeout* of FF FF FF FF<sub>16</sub> will clear *signaled* and
stop the counting.

There are four states for ACT Timeout and *startTimeout*. The *signaled*
attribute will be set as follows:

1\) If ACT Timeout is zero and *startTimeout* is non-zero, then
*signaled* will be CLEAR.

2\) If ACT Timeout is non-zero and *startTimeout* is non-zero, then
*signaled* will be CLEAR.

3\) If ACT Timeout is zero and *startTimeout* is zero, then *signaled*
will be unchanged.

4\) If ACT Timeout is non-zero and *startTimeout* is zero, then
*signaled* will be SET.

NOTE 1 The ACT signals on a transition from non-zero to zero. The
transition can occur either due to TPM2_ACT_SetTimeout() or a decrement.
The effect of *signaled* is platform dependent.

NOTE 2 It may take up to one second until ACT Timeout will be set and
*signaled* will be CLEAR or SET by TPM2_ACT_SetTimeout() or
TPM2_Startup(STATE). This allows the counting and signaling to take
place synchronously with the hardware clock tick.

NOTE 3 TPM2_ACT_SetTimeout() was added in revision 01.56.

### Command and Response

Table 250 — TPM2_ACT_SetTimeout Command

<table>
<colgroup>
<col style="width: 29%" />
<col style="width: 21%" />
<col style="width: 49%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPMI_ST_COMMAND_TAG</td>
<td>tag</td>
<td>TPM_ST_SESSIONS</td>
</tr>
<tr class="odd">
<td>UINT32</td>
<td>commandSize</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_CC</td>
<td>commandCode</td>
<td>TPM_CC_ACT_SetTimeout</td>
</tr>
<tr class="odd">
<td>TPMI_RH_ACT</td>
<td>@actHandle</td>
<td><p>Handle of the selected ACT</p>
<p>Auth Index: 1</p>
<p>Auth Role: USER</p></td>
</tr>
<tr class="even">
<td>UINT32</td>
<td>startTimeout</td>
<td>the start timeout value for the ACT in seconds</td>
</tr>
</tbody>
</table>

Table 251 — TPM2_ACT_SetTimeout Response

| Type   | Name         | Description  |
|--------|--------------|--------------|
| TPM_ST | tag          | see clause 6 |
| UINT32 | responseSize |              |
| TPM_RC | responseCode |              |

### Detailed Actions

\[\[ACT_SetTimeout\]\]

# Vendor Specific

## Introduction

This section contains commands that are vendor specific but made public
in order to prevent proliferation.

This specification does define TPM2_Vendor_TCG_Test() in order to have
at least one command that can be used to ensure the proper operation of
the command dispatch code when processing a vendor-specific command.

## TPM2_Vendor_TCG_Test

### General Description

This is a placeholder to allow testing of the dispatch code.

### Command and Response

Table 252 — TPM2_Vendor_TCG_Test Command

| Type                | Name        | Description                                                                   |
|---------------------|-------------|-------------------------------------------------------------------------------|
| TPMI_ST_COMMAND_TAG | tag         | TPM_ST_SESSIONS if an audit session is present; otherwise, TPM_ST_NO_SESSIONS |
| UINT32              | commandSize |                                                                               |
| TPM_CC              | commandCode | TPM_CC_Vendor_TCG_Test                                                        |
| TPM2B_DATA          | inputData   | dummy data                                                                    |

Table 253 — TPM2_Vendor_TCG_Test Response

| Type       | Name         | Description    |
|------------|--------------|----------------|
| TPM_ST     | tag          | see clause 6   |
| UINT32     | responseSize |                |
| TPM_RC     | responseCode | TPM_RC_SUCCESS |
| TPM2B_DATA | outputData   | dummy data     |

### Detailed Actions

\[\[Vendor_TCG_Test\]\]
