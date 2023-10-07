Trusted Platform Module Library

Vendor-Specific Values in Reference Code

Family “2.0”

Level 00 Revision 01.46

August 19, 2019

Contact: admin@trustedcomputinggroup.org

TCG Confidential

Copyright © TCG 2006-2019

**Licenses and Notices**

1.  Copyright Licenses:

    The TCG grants to the user of the other parts of this document the
    rights to reproduce, distribute, display, and perform the document
    for any purpose provided that this page is included in any copy of
    the document.

2.  Disclaimers:

    THE COPYRIGHT LICENSES SET FORTH ABOVE DO NOT REPRESENT ANY FORM OF
    LICENSE OR WAIVER, EXPRESS OR IMPLIED, BY ESTOPPEL OR OTHERWISE,
    WITH RESPECT TO PATENT RIGHTS HELD BY TCG MEMBERS (OR OTHER THIRD
    PARTIES).

    THIS DOCUMENT IS PROVIDED "AS IS" WITH NO EXPRESS OR IMPLIED
    WARRANTIES WHATSOEVER, INCLUDING ANY WARRANTY OF MERCHANTABILITY OR
    FITNESS FOR A PARTICULAR PURPOSE, ACCURACY, COMPLETENESS, OR
    NONINFRINGEMENT OF INTELLECTUAL PROPERTY RIGHTS, OR ANY WARRANTY
    OTHERWISE ARISING OUT OF ANY PROPOSAL OR SAMPLE.

    Without limitation, TCG and its members and licensors disclaim all
    liability, including liability for infringement of any proprietary
    rights, relating to use of information in this document, and TCG
    disclaims all liability for cost of procurement of substitute goods
    or services, lost profits, loss of use, loss of data or any
    incidental, consequential, direct, indirect, or special damages,
    whether under contract, tort, warranty or otherwise, arising in any
    way out of use or reliance upon this document or any information
    herein.

CONTENTS

1 Introduction 4

2 Notation 5

3 Processor Values 5

4 Implemented Algorithms 6

5 Key Size Selections 8

6 Implemented Curves 9

7 Implemented Commands 10

8 Authenticated Timers 14

9 PLATFORM 15

10 Implementation Specific Values 16

**Tables**

Table 1 — Defines for Processor Values 5

Table 2 — Defines for Implemented Algorithms 6

Table 3 — Defines for Key Size Constants 8

Table 4 — Defines for Implemented Curves 9

Table 5 — Defines for Implemented Commands 10

Table 6 — Defines for ACT Values 14

Table 6 — Defines for PLATFORM Values 15

Table 7 — Defines for Implementation Values 16

#  Introduction

This document contains tables that are used to define the properties of
a TPM 2.0 implementation. A vendor would modify these tables according
to their implementation choices. The chosen values should then be
reflected in the header files used in compilation of the TPM code.

A set of software scripts are available that will automatically convert
the values in the provided tables into appropriately formatted header
files. For availability of these scripts, please contact TCG
Administration (<admin@trustedcomputinggroup.org>).

This document is not a specification.

# 

# Processor Values

These values are used to control generation of octet-swapping routines
and the handling of bit fields structures that are sent on the TPM
interface. The canonical octet ordering for the TPM input/output buffer
is “big endian” (MSB0) with the most significant octet of any datum at
the lowest address. The canonical bit numbering assign the bit number of
0 to the least significant bit of each

NOTE The setting for the exemplar is for the x86 family of processor.

Table 1 — Defines for Processor Values

|                         |                         |                                                       |
|-------------------------|-------------------------|-------------------------------------------------------|
| Name                    | Value                   | Description                                           |
| BIG_ENDIAN_TPM          | NO                      | set to YES or NO according to the processor           |
| LITTLE_ENDIAN_TPM       | !BIG_ENDIAN_TPM         |                                                       |
| MOST_SIGNIFICANT_BIT_0  | NO                      | set to YES or NO according to the processor           |
| LEAST_SIGNIFICANT_BIT_0 | !MOST_SIGNIFICANT_BIT_0 |                                                       |
| AUTO_ALIGN              | NO                      | set to YES if the processor allows unaligned accesses |

# Implemented Algorithms

This table is used to indicate the algorithms that are implemented in a
TPM. The selections in the Value column may be changed to reflect the
implementation. The values shown are illustrative.

The "Implemented" column contains a "Y", "YES", or blank to indicate
that the command is present in the implementation, an "N" or "NO" to
indicate that the command is not implemented.

NOTE The leading and trailing “\_” characters are to avoid name space
collisions with some crypto libraries.

Table 2 — Defines for Implemented Algorithms

| Algorithm Name | Implemented | Comments                                                        |
|----------------|-------------|-----------------------------------------------------------------|
| RSA            | YES         |                                                                 |
| SHA1           | YES         |                                                                 |
| HMAC           | YES         | REQUIRED, do not change this value                              |
| TDES           | NO          |                                                                 |
| AES            | YES         |                                                                 |
| MGF1           | YES         |                                                                 |
| XOR            | YES         |                                                                 |
| KEYEDHASH      | YES         | REQUIRED, do not change this value                              |
| SHA256         | YES         |                                                                 |
| SHA384         | YES         |                                                                 |
| SHA512         | NO          |                                                                 |
| SM3_256        | YES         |                                                                 |
| SM4            | YES         |                                                                 |
| RSASSA         | YES         | requires RSA                                                    |
| RSAES          | YES         | requires RSA                                                    |
| RSAPSS         | YES         | requires RSA                                                    |
| OAEP           | YES         | requires RSA                                                    |
| ECC            | YES         |                                                                 |
| ECDH           | YES         | requires ECC                                                    |
| ECDSA          | YES         | requires ECC                                                    |
| ECDAA          | YES         | requires ECC                                                    |
| SM2            | NO          | requires ECC                                                    |
| CAMELLIA       | YES         |                                                                 |
| ECSCHNORR      | YES         | requires ECC                                                    |
| ECMQV          | NO          | requires ECC                                                    |
| SYMCIPHER      | YES         | REQUIRED, at least one symmetric algorithm shall be implemented |
| KDF1_SP800_56A | YES         | requires ECC                                                    |
| KDF2           | NO          |                                                                 |
| KDF1_SP800_108 | YES         |                                                                 |
| CMAC           | YES         |                                                                 |
| CTR            | YES         |                                                                 |
| OFB            | YES         |                                                                 |
| CBC            | YES         |                                                                 |
| CFB            | YES         | REQUIRED, do not change this value                              |
| ECB            | YES         |                                                                 |

# Key Size Selections

The values in this table indicate the allowed key sizes for the
implementation.

The Value column needs to have a list format (one or more values within
“{}”).

Make sure that the Type column is properly labeled or strange values
will be generated.

To prevent generation of the values for an algorithm, add any
non-upper-case character to the start of the name (such as
“-RSA_KEY_SIZES_BITS” or “xRSA_KEY_SIZES_BITS” or
“//RSA_KEY_SIZES_BITS”). Deleting the row will, of course, also work. Do
not just leave an empty list of key sizes

ECC key sizes are determined by the curve selection in Table 4.

Table 3 — Defines for Key Size Constants

|                         |              |              |                                            |
|-------------------------|--------------|--------------|--------------------------------------------|
| Name                    | Value        | Type         | Comments                                   |
| RSA_KEY_SIZES_BITS      | {1024, 2048} | Asymmetric   | values for the reference implementation    |
| TDES_KEY_SIZES_BITS     | {128, 192}   | Block Cipher | values for the reference implementation    |
| AES_KEY_SIZES_BITS      | {128, 256}   | Block Cipher | values for the reference implementation    |
| SM4_KEY_SIZES_BITS      | {128}        | Block Cipher | not relevant in this implementation        |
| CAMELLIA_KEY_SIZES_BITS | {128, 256}   | Block Cipher | not relevant for reference implementations |

# Implemented Curves

This table is used to indicate the curves that are implemented in a TPM.
The selections in the Value column may be changed to reflect the
implementation. The values shown are illustrative.

The “Implemented” column contains a “Y”, “YES”, or blank to indicate
that the curve is present in the implementation, an “N” or “NO” to
indicate that the curve is not implemented.

If ECC is not implemented, the contents of this table will not have an
effect on the code generated.

NOTE The curve names are required to have a number of at least three
digits in the last part of the name. ECC_SRC_P256 and ECC_SRC_P256A are
both acceptable but ECC_P256_SRC is not.

Table 4 — Defines for Implemented Curves

| Curve Identifier | Implemented | Comments                                          |
|------------------|-------------|---------------------------------------------------|
| ECC_NIST_P192    | NO          |                                                   |
| ECC_NIST_P224    | NO          |                                                   |
| ECC_NIST_P256    | YES         |                                                   |
| ECC_NIST_P384    | YES         |                                                   |
| ECC_NIST_P521    | NO          |                                                   |
| ECC_BN_P256      | YES         |                                                   |
| ECC_BN_P638      | NO          | This is needed to give 384-bit strength for ECDAA |
| ECC_SM2_P256     | YES         |                                                   |
| ECC_TEST_P192    | YES         |                                                   |

# Implemented Commands

This table is used to indicate which of the commands are implemented. In
the reference implementation, this table determines which commands can
be called and drives the generation of various command-dependent switch
statements.

The “Implemented or Dependent” column contains a “Y”, “YES”, or blank to
indicate that the command is present in the implementation; an “N” or
“NO” to indicate that the command is not implemented; and an algorithm
value if implementation of the command is dependent on a setting in
Table 2

Table 5 — Defines for Implemented Commands

| Name                       | Implemented | Comments                                |
|----------------------------|-------------|-----------------------------------------|
| ActivateCredential         | YES         |                                         |
| Certify                    | Y           |                                         |
| CertifyCreation            | Y           |                                         |
| ChangeEPS                  | Y           |                                         |
| ChangePPS                  | Y           |                                         |
| Clear                      | Y           |                                         |
| ClearControl               | Y           |                                         |
| ClockRateAdjust            | Y           |                                         |
| ClockSet                   | Y           |                                         |
| Commit                     | Y           | Requires ECC                            |
| ContextLoad                | Y           | Context                                 |
| ContextSave                | Y           | Context                                 |
| Create                     | Y           |                                         |
| CreatePrimary              | Y           |                                         |
| DictionaryAttackLockReset  | Y           |                                         |
| DictionaryAttackParameters | Y           |                                         |
| Duplicate                  | Y           |                                         |
| ECC_Parameters             | Y           | Requires ECC                            |
| ECDH_KeyGen                | Y           | Requires ECC                            |
| ECDH_ZGen                  | Y           | Requires ECC                            |
| EncryptDecrypt             | Y           |                                         |
| EventSequenceComplete      | Y           |                                         |
| EvictControl               | Y           |                                         |
| FieldUpgradeData           | N           |                                         |
| FieldUpgradeStart          | N           |                                         |
| FirmwareRead               | N           |                                         |
| FlushContext               | Y           | Context                                 |
| GetCapability              | Y           |                                         |
| GetCommandAuditDigest      | Y           |                                         |
| GetRandom                  | Y           |                                         |
| GetSessionAuditDigest      | Y           |                                         |
| GetTestResult              | Y           |                                         |
| GetTime                    | Y           |                                         |
| Hash                       | Y           |                                         |
| HashSequenceStart          | Y           |                                         |
| HierarchyChangeAuth        | Y           |                                         |
| HierarchyControl           | Y           |                                         |
| HMAC                       | Y           | Will be disabled if CMAC is implemented |
| MAC                        | Y           | Will be enabled if CMAC is available    |
| HMAC_Start                 | Y           | Will be disabled if CMAC is available   |
| MAC_Start                  | Y           | Will be disabled if CMA is available    |
| Import                     | Y           |                                         |
| IncrementalSelfTest        | Y           |                                         |
| Load                       | Y           |                                         |
| LoadExternal               | Y           |                                         |
| MakeCredential             | Y           |                                         |
| NV_Certify                 | Y           |                                         |
| NV_ChangeAuth              | Y           |                                         |
| NV_DefineSpace             | Y           |                                         |
| NV_Extend                  | Y           |                                         |
| NV_GlobalWriteLock         | Y           |                                         |
| NV_Increment               | Y           |                                         |
| NV_Read                    | Y           |                                         |
| NV_ReadLock                | Y           |                                         |
| NV_ReadPublic              | Y           | NV                                      |
| NV_SetBits                 | Y           |                                         |
| NV_UndefineSpace           | Y           |                                         |
| NV_UndefineSpaceSpecial    | Y           |                                         |
| NV_Write                   | Y           |                                         |
| NV_WriteLock               | Y           |                                         |
| ObjectChangeAuth           | Y           |                                         |
| PCR_Allocate               | Y           |                                         |
| PCR_Event                  | Y           | PCR                                     |
| PCR_Extend                 | Y           |                                         |
| PCR_Read                   | Y           | PCR                                     |
| PCR_Reset                  | Y           | PCR                                     |
| PCR_SetAuthPolicy          | Y           |                                         |
| PCR_SetAuthValue           | Y           |                                         |
| PolicyAuthorize            | Y           | Policy                                  |
| PolicyAuthValue            | Y           | Policy                                  |
| PolicyCommandCode          | Y           | Policy                                  |
| PolicyCounterTimer         | Y           | Policy                                  |
| PolicyCpHash               | Y           | Policy                                  |
| PolicyDuplicationSelect    | Y           | Policy                                  |
| PolicyGetDigest            | Y           | Policy                                  |
| PolicyLocality             | Y           | Policy                                  |
| PolicyNameHash             | Y           | Policy                                  |
| PolicyNV                   | Y           | Policy                                  |
| PolicyOR                   | Y           | Policy                                  |
| PolicyPassword             | Y           | Policy                                  |
| PolicyPCR                  | Y           | Policy                                  |
| PolicyPhysicalPresence     | Y           | Policy                                  |
| PolicyRestart              | Y           |                                         |
| PolicySecret               | Y           | Policy                                  |
| PolicySigned               | Y           | Policy                                  |
| PolicyTicket               | Y           | Policy                                  |
| PP_Commands                | Y           |                                         |
| Quote                      | Y           |                                         |
| ReadClock                  | Y           |                                         |
| ReadPublic                 | Y           |                                         |
| Rewrap                     | Y           |                                         |
| RSA_Decrypt                | Y           | Requires RSA                            |
| RSA_Encrypt                | Y           | Requires RSA                            |
| SelfTest                   | Y           |                                         |
| SequenceComplete           | Y           |                                         |
| SequenceUpdate             | Y           |                                         |
| SetAlgorithmSet            | Y           |                                         |
| SetCommandCodeAuditStatus  | Y           |                                         |
| SetPrimaryPolicy           | Y           |                                         |
| Shutdown                   | Y           |                                         |
| Sign                       | Y           |                                         |
| StartAuthSession           | Y           |                                         |
| Startup                    | Y           |                                         |
| StirRandom                 | Y           |                                         |
| TestParms                  | Y           |                                         |
| Unseal                     | Y           |                                         |
| VerifySignature            | Y           |                                         |
| ZGen_2Phase                | Y           | Requires ECC                            |
| EC_Ephemeral               | Y           | Requires ECC                            |
| PolicyNvWritten            | Y           |                                         |
| PolicyTemplate             | Y           |                                         |
| CreateLoaded               | Y           |                                         |
| PolicyAuthorizeNV          | Y           |                                         |
| EncryptDecrypt2            | Y           |                                         |
| AC_GetCapability           | Y           |                                         |
| AC_Send                    | Y           |                                         |
| Policy_AC_SendSelect       | Y           |                                         |
| Vendor_TCG_Test            | Y           |                                         |
| CertifyX509                | Y           |                                         |
| ACT_SetTimeout             | Y           |                                         |
| ECC_Encrypt                | Y           |                                         |
| ECC_Decrypt                | Y           |                                         |

# Authenticated Timers

This table indicates which of the ACT are implemented. It is only
necessary to list the implemented values

Table 6 — Defines for Implemented ACT

| Name     | Implemented | Comments                                                                                         |
|----------|-------------|--------------------------------------------------------------------------------------------------|
| RH_ACT_0 | YES         | assumed to be the AWT                                                                            |
| RH_ACT_1 | NO          | iisted to make sure macros are correct                                                           |
| RH_ACT_A | YES         | currently, this is just used for testing to make sure that the macros generate numbers correctly |

# PLATFORM

These values are readable with TPM2_GetCapability(). They are the
TPM_PT_PS_xxx values.

The vendor should update these values for the applicable platform
specification. In this example, the values refer to the TPM
specification values.

These values are not listed as “Definition of” because the values in
this document are macro replacement values and not constants.

Table 6 — Defines for PLATFORM Values

| Name                 | Value                | Comments |
|----------------------|----------------------|----------|
| PLATFORM_FAMILY      | TPM_SPEC_FAMILY      |          |
| PLATFORM_LEVEL       | TPM_SPEC_LEVEL       |          |
| PLATFORM_VERSION     | TPM_SPEC_VERSION     |          |
| PLATFORM_YEAR        | TPM_SPEC_YEAR        |          |
| PLATFORM_DAY_OF_YEAR | TPM_SPEC_DAY_OF_YEAR |          |

# Implementation Specific Values

This table contains a collection of values used in various parts of the
reference code. The values shown are illustrative.

Table 7 — Defines for Implementation Values

<table>
<colgroup>
<col style="width: 36%" />
<col style="width: 30%" />
<col style="width: 32%" />
</colgroup>
<thead>
<tr class="header">
<th>Name</th>
<th>Value</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>FIELD_UPGRADE_IMPLEMENTED</td>
<td>NO</td>
<td>temporary define</td>
</tr>
<tr class="even">
<td></td>
<td></td>
<td></td>
</tr>
<tr class="odd">
<td></td>
<td></td>
<td></td>
</tr>
<tr class="even">
<td></td>
<td></td>
<td></td>
</tr>
<tr class="odd">
<td>HASH_LIB</td>
<td>Ossl</td>
<td>Selection of the library that provides the basic hashing
functions.</td>
</tr>
<tr class="even">
<td>SYM_LIB</td>
<td>Ossl</td>
<td>Selection of the library that provides the low-level symmetric
cryptography. Choices are determined by the vendor (See LibSupport.h for
implications).</td>
</tr>
<tr class="odd">
<td>MATH_LIB</td>
<td>Ossl</td>
<td>Selection of the library that provides the big number math including
ECC. Choices are determined by the vendor (See LibSupport.h for
implications).</td>
</tr>
<tr class="even">
<td></td>
<td></td>
<td></td>
</tr>
<tr class="odd">
<td>IMPLEMENTATION_PCR</td>
<td>24</td>
<td>the number of PCR in the TPM</td>
</tr>
<tr class="even">
<td>PCR_SELECT_MAX</td>
<td>((IMPLEMENTATION_PCR+7)/8)</td>
<td></td>
</tr>
<tr class="odd">
<td>PLATFORM_PCR</td>
<td>24</td>
<td>the number of PCR required by the relevant platform
specification</td>
</tr>
<tr class="even">
<td>PCR_SELECT_MIN</td>
<td>((PLATFORM_PCR + 7) / 8)</td>
<td></td>
</tr>
<tr class="odd">
<td>DRTM_PCR</td>
<td>17</td>
<td><p>the D-RTM PCR</p>
<p>NOTE This value is not defined when the TPM does not implement
D-RTM</p></td>
</tr>
<tr class="even">
<td>HCRTM_PCR</td>
<td>0</td>
<td>the PCR that will receive the H-CRTM value at TPM2_Startup. This
value should not be changed.</td>
</tr>
<tr class="odd">
<td>NUM_LOCALITIES</td>
<td>5</td>
<td><p>the number of localities supported by the TPM</p>
<p>This is expected to be either 5 for a PC, or 1 for just about
everything else.</p></td>
</tr>
<tr class="even">
<td>MAX_HANDLE_NUM</td>
<td>3</td>
<td><p>the maximum number of handles in the handle area</p>
<p>This should be produced by the Part 3 parser but is here for
now.</p></td>
</tr>
<tr class="odd">
<td>MAX_ACTIVE_SESSIONS</td>
<td>64</td>
<td>the number of simultaneously active sessions that are supported by
the TPM implementation</td>
</tr>
<tr class="even">
<td>CONTEXT_SLOT</td>
<td>UINT16</td>
<td>the type of an entry in the array of saved contexts</td>
</tr>
<tr class="odd">
<td></td>
<td></td>
<td></td>
</tr>
<tr class="even">
<td>MAX_LOADED_SESSIONS</td>
<td>3</td>
<td>the number of sessions that the TPM may have in memory</td>
</tr>
<tr class="odd">
<td>MAX_SESSION_NUM</td>
<td>3</td>
<td>this is the current maximum value</td>
</tr>
<tr class="even">
<td>MAX_LOADED_OBJECTS</td>
<td>3</td>
<td>the number of simultaneously loaded objects that are supported by
the TPM; this number does not include the objects that may be placed in
NV memory by TPM2_EvictControl().</td>
</tr>
<tr class="odd">
<td>MIN_EVICT_OBJECTS</td>
<td>2</td>
<td>the minimum number of evict objects supported by the TPM</td>
</tr>
<tr class="even">
<td>NUM_POLICY_PCR_GROUP</td>
<td>1</td>
<td>number of PCR groups that have individual policies</td>
</tr>
<tr class="odd">
<td>NUM_AUTHVALUE_PCR_GROUP</td>
<td>1</td>
<td>number of PCR groups that have individual authorization values</td>
</tr>
<tr class="even">
<td>MAX_CONTEXT_SIZE</td>
<td>1264</td>
<td></td>
</tr>
<tr class="odd">
<td>MAX_DIGEST_BUFFER</td>
<td>1024</td>
<td></td>
</tr>
<tr class="even">
<td>MAX_NV_INDEX_SIZE</td>
<td>2048</td>
<td>maximum data size allowed in an NV Index</td>
</tr>
<tr class="odd">
<td>MAX_NV_BUFFER_SIZE</td>
<td>1024</td>
<td>maximum data size in one NV read or write command</td>
</tr>
<tr class="even">
<td>MAX_CAP_BUFFER</td>
<td>1024</td>
<td>maximum size of a capability buffer</td>
</tr>
<tr class="odd">
<td>NV_MEMORY_SIZE</td>
<td>16384</td>
<td>size of NV memory in octets</td>
</tr>
<tr class="even">
<td>MIN_COUNTER_INDICES</td>
<td>8</td>
<td>the TPM will not allocate a non-counter index if it would prevent
allocation of this number of indices.</td>
</tr>
<tr class="odd">
<td>NUM_STATIC_PCR</td>
<td>16</td>
<td></td>
</tr>
<tr class="even">
<td>MAX_ALG_LIST_SIZE</td>
<td>64</td>
<td>number of algorithms that can be in a list</td>
</tr>
<tr class="odd">
<td>PRIMARY_SEED_SIZE</td>
<td>32</td>
<td>size of the Primary Seed in octets</td>
</tr>
<tr class="even">
<td>CONTEXT_ENCRYPT_ALGORITHM</td>
<td>AES</td>
<td><p>context encryption algorithm</p>
<p>Just use the root so that the macros in GpMacros.h will work
correctly.</p></td>
</tr>
<tr class="odd">
<td>NV_CLOCK_UPDATE_INTERVAL</td>
<td>12</td>
<td><p>the update interval expressed as a power of 2 seconds</p>
<p>A value of 12 is 4,096 seconds (~68 minutes).</p></td>
</tr>
<tr class="even">
<td>NUM_POLICY_PCR</td>
<td>1</td>
<td>number of PCR groups that allow policy/auth</td>
</tr>
<tr class="odd">
<td>MAX_COMMAND_SIZE</td>
<td>4096</td>
<td>maximum size of a command</td>
</tr>
<tr class="even">
<td>MAX_RESPONSE_SIZE</td>
<td>4096</td>
<td>maximum size of a response</td>
</tr>
<tr class="odd">
<td>ORDERLY_BITS</td>
<td>8</td>
<td>number between 1 and 32 inclusive</td>
</tr>
<tr class="even">
<td>MAX_SYM_DATA</td>
<td>128</td>
<td>the maximum number of octets that may be in a sealed blob; 128 is
the minimum allowed value</td>
</tr>
<tr class="odd">
<td>MAX_RNG_ENTROPY_SIZE</td>
<td>64</td>
<td></td>
</tr>
<tr class="even">
<td>RAM_INDEX_SPACE</td>
<td>512</td>
<td>Number of bytes used for the RAM index space. If this is not large
enough, it might not be possible to allocate orderly indices.</td>
</tr>
<tr class="odd">
<td>RSA_DEFAULT_PUBLIC_EXPONENT</td>
<td>0x00010001</td>
<td>2<sup>16</sup> + 1</td>
</tr>
<tr class="even">
<td>ENABLE_PCR_NO_INCREMENT</td>
<td>YES</td>
<td>indicates if the TPM_PT_PCR_NO_INCREMENT group is implemented</td>
</tr>
<tr class="odd">
<td>CRT_FORMAT_RSA</td>
<td>YES</td>
<td></td>
</tr>
<tr class="even">
<td>VENDOR_COMMAND_COUNT</td>
<td>0</td>
<td></td>
</tr>
<tr class="odd">
<td>MAX_VENDOR_BUFFER_SIZE</td>
<td>1024</td>
<td>Maximum size of the vendor-specific buffer</td>
</tr>
<tr class="even">
<td>MAX_DERIVATION_BITS</td>
<td>8192</td>
<td><p>“L’ value for a derivation. This is the</p>
<p>maximum number of bits allowed from an instantiation of a KDF-DRBG.
This is size is OK because RSA keys are never derived keys</p></td>
</tr>
<tr class="odd">
<td>RSA_MAX_PRIME</td>
<td>(MAX_RSA_KEY_BYTES/2)</td>
<td></td>
</tr>
<tr class="even">
<td>RSA_PRIVATE_SIZE</td>
<td>(RSA_MAX_PRIME * 5)</td>
<td></td>
</tr>
<tr class="odd">
<td>SIZE_OF_X509_SERIAL_NUMBER</td>
<td>20</td>
<td></td>
</tr>
<tr class="even">
<td>PRIVATE_VENDOR_SPECIFIC_BYTES</td>
<td>RSA_PRIVATE_SIZE</td>
<td>This is a vendor-specific value so it is in this vendor-speific
table. When this is used, RSA_PRIVATE_SIZE will have been defined</td>
</tr>
</tbody>
</table>
