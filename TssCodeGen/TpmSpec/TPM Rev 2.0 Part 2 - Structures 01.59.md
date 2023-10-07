Trusted Platform Module Library

Part 2: Structures

Family “2.0”

Level 00 Revision 01.59

November 8, 2019

Committee Draft

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

[1 Scope [1](#scope)](#scope)

[2 Terms and definitions
[1](#terms-and-definitions)](#terms-and-definitions)

[3 Symbols and abbreviated terms
[1](#symbols-and-abbreviated-terms)](#symbols-and-abbreviated-terms)

[4 Notation [1](#notation)](#notation)

[4.1 Introduction [1](#introduction)](#introduction)

[4.2 Named Constants [2](#named-constants)](#named-constants)

[4.3 Data Type Aliases (typedefs)
[3](#data-type-aliases-typedefs)](#data-type-aliases-typedefs)

[4.4 Enumerations [3](#enumerations)](#enumerations)

[4.5 Interface Type [4](#interface-type)](#interface-type)

[4.6 Arrays [5](#arrays)](#arrays)

[4.7 Structure Definitions
[6](#structure-definitions)](#structure-definitions)

[4.8 Conditional Types [7](#_Toc283838898)](#_Toc283838898)

[4.9 Unions [9](#unions)](#unions)

[4.9.1 Introduction [9](#introduction-1)](#introduction-1)

[4.9.2 Union Definition [9](#union-definition)](#union-definition)

[4.9.3 Union Instance [10](#union-instance)](#union-instance)

[4.9.4 Union Selector Definition [11](#_Toc20317522)](#_Toc20317522)

[4.10 Bit Field Definitions
[12](#bit-field-definitions)](#bit-field-definitions)

[4.11 Parameter Limits [13](#parameter-limits)](#parameter-limits)

[4.12 Algorithm Macros [14](#algorithm-macros)](#algorithm-macros)

[4.12.1 Introduction [14](#introduction-2)](#introduction-2)

[4.12.2 Algorithm Token Semantics
[15](#algorithm-token-semantics)](#algorithm-token-semantics)

[4.12.3 Algorithm Tokens in Unions
[15](#algorithm-tokens-in-unions)](#algorithm-tokens-in-unions)

[4.12.4 Algorithm Tokens in Interface Types
[16](#algorithm-tokens-in-interface-types)](#algorithm-tokens-in-interface-types)

[4.12.5 Algorithm Tokens for Table Replication
[16](#algorithm-tokens-for-table-replication)](#algorithm-tokens-for-table-replication)

[4.13 Size Checking [18](#size-checking)](#size-checking)

[4.14 Data Direction [18](#data-direction)](#data-direction)

[4.15 Structure Validations
[20](#structure-validations)](#structure-validations)

[4.16 Name Prefix Convention
[20](#name-prefix-convention)](#name-prefix-convention)

[4.17 Data Alignment [21](#data-alignment)](#data-alignment)

[4.18 Parameter Unmarshaling Errors
[21](#parameter-unmarshaling-errors)](#parameter-unmarshaling-errors)

[5 Base Types [23](#base-types)](#base-types)

[5.1 Primitive Types [23](#primitive-types)](#primitive-types)

[5.2 Specification Logic Value Constants
[23](#specification-logic-value-constants)](#specification-logic-value-constants)

[5.3 Miscellaneous Types
[24](#miscellaneous-types)](#miscellaneous-types)

[6 Constants [25](#constants)](#constants)

[6.1 TPM_SPEC (Specification Version Values)
[25](#tpm_spec-specification-version-values)](#tpm_spec-specification-version-values)

[6.2 TPM_GENERATED [25](#tpm_generated)](#tpm_generated)

[6.3 TPM_ALG_ID [26](#tpm_alg_id)](#tpm_alg_id)

[6.4 TPM_ECC_CURVE [30](#tpm_ecc_curve)](#tpm_ecc_curve)

[6.5 TPM_CC (Command Codes)
[30](#tpm_cc-command-codes)](#tpm_cc-command-codes)

[6.5.1 Format [30](#format)](#format)

[6.5.2 TPM_CC Listing [31](#tpm_cc-listing)](#tpm_cc-listing)

[6.6 TPM_RC (Response Codes)
[35](#tpm_rc-response-codes)](#tpm_rc-response-codes)

[6.6.1 Description [35](#description)](#description)

[6.6.2 Response Code Formats
[35](#response-code-formats)](#response-code-formats)

[6.6.3 TPM_RC Values [38](#tpm_rc-values)](#tpm_rc-values)

[6.7 TPM_CLOCK_ADJUST [43](#tpm_clock_adjust)](#tpm_clock_adjust)

[6.8 TPM_EO (EA Arithmetic Operands)
[43](#tpm_eo-ea-arithmetic-operands)](#tpm_eo-ea-arithmetic-operands)

[6.9 TPM_ST (Structure Tags)
[44](#tpm_st-structure-tags)](#tpm_st-structure-tags)

[6.10 TPM_SU (Startup Type)
[46](#tpm_su-startup-type)](#tpm_su-startup-type)

[6.11 TPM_SE (Session Type)
[47](#tpm_se-session-type)](#tpm_se-session-type)

[6.12 TPM_CAP (Capabilities)
[48](#tpm_cap-capabilities)](#tpm_cap-capabilities)

[6.13 TPM_PT (Property Tag)
[49](#tpm_pt-property-tag)](#tpm_pt-property-tag)

[6.14 TPM_PT_PCR (PCR Property Tag)
[54](#tpm_pt_pcr-pcr-property-tag)](#tpm_pt_pcr-pcr-property-tag)

[6.15 TPM_PS (Platform Specific)
[56](#tpm_ps-platform-specific)](#tpm_ps-platform-specific)

[7 Handles [57](#handles)](#handles)

[7.1 Introduction [57](#introduction-3)](#introduction-3)

[7.2 TPM_HT (Handle Types)
[57](#tpm_ht-handle-types)](#tpm_ht-handle-types)

[7.3 Persistent Handle Sub-ranges
[58](#persistent-handle-sub-ranges)](#persistent-handle-sub-ranges)

[7.4 TPM_RH (Permanent Handles)
[59](#tpm_rh-permanent-handles)](#tpm_rh-permanent-handles)

[7.5 TPM_HC (Handle Value Constants)
[60](#tpm_hc-handle-value-constants)](#tpm_hc-handle-value-constants)

[8 Attribute Structures
[63](#attribute-structures)](#attribute-structures)

[8.1 Description [63](#description-1)](#description-1)

[8.2 TPMA_ALGORITHM [63](#tpma_algorithm)](#tpma_algorithm)

[8.3 TPMA_OBJECT (Object Attributes)
[64](#tpma_object-object-attributes)](#tpma_object-object-attributes)

[8.3.1 Introduction [64](#introduction-4)](#introduction-4)

[8.3.2 Structure Definition
[64](#structure-definition)](#structure-definition)

[8.3.3 Attribute Descriptions
[65](#attribute-descriptions)](#attribute-descriptions)

[8.3.3.1 Introduction [65](#introduction-5)](#introduction-5)

[8.3.3.2 Bit\[1\] – *fixedTPM* [66](#bit1-fixedtpm)](#bit1-fixedtpm)

[8.3.3.3 Bit\[2\] – *stClear* [66](#bit2-stclear)](#bit2-stclear)

[8.3.3.4 Bit\[4\] – *fixedParent*
[66](#bit4-fixedparent)](#bit4-fixedparent)

[8.3.3.5 Bit\[5\] – *sensitiveDataOrigin*
[66](#bit5-sensitivedataorigin)](#bit5-sensitivedataorigin)

[8.3.3.6 Bit\[6\] – *userWithAuth*
[67](#bit6-userwithauth)](#bit6-userwithauth)

[8.3.3.7 Bit\[7\] – *adminWithPolicy*
[67](#bit7-adminwithpolicy)](#bit7-adminwithpolicy)

[8.3.3.8 Bit\[10\] – *noDA* [68](#bit10-noda)](#bit10-noda)

[8.3.3.9 Bit\[11\] – *encryptedDuplication*
[68](#bit11-encryptedduplication)](#bit11-encryptedduplication)

[8.3.3.10 Bit\[16\] – *restricted*
[69](#bit16-restricted)](#bit16-restricted)

[8.3.3.11 Bit\[17\] – *decrypt* [69](#bit17-decrypt)](#bit17-decrypt)

[8.3.3.12 Bit\[18\] – *sign* / *encrypt*
[70](#bit18-sign-encrypt)](#bit18-sign-encrypt)

[8.3.3.13 Bit\[19\] – *x509sign* [70](#bit19-x509sign)](#bit19-x509sign)

[8.4 TPMA_SESSION (Session Attributes)
[71](#tpma_session-session-attributes)](#tpma_session-session-attributes)

[8.5 TPMA_LOCALITY (Locality Attribute)
[73](#tpma_locality-locality-attribute)](#tpma_locality-locality-attribute)

[8.6 TPMA_PERMANENT [74](#tpma_permanent)](#tpma_permanent)

[8.7 TPMA_STARTUP_CLEAR [75](#tpma_startup_clear)](#tpma_startup_clear)

[8.8 TPMA_MEMORY [76](#tpma_memory)](#tpma_memory)

[8.9 TPMA_CC (Command Code Attributes)
[77](#tpma_cc-command-code-attributes)](#tpma_cc-command-code-attributes)

[8.9.1 Introduction [77](#introduction-6)](#introduction-6)

[8.9.2 Structure Definition
[77](#structure-definition-1)](#structure-definition-1)

[8.9.3 Field Descriptions
[77](#field-descriptions)](#field-descriptions)

[8.9.3.1 Bits\[15:0\] – *commandIndex*
[77](#bits150-commandindex)](#bits150-commandindex)

[8.9.3.2 Bit\[22\] – *nv* [77](#bit22-nv)](#bit22-nv)

[8.9.3.3 Bit\[23\] – *extensive*
[78](#bit23-extensive)](#bit23-extensive)

[8.9.3.4 Bit\[24\] – *flushed* [78](#bit24-flushed)](#bit24-flushed)

[8.9.3.5 Bits\[27:25\] – *cHandles*
[78](#bits2725-chandles)](#bits2725-chandles)

[8.9.3.6 Bit\[28\] – *rHandle* [78](#bit28-rhandle)](#bit28-rhandle)

[8.9.3.7 Bit\[29\] – V [78](#bit29-v)](#bit29-v)

[8.9.3.8 Bits\[31:30\] – Res [79](#bits3130-res)](#bits3130-res)

[8.10 TPMA_MODES [79](#_Toc20317605)](#_Toc20317605)

[8.11 TPMA_X509_KEY_USAGE [80](#_Toc20317606)](#_Toc20317606)

[8.12 TPMA_ACT [81](#tpma_act)](#tpma_act)

[9 Interface Types [82](#_Toc20317608)](#_Toc20317608)

[9.1 Introduction [82](#introduction-7)](#introduction-7)

[9.2 TPMI_YES_NO [82](#tpmi_yes_no)](#tpmi_yes_no)

[9.3 TPMI_DH_OBJECT [82](#tpmi_dh_object)](#tpmi_dh_object)

[9.4 TPMI_DH_PARENT [83](#tpmi_dh_parent)](#tpmi_dh_parent)

[9.5 TPMI_DH_PERSISTENT [83](#tpmi_dh_persistent)](#tpmi_dh_persistent)

[9.6 TPMI_DH_ENTITY [84](#tpmi_dh_entity)](#tpmi_dh_entity)

[9.7 TPMI_DH_PCR [84](#tpmi_dh_pcr)](#tpmi_dh_pcr)

[9.8 TPMI_SH_AUTH_SESSION
[85](#tpmi_sh_auth_session)](#tpmi_sh_auth_session)

[9.9 TPMI_SH_HMAC [85](#tpmi_sh_hmac)](#tpmi_sh_hmac)

[9.10 TPMI_SH_POLICY [85](#tpmi_sh_policy)](#tpmi_sh_policy)

[9.11 TPMI_DH_CONTEXT [85](#tpmi_dh_context)](#tpmi_dh_context)

[9.12 TPMI_DH_SAVED [86](#tpmi_dh_saved)](#tpmi_dh_saved)

[9.13 TPMI_RH_HIERARCHY [86](#tpmi_rh_hierarchy)](#tpmi_rh_hierarchy)

[9.14 TPMI_RH_ENABLES [86](#tpmi_rh_enables)](#tpmi_rh_enables)

[9.15 TPMI_RH_HIERARCHY_AUTH
[87](#tpmi_rh_hierarchy_auth)](#tpmi_rh_hierarchy_auth)

[9.16 TPMI_RH_HIERARCHY_POLICY
[87](#tpmi_rh_hierarchy_policy)](#tpmi_rh_hierarchy_policy)

[9.17 TPMI_RH_PLATFORM [87](#tpmi_rh_platform)](#tpmi_rh_platform)

[9.18 TPMI_RH_OWNER [88](#tpmi_rh_owner)](#tpmi_rh_owner)

[9.19 TPMI_RH_ENDORSEMENT
[88](#tpmi_rh_endorsement)](#tpmi_rh_endorsement)

[9.20 TPMI_RH_PROVISION [88](#tpmi_rh_provision)](#tpmi_rh_provision)

[9.21 TPMI_RH_CLEAR [89](#tpmi_rh_clear)](#tpmi_rh_clear)

[9.22 TPMI_RH_NV_AUTH [89](#tpmi_rh_nv_auth)](#tpmi_rh_nv_auth)

[9.23 TPMI_RH_LOCKOUT [89](#tpmi_rh_lockout)](#tpmi_rh_lockout)

[9.24 TPMI_RH_NV_INDEX [90](#tpmi_rh_nv_index)](#tpmi_rh_nv_index)

[9.25 TPMI_RH_AC [90](#tpmi_rh_ac)](#tpmi_rh_ac)

[9.26 TPMI_RH_ACT [91](#tpmi_rh_act)](#tpmi_rh_act)

[9.27 TPMI_ALG_HASH [91](#tpmi_alg_hash)](#tpmi_alg_hash)

[9.28 TPMI_ALG_ASYM (Asymmetric Algorithms)
[91](#tpmi_alg_asym-asymmetric-algorithms)](#tpmi_alg_asym-asymmetric-algorithms)

[9.29 TPMI_ALG_SYM (Symmetric Algorithms)
[92](#tpmi_alg_sym-symmetric-algorithms)](#tpmi_alg_sym-symmetric-algorithms)

[9.30 TPMI_ALG_SYM_OBJECT
[92](#tpmi_alg_sym_object)](#tpmi_alg_sym_object)

[9.31 TPMI_ALG_SYM_MODE [92](#tpmi_alg_sym_mode)](#tpmi_alg_sym_mode)

[9.32 TPMI_ALG_KDF (Key and Mask Generation Functions)
[93](#tpmi_alg_kdf-key-and-mask-generation-functions)](#tpmi_alg_kdf-key-and-mask-generation-functions)

[9.33 TPMI_ALG_SIG_SCHEME
[93](#tpmi_alg_sig_scheme)](#tpmi_alg_sig_scheme)

[9.34 TPMI_ECC_KEY_EXCHANGE
[93](#tpmi_ecc_key_exchange)](#tpmi_ecc_key_exchange)

[9.35 TPMI_ST_COMMAND_TAG
[94](#tpmi_st_command_tag)](#tpmi_st_command_tag)

[9.36 TPMI_ALG_MAC_SCHEME
[94](#tpmi_alg_mac_scheme)](#tpmi_alg_mac_scheme)

[9.37 TPMI_ALG_CIPHER_MODE
[94](#tpmi_alg_cipher_mode)](#tpmi_alg_cipher_mode)

[10 Structure Definitions
[95](#structure-definitions-1)](#structure-definitions-1)

[10.1 TPMS_EMPTY [95](#tpms_empty)](#tpms_empty)

[10.2 TPMS_ALGORITHM_DESCRIPTION
[95](#tpms_algorithm_description)](#tpms_algorithm_description)

[10.3 Hash/Digest Structures
[95](#hashdigest-structures)](#hashdigest-structures)

[10.3.1 TPMU_HA (Hash) [95](#tpmu_ha-hash)](#tpmu_ha-hash)

[10.3.2 TPMT_HA [96](#tpmt_ha)](#tpmt_ha)

[10.4 Sized Buffers [96](#sized-buffers)](#sized-buffers)

[10.4.1 Introduction [96](#introduction-8)](#introduction-8)

[10.4.2 TPM2B_DIGEST [97](#tpm2b_digest)](#tpm2b_digest)

[10.4.3 TPM2B_DATA [97](#tpm2b_data)](#tpm2b_data)

[10.4.4 TPM2B_NONCE [97](#tpm2b_nonce)](#tpm2b_nonce)

[10.4.5 TPM2B_AUTH [97](#tpm2b_auth)](#tpm2b_auth)

[10.4.6 TPM2B_OPERAND [98](#tpm2b_operand)](#tpm2b_operand)

[10.4.7 TPM2B_EVENT [98](#tpm2b_event)](#tpm2b_event)

[10.4.8 TPM2B_MAX_BUFFER [98](#tpm2b_max_buffer)](#tpm2b_max_buffer)

[10.4.9 TPM2B_MAX_NV_BUFFER
[98](#tpm2b_max_nv_buffer)](#tpm2b_max_nv_buffer)

[10.4.10 TPM2B_TIMEOUT [99](#tpm2b_timeout)](#tpm2b_timeout)

[10.4.11 TPM2B_IV [99](#tpm2b_iv)](#tpm2b_iv)

[10.5 Names [99](#names)](#names)

[10.5.1 Introduction [99](#introduction-9)](#introduction-9)

[10.5.2 TPMU_NAME [99](#tpmu_name)](#tpmu_name)

[10.5.3 TPM2B_NAME [100](#tpm2b_name)](#tpm2b_name)

[10.6 PCR Structures [100](#pcr-structures)](#pcr-structures)

[10.6.1 TPMS_PCR_SELECT [100](#tpms_pcr_select)](#tpms_pcr_select)

[10.6.2 TPMS_PCR_SELECTION
[101](#tpms_pcr_selection)](#tpms_pcr_selection)

[10.7 Tickets [101](#tickets)](#tickets)

[10.7.1 Introduction [101](#introduction-10)](#introduction-10)

[10.7.2 A NULL Ticket [102](#a-null-ticket)](#a-null-ticket)

[10.7.3 TPMT_TK_CREATION [102](#tpmt_tk_creation)](#tpmt_tk_creation)

[10.7.4 TPMT_TK_VERIFIED [103](#tpmt_tk_verified)](#tpmt_tk_verified)

[10.7.5 TPMT_TK_AUTH [104](#_Toc20317676)](#_Toc20317676)

[10.7.6 TPMT_TK_HASHCHECK [105](#tpmt_tk_hashcheck)](#tpmt_tk_hashcheck)

[10.8 Property Structures
[105](#property-structures)](#property-structures)

[10.8.1 TPMS_ALG_PROPERTY [105](#tpms_alg_property)](#tpms_alg_property)

[10.8.2 TPMS_TAGGED_PROPERTY
[105](#tpms_tagged_property)](#tpms_tagged_property)

[10.8.3 TPMS_TAGGED_PCR_SELECT
[106](#tpms_tagged_pcr_select)](#tpms_tagged_pcr_select)

[10.8.4 TPMS_TAGGED_POLICY
[106](#tpms_tagged_policy)](#tpms_tagged_policy)

[10.8.5 TPMS_ACT_DATA [106](#tpms_act_data)](#tpms_act_data)

[10.9 Lists [107](#lists)](#lists)

[10.9.1 TPML_CC [107](#tpml_cc)](#tpml_cc)

[10.9.2 TPML_CCA [107](#tpml_cca)](#tpml_cca)

[10.9.3 TPML_ALG [107](#tpml_alg)](#tpml_alg)

[10.9.4 TPML_HANDLE [108](#tpml_handle)](#tpml_handle)

[10.9.5 TPML_DIGEST [108](#tpml_digest)](#tpml_digest)

[10.9.6 TPML_DIGEST_VALUES
[109](#tpml_digest_values)](#tpml_digest_values)

[10.9.7 TPML_PCR_SELECTION
[109](#tpml_pcr_selection)](#tpml_pcr_selection)

[10.9.8 TPML_ALG_PROPERTY [109](#tpml_alg_property)](#tpml_alg_property)

[10.9.9 TPML_TAGGED_TPM_PROPERTY
[110](#tpml_tagged_tpm_property)](#tpml_tagged_tpm_property)

[10.9.10 TPML_TAGGED_PCR_PROPERTY
[110](#tpml_tagged_pcr_property)](#tpml_tagged_pcr_property)

[10.9.11 TPML_ECC_CURVE [110](#tpml_ecc_curve)](#tpml_ecc_curve)

[10.9.12 TPML_TAGGED_POLICY
[111](#tpml_tagged_policy)](#tpml_tagged_policy)

[10.9.13 TPML_ACT_DATA [111](#tpml_act_data)](#tpml_act_data)

[10.10 Capabilities Structures
[111](#capabilities-structures)](#capabilities-structures)

[10.10.1 TPMU_CAPABILITIES [112](#_Toc286047089)](#_Toc286047089)

[10.10.2 TPMS_CAPABILITY_DATA
[112](#tpms_capability_data)](#tpms_capability_data)

[10.11 Clock/Counter Structures
[112](#clockcounter-structures)](#clockcounter-structures)

[10.11.1 TPMS_CLOCK_INFO [112](#tpms_clock_info)](#tpms_clock_info)

[10.11.2 *Clock* [113](#clock)](#clock)

[10.11.3 *ResetCount* [113](#resetcount)](#resetcount)

[10.11.4 *RestartCount* [113](#restartcount)](#restartcount)

[10.11.5 *Safe* [113](#safe)](#safe)

[10.11.6 TPMS_TIME_INFO [114](#tpms_time_info)](#tpms_time_info)

[10.12 TPM Attestation Structures
[114](#tpm-attestation-structures)](#tpm-attestation-structures)

[10.12.1 Introduction [114](#introduction-11)](#introduction-11)

[10.12.2 TPMS_TIME_ATTEST_INFO
[114](#tpms_time_attest_info)](#tpms_time_attest_info)

[10.12.3 TPMS_CERTIFY_INFO
[114](#tpms_certify_info)](#tpms_certify_info)

[10.12.4 TPMS_QUOTE_INFO [115](#tpms_quote_info)](#tpms_quote_info)

[10.12.5 TPMS_COMMAND_AUDIT_INFO
[115](#tpms_command_audit_info)](#tpms_command_audit_info)

[10.12.6 TPMS_SESSION_AUDIT_INFO
[115](#tpms_session_audit_info)](#tpms_session_audit_info)

[10.12.7 TPMS_CREATION_INFO
[115](#tpms_creation_info)](#tpms_creation_info)

[10.12.8 TPMS_NV_CERTIFY_INFO
[116](#tpms_nv_certify_info)](#tpms_nv_certify_info)

[10.12.9 TPMS_NV_DIGEST_CERTIFY_INFO
[116](#tpms_nv_digest_certify_info)](#tpms_nv_digest_certify_info)

[10.12.10 TPMI_ST_ATTEST [116](#tpmi_st_attest)](#tpmi_st_attest)

[10.12.11 TPMU_ATTEST [117](#tpmu_attest)](#tpmu_attest)

[10.12.12 TPMS_ATTEST [117](#tpms_attest)](#tpms_attest)

[10.12.13 TPM2B_ATTEST [118](#tpm2b_attest)](#tpm2b_attest)

[10.13 Authorization Structures
[118](#authorization-structures)](#authorization-structures)

[10.13.1 Introduction [118](#introduction-12)](#introduction-12)

[10.13.2 TPMS_AUTH_COMMAND
[118](#tpms_auth_command)](#tpms_auth_command)

[10.13.3 TPMS_AUTH_RESPONSE
[118](#tpms_auth_response)](#tpms_auth_response)

[11 Algorithm Parameters and Structures
[119](#algorithm-parameters-and-structures)](#algorithm-parameters-and-structures)

[11.1 Symmetric [119](#symmetric)](#symmetric)

[11.1.1 Introduction [119](#introduction-13)](#introduction-13)

[11.1.2 TPMI\_!ALG.S_KEY_BITS
[119](#tpmi_alg.s_key_bits)](#tpmi_alg.s_key_bits)

[11.1.3 TPMU_SYM_KEY_BITS [119](#tpmu_sym_key_bits)](#tpmu_sym_key_bits)

[11.1.4 TPMU_SYM_MODE [120](#tpmu_sym_mode)](#tpmu_sym_mode)

[11.1.5 TPMU_SYM_DETAILS [120](#tpmu_sym_details)](#tpmu_sym_details)

[11.1.6 TPMT_SYM_DEF [121](#tpmt_sym_def)](#tpmt_sym_def)

[11.1.7 TPMT_SYM_DEF_OBJECT
[121](#tpmt_sym_def_object)](#tpmt_sym_def_object)

[11.1.8 TPM2B_SYM_KEY [121](#tpm2b_sym_key)](#tpm2b_sym_key)

[11.1.9 TPMS_SYMCIPHER_PARMS
[122](#tpms_symcipher_parms)](#tpms_symcipher_parms)

[11.1.10 TPM2B_LABEL [122](#tpm2b_label)](#tpm2b_label)

[11.1.11 TPMS_DERIVE [122](#tpms_derive)](#tpms_derive)

[11.1.12 TPM2B_DERIVE [123](#tpm2b_derive)](#tpm2b_derive)

[11.1.13 TPMU_SENSITIVE_CREATE
[123](#tpmu_sensitive_create)](#tpmu_sensitive_create)

[11.1.14 TPM2B_SENSITIVE_DATA
[123](#tpm2b_sensitive_data)](#tpm2b_sensitive_data)

[11.1.15 TPMS_SENSITIVE_CREATE
[124](#tpms_sensitive_create)](#tpms_sensitive_create)

[11.1.16 TPM2B_SENSITIVE_CREATE
[124](#tpm2b_sensitive_create)](#tpm2b_sensitive_create)

[11.1.17 TPMS_SCHEME_HASH [124](#_Toc20317744)](#_Toc20317744)

[11.1.18 TPMS_SCHEME_ECDAA
[125](#tpms_scheme_ecdaa)](#tpms_scheme_ecdaa)

[11.1.19 TPMI_ALG_KEYEDHASH_SCHEME
[125](#tpmi_alg_keyedhash_scheme)](#tpmi_alg_keyedhash_scheme)

[11.1.20 HMAC_SIG_SCHEME [125](#hmac_sig_scheme)](#hmac_sig_scheme)

[11.1.21 TPMS_SCHEME_XOR [125](#tpms_scheme_xor)](#tpms_scheme_xor)

[11.1.22 TPMU_SCHEME_KEYEDHASH
[126](#tpmu_scheme_keyedhash)](#tpmu_scheme_keyedhash)

[11.1.23 TPMT_KEYEDHASH_SCHEME
[126](#tpmt_keyedhash_scheme)](#tpmt_keyedhash_scheme)

[11.2 Asymmetric [127](#asymmetric)](#asymmetric)

[11.2.1 Signing Schemes [127](#signing-schemes)](#signing-schemes)

[11.2.1.1 Introduction [127](#introduction-14)](#introduction-14)

[11.2.1.2 RSA Signature Schemes
[127](#rsa-signature-schemes)](#rsa-signature-schemes)

[11.2.1.3 ECC Signature Schemes
[127](#ecc-signature-schemes)](#ecc-signature-schemes)

[11.2.1.4 TPMU_SIG_SCHEME [128](#tpmu_sig_scheme)](#tpmu_sig_scheme)

[11.2.1.5 TPMT_SIG_SCHEME [128](#tpmt_sig_scheme)](#tpmt_sig_scheme)

[11.2.2 Encryption Schemes
[128](#encryption-schemes)](#encryption-schemes)

[11.2.2.1 Introduction [128](#introduction-15)](#introduction-15)

[11.2.2.2 RSA Encryption Schemes
[128](#rsa-encryption-schemes)](#rsa-encryption-schemes)

[11.2.2.3 ECC Key Exchange Schemes
[129](#ecc-key-exchange-schemes)](#ecc-key-exchange-schemes)

[11.2.3 Key Derivation Schemes
[129](#key-derivation-schemes)](#key-derivation-schemes)

[11.2.3.1 Introduction [129](#introduction-16)](#introduction-16)

[11.2.3.2 TPMU_KDF_SCHEME [129](#tpmu_kdf_scheme)](#tpmu_kdf_scheme)

[11.2.3.3 TPMT_KDF_SCHEME [129](#tpmt_kdf_scheme)](#tpmt_kdf_scheme)

[11.2.3.4 TPMI_ALG_ASYM_SCHEME
[130](#tpmi_alg_asym_scheme)](#tpmi_alg_asym_scheme)

[11.2.3.5 TPMU_ASYM_SCHEME [130](#tpmu_asym_scheme)](#tpmu_asym_scheme)

[11.2.3.6 TPMT_ASYM_SCHEME [130](#tpmt_asym_scheme)](#tpmt_asym_scheme)

[11.2.4 RSA [131](#rsa)](#rsa)

[11.2.4.1 TPMI_ALG_RSA_SCHEME
[131](#tpmi_alg_rsa_scheme)](#tpmi_alg_rsa_scheme)

[11.2.4.2 TPMT_RSA_SCHEME [131](#tpmt_rsa_scheme)](#tpmt_rsa_scheme)

[11.2.4.3 TPMI_ALG_RSA_DECRYPT
[131](#tpmi_alg_rsa_decrypt)](#tpmi_alg_rsa_decrypt)

[11.2.4.4 TPMT_RSA_DECRYPT [131](#tpmt_rsa_decrypt)](#tpmt_rsa_decrypt)

[11.2.4.5 TPM2B_PUBLIC_KEY_RSA
[132](#tpm2b_public_key_rsa)](#tpm2b_public_key_rsa)

[11.2.4.6 TPMI_RSA_KEY_BITS
[132](#tpmi_rsa_key_bits)](#tpmi_rsa_key_bits)

[11.2.4.7 TPM2B_PRIVATE_KEY_RSA
[132](#tpm2b_private_key_rsa)](#tpm2b_private_key_rsa)

[11.2.5 ECC [133](#ecc)](#ecc)

[11.2.5.1 TPM2B_ECC_PARAMETER
[133](#tpm2b_ecc_parameter)](#tpm2b_ecc_parameter)

[11.2.5.2 TPMS_ECC_POINT [133](#tpms_ecc_point)](#tpms_ecc_point)

[11.2.5.3 TPM2B_ECC_POINT [133](#tpm2b_ecc_point)](#tpm2b_ecc_point)

[11.2.5.4 TPMI_ALG_ECC_SCHEME
[134](#tpmi_alg_ecc_scheme)](#tpmi_alg_ecc_scheme)

[11.2.5.5 TPMI_ECC_CURVE [134](#tpmi_ecc_curve)](#tpmi_ecc_curve)

[11.2.5.6 TPMT_ECC_SCHEME [134](#tpmt_ecc_scheme)](#tpmt_ecc_scheme)

[11.2.5.7 TPMS_ALGORITHM_DETAIL_ECC
[135](#tpms_algorithm_detail_ecc)](#tpms_algorithm_detail_ecc)

[11.3 Signatures [135](#signatures)](#signatures)

[11.3.1 TPMS_SIGNATURE_RSA
[135](#tpms_signature_rsa)](#tpms_signature_rsa)

[11.3.2 TPMS_SIGNATURE_ECC
[136](#tpms_signature_ecc)](#tpms_signature_ecc)

[11.3.3 TPMU_SIGNATURE [136](#tpmu_signature)](#tpmu_signature)

[11.3.4 TPMT_SIGNATURE [136](#tpmt_signature)](#tpmt_signature)

[11.4 Key/Secret Exchange
[137](#keysecret-exchange)](#keysecret-exchange)

[11.4.1 Introduction [137](#introduction-17)](#introduction-17)

[11.4.2 TPMU_ENCRYPTED_SECRET
[137](#tpmu_encrypted_secret)](#tpmu_encrypted_secret)

[11.4.3 TPM2B_ENCRYPTED_SECRET
[137](#tpm2b_encrypted_secret)](#tpm2b_encrypted_secret)

[12 Key/Object Complex [138](#keyobject-complex)](#keyobject-complex)

[12.1 Introduction [138](#keyobject-complex)](#keyobject-complex)

[12.2 Public Area Structures
[138](#public-area-structures)](#public-area-structures)

[12.2.1 Description [138](#description-2)](#description-2)

[12.2.2 TPMI_ALG_PUBLIC [138](#tpmi_alg_public)](#tpmi_alg_public)

[12.2.3 Type-Specific Parameters
[139](#type-specific-parameters)](#type-specific-parameters)

[12.2.3.1 Description [139](#description-3)](#description-3)

[12.2.3.2 TPMU_PUBLIC_ID [139](#tpmu_public_id)](#tpmu_public_id)

[12.2.3.3 TPMS_KEYEDHASH_PARMS
[140](#tpms_keyedhash_parms)](#tpms_keyedhash_parms)

[12.2.3.4 TPMS_ASYM_PARMS [140](#tpms_asym_parms)](#tpms_asym_parms)

[12.2.3.5 TPMS_RSA_PARMS [141](#tpms_rsa_parms)](#tpms_rsa_parms)

[12.2.3.6 TPMS_ECC_PARMS [142](#tpms_ecc_parms)](#tpms_ecc_parms)

[12.2.3.7 TPMU_PUBLIC_PARMS
[142](#tpmu_public_parms)](#tpmu_public_parms)

[12.2.3.8 TPMT_PUBLIC_PARMS
[143](#tpmt_public_parms)](#tpmt_public_parms)

[12.2.4 TPMT_PUBLIC [143](#tpmt_public)](#tpmt_public)

[12.2.5 TPM2B_PUBLIC [143](#tpm2b_public)](#tpm2b_public)

[12.2.6 TPM2B_TEMPLATE [144](#tpm2b_template)](#tpm2b_template)

[12.3 Private Area Structures
[144](#private-area-structures)](#private-area-structures)

[12.3.1 Introduction [144](#introduction-19)](#introduction-19)

[12.3.2 Sensitive Data Structures
[144](#sensitive-data-structures)](#sensitive-data-structures)

[12.3.2.1 Introduction [144](#introduction-20)](#introduction-20)

[12.3.2.2 TPM2B_PRIVATE_VENDOR_SPECIFIC
[144](#tpm2b_private_vendor_specific)](#tpm2b_private_vendor_specific)

[12.3.2.3 TPMU_SENSITIVE_COMPOSITE
[145](#tpmu_sensitive_composite)](#tpmu_sensitive_composite)

[12.3.2.4 TPMT_SENSITIVE [145](#tpmt_sensitive)](#tpmt_sensitive)

[12.3.3 TPM2B_SENSITIVE [145](#tpm2b_sensitive)](#tpm2b_sensitive)

[12.3.4 Encryption [146](#encryption)](#encryption)

[12.3.5 Integrity [146](#integrity)](#integrity)

[12.3.6 \_PRIVATE [146](#private)](#private)

[12.3.7 TPM2B_PRIVATE [146](#tpm2b_private)](#tpm2b_private)

[12.4 Identity Object [147](#identity-object)](#identity-object)

[12.4.1 Description [147](#description-4)](#description-4)

[12.4.2 TPMS_ID_OBJECT [147](#tpms_id_object)](#tpms_id_object)

[12.4.3 TPM2B_ID_OBJECT [147](#tpm2b_id_object)](#tpm2b_id_object)

[13 NV Storage Structures
[148](#nv-storage-structures)](#nv-storage-structures)

[13.1 TPM_NV_INDEX [148](#tpm_nv_index)](#tpm_nv_index)

[13.2 TPM_NT [149](#_Toc432512476)](#_Toc432512476)

[13.3 TPMS_NV_PIN_COUNTER_PARAMETERS
[149](#tpms_nv_pin_counter_parameters)](#tpms_nv_pin_counter_parameters)

[13.4 TPMA_NV (NV Index Attributes)
[149](#tpma_nv-nv-index-attributes)](#tpma_nv-nv-index-attributes)

[13.5 TPMS_NV_PUBLIC [153](#tpms_nv_public)](#tpms_nv_public)

[13.6 TPM2B_NV_PUBLIC [153](#tpm2b_nv_public)](#tpm2b_nv_public)

[14 Context Data [154](#context-data)](#context-data)

[14.1 Introduction [154](#introduction-21)](#introduction-21)

[14.2 TPM2B_CONTEXT_SENSITIVE
[154](#tpm2b_context_sensitive)](#tpm2b_context_sensitive)

[14.3 TPMS_CONTEXT_DATA [154](#tpms_context_data)](#tpms_context_data)

[14.4 TPM2B_CONTEXT_DATA
[154](#tpm2b_context_data)](#tpm2b_context_data)

[14.5 TPMS_CONTEXT [155](#tpms_context)](#tpms_context)

[14.6 Parameters of TPMS_CONTEXT
[156](#parameters-of-tpms_context)](#parameters-of-tpms_context)

[14.6.1 *sequence* [156](#sequence)](#sequence)

[14.6.2 *savedHandle* [156](#savedhandle)](#savedhandle)

[14.6.3 *hierarchy* [157](#hierarchy)](#hierarchy)

[14.7 Context Protection
[157](#context-protection)](#context-protection)

[14.7.1 Context Integrity [157](#context-integrity)](#context-integrity)

[14.7.2 Context Confidentiality
[157](#context-confidentiality)](#context-confidentiality)

[15 Creation Data [158](#creation-data)](#creation-data)

[15.1 TPMS_CREATION_DATA
[158](#tpms_creation_data)](#tpms_creation_data)

[15.2 TPM2B_CREATION_DATA
[158](#tpm2b_creation_data)](#tpm2b_creation_data)

[16 Attached Component Structures [159](#_Toc20317850)](#_Toc20317850)

[16.1 TPM_AT [159](#tpm_at)](#tpm_at)

[16.2 TPM_AE [159](#tpm_ae)](#tpm_ae)

[16.3 TPMS_AC_OUTPUT [159](#tpms_ac_output)](#tpms_ac_output)

[16.4 TPML_AC_CAPABILITIES
[160](#tpml_ac_capabilities)](#tpml_ac_capabilities)

Tables

[Table 1 — Name Prefix Convention [20](#_Toc380749690)](#_Toc380749690)

[Table 2 — Unmarshaling Errors [22](#_Ref328497210)](#_Ref328497210)

[Table 3 — Definition of Base Types
[23](#_Ref247782753)](#_Ref247782753)

[Table 4 — Defines for Logic Values
[23](#_Toc432512500)](#_Toc432512500)

[Table 5 — Definition of Types for Documentation Clarity
[24](#_Toc380749693)](#_Toc380749693)

[Table 6 — Definition of (UINT32) TPM_SPEC Constants \<\>
[25](#_Toc380749694)](#_Toc380749694)

[Table 7 — Definition of (UINT32) TPM_GENERATED Constants \<O\>
[25](#_Toc380749695)](#_Toc380749695)

[Table 8 — Legend for TPM_ALG_ID Table
[26](#_Toc379564855)](#_Toc379564855)

[Table 9 — Definition of (UINT16) TPM_ALG_ID Constants \<IN/OUT, S\>
[27](#_Toc278371153)](#_Toc278371153)

[Table 10 — Definition of (UINT16) {ECC} TPM_ECC_CURVE Constants
\<IN/OUT\> [30](#_Ref335120390)](#_Ref335120390)

[Table 11 — TPM Command Format Fields Description
[30](#_Toc380749699)](#_Toc380749699)

[Table 12 — Definition of (UINT32) TPM_CC Constants (Numeric Order)
\<IN/OUT, S\> [31](#_Ref518051117)](#_Ref518051117)

[Table 13 — Format-Zero Response Codes
[36](#_Ref283479355)](#_Ref283479355)

[Table 14 — Format-One Response Codes
[37](#_Toc380749703)](#_Toc380749703)

[Table 15 — Response Code Groupings
[37](#_Ref278372048)](#_Ref278372048)

[Table 16 — Definition of (UINT32) TPM_RC Constants (Actions) \<OUT\>
[38](#_Ref282778736)](#_Ref282778736)

[Table 17 — Definition of (INT8) TPM_CLOCK_ADJUST Constants \<IN\>
[43](#_Toc380749706)](#_Toc380749706)

[Table 18 — Definition of (UINT16) TPM_EO Constants \<IN/OUT\>
[43](#_Toc380749707)](#_Toc380749707)

[Table 19 — Definition of (UINT16) TPM_ST Constants \<IN/OUT, S\>
[45](#_Ref214083845)](#_Ref214083845)

[Table 20 — Definition of (UINT16) TPM_SU Constants \<IN\>
[47](#_Ref291502828)](#_Ref291502828)

[Table 21 — Definition of (UINT8) TPM_SE Constants \<IN\>
[47](#_Toc380749710)](#_Toc380749710)

[Table 22 — Definition of (UINT32) TPM_CAP Constants
[48](#_Toc380749711)](#_Toc380749711)

[Table 23 — Definition of (UINT32) TPM_PT Constants \<IN/OUT, S\>
[49](#_Toc380749712)](#_Toc380749712)

[Table 24 — Definition of (UINT32) TPM_PT_PCR Constants \<IN/OUT, S\>
[54](#_Toc380749713)](#_Toc380749713)

[Table 25 — Definition of (UINT32) TPM_PS Constants \<OUT\>
[56](#_Ref294624520)](#_Ref294624520)

[Table 26 — Definition of Types for Handles
[57](#_Toc380749715)](#_Toc380749715)

[Table 27 — Definition of (UINT8) TPM_HT Constants \<S\>
[57](#_Ref283540608)](#_Ref283540608)

[Table 28 — Definition of (TPM_HANDLE) TPM_RH Constants \<S\>
[59](#_Ref284246076)](#_Ref284246076)

[Table 29 — Definition of (TPM_HANDLE) TPM_HC Constants \<S\>
[61](#_Ref286043143)](#_Ref286043143)

[Table 30 — Definition of (UINT32) TPMA_ALGORITHM Bits
[63](#_Toc380749719)](#_Toc380749719)

[Table 31 — Definition of (UINT32) TPMA_OBJECT Bits
[64](#_Ref213575138)](#_Ref213575138)

[Table 32 — Definition of (UINT8) TPMA_SESSION Bits \<IN/OUT\>
[71](#_Toc384651383)](#_Toc384651383)

[Table 33 — Definition of (UINT8) TPMA_LOCALITY Bits \<IN/OUT\>
[73](#_Toc380749722)](#_Toc380749722)

[Table 34 — Definition of (UINT32) TPMA_PERMANENT Bits \<OUT\>
[74](#_Toc380749723)](#_Toc380749723)

[Table 35 — Definition of (UINT32) TPMA_STARTUP_CLEAR Bits \<OUT\>
[75](#_Toc380749724)](#_Toc380749724)

[Table 36 — Definition of (UINT32) TPMA_MEMORY Bits \<Out\>
[76](#_Toc380749725)](#_Toc380749725)

[Table 37 — Definition of (TPM_CC) TPMA_CC Bits \<OUT\>
[77](#_Ref435084841)](#_Ref435084841)

[Table 38 — Definition of (UINT32) TPMA_MODES Bits \<Out\>
[79](#_Toc432512534)](#_Toc432512534)

[Table 39 — Definition of (UINT32) TPMA_X509_KEY_USAGE Bits\<\>
[80](#_Toc21376086)](#_Toc21376086)

[Table 40 — Definition of (UINT32) TPMA_ACT Bits
[81](#_Toc21376087)](#_Toc21376087)

[Table 41 — Definition of (BYTE) TPMI_YES_NO Type
[82](#_Toc380749727)](#_Toc380749727)

[Table 42 — Definition of (TPM_HANDLE) TPMI_DH_OBJECT Type
[82](#_Toc380749728)](#_Toc380749728)

[Table 43 — Definition of (TPM_HANDLE) TPMI_DH_PARENT Type
[83](#_Toc470518115)](#_Toc470518115)

[Table 44 — Definition of (TPM_HANDLE) TPMI_DH_PERSISTENT Type
[83](#_Toc380749729)](#_Toc380749729)

[Table 45 — Definition of (TPM_HANDLE) TPMI_DH_ENTITY Type \<IN\>
[84](#_Toc380749730)](#_Toc380749730)

[Table 46 — Definition of (TPM_HANDLE) TPMI_DH_PCR Type \<IN\>
[84](#_Toc380749731)](#_Toc380749731)

[Table 47 — Definition of (TPM_HANDLE) TPMI_SH_AUTH_SESSION Type
\<IN/OUT\> [85](#_Toc380749732)](#_Toc380749732)

[Table 48 — Definition of (TPM_HANDLE) TPMI_SH_HMAC Type \<IN/OUT\>
[85](#_Toc380749733)](#_Toc380749733)

[Table 49 — Definition of (TPM_HANDLE) TPMI_SH_POLICY Type \<IN/OUT\>
[85](#_Toc380749734)](#_Toc380749734)

[Table 50 — Definition of (TPM_HANDLE) TPMI_DH_CONTEXT Type
[85](#_Toc380749735)](#_Toc380749735)

[Table 51 — Definition of (TPM_HANDLE) TPMI_DH_SAVED Type
[86](#_Toc516155165)](#_Toc516155165)

[Table 52 — Definition of (TPM_HANDLE) TPMI_RH_HIERARCHY Type
[86](#_Toc380749736)](#_Toc380749736)

[Table 53 — Definition of (TPM_HANDLE) TPMI_RH_ENABLES Type
[86](#_Toc380749737)](#_Toc380749737)

[Table 54 — Definition of (TPM_HANDLE) TPMI_RH_HIERARCHY_AUTH Type
\<IN\> [87](#_Toc380749738)](#_Toc380749738)

[Table 55 — Definition of (TPM_HANDLE) TPMI_RH_HIERARCHY_POLICY Type
\<IN\> [87](#_Toc21376102)](#_Toc21376102)

[Table 56 — Definition of (TPM_HANDLE) TPMI_RH_PLATFORM Type \<IN\>
[87](#_Toc380749739)](#_Toc380749739)

[Table 57 — Definition of (TPM_HANDLE) TPMI_RH_OWNER Type \<IN\>
[88](#_Toc380749740)](#_Toc380749740)

[Table 58 — Definition of (TPM_HANDLE) TPMI_RH_ENDORSEMENT Type \<IN\>
[88](#_Toc380749741)](#_Toc380749741)

[Table 59 — Definition of (TPM_HANDLE) TPMI_RH_PROVISION Type \<IN\>
[88](#_Ref245089346)](#_Ref245089346)

[Table 60 — Definition of (TPM_HANDLE) TPMI_RH_CLEAR Type \<IN\>
[89](#_Toc380749743)](#_Toc380749743)

[Table 61 — Definition of (TPM_HANDLE) TPMI_RH_NV_AUTH Type \<IN\>
[89](#_Toc380749744)](#_Toc380749744)

[Table 62 — Definition of (TPM_HANDLE) TPMI_RH_LOCKOUT Type \<IN\>
[89](#_Toc380749745)](#_Toc380749745)

[Table 63 — Definition of (TPM_HANDLE) TPMI_RH_NV_INDEX Type \<IN/OUT\>
[90](#_Toc380749746)](#_Toc380749746)

[Table 64 — Definition of (TPM_HANDLE) TPMI_RH_AC Type \<IN\>
[90](#_Toc470518134)](#_Toc470518134)

[Table 65 — Definition of (TPM_HANDLE) TPMI_RH_ACT Type
[91](#_Toc21376112)](#_Toc21376112)

[Table 66 — Definition of (TPM_ALG_ID) TPMI_ALG_HASH Type
[91](#_Ref248023934)](#_Ref248023934)

[Table 67 — Definition of (TPM_ALG_ID) TPMI_ALG_ASYM Type
[91](#_Ref307234064)](#_Ref307234064)

[Table 68 — Definition of (TPM_ALG_ID) TPMI_ALG_SYM Type
[92](#_Toc380749749)](#_Toc380749749)

[Table 69 — Definition of (TPM_ALG_ID) TPMI_ALG_SYM_OBJECT Type
[92](#_Ref307234311)](#_Ref307234311)

[Table 70 — Definition of (TPM_ALG_ID) TPMI_ALG_SYM_MODE Type
[92](#_Toc380749751)](#_Toc380749751)

[Table 71 — Definition of (TPM_ALG_ID) TPMI_ALG_KDF Type
[93](#_Ref307235867)](#_Ref307235867)

[Table 72 — Definition of (TPM_ALG_ID) TPMI_ALG_SIG_SCHEME Type
[93](#_Toc380749753)](#_Toc380749753)

[Table 73 — Definition of (TPM_ALG_ID){ECC} TPMI_ECC_KEY_EXCHANGE Type
[93](#_Toc380749754)](#_Toc380749754)

[Table 74 — Definition of (TPM_ST) TPMI_ST_COMMAND_TAG Type
[94](#_Toc380749755)](#_Toc380749755)

[Table 75 — Definition of (TPM_ALG_ID) TPMI_ALG_MAC_SCHEME Type
[94](#_Toc516155187)](#_Toc516155187)

[Table 76 — Definition of (TPM_ALG_ID) TPMI_ALG_CIPHER_MODE Type
[94](#_Toc516155188)](#_Toc516155188)

[Table 77 — Definition of TPMS_EMPTY Structure \<IN/OUT\>
[95](#_Toc380749756)](#_Toc380749756)

[Table 78 — Definition of TPMS_ALGORITHM_DESCRIPTION Structure \<OUT\>
[95](#_Toc380749757)](#_Toc380749757)

[Table 79 — Definition of TPMU_HA Union \<IN/OUT \>
[95](#_Toc384651420)](#_Toc384651420)

[Table 80 — Definition of TPMT_HA Structure \<IN/OUT\>
[96](#_Ref213995262)](#_Ref213995262)

[Table 81 — Definition of TPM2B_DIGEST Structure
[97](#_Toc380749760)](#_Toc380749760)

[Table 82 — Definition of TPM2B_DATA Structure
[97](#_Toc380749761)](#_Toc380749761)

[Table 83 — Definition of Types for TPM2B_NONCE
[97](#_Toc380749762)](#_Toc380749762)

[Table 84 — Definition of Types for TPM2B_AUTH
[97](#_Toc380749763)](#_Toc380749763)

[Table 85 — Definition of Types for TPM2B_OPERAND
[98](#_Toc380749764)](#_Toc380749764)

[Table 86 — Definition of TPM2B_EVENT Structure
[98](#_Toc380749765)](#_Toc380749765)

[Table 87 — Definition of TPM2B_MAX_BUFFER Structure
[98](#_Toc380749766)](#_Toc380749766)

[Table 88 — Definition of TPM2B_MAX_NV_BUFFER Structure
[98](#_Toc380749767)](#_Toc380749767)

[Table 89 — Definition of TPM2B_TIMEOUT Structure
[99](#_Toc432512576)](#_Toc432512576)

[Table 90 — Definition of TPM2B_IV Structure \<IN/OUT\>
[99](#_Toc380749769)](#_Toc380749769)

[Table 91 — Definition of TPMU_NAME Union \<\>
[99](#_Toc380749770)](#_Toc380749770)

[Table 92 — Definition of TPM2B_NAME Structure
[100](#_Toc380749771)](#_Toc380749771)

[Table 93 — Definition of TPMS_PCR_SELECT Structure
[101](#_Toc380749772)](#_Toc380749772)

[Table 94 — Definition of TPMS_PCR_SELECTION Structure
[101](#_Toc380749773)](#_Toc380749773)

[Table 95 — Values for *proof* Used in Tickets
[102](#_Ref294969840)](#_Ref294969840)

[Table 96 — General Format of a Ticket
[102](#_Ref294969896)](#_Ref294969896)

[Table 97 — Definition of TPMT_TK_CREATION Structure
[103](#_Toc380749776)](#_Toc380749776)

[Table 98 — Definition of TPMT_TK_VERIFIED Structure
[103](#_Toc380749777)](#_Toc380749777)

[Table 99 — Definition of TPMT_TK_AUTH Structure
[104](#_Toc470518166)](#_Toc470518166)

[Table 100 — Definition of TPMT_TK_HASHCHECK Structure
[105](#_Toc380749779)](#_Toc380749779)

[Table 101 — Definition of TPMS_ALG_PROPERTY Structure \<OUT\>
[105](#_Toc380749780)](#_Toc380749780)

[Table 102 — Definition of TPMS_TAGGED_PROPERTY Structure \<OUT\>
[105](#_Toc380749781)](#_Toc380749781)

[Table 103 — Definition of TPMS_TAGGED_PCR_SELECT Structure \<OUT\>
[106](#_Toc380749782)](#_Toc380749782)

[Table 104 — Definition of TPMS_TAGGED_POLICY Structure \<OUT\>
[106](#_Toc450655450)](#_Toc450655450)

[Table 105 — Definition of TPMS_ACT_DATA Structure \<OUT\>
[106](#_Toc536540074)](#_Toc536540074)

[Table 106 — Definition of TPML_CC Structure
[107](#_Toc380749783)](#_Toc380749783)

[Table 107 — Definition of TPML_CCA Structure \<OUT\>
[107](#_Toc380749784)](#_Toc380749784)

[Table 108 — Definition of TPML_ALG Structure
[107](#_Toc380749785)](#_Toc380749785)

[Table 109 — Definition of TPML_HANDLE Structure \<OUT\>
[108](#_Toc380749786)](#_Toc380749786)

[Table 110 — Definition of TPML_DIGEST Structure
[108](#_Toc380749787)](#_Toc380749787)

[Table 111 — Definition of TPML_DIGEST_VALUES Structure
[109](#_Toc380749788)](#_Toc380749788)

[Table 112 — Definition of TPML_PCR_SELECTION Structure
[109](#_Toc380749790)](#_Toc380749790)

[Table 113 — Definition of TPML_ALG_PROPERTY Structure \<OUT\>
[110](#_Toc380749791)](#_Toc380749791)

[Table 114 — Definition of TPML_TAGGED_TPM_PROPERTY Structure \<OUT\>
[110](#_Toc380749792)](#_Toc380749792)

[Table 115 — Definition of TPML_TAGGED_PCR_PROPERTY Structure \<OUT\>
[110](#_Toc380749793)](#_Toc380749793)

[Table 116 — Definition of {ECC} TPML_ECC_CURVE Structure \<OUT\>
[110](#_Toc380749794)](#_Toc380749794)

[Table 117 — Definition of TPML_TAGGED_POLICY Structure \<OUT\>
[111](#_Toc451196367)](#_Toc451196367)

[Table 118 — Definition of TPML_ACT_DATA Structure \<OUT\>
[111](#_Toc536540086)](#_Toc536540086)

[Table 119 — Definition of TPMU_CAPABILITIES Union \<OUT\>
[112](#_Toc380749795)](#_Toc380749795)

[Table 120 — Definition of TPMS_CAPABILITY_DATA Structure \<OUT\>
[112](#_Toc380749796)](#_Toc380749796)

[Table 121 — Definition of TPMS_CLOCK_INFO Structure
[113](#_Toc380749797)](#_Toc380749797)

[Table 122 — Definition of TPMS_TIME_INFO Structure
[114](#_Toc380749798)](#_Toc380749798)

[Table 123 — Definition of TPMS_TIME_ATTEST_INFO Structure \<OUT\>
[115](#_Toc380749799)](#_Toc380749799)

[Table 124 — Definition of TPMS_CERTIFY_INFO Structure \<OUT\>
[115](#_Toc380749800)](#_Toc380749800)

[Table 125 — Definition of TPMS_QUOTE_INFO Structure \<OUT\>
[115](#_Ref225426227)](#_Ref225426227)

[Table 126 — Definition of TPMS_COMMAND_AUDIT_INFO Structure \<OUT\>
[116](#_Toc380749802)](#_Toc380749802)

[Table 127 — Definition of TPMS_SESSION_AUDIT_INFO Structure \<OUT\>
[116](#_Toc380749803)](#_Toc380749803)

[Table 128 — Definition of TPMS_CREATION_INFO Structure \<OUT\>
[116](#_Toc380749804)](#_Toc380749804)

[Table 129 — Definition of TPMS_NV_CERTIFY_INFO Structure \<OUT\>
[116](#_Toc380749805)](#_Toc380749805)

[Table 130 — Definition of TPMS_NV_DIGEST_CERTIFY_INFO Structure \<OUT\>
[117](#_Toc21376177)](#_Toc21376177)

[Table 131 — Definition of (TPM_ST) TPMI_ST_ATTEST Type \<OUT\>
[117](#_Toc380749806)](#_Toc380749806)

[Table 132 — Definition of TPMU_ATTEST Union \<OUT\>
[117](#_Toc380749807)](#_Toc380749807)

[Table 133 — Definition of TPMS_ATTEST Structure \<OUT\>
[118](#_Toc380749808)](#_Toc380749808)

[Table 134 — Definition of TPM2B_ATTEST Structure \<OUT\>
[119](#_Toc380749809)](#_Toc380749809)

[Table 135 — Definition of TPMS_AUTH_COMMAND Structure \<IN\>
[119](#_Toc380749810)](#_Toc380749810)

[Table 136 — Definition of TPMS_AUTH_RESPONSE Structure \<OUT\>
[119](#_Toc380749811)](#_Toc380749811)

[Table 137 — Definition of {!ALG.S} (TPM_KEY_BITS) TPMI\_!ALG.S_KEY_BITS
Type [120](#_Toc384651474)](#_Toc384651474)

[Table 138 — Definition of TPMU_SYM_KEY_BITS Union
[120](#_Toc380749814)](#_Toc380749814)

[Table 139 — Definition of TPMU_SYM_MODE Union
[121](#_Toc380749815)](#_Toc380749815)

[Table 140 —xDefinition of TPMU_SYM_DETAILS Union
[121](#_Toc380749816)](#_Toc380749816)

[Table 141 — Definition of TPMT_SYM_DEF Structure
[122](#_Ref416449301)](#_Ref416449301)

[Table 142 — Definition of TPMT_SYM_DEF_OBJECT Structure
[122](#_Toc380749818)](#_Toc380749818)

[Table 143 — Definition of TPM2B_SYM_KEY Structure
[123](#_Toc432512626)](#_Toc432512626)

[Table 144 — Definition of TPMS_SYMCIPHER_PARMS Structure
[123](#_Toc380749820)](#_Toc380749820)

[Table 145 — Definition of TPM2B_LABEL Structure
[123](#_Toc470518209)](#_Toc470518209)

[Table 146 — Definition of TPMS_DERIVE Structure
[123](#_Toc470518210)](#_Toc470518210)

[Table 147 — Definition of TPM2B_DERIVE Structure
[124](#_Toc470518211)](#_Toc470518211)

[Table 148 — Definition of TPMU_SENSITIVE_CREATE Union \<\>
[124](#_Toc470518212)](#_Toc470518212)

[Table 149 — Definition of TPM2B_SENSITIVE_DATA Structure
[124](#_Toc380749821)](#_Toc380749821)

[Table 150 — Definition of TPMS_SENSITIVE_CREATE Structure \<IN\>
[125](#_Toc380749822)](#_Toc380749822)

[Table 151 — Definition of TPM2B_SENSITIVE_CREATE Structure \<IN, S\>
[125](#_Toc380749823)](#_Toc380749823)

[Table 152 — Definition of TPMS_SCHEME_HASH Structure
[125](#_Toc380749824)](#_Toc380749824)

[Table 153 — Definition of {ECC} TPMS_SCHEME_ECDAA Structure
[126](#_Toc432512632)](#_Toc432512632)

[Table 154 — Definition of (TPM_ALG_ID) TPMI_ALG_KEYEDHASH_SCHEME Type
[126](#_Toc380749825)](#_Toc380749825)

[Table 155 — Definition of Types for HMAC_SIG_SCHEME
[126](#_Toc380749826)](#_Toc380749826)

[Table 156 — Definition of TPMS_SCHEME_XOR Structure
[126](#_Toc380749827)](#_Toc380749827)

[Table 157 — Definition of TPMU_SCHEME_KEYEDHASH Union \<IN/OUT \>
[127](#_Toc380749828)](#_Toc380749828)

[Table 158 — Definition of TPMT_KEYEDHASH_SCHEME Structure
[127](#_Toc380749829)](#_Toc380749829)

[Table 159 — Definition of {RSA} Types for RSA Signature Schemes
[128](#_Ref386448866)](#_Ref386448866)

[Table 160 — Definition of {ECC} Types for ECC Signature Schemes
[128](#_Ref386448781)](#_Ref386448781)

[Table 161 — Definition of TPMU_SIG_SCHEME Union \<IN/OUT \>
[129](#_Toc380749833)](#_Toc380749833)

[Table 162 — Definition of TPMT_SIG_SCHEME Structure
[129](#_Toc380749834)](#_Toc380749834)

[Table 163 — Definition of Types for {RSA} Encryption Schemes
[129](#_Toc432512642)](#_Toc432512642)

[Table 164 — Definition of Types for {ECC} ECC Key Exchange
[130](#_Toc432512643)](#_Toc432512643)

[Table 165 — Definition of Types for KDF Schemes
[130](#_Toc432512644)](#_Toc432512644)

[Table 166 — Definition of TPMU_KDF_SCHEME Union \<IN/OUT\>
[130](#_Toc432512645)](#_Toc432512645)

[Table 167 — Definition of TPMT_KDF_SCHEME Structure
[130](#_Toc380749842)](#_Toc380749842)

[Table 168 — Definition of (TPM_ALG_ID) TPMI_ALG_ASYM_SCHEME Type \<IO\>
[131](#_Toc380749843)](#_Toc380749843)

[Table 169 — Definition of TPMU_ASYM_SCHEME Union
[131](#_Toc380749844)](#_Toc380749844)

[Table 170 — Definition of TPMT_ASYM_SCHEME Structure \<\>
[132](#_Toc380749845)](#_Toc380749845)

[Table 171 — Definition of (TPM_ALG_ID) {RSA} TPMI_ALG_RSA_SCHEME Type
[132](#_Toc380749846)](#_Toc380749846)

[Table 172 — Definition of {RSA} TPMT_RSA_SCHEME Structure
[132](#_Toc380749847)](#_Toc380749847)

[Table 173 — Definition of (TPM_ALG_ID) {RSA} TPMI_ALG_RSA_DECRYPT Type
[132](#_Ref365138834)](#_Ref365138834)

[Table 174 — Definition of {RSA} TPMT_RSA_DECRYPT Structure
[132](#_Toc380749849)](#_Toc380749849)

[Table 175 — Definition of {RSA} TPM2B_PUBLIC_KEY_RSA Structure
[133](#_Toc380749850)](#_Toc380749850)

[Table 176 — Definition of {RSA} (TPM_KEY_BITS) TPMI_RSA_KEY_BITS Type
[133](#_Toc380749851)](#_Toc380749851)

[Table 177 — Definition of {RSA} TPM2B_PRIVATE_KEY_RSA Structure
[133](#_Toc380749852)](#_Toc380749852)

[Table 178 — Definition of TPM2B_ECC_PARAMETER Structure
[134](#_Toc380749853)](#_Toc380749853)

[Table 179 — Definition of {ECC} TPMS_ECC_POINT Structure
[134](#_Toc380749854)](#_Toc380749854)

[Table 180 — Definition of {ECC} TPM2B_ECC_POINT Structure
[134](#_Toc380749855)](#_Toc380749855)

[Table 181 — Definition of (TPM_ALG_ID) {ECC} TPMI_ALG_ECC_SCHEME Type
[135](#_Toc380749856)](#_Toc380749856)

[Table 182 — Definition of {ECC} (TPM_ECC_CURVE) TPMI_ECC_CURVE Type
[135](#_Toc380749857)](#_Toc380749857)

[Table 183 — Definition of (TPMT_SIG_SCHEME) {ECC} TPMT_ECC_SCHEME
Structure [135](#_Toc380749858)](#_Toc380749858)

[Table 184 — Definition of {ECC} TPMS_ALGORITHM_DETAIL_ECC Structure
\<OUT\> [136](#_Toc380749859)](#_Toc380749859)

[Table 185 — Definition of {RSA} TPMS_SIGNATURE_RSA Structure
[136](#_Toc380749860)](#_Toc380749860)

[Table 186 — Definition of Types for {RSA} Signature
[136](#_Toc432512665)](#_Toc432512665)

[Table 187 — Definition of {ECC} TPMS_SIGNATURE_ECC Structure
[137](#_Toc380749862)](#_Toc380749862)

[Table 188 — Definition of Types for {ECC} TPMS_SIGNATURE_ECC
[137](#_Toc432512667)](#_Toc432512667)

[Table 189 — Definition of TPMU_SIGNATURE Union \<IN/OUT\>
[137](#_Ref259714628)](#_Ref259714628)

[Table 190 — Definition of TPMT_SIGNATURE Structure
[137](#_Ref291846412)](#_Ref291846412)

[Table 191 — Definition of TPMU_ENCRYPTED_SECRET Union
[138](#_Ref307333263)](#_Ref307333263)

[Table 192 — Definition of TPM2B_ENCRYPTED_SECRET Structure
[138](#_Toc380749866)](#_Toc380749866)

[Table 193 — Definition of (TPM_ALG_ID) TPMI_ALG_PUBLIC Type
[139](#_Toc380749867)](#_Toc380749867)

[Table 194 — Definition of TPMU_PUBLIC_ID Union \<IN/OUT\>
[140](#_Toc380749868)](#_Toc380749868)

[Table 195 — Definition of TPMS_KEYEDHASH_PARMS Structure
[141](#_Toc380749869)](#_Toc380749869)

[Table 196 — Definition of TPMS_ASYM_PARMS Structure \<\>
[141](#_Toc380749870)](#_Toc380749870)

[Table 197 — Definition of {RSA} TPMS_RSA_PARMS Structure
[142](#_Toc380749871)](#_Toc380749871)

[Table 198 — Definition of {ECC} TPMS_ECC_PARMS Structure
[143](#_Toc380749872)](#_Toc380749872)

[Table 199 — Definition of TPMU_PUBLIC_PARMS Union \<IN/OUT\>
[143](#_Ref247962010)](#_Ref247962010)

[Table 200 — Definition of TPMT_PUBLIC_PARMS Structure
[144](#_Ref307337336)](#_Ref307337336)

[Table 201 — Definition of TPMT_PUBLIC Structure
[144](#_Ref246771133)](#_Ref246771133)

[Table 202 — Definition of TPM2B_PUBLIC Structure
[144](#_Ref214420523)](#_Ref214420523)

[Table 203 — Definition of TPM2B_TEMPLATE Structure
[145](#_Ref428437970)](#_Ref428437970)

[Table 204 — Definition of TPM2B_PRIVATE_VENDOR_SPECIFIC Structure
[145](#_Toc380749877)](#_Toc380749877)

[Table 205 — Definition of TPMU_SENSITIVE_COMPOSITE Union \<IN/OUT\>
[146](#_Toc380749878)](#_Toc380749878)

[Table 206 — Definition of TPMT_SENSITIVE Structure
[146](#_Toc380749879)](#_Toc380749879)

[Table 207 — Definition of TPM2B_SENSITIVE Structure \<IN/OUT\>
[146](#_Toc380749880)](#_Toc380749880)

[Table 208 — Definition of \_PRIVATE Structure \<\>
[147](#_Ref227144447)](#_Ref227144447)

[Table 209 — Definition of TPM2B_PRIVATE Structure \<IN/OUT\>
[147](#_Toc380749882)](#_Toc380749882)

[Table 210 — Definition of TPMS_ID_OBJECT Structure \<\>
[148](#_Toc380749883)](#_Toc380749883)

[Table 211 — Definition of TPM2B_ID_OBJECT Structure \<IN/OUT\>
[148](#_Toc380749884)](#_Toc380749884)

[Table 212 — Definition of (UINT32) TPM_NV_INDEX Bits \<\>
[149](#_Toc380749885)](#_Toc380749885)

[Table 213 — Definition of TPM_NT Constants
[150](#_Ref443726496)](#_Ref443726496)

[Table 214 — Definition of TPMS_NV_PIN_COUNTER_PARAMETERS Structure
[150](#_Toc432512694)](#_Toc432512694)

[Table 215 — Definition of (UINT32) TPMA_NV Bits
[152](#_Ref402873547)](#_Ref402873547)

[Table 216 — Definition of TPMS_NV_PUBLIC Structure
[154](#_Toc380749887)](#_Toc380749887)

[Table 217 — Definition of TPM2B_NV_PUBLIC Structure
[154](#_Toc380749888)](#_Toc380749888)

[Table 218 — Definition of TPM2B_CONTEXT_SENSITIVE Structure \<IN/OUT\>
[155](#_Toc380749889)](#_Toc380749889)

[Table 219 — Definition of TPMS_CONTEXT_DATA Structure \<IN/OUT\>
[155](#_Toc380749890)](#_Toc380749890)

[Table 220 — Definition of TPM2B_CONTEXT_DATA Structure \<IN/OUT\>
[155](#_Toc380749891)](#_Toc380749891)

[Table 221 — Definition of TPMS_CONTEXT Structure
[156](#_Toc380749892)](#_Toc380749892)

[Table 222 — Context Handle Values
[157](#_Ref307386359)](#_Ref307386359)

[Table 223 — Definition of TPMS_CREATION_DATA Structure \<OUT\>
[159](#_Ref236972116)](#_Ref236972116)

[Table 224 — Definition of TPM2B_CREATION_DATA Structure \<OUT\>
[159](#_Toc380749895)](#_Toc380749895)

[Table 225 — Definition of (UINT32) TPM_AT Constants
[160](#_Ref473897953)](#_Ref473897953)

[Table 226 — Definition of (UINT32) TPM_AE Constants \<OUT\>
[160](#_Toc516155335)](#_Toc516155335)

[Table 227 — Definition of TPMS_AC_OUTPUT Structure \<OUT\>
[160](#_Toc516155336)](#_Toc516155336)

[Table 228 — Definition of TPML_AC_CAPABILITIES Structure \<OUT\>
[161](#_Toc470518291)](#_Toc470518291)

Figures

[Figure 1 — Command Format [30](#_Ref345831282)](#_Ref345831282)

[Figure 2 — Format-Zero Response Codes
[36](#_Ref245368011)](#_Ref245368011)

[Figure 3 — Format-One Response Codes
[36](#_Ref291794972)](#_Ref291794972)

[Figure 4 — TPM 1.2 TPM_NV_INDEX [148](#_Ref235403879)](#_Ref235403879)

[Figure 5 — TPM 2.0 TPM_NV_INDEX [148](#_Ref235403989)](#_Ref235403989)

Trusted Platform Module Library

Part 2: Structures

# Scope

This part of the *Trusted Platform Module Library* specification
contains the definitions of the constants, flags, structure, and union
definitions used to communicate with the TPM. Values defined in this
document are used by the TPM commands defined in TPM 2.0 Part 3:
*Commands* and by the functions in TPM 2.0 Part 4: *Supporting
Routines*.

NOTE The structures in this document are the canonical form of the
structures on the interface. All structures are "packed" with no octets
of padding between structure elements. The TPM-internal form of the
structures is dependent on the processor and compiler for the TPM
implementation.

# Terms and definitions

For the purposes of this document, the terms and definitions given in
TPM 2.0 Part 1 apply.

# Symbols and abbreviated terms

For the purposes of this document, the symbols and abbreviated terms
given in TPM 2.0 Part 1 apply.

# Notation

## Introduction

The information in this document is formatted so that it may be
converted to standard computer-language formats by an automated process.
The purpose of this automated process is to minimize the transcription
errors that often occur during the conversion process.

For the purposes of this document, the conventions given in TPM 2.0 Part
1 apply.

In addition, the conventions and notations in clause 4 describe the
representation of various data so that it is both human readable and
amenable to automated processing.

When a table row contains the keyword “reserved” (all lower case) in
columns 1 or 2, the tools will not produce any values for the row in the
table.

NOTE The unmarshaling code examples are the actual code that would be
produced by the automatic code generator used in the construction of the
reference code. The actual code contains additional parameter checking
that is omitted for clarity of the principle being illustrated. Actual
examples of the code are found in TPM 2.0 Part 4.

## Named Constants

A named constant is a numeric value to which a name has been assigned.
In the C language, this is done with a \#define statement. In this
specification, a named constant is defined in a table that has a title
that starts with “Definition” and ends with “Constants.”

The table title will indicate the name of the class of constants that
are being defined in the table. When applicable, the title will include
the data type of the constants in parentheses.

The table in Example 1 names a collection of 16-bit constants and
Example 2 shows the C code that might be produced from that table by an
automated process.

NOTE A named constant (**\#define**) has no data type in C and an
enumeration would be a better choice for many of the defined constants.
However, the C language does not allow an enumerated type to have a
storage type other than **int** so the method of using a combination of
**typedef** and **\#define** is used.

EXAMPLE 1

Table xx — Definition of (UINT16) COUNTING Constants

|           |        |                                                         |
|-----------|--------|---------------------------------------------------------|
| Parameter | Value  | Description                                             |
| first     | 1      | decimal value is implicitly the size of the             |
| second    | 0x0002 | hex value will match the number of bits in the constant |
| third     | 3      |                                                         |
| fourth    | 0x0004 |                                                         |

EXAMPLE 2

/\* The C language equivalent of the constants from the table above \*/

typedef UINT16 COUNTING;

\#define first 1

\#define second 0x0002

\#define third 3

\#define fourth 0x0004

## Data Type Aliases (typedefs)

When a group of named items is assigned a type, it is placed in a table
that has a title starting with “Definition of Types.” In this
specification, defined types have names that use all upper-case
characters.

The table in Example 1 shows how typedefs would be defined in this
specification and Example 2 shows the C-compatible code that might be
produced from that table by an automated process.

EXAMPLE 1

Table xx — Definition of Types for Some Purpose

|                |           |             |
|----------------|-----------|-------------|
| Type           | Name      | Description |
| unsigned short | UINT16    |             |
| UINT16         | SOME_TYPE |             |
| unsigned long  | UINT32    |             |
| UINT32         | LAST_TYPE |             |

EXAMPLE 2

/\* C language equivalent of the typedefs from the table above \*/

typedef unsigned short UINT16;

typedef UINT16 SOME_TYPE;

typedef unsigned long UINT32;

typedef UINT32 LAST_TYPE;

## Enumerations

A table that defines an enumerated data type will start with the word
“Definition” and end with “Values.”

A value in parenthesis will denote the intrinsic data size of the value
and may have the values "INT8", "UINT8", "INT16", “UINT16”, "INT32", and
“UINT32.” If this value is not present, “UINT16” is assumed.

Most C compilers set the type of an enumerated value to be an integer on
the machine – often 16 bits – but this is not always consistent. To
ensure interoperability, the enumeration values may not exceed 32,384.

The table in Example 1 shows how an enumeration would be defined in this
specification. Example 2 shows the C code that might be produced from
that table by an automated process.

EXAMPLE 1

Table xx — Definition of (UINT16) CARD_SUIT Values

|            |        |             |
|------------|--------|-------------|
| Suit Names | Value  | Description |
| CLUBS      | 0x0000 |             |
| DIAMONDS   | 0x000D |             |
| HEARTS     | 0x001A |             |
| SPADES     | 0x0027 |             |

EXAMPLE 2

/\* C language equivalent of the structure defined in the table above
\*/

typedef enum {

CLUBS = 0x0000,

DIAMONDS = 0x000D,

HEARTS = 0x001A,

SPADES = 0x0027

} CARD_SUIT;

## Interface Type

An interface type is used for an enumeration that is checked by the
unmarshaling code. This type is defined for purposes of automatic
generation of the code that will validate the type. The title will start
with the keyword “Definition” and end with the keyword “Type.” A value
in parenthesis indicates the base type of the interface. The table may
contain an entry that is prefixed with the “#” character to indicate the
response code if the validation code determines that the input parameter
is the wrong type.

EXAMPLE 1

Table xx — Definition of (CARD_SUIT) RED_SUIT Type

<table>
<colgroup>
<col style="width: 31%" />
<col style="width: 68%" />
</colgroup>
<thead>
<tr class="header">
<th>Values</th>
<th>Comments</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>HEARTS</td>
<td></td>
</tr>
<tr class="even">
<td>DIAMONDS</td>
<td></td>
</tr>
<tr class="odd">
<td>#TPM_RC_SUIT</td>
<td><p>response code returned when the unmarshaling of this type
fails</p>
<p>NOTE TPM_RC_SUIT is an example and no such response code is actually
defined in this specification.</p></td>
</tr>
</tbody>
</table>

EXAMPLE 2

/\* Validation code that might be automatically generated from table
above \*/

if((\*target != HEARTS) && (\*target != DIAMONDS))

return TPM_RC_SUIT;

In some cases, the allowed values are numeric values with no associated
mnemonic. In such a case, the list of numeric values may be given a
name. Then, when used in an interface definition, the name would have a
"\$" prefix to indicate that a named list of values should be
substituted.

To illustrate, assume that the implementation only supports two sizes
(1024 and 2048 bits) for keys associated with some algorithm (MY
algorithm).

EXAMPLE 3

Table xx — Defines for MY Algorithm Constants

|                   |              |                                     |
|-------------------|--------------|-------------------------------------|
| Name              | Value        | Comments                            |
| MY_KEY_SIZES_BITS | {1024, 2048} | braces because this is a list value |

Then, whenever an input value would need to be a valid MY key size for
the implementation, the value \$MY_KEY_SIZES_BITS could be used. Given
the definition for MY_KEY_SIZES_BITS in example 3 above, the tables in
example 4 and 5 below, are equivalent.

EXAMPLE 4

Table xx — Definition of (UINT16) MY_KEY_BITS Type

|              |                                         |
|--------------|-----------------------------------------|
| Parameter    | Description                             |
| {1024, 2048} | the number of bits in the supported key |

EXAMPLE 5

Table xx — Definition of (UINT16) MY_KEY_BITS Type

|                     |                                         |
|---------------------|-----------------------------------------|
| Parameter           | Description                             |
| \$MY_KEY_SIZES_BITS | the number of bits in the supported key |

## Arrays

Arrays are denoted by a value in square brackets (“\[ \]”) following a
parameter name. The value in the brackets may be either an integer value
such as “\[20\]” or the name of a component of the same structure that
contains the array.

The table in Example 1 shows how a structure containing fixed and
variable-length arrays would be defined in this specification. Example 2
shows the C code that might be produced from that table by an automated
process.

EXAMPLE 1

Table xx — Definition of A_STRUCT Structure

|                  |        |                                                                                    |
|------------------|--------|------------------------------------------------------------------------------------|
| Parameter        | Type   | Description                                                                        |
| array1\[20\]     | UINT16 | an array of 20 UINT16s                                                             |
| a_size           | UINT16 |                                                                                    |
| array2\[a_size\] | UINT32 | an array of UINT32 values that has a number of elements determined by a_size above |

EXAMPLE 2

/\* C language equivalent of the typedefs from the table above \*/

typedef struct {

UINT16 array1\[20\];

UINT16 a_size;

UINT32 array2\[\];

} A_STRUCT;

## Structure Definitions

The tables used to define structures have a title that starts with the
word “Definition” and ends with “Structure.” The first column of the
table will denote the reference names for the structure members; the
second column the data type of the member; and the third column a
synopsis of the use of the element.

The table in Example 1 shows an example of how a structure would be
defined in this specification and Example 2 shows the C code that might
be produced from the table by an automated process. Example 3
illustrates the type of unmarshaling code that could be generated using
the information available in the table.

EXAMPLE 1

Table xx — Definition of SIMPLE_STRUCTURE Structure

|           |        |             |
|-----------|--------|-------------|
| Parameter | Type   | Description |
| tag       | TPM_ST |             |
| value1    | INT32  |             |
| value2    | INT32  |             |

EXAMPLE 2

/\* C language equivalent of the structure defined in the table above
\*/

typedef struct {

TPM_ST tag;

INT32 value1

INT32 value2;

} SIMPLE_STRUCTURE;

EXAMPLE 3

TPM_RC SIMPLE_STRUCTURE_Unmarshal(SIMPLE_STRUCTURE \*target, BYTE
\*\*buffer, INT32 \*size)

{

TPM_RC rc;

// If unmarshal of tag succeeds

rc = TPM_ST_Unmarshal((TPM_ST \*)&(target-\>tag), buffer, size

If(rc == TPM_RC_SUCCESS)

{

// then unmarshal value1,

rc = INT32_Unmarshal((INT32 \*)&(target-\>value1, buffer, size);

// and if that succeeds...

if(rc == TPM_RC_SUCCESS)

{

// then unmarshal the value 2

rc = INT32_Unmarshal((INT32 \*)&(target-\>value2, buffer, size);

}

}

return rc;

}

A table may have a term in {}. This indicates that the table is
conditionally compiled. It is commonly used when a table's inclusion is
based on the implementation of a cryptographic algorithm. See, for
example, Table 173 — Definition of (TPM_ALG_ID) {RSA}
TPMI_ALG_RSA_DECRYPT Type, which is dependent on the RSA
algorithm.<span id="_Toc283838898" class="anchor"></span>

## Conditional Types

An interface type may have a conditional value. This value is indicated
by a “+” prepended to the name of the value. When this type is
referenced in a structure, a “+” appended to the reference indicates
that the instance allows the conditional value to be returned. If the
reference does not has an appended “+”, then the conditional type is not
allowed.

EXAMPLE 1 Table 66 defining TPMI_ALG_HASH indicates that TPM_ALG_NULL is
a conditional type. TPMI_ALG_HASH is a member of the TPMS_SCHEME_XOR
structure and that reference is TPMI_ALG_HASH+, indicating that
TPM_ALG_NULL is an allowed value for hashAlg. TPMI_ALG_HASH is also
referenced in TPMS_PCR_SELECTION. In that structure the TPMI_ALG_HASH
does not have an appended “+”, so TPM_ALG_NULL would not be an allowed
value for hash.

NOTE In many cases, the input values are algorithm IDs. When two
collections of algorithm IDs differ only because one collection allows
TPM_ALG_NULL and the other does not, it is preferred that there not be
two completely different enumerations because this leads to many casts.
To avoid this, the “+” can be added to a TPM_ALG_NULL value in the table
defining the type. When the use of that type allows TPM_ALG_NULL to be
in the set, the use would append a “+” to the instance.

When a type with a conditional value is referenced within a structure or
union and the type reference has a “+” prepended to the type, it allows
the references to that structure to treat it as if it had a conditional
type. That means that a reference to that structure may have a “+”
appended to the type. When the “+” is present in the structure/union
reference, then the conditional value of the conditional type within the
structure/union is allowed.

EXAMPLE 2 Table 142 — Definition of TPMT_SYM_DEF_OBJECT Structure
defines the TPMT_SYM_DEF_OBJECT. The algorithm element of that structure
is a TPMI_ALG_SYM_OBJECT with a “+” prepended. This means that when a
TPMT_SYM_DEF_OBJECT is referenced, the reference may have an appended
“+” as it does in the definition of the symmetric parameter of
TPMS_ASYM_PARMS. The “+” in TPMA_ASYM_PARMS means that the algorithm
parameter in the TPMT_SYM_DEF_OBJECT may have the conditional value
(TPM_ALG_NULL).

EXAMPLE 3

Table xx — Definition of (CARD_SUIT) TPMI_CARD_SUIT Type

| Values        | Comments                                                                   |
|---------------|----------------------------------------------------------------------------|
| SPADES        |                                                                            |
| HEARTS        |                                                                            |
| DIAMONDS      |                                                                            |
| CLUBS         |                                                                            |
| +JOKER        | an optional value that may be allowed                                      |
| \#TPM_RC_SUIT | response code returned when the input value is not one of the values above |

EXAMPLE 4

Table xx — Definition of POKER_CARD Structure

|           |                 |                |
|-----------|-----------------|----------------|
| Parameter | Type            | Description    |
| suit      | TPMI_CARD_SUIT+ | allows joker   |
| number    | UINT8           | the card value |

EXAMPLE 5

Table xx — Definition of BRIDGE_CARD Structure

|           |                |                      |
|-----------|----------------|----------------------|
| Parameter | Type           | Description          |
| suit      | TPMI_CARD_SUIT | does not allow joker |
| number    | UINT8          | the card value       |

## Unions

### Introduction

A union allows a structure to contain a variety of structures or types.
The union has members, only one of which is present at a time. Three
different tables are required to fully characterize a union so that it
may be communicated on the TPM interface and used by the TPM:

- union definition;

- union instance; and

- union selector definition.

### Union Definition

The table in Example 1 illustrates a union definition. The title of a
union definition table starts with “Definition” and ends with “Union.”
The “Parameter” column of a union definition lists the different names
that are used when referring to a specific type. The “Type” column
identifies the data type of the member. The “Selector” column identifies
the value that is used by the marshaling and unmarshaling code to
determine which case of the union is present.

If a parameter is the keyword “null” or the type is empty, then this
denotes a selector with no contents. The table in Example 1 illustrates
a union in which a conditional null selector is allowed to indicate an
empty union member.

Example 2 shows how the table would be converted into C-compatible code.

The expectation is that the unmarshaling code for the union will
validate that the selector for the union is one of values in the
selector list.

EXAMPLE 1

Table xx — Definition of NUMBER_UNION Union

|           |       |              |                  |
|-----------|-------|--------------|------------------|
| Parameter | Type  | Selector     | Description      |
| a_byte    | BYTE  | BYTE_SELECT  |                  |
| an_int    | int   | INT_SELECT   |                  |
| a_float   | float | FLOAT_SELECT |                  |
| +null     |       | NULL_SELECT  | the empty branch |

EXAMPLE 2

// C-compatible version of the union defined in the table above

typedef union {

BYTE a_byte;

int an_int;

float a_float;

} NUMBER_UNION;

EXAMPLE 3

// Possible auto-generated code to unmarshal a union in Example 2 based
on the

// input value of selector

TPM_RC NUMBER_UNION_Unmarshal(NUMBER_UNION \*target, BYTE \*\*buffer,

INT32 \*size, UINT32 selector)

{

switch (selector) {

case BYTE_SELECT:

return BYTE_Unmarshal((BYTE \*)&(target-\>a_byte), buffer, size);

case INT_SELECT:

return INT_Unmarshal((int \*)&(target-\>an_int), buffer, size);

case FLOAT_SELECT:

return FLOAT_Unmarshal((float \*)&(target-\>a_float), buffer, size);

case NULL_SELECT:

return TPM_RC_SUCCESS;

}

A table may have a type with no selector. This is used when the first
part of the structure for all union members is identical. This type is a
programming convenience, allowing code to reference the common members
without requiring a case statement to determine the specific structure.
In object oriented programming terms, this type is a superclass and the
types with selectors are subclasses. Since there is no selector, this
union member cannot be marshaled or unmarshaled.

EXAMPLE 4 Table 189 has an 'any' parameter with no selector. Any of the
other union members may be cast to TPMS_SCHEME_HASH, since all begin
with TPMI_ALG_HASH.

### Union Instance

When a union is used in a structure that is sent on the interface, the
structure will minimally contain a selector and a union. The selector
value indicates which of the possible union members is present so that
the unmarshaling code can unmarshal the correct type. The selector may
be any of the parameters that occur in the structure before the union
instance. To denote the structure parameter that is used as the
selector, its name is in brackets (“\[ \]”) placed before the parameter
name associated with the union.

The table in Example 1 shows the definition of a structure that contains
a union and a selector. Example 2 shows how the table would be converted
into C-compatible code and Example 3 shows how the unmarshaling code
would handle the selector.

EXAMPLE 1

Table xx — Definition of STRUCTURE_WITH_UNION Structure

|                   |               |                                         |
|-------------------|---------------|-----------------------------------------|
| Parameter         | Type          | Description                             |
| select            | NUMBER_SELECT | a value indicating the type in *number* |
| \[select\] number | NUMBER_UNION  | a union as shown in 4.9.2               |

EXAMPLE 2

// C-compatible version of the union structure in the table above

typedef struct {

NUMBER_SELECT select;

NUMBER_UNION number;

} STRUCT_WITH_UNION;

EXAMPLE 3

// Possible unmarshaling code for the structure above

TPM_RC STRUCT_WITH_UNION_Unmarshal(STRUCT_WITH_UNION \*target, BYTE
\*\*buffer, INT32 \*size)

{

TPM_RC rc;

// Unmarshal the selector value

rc = NUMBER_SELECT_Unmarshal((NUMBER_SELECT \*)&target-\>select, buffer,
size)

if(rc != TPM_RC_SUCCESS)

return rc;

// Use the unmarshaled selector value to indicate to the union unmarshal

// function which unmarshaling branch to follow.

return(NUMBER_UNION_Unmarshal((NUMBER_UNION \*)&(target-\>number),

buffer, size, (UINT32)target-\>select);

}

### Union Selector Definition

The selector definition limits the values that are used in unmarshaling
a union. Two different selector sets applied to the same union define
different types.

For the union in 4.9.2, a selector definition should be limited to no
more than four values, one for each of the union members. The selector
definition could have fewer than four values.

In Example 1, the table defines a value for each of the union members.

EXAMPLE 1

Table xx — Definition of (INT8) NUMBER_SELECT Values \<IN\>

|              |       |          |
|--------------|-------|----------|
| Name         | Value | Comments |
| BYTE_SELECT  | 3     |          |
| INT_SELECT   | 2     |          |
| FLOAT_SELECT | 1     |          |
| NULL_SELECT  | 0     |          |

The unmarshaling code would limit the input values to the defined
values. When the NUMBER_SELECT is used in the union instance of 4.9.3,
any of the allowed union members of NUMBER_UNION could be present.

A different selection could be used to limit the values in a specific
instance. To get the different selection, a new structure is defined
with a different selector. The table in example 2 illustrates a way to
subset the union. The base type of the selection is NUMBER_SELECT so a
NUMBER_SELECT will be unmarshaled before the checks are made to see if
the value is in the correct range for JUST_INTEGERS types. If the base
type had been UINT8, then no checking would occur prior to checking that
the value is in the allowed list. In this particular case, the effect is
the same in either case since the only values that will be accepted by
the unmarshaling code for JUST_INTEGER are BYTE_SELECT and INT_SELECT.

EXAMPLE 2

Table xx — Definition of (NUMBER_SELECT) AN_INTEGER Type \<IN\>

| Values                    | Comments               |
|---------------------------|------------------------|
| {BYTE_SELECT, INT_SELECT} | list of allowed values |

NOTE Since NULL_SELECT is not in the list of values accepted as a
JUST_INTEGER, the “+” modifier will have no effect if used for a
JUST_INTEGERS type shown in Example 3.

The selector in Example 2 can then be used in a subset union as shown in
Example 3.

EXAMPLE 3

Table xx — Definition of JUST_INTEGERS Structure

|                   |              |                                         |
|-------------------|--------------|-----------------------------------------|
| Parameter         | Type         | Description                             |
| select            | AN_INTEGER   | a value indicating the type in *number* |
| \[select\] number | NUMBER_UNION | a union as shown in 4.9.2               |

## Bit Field Definitions

A table that defines a structure containing bit fields has a title that
starts with “Definition” and ends with “Bits.” A type identifier in
parentheses in the title indicates the size of the datum that contains
the bit fields.

When the bit fields do not occupy consecutive locations, a spacer field
is defined with a name of “Reserved.” Bits in these spaces are reserved
and shall be zero.

The table in Example 1 shows how a structure containing bit fields would
be defined in this specification. Example 2 shows the C code that might
be produced from that table by an automated process.

When a field has more than one bit, the range is indicated by a pair of
numbers separated by a colon (“:”). The numbers will be in high:low
order.

EXAMPLE1

Table xx — Definition of (UINT32) SOME_ATTRIBUTE Bits

<table>
<colgroup>
<col style="width: 8%" />
<col style="width: 30%" />
<col style="width: 61%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Bit</td>
<td>Name</td>
<td>Action</td>
</tr>
<tr class="even">
<td>0</td>
<td>zeroth_bit</td>
<td><p><strong>SET (1)</strong>: what to do if bit is 1</p>
<p><strong>CLEAR (0):</strong> what to do if bit is 0</p></td>
</tr>
<tr class="odd">
<td>1</td>
<td>first_bit</td>
<td><p><strong>SET (1)</strong>: what to do if bit is 1</p>
<p><strong>CLEAR (0):</strong> what to do if bit is 0</p></td>
</tr>
<tr class="even">
<td>6:2</td>
<td>Reserved</td>
<td>A placeholder that spans 5 bits</td>
</tr>
<tr class="odd">
<td>7</td>
<td>third_bit</td>
<td><p><strong>SET (1)</strong>: what to do if bit is 1</p>
<p><strong>CLEAR (0):</strong> what to do if bit is 0</p></td>
</tr>
<tr class="even">
<td>31:8</td>
<td>Reserved</td>
<td>Placeholder to fill 32 bits</td>
</tr>
</tbody>
</table>

EXAMPLE 2

/\* C language equivalent of the attributes structure defined in the
table above \*/

typedef struct {

int zeroth_bit : 1;

int first_bit : 1;

int Reserved3 : 5;

int third_bit : 1;

int Reserved7 : 24;

} SOME_ATTRIBUTE;

NOTE The packing of bit fields into an integer is compiler and tool
chain dependent. This C language equivalent is valid for a compiler that
packs bit fields from the least significant bit to the most significant
bit. It is likely to be correct for a little endian processor and likely
to be incorrect for a big endian processor.

## Parameter Limits

A parameter used in a structure may be given a set of values that can be
checked by the unmarshaling code. The allowed values for a parameter may
be included in the definition of the parameter by appending the values
and delimiting them with braces (“{ }”). The values are comma-separated
expressions. A range of numbers may be indicated by separating two
expressions with a colon (“:”). The first number is an expression that
represents the minimum allowed value and the second number indicates the
maximum. If the minimum or maximum value expression is omitted, then the
range is open-ended.

Lower limits expressed using braces apply only to inputs to the TPM. The
lower limit for a value returned by the TPM is determined by input
parameters and the TPM implementation. Upper limits expressed using
braces apply to both inputs to and outputs from the TPM.

NOTE In many cases, the upper limits are dependent on the TPM
implementation. The values for these limits can be determined by
accessing the TPM’s capabilities.

The maximum size of an array may be indicated by putting a “{}”
delimited expression following the square brackets (“\[ \]”) that
indicate that the value is an array.

EXAMPLE

Table xx — Definition of B_STRUCT Structure

<table>
<colgroup>
<col style="width: 30%" />
<col style="width: 17%" />
<col style="width: 52%" />
</colgroup>
<thead>
<tr class="header">
<th>Parameter</th>
<th>Type</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>value1 {20:25}</td>
<td>UINT16</td>
<td>a parameter that must have a value between 20 and 25, inclusive</td>
</tr>
<tr class="even">
<td>value2 {20}</td>
<td>UINT16</td>
<td>a parameter that must have a value of 20</td>
</tr>
<tr class="odd">
<td>value3 {:25}</td>
<td>INT16</td>
<td><p>a parameter that may be no larger than 25</p>
<p>Since the parameter is signed, the minimum value is the largest
negative integer that may be expressed in 16 bits.</p></td>
</tr>
<tr class="even">
<td>value4 {20:}</td>
<td></td>
<td>a parameter that must be at least 20</td>
</tr>
<tr class="odd">
<td>value5 {1,2,3,5}</td>
<td>UINT16</td>
<td>a parameter that may only have one of the four listed values</td>
</tr>
<tr class="even">
<td>value6 {1, 2, 10:(10+10)}</td>
<td>UINT32</td>
<td>a parameter that may have a value of 1, 2, or be between 10 and
20</td>
</tr>
<tr class="odd">
<td>array1[value1]</td>
<td>BYTE</td>
<td><p>Because the index refers to <em>value1</em>, which is a value
limited to be between 20 and 25 inclusive, array1 is an array that may
have between 20 and 25 octets. This is not the preferred way to indicate
the upper limit for an array as it does not indicate the upper bound of
the size.</p>
<p>NOTE This is a limitation of the current parser. A different parser
could associate the range of value1 with this value and compute the
maximum size of the array.</p></td>
</tr>
<tr class="even">
<td>array2[value4]{:25}</td>
<td>BYTE</td>
<td><p>an array that may have between 20 and 25 octets</p>
<p>This arrangement is used to allow the automatic code generation to
allocate 25 octets to store the largest array2 that can be unmarshaled.
The code generation can determine from this expression that
<em>value4</em> shall have a value of 25 or less. From the definition of
<em>value4</em> above, it can determine that <em>value4</em> must have a
value of at least 20.</p></td>
</tr>
</tbody>
</table>

## Algorithm Macros

### Introduction

This specification is intended to be algorithm agile in two different
ways. In the first, agility is provided by allowing different subsets of
the algorithms listed in the TCG registry. In the second, agility is
provided by allowing the list of algorithms in the TCG registry to
change without requiring changes to this specification.

This second form of algorithm agility is accomplished by using
placeholder tokens that represent all of the algorithms of a particular
type. The type of the algorithm is indicated by the letters in the Type
column of the TPM_ALG_ID table in the TCG registry.

The use of these tokens is described in the remainder of this clause
4.12.

### Algorithm Token Semantics

The string “!ALG” or “!alg” indicates the algorithm token. This token
may be followed by an algorithm type selection. The presence of the type
selection is indicated by a period (“.”) following the token. The
selection is all alphanumeric characters following the period.

NOTE In this selection context, the underscore character (“\_”) is not
considered an alphanumeric character.

The selection is either an exclusive selection or an inclusive
selection. An exclusive selection is one for which the Type entry for
the algorithm is required to exactly match the type selection of the
token. An inclusive selection is one where the Type entry for the
algorithm is required to contain all of the characters of the selection
but may contain additional attributes.

EXAMPLE 1 The “!ALG.AX” token would select those algorithms that only
have the ‘A’ and ‘X’ types (that is, an asymmetric signing algorithm).
The “!ALG.ax” token would select those algorithms that at least have ‘A’
and ‘X’ types but would include algorithms with other types such as
‘ANX’ (asymmetric signing and anonymous asymmetric signing).

When a replacement is made, the token will be replaced by an algorithm
root identifier using either upper or lower case. If the algorithm token
is part of another word, then the replacement uses upper case
characters, otherwise, lower case is used.

NOTE The root identifier of an algorithm is the name in the TPM_ALG_ID
table with “TPM_ALG\_” removed. For example TPM_ALG_SHA1 has “SHA1” as
its root.

The typical use of these tokens follows.

### Algorithm Tokens in Unions

A common place for algorithm tokens is in a union of values that are
dependent on the type of the algorithm

EXAMPLE 1 An algorithm token indicating all hashes would be “!ALG.H” and
could be used in a table to indicate that a union contains all defined
hashes.

Table A — Definition of TPMU_HA Union

|                             |      |               |             |
|-----------------------------|------|---------------|-------------|
| Parameter                   | Type | Selector      | Description |
| !ALG.H \[!ALG_DIGEST_SIZE\] | BYTE | TPM_ALG\_!ALG | all hashes  |
| null                        |      | TPM_ALG_NULL  |             |

If the TCG registry only contained SHA1, SHA256, and the SM3_256 hash
algorithm identifiers, then the table above would be semantically
equivalent to:

Table xx — Definition of TPMU_HA Union

|                                 |      |                 |             |
|---------------------------------|------|-----------------|-------------|
| Parameter                       | Type | Selector        | Description |
| sha1 \[SHA1_DIGEST_SIZE\]       | BYTE | TPM_ALG_SHA1    |             |
| sha256 \[SHA256_DIGEST_SIZE\]   | BYTE | TPM_ALG_SHA256  |             |
| sm3_256 \[SM3_256_DIGEST_SIZE\] | BYTE | TPM_ALG_SM3_256 |             |
| null                            |      | TPM_ALG_NULL    |             |

As shown in table A, the case of the replacement is determined by
context. When !ALG is not an element of a longer name, then lower case
characters are used. When !ALG is part of a longer name (indicated by
leading or trailing underscore (“\_”), then upper case is used for the
replacement.

Only one occurrence of the algorithm type (such as !ALG.H) is required
for a line. If a line contains multiple list selections they are
required to be identical.

If a table contains multiple lines with algorithm tokens, then each line
is expanded separately.

### Algorithm Tokens in Interface Types

An interface type is often used with a union to create a tagged
structure – the structure contains a union and a tag to indicate which
of the union elements is actually present. The interface type for a
tagged structure will usually contain the same elements as the union.

EXAMPLE If SHA1, SHA256, and SM3_256 are the only defined hash
algorithms, then an interface type to select a hash would be:

Table xx — Definition of (TPM_ALG_ID) TPMI_ALG_HASH Type

| Values          | Comments |
|-----------------|----------|
| TPM_ALG_SHA1    | example  |
| TPM_ALG_SHA256  | example  |
| TPM_ALG_SM3_256 | example  |
| +TPM_ALG_NULL   |          |
| \#TPM_RC_HASH   |          |

An equivalent table may be represented using an algorithm macro.

Table xx — Definition of (TPM_ALG_ID) TPMI_ALG_HASH Type

| Values          | Comments                               |
|-----------------|----------------------------------------|
| TPM_ALG\_!ALG.H | all hash algorithms defined by the TCG |
| +TPM_ALG_NULL   |                                        |
| \#TPM_RC_HASH   |                                        |

### Algorithm Tokens for Table Replication

When a table is used to define an algorithm-specific value, that table
may be replicated using the algorithm replacement token to create a
table with values specific to the algorithm type. This type of
replication is indicated by using an algorithm token in the name of the
table.

EXAMPLE If AES and SM4 are the only defined symmetric block ciphers,
then:

Table xx — Definition of {!ALG.S} (TPM_KEY_BITS) TPMI\_!ALG_KEY_BITS
Type

|                       |                                      |
|-----------------------|--------------------------------------|
| Parameter             | Description                          |
| \$!ALG_KEY_SIZES_BITS | number of bits in the key            |
| \#TPM_RC_VALUE        | error when key size is not supported |

has the same meaning as:

Table xx — Definition of {AES} (TPM_KEY_BITS) TPMI_AES_KEY_BITS Type

|                      |                                      |
|----------------------|--------------------------------------|
| Parameter            | Description                          |
| \$AES_KEY_SIZES_BITS | number of bits in the key            |
| \#TPM_RC_VALUE       | error when key size is not supported |

Table xx — Definition of {SM4} (TPM_KEY_BITS) TPMI_SM4_KEY_BITS Type

|                      |                                      |
|----------------------|--------------------------------------|
| Parameter            | Description                          |
| \$SM4_KEY_SIZES_BITS | number of bits in the key            |
| \#TPM_RC_VALUE       | error when key size is not supported |

## Size Checking

In some structures, a size field is present to indicate the number of
octets in some subsequent part of the structure. In the B_STRUCT table
in 4.11, *value4* indicates how many octets to unmarshal for *array2*.
This semantic applies when the size field determines the number of
octets to unmarshal. However, in some cases, the subsequent structure is
self-defining. If the size precedes a parameter that is not an octet
array, then the unmarshaled size of that parameter is determined by its
data type. The table in Example 1 shows a structure where the size
parameter would nominally indicate the number of octets in the remainder
of the structure.

EXAMPLE 1

Table xx — Definition of C_STRUCT Structure

|           |        |                                                     |
|-----------|--------|-----------------------------------------------------|
| Parameter | Type   | Comments                                            |
| size      | UINT16 | the expected size of the remainder of the structure |
| anInteger | UINT32 | a 4-octet value                                     |

In this particular case, the value of size would be incorrect if it had
any value other than 4. So that the table parser is able to know that
the purpose of the size parameter is to define the number of octets
expected in the remainder of the structure, an equal sign (“=”) is
appended to the parameter name.

In the example below, the *size=* causes the parser to generate
validation code that will check that the unmarshaled size of
*someStructure* and *someData* adds to the value unmarshaled for *size*.
When the “=” decoration is present, a value of zero is not allowed for
the size.

EXAMPLE 2

Table xx — Definition of D_STRUCT Structure

<table>
<colgroup>
<col style="width: 23%" />
<col style="width: 23%" />
<col style="width: 52%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Parameter</td>
<td>Type</td>
<td>Comments</td>
</tr>
<tr class="even">
<td>size=</td>
<td>UINT16</td>
<td><p>the size of a structure</p>
<p>The “=” indicates that the TPM is required to validate that the
remainder of the D_STRUCT structure is exactly the value in
<em>size</em>. That is, the number of bytes in the input buffer used to
successfully unmarshal <em>someStructure</em> must be the same as
<em>size</em>.</p></td>
</tr>
<tr class="odd">
<td>someStructure</td>
<td>A_STRUCT</td>
<td><p>a structure to be unmarshaled</p>
<p>The size of the structure is computed when it is unmarshaled. Because
an “=” is present on the definition of <em>size,</em> the TPM is
required to validate that the unmarshaled size exactly matches
<em>size</em>.</p></td>
</tr>
<tr class="even">
<td>someData</td>
<td>UINT32</td>
<td>a value</td>
</tr>
</tbody>
</table>

## Data Direction

A structure or union may be input (IN), output (OUT), or internal. An
input structure is sent to the TPM and is unmarshaled by the TPM. An
output structure is sent from the TPM and is marshaled by the TPM. An
internal structure is not used outside of the TPM except that it may be
included in a saved context.

By default, structures are assumed to be both IN and OUT and the code
generation tool will generate both marshaling and unmarshaling code for
the structure. This default may be changed by using values enclosed in
angle brackets (“\<\>”) as part of the table title. If the angle
brackets are empty, then the structure is internal and neither
marshaling nor unmarshaling code is generated. If the angle brackets
contain the letter “I” (such as in “IN” or “in” or “i”), then the
structure is input and unmarshaling code will be generated. If the angle
brackets contain the letter “O” (such as in “OUT” or “out” or “o”), then
the structure is output and marshaling code will be generated.

EXAMPLE 1 Both of the following table titles would indicate a structure
that is used in both input and output

**Table xx — Definition of TPMS_A Structure**

**Table xx — Definition of TPMS_A Structure \<IN/OUT\>**

EXAMPLE 2 The following table title would indicate a structure that is
used only for input

**Table xx — Definition of TPMS_A Structure \<IN\>**

EXAMPLE 3 The following table title would indicate a structure that is
used only for output

**Table xx — Definition of TPMS_A Structure \<OUT\>**

## Structure Validations

By default, when a structure is used for input to the TPM, the code
generation tool will generate the unmarshaling code for that structure.
Auto-generation may be suppressed by adding an “S” within the angle
brackets.

EXAMPLE The following table titles indicate a structure for which the
auto-generation of the validation code is to be suppressed.

**Table xx — Definition of TPMT_A Structure \<S\>**

**Table xx — Definition of TPMT_A Structure \<IN, S\>**

**Table xx — Definition of TPMT_A Structure \<IN/OUT, S\>**

## Name Prefix Convention

Parameters are constants, variables, structures, unions, and structure
members. Structure members are given a name that is indicative of its
use, with no special prefix. The other parameter types are named
according to their type with their name starting with “TPMx\_”, where
“x” is an optional character to indicate the data type.

In some cases, additional qualifying characters will follow the
underscore. These are generally used when dealing with an enumerated
data type.<span id="_Toc380749690" class="anchor"></span>

Table 1 — Name Prefix Convention

<table>
<colgroup>
<col style="width: 16%" />
<col style="width: 83%" />
</colgroup>
<thead>
<tr class="header">
<th>Prefix</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>_TPM_</td>
<td>an indication/signal from the TPM’s system interface</td>
</tr>
<tr class="even">
<td>TPM_</td>
<td>a constant or an enumerated type</td>
</tr>
<tr class="odd">
<td>TPM2_</td>
<td>a command defined by this specification</td>
</tr>
<tr class="even">
<td>TPM2B_</td>
<td><p>a structure that is a sized buffer where the size of the buffer
is contained in a 16-bit, unsigned value</p>
<p>The first parameter is the size in octets of the second parameter.
The second parameter may be any type.</p></td>
</tr>
<tr class="odd">
<td>TPMA_</td>
<td><p>a structure where each of the fields defines an attribute and
each field is usually a single bit</p>
<p>All the attributes in an attribute structure are packed with the
overall size of the structure indicated in the heading of the attribute
description (UINT8, UINT16, or UINT32).</p></td>
</tr>
<tr class="even">
<td>TPM_ALG_</td>
<td><p>an enumerated type that indicates an algorithm</p>
<p>A TPM_ALG_ is often used as a selector for a union.</p></td>
</tr>
<tr class="odd">
<td>TPMI_</td>
<td><p>an interface type</p>
<p>The value is specified for purposes of dynamic type checking when
unmarshaled.</p></td>
</tr>
<tr class="even">
<td>TPML_</td>
<td><p>a list length followed by the indicated number of entries of the
indicated type</p>
<p>This is an array with a length field.</p></td>
</tr>
<tr class="odd">
<td>TPMS_</td>
<td>a structure that is not a size buffer or a tagged buffer or a
list</td>
</tr>
<tr class="even">
<td>TPMT_</td>
<td><p>a structure with the first parameter being a structure tag,
indicating the type of the structure that follows</p>
<p>A structure tag may be either a TPM_ST_ or TPM_ALG_ depending on
context.</p></td>
</tr>
<tr class="odd">
<td>TPMU_</td>
<td><p>a union of structures, lists, or unions</p>
<p>If a union exists, there will normally be a companion TPMT_ that is
the expression of the union in a tagged structure, where the tag is the
selector indicating which member of the union is present.</p></td>
</tr>
<tr class="even">
<td>TPM_xx_</td>
<td><p>an enumeration value of a particular type</p>
<p>The value of “xx” will be indicative of the use of the enumerated
type. A table of “TPM_xx” constant definitions will exist to define each
of the TPM_xx_ values.</p>
<p>EXAMPLE 1 TPM_CC_ indicates that the type is used for a
<em>commandCode.</em> The allowed enumeration values will be found in
the table defining the TPM_CC constants (Table 12)</p>
<p>EXAMPLE 2 TPM_RC_ indicates that the type is used for a
<em>responseCode</em>. The allowed enumeration values are in Table
16.</p></td>
</tr>
</tbody>
</table>

## Data Alignment

The data structures in this TPM 2.0 Part 2 use octet alignment for all
structures. When used in a table to indicate a maximum size, the
sizeof() function returns the octet-aligned size of the structure, with
no padding.

## Parameter Unmarshaling Errors

The TPM commands are defined in TPM 2.0 Part 3. The command definition
includes C code that details the actions performed by that command. The
code is written assuming that the parameters of the command have been
unmarshaled.

NOTE 1 An implementation is not required to process parameters in this
manner or to separate the parameter parsing from the command actions.
This method was chosen for the specification so that the normative
behavior described by the detailed actions would be clear and
unencumbered.

Unmarshaling is the process of processing the parameters in the input
buffer and preparing the parameters for use by the command-specific
action code. No data movement need take place but it is required that
the TPM validate that the parameters meet the requirements of the
expected data type as defined in this TPM 2.0 Part 2.

When an error is encountered while unmarshaling a command parameter, an
error response code is returned and no command processing occurs. A
table defining a data type may have response codes embedded in the table
to indicate the error returned when the input value does not match the
parameters of the table.

EXAMPLE 1 Table 12 has a listing of TPM command code values. The last
row in the table contains "#TPM_RC_COMMAND_CODE" indicating the response
code that is returned if the TPM is unmarshaling a value that it expects
to be a TPM_CC and the input value is not in the table.

NOTE 2 In the reference implementation, a parameter number is added to
the response code so that the offending parameter can be isolated.

In many cases, the table contains no specific response code value and
the return code will be determined as defined in Table 2.

<span id="_Ref328497210" class="anchor"></span>Table 2 — Unmarshaling
Errors

| Response code        | Usage                                                                                           |
|----------------------|-------------------------------------------------------------------------------------------------|
| TPM_RC_INSUFFICIENT  | the input buffer did not contain enough octets to allow unmarshaling of the expected data type; |
| TPM_RC_RESERVED_BITS | a non-zero value was found in a reserved field of an attribute structure (TPMA\_)               |
| TPM_RC_SIZE          | the value of a size parameter is larger or smaller than allowed                                 |
| TPM_RC_VALUE         | A parameter does not have one of its allowed values                                             |
| TPM_RC_TAG           | A parameter that should be a structure tag has a value that is not supported by the TPM         |

In some commands, a parameter may not be used because of various options
of that command. However, the unmarshaling code is required to validate
that all parameters have values that are allowed by the TPM 2.0 Part 2
definition of the parameter type even if that parameter is not used in
the command actions.

# Base Types

## Primitive Types

The types listed in Table 3 are the primitive types on which all of the
other types and structures are based. The values in the “Type” column
should be edited for the compiler and computer on which the TPM is
implemented. The values in the “Name” column should remain the same
because these values are used in the remainder of the specification.

NOTE The types are compatible with the C99 standard and should be
defined in stdint.h that is provided with a C99-compliant compiler;

The parameters in the Name column should remain in the order shown.

<span id="_Ref247782753" class="anchor"></span>Table 3 — Definition of
Base Types

<table>
<colgroup>
<col style="width: 13%" />
<col style="width: 18%" />
<col style="width: 68%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Type</td>
<td>Name</td>
<td>Description</td>
</tr>
<tr class="even">
<td>uint8_t</td>
<td>UINT8</td>
<td>unsigned, 8-bit integer</td>
</tr>
<tr class="odd">
<td>uint8_t</td>
<td>BYTE</td>
<td>unsigned 8-bit integer</td>
</tr>
<tr class="even">
<td>int8_t</td>
<td>INT8</td>
<td>signed, 8-bit integer</td>
</tr>
<tr class="odd">
<td>int</td>
<td>BOOL</td>
<td><p>a bit in an <strong>int</strong></p>
<p>This is not used across the interface but is used in many places in
the code. If the type were sent on the interface, it would have to have
a type with a specific number of bytes.</p></td>
</tr>
<tr class="even">
<td>uint16_t</td>
<td>UINT16</td>
<td>unsigned, 16-bit integer</td>
</tr>
<tr class="odd">
<td>int16_t</td>
<td>INT16</td>
<td>signed, 16-bit integer</td>
</tr>
<tr class="even">
<td>uint32_t</td>
<td>UINT32</td>
<td>unsigned, 32-bit integer</td>
</tr>
<tr class="odd">
<td>int32_t</td>
<td>INT32</td>
<td>signed, 32-bit integer</td>
</tr>
<tr class="even">
<td>uint64_t</td>
<td>UINT64</td>
<td>unsigned, 64-bit integer</td>
</tr>
<tr class="odd">
<td>int64_t</td>
<td>INT64</td>
<td>signed, 64-bit integer</td>
</tr>
</tbody>
</table>

## Specification Logic Value Constants

<span id="_Toc432512500" class="anchor"></span>Table 4 — Defines for
Logic Values

|       |       |             |
|-------|-------|-------------|
| Name  | Value | Description |
| TRUE  | 1     |             |
| FALSE | 0     |             |
| YES   | 1     |             |
| NO    | 0     |             |
| SET   | 1     |             |
| CLEAR | 0     |             |

## Miscellaneous Types

These types are defined either for compatibility with previous versions
of this specification or for clarity of this specification.

<span id="_Toc380749693" class="anchor"></span>Table 5 — Definition of
Types for Documentation Clarity

|        |                        |                                                   |
|--------|------------------------|---------------------------------------------------|
| Type   | Name                   | Description                                       |
| UINT32 | TPM_ALGORITHM_ID       | this is the 1.2 compatible form of the TPM_ALG_ID |
| UINT32 | TPM_MODIFIER_INDICATOR |                                                   |
| UINT32 | TPM_AUTHORIZATION_SIZE | the *authorizationSize* parameter in a command    |
| UINT32 | TPM_PARAMETER_SIZE     | the *parameterSize* parameter in a command        |
| UINT16 | TPM_KEY_SIZE           | a key size in octets                              |
| UINT16 | TPM_KEY_BITS           | a key size in bits                                |

# Constants

## TPM_SPEC (Specification Version Values)

These values are readable with TPM2_GetCapability() (see 6.13 for the
format).

NOTE 1 This table will require editing when the specification is
updated.

NOTE 2 The year and day of year are those of this specification if the
TPM does not implement errata. If the TPM implements errata, the values
indicate the release date of the errata document. There is no provision
for indicating that not all errata are implemented.

<span id="_Toc380749694" class="anchor"></span>Table 6 — Definition of
(UINT32) TPM_SPEC Constants \<\>

| Name                 | Value      | Comments                                       |
|----------------------|------------|------------------------------------------------|
| TPM_SPEC_FAMILY      | 0x322E3000 | ASCII “2.0” with null terminator               |
| TPM_SPEC_LEVEL       | 00         | the level number for the specification         |
| TPM_SPEC_VERSION     | 159        | the version number of the spec (001.59 \* 100) |
| TPM_SPEC_YEAR        | 2019       | the year of the version                        |
| TPM_SPEC_DAY_OF_YEAR | 312        | the day of the year (November 8)               |

## TPM_GENERATED

This constant value differentiates TPM-generated structures from non-TPM
structures.

<span id="_Toc380749695" class="anchor"></span>Table 7 — Definition of
(UINT32) TPM_GENERATED Constants \<O\>

|                     |            |                                       |
|---------------------|------------|---------------------------------------|
| Name                | Value      | Comments                              |
| TPM_GENERATED_VALUE | 0xff544347 | 0xFF ‘TCG’ (FF 54 43 47<sub>16</sub>) |

## TPM_ALG_ID

The TCG maintains a registry of all algorithms that have an assigned
algorithm ID. That registry is the definitive list of algorithms that
may be supported by a TPM.

NOTE Inclusion of an algorithm does NOT indicate that the necessary
claims of the algorithm are available under reasonable and
non-discriminatory (RAND) terms from a TCG member.

Table 9 is an informative example of a TPM_ALG_ID constants table in the
TCG Algorithm registry. Table 9 is provided for illustrative purposes
only.

An algorithm ID is often used like a tag to determine the type of a
structure in a context-sensitive way. The values for TPM_ALG_ID shall be
in the range of 00 00<sub>16</sub> – 7F FF<sub>16</sub>. Other structure
tags will be in the range 80 00<sub>16</sub> – FF FF<sub>16</sub>.

NOTE In TPM 1.2, these were defined as 32-bit constants. This
specification limits the future size of the algorithm ID to 16 bits. The
TPM_ALGORITHM_ID data type will continue to be a 32-bit number.

An algorithm shall not be assigned a value in the range 00
C1<sub>16</sub> – 00 C6<sub>16</sub> in order to prevent any overlap
with the command structure tags used in TPM 1.2.

The implementation of some algorithms is dependent on the presence of
other algorithms. When there is a dependency, the algorithm that is
required is listed in column labeled "D" (dependent) in Table 9.

EXAMPLE Implementation of TPM_ALG_RSASSA requires that the RSA algorithm
be implemented.

TPM_ALG_KEYEDHASH and TPM_ALG_NULL are required of all TPM
implementations.

<span id="_Toc379564855" class="anchor"></span>Table 8 — Legend for
TPM_ALG_ID Table

<table>
<colgroup>
<col style="width: 25%" />
<col style="width: 74%" />
</colgroup>
<thead>
<tr class="header">
<th>Column Title</th>
<th>Comments</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>Algorithm Name</td>
<td>the mnemonic name assigned to the algorithm</td>
</tr>
<tr class="even">
<td>Value</td>
<td>the numeric value assigned to the algorithm</td>
</tr>
<tr class="odd">
<td>Type</td>
<td><p>The allowed values are:</p>
<blockquote>
<p><strong>A</strong> – asymmetric algorithm with a public and private
key</p>
<p><strong>S</strong> – symmetric algorithm with only a private key</p>
<p><strong>H</strong> – hash algorithm that compresses input data to a
digest value or indicates a method that uses a hash</p>
<p><strong>X</strong> – signing algorithm</p>
<p><strong>N</strong> – an anonymous signing algorithm</p>
<p><strong>E</strong> – an encryption algorithm</p>
<p><strong>M</strong> – a method such as a mask generation function</p>
<p><strong>O</strong> – an object type</p>
</blockquote></td>
</tr>
<tr class="even">
<td>C</td>
<td><p>(<strong>C</strong>lassification) The allowed values are:</p>
<blockquote>
<p><strong>A</strong> – Assigned</p>
<p><strong>S</strong> – TCG Standard</p>
<p><strong>L</strong> – TCG Legacy</p>
</blockquote></td>
</tr>
<tr class="odd">
<td>Dep</td>
<td>(<strong>D</strong>ependent) Indicates which other algorithm is
required to be implemented if this algorithm is implemented</td>
</tr>
<tr class="even">
<td>Reference</td>
<td>the reference document that defines the algorithm</td>
</tr>
<tr class="odd">
<td>Comments</td>
<td>clarifying information</td>
</tr>
</tbody>
</table>

<span id="_Toc278371153" class="anchor"></span>Table 9 — Definition of
(UINT16) TPM_ALG_ID Constants \<IN/OUT, S\>

<table>
<colgroup>
<col style="width: 27%" />
<col style="width: 8%" />
<col style="width: 6%" />
<col style="width: 5%" />
<col style="width: 4%" />
<col style="width: 21%" />
<col style="width: 26%" />
</colgroup>
<thead>
<tr class="header">
<th>Algorithm Name</th>
<th>Value</th>
<th>Type</th>
<th>Dep</th>
<th>C</th>
<th>Reference</th>
<th>Comments</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>TPM_ALG_ERROR</td>
<td>0x0000</td>
<td></td>
<td></td>
<td></td>
<td></td>
<td>should not occur</td>
</tr>
<tr class="even">
<td>TPM_ALG_RSA</td>
<td>0x0001</td>
<td>A O</td>
<td></td>
<td>S</td>
<td>IETF RFC 8017</td>
<td>the RSA algorithm</td>
</tr>
<tr class="odd">
<td>TPM_ALG_TDES</td>
<td>0x0003</td>
<td>S</td>
<td></td>
<td>A</td>
<td>ISO/IEC 18033-3</td>
<td>block cipher with various key sizes (Triple Data Encryption
Algorithm, commonly called Triple Data Encryption Standard)</td>
</tr>
<tr class="even">
<td>TPM_ALG_SHA</td>
<td>0x0004</td>
<td>H</td>
<td></td>
<td>S</td>
<td>ISO/IEC 10118-3</td>
<td>the SHA1 algorithm</td>
</tr>
<tr class="odd">
<td>TPM_ALG_SHA1</td>
<td>0x0004</td>
<td>H</td>
<td></td>
<td>S</td>
<td>ISO/IEC 10118-3</td>
<td>redefinition for documentation consistency</td>
</tr>
<tr class="even">
<td>TPM_ALG_HMAC</td>
<td>0x0005</td>
<td>H X</td>
<td></td>
<td>S</td>
<td>ISO/IEC 9797-2</td>
<td>Hash Message Authentication Code (HMAC) algorithm</td>
</tr>
<tr class="odd">
<td>TPM_ALG_AES</td>
<td>0x0006</td>
<td>S</td>
<td></td>
<td>S</td>
<td>ISO/IEC 18033-3</td>
<td>the AES algorithm with various key sizes</td>
</tr>
<tr class="even">
<td>TPM_ALG_MGF1</td>
<td>0x0007</td>
<td>H M</td>
<td></td>
<td>S</td>
<td><p>IEEE Std 1363<sup>TM</sup>-2000</p>
<p>IEEE Std 1363a™-2004</p></td>
<td>hash-based mask-generation function</td>
</tr>
<tr class="odd">
<td>TPM_ALG_KEYEDHASH</td>
<td>0x0008</td>
<td>H O</td>
<td></td>
<td>S</td>
<td>TCG TPM 2.0 library specification</td>
<td>an object type that may use XOR for encryption or an HMAC for
signing and may also refer to a data object that is neither signing nor
encrypting</td>
</tr>
<tr class="even">
<td>TPM_ALG_XOR</td>
<td>0x000A</td>
<td>H S</td>
<td></td>
<td>S</td>
<td>TCG TPM 2.0 library specification</td>
<td>the XOR encryption algorithm</td>
</tr>
<tr class="odd">
<td>TPM_ALG_SHA256</td>
<td>0x000B</td>
<td>H</td>
<td></td>
<td>S</td>
<td>ISO/IEC 10118-3</td>
<td>the SHA 256 algorithm</td>
</tr>
<tr class="even">
<td>TPM_ALG_SHA384</td>
<td>0x000C</td>
<td>H</td>
<td></td>
<td>A</td>
<td>ISO/IEC 10118-3</td>
<td>the SHA 384 algorithm</td>
</tr>
<tr class="odd">
<td>TPM_ALG_SHA512</td>
<td>0x000D</td>
<td>H</td>
<td></td>
<td>A</td>
<td>ISO/IEC 10118-3</td>
<td>the SHA 512 algorithm</td>
</tr>
<tr class="even">
<td>TPM_ALG_NULL</td>
<td>0x0010</td>
<td></td>
<td></td>
<td>S</td>
<td>TCG TPM 2.0 library specification</td>
<td>Null algorithm</td>
</tr>
<tr class="odd">
<td>TPM_ALG_SM3_256</td>
<td>0x0012</td>
<td>H</td>
<td></td>
<td>A</td>
<td>GM/T 0004-2012</td>
<td>SM3 hash algorithm</td>
</tr>
<tr class="even">
<td>TPM_ALG_SM4</td>
<td>0x0013</td>
<td>S</td>
<td></td>
<td>A</td>
<td>GM/T 0002-2012</td>
<td>SM4 symmetric block cipher</td>
</tr>
<tr class="odd">
<td>TPM_ALG_RSASSA</td>
<td>0x0014</td>
<td>A X</td>
<td>RSA</td>
<td>S</td>
<td>IETF RFC 8017</td>
<td>a signature algorithm defined in section 8.2
(RSASSA-PKCS1-v1_5)</td>
</tr>
<tr class="even">
<td>TPM_ALG_RSAES</td>
<td>0x0015</td>
<td>A E</td>
<td>RSA</td>
<td>S</td>
<td>IETF RFC 8017</td>
<td>a padding algorithm defined in section 7.2 (RSAES-PKCS1-v1_5)</td>
</tr>
<tr class="odd">
<td>TPM_ALG_RSAPSS</td>
<td>0x0016</td>
<td>A X</td>
<td>RSA</td>
<td>S</td>
<td>IETF RFC 8017</td>
<td>a signature algorithm defined in section 8.1 (RSASSA-PSS)</td>
</tr>
<tr class="even">
<td>TPM_ALG_OAEP</td>
<td>0x0017</td>
<td>A E</td>
<td>RSA</td>
<td>S</td>
<td>IETF RFC 8017</td>
<td>a padding algorithm defined in section 7.1 (RSAES_OAEP)</td>
</tr>
<tr class="odd">
<td>TPM_ALG_ECDSA</td>
<td>0x0018</td>
<td>A X</td>
<td>ECC</td>
<td>S</td>
<td>ISO/IEC 14888-3</td>
<td>signature algorithm using elliptic curve cryptography (ECC)</td>
</tr>
<tr class="even">
<td>TPM_ALG_ECDH</td>
<td>0x0019</td>
<td>A M</td>
<td>ECC</td>
<td>S</td>
<td>NIST SP800-56A</td>
<td><p>secret sharing using ECC</p>
<p>Based on context, this can be either One-Pass Diffie-Hellman, C(1, 1,
ECC CDH) defined in 6.2.2.2 or Full Unified Model C(2, 2, ECC CDH)
defined in 6.1.1.2</p></td>
</tr>
<tr class="odd">
<td>TPM_ALG_ECDAA</td>
<td>0x001A</td>
<td>A X N</td>
<td>ECC</td>
<td>S</td>
<td>TCG TPM 2.0 library specification</td>
<td>elliptic-curve based, anonymous signing scheme</td>
</tr>
<tr class="even">
<td>TPM_ALG_SM2</td>
<td>0x001B</td>
<td>A X</td>
<td>ECC</td>
<td>A</td>
<td><p>GM/T 0003.1–2012</p>
<p>GM/T 0003.2–2012</p>
<p>GM/T 0003.3–2012</p>
<p>GM/T 0003.4–2012 GM/T 0003.5–2012</p></td>
<td><p>SM2 – depending on context, either an elliptic-curve based,
signature algorithm or a key exchange protocol</p>
<p>NOTE 1 Type listed as signing but, other uses are allowed according
to context.</p></td>
</tr>
<tr class="odd">
<td>TPM_ALG_ECSCHNORR</td>
<td>0x001C</td>
<td>A X</td>
<td>ECC</td>
<td>S</td>
<td>TCG TPM 2.0 library specification</td>
<td>elliptic-curve based Schnorr signature</td>
</tr>
<tr class="even">
<td>TPM_ALG_ECMQV</td>
<td>0x001D</td>
<td>A M</td>
<td>ECC</td>
<td>A</td>
<td>NIST SP800-56A</td>
<td>two-phase elliptic-curve key exchange – C(2, 2, ECC MQV) section
6.1.1.4</td>
</tr>
<tr class="odd">
<td>TPM_ALG_KDF1_SP800_56A</td>
<td>0x0020</td>
<td>H M</td>
<td>ECC</td>
<td>S</td>
<td>NIST SP800-56A</td>
<td>concatenation key derivation function (approved alternative 1)
section 5.8.1</td>
</tr>
<tr class="even">
<td>TPM_ALG_KDF2</td>
<td>0x0021</td>
<td>H M</td>
<td></td>
<td>A</td>
<td>IEEE Std 1363a-2004</td>
<td>key derivation function KDF2 section 13.2</td>
</tr>
<tr class="odd">
<td>TPM_ALG_KDF1_SP800_108</td>
<td>0x0022</td>
<td>H M</td>
<td></td>
<td>S</td>
<td>NIST SP800-108</td>
<td><p>a key derivation method</p>
<p>Section 5.1 KDF in Counter Mode</p></td>
</tr>
<tr class="even">
<td>TPM_ALG_ECC</td>
<td>0x0023</td>
<td>A O</td>
<td></td>
<td>S</td>
<td>ISO/IEC 15946-1</td>
<td>prime field ECC</td>
</tr>
<tr class="odd">
<td>TPM_ALG_SYMCIPHER</td>
<td>0x0025</td>
<td>O S</td>
<td></td>
<td>S</td>
<td>TCG TPM 2.0 library specification</td>
<td>the object type for a symmetric block cipher</td>
</tr>
<tr class="even">
<td>TPM_ALG_CAMELLIA</td>
<td>0x0026</td>
<td>S</td>
<td></td>
<td>A</td>
<td>ISO/IEC 18033-3</td>
<td>Camellia is symmetric block cipher. The Camellia algorithm with
various key sizes</td>
</tr>
<tr class="odd">
<td>TPM_ALG_SHA3_256</td>
<td>0x0027</td>
<td>H</td>
<td></td>
<td>A</td>
<td>NIST PUB FIPS 202</td>
<td>Hash algorithm producing a 256-bit digest</td>
</tr>
<tr class="even">
<td>TPM_ALG_SHA3_384</td>
<td>0x0028</td>
<td>H</td>
<td></td>
<td>A</td>
<td>NIST PUB FIPS 202</td>
<td>Hash algorithm producing a 384-bit digest</td>
</tr>
<tr class="odd">
<td>TPM_ALG_SHA3_512</td>
<td>0x0029</td>
<td>H</td>
<td></td>
<td>A</td>
<td>NIST PUB FIPS 202</td>
<td>Hash algorithm producing a 512-bit digest</td>
</tr>
<tr class="even">
<td>TPM_ALG_CTR</td>
<td>0x0040</td>
<td>S E</td>
<td></td>
<td>A</td>
<td>ISO/IEC 10116</td>
<td>Counter mode – if implemented, all symmetric block ciphers (S type)
implemented shall be capable of using this mode.</td>
</tr>
<tr class="odd">
<td>TPM_ALG_OFB</td>
<td>0x0041</td>
<td>S E</td>
<td></td>
<td>A</td>
<td>ISO/IEC 10116</td>
<td>Output Feedback mode – if implemented, all symmetric block ciphers
(S type) implemented shall be capable of using this mode.</td>
</tr>
<tr class="even">
<td>TPM_ALG_CBC</td>
<td>0x0042</td>
<td>S E</td>
<td></td>
<td>A</td>
<td>ISO/IEC 10116</td>
<td>Cipher Block Chaining mode – if implemented, all symmetric block
ciphers (S type) implemented shall be capable of using this mode.</td>
</tr>
<tr class="odd">
<td>TPM_ALG_CFB</td>
<td>0x0043</td>
<td>S E</td>
<td></td>
<td>S</td>
<td>ISO/IEC 10116</td>
<td>Cipher Feedback mode – if implemented, all symmetric block ciphers
(S type) implemented shall be capable of using this mode.</td>
</tr>
<tr class="even">
<td>TPM_ALG_ECB</td>
<td>0x0044</td>
<td>S E</td>
<td></td>
<td>A</td>
<td>ISO/IEC 10116</td>
<td><p>Electronic Codebook mode – if implemented, all symmetric block
ciphers (S type) implemented shall be capable of using this mode.</p>
<p>NOTE 2 This mode is not recommended for uses unless the key is
frequently rotated such as in video codecs</p></td>
</tr>
<tr class="odd">
<td>reserved</td>
<td>0x00C1 through 0x00C6</td>
<td></td>
<td></td>
<td></td>
<td></td>
<td>0x00C1 – 0x00C6 are reserved to prevent any overlap with the command
structure tags used in TPM 1.2</td>
</tr>
<tr class="even">
<td>reserved</td>
<td>0x8000 through 0xFFFF</td>
<td></td>
<td></td>
<td></td>
<td></td>
<td>reserved for other structure tags</td>
</tr>
</tbody>
</table>

## TPM_ECC_CURVE

The TCG maintains a registry of all curves that have an assigned curve
identifier. That registry is the definitive list of curves that may be
supported by a TPM.

Table 10 is a copy of the TPM_ECC_CURVE constants table in the TCG
registry as of the date of publication of this specification. Table 10
is provided for illustrative purposes only.

<span id="_Ref335120390" class="anchor"></span>Table 10 — Definition of
(UINT16) {ECC} TPM_ECC_CURVE Constants \<IN/OUT\>

| Name              | Value  | Comments               |
|-------------------|--------|------------------------|
| +TPM_ECC_NONE     | 0x0000 |                        |
| TPM_ECC_NIST_P192 | 0x0001 |                        |
| TPM_ECC_NIST_P224 | 0x0002 |                        |
| TPM_ECC_NIST_P256 | 0x0003 |                        |
| TPM_ECC_NIST_P384 | 0x0004 |                        |
| TPM_ECC_NIST_P521 | 0x0005 |                        |
| TPM_ECC_BN_P256   | 0x0010 | curve to support ECDAA |
| TPM_ECC_BN_P638   | 0x0011 | curve to support ECDAA |
| TPM_ECC_SM2_P256  | 0x0020 |                        |
| TPM_ECC_TEST_P192 | 0x0021 |                        |
| \#TPM_RC_CURVE    |        |                        |

## TPM_CC (Command Codes)

### Format

A command is a 32-bit structure with fields assigned as shown in
Figure 1. If V is SET, the command is vendor specific. If V is CLEAR,
the command is not vendor specific.

<table>
<colgroup>
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
</colgroup>
<tbody>
<tr class="odd">
<td><p>3</p>
<p>1</p></td>
<td><p>3</p>
<p>0</p></td>
<td><p>2</p>
<p>9</p></td>
<td><p>2</p>
<p>8</p></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td><p>1</p>
<p>6</p></td>
<td><p>1</p>
<p>5</p></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td><p>0</p>
<p>0</p></td>
</tr>
<tr class="even">
<td colspan="2">Res</td>
<td>V</td>
<td colspan="13">Reserved</td>
<td colspan="16">Command Index</td>
</tr>
</tbody>
</table>

<span id="_Ref345831282" class="anchor"></span>Figure 1 — Command Format

<span id="_Toc380749699" class="anchor"></span>Table 11 — TPM Command
Format Fields Description

| Bit   | Name          | Definition               |
|-------|---------------|--------------------------|
| 15:0  | Command Index | the index of the command |
| 28:16 | Reserved      | shall be zero            |
| 29    | V             | vendor specific          |
| 31:30 | Res           | shall be zero            |

### TPM_CC Listing

Table 12 lists the command codes assigned to each command name. The Dep
column indicates whether the command has a dependency on the
implementation of a specific algorithm.<span id="_Ref518051117"
class="anchor"></span>

Table 12 — Definition of (UINT32) TPM_CC Constants (Numeric Order)
\<IN/OUT, S\>

| Name                              | Command Code   | Dep   | Comments                                                |
|-----------------------------------|----------------|-------|---------------------------------------------------------|
| TPM_CC_FIRST                      | 0x0000011F     |       | Compile variable. May decrease based on implementation. |
| TPM_CC_NV_UndefineSpaceSpecial    | 0x0000011F     |       |                                                         |
| TPM_CC_EvictControl               | 0x00000120     |       |                                                         |
| TPM_CC_HierarchyControl           | 0x00000121     |       |                                                         |
| TPM_CC_NV_UndefineSpace           | 0x00000122     |       |                                                         |
| TPM_CC_ChangeEPS                  | 0x00000124     |       |                                                         |
| TPM_CC_ChangePPS                  | 0x00000125     |       |                                                         |
| TPM_CC_Clear                      | 0x00000126     |       |                                                         |
| TPM_CC_ClearControl               | 0x00000127     |       |                                                         |
| TPM_CC_ClockSet                   | 0x00000128     |       |                                                         |
| TPM_CC_HierarchyChangeAuth        | 0x00000129     |       |                                                         |
| TPM_CC_NV_DefineSpace             | 0x0000012A     |       |                                                         |
| TPM_CC_PCR_Allocate               | 0x0000012B     |       |                                                         |
| TPM_CC_PCR_SetAuthPolicy          | 0x0000012C     |       |                                                         |
| TPM_CC_PP_Commands                | 0x0000012D     |       |                                                         |
| TPM_CC_SetPrimaryPolicy           | 0x0000012E     |       |                                                         |
| TPM_CC_FieldUpgradeStart          | 0x0000012F     |       |                                                         |
| TPM_CC_ClockRateAdjust            | 0x00000130     |       |                                                         |
| TPM_CC_CreatePrimary              | 0x00000131     |       |                                                         |
| TPM_CC_NV_GlobalWriteLock         | 0x00000132     |       |                                                         |
| TPM_CC_GetCommandAuditDigest      | 0x00000133     |       |                                                         |
| TPM_CC_NV_Increment               | 0x00000134     |       |                                                         |
| TPM_CC_NV_SetBits                 | 0x00000135     |       |                                                         |
| TPM_CC_NV_Extend                  | 0x00000136     |       |                                                         |
| TPM_CC_NV_Write                   | 0x00000137     |       |                                                         |
| TPM_CC_NV_WriteLock               | 0x00000138     |       |                                                         |
| TPM_CC_DictionaryAttackLockReset  | 0x00000139     |       |                                                         |
| TPM_CC_DictionaryAttackParameters | 0x0000013A     |       |                                                         |
| TPM_CC_NV_ChangeAuth              | 0x0000013B     |       |                                                         |
| TPM_CC_PCR_Event                  | 0x0000013C     |       | PCR                                                     |
| TPM_CC_PCR_Reset                  | 0x0000013D     |       | PCR                                                     |
| TPM_CC_SequenceComplete           | 0x0000013E     |       |                                                         |
| TPM_CC_SetAlgorithmSet            | 0x0000013F     |       |                                                         |
| TPM_CC_SetCommandCodeAuditStatus  | 0x00000140     |       |                                                         |
| TPM_CC_FieldUpgradeData           | 0x00000141     |       |                                                         |
| TPM_CC_IncrementalSelfTest        | 0x00000142     |       |                                                         |
| TPM_CC_SelfTest                   | 0x00000143     |       |                                                         |
| TPM_CC_Startup                    | 0x00000144     |       |                                                         |
| TPM_CC_Shutdown                   | 0x00000145     |       |                                                         |
| TPM_CC_StirRandom                 | 0x00000146     |       |                                                         |
| TPM_CC_ActivateCredential         | 0x00000147     |       |                                                         |
| TPM_CC_Certify                    | 0x00000148     |       |                                                         |
| TPM_CC_PolicyNV                   | 0x00000149     |       | Policy                                                  |
| TPM_CC_CertifyCreation            | 0x0000014A     |       |                                                         |
| TPM_CC_Duplicate                  | 0x0000014B     |       |                                                         |
| TPM_CC_GetTime                    | 0x0000014C     |       |                                                         |
| TPM_CC_GetSessionAuditDigest      | 0x0000014D     |       |                                                         |
| TPM_CC_NV_Read                    | 0x0000014E     |       |                                                         |
| TPM_CC_NV_ReadLock                | 0x0000014F     |       |                                                         |
| TPM_CC_ObjectChangeAuth           | 0x00000150     |       |                                                         |
| TPM_CC_PolicySecret               | 0x00000151     |       | Policy                                                  |
| TPM_CC_Rewrap                     | 0x00000152     |       |                                                         |
| TPM_CC_Create                     | 0x00000153     |       |                                                         |
| TPM_CC_ECDH_ZGen                  | 0x00000154     | ECC   |                                                         |
| TPM_CC_HMAC                       | 0x00000155     | !CMAC | See NOTE 1                                              |
| TPM_CC_MAC                        | 0x00000155     | CMAC  | See NOTE 1                                              |
| TPM_CC_Import                     | 0x00000156     |       |                                                         |
| TPM_CC_Load                       | 0x00000157     |       |                                                         |
| TPM_CC_Quote                      | 0x00000158     |       |                                                         |
| TPM_CC_RSA_Decrypt                | 0x00000159     | RSA   |                                                         |
| TPM_CC_HMAC_Start                 | 0x0000015B     | !CMAC | See NOTE 1                                              |
| TPM_CC_MAC_Start                  | 0x0000015B     | CMAC  | See NOTE 1                                              |
| TPM_CC_SequenceUpdate             | 0x0000015C     |       |                                                         |
| TPM_CC_Sign                       | 0x0000015D     |       |                                                         |
| TPM_CC_Unseal                     | 0x0000015E     |       |                                                         |
| TPM_CC_PolicySigned               | 0x00000160     |       | Policy                                                  |
| TPM_CC_ContextLoad                | 0x00000161     |       | Context                                                 |
| TPM_CC_ContextSave                | 0x00000162     |       | Context                                                 |
| TPM_CC_ECDH_KeyGen                | 0x00000163     | ECC   |                                                         |
| TPM_CC_EncryptDecrypt             | 0x00000164     |       |                                                         |
| TPM_CC_FlushContext               | 0x00000165     |       | Context                                                 |
| TPM_CC_LoadExternal               | 0x00000167     |       |                                                         |
| TPM_CC_MakeCredential             | 0x00000168     |       |                                                         |
| TPM_CC_NV_ReadPublic              | 0x00000169     |       | NV                                                      |
| TPM_CC_PolicyAuthorize            | 0x0000016A     |       | Policy                                                  |
| TPM_CC_PolicyAuthValue            | 0x0000016B     |       | Policy                                                  |
| TPM_CC_PolicyCommandCode          | 0x0000016C     |       | Policy                                                  |
| TPM_CC_PolicyCounterTimer         | 0x0000016D     |       | Policy                                                  |
| TPM_CC_PolicyCpHash               | 0x0000016E     |       | Policy                                                  |
| TPM_CC_PolicyLocality             | 0x0000016F     |       | Policy                                                  |
| TPM_CC_PolicyNameHash             | 0x00000170     |       | Policy                                                  |
| TPM_CC_PolicyOR                   | 0x00000171     |       | Policy                                                  |
| TPM_CC_PolicyTicket               | 0x00000172     |       | Policy                                                  |
| TPM_CC_ReadPublic                 | 0x00000173     |       |                                                         |
| TPM_CC_RSA_Encrypt                | 0x00000174     | RSA   |                                                         |
| TPM_CC_StartAuthSession           | 0x00000176     |       |                                                         |
| TPM_CC_VerifySignature            | 0x00000177     |       |                                                         |
| TPM_CC_ECC_Parameters             | 0x00000178     | ECC   |                                                         |
| TPM_CC_FirmwareRead               | 0x00000179     |       |                                                         |
| TPM_CC_GetCapability              | 0x0000017A     |       |                                                         |
| TPM_CC_GetRandom                  | 0x0000017B     |       |                                                         |
| TPM_CC_GetTestResult              | 0x0000017C     |       |                                                         |
| TPM_CC_Hash                       | 0x0000017D     |       |                                                         |
| TPM_CC_PCR_Read                   | 0x0000017E     |       | PCR                                                     |
| TPM_CC_PolicyPCR                  | 0x0000017F     |       | Policy                                                  |
| TPM_CC_PolicyRestart              | 0x00000180     |       |                                                         |
| TPM_CC_ReadClock                  | 0x00000181     |       |                                                         |
| TPM_CC_PCR_Extend                 | 0x00000182     |       |                                                         |
| TPM_CC_PCR_SetAuthValue           | 0x00000183     |       |                                                         |
| TPM_CC_NV_Certify                 | 0x00000184     |       |                                                         |
| TPM_CC_EventSequenceComplete      | 0x00000185     |       |                                                         |
| TPM_CC_HashSequenceStart          | 0x00000186     |       |                                                         |
| TPM_CC_PolicyPhysicalPresence     | 0x00000187     |       | Policy                                                  |
| TPM_CC_PolicyDuplicationSelect    | 0x00000188     |       | Policy                                                  |
| TPM_CC_PolicyGetDigest            | 0x00000189     |       | Policy                                                  |
| TPM_CC_TestParms                  | 0x0000018A     |       |                                                         |
| TPM_CC_Commit                     | 0x0000018B     | ECC   |                                                         |
| TPM_CC_PolicyPassword             | 0x0000018C     |       | Policy                                                  |
| TPM_CC_ZGen_2Phase                | 0x0000018D     | ECC   |                                                         |
| TPM_CC_EC_Ephemeral               | 0x0000018E     | ECC   |                                                         |
| TPM_CC_PolicyNvWritten            | 0x0000018F     |       | Policy                                                  |
| TPM_CC_PolicyTemplate             | 0x00000190     |       | Policy                                                  |
| TPM_CC_CreateLoaded               | 0x00000191     |       |                                                         |
| TPM_CC_PolicyAuthorizeNV          | 0x00000192     |       | Policy                                                  |
| TPM_CC_EncryptDecrypt2            | 0x00000193     |       |                                                         |
| TPM_CC_AC_GetCapability           | 0x00000194     |       |                                                         |
| TPM_CC_AC_Send                    | 0x00000195     |       |                                                         |
| TPM_CC_Policy_AC_SendSelect       | 0x00000196     |       | Policy                                                  |
| TPM_CC_CertifyX509                | 0x00000197     |       |                                                         |
| TPM_CC_ACT_SetTimeout             | 0x00000198     |       |                                                         |
| TPM_CC_ECC_Encrypt                | 0x00000199     | ECC   |                                                         |
| TPM_CC_ECC_Decrypt                | 0x0000019A     | ECC   |                                                         |
| TPM_CC_LAST                       | 0x0000019A     |       | Compile variable. May increase based on implementation. |
| CC_VEND                           | 0x20000000     |       |                                                         |
| TPM_CC_Vendor_TCG_Test            | CC_VEND+0x0000 |       | Used for testing of command dispatch                    |
| \#TPM_RC_COMMAND_CODE             |                |       |                                                         |

NOTE 1 A TPM may implement either TPM2_HMAC()/TPM2_HMAC_Start() or
TPM2_MAC()/TPM2_MAC_Start() but not both, as they have the same command
code and there is no way to distinguish them. A TPM that supports
TPM2_MAC()/TPM2_MAC_Start() will support any code that was written to
use TPM2_HMAC()/TPM2_HMAC_Start(), but a TPM that supports
TPM2_HMAC()/TPM2_HMAC_Start() will not support a MAC based on symmetric
block ciphers.

## TPM_RC (Response Codes)

### Description

Each return from the TPM has a 32-bit response code. The TPM will always
set the upper 20 bits (31:12) of the response code to 0 00
00<sub>16</sub> and the low-order 12 bits (11:00) will contain the
response code.

When a command succeeds, the TPM shall return TPM_RC_SUCCESS (0
00<sub>16</sub>) and will update any authorization-session nonce
associated with the command.

When a command fails to complete for any reason, the TPM shall return

- a TPM_ST (UINT16) with a value of TPM_TAG_RSP_COMMAND or
  TPM_ST_NO_SESSIONS, followed by

- a UINT32 (*responseSize*) with a value of 10, followed by

- a UINT32 containing a response code with a value other than
  TPM_RC_SUCCESS.

Commands defined in this specification will use a tag of either
TPM_ST_NO_SESSIONS or TPM_ST_SESSIONS. Error responses will use a tag
value of TPM_ST_NO_SESSIONS and the response code will be as defined in
this specification. Commands that use tags defined in the TPM 1.2
specification will use TPM_TAG_RSP_COMMAND in an error and a response
code defined in TPM 1.2.

If the tag of the command is not a recognized command tag, the TPM error
response will differ depending on TPM 1.2 compatibility. If the TPM
supports 1.2 compatibility, the TPM shall return a tag of
TPM_TAG_RSP_COMMAND and an appropriate TPM 1.2 response code (TPM_BADTAG
= 00 00 00 1E<sub>16</sub>). If the TPM does not have compatibility with
TPM 1.2, the TPM shall return TPM_ST_NO_SESSION and a response code of
TPM_RC_TAG.

When a command fails, the TPM shall not update the authorization-session
nonces associated with the command and will not close the authorization
sessions used by the command. Audit digests will not be updated on an
error. Unless noted in the command actions, a command that returns an
error shall leave the state of the TPM as if the command had not been
attempted. The exception to this principle is that a failure due to an
authorization failure may update the dictionary-attack protection
values.

### Response Code Formats

The response codes for this specification are defined such that there is
no overlap between the response codes used for this specification and
those assigned in previous TPM specifications.

The formats defined in this clause only apply when the tag for the
response is TPM_ST_NO_SESSIONS.

The response codes use two different format groups. One group contains
the TPM 1.2 compatible response codes and the response codes for this
specification that are not related to command parameters. The second
group contains the errors that may be associated with a command
parameter, handle, or session.

Figure 2 shows the format for the response codes when bit 7 is zero.

<table style="width:100%;">
<colgroup>
<col style="width: 12%" />
<col style="width: 6%" />
<col style="width: 8%" />
<col style="width: 7%" />
<col style="width: 8%" />
<col style="width: 8%" />
<col style="width: 7%" />
<col style="width: 7%" />
<col style="width: 7%" />
<col style="width: 7%" />
<col style="width: 7%" />
<col style="width: 7%" />
<col style="width: 7%" />
</colgroup>
<thead>
<tr class="header">
<th>bit</th>
<th><p>1</p>
<p>1</p></th>
<th><p>1</p>
<p>0</p></th>
<th><p>0</p>
<p>9</p></th>
<th><p>0</p>
<p>8</p></th>
<th><p>0</p>
<p>7</p></th>
<th><p>0</p>
<p>6</p></th>
<th><p>0</p>
<p>5</p></th>
<th><p>0</p>
<p>4</p></th>
<th><p>0</p>
<p>3</p></th>
<th><p>0</p>
<p>2</p></th>
<th><p>0</p>
<p>1</p></th>
<th><p>0</p>
<p>0</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td></td>
<td>S</td>
<td>T</td>
<td>r</td>
<td>V</td>
<td>F</td>
<td colspan="7">E</td>
</tr>
</tbody>
</table>

<span id="_Ref245368011" class="anchor"></span>Figure 2 — Format-Zero
Response Codes

The field definitions are:

<span id="_Ref283479355" class="anchor"></span>Table 13 — Format-Zero
Response Codes

<table>
<colgroup>
<col style="width: 6%" />
<col style="width: 9%" />
<col style="width: 83%" />
</colgroup>
<thead>
<tr class="header">
<th>Bit</th>
<th>Name</th>
<th>Definition</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>06:00</td>
<td>E</td>
<td><p>the error number</p>
<p>The interpretation of this field is dependent on the setting of the F
and S fields.</p></td>
</tr>
<tr class="even">
<td>07</td>
<td>F</td>
<td><p>format selector</p>
<p><strong>CLEAR</strong> when the format is as defined in this Table 13
or when the response code is TPM_RC_BAD_TAG.</p></td>
</tr>
<tr class="odd">
<td>08</td>
<td>V</td>
<td><p>version</p>
<p><strong>SET (1)</strong>: The error number is defined in this
specification and is returned when the response tag is
TPM_ST_NO_SESSIONS.</p>
<p><strong>CLEAR (0)</strong>: The error number is defined by a previous
TPM specification. The error number is returned when the response tag is
TPM_TAG_RSP_COMMAND.</p>
<p>NOTE In any error number returned by a TPM, the F (bit 7) and V (bit
8) attributes shall be CLEAR when the response tag is
TPM_TAG_RSP_COMMAND value used in TPM 1.2.</p></td>
</tr>
<tr class="even">
<td>09</td>
<td>Reserved</td>
<td>shall be zero.</td>
</tr>
<tr class="odd">
<td>10</td>
<td>T</td>
<td><p>TCG/Vendor indicator</p>
<p><strong>SET (1):</strong> The response code is defined by the TPM
vendor.</p>
<p><strong>CLEAR (0):</strong> The response code is defined by the TCG
(a value in this specification).</p>
<p>NOTE This attribute does not indicate a vendor-specific code unless
the <em>F</em> attribute (bit[07]) is CLEAR.</p></td>
</tr>
<tr class="even">
<td>11</td>
<td>S</td>
<td><p>severity</p>
<p><strong>SET (1)</strong>: The response code is a warning and the
command was not necessarily in error. This command indicates that the
TPM is busy or that the resources of the TPM have to be adjusted in
order to allow the command to execute.</p>
<p><strong>CLEAR (0)</strong>: The response code indicates that the
command had an error that would prevent it from running.</p></td>
</tr>
</tbody>
</table>

When the format bit (bit 7) is SET, then the error occurred during the
unmarshaling or validation of an input parameter to the TPM. Figure 3
shows the format for the response codes when bit 7 is one.

<table>
<colgroup>
<col style="width: 11%" />
<col style="width: 7%" />
<col style="width: 7%" />
<col style="width: 7%" />
<col style="width: 7%" />
<col style="width: 8%" />
<col style="width: 8%" />
<col style="width: 8%" />
<col style="width: 7%" />
<col style="width: 7%" />
<col style="width: 7%" />
<col style="width: 7%" />
<col style="width: 7%" />
</colgroup>
<thead>
<tr class="header">
<th>bit</th>
<th><p>1</p>
<p>1</p></th>
<th><p>1</p>
<p>0</p></th>
<th><p>0</p>
<p>9</p></th>
<th><p>0</p>
<p>8</p></th>
<th><p>0</p>
<p>7</p></th>
<th><p>0</p>
<p>6</p></th>
<th><p>0</p>
<p>5</p></th>
<th><p>0</p>
<p>4</p></th>
<th><p>0</p>
<p>3</p></th>
<th><p>0</p>
<p>2</p></th>
<th><p>0</p>
<p>1</p></th>
<th><p>0</p>
<p>0</p></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td></td>
<td colspan="4">N</td>
<td>1</td>
<td>P</td>
<td colspan="6">E</td>
</tr>
</tbody>
</table>

<span id="_Ref291794972" class="anchor"></span>Figure 3 — Format-One
Response Codes

There are 64 errors with this format. The errors can be associated with
a parameter, handle, or session. The error number for this format is in
bits\[05:00\]. When an error is associated with a parameter, TPM_RC_P (0
40<sub>16)</sub> is added and N is set to the parameter number.

NOTE 1 In the reference implementation, for a RC_FMT1 response code, a
constant of the form RC_Command_parameterName is the one based parameter
number (TPM_RC_n) plus TPM_RC_P.

Example RC_Startup_startupType is the first parameter, TPM_RC_1 (0x100)
plus TPM_RC_P (0x40) or 0x140. TPM_RC_VALUE (RC_FMT1 (0x080) + 0x004) +
RC_Startup_startupType is thus 0x080 + 0x004 + 0x140 = 0x1c4.

For an error associated with a handle, a parameter number (1 to 7) is
added to the N field. For an error associated with a session, a value of
8 plus the session number (1 to 7) is added to the N field. In other
words, if P is clear, then a value of 0 to 7 in the N field will
indicate a handle error, and a value of 8 – 15 will indicate a session
error.

NOTE 2 If an implementation is not able to designate the handle,
session, or parameter in error, then P and N will be zero.

The field definitions are:

<span id="_Toc380749703" class="anchor"></span>Table 14 — Format-One
Response Codes

<table>
<colgroup>
<col style="width: 6%" />
<col style="width: 7%" />
<col style="width: 85%" />
</colgroup>
<thead>
<tr class="header">
<th>Bit</th>
<th>Name</th>
<th>Definition</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>05:00</td>
<td>E</td>
<td><p>the error number</p>
<p>The error number is independent of the other settings.</p></td>
</tr>
<tr class="even">
<td>06</td>
<td>P</td>
<td><p><strong>SET (1):</strong> The error is associated with a
parameter.</p>
<p><strong>CLEAR (0):</strong> The error is associated with a handle or
a session.</p></td>
</tr>
<tr class="odd">
<td>07</td>
<td>F</td>
<td><p>the response code format selector</p>
<p>This field shall be SET for the format in this table.</p></td>
</tr>
<tr class="even">
<td>11:08</td>
<td>N</td>
<td><p>the number of the handle, session, or parameter in error. The
number is one based. See TPM_RC_1 through TPM_RC_F.</p>
<p>If P is SET, then this field is the parameter in error.</p>
<p>If P is CLEAR, then this field indicates the handle or session in
error. Handles use values of N between 0000<sub>2</sub> and
0111<sub>2</sub>. Sessions use values between 1000<sub>2</sub> and
1111<sub>2</sub>.</p>
<p>NOTE Bit 11 distinguishes between handles and sessions. Bits 10:8
000<sub>2</sub> indicate that the number is unspecified.</p></td>
</tr>
</tbody>
</table>

The groupings of response codes are determined by bits 08, 07, and 06 of
the response code as summarized in Table 15.

<span id="_Ref278372048" class="anchor"></span>Table 15 — Response Code
Groupings

<table>
<colgroup>
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 90%" />
</colgroup>
<thead>
<tr class="header">
<th colspan="3">Bit</th>
<th rowspan="2">Definition</th>
</tr>
<tr class="odd">
<th>08</th>
<th>07</th>
<th>06</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>0</td>
<td>0</td>
<td>x</td>
<td><p>a response code defined by TPM 1.2</p>
<p>NOTE An “x” in a column indicates that this may be either 0 or 1 and
not affect the grouping of the response code.</p></td>
</tr>
<tr class="even">
<td>1</td>
<td>0</td>
<td>x</td>
<td>a response code defined by this specification with no handle,
session, or parameter number modifier</td>
</tr>
<tr class="odd">
<td>x</td>
<td>1</td>
<td>0</td>
<td>a response code defined by this specification with either a handle
or session number modifier</td>
</tr>
<tr class="even">
<td>x</td>
<td>1</td>
<td>1</td>
<td>a response code defined by this specification with a parameter
number modifier</td>
</tr>
</tbody>
</table>

### TPM_RC Values

In general, response codes defined in TPM 2.0 Part 2 will be
unmarshaling errors and will have the F (format) bit SET. Codes that are
unique to TPM 2.0 Part 3 will have the F bit CLEAR but the V (version)
attribute will be SET to indicate that it is a TPM 2.0 response code.
See *Response Code Details* in TPM 2.0 Part 1.

NOTE The constant RC_VER1 is used to indicate that the V attribute is
SET and the constant RC_FMT1 is used to indicate that the F attribute is
SET and that the return code is variable based on handle, session, and
parameter modifiers.

<span id="_Ref282778736" class="anchor"></span>Table 16 — Definition of
(UINT32) TPM_RC Constants (Actions) \<OUT\>

<table>
<colgroup>
<col style="width: 33%" />
<col style="width: 20%" />
<col style="width: 45%" />
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
<td>TPM_RC_SUCCESS</td>
<td>0x000</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_RC_BAD_TAG</td>
<td>0x01E</td>
<td>defined for compatibility with TPM 1.2</td>
</tr>
<tr class="odd">
<td>RC_VER1</td>
<td>0x100</td>
<td>set for all format 0 response codes</td>
</tr>
<tr class="even">
<td>TPM_RC_INITIALIZE</td>
<td>RC_VER1 + 0x000</td>
<td>TPM not initialized by TPM2_Startup or already initialized</td>
</tr>
<tr class="odd">
<td>TPM_RC_FAILURE</td>
<td>RC_VER1 + 0x001</td>
<td><p>commands not being accepted because of a TPM failure</p>
<p>NOTE This may be returned by TPM2_GetTestResult() as the
<em>testResult</em> parameter.</p></td>
</tr>
<tr class="even">
<td>TPM_RC_SEQUENCE</td>
<td>RC_VER1 + 0x003</td>
<td>improper use of a sequence handle</td>
</tr>
<tr class="odd">
<td>TPM_RC_PRIVATE</td>
<td>RC_VER1 + 0x00B</td>
<td>not currently used</td>
</tr>
<tr class="even">
<td>TPM_RC_HMAC</td>
<td>RC_VER1 + 0x019</td>
<td>not currently used</td>
</tr>
<tr class="odd">
<td>TPM_RC_DISABLED</td>
<td>RC_VER1 + 0x020</td>
<td>the command is disabled</td>
</tr>
<tr class="even">
<td>TPM_RC_EXCLUSIVE</td>
<td>RC_VER1 + 0x021</td>
<td>command failed because audit sequence required exclusivity</td>
</tr>
<tr class="odd">
<td>TPM_RC_AUTH_TYPE</td>
<td>RC_VER1 + 0x024</td>
<td>authorization handle is not correct for command</td>
</tr>
<tr class="even">
<td>TPM_RC_AUTH_MISSING</td>
<td>RC_VER1 + 0x025</td>
<td>command requires an authorization session for handle and it is not
present.</td>
</tr>
<tr class="odd">
<td>TPM_RC_POLICY</td>
<td>RC_VER1 + 0x026</td>
<td>policy failure in math operation or an invalid authPolicy value</td>
</tr>
<tr class="even">
<td>TPM_RC_PCR</td>
<td>RC_VER1 + 0x027</td>
<td>PCR check fail</td>
</tr>
<tr class="odd">
<td>TPM_RC_PCR_CHANGED</td>
<td>RC_VER1 + 0x028</td>
<td>PCR have changed since checked.</td>
</tr>
<tr class="even">
<td>TPM_RC_UPGRADE</td>
<td>RC_VER1 + 0x02D</td>
<td>for all commands other than TPM2_FieldUpgradeData(), this code
indicates that the TPM is in field upgrade mode; for
TPM2_FieldUpgradeData(), this code indicates that the TPM is not in
field upgrade mode</td>
</tr>
<tr class="odd">
<td>TPM_RC_TOO_MANY_CONTEXTS</td>
<td>RC_VER1 + 0x02E</td>
<td>context ID counter is at maximum.</td>
</tr>
<tr class="even">
<td>TPM_RC_AUTH_UNAVAILABLE</td>
<td>RC_VER1 + 0x02F</td>
<td>authValue or authPolicy is not available for selected entity.</td>
</tr>
<tr class="odd">
<td>TPM_RC_REBOOT</td>
<td>RC_VER1 + 0x030</td>
<td>a _TPM_Init and Startup(CLEAR) is required before the TPM can resume
operation.</td>
</tr>
<tr class="even">
<td>TPM_RC_UNBALANCED</td>
<td>RC_VER1 + 0x031</td>
<td>the protection algorithms (hash and symmetric) are not reasonably
balanced. The digest size of the hash must be larger than the key size
of the symmetric algorithm.</td>
</tr>
<tr class="odd">
<td>TPM_RC_COMMAND_SIZE</td>
<td>RC_VER1 + 0x042</td>
<td>command <em>commandSize</em> value is inconsistent with contents of
the command buffer; either the size is not the same as the octets loaded
by the hardware interface layer or the value is not large enough to hold
a command header</td>
</tr>
<tr class="even">
<td>TPM_RC_COMMAND_CODE</td>
<td>RC_VER1 + 0x043</td>
<td>command code not supported</td>
</tr>
<tr class="odd">
<td>TPM_RC_AUTHSIZE</td>
<td>RC_VER1 + 0x044</td>
<td>the value of <em>authorizationSize</em> is out of range or the
number of octets in the Authorization Area is greater than required</td>
</tr>
<tr class="even">
<td>TPM_RC_AUTH_CONTEXT</td>
<td>RC_VER1 + 0x045</td>
<td>use of an authorization session with a context command or another
command that cannot have an authorization session.</td>
</tr>
<tr class="odd">
<td>TPM_RC_NV_RANGE</td>
<td>RC_VER1 + 0x046</td>
<td>NV offset+size is out of range.</td>
</tr>
<tr class="even">
<td>TPM_RC_NV_SIZE</td>
<td>RC_VER1 + 0x047</td>
<td>Requested allocation size is larger than allowed.</td>
</tr>
<tr class="odd">
<td>TPM_RC_NV_LOCKED</td>
<td>RC_VER1 + 0x048</td>
<td>NV access locked.</td>
</tr>
<tr class="even">
<td>TPM_RC_NV_AUTHORIZATION</td>
<td>RC_VER1 + 0x049</td>
<td>NV access authorization fails in command actions (this failure does
not affect lockout.action)</td>
</tr>
<tr class="odd">
<td>TPM_RC_NV_UNINITIALIZED</td>
<td>RC_VER1 + 0x04A</td>
<td>an NV Index is used before being initialized or the state saved by
TPM2_Shutdown(STATE) could not be restored</td>
</tr>
<tr class="even">
<td>TPM_RC_NV_SPACE</td>
<td>RC_VER1 + 0x04B</td>
<td>insufficient space for NV allocation</td>
</tr>
<tr class="odd">
<td>TPM_RC_NV_DEFINED</td>
<td>RC_VER1 + 0x04C</td>
<td>NV Index or persistent object already defined</td>
</tr>
<tr class="even">
<td>TPM_RC_BAD_CONTEXT</td>
<td>RC_VER1 + 0x050</td>
<td>context in TPM2_ContextLoad() is not valid</td>
</tr>
<tr class="odd">
<td>TPM_RC_CPHASH</td>
<td>RC_VER1 + 0x051</td>
<td>cpHash value already set or not correct for use</td>
</tr>
<tr class="even">
<td>TPM_RC_PARENT</td>
<td>RC_VER1 + 0x052</td>
<td>handle for parent is not a valid parent</td>
</tr>
<tr class="odd">
<td>TPM_RC_NEEDS_TEST</td>
<td>RC_VER1 + 0x053</td>
<td>some function needs testing.</td>
</tr>
<tr class="even">
<td>TPM_RC_NO_RESULT</td>
<td>RC_VER1 + 0x054</td>
<td>returned when an internal function cannot process a request due to
an unspecified problem. This code is usually related to invalid
parameters that are not properly filtered by the input unmarshaling
code.</td>
</tr>
<tr class="odd">
<td>TPM_RC_SENSITIVE</td>
<td>RC_VER1 + 0x055</td>
<td>the sensitive area did not unmarshal correctly after decryption –
this code is used in lieu of the other unmarshaling errors so that an
attacker cannot determine where the unmarshaling error occurred</td>
</tr>
<tr class="even">
<td>RC_MAX_FM0</td>
<td>RC_VER1 + 0x07F</td>
<td>largest version 1 code that is not a warning</td>
</tr>
<tr class="odd">
<td></td>
<td></td>
<td>New Subsection</td>
</tr>
<tr class="even">
<td>RC_FMT1</td>
<td>0x080</td>
<td><p>This bit is SET in all format 1 response codes</p>
<p>The codes in this group may have a value added to them to indicate
the handle, session, or parameter to which they apply.</p></td>
</tr>
<tr class="odd">
<td>TPM_RC_ASYMMETRIC</td>
<td>RC_FMT1 + 0x001</td>
<td>asymmetric algorithm not supported or not correct</td>
</tr>
<tr class="even">
<td>TPM_RC_ATTRIBUTES</td>
<td>RC_FMT1 + 0x002</td>
<td>inconsistent attributes</td>
</tr>
<tr class="odd">
<td>TPM_RC_HASH</td>
<td>RC_FMT1 + 0x003</td>
<td>hash algorithm not supported or not appropriate</td>
</tr>
<tr class="even">
<td>TPM_RC_VALUE</td>
<td>RC_FMT1 + 0x004</td>
<td>value is out of range or is not correct for the context</td>
</tr>
<tr class="odd">
<td>TPM_RC_HIERARCHY</td>
<td>RC_FMT1 + 0x005</td>
<td>hierarchy is not enabled or is not correct for the use</td>
</tr>
<tr class="even">
<td>TPM_RC_KEY_SIZE</td>
<td>RC_FMT1 + 0x007</td>
<td>key size is not supported</td>
</tr>
<tr class="odd">
<td>TPM_RC_MGF</td>
<td>RC_FMT1 + 0x008</td>
<td>mask generation function not supported</td>
</tr>
<tr class="even">
<td>TPM_RC_MODE</td>
<td>RC_FMT1 + 0x009</td>
<td>mode of operation not supported</td>
</tr>
<tr class="odd">
<td>TPM_RC_TYPE</td>
<td>RC_FMT1 + 0x00A</td>
<td>the type of the value is not appropriate for the use</td>
</tr>
<tr class="even">
<td>TPM_RC_HANDLE</td>
<td>RC_FMT1 + 0x00B</td>
<td>the handle is not correct for the use</td>
</tr>
<tr class="odd">
<td>TPM_RC_KDF</td>
<td>RC_FMT1 + 0x00C</td>
<td>unsupported key derivation function or function not appropriate for
use</td>
</tr>
<tr class="even">
<td>TPM_RC_RANGE</td>
<td>RC_FMT1 + 0x00D</td>
<td>value was out of allowed range.</td>
</tr>
<tr class="odd">
<td>TPM_RC_AUTH_FAIL</td>
<td>RC_FMT1 + 0x00E</td>
<td>the authorization HMAC check failed and DA counter incremented</td>
</tr>
<tr class="even">
<td>TPM_RC_NONCE</td>
<td>RC_FMT1 + 0x00F</td>
<td>invalid nonce size or nonce value mismatch</td>
</tr>
<tr class="odd">
<td>TPM_RC_PP</td>
<td>RC_FMT1 + 0x010</td>
<td>authorization requires assertion of PP</td>
</tr>
<tr class="even">
<td>TPM_RC_SCHEME</td>
<td>RC_FMT1 + 0x012</td>
<td>unsupported or incompatible scheme</td>
</tr>
<tr class="odd">
<td>TPM_RC_SIZE</td>
<td>RC_FMT1 + 0x015</td>
<td>structure is the wrong size</td>
</tr>
<tr class="even">
<td>TPM_RC_SYMMETRIC</td>
<td>RC_FMT1 + 0x016</td>
<td>unsupported symmetric algorithm or key size, or not appropriate for
instance</td>
</tr>
<tr class="odd">
<td>TPM_RC_TAG</td>
<td>RC_FMT1 + 0x017</td>
<td>incorrect structure tag</td>
</tr>
<tr class="even">
<td>TPM_RC_SELECTOR</td>
<td>RC_FMT1 + 0x018</td>
<td>union selector is incorrect</td>
</tr>
<tr class="odd">
<td>TPM_RC_INSUFFICIENT</td>
<td>RC_FMT1 + 0x01A</td>
<td>the TPM was unable to unmarshal a value because there were not
enough octets in the input buffer</td>
</tr>
<tr class="even">
<td>TPM_RC_SIGNATURE</td>
<td>RC_FMT1 + 0x01B</td>
<td>the signature is not valid</td>
</tr>
<tr class="odd">
<td>TPM_RC_KEY</td>
<td>RC_FMT1 + 0x01C</td>
<td>key fields are not compatible with the selected use</td>
</tr>
<tr class="even">
<td>TPM_RC_POLICY_FAIL</td>
<td>RC_FMT1 + 0x01D</td>
<td>a policy check failed</td>
</tr>
<tr class="odd">
<td>TPM_RC_INTEGRITY</td>
<td>RC_FMT1 + 0x01F</td>
<td>integrity check failed</td>
</tr>
<tr class="even">
<td>TPM_RC_TICKET</td>
<td>RC_FMT1 + 0x020</td>
<td>invalid ticket</td>
</tr>
<tr class="odd">
<td>TPM_RC_RESERVED_BITS</td>
<td>RC_FMT1 + 0x021</td>
<td>reserved bits not set to zero as required</td>
</tr>
<tr class="even">
<td>TPM_RC_BAD_AUTH</td>
<td>RC_FMT1 + 0x022</td>
<td>authorization failure without DA implications</td>
</tr>
<tr class="odd">
<td>TPM_RC_EXPIRED</td>
<td>RC_FMT1 + 0x023</td>
<td>the policy has expired</td>
</tr>
<tr class="even">
<td>TPM_RC_POLICY_CC</td>
<td>RC_FMT1 + 0x024</td>
<td>the <em>commandCode</em> in the policy is not the
<em>commandCode</em> of the command or the command code in a policy
command references a command that is not implemented</td>
</tr>
<tr class="odd">
<td>TPM_RC_BINDING</td>
<td>RC_FMT1 + 0x025</td>
<td>public and sensitive portions of an object are not cryptographically
bound</td>
</tr>
<tr class="even">
<td>TPM_RC_CURVE</td>
<td>RC_FMT1 + 0x026</td>
<td>curve not supported</td>
</tr>
<tr class="odd">
<td>TPM_RC_ECC_POINT</td>
<td>RC_FMT1 + 0x027</td>
<td>point is not on the required curve.</td>
</tr>
<tr class="even">
<td></td>
<td></td>
<td></td>
</tr>
<tr class="odd">
<td></td>
<td></td>
<td>New Subsection</td>
</tr>
<tr class="even">
<td>RC_WARN</td>
<td>0x900</td>
<td>set for warning response codes</td>
</tr>
<tr class="odd">
<td>TPM_RC_CONTEXT_GAP</td>
<td>RC_WARN + 0x001</td>
<td>gap for context ID is too large</td>
</tr>
<tr class="even">
<td>TPM_RC_OBJECT_MEMORY</td>
<td>RC_WARN + 0x002</td>
<td>out of memory for object contexts</td>
</tr>
<tr class="odd">
<td>TPM_RC_SESSION_MEMORY</td>
<td>RC_WARN + 0x003</td>
<td>out of memory for session contexts</td>
</tr>
<tr class="even">
<td>TPM_RC_MEMORY</td>
<td>RC_WARN + 0x004</td>
<td>out of shared object/session memory or need space for internal
operations</td>
</tr>
<tr class="odd">
<td>TPM_RC_SESSION_HANDLES</td>
<td>RC_WARN + 0x005</td>
<td>out of session handles – a session must be flushed before a new
session may be created</td>
</tr>
<tr class="even">
<td>TPM_RC_OBJECT_HANDLES</td>
<td>RC_WARN + 0x006</td>
<td><p>out of object handles – the handle space for objects is depleted
and a reboot is required</p>
<p>NOTE 1 This cannot occur on the reference implementation.</p>
<p>NOTE 2 There is no reason why an implementation would implement a
design that would deplete handle space. Platform specifications are
encouraged to forbid it.</p></td>
</tr>
<tr class="odd">
<td>TPM_RC_LOCALITY</td>
<td>RC_WARN + 0x007</td>
<td>bad locality</td>
</tr>
<tr class="even">
<td>TPM_RC_YIELDED</td>
<td>RC_WARN + 0x008</td>
<td><p>the TPM has suspended operation on the command; forward progress
was made and the command may be retried</p>
<p>See TPM 2.0 Part 1, “Multi-tasking.”</p>
<p>NOTE This cannot occur on the reference implementation.</p></td>
</tr>
<tr class="odd">
<td>TPM_RC_CANCELED</td>
<td>RC_WARN + 0x009</td>
<td>the command was canceled</td>
</tr>
<tr class="even">
<td>TPM_RC_TESTING</td>
<td>RC_WARN + 0x00A</td>
<td>TPM is performing self-tests</td>
</tr>
<tr class="odd">
<td>TPM_RC_REFERENCE_H0</td>
<td>RC_WARN + 0x010</td>
<td>the 1<sup>st</sup> handle in the handle area references a transient
object or session that is not loaded</td>
</tr>
<tr class="even">
<td>TPM_RC_REFERENCE_H1</td>
<td>RC_WARN + 0x011</td>
<td>the 2<sup>nd</sup> handle in the handle area references a transient
object or session that is not loaded</td>
</tr>
<tr class="odd">
<td>TPM_RC_REFERENCE_H2</td>
<td>RC_WARN + 0x012</td>
<td>the 3<sup>rd</sup> handle in the handle area references a transient
object or session that is not loaded</td>
</tr>
<tr class="even">
<td>TPM_RC_REFERENCE_H3</td>
<td>RC_WARN + 0x013</td>
<td>the 4<sup>th</sup> handle in the handle area references a transient
object or session that is not loaded</td>
</tr>
<tr class="odd">
<td>TPM_RC_REFERENCE_H4</td>
<td>RC_WARN + 0x014</td>
<td>the 5<sup>th</sup> handle in the handle area references a transient
object or session that is not loaded</td>
</tr>
<tr class="even">
<td>TPM_RC_REFERENCE_H5</td>
<td>RC_WARN + 0x015</td>
<td>the 6<sup>th</sup> handle in the handle area references a transient
object or session that is not loaded</td>
</tr>
<tr class="odd">
<td>TPM_RC_REFERENCE_H6</td>
<td>RC_WARN + 0x016</td>
<td>the 7<sup>th</sup> handle in the handle area references a transient
object or session that is not loaded</td>
</tr>
<tr class="even">
<td>TPM_RC_REFERENCE_S0</td>
<td>RC_WARN + 0x018</td>
<td>the 1<sup>st</sup> authorization session handle references a session
that is not loaded</td>
</tr>
<tr class="odd">
<td>TPM_RC_REFERENCE_S1</td>
<td>RC_WARN + 0x019</td>
<td>the 2<sup>nd</sup> authorization session handle references a session
that is not loaded</td>
</tr>
<tr class="even">
<td>TPM_RC_REFERENCE_S2</td>
<td>RC_WARN + 0x01A</td>
<td>the 3<sup>rd</sup> authorization session handle references a session
that is not loaded</td>
</tr>
<tr class="odd">
<td>TPM_RC_REFERENCE_S3</td>
<td>RC_WARN + 0x01B</td>
<td>the 4th authorization session handle references a session that is
not loaded</td>
</tr>
<tr class="even">
<td>TPM_RC_REFERENCE_S4</td>
<td>RC_WARN + 0x01C</td>
<td>the 5<sup>th</sup> session handle references a session that is not
loaded</td>
</tr>
<tr class="odd">
<td>TPM_RC_REFERENCE_S5</td>
<td>RC_WARN + 0x01D</td>
<td>the 6<sup>th</sup> session handle references a session that is not
loaded</td>
</tr>
<tr class="even">
<td>TPM_RC_REFERENCE_S6</td>
<td>RC_WARN + 0x01E</td>
<td>the 7<sup>th</sup> authorization session handle references a session
that is not loaded</td>
</tr>
<tr class="odd">
<td>TPM_RC_NV_RATE</td>
<td>RC_WARN + 0x020</td>
<td>the TPM is rate-limiting accesses to prevent wearout of NV</td>
</tr>
<tr class="even">
<td>TPM_RC_LOCKOUT</td>
<td>RC_WARN + 0x021</td>
<td>authorizations for objects subject to DA protection are not allowed
at this time because the TPM is in DA lockout mode</td>
</tr>
<tr class="odd">
<td>TPM_RC_RETRY</td>
<td>RC_WARN + 0x022</td>
<td>the TPM was not able to start the command</td>
</tr>
<tr class="even">
<td>TPM_RC_NV_UNAVAILABLE</td>
<td>RC_WARN + 0x023</td>
<td>the command may require writing of NV and NV is not current
accessible</td>
</tr>
<tr class="odd">
<td>TPM_RC_NOT_USED</td>
<td>RC_WARN + 0x7F</td>
<td>this value is reserved and shall not be returned by the TPM</td>
</tr>
<tr class="even">
<td></td>
<td></td>
<td>Additional Defines</td>
</tr>
<tr class="odd">
<td>TPM_RC_H</td>
<td>0x000</td>
<td>add to a handle-related error</td>
</tr>
<tr class="even">
<td>TPM_RC_P</td>
<td>0x040</td>
<td>add to a parameter-related error</td>
</tr>
<tr class="odd">
<td>TPM_RC_S</td>
<td>0x800</td>
<td>add to a session-related error</td>
</tr>
<tr class="even">
<td>TPM_RC_1</td>
<td>0x100</td>
<td>add to a parameter-, handle-, or session-related error</td>
</tr>
<tr class="odd">
<td>TPM_RC_2</td>
<td>0x200</td>
<td>add to a parameter-, handle-, or session-related error</td>
</tr>
<tr class="even">
<td>TPM_RC_3</td>
<td>0x300</td>
<td>add to a parameter-, handle-, or session-related error</td>
</tr>
<tr class="odd">
<td>TPM_RC_4</td>
<td>0x400</td>
<td>add to a parameter-, handle-, or session-related error</td>
</tr>
<tr class="even">
<td>TPM_RC_5</td>
<td>0x500</td>
<td>add to a parameter-, handle-, or session-related error</td>
</tr>
<tr class="odd">
<td>TPM_RC_6</td>
<td>0x600</td>
<td>add to a parameter-, handle-, or session-related error</td>
</tr>
<tr class="even">
<td>TPM_RC_7</td>
<td>0x700</td>
<td>add to a parameter-, handle-, or session-related error</td>
</tr>
<tr class="odd">
<td>TPM_RC_8</td>
<td>0x800</td>
<td>add to a parameter-related error</td>
</tr>
<tr class="even">
<td>TPM_RC_9</td>
<td>0x900</td>
<td>add to a parameter-related error</td>
</tr>
<tr class="odd">
<td>TPM_RC_A</td>
<td>0xA00</td>
<td>add to a parameter-related error</td>
</tr>
<tr class="even">
<td>TPM_RC_B</td>
<td>0xB00</td>
<td>add to a parameter-related error</td>
</tr>
<tr class="odd">
<td>TPM_RC_C</td>
<td>0xC00</td>
<td>add to a parameter-related error</td>
</tr>
<tr class="even">
<td>TPM_RC_D</td>
<td>0xD00</td>
<td>add to a parameter-related error</td>
</tr>
<tr class="odd">
<td>TPM_RC_E</td>
<td>0xE00</td>
<td>add to a parameter-related error</td>
</tr>
<tr class="even">
<td>TPM_RC_F</td>
<td>0xF00</td>
<td>add to a parameter-related error</td>
</tr>
<tr class="odd">
<td>TPM_RC_N_MASK</td>
<td>0xF00</td>
<td>number mask</td>
</tr>
</tbody>
</table>

## TPM_CLOCK_ADJUST

A TPM_CLOCK_ADJUST value is used to change the rate at which the TPM
internal oscillator is divided. A change to the divider will change the
rate at which *Clock* and *Time* change.

NOTE The recommended adjustments are approximately 1% for a course
adjustment, 0.1% for a medium adjustment, and the minimum possible on
the implementation for the fine adjustment (e.g., one count of the
pre-scalar if possible).

<span id="_Toc380749706" class="anchor"></span>Table 17 — Definition of
(INT8) TPM_CLOCK_ADJUST Constants \<IN\>

|                         |       |                                                              |
|-------------------------|-------|--------------------------------------------------------------|
| Name                    | Value | Comments                                                     |
| TPM_CLOCK_COARSE_SLOWER | -3    | Slow the *Clock* update rate by one coarse adjustment step.  |
| TPM_CLOCK_MEDIUM_SLOWER | -2    | Slow the *Clock* update rate by one medium adjustment step.  |
| TPM_CLOCK_FINE_SLOWER   | -1    | Slow the *Clock* update rate by one fine adjustment step.    |
| TPM_CLOCK_NO_CHANGE     | 0     | No change to the *Clock* update rate.                        |
| TPM_CLOCK_FINE_FASTER   | 1     | Speed the *Clock* update rate by one fine adjustment step.   |
| TPM_CLOCK_MEDIUM_FASTER | 2     | Speed the *Clock* update rate by one medium adjustment step. |
| TPM_CLOCK_COARSE_FASTER | 3     | Speed the *Clock* update rate by one coarse adjustment step. |
| \#TPM_RC_VALUE          |       |                                                              |

## TPM_EO (EA Arithmetic Operands)

<span id="_Toc380749707" class="anchor"></span>Table 18 — Definition of
(UINT16) TPM_EO Constants \<IN/OUT\>

|                    |        |                                                             |
|--------------------|--------|-------------------------------------------------------------|
| Operation Name     | Value  | Comments                                                    |
| TPM_EO_EQ          | 0x0000 | A = B                                                       |
| TPM_EO_NEQ         | 0x0001 | A ≠ B                                                       |
| TPM_EO_SIGNED_GT   | 0x0002 | A \> B signed                                               |
| TPM_EO_UNSIGNED_GT | 0x0003 | A \> B unsigned                                             |
| TPM_EO_SIGNED_LT   | 0x0004 | A \< B signed                                               |
| TPM_EO_UNSIGNED_LT | 0x0005 | A \< B unsigned                                             |
| TPM_EO_SIGNED_GE   | 0x0006 | A ≥ B signed                                                |
| TPM_EO_UNSIGNED_GE | 0x0007 | A ≥ B unsigned                                              |
| TPM_EO_SIGNED_LE   | 0x0008 | A ≤ B signed                                                |
| TPM_EO_UNSIGNED_LE | 0x0009 | A ≤ B unsigned                                              |
| TPM_EO_BITSET      | 0x000A | All bits SET in B are SET in A. ((A&B)=B)                   |
| TPM_EO_BITCLEAR    | 0x000B | All bits SET in B are CLEAR in A. ((A&B)=0)                 |
| \#TPM_RC_VALUE     |        | Response code returned when unmarshaling of this type fails |

## TPM_ST (Structure Tags)

Structure tags are used to disambiguate structures. They are 16-bit
values with the most significant bit SET so that they do not overlap
TPM_ALG_ID values. A single exception is made for the value associated
with TPM_ST_RSP_COMMAND (0x00C4), which has the same value as the
TPM_TAG_RSP_COMMAND tag from earlier versions of this specification.
This value is used when the TPM is compatible with a previous TPM
specification and the TPM cannot determine which family of response code
to return because the command tag is not valid.

Many of the structures defined in this document have parameters that are
unions of other structures. That is, a parameter may be one of several
structures. The parameter will have a selector value that indicates
which of the options is actually present.

In order to allow the marshaling and unmarshaling code to determine
which of the possible structures is allowed, each selector will have a
unique interface type and will constrain the number of possible tag
values.

Table 19 defines the structure tags values. The definition of many
structures is context-sensitive using an algorithm ID. In cases where an
algorithm ID is not a meaningful way to designate the structure, the
values in this table are used.

<span id="_Ref214083845" class="anchor"></span>Table 19 — Definition of
(UINT16) TPM_ST Constants \<IN/OUT, S\>

<table>
<colgroup>
<col style="width: 38%" />
<col style="width: 10%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th>Name</th>
<th>Value</th>
<th>Comments</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>TPM_ST_RSP_COMMAND</td>
<td>0x00C4</td>
<td><p><em>tag</em> value for a response; used when there is an error in
the tag. This is also the value returned from a TPM 1.2 when an error
occurs. This value is used in this specification because an error in the
command tag may prevent determination of the family. When this tag is
used in the response, the response code will be TPM_RC_BAD_TAG (0
1E<sub>16</sub>), which has the same numeric value as the TPM 1.2
response code for TPM_BADTAG.</p>
<p>NOTE In a previously published version of this specification,
TPM_RC_BAD_TAG was incorrectly assigned a value of 0x030 instead of 30
(0x01e). Some implementations my return the old value instead of the new
value.</p></td>
</tr>
<tr class="even">
<td>TPM_ST_NULL</td>
<td>0X8000</td>
<td>no structure type specified</td>
</tr>
<tr class="odd">
<td>TPM_ST_NO_SESSIONS</td>
<td>0x8001</td>
<td><p><em>tag</em> value for a command/response for a command defined
in this specification; indicating that the command/response has no
attached sessions and no
<em>authorizationSize</em>/<em>parameterSize</em> value is present</p>
<p>If the <em>responseCode</em> from the TPM is not TPM_RC_SUCCESS, then
the response tag shall have this value.</p></td>
</tr>
<tr class="even">
<td>TPM_ST_SESSIONS</td>
<td>0x8002</td>
<td><em>tag</em> value for a command/response for a command defined in
this specification; indicating that the command/response has one or more
attached sessions and the
<em>authorizationSize</em>/<em>parameterSize</em> field is present</td>
</tr>
<tr class="odd">
<td>reserved</td>
<td>0x8003</td>
<td><p>When used between application software and the TPM resource
manager, this tag indicates that the command has no sessions and the
handles are using the Name format rather than the 32-bit handle
format.</p>
<p>NOTE 1 The response to application software will have a <em>tag</em>
of TPM_ST_NO_SESSIONS.</p>
<p>Between the TRM and TPM, this tag would occur in a response from a
TPM that overlaps the <em>tag</em> parameter of a request with the
<em>tag</em> parameter of a response, when the response has no
associated sessions.</p>
<p>NOTE 2 This tag is not used by all TPM or TRM
implementations.</p></td>
</tr>
<tr class="even">
<td>reserved</td>
<td>0x8004</td>
<td><p>When used between application software and the TPM resource
manager, this tag indicates that the command has sessions and the
handles are using the Name format rather than the 32-bit handle
format.</p>
<p>NOTE 1 If the command completes successfully, the response to
application software will have a <em>tag</em> of TPM_ST_SESSIONS.</p>
<p>Between the TRM and TPM, would occur in a response from a TPM that
overlaps the <em>tag</em> parameter of a request with the <em>tag</em>
parameter of a response, when the response has authorization
sessions.</p>
<p>NOTE 2 This tag is not used by all TPM or TRM
implementations.</p></td>
</tr>
<tr class="odd">
<td>TPM_ST_ATTEST_NV</td>
<td>0x8014</td>
<td>tag for an attestation structure</td>
</tr>
<tr class="even">
<td>TPM_ST_ATTEST_COMMAND_AUDIT</td>
<td>0x8015</td>
<td>tag for an attestation structure</td>
</tr>
<tr class="odd">
<td>TPM_ST_ATTEST_SESSION_AUDIT</td>
<td>0x8016</td>
<td>tag for an attestation structure</td>
</tr>
<tr class="even">
<td>TPM_ST_ATTEST_CERTIFY</td>
<td>0x8017</td>
<td>tag for an attestation structure</td>
</tr>
<tr class="odd">
<td>TPM_ST_ATTEST_QUOTE</td>
<td>0x8018</td>
<td>tag for an attestation structure</td>
</tr>
<tr class="even">
<td>TPM_ST_ATTEST_TIME</td>
<td>0x8019</td>
<td>tag for an attestation structure</td>
</tr>
<tr class="odd">
<td>TPM_ST_ATTEST_CREATION</td>
<td>0x801A</td>
<td>tag for an attestation structure</td>
</tr>
<tr class="even">
<td>reserved</td>
<td>0x801B</td>
<td><p>do not use</p>
<p>NOTE This was previously assigned to TPM_ST_ATTEST_NV. The tag is
changed because the structure has changed</p></td>
</tr>
<tr class="odd">
<td>TPM_ST_ATTEST_NV_DIGEST</td>
<td>0x801C</td>
<td>tag for an attestation structure</td>
</tr>
<tr class="even">
<td>TPM_ST_CREATION</td>
<td>0x8021</td>
<td>tag for a ticket type</td>
</tr>
<tr class="odd">
<td>TPM_ST_VERIFIED</td>
<td>0x8022</td>
<td>tag for a ticket type</td>
</tr>
<tr class="even">
<td>TPM_ST_AUTH_SECRET</td>
<td>0x8023</td>
<td>tag for a ticket type</td>
</tr>
<tr class="odd">
<td>TPM_ST_HASHCHECK</td>
<td>0x8024</td>
<td>tag for a ticket type</td>
</tr>
<tr class="even">
<td>TPM_ST_AUTH_SIGNED</td>
<td>0x8025</td>
<td>tag for a ticket type</td>
</tr>
<tr class="odd">
<td>TPM_ST_FU_MANIFEST</td>
<td>0x8029</td>
<td>tag for a structure describing a Field Upgrade Policy</td>
</tr>
</tbody>
</table>

## TPM_SU (Startup Type)

These values are used in TPM2_Startup() to indicate the shutdown and
startup mode. The defined startup sequences are:

1)  TPM Reset – Two cases:

<!-- -->

1)  Shutdown(CLEAR) followed by Startup(CLEAR)

2)  Startup(CLEAR) with no Shutdown()

3)  TPM Restart – Shutdown(STATE) followed by Startup(CLEAR)

4)  TPM Resume – Shutdown(STATE) followed by Startup(STATE)

TPM_SU values of 80 00<sub>16</sub> and above are reserved for internal
use of the TPM and may not be assigned values.

NOTE In the reference code, a value of FF FF<sub>16</sub> indicates that
the startup state has not been set. If this was defined in this table to
be, say, TPM_SU_NONE, then TPM_SU_NONE would be a valid input value but
the caller is not allowed to indicate the that the startup type is
TPM_SU_NONE so the reserved value is defined in the implementation as
required for internal TPM uses.

<span id="_Ref291502828" class="anchor"></span>Table 20 — Definition of
(UINT16) TPM_SU Constants \<IN\>

<table>
<colgroup>
<col style="width: 31%" />
<col style="width: 12%" />
<col style="width: 55%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Name</td>
<td>Value</td>
<td>Description</td>
</tr>
<tr class="even">
<td>TPM_SU_CLEAR</td>
<td>0x0000</td>
<td><p>on TPM2_Shutdown(), indicates that the TPM should prepare for
loss of power and save state required for an orderly startup (TPM
Reset).</p>
<p>on TPM2_Startup(), indicates that the TPM should perform TPM Reset or
TPM Restart</p></td>
</tr>
<tr class="odd">
<td>TPM_SU_STATE</td>
<td>0x0001</td>
<td><p>on TPM2_Shutdown(), indicates that the TPM should prepare for
loss of power and save state required for an orderly startup (TPM
Restart or TPM Resume)</p>
<p>on TPM2_Startup(), indicates that the TPM should restore the state
saved by TPM2_Shutdown(TPM_SU_STATE)</p></td>
</tr>
<tr class="even">
<td>#TPM_RC_VALUE</td>
<td></td>
<td>response code when incorrect value is used</td>
</tr>
</tbody>
</table>

## TPM_SE (Session Type)

This type is used in TPM2_StartAuthSession() to indicate the type of the
session to be created.

<span id="_Toc380749710" class="anchor"></span>Table 21 — Definition of
(UINT8) TPM_SE Constants \<IN\>

<table>
<colgroup>
<col style="width: 31%" />
<col style="width: 12%" />
<col style="width: 56%" />
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
<td>TPM_SE_HMAC</td>
<td>0x00</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_SE_POLICY</td>
<td>0x01</td>
<td></td>
</tr>
<tr class="odd">
<td>TPM_SE_TRIAL</td>
<td>0x03</td>
<td><p>The policy session is being used to compute the
<em>policyHash</em> and not for command authorization.</p>
<p>This setting modifies some policy commands and prevents session from
being used to authorize a command.</p></td>
</tr>
<tr class="even">
<td>#TPM_RC_VALUE</td>
<td></td>
<td>response code when incorrect value is used</td>
</tr>
</tbody>
</table>

## TPM_CAP (Capabilities)

The TPM_CAP values are used in TPM2_GetCapability() to select the type
of the value to be returned. The format of the response varies according
to the type of the value.

<span id="_Toc380749711" class="anchor"></span>Table 22 — Definition of
(UINT32) TPM_CAP Constants

<table>
<colgroup>
<col style="width: 31%" />
<col style="width: 12%" />
<col style="width: 23%" />
<col style="width: 33%" />
</colgroup>
<thead>
<tr class="header">
<th>Capability Name</th>
<th>Value</th>
<th>Property Type</th>
<th>Return Type</th>
</tr>
<tr class="odd">
<th>TPM_CAP_FIRST</th>
<th>0x00000000</th>
<th></th>
<th></th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>TPM_CAP_ALGS</td>
<td>0x00000000</td>
<td>TPM_ALG_ID<sup>(1)</sup></td>
<td>TPML_ALG_PROPERTY</td>
</tr>
<tr class="even">
<td>TPM_CAP_HANDLES</td>
<td>0x00000001</td>
<td>TPM_HANDLE</td>
<td>TPML_HANDLE</td>
</tr>
<tr class="odd">
<td>TPM_CAP_COMMANDS</td>
<td>0x00000002</td>
<td>TPM_CC</td>
<td>TPML_CCA</td>
</tr>
<tr class="even">
<td>TPM_CAP_PP_COMMANDS</td>
<td>0x00000003</td>
<td>TPM_CC</td>
<td>TPML_CC</td>
</tr>
<tr class="odd">
<td>TPM_CAP_AUDIT_COMMANDS</td>
<td>0x00000004</td>
<td>TPM_CC</td>
<td>TPML_CC</td>
</tr>
<tr class="even">
<td>TPM_CAP_PCRS</td>
<td>0x00000005</td>
<td>reserved</td>
<td>TPML_PCR_SELECTION</td>
</tr>
<tr class="odd">
<td>TPM_CAP_TPM_PROPERTIES</td>
<td>0x00000006</td>
<td>TPM_PT</td>
<td>TPML_TAGGED_TPM_PROPERTY</td>
</tr>
<tr class="even">
<td>TPM_CAP_PCR_PROPERTIES</td>
<td>0x00000007</td>
<td>TPM_PT_PCR</td>
<td>TPML_TAGGED_PCR_PROPERTY</td>
</tr>
<tr class="odd">
<td>TPM_CAP_ECC_CURVES</td>
<td>0x00000008</td>
<td>TPM_ECC_CURVE<sup>(1)</sup></td>
<td>TPML_ECC_CURVE</td>
</tr>
<tr class="even">
<td>TPM_CAP_AUTH_POLICIES</td>
<td>0x00000009</td>
<td>TPM_HANDLE<sup>(2)(3)</sup></td>
<td>TPML_TAGGED_POLICY</td>
</tr>
<tr class="odd">
<td>TPM_CAP_ACT</td>
<td>0x0000000A</td>
<td>TPM_HANDLE<sup>(2(4))</sup></td>
<td>TPML_ACT_DATA</td>
</tr>
<tr class="even">
<td>TPM_CAP_LAST</td>
<td>0x0000000A</td>
<td></td>
<td></td>
</tr>
<tr class="odd">
<td>TPM_CAP_VENDOR_PROPERTY</td>
<td>0x00000100</td>
<td>manufacturer specific</td>
<td>manufacturer-specific values</td>
</tr>
<tr class="even">
<td>#TPM_RC_VALUE</td>
<td></td>
<td></td>
<td></td>
</tr>
<tr class="odd">
<td colspan="4"><p>NOTES:</p>
<p>(1) The TPM_ALG_ID or TPM_ECC_CURVE is cast to a UINT32</p>
<p>(2) The TPM will return TPM_RC_VALUE if the handle does not reference
the range for permanent handles.</p>
<p>(3) TPM_CAP_AUTH_POLICIES was added in revision 01.32.</p>
<p>(4) TPM_CAP_ACT was added in revision 01.57.</p></td>
</tr>
</tbody>
</table>

## TPM_PT (Property Tag)

The TPM_PT constants are used in TPM2_GetCapability(capability =
TPM_CAP_TPM_PROPERTIES) to indicate the property being selected or
returned.

The values in the fixed group (PT_FIXED) are not changeable through
programmatic means other than a firmware update. The values in the
variable group (PT_VAR) may be changed with TPM commands but should be
persistent over power cycles and only changed when indicated by the
detailed actions code.

<span id="_Toc380749712" class="anchor"></span>Table 23 — Definition of
(UINT32) TPM_PT Constants \<IN/OUT, S\>

<table>
<colgroup>
<col style="width: 34%" />
<col style="width: 14%" />
<col style="width: 50%" />
</colgroup>
<thead>
<tr class="header">
<th>Capability Name</th>
<th>Value</th>
<th>Comments</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>TPM_PT_NONE</td>
<td>0x00000000</td>
<td>indicates no property type</td>
</tr>
<tr class="even">
<td>PT_GROUP</td>
<td>0x00000100</td>
<td><p>The number of properties in each group.</p>
<p>NOTE The first group with any properties is group 1 (PT_GROUP * 1).
Group 0 is reserved.</p></td>
</tr>
<tr class="odd">
<td>PT_FIXED</td>
<td>PT_GROUP * 1</td>
<td><p>the group of fixed properties returned as
TPMS_TAGGED_PROPERTY</p>
<p>The values in this group are only changed due to a firmware change in
the TPM.</p></td>
</tr>
<tr class="even">
<td>TPM_PT_FAMILY_INDICATOR</td>
<td>PT_FIXED + 0</td>
<td>a 4-octet character string containing the TPM Family value
(TPM_SPEC_FAMILY)</td>
</tr>
<tr class="odd">
<td>TPM_PT_LEVEL</td>
<td>PT_FIXED + 1</td>
<td><p>the level of the specification</p>
<p>NOTE 1 For this specification, the level is zero.</p>
<p>NOTE 2 The level is on the title page of the specification.</p></td>
</tr>
<tr class="even">
<td>TPM_PT_REVISION</td>
<td>PT_FIXED + 2</td>
<td><p>the specification Revision times 100</p>
<p>EXAMPLE Revision 01.01 would have a value of 101.</p>
<p>NOTE The Revision value is on the title page of the
specification.</p></td>
</tr>
<tr class="odd">
<td>TPM_PT_DAY_OF_YEAR</td>
<td>PT_FIXED + 3</td>
<td><p>the specification day of year using TCG calendar</p>
<p>EXAMPLE November 15, 2010, has a day of year value of 319
(00 00 01 3F<sub>16</sub>).</p>
<p>NOTE The specification date is on the title page of the specification
or errata (see 6.1).</p></td>
</tr>
<tr class="even">
<td>TPM_PT_YEAR</td>
<td>PT_FIXED + 4</td>
<td><p>the specification year using the CE</p>
<p>EXAMPLE The year 2010 has a value of 00 00 07 DA<sub>16</sub>.</p>
<p>NOTE The specification date is on the title page of the specification
or errata (see 6.1).</p></td>
</tr>
<tr class="odd">
<td>TPM_PT_MANUFACTURER</td>
<td>PT_FIXED + 5</td>
<td>the vendor ID unique to each TPM manufacturer</td>
</tr>
<tr class="even">
<td>TPM_PT_VENDOR_STRING_1</td>
<td>PT_FIXED + 6</td>
<td><p>the first four characters of the vendor ID string</p>
<p>NOTE When the vendor string is fewer than 16 octets, the additional
property values do not have to be present. A vendor string of 4 octets
can be represented in one 32-bit value and no null terminating character
is required.</p></td>
</tr>
<tr class="odd">
<td>TPM_PT_VENDOR_STRING_2</td>
<td>PT_FIXED + 7</td>
<td>the second four characters of the vendor ID string</td>
</tr>
<tr class="even">
<td>TPM_PT_VENDOR_STRING_3</td>
<td>PT_FIXED + 8</td>
<td>the third four characters of the vendor ID string</td>
</tr>
<tr class="odd">
<td>TPM_PT_VENDOR_STRING_4</td>
<td>PT_FIXED + 9</td>
<td>the fourth four characters of the vendor ID sting</td>
</tr>
<tr class="even">
<td>TPM_PT_VENDOR_TPM_TYPE</td>
<td>PT_FIXED + 10</td>
<td>vendor-defined value indicating the TPM model</td>
</tr>
<tr class="odd">
<td>TPM_PT_FIRMWARE_VERSION_1</td>
<td>PT_FIXED + 11</td>
<td>the most-significant 32 bits of a TPM vendor-specific value
indicating the version number of the firmware. See 10.12.2 and
10.12.12.</td>
</tr>
<tr class="even">
<td>TPM_PT_FIRMWARE_VERSION_2</td>
<td>PT_FIXED + 12</td>
<td>the least-significant 32 bits of a TPM vendor-specific value
indicating the version number of the firmware. See 10.12.2 and
10.12.12.</td>
</tr>
<tr class="odd">
<td>TPM_PT_INPUT_BUFFER</td>
<td>PT_FIXED + 13</td>
<td>the maximum size of a parameter (typically, a TPM2B_MAX_BUFFER)</td>
</tr>
<tr class="even">
<td>TPM_PT_HR_TRANSIENT_MIN</td>
<td>PT_FIXED + 14</td>
<td><p>the minimum number of transient objects that can be held in TPM
RAM</p>
<p>NOTE This minimum shall be no less than the minimum value required by
the platform-specific specification to which the TPM is built.</p></td>
</tr>
<tr class="odd">
<td>TPM_PT_HR_PERSISTENT_MIN</td>
<td>PT_FIXED + 15</td>
<td><p>the minimum number of persistent objects that can be held in TPM
NV memory</p>
<p>NOTE This minimum shall be no less than the minimum value required by
the platform-specific specification to which the TPM is built.</p></td>
</tr>
<tr class="even">
<td>TPM_PT_HR_LOADED_MIN</td>
<td>PT_FIXED + 16</td>
<td><p>the minimum number of authorization sessions that can be held in
TPM RAM</p>
<p>NOTE This minimum shall be no less than the minimum value required by
the platform-specific specification to which the TPM is built.</p></td>
</tr>
<tr class="odd">
<td>TPM_PT_ACTIVE_SESSIONS_MAX</td>
<td>PT_FIXED + 17</td>
<td><p>the number of authorization sessions that may be active at a
time</p>
<p>A session is active when it has a context associated with its handle.
The context may either be in TPM RAM or be context saved.</p>
<p>NOTE This value shall be no less than the minimum value required by
the platform-specific specification to which the TPM is built.</p></td>
</tr>
<tr class="even">
<td>TPM_PT_PCR_COUNT</td>
<td>PT_FIXED + 18</td>
<td><p>the number of PCR implemented</p>
<p>NOTE This number is determined by the defined attributes, not the
number of PCR that are populated.</p></td>
</tr>
<tr class="odd">
<td>TPM_PT_PCR_SELECT_MIN</td>
<td>PT_FIXED + 19</td>
<td><p>the minimum number of octets in a
TPMS_PCR_SELECT.<em>sizeOfSelect</em></p>
<p>NOTE This value is not determined by the number of PCR implemented
but by the number of PCR required by the platform-specific specification
with which the TPM is compliant or by the implementer if not adhering to
a platform-specific specification.</p></td>
</tr>
<tr class="even">
<td>TPM_PT_CONTEXT_GAP_MAX</td>
<td>PT_FIXED + 20</td>
<td><p>the maximum allowed difference (unsigned) between the
<em>contextID</em> values of two saved session contexts</p>
<p>This value shall be 2<sup>n</sup>-1, where n is at least 16.</p></td>
</tr>
<tr class="odd">
<td></td>
<td>PT_FIXED + 21</td>
<td>skipped</td>
</tr>
<tr class="even">
<td>TPM_PT_NV_COUNTERS_MAX</td>
<td>PT_FIXED + 22</td>
<td><p>the maximum number of NV Indexes that are allowed to have the
TPM_NT_COUNTER attribute</p>
<p>NOTE 1 It is allowed for this value to be larger than the number of
NV Indexes that can be defined. This would be indicative of a TPM
implementation that did not use different implementation technology for
different NV Index types.</p>
<p>NOTE 2 The value zero indicates that there is no fixed maximum. The
number of counter indexes is determined by the available NV memory
pool.</p></td>
</tr>
<tr class="odd">
<td>TPM_PT_NV_INDEX_MAX</td>
<td>PT_FIXED + 23</td>
<td>the maximum size of an NV Index data area</td>
</tr>
<tr class="even">
<td>TPM_PT_MEMORY</td>
<td>PT_FIXED + 24</td>
<td>a TPMA_MEMORY indicating the memory management method for the
TPM</td>
</tr>
<tr class="odd">
<td>TPM_PT_CLOCK_UPDATE</td>
<td>PT_FIXED + 25</td>
<td>interval, in milliseconds, between updates to the copy of
TPMS_CLOCK_INFO.<em>clock</em> in NV</td>
</tr>
<tr class="even">
<td>TPM_PT_CONTEXT_HASH</td>
<td>PT_FIXED + 26</td>
<td>the algorithm used for the integrity HMAC on saved contexts and for
hashing the <em>fuData</em> of TPM2_FirmwareRead()</td>
</tr>
<tr class="odd">
<td>TPM_PT_CONTEXT_SYM</td>
<td>PT_FIXED + 27</td>
<td>TPM_ALG_ID, the algorithm used for encryption of saved contexts</td>
</tr>
<tr class="even">
<td>TPM_PT_CONTEXT_SYM_SIZE</td>
<td>PT_FIXED + 28</td>
<td>TPM_KEY_BITS, the size of the key used for encryption of saved
contexts</td>
</tr>
<tr class="odd">
<td>TPM_PT_ORDERLY_COUNT</td>
<td>PT_FIXED + 29</td>
<td><p>the modulus - 1 of the count for NV update of an orderly
counter</p>
<p>The returned value is MAX_ORDERLY_COUNT.</p>
<p>This will have a value of 2<sup>N</sup> – 1 where 1 ≤ N ≤ 32</p>
<p>NOTE 1 An “orderly counter” is an NV Index with an TPM_NT of
TPM_NV_COUNTER and TPMA_NV_ORDERLY SET.</p>
<p>NOTE 2 When the low-order bits of a counter equal this value, an NV
write occurs on the next increment.</p></td>
</tr>
<tr class="even">
<td>TPM_PT_MAX_COMMAND_SIZE</td>
<td>PT_FIXED + 30</td>
<td>the maximum value for <em>commandSize</em> in a command</td>
</tr>
<tr class="odd">
<td>TPM_PT_MAX_RESPONSE_SIZE</td>
<td>PT_FIXED + 31</td>
<td>the maximum value for <em>responseSize</em> in a response</td>
</tr>
<tr class="even">
<td>TPM_PT_MAX_DIGEST</td>
<td>PT_FIXED + 32</td>
<td>the maximum size of a digest that can be produced by the TPM</td>
</tr>
<tr class="odd">
<td>TPM_PT_MAX_OBJECT_CONTEXT</td>
<td>PT_FIXED + 33</td>
<td>the maximum size of an object context that will be returned by
TPM2_ContextSave</td>
</tr>
<tr class="even">
<td>TPM_PT_MAX_SESSION_CONTEXT</td>
<td>PT_FIXED + 34</td>
<td>the maximum size of a session context that will be returned by
TPM2_ContextSave</td>
</tr>
<tr class="odd">
<td>TPM_PT_PS_FAMILY_INDICATOR</td>
<td>PT_FIXED + 35</td>
<td><p>platform-specific family (a TPM_PS value)(see Table 25)</p>
<p>NOTE The platform-specific values for the TPM_PT_PS parameters are in
the relevant platform-specific specification. In the reference
implementation, all of these values are 0.</p></td>
</tr>
<tr class="even">
<td>TPM_PT_PS_LEVEL</td>
<td>PT_FIXED + 36</td>
<td>the level of the platform-specific specification</td>
</tr>
<tr class="odd">
<td>TPM_PT_PS_REVISION</td>
<td>PT_FIXED + 37</td>
<td>a platform specific value</td>
</tr>
<tr class="even">
<td>TPM_PT_PS_DAY_OF_YEAR</td>
<td>PT_FIXED + 38</td>
<td><p>the platform-specific TPM specification day of year using TCG
calendar</p>
<p>EXAMPLE November 15, 2010, has a day of year value of 319
(00 00 01 3F<sub>16</sub>).</p></td>
</tr>
<tr class="odd">
<td>TPM_PT_PS_YEAR</td>
<td>PT_FIXED + 39</td>
<td><p>the platform-specific TPM specification year using the CE</p>
<p>EXAMPLE The year 2010 has a value of
00 00 07 DA<sub>16</sub>.</p></td>
</tr>
<tr class="even">
<td>TPM_PT_SPLIT_MAX</td>
<td>PT_FIXED + 40</td>
<td>the number of split signing operations supported by the TPM</td>
</tr>
<tr class="odd">
<td>TPM_PT_TOTAL_COMMANDS</td>
<td>PT_FIXED + 41</td>
<td>total number of commands implemented in the TPM</td>
</tr>
<tr class="even">
<td>TPM_PT_LIBRARY_COMMANDS</td>
<td>PT_FIXED + 42</td>
<td>number of commands from the TPM library that are implemented</td>
</tr>
<tr class="odd">
<td>TPM_PT_VENDOR_COMMANDS</td>
<td>PT_FIXED + 43</td>
<td>number of vendor commands that are implemented</td>
</tr>
<tr class="even">
<td>TPM_PT_NV_BUFFER_MAX</td>
<td>PT_FIXED + 44</td>
<td>the maximum data size in one NV write, NV read, NV extend, or NV
certify command</td>
</tr>
<tr class="odd">
<td>TPM_PT_MODES</td>
<td>PT_FIXED + 45</td>
<td>a TPMA_MODES value, indicating that the TPM is designed for these
modes.</td>
</tr>
<tr class="even">
<td>TPM_PT_MAX_CAP_BUFFER</td>
<td>PT_FIXED + 46</td>
<td>the maximum size of a TPMS_CAPABILITY_DATA structure returned in
TPM2_GetCapability().</td>
</tr>
<tr class="odd">
<td></td>
<td></td>
<td>Intentionally left empty</td>
</tr>
<tr class="even">
<td>PT_VAR</td>
<td>PT_GROUP * 2</td>
<td><p>the group of variable properties returned as
TPMS_TAGGED_PROPERTY</p>
<p>The properties in this group change because of a Protected Capability
other than a firmware update. The values are not necessarily persistent
across all power transitions.</p></td>
</tr>
<tr class="odd">
<td>TPM_PT_PERMANENT</td>
<td>PT_VAR + 0</td>
<td>TPMA_PERMANENT</td>
</tr>
<tr class="even">
<td>TPM_PT_STARTUP_CLEAR</td>
<td>PT_VAR + 1</td>
<td>TPMA_STARTUP_CLEAR</td>
</tr>
<tr class="odd">
<td>TPM_PT_HR_NV_INDEX</td>
<td>PT_VAR + 2</td>
<td>the number of NV Indexes currently defined</td>
</tr>
<tr class="even">
<td>TPM_PT_HR_LOADED</td>
<td>PT_VAR + 3</td>
<td>the number of authorization sessions currently loaded into TPM
RAM</td>
</tr>
<tr class="odd">
<td>TPM_PT_HR_LOADED_AVAIL</td>
<td>PT_VAR + 4</td>
<td><p>the number of additional authorization sessions, of any type,
that could be loaded into TPM RAM</p>
<p>This value is an estimate. If this value is at least 1, then at least
one authorization session of any type may be loaded. Any command that
changes the RAM memory allocation can make this estimate invalid.</p>
<p>NOTE A valid implementation may return 1 even if more than one
authorization session would fit into RAM.</p></td>
</tr>
<tr class="even">
<td>TPM_PT_HR_ACTIVE</td>
<td>PT_VAR + 5</td>
<td><p>the number of active authorization sessions currently being
tracked by the TPM</p>
<p>This is the sum of the loaded and saved sessions.</p></td>
</tr>
<tr class="odd">
<td>TPM_PT_HR_ACTIVE_AVAIL</td>
<td>PT_VAR + 6</td>
<td><p>the number of additional authorization sessions, of any type,
that could be created</p>
<p>This value is an estimate. If this value is at least 1, then at least
one authorization session of any type may be created. Any command that
changes the RAM memory allocation can make this estimate invalid.</p>
<p>NOTE A valid implementation may return 1 even if more than one
authorization session could be created.</p></td>
</tr>
<tr class="even">
<td>TPM_PT_HR_TRANSIENT_AVAIL</td>
<td>PT_VAR + 7</td>
<td><p>estimate of the number of additional transient objects that could
be loaded into TPM RAM</p>
<p>This value is an estimate. If this value is at least 1, then at least
one object of any type may be loaded. Any command that changes the
memory allocation can make this estimate invalid.</p>
<p>NOTE A valid implementation may return 1 even if more than one
transient object would fit into RAM.</p></td>
</tr>
<tr class="odd">
<td>TPM_PT_HR_PERSISTENT</td>
<td>PT_VAR + 8</td>
<td>the number of persistent objects currently loaded into TPM NV
memory</td>
</tr>
<tr class="even">
<td>TPM_PT_HR_PERSISTENT_AVAIL</td>
<td>PT_VAR + 9</td>
<td><p>the number of additional persistent objects that could be loaded
into NV memory</p>
<p>This value is an estimate. If this value is at least 1, then at least
one object of any type may be made persistent. Any command that changes
the NV memory allocation can make this estimate invalid.</p>
<p>NOTE A valid implementation may return 1 even if more than one
persistent object would fit into NV memory.</p></td>
</tr>
<tr class="odd">
<td>TPM_PT_NV_COUNTERS</td>
<td>PT_VAR + 10</td>
<td>the number of defined NV Indexes that have NV the TPM_NT_COUNTER
attribute</td>
</tr>
<tr class="even">
<td>TPM_PT_NV_COUNTERS_AVAIL</td>
<td>PT_VAR + 11</td>
<td><p>the number of additional NV Indexes that can be defined with
their TPM_NT of TPM_NV_COUNTER and the TPMA_NV_ORDERLY attribute SET</p>
<p>This value is an estimate. If this value is at least 1, then at least
one NV Index may be created with a TPM_NT of TPM_NV_COUNTER and the
TPMA_NV_ORDERLY attributes. Any command that changes the NV memory
allocation can make this estimate invalid.</p>
<p>NOTE A valid implementation may return 1 even if more than one NV
counter could be defined.</p></td>
</tr>
<tr class="odd">
<td>TPM_PT_ALGORITHM_SET</td>
<td>PT_VAR + 12</td>
<td>code that limits the algorithms that may be used with the TPM</td>
</tr>
<tr class="even">
<td>TPM_PT_LOADED_CURVES</td>
<td>PT_VAR + 13</td>
<td>the number of loaded ECC curves</td>
</tr>
<tr class="odd">
<td>TPM_PT_LOCKOUT_COUNTER</td>
<td>PT_VAR + 14</td>
<td>the current value of the lockout counter (<em>failedTries</em>)</td>
</tr>
<tr class="even">
<td>TPM_PT_MAX_AUTH_FAIL</td>
<td>PT_VAR + 15</td>
<td>the number of authorization failures before DA lockout is
invoked</td>
</tr>
<tr class="odd">
<td>TPM_PT_LOCKOUT_INTERVAL</td>
<td>PT_VAR + 16</td>
<td>the number of seconds before the value reported by
TPM_PT_LOCKOUT_COUNTER is decremented</td>
</tr>
<tr class="even">
<td>TPM_PT_LOCKOUT_RECOVERY</td>
<td>PT_VAR + 17</td>
<td>the number of seconds after a lockoutAuth failure before use of
lockoutAuth may be attempted again</td>
</tr>
<tr class="odd">
<td>TPM_PT_NV_WRITE_RECOVERY</td>
<td>PT_VAR + 18</td>
<td><p>number of milliseconds before the TPM will accept another command
that will modify NV</p>
<p>This value is an approximation and may go up or down over
time.</p></td>
</tr>
<tr class="even">
<td>TPM_PT_AUDIT_COUNTER_0</td>
<td>PT_VAR + 19</td>
<td>the high-order 32 bits of the command audit counter</td>
</tr>
<tr class="odd">
<td>TPM_PT_AUDIT_COUNTER_1</td>
<td>PT_VAR + 20</td>
<td>the low-order 32 bits of the command audit counter</td>
</tr>
</tbody>
</table>

## TPM_PT_PCR (PCR Property Tag)

The TPM_PT_PCR constants are used in TPM2_GetCapability() to indicate
the property being selected or returned. The PCR properties can be read
when *capability* == TPM_CAP_PCR_PROPERTIES. If there is no property
that corresponds to the value of *property*, the next higher value is
returned, if it exists.

<span id="_Toc380749713" class="anchor"></span>Table 24 — Definition of
(UINT32) TPM_PT_PCR Constants \<IN/OUT, S\>

<table>
<colgroup>
<col style="width: 30%" />
<col style="width: 13%" />
<col style="width: 55%" />
</colgroup>
<thead>
<tr class="header">
<th>Capability Name</th>
<th>Value</th>
<th>Comments</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>TPM_PT_PCR_FIRST</td>
<td>0x00000000</td>
<td>bottom of the range of TPM_PT_PCR properties</td>
</tr>
<tr class="even">
<td>TPM_PT_PCR_SAVE</td>
<td>0x00000000</td>
<td>a SET bit in the TPMS_PCR_SELECT indicates that the PCR is saved and
restored by TPM_SU_STATE</td>
</tr>
<tr class="odd">
<td>TPM_PT_PCR_EXTEND_L0</td>
<td>0x00000001</td>
<td><p>a SET bit in the TPMS_PCR_SELECT indicates that the PCR may be
extended from locality 0</p>
<p>This property is only present if a locality other than 0 is
implemented.</p></td>
</tr>
<tr class="even">
<td>TPM_PT_PCR_RESET_L0</td>
<td>0x00000002</td>
<td>a SET bit in the TPMS_PCR_SELECT indicates that the PCR may be reset
by TPM2_PCR_Reset() from locality 0</td>
</tr>
<tr class="odd">
<td>TPM_PT_PCR_EXTEND_L1</td>
<td>0x00000003</td>
<td><p>a SET bit in the TPMS_PCR_SELECT indicates that the PCR may be
extended from locality 1</p>
<p>This property is only present if locality 1 is implemented.</p></td>
</tr>
<tr class="even">
<td>TPM_PT_PCR_RESET_L1</td>
<td>0x00000004</td>
<td><p>a SET bit in the TPMS_PCR_SELECT indicates that the PCR may be
reset by TPM2_PCR_Reset() from locality 1</p>
<p>This property is only present if locality 1 is implemented.</p></td>
</tr>
<tr class="odd">
<td>TPM_PT_PCR_EXTEND_L2</td>
<td>0x00000005</td>
<td><p>a SET bit in the TPMS_PCR_SELECT indicates that the PCR may be
extended from locality 2</p>
<p>This property is only present if localities 1 and 2 are
implemented.</p></td>
</tr>
<tr class="even">
<td>TPM_PT_PCR_RESET_L2</td>
<td>0x00000006</td>
<td><p>a SET bit in the TPMS_PCR_SELECT indicates that the PCR may be
reset by TPM2_PCR_Reset() from locality 2</p>
<p>This property is only present if localities 1 and 2 are
implemented.</p></td>
</tr>
<tr class="odd">
<td>TPM_PT_PCR_EXTEND_L3</td>
<td>0x00000007</td>
<td><p>a SET bit in the TPMS_PCR_SELECT indicates that the PCR may be
extended from locality 3</p>
<p>This property is only present if localities 1, 2, and 3 are
implemented.</p></td>
</tr>
<tr class="even">
<td>TPM_PT_PCR_RESET_L3</td>
<td>0x00000008</td>
<td><p>a SET bit in the TPMS_PCR_SELECT indicates that the PCR may be
reset by TPM2_PCR_Reset() from locality 3</p>
<p>This property is only present if localities 1, 2, and 3 are
implemented.</p></td>
</tr>
<tr class="odd">
<td>TPM_PT_PCR_EXTEND_L4</td>
<td>0x00000009</td>
<td><p>a SET bit in the TPMS_PCR_SELECT indicates that the PCR may be
extended from locality 4</p>
<p>This property is only present if localities 1, 2, 3, and 4 are
implemented.</p></td>
</tr>
<tr class="even">
<td>TPM_PT_PCR_RESET_L4</td>
<td>0x0000000A</td>
<td><p>a SET bit in the TPMS_PCR_SELECT indicates that the PCR may be
reset by TPM2_PCR_Reset() from locality 4</p>
<p>This property is only present if localities 1, 2, 3, and 4 are
implemented.</p></td>
</tr>
<tr class="odd">
<td>reserved</td>
<td>0x0000000B – 0x00000010</td>
<td><p>the values in this range are reserved</p>
<p>They correspond to values that may be used to describe attributes
associated with the extended localities (32-255).synthesize additional
software localities. The meaning of these properties need not be the
same as the meaning for the Extend and Reset properties above.</p></td>
</tr>
<tr class="even">
<td>TPM_PT_PCR_NO_INCREMENT</td>
<td>0x00000011</td>
<td>a SET bit in the TPMS_PCR_SELECT indicates that modifications to
this PCR (reset or Extend) will not increment the
<em>pcrUpdateCounter</em></td>
</tr>
<tr class="odd">
<td>TPM_PT_PCR_DRTM_RESET</td>
<td>0x00000012</td>
<td><p>a SET bit in the TPMS_PCR_SELECT indicates that the PCR is reset
by a D-RTM event</p>
<p>These PCR are reset to -1 on TPM2_Startup() and reset to 0 on a
_TPM_Hash_End event following a _TPM_Hash_Start event.</p></td>
</tr>
<tr class="even">
<td>TPM_PT_PCR_POLICY</td>
<td>0x00000013</td>
<td><p>a SET bit in the TPMS_PCR_SELECT indicates that the PCR is
controlled by policy</p>
<p>This property is only present if the TPM supports policy control of a
PCR.</p></td>
</tr>
<tr class="odd">
<td>TPM_PT_PCR_AUTH</td>
<td>0x00000014</td>
<td><p>a SET bit in the TPMS_PCR_SELECT indicates that the PCR is
controlled by an authorization value</p>
<p>This property is only present if the TPM supports authorization
control of a PCR.</p></td>
</tr>
<tr class="even">
<td>reserved</td>
<td>0x00000015</td>
<td>reserved for the next (2<sup>nd</sup>) TPM_PT_PCR_POLICY set</td>
</tr>
<tr class="odd">
<td>reserved</td>
<td>0x00000016</td>
<td>reserved for the next (2<sup>nd</sup>) TPM_PT_PCR_AUTH set</td>
</tr>
<tr class="even">
<td>reserved</td>
<td>0x00000017 – 0x00000210</td>
<td>reserved for the 2<sup>nd</sup> through 255<sup>th</sup>
TPM_PT_PCR_POLICY and TPM_PT_PCR_AUTH values</td>
</tr>
<tr class="odd">
<td>reserved</td>
<td>0x00000211</td>
<td>reserved to the 256<sup>th</sup>, and highest allowed,
TPM_PT_PCR_POLICY set</td>
</tr>
<tr class="even">
<td>reserved</td>
<td>0x00000212</td>
<td>reserved to the 256<sup>th</sup>, and highest allowed,
TPM_PT_PCR_AUTH set</td>
</tr>
<tr class="odd">
<td>reserved</td>
<td>0x00000213</td>
<td>new PCR property values may be assigned starting with this
value</td>
</tr>
<tr class="even">
<td>TPM_PT_PCR_LAST</td>
<td>0x00000014</td>
<td><p>top of the range of TPM_PT_PCR properties of the
implementation</p>
<p>If the TPM receives a request for a PCR property with a value larger
than this, the TPM will return a zero length list and set the
<em>moreData</em> parameter to NO.</p>
<p>NOTE This is an implementation-specific value. The value shown
reflects the reference code implementation.</p></td>
</tr>
</tbody>
</table>

## TPM_PS (Platform Specific)

The platform values in Table 25 are used for the
TPM_PT_PS_FAMILY_INDICATOR.

Table 25 is an informative example of a TPM_PS constants table in the
TCG Registry of Reserved TPM 2.0 Handles and Localities. It is provided
for illustrative purposes only.

NOTE Values below six (6) have the same values as the purview
assignments in TPM 1.2.

<span id="_Ref294624520" class="anchor"></span>Table 25 — Definition of
(UINT32) TPM_PS Constants \<OUT\>

| Capability Name       | Value      | Comments                                                                |
|-----------------------|------------|-------------------------------------------------------------------------|
| TPM_PS_MAIN           | 0x00000000 | not platform specific                                                   |
| TPM_PS_PC             | 0x00000001 | PC Client                                                               |
| TPM_PS_PDA            | 0x00000002 | PDA (includes all mobile devices that are not specifically cell phones) |
| TPM_PS_CELL_PHONE     | 0x00000003 | Cell Phone                                                              |
| TPM_PS_SERVER         | 0x00000004 | Server WG                                                               |
| TPM_PS_PERIPHERAL     | 0x00000005 | Peripheral WG                                                           |
| TPM_PS_TSS            | 0x00000006 | TSS WG (deprecated)                                                     |
| TPM_PS_STORAGE        | 0x00000007 | Storage WG                                                              |
| TPM_PS_AUTHENTICATION | 0x00000008 | Authentication WG                                                       |
| TPM_PS_EMBEDDED       | 0x00000009 | Embedded WG                                                             |
| TPM_PS_HARDCOPY       | 0x0000000A | Hardcopy WG                                                             |
| TPM_PS_INFRASTRUCTURE | 0x0000000B | Infrastructure WG (deprecated)                                          |
| TPM_PS_VIRTUALIZATION | 0x0000000C | Virtualization WG                                                       |
| TPM_PS_TNC            | 0x0000000D | Trusted Network Connect WG (deprecated)                                 |
| TPM_PS_MULTI_TENANT   | 0x0000000E | Multi-tenant WG (deprecated)                                            |
| TPM_PS_TC             | 0x0000000F | Technical Committee (deprecated)                                        |

# Handles

## Introduction

Handles are 32-bit values used to reference shielded locations of
various types within the TPM.

<span id="_Toc380749715" class="anchor"></span>Table 26 — Definition of
Types for Handles

|        |            |             |
|--------|------------|-------------|
| Type   | Name       | Description |
| UINT32 | TPM_HANDLE |             |

Handles may refer to objects (keys or data blobs), authorization
sessions (HMAC and policy), NV Indexes, permanent TPM locations, and
PCR.

## TPM_HT (Handle Types)

The 32-bit handle space is divided into 256 regions of equal size with
2<sup>24</sup> values in each. Each of these ranges represents a handle
type.

The type of the entity is indicated by the MSO of its handle. The values
for the MSO and the entity referenced are shown in Table 27.

<span id="_Ref283540608" class="anchor"></span>Table 27 — Definition of
(UINT8) TPM_HT Constants \<S\>

<table>
<colgroup>
<col style="width: 28%" />
<col style="width: 9%" />
<col style="width: 61%" />
</colgroup>
<thead>
<tr class="header">
<th>Name</th>
<th>Value</th>
<th>Comments</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>TPM_HT_PCR</td>
<td>0x00</td>
<td><p><strong>PCR</strong> – consecutive numbers, starting at 0, that
reference the PCR registers</p>
<p>A platform-specific specification will set the minimum number of PCR
and an implementation may have more.</p></td>
</tr>
<tr class="even">
<td>TPM_HT_NV_INDEX</td>
<td>0x01</td>
<td><strong>NV Index</strong> – assigned by the caller</td>
</tr>
<tr class="odd">
<td>TPM_HT_HMAC_SESSION</td>
<td>0x02</td>
<td><strong>HMAC Authorization Session</strong> – assigned by the TPM
when the session is created</td>
</tr>
<tr class="even">
<td>TPM_HT_LOADED_SESSION</td>
<td>0x02</td>
<td><p><strong>Loaded Authorization Session</strong> – used only in the
context of TPM2_GetCapability</p>
<p>This type references both loaded HMAC and loaded policy authorization
sessions.</p></td>
</tr>
<tr class="odd">
<td>TPM_HT_POLICY_SESSION</td>
<td>0x03</td>
<td><strong>Policy Authorization Session</strong> – assigned by the TPM
when the session is created</td>
</tr>
<tr class="even">
<td>TPM_HT_SAVED_SESSION</td>
<td>0x03</td>
<td><p><strong>Saved Authorization Session</strong> – used only in the
context of TPM2_GetCapability</p>
<p>This type references saved authorization session contexts for which
the TPM is maintaining tracking information.</p></td>
</tr>
<tr class="odd">
<td>TPM_HT_PERMANENT</td>
<td>0x40</td>
<td><strong>Permanent Values</strong> – assigned by this specification
in Table 28</td>
</tr>
<tr class="even">
<td>TPM_HT_TRANSIENT</td>
<td>0x80</td>
<td><strong>Transient Objects</strong> – assigned by the TPM when an
object is loaded into transient-object memory or when a persistent
object is converted to a transient object</td>
</tr>
<tr class="odd">
<td>TPM_HT_PERSISTENT</td>
<td>0x81</td>
<td><strong>Persistent Objects</strong> – assigned by the TPM when a
loaded transient object is made persistent</td>
</tr>
<tr class="even">
<td>TPM_HT_AC</td>
<td>0x90</td>
<td><strong>Attached Component</strong> – handle for an Attached
Component.</td>
</tr>
</tbody>
</table>

When a transient object is loaded, the TPM shall assign a handle with an
MSO of TPM_HT_TRANSIENT. The object may be assigned a different handle
each time it is loaded. The TPM shall ensure that handles assigned to
transient objects are unique and assigned to only one transient object
at a time.

EXAMPLE 1 If a TPM is only able to hold 4 transient objects in internal
memory, it might choose to assign handles to those objects with the
values 80 00 00 00<sub>16</sub> – 80 00 00 03<sub>16</sub>.

When a transient object is converted to a persistent object
(TPM2_EvictControl()), the TPM shall validate that the handle provided
by the caller has an MSO of TPM_HT_PERSISTENT and that the handle is not
already assigned to a persistent object.

A handle is assigned to a session when the session is started. The
handle shall have an MSO equal to TPM_HT_SESSION and remain associated
with that session until the session is closed or flushed. The TPM shall
ensure that a session handle is only associated with one session at a
time. When the session is loaded into the TPM using TPM2_LoadContext(),
it will have the same handle each time it is loaded.

EXAMPLE 2 If a TPM is only able to track 64 active sessions at a time,
it could number those sessions using the values xx 00 01 00<sub>16</sub>
– xx 00 01 3F<sub>16</sub> where xx is either 02<sub>16</sub> or
03<sub>16</sub> depending on the session type.

## Persistent Handle Sub-ranges

Persistent handles are assigned by the caller of TPM2_EvictControl().
Owner Authorization or Platform Authorization is required to authorize
allocation of space for a persistent object. These entities are given
separate ranges of persistent handles so that they do not have to
allocate from a common range of handles.

NOTE While this “namespace” allocation of the handle ranges could have
been handled by convention, TPM enforcement is used to prevent errors by
the OS or malicious software from affecting the platform’s use of the NV
memory.

The Owner is allocated persistent handles in the range of
81 00 00 00<sub>16</sub> to 81 7F FF FF<sub>16</sub> inclusive and the
TPM will return an error if Owner Authorization is used to attempt to
assign a persistent handle outside of this range.

## TPM_RH (Permanent Handles)

Table 28 lists the architecturally defined handles that cannot be
changed. The handles include authorization handles, and special handles.

<span id="_Ref284246076" class="anchor"></span>Table 28 — Definition of
(TPM_HANDLE) TPM_RH Constants \<S\>

<table>
<colgroup>
<col style="width: 25%" />
<col style="width: 13%" />
<col style="width: 8%" />
<col style="width: 51%" />
</colgroup>
<thead>
<tr class="header">
<th>Name</th>
<th>Value</th>
<th>Type</th>
<th>Comments</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>TPM_RH_FIRST</td>
<td>0x40000000</td>
<td>R</td>
<td></td>
</tr>
<tr class="even">
<td>TPM_RH_SRK</td>
<td>0x40000000</td>
<td>R</td>
<td>not used<sup>1</sup></td>
</tr>
<tr class="odd">
<td>TPM_RH_OWNER</td>
<td>0x40000001</td>
<td>K, A, P</td>
<td>handle references the Storage Primary Seed (SPS), the
<em>ownerAuth</em>, and the <em>ownerPolicy</em></td>
</tr>
<tr class="even">
<td>TPM_RH_REVOKE</td>
<td>0x40000002</td>
<td>R</td>
<td>not used<sup>1</sup></td>
</tr>
<tr class="odd">
<td>TPM_RH_TRANSPORT</td>
<td>0x40000003</td>
<td>R</td>
<td>not used<sup>1</sup></td>
</tr>
<tr class="even">
<td>TPM_RH_OPERATOR</td>
<td>0x40000004</td>
<td>R</td>
<td>not used<sup>1</sup></td>
</tr>
<tr class="odd">
<td>TPM_RH_ADMIN</td>
<td>0x40000005</td>
<td>R</td>
<td>not used<sup>1</sup></td>
</tr>
<tr class="even">
<td>TPM_RH_EK</td>
<td>0x40000006</td>
<td>R</td>
<td>not used<sup>1</sup></td>
</tr>
<tr class="odd">
<td>TPM_RH_NULL</td>
<td>0x40000007</td>
<td>K, A, P</td>
<td>a handle associated with the null hierarchy, an EmptyAuth
<em>authValue</em>, and an Empty Policy <em>authPolicy</em>.</td>
</tr>
<tr class="even">
<td>TPM_RH_UNASSIGNED</td>
<td>0x40000008</td>
<td>R</td>
<td>value reserved to the TPM to indicate a handle location that has not
been initialized or assigned</td>
</tr>
<tr class="odd">
<td>TPM_RS_PW</td>
<td>0x40000009</td>
<td>S</td>
<td>authorization value used to indicate a password authorization
session</td>
</tr>
<tr class="even">
<td>TPM_RH_LOCKOUT</td>
<td>0x4000000A</td>
<td>A</td>
<td>references the authorization associated with the dictionary attack
lockout reset</td>
</tr>
<tr class="odd">
<td>TPM_RH_ENDORSEMENT</td>
<td>0x4000000B</td>
<td>K, A, P</td>
<td>references the Endorsement Primary Seed (EPS),
<em>endorsementAuth</em>, and <em>endorsementPolicy</em></td>
</tr>
<tr class="even">
<td>TPM_RH_PLATFORM</td>
<td>0x4000000C</td>
<td>K, A, P</td>
<td>references the Platform Primary Seed (PPS), <em>platformAuth</em>,
and <em>platformPolicy</em></td>
</tr>
<tr class="odd">
<td>TPM_RH_PLATFORM_NV</td>
<td>0x4000000D</td>
<td>C</td>
<td>for phEnableNV</td>
</tr>
<tr class="even">
<td>TPM_RH_AUTH_00</td>
<td>0x40000010</td>
<td>A</td>
<td><p>Start of a range of authorization values that are
vendor-specific. A TPM may support any of the values in this range as
are needed for vendor-specific purposes.</p>
<p>Disabled if ehEnable is CLEAR.</p>
<p>NOTE “Any” includes “none”.</p></td>
</tr>
<tr class="odd">
<td>TPM_RH_AUTH_FF</td>
<td>0x4000010F</td>
<td>A</td>
<td>End of the range of vendor-specific authorization values.</td>
</tr>
<tr class="even">
<td>TPM_RH_ACT_0</td>
<td>0x40000110</td>
<td>A,P</td>
<td>Start of the range of authenticated timers</td>
</tr>
<tr class="odd">
<td>TPM_RH_ACT_F</td>
<td>0x4000011F</td>
<td>A,P</td>
<td>End of the range of authenticated timers</td>
</tr>
<tr class="even">
<td>TPM_RH_LAST</td>
<td>0x4000011F</td>
<td>R</td>
<td><p>the top of the reserved handle area</p>
<p>This is set to allow TPM2_GetCapability() to know where to stop. It
may vary as implementations add to the permanent handle area.</p></td>
</tr>
<tr class="odd">
<td colspan="4"><p>Type definitions:</p>
<p><strong>R</strong> – a reserved value</p>
<p><strong>K</strong> – a Primary Seed</p>
<p><strong>A</strong> – an authorization value</p>
<p><strong>P</strong> – a policy value</p>
<p><strong>S</strong> – a session handle</p>
<p><strong>C</strong> - a control</p>
<p>Note 1 The handle is only used in a TPM that is compatible with a
previous version of this specification. It is not used in any command
defined in this version of the specification.</p></td>
</tr>
</tbody>
</table>

## TPM_HC (Handle Value Constants)

The definitions in Table 29 are used to define many of the interface
data types.

These values, that indicate ranges, are informative and may be changed
by an implementation. The TPM will always return the correct handle type
as described in 7.2 Table 27:

- HMAC_SESSION_FIRST—HMAC_SESSION_LAST,

- LOADED_SESSION_FIRST—LOADED_SESSION_LAST,

- POLICY_SESSION_FIRST—POLICY_SESSION_LAST,

- TRANSIENT_FIRST—TRANSIENT_LAST,

- ACTIVE_SESSION_FIRST—ACTIVE_SESSION_LAST,

- PCR_FIRST—PCR_LAST

These values are input by the caller. The TPM implementation should
support the entire range:

- PERSISTENT_FIRST—PERSISTENT_LAST,

- PLATFORM_PERSISTENT—PLATFORM_PERSISTENT+0x007FFFFF,

- NV_INDEX_FIRST—NV_INDEX_LAST,

- PERMANENT_FIRST—PERMANENT_LAST

NOTE PCR0 is architecturally defined to have a handle value of 0.

For the reference implementation, the handle range for sessions starts
at the lowest allowed value for a session handle. The highest value for
a session handle is determined by how many active sessions are allowed
by the implementation. The MSO of the session handle will be set
according to the session type.

A similar approach is used for transient objects with the first assigned
handle at the bottom of the range defined by TPM_HT_TRANSIENT and the
top of the range determined by the implementation-dependent value of
MAX_LOADED_OBJECTS.

The first assigned handle for evict objects is also at the bottom of the
allowed range defined by TPM_HT_PERSISTENT and the top of the range
determined by the implementation-dependent value of MAX_EVICT_OBJECTS.

NOTE The values in Table 29 are intended to facilitate the process of
making the handle larger than 32 bits in the future. It is intended that
HR_MASK and HR_SHIFT are the only values that need change to resize the
handle space.

<span id="_Ref286043143" class="anchor"></span>Table 29 — Definition of
(TPM_HANDLE) TPM_HC Constants \<S\>

| Name                 | Value                                          | Comments                                     |
|----------------------|------------------------------------------------|----------------------------------------------|
| HR_HANDLE_MASK       | 0x00FFFFFF                                     | to mask off the HR                           |
| HR_RANGE_MASK        | 0xFF000000                                     | to mask off the variable part                |
| HR_SHIFT             | 24                                             |                                              |
| HR_PCR               | (TPM_HT_PCR \<\< HR_SHIFT)                     |                                              |
| HR_HMAC_SESSION      | (TPM_HT_HMAC_SESSION \<\< HR_SHIFT)            |                                              |
| HR_POLICY_SESSION    | (TPM_HT_POLICY_SESSION \<\< HR_SHIFT)          |                                              |
| HR_TRANSIENT         | (TPM_HT_TRANSIENT \<\< HR_SHIFT)               |                                              |
| HR_PERSISTENT        | (TPM_HT_PERSISTENT \<\< HR_SHIFT)              |                                              |
| HR_NV_INDEX          | (TPM_HT_NV_INDEX \<\< HR_SHIFT)                |                                              |
| HR_PERMANENT         | (TPM_HT_PERMANENT \<\< HR_SHIFT)               |                                              |
| PCR_FIRST            | (HR_PCR + 0)                                   | first PCR                                    |
| PCR_LAST             | (PCR_FIRST + IMPLEMENTATION_PCR-1)             | last PCR                                     |
| HMAC_SESSION_FIRST   | (HR_HMAC_SESSION + 0)                          | first HMAC session                           |
| HMAC_SESSION_LAST    | (HMAC_SESSION_FIRST+MAX_ACTIVE_SESSIONS-1)     | last HMAC session                            |
| LOADED_SESSION_FIRST | HMAC_SESSION_FIRST                             | used in GetCapability                        |
| LOADED_SESSION_LAST  | HMAC_SESSION_LAST                              | used in GetCapability                        |
| POLICY_SESSION_FIRST | (HR_POLICY_SESSION + 0)                        | first policy session                         |
| POLICY_SESSION_LAST  | (POLICY_SESSION_FIRST + MAX_ACTIVE_SESSIONS-1) | last policy session                          |
| TRANSIENT_FIRST      | (HR_TRANSIENT + 0)                             | first transient object                       |
| ACTIVE_SESSION_FIRST | POLICY_SESSION_FIRST                           | used in GetCapability                        |
| ACTIVE_SESSION_LAST  | POLICY_SESSION_LAST                            | used in GetCapability                        |
| TRANSIENT_LAST       | (TRANSIENT_FIRST+MAX_LOADED_OBJECTS-1)         | last transient object                        |
| PERSISTENT_FIRST     | (HR_PERSISTENT + 0)                            | first persistent object                      |
| PERSISTENT_LAST      | (PERSISTENT_FIRST + 0x00FFFFFF)                | last persistent object                       |
| PLATFORM_PERSISTENT  | (PERSISTENT_FIRST + 0x00800000)                | first platform persistent object             |
| NV_INDEX_FIRST       | (HR_NV_INDEX + 0)                              | first allowed NV Index                       |
| NV_INDEX_LAST        | (NV_INDEX_FIRST + 0x00FFFFFF)                  | last allowed NV Index                        |
| PERMANENT_FIRST      | TPM_RH_FIRST                                   |                                              |
| PERMANENT_LAST       | TPM_RH_LAST                                    |                                              |
| HR_NV_AC             | ((TPM_HT_NV_INDEX \<\< HR_SHIFT) + 0xD00000)   | AC aliased NV Index                          |
| NV_AC_FIRST          | (HR_NV_AC + 0)                                 | first NV Index aliased to Attached Component |
| NV_AC_LAST           | (HR_NV_AC + 0x0000FFFF)                        | last NV Index aliased to Attached Component  |
| HR_AC                | (TPM_HT_AC \<\< HR_SHIFT)                      | AC Handle                                    |
| AC_FIRST             | (HR_AC + 0)                                    | first Attached Component                     |
| AC_LAST              | (HR_AC + 0x0000FFFF)                           | last Attached Component                      |

# Attribute Structures

## Description

Attributes are expressed as bit fields of varying size. An attribute
field structure may be 1, 2, or 4 octets in length.

The bit numbers for an attribute structure are assigned with the number
0 assigned to the least-significant bit of the structure and the highest
number assigned to the most-significant bit of the structure.

The least significant bit is determined by treating the attribute
structure as an integer. The least-significant bit would be the bit that
is set when the value of the integer is 1.

When any reserved bit in an attribute is SET, the TPM shall return
TPM_RC_RESERVED_BITS. This response code is not shown in the tables for
attributes.

## TPMA_ALGORITHM

This structure defines the attributes of an algorithm.

Each algorithm has a fundamental attribute: *asymmetric*, *symmetric*,
or *hash*. In some cases (e.g., TPM_ALG_RSA or TPM_ALG_AES), this is the
only attribute.

A mode, method, or scheme may have an associated asymmetric, symmetric,
or hash algorithm.

NOTE A hash algorithm that can be used directly is one that has only the
*hash* attribute SET.

EXAMPLE A PCR bank or an object Name can only use an algorithm that has
only the *hash* attribute SET.

<span id="_Toc380749719" class="anchor"></span>Table 30 — Definition of
(UINT32) TPMA_ALGORITHM Bits

<table>
<colgroup>
<col style="width: 6%" />
<col style="width: 24%" />
<col style="width: 69%" />
</colgroup>
<thead>
<tr class="header">
<th>Bit</th>
<th>Name</th>
<th>Definition</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>0</td>
<td>asymmetric</td>
<td><p><strong>SET (1):</strong> an asymmetric algorithm with public and
private portions</p>
<p><strong>CLEAR (0):</strong> not an asymmetric algorithm</p></td>
</tr>
<tr class="even">
<td>1</td>
<td>symmetric</td>
<td><p><strong>SET (1):</strong> a symmetric block cipher</p>
<p><strong>CLEAR (0):</strong> not a symmetric block cipher</p></td>
</tr>
<tr class="odd">
<td>2</td>
<td>hash</td>
<td><p><strong>SET (1):</strong> a hash algorithm</p>
<p><strong>CLEAR (0):</strong> not a hash algorithm</p></td>
</tr>
<tr class="even">
<td>3</td>
<td>object</td>
<td><p><strong>SET (1):</strong> an algorithm that may be used as an
object type</p>
<p><strong>CLEAR (0):</strong> an algorithm that is not used as an
object type</p></td>
</tr>
<tr class="odd">
<td>7:4</td>
<td>Reserved</td>
<td></td>
</tr>
<tr class="even">
<td>8</td>
<td>signing</td>
<td><p><strong>SET (1):</strong> a signing algorithm. The setting of
<em>asymmetric</em>, <em>symmetric</em>, and <em>hash</em> will indicate
the type of signing algorithm.</p>
<p><strong>CLEAR (0):</strong> not a signing algorithm</p></td>
</tr>
<tr class="odd">
<td>9</td>
<td>encrypting</td>
<td><p><strong>SET (1):</strong> an encryption/decryption algorithm. The
setting of <em>asymmetric</em>, <em>symmetric</em>, and <em>hash</em>
will indicate the type of encryption/decryption algorithm.</p>
<p><strong>CLEAR (0):</strong> not an encryption/decryption
algorithm</p></td>
</tr>
<tr class="even">
<td>10</td>
<td>method</td>
<td><p><strong>SET (1):</strong> a method such as a key derivative
function (KDF)</p>
<p><strong>CLEAR (0):</strong> not a method</p></td>
</tr>
<tr class="odd">
<td>31:11</td>
<td>Reserved</td>
<td></td>
</tr>
</tbody>
</table>

## TPMA_OBJECT (Object Attributes)

### Introduction

This attribute structure indicates an object’s use, its authorization
types, and its relationship to other objects.

The state of the attributes is determined when the object is created and
they are never changed by the TPM. Additionally, the setting of these
structures is reflected in the integrity value of the private area of an
object in order to allow the TPM to detect modifications of the
Protected Object when stored off the TPM.

### Structure Definition

<span id="_Ref213575138" class="anchor"></span>Table 31 — Definition of
(UINT32) TPMA_OBJECT Bits

<table>
<colgroup>
<col style="width: 6%" />
<col style="width: 24%" />
<col style="width: 69%" />
</colgroup>
<thead>
<tr class="header">
<th>Bit</th>
<th>Name</th>
<th>Definition</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>0</td>
<td>Reserved</td>
<td>shall be zero</td>
</tr>
<tr class="even">
<td>1</td>
<td>fixedTPM</td>
<td><p><strong>SET (1):</strong> The hierarchy of the object, as
indicated by its Qualified Name, may not change.</p>
<p><strong>CLEAR (0):</strong> The hierarchy of the object may change as
a result of this object or an ancestor key being duplicated for use in
another hierarchy.</p>
<p>NOTE <em>fixedTPM</em> does not indicate that key material resides on
a single TPM (see <em>sensitiveDataOrigin</em>)<em>.</em></p></td>
</tr>
<tr class="odd">
<td>2</td>
<td>stClear</td>
<td><p><strong>SET (1):</strong> Previously saved contexts of this
object may not be loaded after Startup(CLEAR).</p>
<p><strong>CLEAR (0):</strong> Saved contexts of this object may be used
after a Shutdown(STATE) and subsequent Startup().</p></td>
</tr>
<tr class="even">
<td>3</td>
<td>Reserved</td>
<td>shall be zero</td>
</tr>
<tr class="odd">
<td>4</td>
<td>fixedParent</td>
<td><p><strong>SET (1):</strong> The parent of the object may not
change.</p>
<p><strong>CLEAR (0):</strong> The parent of the object may change as
the result of a TPM2_Duplicate() of the object.</p></td>
</tr>
<tr class="even">
<td>5</td>
<td>sensitiveDataOrigin</td>
<td><p><strong>SET (1):</strong> Indicates that, when the object was
created with TPM2_Create() or TPM2_CreatePrimary(), the TPM generated
all of the sensitive data other than the <em>authValue</em>.</p>
<p><strong>CLEAR (0):</strong> A portion of the sensitive data, other
than the <em>authValue</em>, was provided by the caller.</p></td>
</tr>
<tr class="odd">
<td>6</td>
<td>userWithAuth</td>
<td><p><strong>SET (1):</strong> Approval of USER role actions with this
object may be with an HMAC session or with a password using the
<em>authValue</em> of the object or a policy session.</p>
<p><strong>CLEAR (0):</strong> Approval of USER role actions with this
object may only be done with a policy session.</p></td>
</tr>
<tr class="even">
<td>7</td>
<td>adminWithPolicy</td>
<td><p><strong>SET (1):</strong> Approval of ADMIN role actions with
this object may only be done with a policy session.</p>
<p><strong>CLEAR (0):</strong> Approval of ADMIN role actions with this
object may be with an HMAC session or with a password using the
<em>authValue</em> of the object or a policy session.</p></td>
</tr>
<tr class="odd">
<td>9:8</td>
<td>Reserved</td>
<td>shall be zero</td>
</tr>
<tr class="even">
<td>10</td>
<td>noDA</td>
<td><p><strong>SET (1):</strong> The object is not subject to dictionary
attack protections.</p>
<p><strong>CLEAR (0):</strong> The object is subject to dictionary
attack protections.</p></td>
</tr>
<tr class="odd">
<td>11</td>
<td>encryptedDuplication</td>
<td><p><strong>SET (1):</strong> If the object is duplicated, then
<em>symmetricAlg</em> shall not be TPM_ALG_NULL and
<em>newParentHandle</em> shall not be TPM_RH_NULL.</p>
<p><strong>CLEAR (0):</strong> The object may be duplicated without an
inner wrapper on the private portion of the object and the new parent
may be TPM_RH_NULL.</p></td>
</tr>
<tr class="even">
<td>15:12</td>
<td>Reserved</td>
<td>shall be zero</td>
</tr>
<tr class="odd">
<td>16</td>
<td>restricted</td>
<td><p><strong>SET (1):</strong> Key usage is restricted to manipulate
structures of known format; the parent of this key shall have
<em>restricted</em> SET.</p>
<p><strong>CLEAR (0):</strong> Key usage is not restricted to use on
special formats.</p></td>
</tr>
<tr class="even">
<td>17</td>
<td>decrypt</td>
<td><p><strong>SET (1):</strong> The private portion of the key may be
used to decrypt.</p>
<p><strong>CLEAR (0):</strong> The private portion of the key may not be
used to decrypt.</p></td>
</tr>
<tr class="odd">
<td>18</td>
<td>sign / encrypt</td>
<td><p><strong>SET (1):</strong> For a symmetric cipher object, the
private portion of the key may be used to encrypt. For other objects,
the private portion of the key may be used to sign.</p>
<p><strong>CLEAR (0):</strong> The private portion of the key may not be
used to sign or encrypt.</p></td>
</tr>
<tr class="even">
<td>19</td>
<td>x509sign</td>
<td><p><strong>SET (1):</strong> An asymmetric key that may not be used
to sign with TPM2_Sign()</p>
<p><strong>CLEAR (0):</strong> A key that may be used with TPM2_Sign()
if <em>sign</em> is SET</p>
<p>NOTE: This attribute only has significance if <em>sign</em> is
SET.</p></td>
</tr>
<tr class="odd">
<td>31:20</td>
<td>Reserved</td>
<td>shall be zero</td>
</tr>
</tbody>
</table>

### Attribute Descriptions

#### Introduction

The following remaining paragraphs in 8.3.3 describe the use and
settings for each of the TPMA_OBJECT attributes. The description
includes checks that are performed on the *objectAttributes* when an
object is created, when it is loaded, and when it is imported. In these
descriptions:

**Creation** indicates settings for the *template* parameter in
TPM2_Create() or TPM2_CreatePrimary()

**Load** indicates settings for the *inPublic* parameter in TPM2_Load()

**Import** indicates settings for the *objectPublic* parameter in
TPM2_Import()

**External** indicates settings that apply to the *inPublic* parameter
in TPM2_LoadExternal() if both the public and sensitive portions of the
object are loaded

NOTE For TPM2_LoadExternal() when only the public portion of the object
is loaded, the only attribute checks are the checks in the validation
code following Table 31 and the reserved attributes check.

For any consistency error of attributes in TPMA_OBJECT, the TPM shall
return TPM_RC_ATTRIBUTES.

#### Bit\[1\] – *fixedTPM*

When SET, the object cannot be duplicated for use on a different TPM,
either directly or indirectly and the Qualified Name of the object
cannot change. When CLEAR, the object’s Qualified Name may change if the
object or an ancestor is duplicated.

NOTE This attribute is the logical inverse of the migratable attribute
in 1.2. That is, when this attribute is CLEAR, it is the equivalent to a
1.2 object with migratable SET.

**Creation** If *fixedTPM* is SET in the object's parent, then
*fixedTPM* and *fixedParent* shall both be set to the same value in
*template.* If *fixedTPM* is CLEAR in the parent, this attribute shall
also be CLEAR in *template*.

> NOTE For a Primary Object, the parent is considered to have *fixedTPM*
> SET.

**Load** If *fixedTPM* is SET in the object's parent, then *fixedTPM*
and *fixedParent* shall both be set to the same value. If *fixedTPM* is
CLEAR in the parent, this attribute shall also be CLEAR.

**Import** shall be CLEAR

**External** shall be CLEAR if both the public and sensitive portions
are loaded or if fixedParent is CLEAR, otherwise may be SET or CLEAR

#### Bit\[2\] – *stClear*

If this attribute is SET, then saved contexts of this object will be
invalidated on TPM2_Startup(TPM_SU_CLEAR). If the attribute is CLEAR,
then the TPM shall not invalidate the saved context if the TPM received
TPM2_Shutdown(TPM_SU_STATE). If the saved state is valid when checked at
the next TPM2_Startup(), then the TPM shall continue to be able to use
the saved contexts.

**Creation** may be SET or CLEAR in template

**Load** may be SET or CLEAR

**Import** may be SET or CLEAR

**External** may be SET or CLEAR

#### Bit\[4\] – *fixedParent*

If this attribute is SET, the object’s parent may not be changed. That
is, this object may not be the object of a TPM2_Duplicate(). If this
attribute is CLEAR, then this object may be the object of a
TPM2_Duplicate().

**Creation** may be SET or CLEAR in template

**Load** may be SET or CLEAR

**Import** shall be CLEAR

**External** shall be CLEAR if both the public and sensitive portions
are loaded; otherwise it may be SET or CLEAR

#### Bit\[5\] – *sensitiveDataOrigin*

This attribute is SET for any key that was generated by TPM in
TPM2_Create() or TPM2_CreatePrimary(). If CLEAR, it indicates that the
sensitive part of the object (other than the *obfuscation* value) was
provided by the caller.

NOTE 1 If the *fixedTPM* attribute is SET, then this attribute is
authoritative and accurately reflects the source of the sensitive area
data. If the *fixedTPM* attribute is CLEAR, then validation of this
attribute requires evaluation of the properties of the ancestor keys.

**Creation** If *inSensitive.sensitive.data.*size is zero, then this
attribute shall be SET in the template; otherwise, it shall be CLEAR in
the template.

NOTE 2 The *inSensitive.sensitive.data.size* parameter is required to be
zero for an asymmetric key so *sensitiveDataOrigin* is required to be
SET.

NOTE 3 The *inSensitive.sensitive.data.size* parameter may not be zero
for a data object so *sensitiveDataOrigin* is required to be CLEAR. A
data object has *type* = TPM_ALG_KEYEDHASH and its *sign* and *decrypt*
attributes are CLEAR.

**Load** may be SET or CLEAR

**Import** may be SET or CLEAR

**External** may be SET or CLEAR

#### Bit\[6\] – *userWithAuth*

If SET, authorization for operations that require USER role
authorization may be given if the caller provides proof of knowledge of
the *authValue* of the object with an HMAC authorization session or a
password.

If this attribute is CLEAR, then HMAC or password authorizations may not
be used for USER role authorizations.

NOTE 1 Regardless of the setting of this attribute, authorizations for
operations that require USER role authorizations may be provided with a
policy session that satisfies the object's *authPolicy*.

NOTE 2 Regardless of the setting of this attribute, the *authValue* may
be referenced in a policy session or used to provide the *bind* value in
TPM2_StartAuthSession(). However, if *userWithAuth* is CLEAR, then the
object may be used as the bind object in TPM2_StartAuthSession() but the
session cannot be used to authorize actions on the object. If this were
allowed, then the *userWithAuth* control could be circumvented simply by
using the object as the bind object.

**Creation** may be SET or CLEAR in template

**Load** may be SET or CLEAR

**Import** may be SET or CLEAR

**External** may be SET or CLEAR

#### Bit\[7\] – *adminWithPolicy*

If CLEAR, authorization for operations that require ADMIN role may be
given if the caller provides proof of knowledge of the *authValue* of
the object with an HMAC authorization session or a password.

If this attribute is SET, then then HMAC or password authorizations may
not be used for ADMIN role authorizations.

NOTE 1 Regardless of the setting of this attribute, operations that
require ADMIN role authorization may be provided by a policy session
that satisfies the object's *authPolicy*.

NOTE 2 This attribute is similar to *userWithAuth* but the logic is a
bit different. When *userWithAuth* is CLEAR, the *authValue* may not be
used for USER mode authorizations. When *adminWithPolicy* is CLEAR, it
means that the *authValue* may be used for ADMIN role. Policy may always
be used regardless of the setting of *userWithAuth* or
*adminWithPolicy*.

Actions that always require policy (TPM2_Duplicate()) are not affected
by the setting of this attribute.

**Creation** may be SET or CLEAR in *template*

**Load** may be SET or CLEAR

**Import** may be SET or CLEAR

**External** may be SET or CLEAR

#### Bit\[10\] – *noDA*

If SET, then authorization failures for the object do not affect the
dictionary attack protection logic and authorization of the object is
not blocked if the TPM is in lockout.

**Creation** may be SET or CLEAR in *template*

**Load** may be SET or CLEAR

**Import** may be SET or CLEAR

**External** may be SET or CLEAR

#### Bit\[11\] – *encryptedDuplication*

If SET, then when the object is duplicated, the sensitive portion of the
object is required to be encrypted with an inner wrapper and the new
parent shall be an asymmetric key and not TPM_RH_NULL

NOTE 1 Enforcement of these requirements in TPM2_Duplicate() is by not
allowing *symmetricAlg* to be TPM_ALG_NULL and not allowing
*newParentHandle* to be TPM_RH_NULL.

This attribute shall not be SET in any object that has *fixedTPM*
SET**.**

NOTE 2 This requirement means that *encryptedDuplication* may not be SET
if the object cannot be directly or indirectly duplicated.

If an object's parent has *fixedTPM* SET, and the object is duplicable
(*fixedParent* == CLEAR), then *encryptedDuplication* may be SET or
CLEAR in the object.

NOTE 3 This allows the object at the boundary between duplicable and
non-duplicable objects to have either setting.

If an object's parent has *fixedTPM* CLEAR, then the object is required
to have the same setting of *encryptedDuplication* as its parent.

NOTE 4 This requirement forces all duplicable objects in a duplication
group to have the same *encryptedDuplication* setting.

**Creation** shall be CLEAR if *fixedTPM* is SET. If *fixedTPM* is
CLEAR, then this attribute shall have the same value as its parent
unless *fixedTPM* is SET in the object's parent, in which case, it may
be SET or CLEAR.

**Load** shall be CLEAR if *fixedTPM* is SET. If *fixedTPM* is CLEAR,
then this attribute shall have the same value as its parent, unless
*fixedTPM* is SET the parent, in which case, it may be SET or CLEAR.

**Import** if *fixedTPM* is SET in the object's new parent, then this
attribute may be SET or CLEAR, otherwise, it shall have the same setting
as the new parent.

**External** may be SET or CLEAR.

#### Bit\[16\] – *restricted*

This this attribute modifies the *decrypt* and *sign* attributes of an
object.

NOTE A key with this object CLEAR may not be a parent for another
object.

**Creation** shall be CLEAR in *template* if neither sign nor decrypt is
SET in *template*.

**Load** shall be CLEAR if neither sign nor decrypt is SET in the object

**Import** may be SET or CLEAR

**External** shall be CLEAR

#### Bit\[17\] – *decrypt*

When SET, the private portion of this key can be used to decrypt an
external blob. If *restricted* is SET, then the TPM will return an error
if the external decrypted blob is not formatted as appropriate for the
command.

NOTE 1 Since TPM-generated keys and sealed data will contain a hash and
a structure tag, the TPM can ensure that it is not being used to
improperly decrypt and return sensitive data that should not be
returned. The only type of data that may be returned after decryption is
a Sealed Data Object (a *keyedHash* object with *decrypt* and *sign*
CLEAR).

When *restricted* is CLEAR, there are no restrictions on the use of the
private portion of the key for decryption and the key may be used to
decrypt and return any structure encrypted by the public portion of the
key.

NOTE 2 A key with this attribute SET may be a parent for another object
if *restricted* is SET and *sign* is CLEAR.

If *decrypt* is SET on an object with *type* set to TPM_ALG_KEYEDHASH,
it indicates that the object is an XOR encryption key.

**Creation** may be SET or CLEAR in *template*

**Load** may be SET or CLEAR

**Import** may be SET or CLEAR

**External** may be SET or CLEAR

#### Bit\[18\] – *sign* / *encrypt*

When SET, the private portion of this key may be used to sign a digest
if the key is an asymetric key or to encrypt a block of data if the key
is a symmetric key. If *restricted* is SET, then the asymmetric key may
only be used to sign a digest that was computed by the TPM. A restricted
symmetric key may only be used to encrypt a data block. If a structure
is generated by the TPM, it will begin with TPM_GENERATED_VALUE and the
TPM may sign the digest of that structure. If the data is externally
supplied and has TPM_GENERATED_VALUE as its first octets, then the TPM
will not sign a digest of that data with a restricted signing key.

If *restricted* is CLEAR, then the key may be used to sign any digest or
encrypt any data block, whether generated by the TPM or externally
provided.

NOTE 1 Some asymmetric algorithms may not support both *sign* and
*decrypt* being SET in the same key.

If *sign* is SET on an object with *type* set to TPM_ALG_KEYEDHASH, it
indicates that the object is an HMAC key.

NOTE 2 A key with this attribute SET may not be a parent for another
object.

**Creation** shall not be SET if *decrypt* and *restricted* are both SET

**Load** shall not be SET if *decrypt* and *restricted* are both SET

**Import** shall not be SET if *decrypt* and *restricted* are both SET

**External** shall not be SET if *decrypt* and *restricted* are both SET

#### Bit\[19\] – *x509sign*

When SET, the private portion of the asymmetric key may not be used as
the signing key in TPM2_Sign(). This restriction is to ensure that the
only digest signed by this key is a digest of a strucure that is
specific to the TPM or an x509 certiticate.

NOTE 1 This attribute does not limit the use of the key in any command
other than TPM2_Sign().

NOTE 2 This attribute was added in revision 01.53.

This attribute may not be SET if the object is not an asymmetric key or
if *sign* is CLEAR.

**Creation** shall not be SET if *sign* is CLEAR or if the object is not
an asymmetric key

**Load** shall not be SET if *sign* is CLEAR or if the object is not an
asymmetric key

**Import** shall not be SET if *sign* is CLEAR or if the object is not
an asymmetric key

**External** shall not be SET if *sign* is CLEAR or if the object is not
an asymmetric key

## TPMA_SESSION (Session Attributes)

This octet in each session is used to identify the session type,
indicate its relationship to any handles in the command, and indicate
its use in parameter encryption.

If a session is not being used for authorization, at least one of
decrypt, encrypt, or audit must be SET.

In this revision, if *audit* is CLEAR, *auditExclusive* must be CLEAR in
the command and will be CLEAR in the response. In a future, revision,
this bit may have a different meaning if *audit* is CLEAR. See
"Exclusive Audit Session" clause in TPM 2.0 Part 1.

In this revision, if *audit* is CLEAR, *auditReset* must be clear in the
command and will be CLEAR in the response. In a future, revision, this
bit may have a different meaning if *audit* is CLEAR.

*decrypt* may only be SET in one session per command. It may only be SET
if the first parameter of the command is a sized buffer (TPM2B\_).

*encrypt* may only be SET in one session per command. It may only be SET
if the first parameter of the response is a sized buffer (TPM2B\_).

*audit* may only be SET in one session per command or response.

<span id="_Toc384651383" class="anchor"></span>Table 32 — Definition of
(UINT8) TPMA_SESSION Bits \<IN/OUT\>

<table>
<colgroup>
<col style="width: 6%" />
<col style="width: 18%" />
<col style="width: 75%" />
</colgroup>
<thead>
<tr class="header">
<th>Bit</th>
<th>Name</th>
<th>Meaning</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>0</td>
<td>continueSession</td>
<td><p><strong>SET (1):</strong> In a command, this setting indicates
that the session is to remain active after successful completion of the
command. In a response, it indicates that the session is still active.
If SET in the command, this attribute shall be SET in the response.</p>
<p><strong>CLEAR (0):</strong> In a command, this setting indicates that
the TPM should close the session and flush any related context when the
command completes successfully. In a response, it indicates that the
session is closed and the context is no longer active.</p>
<p>This attribute has no meaning for a password authorization and the
TPM will allow any setting of the attribute in the command and SET the
attribute in the response.</p>
<p>This attribute will only be CLEAR in one response for a logical
session. If the attribute is CLEAR, the context associated with the
session is no longer in use and the space is available. A session
created after another session is ended may have the same handle but
logically is not the same session.</p>
<p>This attribute has no effect if the command does not complete
successfully.</p></td>
</tr>
<tr class="even">
<td>1</td>
<td>auditExclusive</td>
<td><p><strong>SET (1):</strong> In a command, this setting indicates
that the command should only be executed if the session is exclusive at
the start of the command. In a response, it indicates that the session
is exclusive. This setting is only allowed if the <em>audit</em>
attribute is SET (TPM_RC_ATTRIBUTES).</p>
<p><strong>CLEAR (0):</strong> In a command, indicates that the session
need not be exclusive at the start of the command. In a response,
indicates that the session is not exclusive.</p></td>
</tr>
<tr class="odd">
<td>2</td>
<td>auditReset</td>
<td><p><strong>SET (1):</strong> In a command, this setting indicates
that the audit digest of the session should be initialized and the
exclusive status of the session SET. This setting is only allowed if the
<em>audit</em> attribute is SET (TPM_RC_ATTRIBUTES).</p>
<p><strong>CLEAR (0):</strong> In a command, indicates that the audit
digest should not be initialized.</p>
<p>This bit is always CLEAR in a response.</p></td>
</tr>
<tr class="even">
<td>4:3</td>
<td>Reserved</td>
<td>shall be CLEAR</td>
</tr>
<tr class="odd">
<td>5</td>
<td>decrypt</td>
<td><p><strong>SET (1):</strong> In a command, this setting indicates
that the first parameter in the command is symmetrically encrypted using
the parameter encryption scheme described in TPM 2.0 Part 1. The TPM
will decrypt the parameter after performing any HMAC computations and
before unmarshaling the parameter. In a response, the attribute is
copied from the request but has no effect on the response.</p>
<p><strong>CLEAR (0):</strong> Session not used for encryption.</p>
<p>For a password authorization, this attribute will be CLEAR in both
the command and response.</p>
<p>This attribute may be SET in a session that is not associated with a
command handle. Such a session is provided for purposes of encrypting a
parameter and not for authorization.</p>
<p>This attribute may be SET in combination with any other session
attributes.</p></td>
</tr>
<tr class="even">
<td>6</td>
<td>encrypt</td>
<td><p><strong>SET (1):</strong> In a command, this setting indicates
that the TPM should use this session to encrypt the first parameter in
the response. In a response, it indicates that the attribute was set in
the command and that the TPM used the session to encrypt the first
parameter in the response using the parameter encryption scheme
described in TPM 2.0 Part 1.</p>
<p><strong>CLEAR (0):</strong> Session not used for encryption.</p>
<p>For a password authorization, this attribute will be CLEAR in both
the command and response.</p>
<p>This attribute may be SET in a session that is not associated with a
command handle. Such a session is provided for purposes of encrypting a
parameter and not for authorization.</p></td>
</tr>
<tr class="odd">
<td>7</td>
<td>audit</td>
<td><p><strong>SET (1):</strong> In a command or response, this setting
indicates that the session is for audit and that <em>auditExclusive</em>
and <em>auditReset</em> have meaning. This session may also be used for
authorization, encryption, or decryption. The <em>encrypted</em> and
<em>encrypt</em> fields may be SET or CLEAR.</p>
<p><strong>CLEAR (0):</strong> Session is not used for audit.</p>
<p>If SET in the command, then this attribute will be SET in the
response.</p></td>
</tr>
</tbody>
</table>

## TPMA_LOCALITY (Locality Attribute)

In a TPMS_CREATION_DATA structure, this structure is used to indicate
the locality of the command that created the object. No more than one of
the locality attributes shall be set in the creation data.

When used in TPM2_PolicyLocality(), this structure indicates which
localities are approved by the policy. When a policy is started, all
localities are allowed. If TPM2_PolicyLocality() is executed, it
indicates that the command may only be executed at specific localities.
More than one locality may be selected.

EXAMPLE 1 TPM_LOC_TWO would indicate that only locality 2 is authorized.

EXAMPLE 2 TPM_LOC_ONE + TPM_LOC_TWO would indicate that locality 1 or 2
is authorized.

EXAMPLE 3 TPM_LOC_FOUR + TPM_LOC_THREE would indicate that localities 3
or 4 are authorized.

EXAMPLE 4 A value of 21<sub>16</sub> would represent a locality of 33.

NOTE Locality values of 5 through 31 are not selectable.

If Extended is non-zero, then an extended locality is indicated and the
TPMA_LOCALITY contains an integer value.

<span id="_Toc380749722" class="anchor"></span>Table 33 — Definition of
(UINT8) TPMA_LOCALITY Bits \<IN/OUT\>

|     |               |                                                                |
|-----|---------------|----------------------------------------------------------------|
| Bit | Name          | Definition                                                     |
| 0   | TPM_LOC_ZERO  |                                                                |
| 1   | TPM_LOC_ONE   |                                                                |
| 2   | TPM_LOC_TWO   |                                                                |
| 3   | TPM_LOC_THREE |                                                                |
| 4   | TPM_LOC_FOUR  |                                                                |
| 7:5 | Extended      | If any of these bits is set, an extended locality is indicated |

## TPMA_PERMANENT

The attributes in this structure are persistent and are not changed as a
result of \_TPM_Init or any TPM2_Startup(). Some of the attributes in
this structure may change as the result of specific Protected
Capabilities. This structure may be read using
TPM2_GetCapability(*capability* = TPM_CAP_TPM_PROPERTIES, *property* =
TPM_PT_PERMANENT).

<span id="_Toc380749723" class="anchor"></span>Table 34 — Definition of
(UINT32) TPMA_PERMANENT Bits \<OUT\>

<table>
<colgroup>
<col style="width: 7%" />
<col style="width: 21%" />
<col style="width: 71%" />
</colgroup>
<thead>
<tr class="header">
<th>Bit</th>
<th>Parameter</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>0</td>
<td>ownerAuthSet</td>
<td><p><strong>SET (1):</strong> TPM2_HierarchyChangeAuth() with
<em>ownerAuth</em> has been executed since the last TPM2_Clear().</p>
<p><strong>CLEAR (0):</strong> o<em>wnerAuth</em> has not been changed
since TPM2_Clear().</p></td>
</tr>
<tr class="even">
<td>1</td>
<td>endorsementAuthSet</td>
<td><p><strong>SET (1):</strong> TPM2_HierarchyChangeAuth() with
<em>endorsementAuth</em> has been executed since the last
TPM2_Clear().</p>
<p><strong>CLEAR (0):</strong> endorsementAuth has not been changed
since TPM2_Clear().</p></td>
</tr>
<tr class="odd">
<td>2</td>
<td>lockoutAuthSet</td>
<td><p><strong>SET (1):</strong> TPM2_HierarchyChangeAuth() with
<em>lockoutAuth</em> has been executed since the last TPM2_Clear().</p>
<p><strong>CLEAR (0):</strong> <em>lockoutAuth</em> has not been changed
since TPM2_Clear().</p></td>
</tr>
<tr class="even">
<td>7:3</td>
<td>Reserved</td>
<td></td>
</tr>
<tr class="odd">
<td>8</td>
<td>disableClear</td>
<td><p><strong>SET (1):</strong> TPM2_Clear() is disabled.</p>
<p><strong>CLEAR (0):</strong> TPM2_Clear() is enabled.</p>
<p>NOTE See “TPM2_ClearControl” in TPM 2.0 Part 3 for details on
changing this attribute.</p></td>
</tr>
<tr class="even">
<td>9</td>
<td>inLockout</td>
<td><strong>SET (1):</strong> The TPM is in lockout, when
<em>failedTries</em> is equal to <em>maxTries</em>.</td>
</tr>
<tr class="odd">
<td>10</td>
<td>tpmGeneratedEPS</td>
<td><p><strong>SET (1):</strong> The EPS was created by the TPM.</p>
<p><strong>CLEAR (0):</strong> The EPS was created outside of the TPM
using a manufacturer-specific process.</p></td>
</tr>
<tr class="even">
<td>31:11</td>
<td>Reserved</td>
<td></td>
</tr>
</tbody>
</table>

## TPMA_STARTUP_CLEAR

This structure may be read using TPM2_GetCapability(*capability* =
TPM_CAP_TPM_PROPERTIES, *property* = TPM_PT_STARTUP_CLEAR).

*phEnable* is SET on any TPM2_Startup. *shEnable*, *ehEnable*, and
*phEnableNV* are SET on TPM Reset or TPM_Restart and preserved by TPM
Resume.

Some of attributes may be changed as the result of specific Protected
Capabilities.

<span id="_Toc380749724" class="anchor"></span>Table 35 — Definition of
(UINT32) TPMA_STARTUP_CLEAR Bits \<OUT\>

<table>
<colgroup>
<col style="width: 7%" />
<col style="width: 19%" />
<col style="width: 72%" />
</colgroup>
<thead>
<tr class="header">
<th>Bit</th>
<th>Parameter</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>0</td>
<td>phEnable</td>
<td><p><strong>SET (1):</strong> The platform hierarchy is enabled and
<em>platformAuth</em> or <em>platformPolicy</em> may be used for
authorization.</p>
<p><strong>CLEAR (0):</strong> <em>platformAuth</em> and
<em>platformPolicy</em> may not be used for authorizations, and objects
in the platform hierarchy, including persistent objects, cannot be
used.</p>
<p>NOTE See “TPM2_HierarchyControl” in TPM 2.0 Part 3 for details on
changing this attribute.</p></td>
</tr>
<tr class="even">
<td>1</td>
<td>shEnable</td>
<td><p><strong>SET (1):</strong> The Storage hierarchy is enabled and
<em>ownerAuth</em> or <em>ownerPolicy</em> may be used for
authorization. NV indices defined using owner authorization are
accessible.</p>
<p><strong>CLEAR (0):</strong> <em>ownerAuth</em> and
<em>ownerPolicy</em> may not be used for authorizations, and objects in
the Storage hierarchy, persistent objects, and NV indices defined using
owner authorization cannot be used.</p>
<p>NOTE See “TPM2_HierarchyControl” in TPM 2.0 Part 3 for details on
changing this attribute.</p></td>
</tr>
<tr class="odd">
<td>2</td>
<td>ehEnable</td>
<td><p><strong>SET (1):</strong> The EPS hierarchy is enabled and
Endorsement Authorization may be used to authorize commands.</p>
<p><strong>CLEAR (0):</strong> Endorsement Authorization may not be used
for authorizations, and objects in the endorsement hierarchy, including
persistent objects, cannot be used.</p>
<p>NOTE See “TPM2_HierarchyControl” in TPM 2.0 Part 3 for details on
changing this attribute.</p></td>
</tr>
<tr class="even">
<td>3</td>
<td>phEnableNV</td>
<td><p><strong>SET (1):</strong> NV indices that have
TPMA_NV_PLATFORMCREATE SET may be read or written. The platform can
create define and undefine indices.</p>
<p><strong>CLEAR (0):</strong> NV indices that have
TPMA_NV_PLATFORMCREATE SET may not be read or written (TPM_RC_HANDLE).
The platform cannot define (TPM_RC_HIERARCHY) or undefined
(TPM_RC_HANDLE) indices.</p>
<p>NOTE See “TPM2_HierarchyControl” in TPM 2.0 Part 3 for details on
changing this attribute.</p>
<p>NOTE</p>
<p>read refers to these commands: TPM2_NV_Read, TPM2_NV_ReadPublic,
TPM_NV_Certify, TPM2_PolicyNV</p>
<p>write refers to these commands: TPM2_NV_Write, TPM2_NV_Increment,
TPM2_NV_Extend, TPM2_NV_SetBits</p>
<p>NOTE The TPM must query the index TPMA_NV_PLATFORMCREATE attribute to
determine whether phEnableNV is applicable. Since the TPM will return
TPM_RC_HANDLE if the index does not exist, it also returns this error
code if the index is disabled. Otherwise, the TPM would leak the
existence of an index even when disabled.</p></td>
</tr>
<tr class="odd">
<td>30:4</td>
<td>Reserved</td>
<td>shall be zero</td>
</tr>
<tr class="even">
<td>31</td>
<td>orderly</td>
<td><p><strong>SET (1):</strong> The TPM received a TPM2_Shutdown() and
a matching TPM2_Startup().</p>
<p><strong>CLEAR (0):</strong> TPM2_Startup(TPM_SU_CLEAR) was not
preceded by a TPM2_Shutdown() of any type.</p>
<p>NOTE A shutdown is orderly if the TPM receives a TPM2_Shutdown() of
any type followed by a TPM2_Startup() of any type. However, the TPM will
return an error if TPM2_Startup(TPM_SU_STATE) was not preceded by
TPM2_Shutdown(TPM_SU_STATE).</p></td>
</tr>
</tbody>
</table>

## TPMA_MEMORY

This structure of this attribute is used to report the memory management
method used by the TPM for transient objects and authorization sessions.
This structure may be read using TPM2_GetCapability(*capability* =
TPM_CAP_TPM_PROPERTIES, *property* = TPM_PT_MEMORY).

If the RAM memory is shared, then context save of a session may make it
possible to load an additional transient object.

<span id="_Toc380749725" class="anchor"></span>Table 36 — Definition of
(UINT32) TPMA_MEMORY Bits \<Out\>

<table>
<colgroup>
<col style="width: 6%" />
<col style="width: 25%" />
<col style="width: 68%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Bit</td>
<td>Name</td>
<td>Definition</td>
</tr>
<tr class="even">
<td>0</td>
<td>sharedRAM</td>
<td><p><strong>SET (1):</strong> indicates that the RAM memory used for
authorization session contexts is shared with the memory used for
transient objects</p>
<p><strong>CLEAR (0):</strong> indicates that the memory used for
authorization sessions is not shared with memory used for transient
objects</p></td>
</tr>
<tr class="odd">
<td>1</td>
<td>sharedNV</td>
<td><p><strong>SET (1):</strong> indicates that the NV memory used for
persistent objects is shared with the NV memory used for NV Index
values</p>
<p><strong>CLEAR (0):</strong> indicates that the persistent objects and
NV Index values are allocated from separate sections of NV</p></td>
</tr>
<tr class="even">
<td>2</td>
<td>objectCopiedToRam</td>
<td><p><strong>SET (1):</strong> indicates that the TPM copies
persistent objects to a transient-object slot in RAM when the persistent
object is referenced in a command. The TRM is required to make sure that
an object slot is available.</p>
<p><strong>CLEAR (0):</strong> indicates that the TPM does not use
transient-object slots when persistent objects are referenced</p></td>
</tr>
<tr class="odd">
<td>31:3</td>
<td>Reserved</td>
<td>shall be zero</td>
</tr>
</tbody>
</table>

## TPMA_CC (Command Code Attributes)

### Introduction

This structure defines the attributes of a command from a context
management perspective. The fields of the structure indicate to the TPM
Resource Manager (TRM) the number of resources required by a command and
how the command affects the TPM’s resources.

This structure is only used in a list returned by the TPM in response to
TPM2_GetCapability(capability = TPM_CAP_COMMANDS).

For a command to the TPM, only the *commandIndex* field and *V*
attribute are allowed to be non-zero.

### Structure Definition

<span id="_Ref435084841" class="anchor"></span>Table 37 — Definition of
(TPM_CC) TPMA_CC Bits \<OUT\>

<table>
<colgroup>
<col style="width: 7%" />
<col style="width: 23%" />
<col style="width: 69%" />
</colgroup>
<thead>
<tr class="header">
<th>Bit</th>
<th>Name</th>
<th>Definition</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>15:0</td>
<td>commandIndex</td>
<td>indicates the command being selected</td>
</tr>
<tr class="even">
<td>21:16</td>
<td>Reserved</td>
<td>shall be zero</td>
</tr>
<tr class="odd">
<td>22</td>
<td>nv</td>
<td><p><strong>SET (1):</strong> indicates that the command may write to
NV</p>
<p><strong>CLEAR (0):</strong> indicates that the command does not write
to NV</p></td>
</tr>
<tr class="even">
<td>23</td>
<td>extensive</td>
<td><p><strong>SET (1):</strong> This command could flush any number of
loaded contexts.</p>
<p><strong>CLEAR (0):</strong> no additional changes other than
indicated by the <em>flushed</em> attribute</p></td>
</tr>
<tr class="odd">
<td>24</td>
<td>flushed</td>
<td><p><strong>SET (1):</strong> The context associated with any
transient handle in the command will be flushed when this command
completes.</p>
<p><strong>CLEAR (0):</strong> No context is flushed as a side effect of
this command.</p></td>
</tr>
<tr class="even">
<td>27:25</td>
<td>cHandles</td>
<td>indicates the number of the handles in the handle area for this
command</td>
</tr>
<tr class="odd">
<td>28</td>
<td>rHandle</td>
<td><strong>SET (1):</strong> indicates the presence of the handle area
in the response</td>
</tr>
<tr class="even">
<td>29</td>
<td>V</td>
<td><p><strong>SET (1):</strong> indicates that the command is
vendor-specific</p>
<p><strong>CLEAR (0):</strong> indicates that the command is defined in
a version of this specification</p></td>
</tr>
<tr class="odd">
<td>31:30</td>
<td>Res</td>
<td>allocated for software; shall be zero</td>
</tr>
</tbody>
</table>

### Field Descriptions

#### Bits\[15:0\] – *commandIndex*

This is the command index of the command in the set of commands. The two
sets are defined by the *V* attribute. If *V* is zero, then the
*commandIndex* shall be in the set of commands defined in a version of
this specification. If *V* is one, then the meaning of *commandIndex* is
as determined by the TPM vendor.

#### Bit\[22\] – *nv*

If this attribute is SET, then the TPM <u>may</u> perform an NV write as
part of the command actions. This write is independent of any write that
may occur as a result of dictionary attack protection. If this attribute
is CLEAR, then the TPM shall not perform an NV write as part of the
command actions.

#### Bit\[23\] – *extensive*

If this attribute is SET, then the TPM may flush many transient objects
as a side effect of this command. In TPM 2.0 Part 3, a command that has
this attribute is indicated by using a “{E}” decoration in the
“Description” column of the *commandCode* parameter.

EXAMPLE See “TPM2_Clear” in TPM 2.0 Part 3.

NOTE The “{E}” decoration may be combined with other decorations such as
“{NV}” in which case the decoration would be “{NV E}.”

#### Bit\[24\] – *flushed*

If this attribute is SET, then the TPM will flush transient objects as a
side effect of this command. Any transient objects listed in the handle
area of the command will be flushed from TPM memory. Handles associated
with persistent objects, sessions, PCR, or other fixed TPM resources are
not flushed.

NOTE The TRM is expected to use this value to determine how many objects
are loaded into transient TPM memory.

NOTE The “{F}” decoration may be combined with other decorations such as
“{NV}” in which case the decoration would be “{NV F}.”

If this attribute is SET for a command, and the handle of the command is
associated with a hierarchy (TPM_RH_PLATFORM, TPM_RH_OWNER, or
TPM_RH_ENDORSEMENT), all loaded objects in the indicated hierarchy are
flushed.

The TRM is expected to know the behaviour of TPM2_ContextSave(), and
sessions are flushed when context saved, but objects are not. The
*flushed* attribute for that command shall be CLEAR.

In TPM 2.0 Part 3, a command that has this attribute is indicated by
using a “{F}” decoration in the “Description” column of the
*commandCode* parameter.

EXAMPLE See “TPM2_SequenceComplete” in TPM 2.0 Part 3.”

#### Bits\[27:25\] – *cHandles*

This field indicates the number of handles in the handle area of the
command. This number allows the TRM to enumerate the handles in the
handle area and find the position of the authorizations (if any).

#### Bit\[28\] – *rHandle*

If this attribute is SET, then the response to this command has a handle
area. This area will contain no more than one handle. This field is
necessary to allow the TRM to locate the *parameterSize* field in the
response, which is then used to locate the authorizations.

NOTE The TRM is expected to “virtualize” the handle value for any
returned handle.

A TPM command is only allowed to have one handle in the response handle
area.

#### Bit\[29\] – V

When this attribute is SET, it indicates that the command operation is
defined by the TPM vendor. When CLEAR, it indicates that the command is
defined by a version of this specification.

#### Bits\[31:30\] – Res

This field is reserved for system software. This field is required to be
zero for a command to the TPM.

## TPMA_MODES

This structure of this attribute is used to report that the TPM is
designed for these modes. This structure may be read using
TPM2_GetCapability(*capability* = TPM_CAP_TPM_PROPERTIES, *property* =
TPM_PT_MODES).

NOTE: To determine the certification status of a TPM with the FIPS_140_2
attribute SET, consult the NIST Module Validation List at
http://csrc.nist.gov/groups/STM/cmvp/validation.html.

<span id="_Toc432512534" class="anchor"></span>Table 38 — Definition of
(UINT32) TPMA_MODES Bits \<Out\>

|      |            |                                                                                                                         |
|------|------------|-------------------------------------------------------------------------------------------------------------------------|
| Bit  | Name       | Definition                                                                                                              |
| 0    | FIPS_140_2 | **SET (1):** indicates that the TPM is designed to comply with all of the FIPS 140-2 requirements at Level 1 or higher. |
| 31:1 | Reserved   | shall be zero                                                                                                           |

## TPMA_X509_KEY_USAGE

These attributes are as specified in clause 4.2.1.3. of RFC 5280
*Internet X.509 Public Key Infrastructure Certificate and Certificate
Revocation List (CRL) Profile.* For TPM2_CertifyX509, when a caller
provides a DER encoded Key Usage in *partialCertificate*, the TPM will
validate that the key to be certified meets the requirements of Key
Usage.

RFC 5280 describes these attributes in terms of how the public key in
the certificate should be used. The TPM needs to check that the
attributes of the key allow the private part of the key to be used for a
purpose that is complimentary to the use of the public key. That is, if
the public key should be used to verify signatures, the private key
needs to be able to create the signatures (have *sign* SET).

This structure is defined to provide labels of the attributes for use by
the TPM code that validates the attributes. This structure is input to
the TPM as a DER encoded structure and not in the normal, TPM-canonical
form.

This structure is only input to the TPM in a DER-encoded structure and
is not present on the interface in canonical TPM format.

Table 39 — Definition of (UINT32) TPMA_X509_KEY_USAGE Bits\<\>

| Bit  | Atrribute                        | Requirements                                                                                |
|------|----------------------------------|---------------------------------------------------------------------------------------------|
| 22:0 | Reserved                         |                                                                                             |
| 23   | decipherOnly                     | Attributes.Decrypt SET                                                                      |
| 24   | encipherOnly                     | Attributes.Decrypt SET                                                                      |
| 25   | cRLSign                          | Attributes.sign SET                                                                         |
| 26   | keyCertSign                      | Attributes.sign SET                                                                         |
| 27   | keyAgreement                     | Attributes.Decrypt SET                                                                      |
| 28   | dataEncipherment                 | Attributes.Decrypt SET                                                                      |
| 29   | keyEncipherment                  | asymmetric key with *decrypt* and *restricted* SET – key has the attributes of a parent key |
| 30   | nonrepudiation/contentCommitment | *fixedTPM* SET in Subject Key (*objectHandle*)                                              |
| 31   | digitalSignature                 | *sign* SET in Subject Key (*objectHandle*)                                                  |

## TPMA_ACT

This attribute is used to report the ACT state. This attribute may be
read using TPM2_GetCapability(*capability* = TPM_CAP_ACT, *property* =
TPM_RH_ACT\_”x” where “x” is the ACT number (0-F)). The *signaled* value
must be preserved across TPM Resume or if the TPM has not lost power.
The *signaled* value may be preserved over a power cycle of a TPM.

NOTE: The ACT signaled value is reset to zero when the ACT is next
accessed by TPM2_ACT_SetTimeout() with a non-zero *startTimeout*.

<span id="_Toc21376087" class="anchor"></span>Table 40 — Definition of
(UINT32) TPMA_ACT Bits

<table>
<colgroup>
<col style="width: 6%" />
<col style="width: 24%" />
<col style="width: 69%" />
</colgroup>
<thead>
<tr class="header">
<th>Bit</th>
<th>Name</th>
<th>Definition</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>0</td>
<td>signaled</td>
<td><p><strong>SET (1):</strong> The ACT has signaled</p>
<p><strong>CLEAR (0):</strong> The ACT has not signaled</p></td>
</tr>
<tr class="even">
<td>1</td>
<td>preserveSignaled</td>
<td><p><strong>SET (1):</strong> The ACT signaled bit is preserved over
a power cycle</p>
<p><strong>CLEAR (0):</strong> The ACT signaled bit is not preserved
over a power cycle</p></td>
</tr>
<tr class="odd">
<td>31:2</td>
<td>Reserved</td>
<td>shall be zero</td>
</tr>
</tbody>
</table>

<span id="_Toc20317608" class="anchor"></span>

# Interface Types

## Introduction

Clause 8.11 contains definitions for interface types. An interface type
is type checked when it is unmarshaled. These types are based on an
underlying type that is indicated in the table title by the value in
parentheses. When an interface type is used, the base type is
unmarshaled and then checked to see if it has one of the allowed values.

## TPMI_YES_NO

This interface type is used in place of a Boolean type in order to
eliminate ambiguity in the handling of a octet that conveys a single bit
of information. This type only has two allowed values, YES (1) and NO
(0).

NOTE This list is not used as input to the TPM.

<span id="_Toc380749727" class="anchor"></span>Table 41 — Definition of
(BYTE) TPMI_YES_NO Type

|                |              |
|----------------|--------------|
| Value          | Description  |
| NO             | a value of 0 |
| YES            | a value of 1 |
| \#TPM_RC_VALUE |              |

## TPMI_DH_OBJECT

The TPMI_DH_OBJECT interface type is a handle that references a loaded
object. The handles in this set are used to refer to either transient or
persistent object. The range of these values would change according to
the TPM implementation.

NOTE These interface types should not be used by system software to
qualify the keys produced by the TPM. The value returned by the TPM
shall be used to reference the object.

<span id="_Toc380749728" class="anchor"></span>Table 42 — Definition of
(TPM_HANDLE) TPMI_DH_OBJECT Type

| Values                             | Comments                             |
|------------------------------------|--------------------------------------|
| {TRANSIENT_FIRST:TRANSIENT_LAST}   | allowed range for transient objects  |
| {PERSISTENT_FIRST:PERSISTENT_LAST} | allowed range for persistent objects |
| +TPM_RH_NULL                       | the conditional value                |
| \#TPM_RC_VALUE                     |                                      |

## TPMI_DH_PARENT

The TPMI_DH_PARENT interface type is a handle that references an object
that can be the parent of another object. The handles in this set may
refer to either transient or persistent object or to Primary Seeds.

<span id="_Toc470518115" class="anchor"></span>Table 43 — Definition of
(TPM_HANDLE) TPMI_DH_PARENT Type

| Values                             | Comments                             |
|------------------------------------|--------------------------------------|
| {TRANSIENT_FIRST:TRANSIENT_LAST}   | allowed range for transient objects  |
| {PERSISTENT_FIRST:PERSISTENT_LAST} | allowed range for persistent objects |
| TPM_RH_OWNER                       | Storage hierarchy                    |
| TPM_RH_PLATFORM                    | Platform hierarchy                   |
| TPM_RH_ENDORSEMENT                 | Endorsement hierarchy                |
| +TPM_RH_NULL                       | no hierarchy                         |
| \#TPM_RC_VALUE                     |                                      |

## TPMI_DH_PERSISTENT

The TPMI_DH_PERSISTENT interface type is a handle that references a
location for a transient object. This type is used in
TPM2_EvictControl() to indicate the handle to be assigned to the
persistent object.

<span id="_Toc380749729" class="anchor"></span>Table 44 — Definition of
(TPM_HANDLE) TPMI_DH_PERSISTENT Type

| Values                             | Comments                             |
|------------------------------------|--------------------------------------|
| {PERSISTENT_FIRST:PERSISTENT_LAST} | allowed range for persistent objects |
| \#TPM_RC_VALUE                     |                                      |

## TPMI_DH_ENTITY

The TPMI_DH_ENTITY interface type is TPM-defined values that are used to
indicate that the handle refers to an *authValue*. The range of these
values would change according to the TPM implementation.

<span id="_Toc380749730" class="anchor"></span>Table 45 — Definition of
(TPM_HANDLE) TPMI_DH_ENTITY Type \<IN\>

| Values                               | Comments                                      |
|--------------------------------------|-----------------------------------------------|
| TPM_RH_OWNER                         |                                               |
| TPM_RH_ENDORSEMENT                   |                                               |
| TPM_RH_PLATFORM                      |                                               |
| TPM_RH_LOCKOUT                       |                                               |
| {TRANSIENT_FIRST : TRANSIENT_LAST}   | range of object handles                       |
| {PERSISTENT_FIRST : PERSISTENT_LAST} |                                               |
| {NV_INDEX_FIRST : NV_INDEX_LAST}     |                                               |
| {PCR_FIRST : PCR_LAST}               |                                               |
| {TPM_RH_AUTH_00 : TPM_RH_AUTH_FF}    | range of vendor-specific authorization values |
| +TPM_RH_NULL                         | conditional value                             |
| \#TPM_RC_VALUE                       |                                               |

## TPMI_DH_PCR

This interface type consists of the handles that may be used as PCR
references. The upper end of this range of values would change according
to the TPM implementation.

NOTE 1 Typically, the 0<sup>th</sup> PCR will have a handle value of
zero.

NOTE 2 The handle range for PCR is defined to be the same as the handle
range for PCR in previous versions of TPM specifications.

<span id="_Toc380749731" class="anchor"></span>Table 46 — Definition of
(TPM_HANDLE) TPMI_DH_PCR Type \<IN\>

| Values               | Comments          |
|----------------------|-------------------|
| {PCR_FIRST:PCR_LAST} |                   |
| +TPM_RH_NULL         | conditional value |
| \#TPM_RC_VALUE       |                   |

## TPMI_SH_AUTH_SESSION

The TPMI_SH_AUTH_SESSION interface type is TPM-defined values that are
used to indicate that the handle refers to an authorization session.

<span id="_Toc380749732" class="anchor"></span>Table 47 — Definition of
(TPM_HANDLE) TPMI_SH_AUTH_SESSION Type \<IN/OUT\>

| Values                                      | Comments                                      |
|---------------------------------------------|-----------------------------------------------|
| {HMAC_SESSION_FIRST : HMAC_SESSION_LAST}    | range of HMAC authorization session handles   |
| {POLICY_SESSION_FIRST: POLICY_SESSION_LAST} | range of policy authorization session handles |
| +TPM_RS_PW                                  | a password authorization                      |
| \#TPM_RC_VALUE                              | error returned if the handle is out of range  |

## TPMI_SH_HMAC

This interface type is used for an authorization handle when the
authorization session uses an HMAC.

<span id="_Toc380749733" class="anchor"></span>Table 48 — Definition of
(TPM_HANDLE) TPMI_SH_HMAC Type \<IN/OUT\>

| Values                                  | Comments                                     |
|-----------------------------------------|----------------------------------------------|
| {HMAC_SESSION_FIRST: HMAC_SESSION_LAST} | range of HMAC authorization session handles  |
| \#TPM_RC_VALUE                          | error returned if the handle is out of range |

## TPMI_SH_POLICY

This interface type is used for a policy handle when it appears in a
policy command.

<span id="_Toc380749734" class="anchor"></span>Table 49 — Definition of
(TPM_HANDLE) TPMI_SH_POLICY Type \<IN/OUT\>

| Values                                      | Comments                                      |
|---------------------------------------------|-----------------------------------------------|
| {POLICY_SESSION_FIRST: POLICY_SESSION_LAST} | range of policy authorization session handles |
| \#TPM_RC_VALUE                              | error returned if the handle is out of range  |

## TPMI_DH_CONTEXT

This type defines the handle values that may be used in
TPM2_ContextSave() or TPM2_Flush().

<span id="_Toc380749735" class="anchor"></span>Table 50 — Definition of
(TPM_HANDLE) TPMI_DH_CONTEXT Type

| Values                                     | Comments |
|--------------------------------------------|----------|
| {HMAC_SESSION_FIRST : HMAC_SESSION_LAST}   |          |
| {POLICY_SESSION_FIRST:POLICY_SESSION_LAST} |          |
| {TRANSIENT_FIRST:TRANSIENT_LAST}           |          |
| \#TPM_RC_VALUE                             |          |

## TPMI_DH_SAVED

This type defines the handle values that may be used in
TPM2_ContextSave() or TPM2_FlushContext().

<span id="_Toc516155165" class="anchor"></span>Table 51 — Definition of
(TPM_HANDLE) TPMI_DH_SAVED Type

| Values                                     | Comments                                            |
|--------------------------------------------|-----------------------------------------------------|
| {HMAC_SESSION_FIRST : HMAC_SESSION_LAST}   | an HMAC session context                             |
| {POLICY_SESSION_FIRST:POLICY_SESSION_LAST} | a policy session context                            |
| 0x80000000                                 | an ordinary transient object                        |
| 0x80000001                                 | a sequence object                                   |
| 0x80000002                                 | a transient object with the *stClear* attribute SET |
| \#TPM_RC_VALUE                             |                                                     |

## TPMI_RH_HIERARCHY

The TPMI_RH_HIERARCHY interface type is used as the type of a handle in
a command when the handle is required to be one of the hierarchy
selectors.

<span id="_Toc380749736" class="anchor"></span>Table 52 — Definition of
(TPM_HANDLE) TPMI_RH_HIERARCHY Type

| Values             | Comments                                                        |
|--------------------|-----------------------------------------------------------------|
| TPM_RH_OWNER       | Storage hierarchy                                               |
| TPM_RH_PLATFORM    | Platform hierarchy                                              |
| TPM_RH_ENDORSEMENT | Endorsement hierarchy                                           |
| +TPM_RH_NULL       | no hierarchy                                                    |
| \#TPM_RC_VALUE     | response code returned when the unmarshaling of this type fails |

## TPMI_RH_ENABLES

The TPMI_RH_ENABLES interface type is used as the type of a handle in a
command when the handle is required to be one of the hierarchy or NV
enables.

<span id="_Toc380749737" class="anchor"></span>Table 53 — Definition of
(TPM_HANDLE) TPMI_RH_ENABLES Type

| Values             | Comments                                                        |
|--------------------|-----------------------------------------------------------------|
| TPM_RH_OWNER       | Storage hierarchy                                               |
| TPM_RH_PLATFORM    | Platform hierarchy                                              |
| TPM_RH_ENDORSEMENT | Endorsement hierarchy                                           |
| TPM_RH_PLATFORM_NV | Platform NV                                                     |
| +TPM_RH_NULL       | no hierarchy                                                    |
| \#TPM_RC_VALUE     | response code returned when the unmarshaling of this type fails |

## TPMI_RH_HIERARCHY_AUTH

This interface type is used as the type of a handle in a command when
the handle is required to be one of the hierarchy selectors or the
Lockout Authorization.

<span id="_Toc380749738" class="anchor"></span>Table 54 — Definition of
(TPM_HANDLE) TPMI_RH_HIERARCHY_AUTH Type \<IN\>

| Values             | Comments                                                        |
|--------------------|-----------------------------------------------------------------|
| TPM_RH_OWNER       | Storage hierarchy                                               |
| TPM_RH_PLATFORM    | Platform hierarchy                                              |
| TPM_RH_ENDORSEMENT | Endorsement hierarchy                                           |
| TPM_RH_LOCKOUT     | Lockout Authorization                                           |
| \#TPM_RC_VALUE     | response code returned when the unmarshaling of this type fails |

## TPMI_RH_HIERARCHY_POLICY

This interface type is used as the type of a handle in a command when
the handle is required to be one of the hierarchy selectors, the Lockout
Authorization, or an ACT. This type is used in TPM2_SetPrimaryPolicy().

<span id="_Toc21376102" class="anchor"></span>Table 55 — Definition of
(TPM_HANDLE) TPMI_RH_HIERARCHY_POLICY Type \<IN\>

| Values                      | Comments                                                        |
|-----------------------------|-----------------------------------------------------------------|
| TPM_RH_OWNER                | Storage hierarchy                                               |
| TPM_RH_PLATFORM             | Platform hierarchy                                              |
| TPM_RH_ENDORSEMENT          | Endorsement hierarchy                                           |
| TPM_RH_LOCKOUT              | Lockout Authorization                                           |
| {TPM_RH_ACT_0:TPM_RH_ACT_F} | Authenticated Countdown Timer                                   |
| \#TPM_RC_VALUE              | response code returned when the unmarshaling of this type fails |

## TPMI_RH_PLATFORM

The TPMI_RH_PLATFORM interface type is used as the type of a handle in a
command when the only allowed handle is TPM_RH_PLATFORM indicating that
Platform Authorization is required.

<span id="_Toc380749739" class="anchor"></span>Table 56 — Definition of
(TPM_HANDLE) TPMI_RH_PLATFORM Type \<IN\>

| Values          | Comments                                                        |
|-----------------|-----------------------------------------------------------------|
| TPM_RH_PLATFORM | Platform hierarchy                                              |
| \#TPM_RC_VALUE  | response code returned when the unmarshaling of this type fails |

## TPMI_RH_OWNER

This interface type is used as the type of a handle in a command when
the only allowed handle is TPM_RH_OWNER indicating that Owner
Authorization is required.

<span id="_Toc380749740" class="anchor"></span>Table 57 — Definition of
(TPM_HANDLE) TPMI_RH_OWNER Type \<IN\>

| Values         | Comments                                                        |
|----------------|-----------------------------------------------------------------|
| TPM_RH_OWNER   | Owner hierarchy                                                 |
| +TPM_RH_NULL   | may allow the null handle                                       |
| \#TPM_RC_VALUE | response code returned when the unmarshaling of this type fails |

## TPMI_RH_ENDORSEMENT

This interface type is used as the type of a handle in a command when
the only allowed handle is TPM_RH_ENDORSEMENT indicating that
Endorsement Authorization is required.

<span id="_Toc380749741" class="anchor"></span>Table 58 — Definition of
(TPM_HANDLE) TPMI_RH_ENDORSEMENT Type \<IN\>

| Values             | Comments                                                        |
|--------------------|-----------------------------------------------------------------|
| TPM_RH_ENDORSEMENT | Endorsement hierarchy                                           |
| +TPM_RH_NULL       | may allow the null handle                                       |
| \#TPM_RC_VALUE     | response code returned when the unmarshaling of this type fails |

## TPMI_RH_PROVISION

The TPMI_RH_PROVISION interface type is used as the type of the handle
in a command when the only allowed handles are either TPM_RH_OWNER or
TPM_RH_PLATFORM indicating that either Platform Authorization or Owner
Authorization are allowed.

In most cases, either Platform Authorization or Owner Authorization may
be used to authorize the commands used for management of the resources
of the TPM and this interface type will be used.

<span id="_Ref245089346" class="anchor"></span>Table 59 — Definition of
(TPM_HANDLE) TPMI_RH_PROVISION Type \<IN\>

| Value           | Comments                                                        |
|-----------------|-----------------------------------------------------------------|
| TPM_RH_OWNER    | handle for Owner Authorization                                  |
| TPM_RH_PLATFORM | handle for Platform Authorization                               |
| \#TPM_RC_VALUE  | response code returned when the unmarshaling of this type fails |

## TPMI_RH_CLEAR

The TPMI_RH_CLEAR interface type is used as the type of the handle in a
command when the only allowed handles are either TPM_RH_LOCKOUT or
TPM_RH_PLATFORM indicating that either Platform Authorization or Lockout
Authorization are allowed.

This interface type is normally used for performing or controlling
TPM2_Clear().

<span id="_Toc380749743" class="anchor"></span>Table 60 — Definition of
(TPM_HANDLE) TPMI_RH_CLEAR Type \<IN\>

| Value           | Comments                                                        |
|-----------------|-----------------------------------------------------------------|
| TPM_RH_LOCKOUT  | handle for Lockout Authorization                                |
| TPM_RH_PLATFORM | handle for Platform Authorization                               |
| \#TPM_RC_VALUE  | response code returned when the unmarshaling of this type fails |

## TPMI_RH_NV_AUTH

This interface type is used to identify the source of the authorization
for access to an NV location. The handle value of a TPMI_RH_NV_AUTH
shall indicate that the authorization value is either Platform
Authorization, Owner Authorization, or the *authValue.* This type is
used in the commands that access an NV Index (commands of the form
TPM2_NV_xxx) other than TPM2_NV_DefineSpace() and
TPM2_NV_UndefineSpace().

<span id="_Toc380749744" class="anchor"></span>Table 61 — Definition of
(TPM_HANDLE) TPMI_RH_NV_AUTH Type \<IN\>

| Value                          | Comments                                                    |
|--------------------------------|-------------------------------------------------------------|
| TPM_RH_PLATFORM                | Platform Authorization is allowed                           |
| TPM_RH_OWNER                   | Owner Authorization is allowed                              |
| {NV_INDEX_FIRST:NV_INDEX_LAST} | range for NV locations                                      |
| \#TPM_RC_VALUE                 | response code returned when unmarshaling of this type fails |

## TPMI_RH_LOCKOUT

The TPMI_RH_LOCKOUT interface type is used as the type of a handle in a
command when the only allowed handle is TPM_RH_LOCKOUT indicating that
Lockout Authorization is required.

<span id="_Toc380749745" class="anchor"></span>Table 62 — Definition of
(TPM_HANDLE) TPMI_RH_LOCKOUT Type \<IN\>

| Value          | Comments                                                        |
|----------------|-----------------------------------------------------------------|
| TPM_RH_LOCKOUT | handle for Lockout Authorization                                |
| \#TPM_RC_VALUE | response code returned when the unmarshaling of this type fails |

## TPMI_RH_NV_INDEX

This interface type is used to identify an NV location. This type is
used in the NV commands.

<span id="_Toc380749746" class="anchor"></span>Table 63 — Definition of
(TPM_HANDLE) TPMI_RH_NV_INDEX Type \<IN/OUT\>

| Value                          | Comments                                     |
|--------------------------------|----------------------------------------------|
| {NV_INDEX_FIRST:NV_INDEX_LAST} | Range of NV Indexes                          |
| \#TPM_RC_VALUE                 | error returned if the handle is out of range |

## TPMI_RH_AC

This interface type is used to identify an attached component. This type
is used in the AC commands.

<span id="_Toc470518134" class="anchor"></span>Table 64 — Definition of
(TPM_HANDLE) TPMI_RH_AC Type \<IN\>

| Value              | Comments                                     |
|--------------------|----------------------------------------------|
| {AC_FIRST:AC_LAST} | Range of AC handles                          |
| \#TPM_RC_VALUE     | error returned if the handle is out of range |

## TPMI_RH_ACT

This interface type is used to identify the ACT instance used in
TPM2_ACT_SetTimeout().

<span id="_Toc21376112" class="anchor"></span>Table 65 — Definition of
(TPM_HANDLE) TPMI_RH_ACT Type

| Value                       | Comments                                                        |
|-----------------------------|-----------------------------------------------------------------|
| {TPM_RH_ACT_0:TPM_RH_ACT_F} | handles for the Authenticated Countdown Timers                  |
| \#TPM_RC_VALUE              | response code returned when the unmarshaling of this type fails |

## TPMI_ALG_HASH

A TPMI_ALG_HASH is an interface type of all the hash algorithms
implemented on a specific TPM. The selector in Table 66 indicates all of
the hash algorithms that have an algorithm ID assigned by the TCG and
does not indicate the algorithms that will be accepted by a TPM.

NOTE When implemented, each of the algorithm entries is delimited by
\#ifdef and \#endif so that, if the algorithm is not implemented in a
specific TPM, that algorithm is not included in the interface type.

<span id="_Ref248023934" class="anchor"></span>Table 66 — Definition of
(TPM_ALG_ID) TPMI_ALG_HASH Type

| Values          | Comments                               |
|-----------------|----------------------------------------|
| TPM_ALG\_!ALG.H | all hash algorithms defined by the TCG |
| +TPM_ALG_NULL   |                                        |
| \#TPM_RC_HASH   |                                        |

## TPMI_ALG_ASYM (Asymmetric Algorithms)

A TPMI_ALG_ASYM is an interface type of all the asymmetric algorithms
implemented on a specific TPM. Table 67 lists each of the asymmetric
algorithms that have an algorithm ID assigned by the TCG.

<span id="_Ref307234064" class="anchor"></span>Table 67 — Definition of
(TPM_ALG_ID) TPMI_ALG_ASYM Type

| Values              | Comments                    |
|---------------------|-----------------------------|
| TPM_ALG\_!ALG.AO    | all asymmetric object types |
| +TPM_ALG_NULL       |                             |
| \#TPM_RC_ASYMMETRIC |                             |

## TPMI_ALG_SYM (Symmetric Algorithms)

A TPMI_ALG_SYM is an interface type of all the symmetric algorithms that
have an algorithm ID assigned by the TCG and are implemented on the TPM.

NOTE The validation code produced by an example script will produce a
CASE statement with a case for each of the values in the “Values”
column. The case for a value is delimited by a \#ifdef/#endif pair so
that if the algorithm is not implemented on the TPM, then the case for
the algorithm is not generated, and use of the algorithm will cause a
TPM error (TPM_RC_SYMMETRIC).

<span id="_Toc380749749" class="anchor"></span>Table 68 — Definition of
(TPM_ALG_ID) TPMI_ALG_SYM Type

| Values             | Comments                                             |
|--------------------|------------------------------------------------------|
| TPM_ALG\_!ALG.S    | all symmetric block ciphers                          |
| TPM_ALG_XOR        | required                                             |
| +TPM_ALG_NULL      | required to be present in all versions of this table |
| \#TPM_RC_SYMMETRIC |                                                      |

## TPMI_ALG_SYM_OBJECT

A TPMI_ALG_SYM_OBJECT is an interface type of all the TCG-defined
symmetric algorithms that may be used as companion symmetric encryption
algorithm for an asymmetric object. All algorithms in this list shall be
block ciphers usable in Cipher Feedback (CFB).

NOTE TPM_ALG_XOR is not allowed in this list.

<span id="_Ref307234311" class="anchor"></span>Table 69 — Definition of
(TPM_ALG_ID) TPMI_ALG_SYM_OBJECT Type

| Values             | Comments                                             |
|--------------------|------------------------------------------------------|
| TPM_ALG\_!ALG.S    | all symmetric block ciphers                          |
| +TPM_ALG_NULL      | required to be present in all versions of this table |
| \#TPM_RC_SYMMETRIC |                                                      |

## TPMI_ALG_SYM_MODE

A TPMI_ALG_SYM_MODE is an interface type of all the TCG-defined
block-cipher modes of operation.

<span id="_Toc380749751" class="anchor"></span>Table 70 — Definition of
(TPM_ALG_ID) TPMI_ALG_SYM_MODE Type

| Values           | Comments                                               |
|------------------|--------------------------------------------------------|
| TPM_ALG\_!ALG.SE | all symmetric block cipher encryption/decryption modes |
| TPM_ALG\_!ALG.SX | all symmetric block cipher MAC modes                   |
| +TPM_ALG_NULL    |                                                        |
| \#TPM_RC_MODE    |                                                        |

## TPMI_ALG_KDF (Key and Mask Generation Functions)

A TPMI_ALG_KDF is an interface type of all the key derivation functions
implemented on a specific TPM.<span id="_Ref307235867"
class="anchor"></span>

Table 71 — Definition of (TPM_ALG_ID) TPMI_ALG_KDF Type

| Values           | Comments                                                 |
|------------------|----------------------------------------------------------|
| TPM_ALG\_!ALG.HM | all defined hash-based key and mask generation functions |
| +TPM_ALG_NULL    |                                                          |
| \#TPM_RC_KDF     |                                                          |

## TPMI_ALG_SIG_SCHEME

This is the definition of the interface type for any signature
scheme.<span id="_Toc380749753" class="anchor"></span>

Table 72 — Definition of (TPM_ALG_ID) TPMI_ALG_SIG_SCHEME Type

| Values           | Comments                                                   |
|------------------|------------------------------------------------------------|
| TPM_ALG\_!ALG.ax | all asymmetric signing schemes including anonymous schemes |
| TPM_ALG_HMAC     | present on all TPM                                         |
| +TPM_ALG_NULL    |                                                            |
| \#TPM_RC_SCHEME  | response code when a signature scheme is not correct       |

## TPMI_ECC_KEY_EXCHANGE

This is the definition of the interface type for an ECC key exchange
scheme.

NOTE Because of the “{ECC}” in the table title, the only values in this
table will be those that are dependent on ECC being implemented, even if
they otherwise have the correct type attributes.

<span id="_Toc380749754" class="anchor"></span>Table 73 — Definition of
(TPM_ALG_ID){ECC} TPMI_ECC_KEY_EXCHANGE Type

| Values           | Comments                                                           |
|------------------|--------------------------------------------------------------------|
| TPM_ALG\_!ALG.AM | any ECC key exchange method                                        |
| TPM_ALG_SM2      | SM2 is typed as signing but may be used as a key-exchange protocol |
| +TPM_ALG_NULL    |                                                                    |
| \#TPM_RC_SCHEME  | response code when a key exchange scheme is not correct            |

## TPMI_ST_COMMAND_TAG

This interface type is used for the command tags.

The response code for a bad command tag has the same value as the TPM
1.2 response code (TPM_BAD_TAG). This value is used in case the software
is not compatible with this specification and an unexpected response
code might have unexpected side effects.

<span id="_Toc380749755" class="anchor"></span>Table 74 — Definition of
(TPM_ST) TPMI_ST_COMMAND_TAG Type

| Values             | Comments |
|--------------------|----------|
| TPM_ST_NO_SESSIONS |          |
| TPM_ST_SESSIONS    |          |
| \#TPM_RC_BAD_TAG   |          |

## TPMI_ALG_MAC_SCHEME

A TPMI_ALG_MAC_SCHEME is an interface type of all the TCG-defined
symmetric algorithms that may be used as companion symmetric! signing
algorithm.

<span id="_Toc516155187" class="anchor"></span>Table 75 — Definition of
(TPM_ALG_ID) TPMI_ALG_MAC_SCHEME Type

| Values             | Comments                                             |
|--------------------|------------------------------------------------------|
| TPM_ALG\_!ALG.SX   | all symmetric block cipher MAC algorithms            |
| TPM_ALG\_!ALG.H    | all hash algorithms defined by the TCG               |
| +TPM_ALG_NULL      | required to be present in all versions of this table |
| \#TPM_RC_SYMMETRIC |                                                      |

## TPMI_ALG_CIPHER_MODE

A TPMI_ALG_CIPHER_MODE is an interface type of all the symmetric block
cipher, encryption/decryption modes that are listed in the TCG algorithm
registry.

<span id="_Toc516155188" class="anchor"></span>Table 76 — Definition of
(TPM_ALG_ID) TPMI_ALG_CIPHER_MODE Type

| Values           | Comments                                             |
|------------------|------------------------------------------------------|
| TPM_ALG\_!ALG.SE | all symmetric block cipher algorithms                |
| +TPM_ALG_NULL    | required to be present in all versions of this table |
| \#TPM_RC_MODE    |                                                      |

# Structure Definitions

## TPMS_EMPTY

This structure is used as a placeholder. In some cases, a union will
have a selector value with no data to unmarshal when that type is
selected. Rather than leave the entry empty, TPMS_EMPTY may be selected.

NOTE The tool chain will special case this structure and create the
marshaling and unmarshaling code for this structure but not create a
type definition. The unmarshaling code for this structure will return
TPM_RC_SUCCESS and the marshaling code will return
0.<span id="_Toc380749756" class="anchor"></span>

Table 77 — Definition of TPMS_EMPTY Structure \<IN/OUT\>

|           |      |                            |
|-----------|------|----------------------------|
| Parameter | Type | Description                |
|           |      | a structure with no member |

## TPMS_ALGORITHM_DESCRIPTION

This structure is a return value for a TPM2_GetCapability() that reads
the installed algorithms.

<span id="_Toc380749757" class="anchor"></span>Table 78 — Definition of
TPMS_ALGORITHM_DESCRIPTION Structure \<OUT\>

|            |                |                                 |
|------------|----------------|---------------------------------|
| Parameter  | Type           | Description                     |
| alg        | TPM_ALG_ID     | an algorithm                    |
| attributes | TPMA_ALGORITHM | the attributes of the algorithm |

## Hash/Digest Structures

### TPMU_HA (Hash)

A TPMU_HA is a union of all the hash algorithms implemented on a TPM.

NOTE 1 The !ALG.H and !ALG.H values represent all algorithms defined in
the TCG registry as being type “H”.

NOTE 2 If processed by an automated tool, each entry of the table should
be qualified (with \#ifdef/#endif) so that if the hash algorithm is not
implemented on the TPM, the parameter associated with that hash is not
present. This will keep the union from being larger than the largest
digest of a hash implemented on that TPM.

<span id="_Toc384651420" class="anchor"></span>Table 79 — Definition of
TPMU_HA Union \<IN/OUT \>

|                               |      |                 |             |
|-------------------------------|------|-----------------|-------------|
| Parameter                     | Type | Selector        | Description |
| !ALG.H \[!ALG.H_DIGEST_SIZE\] | BYTE | TPM_ALG\_!ALG.H | all hashes  |
| null                          |      | TPM_ALG_NULL    |             |

### TPMT_HA

Table 80 shows the basic hash-agile structure used in this
specification. To handle hash agility, this structure uses the *hashAlg*
parameter to indicate the algorithm used to compute the digest and, by
implication, the size of the digest.

When transmitted, only the number of octets indicated by *hashAlg* is
sent.

NOTE In the reference code, when a TPMT_HA is allocated, the digest
field is large enough to support the largest hash algorithm in the
TPMU_HA union.

<span id="_Ref213995262" class="anchor"></span>Table 80 — Definition of
TPMT_HA Structure \<IN/OUT\>

<table>
<colgroup>
<col style="width: 17%" />
<col style="width: 27%" />
<col style="width: 54%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Parameter</td>
<td>Type</td>
<td>Description</td>
</tr>
<tr class="even">
<td>hashAlg</td>
<td>+TPMI_ALG_HASH</td>
<td><p>selector of the hash contained in the <em>digest</em> that
implies the size of the <em>digest</em></p>
<p>NOTE The leading “+” on the type indicates that this structure should
pass an indication to the unmarshaling function for TPMI_ALG_HASH so
that TPM_ALG_NULL will be allowed if a use of a TPMT_HA allows
TPM_ALG_NULL.</p></td>
</tr>
<tr class="odd">
<td>[hashAlg] digest</td>
<td>TPMU_HA</td>
<td>the digest data</td>
</tr>
</tbody>
</table>

## Sized Buffers

### Introduction

The “TPM2B\_” prefix is used for a structure that has a size field
followed by a data buffer with the indicated number of octets. The
*size* field is 16 bits.

When the type of the second parameter in a TPM2B\_ structure is BYTE,
the TPM shall unmarshal the indicated number of octets, which may be
zero.

When the type of the second parameter in the TPM2B\_ structure is not
BYTE, the value of the *size* field shall either be zero indicating that
no structure is to be unmarshaled; or it shall be identical to the
number of octets unmarshaled for the second parameter.

NOTE 1 If the TPM2B\_ defines a structure and not an array of octets,
then the structure is self-describing and the TPM will be able to
determine how many octets are in the structure when it is unmarshaled.
If that number of octets is not equal to the size parameter, then it is
an error.

NOTE 2 The reason that a structure may be put into a TPM2B\_ is that the
parts of the structure may be handled as separate opaque blocks by the
application/system software. Rather than require that all of the
structures in a command or response be marshaled or unmarshaled
sequentially, the size field allows the structure to be manipulated as
an opaque block. Placing a structure in a TPM2B\_ also makes it possible
to use parameter encryption on the structure.

If a TPM2B\_ is encrypted, the TPM will encrypt/decrypt the data field
of the TPM2B\_ but not the *size* parameter. The TPM will
encrypt/decrypt the number of octets indicated by the *size* field.

NOTE 3 In the reference implementation, a TPM2B type is defined that is
a 16-bit size field followed by a single byte of data. The TPM2B\_ is
then defined as a union that contains a TPM2B (union member ‘b’) and the
structure in the definition table (union member ‘t’). This union is used
for internally generated structures so that there is a way to define a
structure of the correct size (forced by the ‘t’ member) while giving a
way to pass the structure generically as a ‘b’. Most function calls use
the 't' member so that the compiler will generate a warning if there is
a type error (a TPM2B\_ of the wrong type). Having the type checked
helps avoid many issues with buffer overflow caused by a too small
buffer being passed to a function.

### TPM2B_DIGEST

This structure is used for a sized buffer that cannot be larger than the
largest digest produced by any hash algorithm implemented on the TPM.

As with all sized buffers, the size is checked to see if it is within
the prescribed range. If not, the response code is TPM_RC_SIZE.

NOTE For any structure, like the one below, that contains an implied
size check, it is implied that TPM_RC_SIZE is a possible response code
and the response code will not be listed in the table.

<span id="_Toc380749760" class="anchor"></span>Table 81 — Definition of
TPM2B_DIGEST Structure

|                                  |        |                                                     |
|----------------------------------|--------|-----------------------------------------------------|
| Parameter                        | Type   | Description                                         |
| size                             | UINT16 | size in octets of the *buffer* field; may be 0      |
| buffer\[size\]{:sizeof(TPMU_HA)} | BYTE   | the buffer area that can be no larger than a digest |

### TPM2B_DATA

This structure is used for a data buffer that is required to be no
larger than the size of the Name of an object.<span id="_Toc380749761"
class="anchor"></span>

Table 82 — Definition of TPM2B_DATA Structure

|                                  |        |                                                |
|----------------------------------|--------|------------------------------------------------|
| Parameter                        | Type   | Description                                    |
| size                             | UINT16 | size in octets of the *buffer* field; may be 0 |
| buffer\[size\]{:sizeof(TPMT_HA)} | BYTE   |                                                |

### TPM2B_NONCE

<span id="_Toc380749762" class="anchor"></span>Table 83 — Definition of
Types for TPM2B_NONCE

|              |             |                                                  |
|--------------|-------------|--------------------------------------------------|
| Type         | Name        | Description                                      |
| TPM2B_DIGEST | TPM2B_NONCE | size limited to the same as the digest structure |

### TPM2B_AUTH

This structure is used for an authorization value and limits an
*authValue* to being no larger than the largest digest produced by a
TPM. In order to ensure consistency within an object, the *authValue*
may be no larger than the size of the digest produced by the object’s
*nameAlg*. This ensures that any TPM that can load the object will be
able to handle the *authValue* of the object.

<span id="_Toc380749763" class="anchor"></span>Table 84 — Definition of
Types for TPM2B_AUTH

|              |            |                                                  |
|--------------|------------|--------------------------------------------------|
| Type         | Name       | Description                                      |
| TPM2B_DIGEST | TPM2B_AUTH | size limited to the same as the digest structure |

### TPM2B_OPERAND

This type is a sized buffer that can hold an operand for a comparison
with an NV Index location. The maximum size of the operand is
implementation dependent but a TPM is required to support an operand
size that is at least as big as the digest produced by any of the hash
algorithms implemented on the TPM.

<span id="_Toc380749764" class="anchor"></span>Table 85 — Definition of
Types for TPM2B_OPERAND

|              |               |                                                  |
|--------------|---------------|--------------------------------------------------|
| Type         | Name          | Description                                      |
| TPM2B_DIGEST | TPM2B_OPERAND | size limited to the same as the digest structure |

### TPM2B_EVENT

This type is a sized buffer that can hold event data.

<span id="_Toc380749765" class="anchor"></span>Table 86 — Definition of
TPM2B_EVENT Structure

|                         |        |                              |
|-------------------------|--------|------------------------------|
| Parameter               | Type   | Description                  |
| size                    | UINT16 | size of the operand *buffer* |
| buffer \[size\] {:1024} | BYTE   | the operand                  |

### TPM2B_MAX_BUFFER

This type is a sized buffer that can hold a maximally sized buffer for
commands that use a large data buffer such as TPM2_Hash(),
TPM2_SequenceUpdate(), or TPM2_FieldUpgradeData().

NOTE The above list is not comprehensive and other commands may use this
buffer type.

MAX_DIGEST_BUFFER is TPM-dependent but is required to be at least 1,024.

<span id="_Toc380749766" class="anchor"></span>Table 87 — Definition of
TPM2B_MAX_BUFFER Structure

|                                      |        |                    |
|--------------------------------------|--------|--------------------|
| Parameter                            | Type   | Description        |
| size                                 | UINT16 | size of the buffer |
| buffer \[size\] {:MAX_DIGEST_BUFFER} | BYTE   | the operand        |

### TPM2B_MAX_NV_BUFFER

This type is a sized buffer that can hold a maximally sized buffer for
NV data commands such as TPM2_NV_Read(), TPM2_NV_Write(), and
TPM2_NV_Certify().

<span id="_Toc380749767" class="anchor"></span>Table 88 — Definition of
TPM2B_MAX_NV_BUFFER Structure

<table style="width:100%;">
<colgroup>
<col style="width: 36%" />
<col style="width: 22%" />
<col style="width: 41%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Parameter</td>
<td>Type</td>
<td>Description</td>
</tr>
<tr class="even">
<td>size</td>
<td>UINT16</td>
<td>size of the buffer</td>
</tr>
<tr class="odd">
<td>buffer [size] {:MAX_NV_BUFFER_SIZE}</td>
<td>BYTE</td>
<td><p>the operand</p>
<p>NOTE MAX_NV_BUFFER_SIZE is TPM-dependent</p></td>
</tr>
</tbody>
</table>

### TPM2B_TIMEOUT

This TPM-dependent structure is used to provide the timeout value for an
authorization. The *size* shall be 8 or less.

<span id="_Toc432512576" class="anchor"></span>Table 89 — Definition of
TPM2B_TIMEOUT Structure

|                                 |        |                           |
|---------------------------------|--------|---------------------------|
| Type                            | Name   | Description               |
| size                            | UINT16 | size of the timeout value |
| buffer\[size\]{:sizeof(UINT64)} | BYTE   | the timeout value         |

NOTE In the reference implementation the MSb is used as a flag to
indicate whether a ticket expires on TPM Reset or TPM Restart.

### TPM2B_IV

This structure is used for passing an initial value for a symmetric
block cipher to or from the TPM. The size is set to be the largest block
size of any implemented symmetric cipher implemented on the TPM.

<span id="_Toc380749769" class="anchor"></span>Table 90 — Definition of
TPM2B_IV Structure \<IN/OUT\>

<table>
<colgroup>
<col style="width: 37%" />
<col style="width: 17%" />
<col style="width: 45%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Parameter</td>
<td>Type</td>
<td>Description</td>
</tr>
<tr class="even">
<td>size</td>
<td>UINT16</td>
<td><p>size of the IV value</p>
<p>This value is fixed for a TPM implementation.</p></td>
</tr>
<tr class="odd">
<td>buffer[size]{:MAX_SYM_BLOCK_SIZE}</td>
<td>BYTE</td>
<td>the IV value</td>
</tr>
</tbody>
</table>

## Names

### Introduction

The Name of an entity is used in place of the handle in authorization
computations. The substitution occurs in *cpHash* and *policyHash*
computations.

For an entity that is defined by a public area (objects and NV Indexes),
the Name is the hash of the public structure that defines the entity.
The hash is done using the *nameAlg* of the entity.

NOTE For an object, a TPMT_PUBLIC defines the entity. For an NV Index, a
TPMS_NV_PUBLIC defines the entity.

For entities not defined by a public area, the Name is the handle that
is used to refer to the entity.

### TPMU_NAME

<span id="_Toc380749770" class="anchor"></span>Table 91 — Definition of
TPMU_NAME Union \<\>

|           |            |          |                           |
|-----------|------------|----------|---------------------------|
| Parameter | Type       | Selector | Description               |
| digest    | TPMT_HA    |          | when the Name is a digest |
| handle    | TPM_HANDLE |          | when the Name is a handle |

### TPM2B_NAME

This buffer holds a Name for any entity type.

The type of Name in the structure is determined by context and the
*size* parameter. If *size* is four, then the Name is a handle. If
*size* is zero, then no Name is present. Otherwise, the size shall be
the size of a TPM_ALG_ID plus the size of the digest produced by the
indicated hash algorithm.

<span id="_Toc380749771" class="anchor"></span>Table 92 — Definition of
TPM2B_NAME Structure

|                                  |        |                            |
|----------------------------------|--------|----------------------------|
| Parameter                        | Type   | Description                |
| size                             | UINT16 | size of the Name structure |
| name\[size\]{:sizeof(TPMU_NAME)} | BYTE   | the Name structure         |

## PCR Structures

### TPMS_PCR_SELECT

This structure provides a standard method of specifying a list of PCR.

PCR numbering starts at zero.

*pcrSelect* is an array of octets. The octet containing the bit
corresponding to a specific PCR is found by dividing the PCR number by
8.

EXAMPLE 1 The bit in *pcrSelect* corresponding to PCR 19 is in
*pcrSelect* \[2\] (19/8 = 2).

The least significant bit in a octet is bit number 0. The bit in the
octet associated with a PCR is the remainder after division by 8.

EXAMPLE 2 The bit in *pcrSelect* \[2\] corresponding to PCR 19 is bit 3
(19 mod 8). If *sizeofSelect* is 3, then the *pcrSelect* array that
would specify PCR 19 and no other PCR is 00 00 08<sub>16</sub>.

Each bit in *pcrSelect* indicates whether the corresponding PCR is
selected (1) or not (0). If the *pcrSelect* is all zero bits, then no
PCR is selected.

*sizeofSelect* indicates the number of octets in *pcrSelect*. The
allowable value for *sizeofSelect* is determined by the number of PCR
required by the applicable platform-specific specification and the
number of PCR implemented in the TPM. The minimum value for
*sizeofSelect* is:

PCR_SELECT_MIN ≔ (PLATFORM_PCR + 7) / 8 1

where

PLATFORM_PCR the number of PCR required by the platform-specific
specification

The maximum value for sizeofSelect is:

PCR_SELECT_MAX ≔ (IMPLEMENTATION_PCR + 7) / 8 1

where

IMPLEMENTATION_PCR the number of PCR implemented on the TPM

If the TPM implements more PCR than there are bits in *pcrSelect*, the
additional PCR are not selected.

EXAMPLE 3 If the applicable platform-specific specification requires
that the TPM have a minimum of 24 PCR but the TPM implements 32, then a
PCR select of 3 octets would imply that PCR 24-31 are not selected.

<span id="_Toc380749772" class="anchor"></span>Table 93 — Definition of
TPMS_PCR_SELECT Structure

|                                              |       |                                             |
|----------------------------------------------|-------|---------------------------------------------|
| Parameter                                    | Type  | Description                                 |
| sizeofSelect {PCR_SELECT_MIN:}               | UINT8 | the size in octets of the *pcrSelect* array |
| pcrSelect \[sizeofSelect\] {:PCR_SELECT_MAX} | BYTE  | the bit map of selected PCR                 |
| \#TPM_RC_VALUE                               |       |                                             |

### TPMS_PCR_SELECTION

<span id="_Toc380749773" class="anchor"></span>Table 94 — Definition of
TPMS_PCR_SELECTION Structure

|                                              |               |                                                  |
|----------------------------------------------|---------------|--------------------------------------------------|
| Parameter                                    | Type          | Description                                      |
| hash                                         | TPMI_ALG_HASH | the hash algorithm associated with the selection |
| sizeofSelect {PCR_SELECT_MIN:}               | UINT8         | the size in octets of the *pcrSelect* array      |
| pcrSelect \[sizeofSelect\] {:PCR_SELECT_MAX} | BYTE          | the bit map of selected PCR                      |
| \#TPM_RC_VALUE                               |               |                                                  |

## Tickets

### Introduction

Tickets are evidence that the TPM has previously processed some
information. A ticket is an HMAC over the data using a secret key known
only to the TPM. A ticket is a way to expand the state memory of the
TPM. A ticket is only usable by the TPM that produced it.

The formulations for tickets shown in 10.7 are to be used by a TPM that
is compliant with this specification.

The method of creating the ticket data is:

**HMAC**<sub>contexAlg</sub>(proof, (ticketType \|\| param { \|\| param
{…})) 1

where

**HMAC**<sub>contexAlg</sub>() an HMAC using the hash used for context
integrity

proof a TPM secret value (depends on hierarchy)

ticketType a value to differentiate the tickets

param one or more values that were checked by the TPM

The proof value used for each hierarchy is shown in Table 95.

<span id="_Ref294969840" class="anchor"></span>Table 95 — Values for
*proof* Used in Tickets

|             |           |                                                                |
|-------------|-----------|----------------------------------------------------------------|
| Hierarchy   | proof     | Description                                                    |
| Null        | nullProof | a value that changes with every TPM Reset                      |
| Platform    | phProof   | a value that changes with each change of the PPS               |
| Owner       | shProof   | a value that changes with each change of the SPS               |
| Endorsement | ehProof   | a value that changes with each change of either the EPS or SPS |

The format for a ticket is shown in Table 96. This is a template for the
tickets shown in the remainder of this clause 10.7.

<span id="_Ref294969896" class="anchor"></span>Table 96 — General Format
of a Ticket

|           |                    |                                                 |
|-----------|--------------------|-------------------------------------------------|
| Parameter | Type               | Description                                     |
| tag       | TPM_ST             | structure tag indicating the type of the ticket |
| hierarchy | TPMI_RH_HIERARCHY+ | the hierarchy of the proof value                |
| digest    | TPM2B_DIGEST       | the HMAC over the ticket-specific data          |

### A NULL Ticket

When a command requires a ticket and no ticket is available, the caller
is required to provide a structure with a ticket *tag* that is correct
for the context. The *hierarchy* shall be set to TPM_RH_NULL, and
*digest* shall be the Empty Buffer (a buffer with a size field of zero).
This construct is the NULL Ticket. When a response indicates that a
ticket is returned, the TPM may return a NULL Ticket.

NOTE Because each use of a ticket requires that the structure tag for
the ticket be appropriate for the use, there is no single representation
of a NULL Ticket that will work in all circumstances. Minimally, a NULL
ticket will have a structure type that is appropriate for the context.

### TPMT_TK_CREATION

This ticket is produced by TPM2_Create() or TPM2_CreatePrimary(). It is
used to bind the creation data to the object to which it applies. The
ticket is computed by

**HMAC**<sub>contextAlg</sub>(proof, (TPM_ST_CREATION \|\| name \|\|
**H**<sub>nameAlg</sub>(TPMS_CREATION_DATA))) 1

where

**HMAC**<sub>contextAlg</sub>() an HMAC using the context integrity hash
algorithm

proof a TPM secret value associated with the hierarchy associated with
name

TPM_ST_CREATION a value used to ensure that the ticket is properly used

name the Name of the object to which the creation data is to be
associated

**H**<sub>nameAlg</sub>() hash using the nameAlg of the created object

TPMS_CREATION_DATA the creation data structure associated with name

<span id="_Toc380749776" class="anchor"></span>Table 97 — Definition of
TPMT_TK_CREATION Structure

|                       |                    |                                                                     |
|-----------------------|--------------------|---------------------------------------------------------------------|
| Parameter             | Type               | Description                                                         |
| tag {TPM_ST_CREATION} | TPM_ST             | ticket structure tag                                                |
| \#TPM_RC_TAG          |                    | error returned when *tag* is not TPM_ST_CREATION                    |
| hierarchy             | TPMI_RH_HIERARCHY+ | the hierarchy containing *name*                                     |
| digest                | TPM2B_DIGEST       | This shall be the HMAC produced using a proof value of *hierarchy*. |

EXAMPLE A NULL Creation Ticket is the tuple \<TPM_ST_CREATION,
TPM_RH_NULL, 0x0000\>.

### TPMT_TK_VERIFIED

This ticket is produced by TPM2_VerifySignature(). This formulation is
used for multiple ticket uses. The ticket provides evidence that the TPM
has validated that a digest was signed by a key with the Name of
keyName. The ticket is computed by

**HMAC**<sub>contextAlg</sub>(proof, (TPM_ST_VERIFIED \|\| digest \|\|
keyName)) 1

where

**HMAC**<sub>contextAlg</sub>() an HMAC using the context integrity hash

proof a TPM secret value associated with the hierarchy associated with
keyName

TPM_ST_VERIFIED a value used to ensure that the ticket is properly used

digest the signed digest

keyName Name of the key that signed digest

<span id="_Toc380749777" class="anchor"></span>Table 98 — Definition of
TPMT_TK_VERIFIED Structure

|                       |                    |                                                                     |
|-----------------------|--------------------|---------------------------------------------------------------------|
| Parameter             | Type               | Description                                                         |
| tag {TPM_ST_VERIFIED} | TPM_ST             | ticket structure tag                                                |
| \#TPM_RC_TAG          |                    | error returned when *tag* is not TPM_ST_VERIFIED                    |
| hierarchy             | TPMI_RH_HIERARCHY+ | the hierarchy containing *keyName*                                  |
| digest                | TPM2B_DIGEST       | This shall be the HMAC produced using a proof value of *hierarchy*. |

EXAMPLE A NULL Verified Ticket is the tuple \<TPM_ST_VERIFIED,
TPM_RH_NULL, 0x0000\>.

### TPMT_TK_AUTH

This ticket is produced by TPM2_PolicySigned() and TPM2_PolicySecret()
when the authorization has an expiration time. If *nonceTPM* was
provided in the policy command, t*he* ticket is computed by

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

> NOTE 1 Not included if *timeout* is zero.

resetCount implementation-specific representation of the TPM’s
totalResetCount

> NOTE 2 Not included it *timeout* is zero or if *nonceTPM* was include
> in the authorization.

<span id="_Toc470518166" class="anchor"></span>Table 99 — Definition of
TPMT_TK_AUTH Structure

|                                              |                    |                                                                     |
|----------------------------------------------|--------------------|---------------------------------------------------------------------|
| Parameter                                    | Type               | Description                                                         |
| tag {TPM_ST_AUTH_SIGNED, TPM_ST_AUTH_SECRET} | TPM_ST             | ticket structure tag                                                |
| \#TPM_RC_TAG                                 |                    | error returned when *tag* is not TPM_ST_AUTH                        |
| hierarchy                                    | TPMI_RH_HIERARCHY+ | the hierarchy of the object used to produce the ticket              |
| digest                                       | TPM2B_DIGEST       | This shall be the HMAC produced using a proof value of *hierarchy*. |

EXAMPLE A NULL Auth Ticket is the tuple \<TPM_ST_AUTH_SIGNED,
TPM_RH_NULL, 0x0000\> or the tuple \<TPM_ST_AUTH_SIGNED, TPM_RH_NULL,
0x0000\>

### TPMT_TK_HASHCHECK

This ticket is produced by TPM2_SequenceComplete() or TPM2_Hash() when
the message that was digested did not start with TPM_GENERATED_VALUE.
The ticket is computed by

**HMAC**<sub>contexAlg</sub>(proof, (TPM_ST_HASHCHECK \|\| digest)) 1

where

**HMAC**<sub>contexAlg</sub> () an HMAC using the context integrity hash

proof a TPM secret value associated with the hierarchy indicated by the
command

TPM_ST_HASHCHECK a value used to ensure that the ticket is properly used

digest the digest of the data

<span id="_Toc380749779" class="anchor"></span>Table 100 — Definition of
TPMT_TK_HASHCHECK Structure

|                        |                    |                                                                     |
|------------------------|--------------------|---------------------------------------------------------------------|
| Parameter              | Type               | Description                                                         |
| tag {TPM_ST_HASHCHECK} | TPM_ST             | ticket structure tag                                                |
| \#TPM_RC_TAG           |                    | error returned when is not TPM_ST_HASHCHECK                         |
| hierarchy              | TPMI_RH_HIERARCHY+ | the hierarchy                                                       |
| digest                 | TPM2B_DIGEST       | This shall be the HMAC produced using a proof value of *hierarchy*. |

## Property Structures

### TPMS_ALG_PROPERTY

This structure is used to report the properties of an algorithm
identifier. It is returned in response to a TPM2_GetCapability() with
*capability* = TPM_CAP_ALG.

<span id="_Toc380749780" class="anchor"></span>Table 101 — Definition of
TPMS_ALG_PROPERTY Structure \<OUT\>

|               |                |                                 |
|---------------|----------------|---------------------------------|
| Parameter     | Type           | Description                     |
| alg           | TPM_ALG_ID     | an algorithm identifier         |
| algProperties | TPMA_ALGORITHM | the attributes of the algorithm |

### TPMS_TAGGED_PROPERTY

This structure is used to report the properties that are UINT32 values.
It is returned in response to a TPM2_GetCapability().

<span id="_Toc380749781" class="anchor"></span>Table 102 — Definition of
TPMS_TAGGED_PROPERTY Structure \<OUT\>

|           |        |                           |
|-----------|--------|---------------------------|
| Parameter | Type   | Description               |
| property  | TPM_PT | a property identifier     |
| value     | UINT32 | the value of the property |

### TPMS_TAGGED_PCR_SELECT

This structure is used in TPM2_GetCapability() to return the attributes
of the PCR.

<span id="_Toc380749782" class="anchor"></span>Table 103 — Definition of
TPMS_TAGGED_PCR_SELECT Structure \<OUT\>

|                                              |            |                                                 |
|----------------------------------------------|------------|-------------------------------------------------|
| Parameter                                    | Type       | Description                                     |
| tag                                          | TPM_PT_PCR | the property identifier                         |
| sizeofSelect {PCR_SELECT_MIN:}               | UINT8      | the size in octets of the *pcrSelect* array     |
| pcrSelect \[sizeofSelect\] {:PCR_SELECT_MAX} | BYTE       | the bit map of PCR with the identified property |

### TPMS_TAGGED_POLICY

This structure is used in TPM2_GetCapability() to return the policy
associated with a permanent handle.

<span id="_Toc450655450" class="anchor"></span>Table 104 — Definition of
TPMS_TAGGED_POLICY Structure \<OUT\>

|            |            |                               |
|------------|------------|-------------------------------|
| Parameter  | Type       | Description                   |
| handle     | TPM_HANDLE | a permanent handle            |
| policyHash | TPMT_HA    | the policy algorithm and hash |

### TPMS_ACT_DATA

This structure is used in TPM2_GetCapability() to return the ACT data.

<span id="_Toc536540074" class="anchor"></span>Table 105 — Definition of
TPMS_ACT_DATA Structure \<OUT\>

|            |            |                                |
|------------|------------|--------------------------------|
| Parameter  | Type       | Description                    |
| handle     | TPM_HANDLE | a permanent handle             |
| timeout    | UINT32     | the current timeout of the ACT |
| attributes | TPMA_ACT   | the state of the ACT           |

## Lists

### TPML_CC

A list of command codes may be input to the TPM or returned by the TPM
depending on the command.

<span id="_Toc380749783" class="anchor"></span>Table 106 — Definition of
TPML_CC Structure

<table>
<colgroup>
<col style="width: 42%" />
<col style="width: 13%" />
<col style="width: 44%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Parameter</td>
<td>Type</td>
<td>Description</td>
</tr>
<tr class="even">
<td>count</td>
<td>UINT32</td>
<td>number of commands in the <em>commandCode</em> list; may be 0</td>
</tr>
<tr class="odd">
<td>commandCodes[count]{:MAX_CAP_CC}</td>
<td>TPM_CC</td>
<td><p>a list of command codes</p>
<p>The maximum only applies to a command code list in a command. The
response size is limited only by the size of the parameter
buffer.</p></td>
</tr>
<tr class="even">
<td>#TPM_RC_SIZE</td>
<td></td>
<td>response code when count is greater than the maximum allowed list
size</td>
</tr>
</tbody>
</table>

### TPML_CCA

This list is only used in TPM2_GetCapability(capability =
TPM_CAP_COMMANDS).

The values in the list are returned in TPMA_CC-\>*commandIndex* order
(see Table 37) with vendor-specific commands returned after other
commands. Because of the other attributes, the commands may not be
returned in strict numerical order.<span id="_Toc380749784"
class="anchor"></span>

Table 107 — Definition of TPML_CCA Structure \<OUT\>

|                                         |         |                                                            |
|-----------------------------------------|---------|------------------------------------------------------------|
| Parameter                               | Type    | Description                                                |
| count                                   | UINT32  | number of values in the *commandAttributes* list; may be 0 |
| commandAttributes\[count\]{:MAX_CAP_CC} | TPMA_CC | a list of command codes attributes                         |

### TPML_ALG

This list is returned by TPM2_IncrementalSelfTest().

<span id="_Toc380749785" class="anchor"></span>Table 108 — Definition of
TPML_ALG Structure

<table>
<colgroup>
<col style="width: 40%" />
<col style="width: 13%" />
<col style="width: 46%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Parameter</td>
<td>Type</td>
<td>Description</td>
</tr>
<tr class="even">
<td>count</td>
<td>UINT32</td>
<td>number of algorithms in the <em>algorithms</em> list; may be 0</td>
</tr>
<tr class="odd">
<td>algorithms[count]{:MAX_ALG_LIST_SIZE}</td>
<td>TPM_ALG_ID</td>
<td><p>a list of algorithm IDs</p>
<p>The maximum only applies to an algorithm list in a command. The
response size is limited only by the size of the parameter
buffer.</p></td>
</tr>
<tr class="even">
<td>#TPM_RC_SIZE</td>
<td></td>
<td>response code when <em>count</em> is greater than the maximum
allowed list size</td>
</tr>
</tbody>
</table>

### TPML_HANDLE

This structure is used when the TPM returns a list of loaded handles
when the *capability* in TPM2_GetCapability() is TPM_CAP_HANDLE.

NOTE 1 MAX_CAP_HANDLES = (MAX_CAP_DATA / sizeof(TPM_HANDLE))

NOTE 2 This list is not used as input to the TPM.

<span id="_Toc380749786" class="anchor"></span>Table 109 — Definition of
TPML_HANDLE Structure \<OUT\>

<table>
<colgroup>
<col style="width: 36%" />
<col style="width: 16%" />
<col style="width: 46%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Name</td>
<td>Type</td>
<td>Description</td>
</tr>
<tr class="even">
<td>count</td>
<td>UINT32</td>
<td><p>the number of handles in the list</p>
<p>may have a value of 0</p></td>
</tr>
<tr class="odd">
<td>handle[count]{: MAX_CAP_HANDLES}</td>
<td>TPM_HANDLE</td>
<td>an array of handles</td>
</tr>
<tr class="even">
<td>#TPM_RC_SIZE</td>
<td></td>
<td>response code when <em>count</em> is greater than the maximum
allowed list size</td>
</tr>
</tbody>
</table>

### TPML_DIGEST

This list is used to convey a list of digest values. This type is used
in TPM2_PolicyOR() and in TPM2_PCR_Read().

<span id="_Toc380749787" class="anchor"></span>Table 110 — Definition of
TPML_DIGEST Structure

<table>
<colgroup>
<col style="width: 35%" />
<col style="width: 16%" />
<col style="width: 48%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Parameter</td>
<td>Type</td>
<td>Description</td>
</tr>
<tr class="even">
<td>count {2:}</td>
<td>UINT32</td>
<td>number of digests in the list, minimum is two for
TPM2_PolicyOR().</td>
</tr>
<tr class="odd">
<td>digests[count]{:8}</td>
<td>TPM2B_DIGEST</td>
<td><p>a list of digests</p>
<p>For TPM2_PolicyOR(), all digests will have been computed using the
digest of the policy session. For TPM2_PCR_Read(), each digest will be
the size of the digest for the bank containing the PCR.</p></td>
</tr>
<tr class="even">
<td>#TPM_RC_SIZE</td>
<td></td>
<td>response code when <em>count</em> is not at least two or is greater
than eight</td>
</tr>
</tbody>
</table>

### TPML_DIGEST_VALUES

This list is used to convey a list of digest values. This type is
returned by TPM2_PCR_Event() and TPM2_EventSequenceComplete() and is an
input for TPM2_PCR_Extend().

NOTE 1 This construct limits the number of hashes in the list to the
number of digests implemented in the TPM rather than the number of PCR
banks. This allows extra values to appear in a call to
TPM2_PCR_Extend().

NOTE 2 The digest for an unimplemented hash algorithm may not be in a
list because the TPM may not recognize the algorithm as being a hash and
it may not know the digest size.

<span id="_Toc380749788" class="anchor"></span>Table 111 — Definition of
TPML_DIGEST_VALUES Structure

|                               |         |                                                                         |
|-------------------------------|---------|-------------------------------------------------------------------------|
| Parameter                     | Type    | Description                                                             |
| count                         | UINT32  | number of digests in the list                                           |
| digests\[count\]{:HASH_COUNT} | TPMT_HA | a list of tagged digests                                                |
| \#TPM_RC_SIZE                 |         | response code when *count* is greater than the possible number of banks |

### TPML_PCR_SELECTION

This list is used to indicate the PCR that are included in a selection
when more than one PCR value may be selected.

This structure is an input parameter to TPM2_PolicyPCR() to indicate the
PCR that will be included in the digest of PCR for the authorization.
The structure is used in TPM2_PCR_Read() command to indicate the PCR
values to be returned and in the response to indicate which PCR are
included in the list of returned digests. The structure is an output
parameter from TPM2_Create() and indicates the PCR used in the digest of
the PCR state when the object was created. The structure is also
contained in the attestation structure of TPM2_Quote().

When this structure is used to select PCR to be included in a digest,
the selected PCR are concatenated to create a “message” containing all
of the PCR, and then the message is hashed using the context-specific
hash algorithm.

<span id="_Toc380749790" class="anchor"></span>Table 112 — Definition of
TPML_PCR_SELECTION Structure

<table>
<colgroup>
<col style="width: 38%" />
<col style="width: 25%" />
<col style="width: 36%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Parameter</td>
<td>Type</td>
<td>Description</td>
</tr>
<tr class="even">
<td>count</td>
<td>UINT32</td>
<td><p>number of selection structures</p>
<p>A value of zero is allowed.</p></td>
</tr>
<tr class="odd">
<td>pcrSelections[count]{:HASH_COUNT}</td>
<td>TPMS_PCR_SELECTION</td>
<td>list of selections</td>
</tr>
<tr class="even">
<td>#TPM_RC_SIZE</td>
<td></td>
<td>response code when <em>count</em> is greater than the possible
number of banks</td>
</tr>
</tbody>
</table>

### TPML_ALG_PROPERTY

This list is used to report on a list of algorithm attributes. It is
returned in a TPM2_GetCapability().

NOTE MAX_CAP_ALGS = MAX_CAP_DATA / sizeof(TPMS_ALG_PROPERTY).

<span id="_Toc380749791" class="anchor"></span>Table 113 — Definition of
TPML_ALG_PROPERTY Structure \<OUT\>

<table>
<colgroup>
<col style="width: 38%" />
<col style="width: 25%" />
<col style="width: 36%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Parameter</td>
<td>Type</td>
<td>Description</td>
</tr>
<tr class="even">
<td>count</td>
<td>UINT32</td>
<td><p>number of algorithm properties structures</p>
<p>A value of zero is allowed.</p></td>
</tr>
<tr class="odd">
<td>algProperties[count]{:MAX_CAP_ALGS}</td>
<td>TPMS_ALG_PROPERTY</td>
<td>list of properties</td>
</tr>
</tbody>
</table>

### TPML_TAGGED_TPM_PROPERTY

This list is used to report on a list of properties that are
TPMS_TAGGED_PROPERTY values. It is returned by a TPM2_GetCapability().

NOTE MAX_TPM_PROPERTIES = MAX_CAP_DATA / sizeof(TPMS_TAGGED_PROPERTY).

<span id="_Toc380749792" class="anchor"></span>Table 114 — Definition of
TPML_TAGGED_TPM_PROPERTY Structure \<OUT\>

<table>
<colgroup>
<col style="width: 42%" />
<col style="width: 29%" />
<col style="width: 27%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Parameter</td>
<td>Type</td>
<td>Description</td>
</tr>
<tr class="even">
<td>count</td>
<td>UINT32</td>
<td><p>number of properties</p>
<p>A value of zero is allowed.</p></td>
</tr>
<tr class="odd">
<td>tpmProperty[count]{:MAX_TPM_PROPERTIES}</td>
<td>TPMS_TAGGED_PROPERTY</td>
<td>an array of tagged properties</td>
</tr>
</tbody>
</table>

### TPML_TAGGED_PCR_PROPERTY

This list is used to report on a list of properties that are
TPMS_PCR_SELECT values. It is returned by a TPM2_GetCapability().

NOTE MAX_PCR_PROPERTIES = MAX_CAP_DATA / sizeof(TPMS_TAGGED_PCR_SELECT).

<span id="_Toc380749793" class="anchor"></span>Table 115 — Definition of
TPML_TAGGED_PCR_PROPERTY Structure \<OUT\>

<table>
<colgroup>
<col style="width: 42%" />
<col style="width: 29%" />
<col style="width: 27%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Parameter</td>
<td>Type</td>
<td>Description</td>
</tr>
<tr class="even">
<td>count</td>
<td>UINT32</td>
<td><p>number of properties</p>
<p>A value of zero is allowed.</p></td>
</tr>
<tr class="odd">
<td>pcrProperty[count]{:MAX_PCR_PROPERTIES}</td>
<td>TPMS_TAGGED_PCR_SELECT</td>
<td>a tagged PCR selection</td>
</tr>
</tbody>
</table>

### TPML_ECC_CURVE

This list is used to report the ECC curve ID values supported by the
TPM. It is returned by a TPM2_GetCapability().

NOTE MAX_ECC_CURVES = MAX_CAP_DATA / sizeof(TPM_ECC_CURVE).

<span id="_Toc380749794" class="anchor"></span>Table 116 — Definition of
{ECC} TPML_ECC_CURVE Structure \<OUT\>

<table>
<colgroup>
<col style="width: 42%" />
<col style="width: 24%" />
<col style="width: 33%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Parameter</td>
<td>Type</td>
<td>Description</td>
</tr>
<tr class="even">
<td>count</td>
<td>UINT32</td>
<td><p>number of curves</p>
<p>A value of zero is allowed.</p></td>
</tr>
<tr class="odd">
<td>eccCurves[count]{:MAX_ECC_CURVES}</td>
<td>TPM_ECC_CURVE</td>
<td>array of ECC curve identifiers</td>
</tr>
</tbody>
</table>

### TPML_TAGGED_POLICY

This list is used to report the authorization policy values for
permanent handles. This is list may be generated by
TPM2_GetCapabiltiy(). A permanent handle that cannot have a policy is
not included in the list.

NOTE MAX_TAGGED_POLICIES = MAX_CAP_DATA / sizeof(TPMS_TAGGED_POLICY).

<span id="_Toc451196367" class="anchor"></span>Table 117 — Definition of
TPML_TAGGED_POLICY Structure \<OUT\>

<table>
<colgroup>
<col style="width: 42%" />
<col style="width: 24%" />
<col style="width: 33%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Parameter</td>
<td>Type</td>
<td>Description</td>
</tr>
<tr class="even">
<td>count</td>
<td>UINT32</td>
<td><p>number of tagged policies</p>
<p>A value of zero is allowed.</p></td>
</tr>
<tr class="odd">
<td>policies[count]{:MAX_TAGGED_POLICIES}</td>
<td>TPMS_TAGGED_POLICY</td>
<td>array of tagged policies</td>
</tr>
</tbody>
</table>

### TPML_ACT_DATA

This list is used to report the timeout and state for the ACT. This list
may be generated by TPM2_GetCapabilty(). Only implemented ACT are
present in the list

NOTE MAX_ACT_DATA = MAX_CAP_DATA / sizeof(TPMS_ACT_DATA).

<span id="_Toc536540086" class="anchor"></span>Table 118 — Definition of
TPML_ACT_DATA Structure \<OUT\>

<table>
<colgroup>
<col style="width: 42%" />
<col style="width: 24%" />
<col style="width: 33%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Parameter</td>
<td>Type</td>
<td>Description</td>
</tr>
<tr class="even">
<td>count</td>
<td>UINT32</td>
<td><p>number of ACT instances</p>
<p>A value of zero is allowed.</p></td>
</tr>
<tr class="odd">
<td>actData[count]{:MAX_ACT_DATA}</td>
<td>TPMS_ACT_DATA</td>
<td>array of ACT data</td>
</tr>
</tbody>
</table>

## Capabilities Structures

It is required that each parameter in this union be a list (TPML).

The number of returned elements in each list is determined by the size
of each list element and the maximum size set by the vendor as the
capability buffer (MAX_CAP_BUFFER in TPM_PT_MAX_CAP_BUFFER). The maximum
number of bytes in a list is:

MAX_CAP_DATA = (MAX_CAP_BUFFER – sizeof(TPM_CAP) – sizeof(UINT32) 1

The maximum number of entries is then the number of complete list
elements that will fit in MAX_CAP_DATA.

EXAMPLE For a 1024-octet MAX_CAP_BUFFER a response containing a
TPML_HANDLE could have (1024 - 4 – 4) / 4 = 254
handles.<span id="_Toc286047089" class="anchor"></span>

### TPMU_CAPABILITIES

<span id="_Toc380749795" class="anchor"></span>Table 119 — Definition of
TPMU_CAPABILITIES Union \<OUT\>

|               |                          |                        |             |
|---------------|--------------------------|------------------------|-------------|
| Parameter     | Type                     | Selector               | Description |
| algorithms    | TPML_ALG_PROPERTY        | TPM_CAP_ALGS           |             |
| handles       | TPML_HANDLE              | TPM_CAP_HANDLES        |             |
| command       | TPML_CCA                 | TPM_CAP_COMMANDS       |             |
| ppCommands    | TPML_CC                  | TPM_CAP_PP_COMMANDS    |             |
| auditCommands | TPML_CC                  | TPM_CAP_AUDIT_COMMANDS |             |
| assignedPCR   | TPML_PCR_SELECTION       | TPM_CAP_PCRS           |             |
| tpmProperties | TPML_TAGGED_TPM_PROPERTY | TPM_CAP_TPM_PROPERTIES |             |
| pcrProperties | TPML_TAGGED_PCR_PROPERTY | TPM_CAP_PCR_PROPERTIES |             |
| eccCurves     | TPML_ECC_CURVE           | TPM_CAP_ECC_CURVES     | TPM_ALG_ECC |
| authPolicies  | TPML_TAGGED_POLICY       | TPM_CAP_AUTH_POLICIES  |             |
| actData       | TPML_ACT_DATA            | TPM_CAP_ACT            |             |

### TPMS_CAPABILITY_DATA

This data area is returned in response to a TPM2_GetCapability().

<span id="_Toc380749796" class="anchor"></span>Table 120 — Definition of
TPMS_CAPABILITY_DATA Structure \<OUT\>

|                    |                   |                     |
|--------------------|-------------------|---------------------|
| Parameter          | Type              | Description         |
| capability         | TPM_CAP           | the capability      |
| \[capability\]data | TPMU_CAPABILITIES | the capability data |

## Clock/Counter Structures

### TPMS_CLOCK_INFO

This structure is used in each of the attestation commands.

<span id="_Toc380749797" class="anchor"></span>Table 121 — Definition of
TPMS_CLOCK_INFO Structure

<table>
<colgroup>
<col style="width: 22%" />
<col style="width: 19%" />
<col style="width: 58%" />
</colgroup>
<thead>
<tr class="header">
<th>Parameter</th>
<th>Type</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>clock</td>
<td>UINT64</td>
<td><p>time value in milliseconds that advances while the TPM is
powered</p>
<p>NOTE The interpretation of the time-origin (<em>clock</em>=0) is out
of the scope of this specification, although Coordinated Universal Time
(UTC) is expected to be a common convention. This structure element is
used to report on the TPM's Clock value.</p>
<p>This value is reset to zero when the Storage Primary Seed is changed
(TPM2_Clear()).</p>
<p>This value may be advanced by TPM2_ClockSet().</p></td>
</tr>
<tr class="even">
<td>resetCount</td>
<td>UINT32</td>
<td>number of occurrences of TPM Reset since the last TPM2_Clear()</td>
</tr>
<tr class="odd">
<td>restartCount</td>
<td>UINT32</td>
<td>number of times that TPM2_Shutdown() or _TPM_Hash_Start have
occurred since the last TPM Reset or TPM2_Clear().</td>
</tr>
<tr class="even">
<td>safe</td>
<td>TPMI_YES_NO</td>
<td>no value of <em>Clock</em> greater than the current value of
<em>Clock</em> has been previously reported by the TPM. Set to YES on
TPM2_Clear().</td>
</tr>
</tbody>
</table>

### *Clock*

*Clock* is a monotonically increasing counter that advances whenever
power is applied to the TPM. The value of *Clock* may be set forward
with TPM2_ClockSet() if Owner Authorization or Platform Authorization is
provided. The value of *Clock* is incremented each millisecond.

TPM2_Clear() will set *Clock* to zero.

*Clock* will be non-volatile but may have a volatile component that is
updated every millisecond with the non-volatile component updated at a
lower rate. The reference for the millisecond timer is the TPM
oscillator. If the implementation uses a volatile component, the
non-volatile component shall be updated no less frequently than every
2<sup>22</sup> milliseconds (~69.9 minutes). The update rate of the
non-volatile portion of *Clock* shall be reported by a
TPM2_GetCapability() with *capability* = TPM_CAP_TPM_PROPERTIES and
*property* = TPM_PT_CLOCK_UPDATE.

### *ResetCount*

This counter shall increment on each TPM Reset. This counter shall be
reset to zero by TPM2_Clear().

### *RestartCount*

This counter shall increment by one for each TPM Restart or TPM Resume.
The *restartCount* shall be reset to zero on a TPM Reset or
TPM2_Clear().

### *Safe*

This parameter is set to YES when the value reported in *Clock* is
guaranteed to be greater than any previous value for the current Owner.
It is set to NO when the value of *Clock* may have been reported in a
previous attestation or access.

EXAMPLE 1 If *Safe* was NO at TPM2_Shutdown() and *Clock* does not
update unless a command is received, *Safe* will be NO if a
TPM2_Startup() was preceded by TPM2_Shutdown() with no intervening
commands. If *Clock* updates independent of commands, the non-volatile
bits of *Clock* can be updated, so *Safe* can be YES at TPM2_Startup().

EXAMPLE 2 This parameter will be YES after the non-volatile bits of
*Clock* have been updated at the end of an update interval.

If a TPM implementation does not implement *Clock*, *Safe* shall always
be NO and TPMS_CLOCK_INFO.*clock* shall always be zero.

This parameter will be set to YES by TPM2_Clear().

### TPMS_TIME_INFO

This structure is used in, e.g., the TPM2_GetTime() attestation and
TPM2_ReadClock().

The *Time* value reported in this structure is reset whenever power to
the *Time* circuit is reestablished. If required, an implementation may
reset the value of *Time* any time before the TPM returns after
TPM2_Startup(). The value of *Time* shall increment continuously while
power is applied to the TPM.

<span id="_Toc380749798" class="anchor"></span>Table 122 — Definition of
TPMS_TIME_INFO Structure

<table>
<colgroup>
<col style="width: 18%" />
<col style="width: 23%" />
<col style="width: 58%" />
</colgroup>
<thead>
<tr class="header">
<th>Parameter</th>
<th>Type</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>time</td>
<td>UINT64</td>
<td><p>time in milliseconds since the <em>TIme</em> circuit was last
reset</p>
<p>This structure element is used to report on the TPM's <em>Time</em>
value.</p></td>
</tr>
<tr class="even">
<td>clockInfo</td>
<td>TPMS_CLOCK_INFO</td>
<td>a structure containing the clock information</td>
</tr>
</tbody>
</table>

## TPM Attestation Structures

### Introduction

Clause 10.12 describes the structures that are used when a TPM creates a
structure to be signed. The signing structures follow a standard format
TPM2B_ATTEST with case-specific information embedded.

### TPMS_TIME_ATTEST_INFO

This structure is used when the TPM performs TPM2_GetTime.

<span id="_Toc380749799" class="anchor"></span>Table 123 — Definition of
TPMS_TIME_ATTEST_INFO Structure \<OUT\>

|                 |                |                                                                           |
|-----------------|----------------|---------------------------------------------------------------------------|
| Parameter       | Type           | Description                                                               |
| time            | TPMS_TIME_INFO | the *Time*, *Clock*, *resetCount*, *restartCount*, and *Safe* indicator   |
| firmwareVersion | UINT64         | a TPM vendor-specific value indicating the version number of the firmware |

### TPMS_CERTIFY_INFO

This is the attested data for TPM2_Certify().

<span id="_Toc380749800" class="anchor"></span>Table 124 — Definition of
TPMS_CERTIFY_INFO Structure \<OUT\>

|               |            |                                        |
|---------------|------------|----------------------------------------|
| Parameter     | Type       | Description                            |
| name          | TPM2B_NAME | Name of the certified object           |
| qualifiedName | TPM2B_NAME | Qualified Name of the certified object |

### TPMS_QUOTE_INFO

This is the *attested* data for TPM2_Quote().

<span id="_Ref225426227" class="anchor"></span>Table 125 — Definition of
TPMS_QUOTE_INFO Structure \<OUT\>

| Parameter | Type               | Description                                                  |
|-----------|--------------------|--------------------------------------------------------------|
| pcrSelect | TPML_PCR_SELECTION | information on *algID*, PCR selected and digest              |
| pcrDigest | TPM2B_DIGEST       | digest of the selected PCR using the hash of the signing key |

### TPMS_COMMAND_AUDIT_INFO

This is the *attested* data for TPM2_GetCommandAuditDigest().

<span id="_Toc380749802" class="anchor"></span>Table 126 — Definition of
TPMS_COMMAND_AUDIT_INFO Structure \<OUT\>

|               |              |                                                             |
|---------------|--------------|-------------------------------------------------------------|
| Parameter     | Type         | Description                                                 |
| auditCounter  | UINT64       | the monotonic audit counter                                 |
| digestAlg     | TPM_ALG_ID   | hash algorithm used for the command audit                   |
| auditDigest   | TPM2B_DIGEST | the current value of the audit digest                       |
| commandDigest | TPM2B_DIGEST | digest of the command codes being audited using *digestAlg* |

### TPMS_SESSION_AUDIT_INFO

This is the *attested* data for TPM2_GetSessionAuditDigest().

<span id="_Toc380749803" class="anchor"></span>Table 127 — Definition of
TPMS_SESSION_AUDIT_INFO Structure \<OUT\>

<table>
<colgroup>
<col style="width: 18%" />
<col style="width: 25%" />
<col style="width: 56%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Parameter</td>
<td>Type</td>
<td>Description</td>
</tr>
<tr class="even">
<td>exclusiveSession</td>
<td>TPMI_YES_NO</td>
<td><p>current exclusive status of the session</p>
<p>TRUE if all of the commands recorded in the <em>sessionDigest</em>
were executed without any intervening TPM command that did not use this
audit session</p></td>
</tr>
<tr class="odd">
<td>sessionDigest</td>
<td>TPM2B_DIGEST</td>
<td>the current value of the session audit digest</td>
</tr>
</tbody>
</table>

### TPMS_CREATION_INFO

This is the *attested* data for TPM2_CertifyCreation().

<span id="_Toc380749804" class="anchor"></span>Table 128 — Definition of
TPMS_CREATION_INFO Structure \<OUT\>

|              |              |                    |
|--------------|--------------|--------------------|
| Parameter    | Type         | Description        |
| objectName   | TPM2B_NAME   | Name of the object |
| creationHash | TPM2B_DIGEST | creationHash       |

### TPMS_NV_CERTIFY_INFO

This structure contains the Name and contents of the selected NV Index
that is certified by TPM2_NV_Certify().

<span id="_Toc380749805" class="anchor"></span>Table 129 — Definition of
TPMS_NV_CERTIFY_INFO Structure \<OUT\>

|            |                     |                                             |
|------------|---------------------|---------------------------------------------|
| Parameter  | Type                | Description                                 |
| indexName  | TPM2B_NAME          | Name of the NV Index                        |
| offset     | UINT16              | the *offset* parameter of TPM2_NV_Certify() |
| nvContents | TPM2B_MAX_NV_BUFFER | contents of the NV Index                    |

### TPMS_NV_DIGEST_CERTIFY_INFO

This structure contains the Name and hash of the contents of the
selected NV Index that is certified by TPM2_NV_Certify(). The data is
hashed using hash of the signing scheme.

NOTE This structure was added in revision 01.53 to support alternate
TPM2_NV_Certify() behavior.

<span id="_Toc21376177" class="anchor"></span>Table 130 — Definition of
TPMS_NV_DIGEST_CERTIFY_INFO Structure \<OUT\>

|           |              |                                   |
|-----------|--------------|-----------------------------------|
| Parameter | Type         | Description                       |
| indexName | TPM2B_NAME   | Name of the NV Index              |
| nvDigest  | TPM2B_DIGEST | hash of the contents of the index |

### TPMI_ST_ATTEST

<span id="_Toc380749806" class="anchor"></span>Table 131 — Definition of
(TPM_ST) TPMI_ST_ATTEST Type \<OUT\>

| Value                       | Description                               |
|-----------------------------|-------------------------------------------|
| TPM_ST_ATTEST_CERTIFY       | generated by TPM2_Certify()               |
| TPM_ST_ATTEST_QUOTE         | generated by TPM2_Quote()                 |
| TPM_ST_ATTEST_SESSION_AUDIT | generated by TPM2_GetSessionAuditDigest() |
| TPM_ST_ATTEST_COMMAND_AUDIT | generated by TPM2_GetCommandAuditDigest() |
| TPM_ST_ATTEST_TIME          | generated by TPM2_GetTime()               |
| TPM_ST_ATTEST_CREATION      | generated by TPM2_CertifyCreation()       |
| TPM_ST_ATTEST_NV            | generated by TPM2_NV_Certify()            |
| TPM_ST_ATTEST_NV_DIGEST     | generated by TPM2_NV_Certify()            |

### TPMU_ATTEST

<span id="_Toc380749807" class="anchor"></span>Table 132 — Definition of
TPMU_ATTEST Union \<OUT\>

|              |                             |                             |
|--------------|-----------------------------|-----------------------------|
| Parameter    | Type                        | Selector                    |
| certify      | TPMS_CERTIFY_INFO           | TPM_ST_ATTEST_CERTIFY       |
| creation     | TPMS_CREATION_INFO          | TPM_ST_ATTEST_CREATION      |
| quote        | TPMS_QUOTE_INFO             | TPM_ST_ATTEST_QUOTE         |
| commandAudit | TPMS_COMMAND_AUDIT_INFO     | TPM_ST_ATTEST_COMMAND_AUDIT |
| sessionAudit | TPMS_SESSION_AUDIT_INFO     | TPM_ST_ATTEST_SESSION_AUDIT |
| time         | TPMS_TIME_ATTEST_INFO       | TPM_ST_ATTEST_TIME          |
| nv           | TPMS_NV_CERTIFY_INFO        | TPM_ST_ATTEST_NV            |
| nvDigest     | TPMS_NV_DIGEST_CERTIFY_INFO | TPM_ST_ATTEST_NV_DIGEST     |

### TPMS_ATTEST

This structure is used on each TPM-generated signed structure. The
signature is over this structure.

When the structure is signed by a key in the Storage hierarchy, the
values of *clockInfo.resetCount*, *clockInfo.restartCount*, and
*firmwareVersion* are obfuscated with a per-key obfuscation value.

<span id="_Toc380749808" class="anchor"></span>Table 133 — Definition of
TPMS_ATTEST Structure \<OUT\>

<table>
<colgroup>
<col style="width: 19%" />
<col style="width: 25%" />
<col style="width: 55%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Parameter</td>
<td>Type</td>
<td>Description</td>
</tr>
<tr class="even">
<td>magic</td>
<td>TPM_GENERATED</td>
<td>the indication that this structure was created by a TPM (always
TPM_GENERATED_VALUE)</td>
</tr>
<tr class="odd">
<td>type</td>
<td>TPMI_ST_ATTEST</td>
<td>type of the attestation structure</td>
</tr>
<tr class="even">
<td>qualifiedSigner</td>
<td>TPM2B_NAME</td>
<td>Qualified Name of the signing key</td>
</tr>
<tr class="odd">
<td>extraData</td>
<td>TPM2B_DATA</td>
<td><p>external information supplied by caller</p>
<p>NOTE A TPM2B_DATA structure provides room for a digest and a method
indicator to indicate the components of the digest. The definition of
this method indicator is outside the scope of this
specification.</p></td>
</tr>
<tr class="even">
<td>clockInfo</td>
<td>TPMS_CLOCK_INFO</td>
<td>Clock, resetCount, restartCount, and Safe</td>
</tr>
<tr class="odd">
<td>firmwareVersion</td>
<td>UINT64</td>
<td>TPM-vendor-specific value identifying the version number of the
firmware</td>
</tr>
<tr class="even">
<td>[type]attested</td>
<td>TPMU_ATTEST</td>
<td>the type-specific attestation information</td>
</tr>
</tbody>
</table>

### TPM2B_ATTEST

This sized buffer to contain the signed structure. The *attestationData*
is the signed portion of the structure. The *size* parameter is not
signed.

<span id="_Toc380749809" class="anchor"></span>Table 134 — Definition of
TPM2B_ATTEST Structure \<OUT\>

|                                               |        |                                         |
|-----------------------------------------------|--------|-----------------------------------------|
| Parameter                                     | Type   | Description                             |
| size                                          | UINT16 | size of the *attestationData* structure |
| attestationData\[size\]{:sizeof(TPMS_ATTEST)} | BYTE   | the signed structure                    |

## Authorization Structures

### Introduction

The structures in 10.13 are used for all authorizations. One or more of
these structures will be present in a command or response that has a tag
of TPM_ST_SESSIONS.

### TPMS_AUTH_COMMAND

This is the format used for each of the authorizations in the session
area of a command.

<span id="_Toc380749810" class="anchor"></span>Table 135 — Definition of
TPMS_AUTH_COMMAND Structure \<IN\>

|                   |                       |                                             |
|-------------------|-----------------------|---------------------------------------------|
| Parameter         | Type                  | Description                                 |
| sessionHandle     | TPMI_SH_AUTH_SESSION+ | the session handle                          |
| nonce             | TPM2B_NONCE           | the session nonce, may be the Empty Buffer  |
| sessionAttributes | TPMA_SESSION          | the session attributes                      |
| hmac              | TPM2B_AUTH            | either an HMAC, a password, or an EmptyAuth |

### TPMS_AUTH_RESPONSE

This is the format for each of the authorizations in the session area of
the response. If the TPM returns TPM_RC_SUCCESS, then the session area
of the response contains the same number of authorizations as the
command and the authorizations are in the same order.

<span id="_Toc380749811" class="anchor"></span>Table 136 — Definition of
TPMS_AUTH_RESPONSE Structure \<OUT\>

|                   |              |                                            |
|-------------------|--------------|--------------------------------------------|
| Parameter         | Type         | Description                                |
| nonce             | TPM2B_NONCE  | the session nonce, may be the Empty Buffer |
| sessionAttributes | TPMA_SESSION | the session attributes                     |
| hmac              | TPM2B_AUTH   | either an HMAC or an EmptyAuth             |

# Algorithm Parameters and Structures

## Symmetric

### Introduction

Clause 11.1 defines the parameters and structures for describing
symmetric algorithms.

### TPMI\_!ALG.S_KEY_BITS

This interface type defines the supported key sizes for a symmetric
algorithm. This type is used to allow the unmarshaling routine to
generate the proper validation code for the supported key sizes. An
implementation that supports different key sizes would have a different
set of selections.

Each implemented algorithm would have a value for the implemented key
sizes for that implemented algorithm. That value would have a name in
the form !ALG_KEY_SIZES_BITS where “!ALG” would represent the
characteristic name of the algorithm (such as “AES).

NOTE 1 Key size is expressed in bits.

<span id="_Toc384651474" class="anchor"></span>Table 137 — Definition of
{!ALG.S} (TPM_KEY_BITS) TPMI\_!ALG.S_KEY_BITS Type

|                         |                                      |
|-------------------------|--------------------------------------|
| Parameter               | Description                          |
| \$!ALG.S_KEY_SIZES_BITS | number of bits in the key            |
| \#TPM_RC_VALUE          | error when key size is not supported |

### TPMU_SYM_KEY_BITS

This union is used to collect the symmetric encryption key sizes.

The *xor* entry is a hash algorithms selector and not a key size in
bits. This overload is used in order to avoid an additional level of
indirection with another union and another set of selectors.

The *xor* entry is only selected in a TPMT_SYM_DEF, which is used to
select the parameter encryption value.

<span id="_Toc380749814" class="anchor"></span>Table 138 — Definition of
TPMU_SYM_KEY_BITS Union

<table>
<colgroup>
<col style="width: 20%" />
<col style="width: 25%" />
<col style="width: 21%" />
<col style="width: 32%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Parameter</td>
<td>Type</td>
<td>Selector</td>
<td>Description</td>
</tr>
<tr class="even">
<td>!ALG.S</td>
<td>TPMI_!ALG.S_KEY_BITS</td>
<td>TPM_ALG_!ALG.S</td>
<td>all symmetric algorithms</td>
</tr>
<tr class="odd">
<td>sym</td>
<td>TPM_KEY_BITS</td>
<td></td>
<td>this entry is used by the reference code to refer to the key bits
field in a way that is independent of the symmetric algorithm</td>
</tr>
<tr class="even">
<td>xor</td>
<td>TPMI_ALG_HASH</td>
<td>TPM_ALG_XOR</td>
<td><p>overload for using <em>xor</em></p>
<p>NOTE TPM_ALG_NULL is not allowed</p></td>
</tr>
<tr class="odd">
<td>null</td>
<td></td>
<td>TPM_ALG_NULL</td>
<td></td>
</tr>
</tbody>
</table>

### TPMU_SYM_MODE

This is the union of all modes for all symmetric algorithms.

NOTE This union definition allows the mode value in a TPMT_SYM_DEF to be
empty when the selector is TPM_ALG_XOR because the XOR algorithm does
not have a mode.

<span id="_Toc380749815" class="anchor"></span>Table 139 — Definition of
TPMU_SYM_MODE Union

|           |                    |                 |                                                                                                                             |
|-----------|--------------------|-----------------|-----------------------------------------------------------------------------------------------------------------------------|
| Parameter | Type               | Selector        | Description                                                                                                                 |
| !ALG.S    | TPMI_ALG_SYM_MODE+ | TPM_ALG\_!ALG.S |                                                                                                                             |
| sym       | TPMI_ALG_SYM_MODE+ |                 | this entry is used by the reference code to refer to the mode field in a way that is independent of the symmetric algorithm |
| xor       |                    | TPM_ALG_XOR     | no mode selector                                                                                                            |
| null      |                    | TPM_ALG_NULL    | no mode selector                                                                                                            |

### TPMU_SYM_DETAILS

This union allows additional parameters to be added for a symmetric
cipher. Currently, no additional parameters are required for any of the
symmetric algorithms.

NOTE The “x” character in the table title will suppress generation of
this type as the parser is not, at this time, able to generate the
proper values (a union of all empty data types). When an algorithm is
added that requires additional parameterization, the Type column will
contain a value and the “x” may be removed.

<span id="_Toc380749816" class="anchor"></span>Table 140 —xDefinition of
TPMU_SYM_DETAILS Union

|           |      |               |                                                                                                                                |
|-----------|------|---------------|--------------------------------------------------------------------------------------------------------------------------------|
| Parameter | Type | Selector      | Description                                                                                                                    |
| !ALG.S    |      | TPM_ALG\_!ALG |                                                                                                                                |
| sym       |      |               | this entry is used by the reference code to refer to the details field in a way that is independent of the symmetric algorithm |
| xor       |      | TPM_ALG_XOR   |                                                                                                                                |
| null      |      | TPM_ALG_NULL  |                                                                                                                                |

### TPMT_SYM_DEF

The TPMT_SYM_DEF structure is used to select an algorithm to be used for
parameter encryption in those cases when different symmetric algorithms
may be selected.

<span id="_Ref416449301" class="anchor"></span>Table 141 — Definition of
TPMT_SYM_DEF Structure

<table>
<colgroup>
<col style="width: 21%" />
<col style="width: 30%" />
<col style="width: 48%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Parameter</td>
<td>Type</td>
<td>Description</td>
</tr>
<tr class="even">
<td>algorithm</td>
<td>+TPMI_ALG_SYM</td>
<td>indicates a symmetric algorithm</td>
</tr>
<tr class="odd">
<td>[algorithm]keyBits</td>
<td>TPMU_SYM_KEY_BITS</td>
<td>a supported key size</td>
</tr>
<tr class="even">
<td>[algorithm]mode</td>
<td>TPMU_SYM_MODE</td>
<td>the mode for the key</td>
</tr>
<tr class="odd">
<td>//[algorithm]details</td>
<td>TPMU_SYM_DETAILS</td>
<td><p>contains additional algorithm details</p>
<p>NOTE This is commented out at this time as the parser may not produce
the proper code for a union if none of the selectors produces any
data.</p></td>
</tr>
</tbody>
</table>

### TPMT_SYM_DEF_OBJECT

This structure is used when different symmetric block cipher (not XOR)
algorithms may be selected. If the Object can be an ordinary parent (not
a derivation parent), this must be the first field in the Object's
parameter (see 12.2.3.7) field.

<span id="_Toc380749818" class="anchor"></span>Table 142 — Definition of
TPMT_SYM_DEF_OBJECT Structure

<table>
<colgroup>
<col style="width: 21%" />
<col style="width: 30%" />
<col style="width: 48%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Parameter</td>
<td>Type</td>
<td>Description</td>
</tr>
<tr class="even">
<td>algorithm</td>
<td>+TPMI_ALG_SYM_OBJECT</td>
<td><p>selects a symmetric block cipher</p>
<p>When used in the parameter area of a parent object, this shall be a
supported block cipher and not TPM_ALG_NULL</p></td>
</tr>
<tr class="odd">
<td>[algorithm]keyBits</td>
<td>TPMU_SYM_KEY_BITS</td>
<td>the key size</td>
</tr>
<tr class="even">
<td>[algorithm]mode</td>
<td>TPMU_SYM_MODE</td>
<td><p>default mode</p>
<p>When used in the parameter area of a parent object, this shall be
TPM_ALG_CFB.</p></td>
</tr>
<tr class="odd">
<td>//[algorithm]details</td>
<td>TPMU_SYM_DETAILS</td>
<td><p>contains the additional algorithm details, if any</p>
<p>NOTE This is commented out at this time as the parser may not produce
the proper code for a union if none of the selectors produces any
data.</p></td>
</tr>
</tbody>
</table>

### TPM2B_SYM_KEY

This structure is used to hold a symmetric key in the sensitive area of
an asymmetric object.

The number of bits in the key is in *keyBits* in the public area. When
*keyBits* is not an even multiple of 8 bits, the unused bits of *buffer*
will be the most significant bits of *buffer*\[0\] and *size* will be
rounded up to the number of octets required to hold all bits of the key.

NOTE MAX_SYM_KEY_BYTES will be the larger of the largest symmetric key
supported by the TPM and the largest digest produced by any hashing
algorithm implemented on the TPM.

<span id="_Toc432512626" class="anchor"></span>Table 143 — Definition of
TPM2B_SYM_KEY Structure

|                                      |        |                                                                |
|--------------------------------------|--------|----------------------------------------------------------------|
| Parameter                            | Type   | Description                                                    |
| size                                 | UINT16 | size, in octets, of the buffer containing the key; may be zero |
| buffer \[size\] {:MAX_SYM_KEY_BYTES} | BYTE   | the key                                                        |

### TPMS_SYMCIPHER_PARMS

This structure contains the parameters for a symmetric block cipher
object.

<span id="_Toc380749820" class="anchor"></span>Table 144 — Definition of
TPMS_SYMCIPHER_PARMS Structure

|           |                     |                          |
|-----------|---------------------|--------------------------|
| Parameter | Type                | Description              |
| sym       | TPMT_SYM_DEF_OBJECT | a symmetric block cipher |

### TPM2B_LABEL

This buffer holds a *label* or *context* value. For interoperability and
backwards compatibility, LABEL_MAX_BUFFER is the minimum of the largest
digest on the device and the largest ECC parameter (MAX_ECC_KEY_BYTES)
but no more than 32 bytes.

All implementations are required to support at least one hash algorithm
that produces a digest of 32 bytes or larger; and any implementation
that supports ECC is required to support at least one curve with a key
size of 32-bytes or larger.

NOTE Although the maximum size allowed for a *label* or *context* is 32
bytes, the object data structure needs to be sized to allow a 32-byte
value.

<span id="_Toc470518209" class="anchor"></span>Table 145 — Definition of
TPM2B_LABEL Structure

| Parameter                         | Type   | Description                                                                           |
|-----------------------------------|--------|---------------------------------------------------------------------------------------|
| size                              | UINT16 |                                                                                       |
| buffer\[size\]{:LABEL_MAX_BUFFER} | BYTE   | symmetric data for a created object or the *label* and *context* for a derived object |

### TPMS_DERIVE

This structure contains the *label* and *context* fields for a derived
object. These values are used in the derivation KDF. The values in the
*unique* field of *inPubli*c area template take precedence over the
values in the *inSensitive* parameter.

<span id="_Toc470518210" class="anchor"></span>Table 146 — Definition of
TPMS_DERIVE Structure

| Parameter | Type        | Description |
|-----------|-------------|-------------|
| label     | TPM2B_LABEL |             |
| context   | TPM2B_LABEL |             |

### TPM2B_DERIVE

<span id="_Toc470518211" class="anchor"></span>Table 147 — Definition of
TPM2B_DERIVE Structure

| Parameter                             | Type   | Description                                                                           |
|---------------------------------------|--------|---------------------------------------------------------------------------------------|
| size                                  | UINT16 |                                                                                       |
| buffer\[size\]{: sizeof(TPMS_DERIVE)} | BYTE   | symmetric data for a created object or the *label* and *context* for a derived object |

### TPMU_SENSITIVE_CREATE

This structure allows a TPM2B_SENSITIVE_CREATE structure to carry either
a TPM2B_SENSITVE_DATA or a TPM2B_DERIVE structure. The contents of the
union are determined by context. When an object is being derived, the
derivation values are present.

For interoperability, MAX_SYM_DATA should be 128.

NOTE No marshaling code is automatically generated for this union as it
has no selectors that would allow the code to know the context and which
member to unmarshal.

<span id="_Toc470518212" class="anchor"></span>Table 148 — Definition of
TPMU_SENSITIVE_CREATE Union \<\>

|                        |             |          |                                               |
|------------------------|-------------|----------|-----------------------------------------------|
| Parameter              | Type        | Selector | Description                                   |
| create\[MAX_SYM_DATA\] | BYTE        |          | sensitive data for a created symmetric Object |
| derive                 | TPMS_DERIVE |          | *label* and *context* for a derived Object    |

### TPM2B_SENSITIVE_DATA

This buffer wraps the TPMU_SENSITIVE_CREATE
structure.<span id="_Toc380749821" class="anchor"></span>

Table 149 — Definition of TPM2B_SENSITIVE_DATA Structure

| Parameter                                       | Type   | Description                                                                           |
|-------------------------------------------------|--------|---------------------------------------------------------------------------------------|
| size                                            | UINT16 |                                                                                       |
| buffer\[size\]{: sizeof(TPMU_SENSITIVE_CREATE)} | BYTE   | symmetric data for a created object or the *label* and *context* for a derived object |

### TPMS_SENSITIVE_CREATE

This structure defines the values to be placed in the sensitive area of
a created object. This structure is only used within a
TPM2B_SENSITIVE_CREATE structure.

NOTE When sent to the TPM or unsealed, data is usually encrypted using
parameter encryption.

If *data.size* is not zero, and the object is not a *keyedHash*,
*data.size* must match the size indicated in the *keySize* *o*f
*public.parameters.* If the object is a *keyedHash*, *data*.*size* may
be any value up to the maximum allowed in a TPM2B_SENSITIVE_DATA.

For an asymmetric object, data shall be an Empty Buffer and
*sensitiveDataOrigin* shall be SET.

<span id="_Toc380749822" class="anchor"></span>Table 150 — Definition of
TPMS_SENSITIVE_CREATE Structure \<IN\>

|           |                      |                                                |
|-----------|----------------------|------------------------------------------------|
| Parameter | Type                 | Description                                    |
| userAuth  | TPM2B_AUTH           | the USER auth secret value                     |
| data      | TPM2B_SENSITIVE_DATA | data to be sealed, a key, or derivation values |

### TPM2B_SENSITIVE_CREATE

This structure contains the sensitive creation data in a sized buffer.
This structure is defined so that both the *userAuth* and *data* values
of the TPMS_SENSITIVE_CREATE may be passed as a single parameter for
parameter encryption purposes.

<span id="_Toc380749823" class="anchor"></span>Table 151 — Definition of
TPM2B_SENSITIVE_CREATE Structure \<IN, S\>

<table>
<colgroup>
<col style="width: 18%" />
<col style="width: 31%" />
<col style="width: 50%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Parameter</td>
<td>Type</td>
<td>Description</td>
</tr>
<tr class="even">
<td>size=</td>
<td>UINT16</td>
<td><p>size of <em>sensitive</em> in octets (may not be zero)</p>
<p>NOTE The <em>userAuth</em> and data parameters in this buffer may
both be zero length but the minimum size of this parameter will be the
sum of the size fields of the two parameters of the
TPMS_SENSITIVE_CREATE.</p></td>
</tr>
<tr class="odd">
<td>sensitive</td>
<td>TPMS_SENSITIVE_CREATE</td>
<td>data to be sealed or a symmetric key value.</td>
</tr>
</tbody>
</table>

### TPMS_SCHEME_HASH

This structure is the scheme data for schemes that only require a hash
to complete their definition.

<span id="_Toc380749824" class="anchor"></span>Table 152 — Definition of
TPMS_SCHEME_HASH Structure

|           |               |                                               |
|-----------|---------------|-----------------------------------------------|
| Parameter | Type          | Description                                   |
| hashAlg   | TPMI_ALG_HASH | the hash algorithm used to digest the message |

### TPMS_SCHEME_ECDAA

This definition is for split signing schemes that require a commit
count.

<span id="_Toc432512632" class="anchor"></span>Table 153 — Definition of
{ECC} TPMS_SCHEME_ECDAA Structure

|           |               |                                                                             |
|-----------|---------------|-----------------------------------------------------------------------------|
| Parameter | Type          | Description                                                                 |
| hashAlg   | TPMI_ALG_HASH | the hash algorithm used to digest the message                               |
| count     | UINT16        | the counter value that is used between TPM2_Commit() and the sign operation |

### TPMI_ALG_KEYEDHASH_SCHEME

This is the list of values that may appear in a *keyedHash* as the
*scheme* parameter.

<span id="_Toc380749825" class="anchor"></span>Table 154 — Definition of
(TPM_ALG_ID) TPMI_ALG_KEYEDHASH_SCHEME Type

| Values         | Comments                 |
|----------------|--------------------------|
| TPM_ALG_HMAC   | the "signing" scheme     |
| TPM_ALG_XOR    | the "obfuscation" scheme |
| +TPM_ALG_NULL  |                          |
| \#TPM_RC_VALUE |                          |

### HMAC_SIG_SCHEME

<span id="_Toc380749826" class="anchor"></span>Table 155 — Definition of
Types for HMAC_SIG_SCHEME

|                  |                  |             |
|------------------|------------------|-------------|
| Type             | Name             | Description |
| TPMS_SCHEME_HASH | TPMS_SCHEME_HMAC |             |

### TPMS_SCHEME_XOR

This structure is for the XOR encryption scheme.

NOTE Prior to revision 01.47, the TPM_ALG_NULL hash algorithm was
permitted. This produced a zero length key. The TPM_ALG_NULL *hashAlg*
now returns TPM_RC_HASH.

<span id="_Toc380749827" class="anchor"></span>Table 156 — Definition of
TPMS_SCHEME_XOR Structure

|           |               |                                               |
|-----------|---------------|-----------------------------------------------|
| Parameter | Type          | Description                                   |
| hashAlg   | TPMI_ALG_HASH | the hash algorithm used to digest the message |
| kdf       | TPMI_ALG_KDF+ | the key derivation function                   |

### TPMU_SCHEME_KEYEDHASH

<span id="_Toc380749828" class="anchor"></span>Table 157 — Definition of
TPMU_SCHEME_KEYEDHASH Union \<IN/OUT \>

|           |                  |              |                          |
|-----------|------------------|--------------|--------------------------|
| Parameter | Type             | Selector     | Description              |
| hmac      | TPMS_SCHEME_HMAC | TPM_ALG_HMAC | the "signing" scheme     |
| xor       | TPMS_SCHEME_XOR  | TPM_ALG_XOR  | the "obfuscation" scheme |
| null      |                  | TPM_ALG_NULL |                          |

### TPMT_KEYEDHASH_SCHEME

This structure is used for a hash signing object.

<span id="_Toc380749829" class="anchor"></span>Table 158 — Definition of
TPMT_KEYEDHASH_SCHEME Structure

|                   |                            |                       |
|-------------------|----------------------------|-----------------------|
| Parameter         | Type                       | Description           |
| scheme            | +TPMI_ALG_KEYEDHASH_SCHEME | selects the scheme    |
| \[scheme\]details | TPMU_SCHEME_KEYEDHASH      | the scheme parameters |

## Asymmetric

### Signing Schemes

#### Introduction

These structures are used to define the method in which the signature is
to be created. These schemes would appear in an object’s public area and
in commands where the signing scheme is variable.

Every scheme is required to indicate a hash that is used in digesting
the message.

#### RSA Signature Schemes

These are the RSA schemes that only need a hash algorithm as a scheme
parameter.

For the TPM_ALG_RSAPSS signing scheme, the same hash algorithm is used
for digesting TPM-generated data (an attestation structure) and in the
KDF used for the masking operation. The salt size is always the largest
salt value that will fit into the available space.

<span id="_Ref386448866" class="anchor"></span>Table 159 — Definition of
{RSA} Types for RSA Signature Schemes

|                  |                          |             |
|------------------|--------------------------|-------------|
| Type             | Name                     | Description |
| TPMS_SCHEME_HASH | TPMS_SIG_SCHEME\_!ALG.AX |             |

#### ECC Signature Schemes

Most of the ECC signature schemes only require a hash algorithm to
complete the definition and can be typed as TPMS_SCHEME_HASH. Anonymous
algorithms also require a count value so they are typed to be
TPMS_SCHEME_ECDAA.

> <span id="_Ref386448781" class="anchor"></span>Table 160 — Definition
> of {ECC} Types for ECC Signature Schemes

|                   |                           |                                      |
|-------------------|---------------------------|--------------------------------------|
| Type              | Name                      | Description                          |
| TPMS_SCHEME_HASH  | TPMS_SIG_SCHEME\_!ALG.AX  | all asymmetric signing schemes       |
| TPMS_SCHEME_ECDAA | TPMS_SIG_SCHEME\_!ALG.AXN | schemes that need a hash and a count |

#### TPMU_SIG_SCHEME

This is the union of all of the signature schemes.

NOTE The TPMS_SIG_SCHEME\_!ALG is determined by Table 159 or Table 160
and will be either a TPMS_SCHEME_HASH or a TPMS_SCHEME_ECDAA.

<span id="_Toc380749833" class="anchor"></span>Table 161 — Definition of
TPMU_SIG_SCHEME Union \<IN/OUT \>

|           |                       |               |                                                              |
|-----------|-----------------------|---------------|--------------------------------------------------------------|
| Parameter | Type                  | Selector      | Description                                                  |
| !ALG.ax   | TPMS_SIG_SCHEME\_!ALG | TPM_ALG\_!ALG | all signing schemes including anonymous schemes              |
| hmac      | TPMS_SCHEME_HMAC      | TPM_ALG_HMAC  | the HMAC scheme                                              |
| any       | TPMS_SCHEME_HASH      |               | selector that allows access to digest for any signing scheme |
| null      |                       | TPM_ALG_NULL  | no scheme or default                                         |

#### TPMT_SIG_SCHEME

<span id="_Toc380749834" class="anchor"></span>Table 162 — Definition of
TPMT_SIG_SCHEME Structure

|                   |                      |                   |
|-------------------|----------------------|-------------------|
| Parameter         | Type                 | Description       |
| scheme            | +TPMI_ALG_SIG_SCHEME | scheme selector   |
| \[scheme\]details | TPMU_SIG_SCHEME      | scheme parameters |

### Encryption Schemes

#### Introduction

These structures are used to indicate the algorithm used for the
encrypting process. These schemes would appear in an object’s public
area.

NOTE With ECC, the only encryption is with a key exchange of a symmetric
key or seed.

#### RSA Encryption Schemes

These are the RSA encryption schemes that only need a hash algorithm as
a controlling parameter.

NOTE: These types do not appear in the reference code in the
specification but are used in the unmarshaling code.

> <span id="_Toc432512642" class="anchor"></span>Table 163 — Definition
> of Types for {RSA} Encryption Schemes

|                  |                           |                               |
|------------------|---------------------------|-------------------------------|
| Type             | Name                      | Description                   |
| TPMS_SCHEME_HASH | TPMS_ENC_SCHEME\_!ALG.AEH | schemes that only need a hash |
| TPMS_EMPTY       | TPMS_ENC_SCHEME\_!ALG.AE  | schemes that need nothing     |

#### ECC Key Exchange Schemes

These are the ECC schemes that only need a hash algorithm as a
controlling parameter.

NOTE: These types do not appear in the reference code in the
specification but are used in the unmarshaling code.

<span id="_Toc432512643" class="anchor"></span>Table 164 — Definition of
Types for {ECC} ECC Key Exchange

|                  |                          |                          |
|------------------|--------------------------|--------------------------|
| Type             | Name                     | Description              |
| TPMS_SCHEME_HASH | TPMS_KEY_SCHEME\_!ALG.AM | schemes that need a hash |

### Key Derivation Schemes

#### Introduction

These structures are used to define the key derivation for symmetric
secret sharing using asymmetric methods. A secret sharing scheme is
required in any asymmetric key with the *decrypt* attribute SET.

These schemes would appear in an object’s public area and in commands
where the secret sharing scheme is variable.

Each scheme includes a symmetric algorithm and a KDF selection.

The qualifying value for each of the KDF schemes is the hash algorithm.

NOTE: These types do not appear in the reference code in the
specification but are used in the unmarshaling code.

<span id="_Toc432512644" class="anchor"></span>Table 165 — Definition of
Types for KDF Schemes

|                  |                          |                                              |
|------------------|--------------------------|----------------------------------------------|
| Type             | Name                     | Description                                  |
| TPMS_SCHEME_HASH | TPMS_KDF_SCHEME\_!ALG.HM | hash-based key- or mask-generation functions |

#### TPMU_KDF_SCHEME

<span id="_Toc432512645" class="anchor"></span>Table 166 — Definition of
TPMU_KDF_SCHEME Union \<IN/OUT\>

|           |                          |                  |             |
|-----------|--------------------------|------------------|-------------|
| Parameter | Type                     | Selector         | Description |
| !ALG.HM   | TPMS_KDF_SCHEME\_!ALG.HM | TPM_ALG\_!ALG.HM |             |
| null      |                          | TPM_ALG_NULL     |             |

#### TPMT_KDF_SCHEME

<span id="_Toc380749842" class="anchor"></span>Table 167 — Definition of
TPMT_KDF_SCHEME Structure

|                   |                 |                   |
|-------------------|-----------------|-------------------|
| Parameter         | Type            | Description       |
| scheme            | +TPMI_ALG_KDF   | scheme selector   |
| \[scheme\]details | TPMU_KDF_SCHEME | scheme parameters |

#### TPMI_ALG_ASYM_SCHEME

List of all of the scheme types for any asymmetric algorithm.

NOTE 1 This is the selector value used to define TPMT_ASYM_SCHEME.

NOTE 2 Most tokens are exclusive in order to filter out SM2 and other
multi-protocol algorithm identifiers. The inclusive token “ax” will
include those algorithms.

<span id="_Toc380749843" class="anchor"></span>Table 168 — Definition of
(TPM_ALG_ID) TPMI_ALG_ASYM_SCHEME Type \<IO\>

| Values           | Comments                        |
|------------------|---------------------------------|
| TPM_ALG\_!ALG.am | key exchange methods            |
| TPM_ALG\_!ALG.ax | all signing including anonymous |
| TPM_ALG\_!ALG.ae | encrypting schemes              |
| +TPM_ALG_NULL    |                                 |
| \#TPM_RC_VALUE   |                                 |

#### TPMU_ASYM_SCHEME

This union of all asymmetric schemes is used in each of the asymmetric
scheme structures. The actual scheme structure is defined by the
interface type used for the selector (TPMI_ALG_ASYM_SCHEME).

EXAMPLE The TPMT_RSA_SCHEME structure uses the TPMU_ASYM_SCHEME union
but the selector type is TPMI_ALG_RSA_SCHEME. This means that the only
elements of the union that can be selected for the TPMT_RSA_SCHEME are
those that are in TPMI_RSA_SCHEME.

<span id="_Toc380749844" class="anchor"></span>Table 169 — Definition of
TPMU_ASYM_SCHEME Union

<table>
<colgroup>
<col style="width: 12%" />
<col style="width: 31%" />
<col style="width: 24%" />
<col style="width: 31%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Parameter</td>
<td>Type</td>
<td>Selector</td>
<td>Description</td>
</tr>
<tr class="even">
<td>!ALG.am</td>
<td>TPMS_KEY_SCHEME_!ALG</td>
<td>TPM_ALG_!ALG</td>
<td></td>
</tr>
<tr class="odd">
<td>!ALG.ax</td>
<td>TPMS_SIG_SCHEME_!ALG</td>
<td>TPM_ALG_!ALG</td>
<td>signing and anonymous signing</td>
</tr>
<tr class="even">
<td>!ALG.ae</td>
<td>TPMS_ENC_SCHEME_!ALG</td>
<td>TPM_ALG_!ALG</td>
<td>schemes with no hash</td>
</tr>
<tr class="odd">
<td>!ALG.HM</td>
<td>TPMS_KDF_SCHEME_!ALG</td>
<td>TPM_ALG_!ALG</td>
<td>kdf schemes</td>
</tr>
<tr class="even">
<td>anySig</td>
<td>TPMS_SCHEME_HASH</td>
<td></td>
<td></td>
</tr>
<tr class="odd">
<td>null</td>
<td></td>
<td>TPM_ALG_NULL</td>
<td><p>no scheme or default</p>
<p>This selects the NULL Signature.</p></td>
</tr>
</tbody>
</table>

#### TPMT_ASYM_SCHEME

This structure is defined to allow overlay of all of the schemes for any
asymmetric object. This structure is not sent on the interface. It is
defined so that common functions may operate on any similar scheme
structure.

EXAMPLE Since many schemes have a hash algorithm as their defining
parameter, a common function can use the digest selector to select the
hash of the scheme without a need to cast or use a large switch
statement.

<span id="_Toc380749845" class="anchor"></span>Table 170 — Definition of
TPMT_ASYM_SCHEME Structure \<\>

|                   |                       |                   |
|-------------------|-----------------------|-------------------|
| Parameter         | Type                  | Description       |
| scheme            | +TPMI_ALG_ASYM_SCHEME | scheme selector   |
| \[scheme\]details | TPMU_ASYM_SCHEME      | scheme parameters |

### RSA

#### TPMI_ALG_RSA_SCHEME

The list of values that may appear in the scheme parameter of a
TPMS_RSA_PARMS structure.

<span id="_Toc380749846" class="anchor"></span>Table 171 — Definition of
(TPM_ALG_ID) {RSA} TPMI_ALG_RSA_SCHEME Type

| Values              | Comments                          |
|---------------------|-----------------------------------|
| TPM_ALG\_!ALG.ae.ax | encrypting and signing algorithms |
| +TPM_ALG_NULL       |                                   |
| \#TPM_RC_VALUE      |                                   |

#### TPMT_RSA_SCHEME

<span id="_Toc380749847" class="anchor"></span>Table 172 — Definition of
{RSA} TPMT_RSA_SCHEME Structure

|                   |                      |                   |
|-------------------|----------------------|-------------------|
| Parameter         | Type                 | Description       |
| scheme            | +TPMI_ALG_RSA_SCHEME | scheme selector   |
| \[scheme\]details | TPMU_ASYM_SCHEME     | scheme parameters |

#### TPMI_ALG_RSA_DECRYPT

The list of values that are allowed in a decryption scheme selection as
used in TPM2_RSA_Encrypt() and TPM2_RSA_Decrypt().

<span id="_Ref365138834" class="anchor"></span>Table 173 — Definition of
(TPM_ALG_ID) {RSA} TPMI_ALG_RSA_DECRYPT Type

| Values           | Comments                      |
|------------------|-------------------------------|
| TPM_ALG\_!ALG.ae | all RSA encryption algorithms |
| +TPM_ALG_NULL    |                               |
| \#TPM_RC_VALUE   |                               |

#### TPMT_RSA_DECRYPT

<span id="_Toc380749849" class="anchor"></span>Table 174 — Definition of
{RSA} TPMT_RSA_DECRYPT Structure

|                   |                       |                   |
|-------------------|-----------------------|-------------------|
| Parameter         | Type                  | Description       |
| scheme            | +TPMI_ALG_RSA_DECRYPT | scheme selector   |
| \[scheme\]details | TPMU_ASYM_SCHEME      | scheme parameters |

#### TPM2B_PUBLIC_KEY_RSA

This sized buffer holds the largest RSA public key supported by the TPM.

NOTE The reference implementation only supports key sizes of 1,024 and
2,048 bits.

<span id="_Toc380749850" class="anchor"></span>Table 175 — Definition of
{RSA} TPM2B_PUBLIC_KEY_RSA Structure

<table>
<colgroup>
<col style="width: 38%" />
<col style="width: 15%" />
<col style="width: 46%" />
</colgroup>
<thead>
<tr class="header">
<th>Parameter</th>
<th>Type</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>size</td>
<td>UINT16</td>
<td><p>size of the buffer</p>
<p>The value of zero is only valid for create.</p></td>
</tr>
<tr class="even">
<td>buffer[size] {: MAX_RSA_KEY_BYTES}</td>
<td>BYTE</td>
<td>Value</td>
</tr>
</tbody>
</table>

#### TPMI_RSA_KEY_BITS

This holds the value that is the maximum size allowed for an RSA key.

NOTE 1 An implementation is allowed to provide limited support for
smaller RSA key sizes. That is, a TPM may be able to accept a smaller
RSA key size in TPM2_LoadExternal() when only the public area is loaded
but not accept that smaller key size in any command that loads both the
public and private portions of an RSA key. This would allow the TPM to
validate signatures using the smaller key but would prevent the TPM from
using the smaller key size for any other purpose.

NOTE 2 The definition for RSA_KEY_SIZES_BITS used in the reference
implementation is found in TPM 2.0 Part 4, Implementation.h

<span id="_Toc380749851" class="anchor"></span>Table 176 — Definition of
{RSA} (TPM_KEY_BITS) TPMI_RSA_KEY_BITS Type

|                      |                                         |
|----------------------|-----------------------------------------|
| Parameter            | Description                             |
| \$RSA_KEY_SIZES_BITS | the number of bits in the supported key |
| \#TPM_RC_VALUE       | error when key size is not supported    |

#### TPM2B_PRIVATE_KEY_RSA

This sized buffer holds the largest RSA prime number supported by the
TPM.

NOTE 1 All primes are required to have exactly half the number of
significant bits as the public modulus, and the square of each prime is
required to have the same number of significant bits as the public
modulus.

NOTE 2 RSA_PRIVATE_SIZE is a vendor specific value that can be
(MAX_RSA_KEY_BYTES / 2) or ((MAX_RSA_KEY_BYTES \* 5) ./ 2. The larger
size would only apply to keys that have *fixedTPM* parents. The larger
size was added in revision 01.53.

<span id="_Toc380749852" class="anchor"></span>Table 177 — Definition of
{RSA} TPM2B_PRIVATE_KEY_RSA Structure

| Parameter                          | Type   | Description |
|------------------------------------|--------|-------------|
| size                               | UINT16 |             |
| buffer\[size\]{:RSA_PRIVATE_SIZE } | BYTE   |             |

### ECC

#### TPM2B_ECC_PARAMETER

This sized buffer holds the largest ECC parameter (coordinate) supported
by the TPM.

<span id="_Toc380749853" class="anchor"></span>Table 178 — Definition of
TPM2B_ECC_PARAMETER Structure

| Parameter                           | Type   | Description        |
|-------------------------------------|--------|--------------------|
| size                                | UINT16 | size of *buffer*   |
| buffer\[size\] {:MAX_ECC_KEY_BYTES} | BYTE   | the parameter data |

#### TPMS_ECC_POINT

This structure holds two ECC coordinates that, together, make up an ECC
point.

<span id="_Toc380749854" class="anchor"></span>Table 179 — Definition of
{ECC} TPMS_ECC_POINT Structure

| Parameter | Type                | Description  |
|-----------|---------------------|--------------|
| x         | TPM2B_ECC_PARAMETER | X coordinate |
| y         | TPM2B_ECC_PARAMETER | Y coordinate |

#### TPM2B_ECC_POINT

This structure is defined to allow a point to be a single sized
parameter so that it may be encrypted.

NOTE If the point is to be omitted, the X and Y coordinates need to be
individually set to Empty Buffers. The minimum value for size will be
four. It is checked indirectly by unmarshaling of the TPMS_ECC_POINT. If
the type of *point* were BYTE, then *size* could have been zero.
However, this would complicate the process of marshaling the structure.

<span id="_Toc380749855" class="anchor"></span>Table 180 — Definition of
{ECC} TPM2B_ECC_POINT Structure

| Parameter     | Type           | Description                                                                      |
|---------------|----------------|----------------------------------------------------------------------------------|
| size=         | UINT16         | size of the remainder of this structure                                          |
| point         | TPMS_ECC_POINT | coordinates                                                                      |
| \#TPM_RC_SIZE |                | error returned if the unmarshaled size of *point* is not exactly equal to *size* |

#### TPMI_ALG_ECC_SCHEME

<span id="_Toc380749856" class="anchor"></span>Table 181 — Definition of
(TPM_ALG_ID) {ECC} TPMI_ALG_ECC_SCHEME Type

| Values           | Comments                |
|------------------|-------------------------|
| TPM_ALG\_!ALG.ax | the ecc signing schemes |
| TPM_ALG\_!ALG.am | key exchange methods    |
| +TPM_ALG_NULL    |                         |
| \#TPM_RC_SCHEME  |                         |

#### TPMI_ECC_CURVE

This type enumerates the ECC curves implemented by the TPM.

<span id="_Toc380749857" class="anchor"></span>Table 182 — Definition of
{ECC} (TPM_ECC_CURVE) TPMI_ECC_CURVE Type

|                |                                   |
|----------------|-----------------------------------|
| Parameter      | Description                       |
| \$ECC_CURVES   | the list of implemented curves    |
| \#TPM_RC_CURVE | error when curve is not supported |

#### TPMT_ECC_SCHEME

<span id="_Toc380749858" class="anchor"></span>Table 183 — Definition of
(TPMT_SIG_SCHEME) {ECC} TPMT_ECC_SCHEME Structure

|                   |                      |                   |
|-------------------|----------------------|-------------------|
| Parameter         | Type                 | Description       |
| scheme            | +TPMI_ALG_ECC_SCHEME | scheme selector   |
| \[scheme\]details | TPMU_ASYM_SCHEME     | scheme parameters |

#### TPMS_ALGORITHM_DETAIL_ECC

This structure is used to report on the curve parameters of an ECC
curve. It is returned by TPM2_ECC_Parameters().

<span id="_Toc380749859" class="anchor"></span>Table 184 — Definition of
{ECC} TPMS_ALGORITHM_DETAIL_ECC Structure \<OUT\>

|           |                     |                                                                                                          |
|-----------|---------------------|----------------------------------------------------------------------------------------------------------|
| Parameter | Type                | Description                                                                                              |
| curveID   | TPM_ECC_CURVE       | identifier for the curve                                                                                 |
| keySize   | UINT16              | Size in bits of the key                                                                                  |
| kdf       | TPMT_KDF_SCHEME+    | if not TPM_ALG_NULL, the required KDF and hash algorithm used in secret sharing operations               |
| sign      | TPMT_ECC_SCHEME+    | If not TPM_ALG_NULL, this is the mandatory signature scheme that is required to be used with this curve. |
| p         | TPM2B_ECC_PARAMETER | *Fp* (the modulus)                                                                                       |
| a         | TPM2B_ECC_PARAMETER | coefficient of the linear term in the curve equation                                                     |
| b         | TPM2B_ECC_PARAMETER | constant term for curve equation                                                                         |
| gX        | TPM2B_ECC_PARAMETER | x coordinate of base point G                                                                             |
| gY        | TPM2B_ECC_PARAMETER | y coordinate of base point G                                                                             |
| n         | TPM2B_ECC_PARAMETER | order of G                                                                                               |
| h         | TPM2B_ECC_PARAMETER | cofactor (a size of zero indicates a cofactor of 1)                                                      |

## Signatures

### TPMS_SIGNATURE_RSA

<span id="_Toc380749860" class="anchor"></span>Table 185 — Definition of
{RSA} TPMS_SIGNATURE_RSA Structure

<table>
<colgroup>
<col style="width: 22%" />
<col style="width: 32%" />
<col style="width: 45%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Parameter</td>
<td>Type</td>
<td>Description</td>
</tr>
<tr class="even">
<td>hash</td>
<td>TPMI_ALG_HASH</td>
<td><p>the hash algorithm used to digest the message</p>
<p>TPM_ALG_NULL is not allowed.</p></td>
</tr>
<tr class="odd">
<td>sig</td>
<td>TPM2B_PUBLIC_KEY_RSA</td>
<td>The signature is the size of a public key.</td>
</tr>
</tbody>
</table>

<span id="_Toc432512665" class="anchor"></span>Table 186 — Definition of
Types for {RSA} Signature

|                    |                         |             |
|--------------------|-------------------------|-------------|
| Type               | Name                    | Description |
| TPMS_SIGNATURE_RSA | TPMS_SIGNATURE\_!ALG.ax |             |

### TPMS_SIGNATURE_ECC

<span id="_Toc380749862" class="anchor"></span>Table 187 — Definition of
{ECC} TPMS_SIGNATURE_ECC Structure

<table>
<colgroup>
<col style="width: 22%" />
<col style="width: 32%" />
<col style="width: 45%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Parameter</td>
<td>Type</td>
<td>Description</td>
</tr>
<tr class="even">
<td>hash</td>
<td>TPMI_ALG_HASH</td>
<td><p>the hash algorithm used in the signature process</p>
<p>TPM_ALG_NULL is not allowed.</p></td>
</tr>
<tr class="odd">
<td>signatureR</td>
<td>TPM2B_ECC_PARAMETER</td>
<td></td>
</tr>
<tr class="even">
<td>signatureS</td>
<td>TPM2B_ECC_PARAMETER</td>
<td></td>
</tr>
</tbody>
</table>

<span id="_Toc432512667" class="anchor"></span>Table 188 — Definition of
Types for {ECC} TPMS_SIGNATURE_ECC

|                    |                         |             |
|--------------------|-------------------------|-------------|
| Type               | Name                    | Description |
| TPMS_SIGNATURE_ECC | TPMS_SIGNATURE\_!ALG.ax |             |

### TPMU_SIGNATURE

A TPMU_SIGNATURE_COMPOSITE is a union of the various signatures that are
supported by a particular TPM implementation. The union allows
substitution of any signature algorithm wherever a signature is required
in a structure.

NOTE All TPM are required to support a hash algorithm and the HMAC
algorithm.

When a symmetric algorithm is used for signing, the signing algorithm is
assumed to be an HMAC based on the indicated hash algorithm. The HMAC
key will either be referenced as part of the usage or will be implied by
context.

<span id="_Ref259714628" class="anchor"></span>Table 189 — Definition of
TPMU_SIGNATURE Union \<IN/OUT\>

|           |                         |                  |                                           |
|-----------|-------------------------|------------------|-------------------------------------------|
| Parameter | Type                    | Selector         | Description                               |
| !ALG.ax   | TPMS_SIGNATURE\_!ALG.ax | TPM_ALG\_!ALG.ax | all asymmetric signatures                 |
| hmac      | TPMT_HA                 | TPM_ALG_HMAC     | HMAC signature (required to be supported) |
| any       | TPMS_SCHEME_HASH        |                  | used to access the hash                   |
| null      |                         | TPM_ALG_NULL     | the NULL signature                        |

### TPMT_SIGNATURE

Table 190 shows the basic algorithm-agile structure when a symmetric or
asymmetric signature is indicated. The *sigAlg* parameter indicates the
algorithm used for the signature. This structure is output from commands
such as the attestation commands and TPM2_Sign, and is an input to
commands such as TPM2_VerifySignature(), TPM2_PolicySigned(), and
TPM2_FieldUpgradeStart().

<span id="_Ref291846412" class="anchor"></span>Table 190 — Definition of
TPMT_SIGNATURE Structure

|                     |                      |                                                           |
|---------------------|----------------------|-----------------------------------------------------------|
| Parameter           | Type                 | Description                                               |
| sigAlg              | +TPMI_ALG_SIG_SCHEME | selector of the algorithm used to construct the signature |
| \[sigAlg\]signature | TPMU_SIGNATURE       | This shall be the actual signature information.           |

## Key/Secret Exchange

### Introduction

The structures in 11.4 are used when a key or secret is being exchanged.
The exchange may be in

- TPM2_StartAuthSession() where the secret is injected for salting the
  session,

- TPM2_Duplicate(), TPM2_Import, or TPM2_Rewrap() where the secret is
  the symmetric encryption key for the outer wrapper of a duplication
  blob, or

- TPM2_ActivateIdentity() or TPM2_CreateIdentity() where the secret is
  the symmetric encryption key for the credential blob.

Particulars are described in TPM 2.0 Part 1.

### TPMU_ENCRYPTED_SECRET

This structure is used to hold either an ephemeral public point for
ECDH, an OAEP-encrypted block for RSA, or a symmetrically encrypted
value. This structure is defined for the limited purpose of determining
the size of a TPM2B_ENCRYPTED_SECRET.

The symmetrically encrypted value may use either CFB or XOR encryption.

NOTE Table 191 is illustrative. It would be modified depending on the
algorithms supported in the TPM.

<span id="_Ref307333263" class="anchor"></span>Table 191 — Definition of
TPMU_ENCRYPTED_SECRET Union

|                                   |      |                   |                                                                                         |
|-----------------------------------|------|-------------------|-----------------------------------------------------------------------------------------|
| Parameter                         | Type | Selector          | Description                                                                             |
| ecc\[sizeof(TPMS_ECC_POINT)\]     | BYTE | TPM_ALG_ECC       |                                                                                         |
| rsa\[MAX_RSA_KEY_BYTES\]          | BYTE | TPM_ALG_RSA       |                                                                                         |
| symmetric\[sizeof(TPM2B_DIGEST)\] | BYTE | TPM_ALG_SYMCIPHER |                                                                                         |
| keyedHash\[sizeof(TPM2B_DIGEST)\] | BYTE | TPM_ALG_KEYEDHASH | Any symmetrically encrypted secret value will be limited to be no larger than a digest. |

### TPM2B_ENCRYPTED_SECRET

<span id="_Toc380749866" class="anchor"></span>Table 192 — Definition of
TPM2B_ENCRYPTED_SECRET Structure

|                                                 |        |                          |
|-------------------------------------------------|--------|--------------------------|
| Parameter                                       | Type   | Description              |
| size                                            | UINT16 | size of the secret value |
| secret\[size\] {:sizeof(TPMU_ENCRYPTED_SECRET)} | BYTE   | secret                   |

# Key/Object Complex

## Introduction

An object description requires a TPM2B_PUBLIC structure and may require
a TPMT_SENSITIVE structure. When the structure is stored off the TPM,
the TPMT_SENSITIVE structure is encrypted within a TPM2B_PRIVATE
structure.

When the object requires two components for its description, those
components are loaded as separate parameters in the TPM2_Load() command.
When the TPM creates an object that requires both components, the TPM
will return them as separate parameters from the TPM2_Create()
operation.

The TPM may produce multiple different TPM2B_PRIVATE structures for a
single TPM2B_PUBLIC structure. Creation of a modified TPM2B_PRIVATE
structure requires that the full structure be loaded with the
TPM2_Load() command, modification of the TPMT_SENSITIVE data, and output
of a new TPM2B_PRIVATE structure.

## Public Area Structures

### Description

Clause 12.2 defines the TPM2B_PUBLIC structure and the higher-level
substructure that may be contained in a TPM2B_PUBLIC. The higher-level
structures that are currently defined for inclusion in a TPM2B_PUBLIC
are the

- structures for asymmetric keys,

- structures for symmetric keys, and

- structures for sealed data.

### TPMI_ALG_PUBLIC

<span id="_Toc380749867" class="anchor"></span>Table 193 — Definition of
(TPM_ALG_ID) TPMI_ALG_PUBLIC Type

| Values          | Comments                                          |
|-----------------|---------------------------------------------------|
| TPM_ALG\_!ALG.o | All object types                                  |
| \#TPM_RC_TYPE   | response code when a public type is not supported |

### Type-Specific Parameters

#### Description

The public area contains two fields (*parameters* and *unique*) that
vary by object type. The *parameters* field varies according to the
*type* of the object but the contents may be the same across multiple
instances of a particular *type*. The unique field format also varies
according to the type of the object and will also be unique for each
instance.

For a symmetric key (*type* == TPM_ALG_SYMCIPHER), HMAC key (*type* ==
TPM_ALG_KEYEDHASH) or data object (also, *type* == TPM_ALG_KEYEDHASH),
the contents of *unique* shall be computed from components of the
sensitive area of the object as follows:

unique ≔ **H**<sub>nameAlg</sub>(seedValue \|\| sensitive) 1

where

**H**<sub>nameAlg</sub>() the hash algorithm used to compute the Name of
the object

seedValue the digest-sized obfuscation value in the sensitive area of a
symmetric key or symmetric data object found in a
TPMT_SENSITIVE.seedValue.buffer

sensitive the secret key/data of the object in the
TPMT_SENSITIVE.sensitive.any.buffer

#### TPMU_PUBLIC_ID

This is the union of all values allowed in in the *<u>unique</u>* field
of a TPMT_PUBLIC.

NOTE The derive member cannot be unmarshaled in a TPMU_PUBLIC_ID. It is
placed in this structure so that the maximum size of a TPM2B_TEMPLATE
will be computed correctly.

<span id="_Toc380749868" class="anchor"></span>Table 194 — Definition of
TPMU_PUBLIC_ID Union \<IN/OUT\>

|           |                      |                   |                                                                                |
|-----------|----------------------|-------------------|--------------------------------------------------------------------------------|
| Parameter | Type                 | Selector          | Description                                                                    |
| keyedHash | TPM2B_DIGEST         | TPM_ALG_KEYEDHASH |                                                                                |
| sym       | TPM2B_DIGEST         | TPM_ALG_SYMCIPHER |                                                                                |
| rsa       | TPM2B_PUBLIC_KEY_RSA | TPM_ALG_RSA       |                                                                                |
| ecc       | TPMS_ECC_POINT       | TPM_ALG_ECC       |                                                                                |
| derive    | TPMS_DERIVE          |                   | only allowed for TPM2_CreateLoaded when *parentHandle* is a Derivation Parent. |

#### TPMS_KEYEDHASH_PARMS

This structure describes the parameters that would appear in the public
area of a KEYEDHASH object.

NOTE Although the names are the same, the types of the structures are
not the same as for asymmetric parameter lists.

<span id="_Toc380749869" class="anchor"></span>Table 195 — Definition of
TPMS_KEYEDHASH_PARMS Structure

|           |                        |                                                                                                                                                                                                 |
|-----------|------------------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Parameter | Type                   | Description                                                                                                                                                                                     |
| scheme    | TPMT_KEYEDHASH_SCHEME+ | Indicates the signing method used for a *keyedHash* signing object. This field also determines the size of the data field for a data object created with TPM2_Create() or TPM2_CreatePrimary(). |

#### TPMS_ASYM_PARMS

This structure contains the common public area parameters for an
asymmetric key. The first two parameters of the parameter definition
structures of an asymmetric key shall have the same two first
components.

NOTE The sign parameter may have a different type in order to allow
different schemes to be selected for each asymmetric type but the first
parameter of each scheme definition shall be a TPM_ALG_ID for a valid
signing scheme.

<span id="_Toc380749870" class="anchor"></span>Table 196 — Definition of
TPMS_ASYM_PARMS Structure \<\>

<table>
<colgroup>
<col style="width: 22%" />
<col style="width: 27%" />
<col style="width: 50%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Parameter</td>
<td>Type</td>
<td>Description</td>
</tr>
<tr class="even">
<td>symmetric</td>
<td>TPMT_SYM_DEF_OBJECT+</td>
<td><p>the companion symmetric algorithm for a restricted decryption key
and shall be set to a supported symmetric algorithm</p>
<p>This field is optional for keys that are not decryption keys and
shall be set to TPM_ALG_NULL if not used.</p></td>
</tr>
<tr class="odd">
<td>scheme</td>
<td>TPMT_ASYM_SCHEME+</td>
<td><p>for a key with the <em>sign</em> attribute SET, a valid signing
scheme for the key type</p>
<p>for a key with the <em>decrypt</em> attribute SET, a valid key
exchange protocol</p>
<p>for a key with sign and decrypt attributes, shall be
TPM_ALG_NULL</p></td>
</tr>
</tbody>
</table>

#### TPMS_RSA_PARMS

A TPM compatible with this specification and supporting RSA shall
support two primes and an *exponent* of zero. An exponent of zero
indicates that the exponent is the default of 2<sup>16</sup> + 1.
Support for other values is optional. Use of other exponents in
duplicated keys is not recommended because the resulting keys would not
be interoperable with other TPMs.

NOTE Implementations are not required to check that *exponent* is the
default exponent. They may fail to load the key if *exponent* is not
zero. The reference implementation allows the values listed in the
table.

<span id="_Toc380749871" class="anchor"></span>Table 197 — Definition of
{RSA} TPMS_RSA_PARMS Structure

<table>
<colgroup>
<col style="width: 25%" />
<col style="width: 26%" />
<col style="width: 48%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Parameter</td>
<td>Type</td>
<td>Description</td>
</tr>
<tr class="even">
<td>symmetric</td>
<td>TPMT_SYM_DEF_OBJECT+</td>
<td><p>for a restricted decryption key, shall be set to a supported
symmetric algorithm, key size, and mode.</p>
<p>if the key is not a restricted decryption key, this field shall be
set to TPM_ALG_NULL.</p></td>
</tr>
<tr class="odd">
<td>scheme</td>
<td>TPMT_RSA_SCHEME+</td>
<td><p>scheme.scheme shall be:</p>
<p>for an unrestricted signing key, either TPM_ALG_RSAPSS TPM_ALG_RSASSA
or TPM_ALG_NULL</p>
<p>for a restricted signing key, either TPM_ALG_RSAPSS or
TPM_ALG_RSASSA</p>
<p>for an unrestricted decryption key, TPM_ALG_RSAES, TPM_ALG_OAEP, or
TPM_ALG_NULL unless the object also has the <em>sign</em> attribute</p>
<p>for a restricted decryption key, TPM_ALG_NULL</p>
<p>NOTE When both sign and decrypt are SET, restricted shall be CLEAR
and scheme shall be TPM_ALG_NULL.</p></td>
</tr>
<tr class="even">
<td>keyBits</td>
<td>TPMI_RSA_KEY_BITS</td>
<td>number of bits in the public modulus</td>
</tr>
<tr class="odd">
<td>exponent</td>
<td>UINT32</td>
<td><p>the public exponent</p>
<p>A prime number greater than 2.</p></td>
</tr>
</tbody>
</table>

#### TPMS_ECC_PARMS

This structure contains the parameters for prime modulus ECC.

<span id="_Toc380749872" class="anchor"></span>Table 198 — Definition of
{ECC} TPMS_ECC_PARMS Structure

<table>
<colgroup>
<col style="width: 16%" />
<col style="width: 29%" />
<col style="width: 53%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Parameter</td>
<td>Type</td>
<td>Description</td>
</tr>
<tr class="even">
<td>symmetric</td>
<td>TPMT_SYM_DEF_OBJECT+</td>
<td><p>for a restricted decryption key, shall be set to a supported
symmetric algorithm, key size. and mode.</p>
<p>if the key is not a restricted decryption key, this field shall be
set to TPM_ALG_NULL.</p></td>
</tr>
<tr class="odd">
<td>scheme</td>
<td>TPMT_ECC_SCHEME+</td>
<td><p>If the <em>sign</em> attribute of the key is SET, then this shall
be a valid signing scheme.</p>
<p>NOTE If the <em>sign</em> parameter in <em>curveID</em> indicates a
mandatory scheme, then this field shall have the same value.</p>
<p>If the <em>decrypt</em> attribute of the key is SET, then this shall
be a valid key exchange scheme or TPM_ALG_NULL.</p>
<p>If the key is a Storage Key, then this field shall be
TPM_ALG_NULL.</p></td>
</tr>
<tr class="even">
<td>curveID</td>
<td>TPMI_ECC_CURVE</td>
<td>ECC curve ID</td>
</tr>
<tr class="odd">
<td>kdf</td>
<td>TPMT_KDF_SCHEME+</td>
<td><p>an optional key derivation scheme for generating a symmetric key
from a Z value</p>
<p>If the <em>kdf</em> parameter associated with <em>curveID</em> is not
TPM_ALG_NULL then this is required to be NULL.</p>
<p>NOTE There are currently no commands where this parameter has effect
and, in the reference code, this field needs to be set to
TPM_ALG_NULL.</p></td>
</tr>
</tbody>
</table>

#### TPMU_PUBLIC_PARMS

Table 199 defines the possible parameter definition structures that may
be contained in the public portion of a key. If the Object can be a
parent, the first field must be a TPMT_SYM_DEF_OBJECT. See 11.1.7.

<span id="_Ref247962010" class="anchor"></span>Table 199 — Definition of
TPMU_PUBLIC_PARMS Union \<IN/OUT\>

<table>
<colgroup>
<col style="width: 16%" />
<col style="width: 32%" />
<col style="width: 25%" />
<col style="width: 25%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Parameter</td>
<td>Type</td>
<td>Selector</td>
<td>Description<sup>(1)</sup></td>
</tr>
<tr class="even">
<td>keyedHashDetail</td>
<td>TPMS_KEYEDHASH_PARMS</td>
<td>TPM_ALG_KEYEDHASH</td>
<td>sign | decrypt | neither<sup>(2)</sup></td>
</tr>
<tr class="odd">
<td>symDetail</td>
<td>TPMS_SYMCIPHER_PARMS</td>
<td>TPM_ALG_SYMCIPHER</td>
<td>sign | decrypt | neither<sup>(2)</sup></td>
</tr>
<tr class="even">
<td>rsaDetail</td>
<td>TPMS_RSA_PARMS</td>
<td>TPM_ALG_RSA</td>
<td>decrypt + sign<sup>(2)</sup></td>
</tr>
<tr class="odd">
<td>eccDetail</td>
<td>TPMS_ECC_PARMS</td>
<td>TPM_ALG_ECC</td>
<td>decrypt + sign<sup>(2)</sup></td>
</tr>
<tr class="even">
<td>asymDetail</td>
<td>TPMS_ASYM_PARMS</td>
<td></td>
<td>common scheme structure for RSA and ECC keys</td>
</tr>
<tr class="odd">
<td colspan="4"><p>NOTES</p>
<p>1) Description column indicates which of TPMA_OBJECT.<em>decrypt</em>
or TPMA_OBJECT.<em>sign</em> may be set.</p>
<p>2) “+” indicates that both may be set but one shall be set. “|”
indicates the optional settings.</p></td>
</tr>
</tbody>
</table>

#### TPMT_PUBLIC_PARMS

This structure is used in TPM2_TestParms() to validate that a set of
algorithm parameters is supported by the TPM.

<span id="_Ref307337336" class="anchor"></span>Table 200 — Definition of
TPMT_PUBLIC_PARMS Structure

|                    |                   |                            |
|--------------------|-------------------|----------------------------|
| Parameter          | Type              | Description                |
| type               | TPMI_ALG_PUBLIC   | the algorithm to be tested |
| \[type\]parameters | TPMU_PUBLIC_PARMS | the algorithm details      |

### TPMT_PUBLIC

Table 201 defines the public area structure. The Name of the object is
*nameAlg* concatenated with the digest of this structure using
*nameAlg*.

<span id="_Ref246771133" class="anchor"></span>Table 201 — Definition of
TPMT_PUBLIC Structure

<table>
<colgroup>
<col style="width: 16%" />
<col style="width: 23%" />
<col style="width: 60%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Parameter</td>
<td>Type</td>
<td>Description</td>
</tr>
<tr class="even">
<td>type</td>
<td>TPMI_ALG_PUBLIC</td>
<td>“algorithm” associated with this object</td>
</tr>
<tr class="odd">
<td>nameAlg</td>
<td>+TPMI_ALG_HASH</td>
<td><p>algorithm used for computing the Name of the object</p>
<p>NOTE The "+" indicates that the instance of a TPMT_PUBLIC may have a
"+" to indicate that the <em>nameAlg</em> may be TPM_ALG_NULL.</p></td>
</tr>
<tr class="even">
<td>objectAttributes</td>
<td>TPMA_OBJECT</td>
<td>attributes that, along with <em>type</em>, determine the
manipulations of this object</td>
</tr>
<tr class="odd">
<td>authPolicy</td>
<td>TPM2B_DIGEST</td>
<td><p>optional policy for using this key</p>
<p>The policy is computed using the <em>nameAlg</em> of the object.</p>
<p>NOTE Shall be the Empty Policy if no authorization policy is
present.</p></td>
</tr>
<tr class="even">
<td>[type]parameters</td>
<td>TPMU_PUBLIC_PARMS</td>
<td>the algorithm or structure details</td>
</tr>
<tr class="odd">
<td>[type]unique</td>
<td>TPMU_PUBLIC_ID</td>
<td><p>the unique identifier of the structure</p>
<p>For an asymmetric key, this would be the public key.</p></td>
</tr>
</tbody>
</table>

### TPM2B_PUBLIC

This sized buffer is used to embed a TPMT_PUBLIC in a load command and
in any response that returns a public area.

<span id="_Ref214420523" class="anchor"></span>Table 202 — Definition of
TPM2B_PUBLIC Structure

<table>
<colgroup>
<col style="width: 32%" />
<col style="width: 16%" />
<col style="width: 50%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Parameter</td>
<td>Type</td>
<td>Description</td>
</tr>
<tr class="even">
<td>size=</td>
<td>UINT16</td>
<td><p>size of publicArea</p>
<p>NOTE The “=” will force the TPM to try to unmarshal a TPMT_PUBLIC and
check that the unmarshaled size matches the value of <em>size.</em> If
all the required fields of a TPMT_PUBLIC are not present, the TPM will
return an error (generally TPM_RC_SIZE) when attempting to unmarshal the
TPMT_PUBLIC.</p></td>
</tr>
<tr class="odd">
<td>publicArea</td>
<td>+TPMT_PUBLIC</td>
<td><p>the public area</p>
<p>NOTE The “+” indicates that the caller may specify that use of
TPM_ALG_NULL is allowed for <em>nameAlg.</em></p></td>
</tr>
</tbody>
</table>

### TPM2B_TEMPLATE

This sized buffer is used to embed a TPMT_TEMPLATE for
TPM2_CreateLoaded().

Unmarshaling of this structure is fairly complex due to requirements for
backwards compatibility. Unlike a TPM2B_PUBLIC, this structure is
unmarshaled as an array of bytes that is passed to the action code. The
action code will then unmarshal the embedded structure.

If the parent is not a derivation parent, this structure is unmarshaled
normally. If the parent is a derivation parent, *unique* is unmarshaled
as a TPMS_DERIVE structure (*label* and *context*). See 12.2.3.2.

<span id="_Ref428437970" class="anchor"></span>Table 203 — Definition of
TPM2B_TEMPLATE Structure

|                                      |        |                    |
|--------------------------------------|--------|--------------------|
| Parameter                            | Type   | Description        |
| size                                 | UINT16 | size of publicArea |
| buffer\[size\]{:sizeof(TPMT_PUBLIC)} | BYTE   | the public area    |

## Private Area Structures

### Introduction

The structures in 12.2.6 define the contents and construction of the
private portion of a TPM object. A TPM2B_PRIVATE along with a
TPM2B_PUBLIC are needed to describe a TPM object.

A TPM2B_PRIVATE area may be encrypted by different symmetric algorithms
or, in some cases, not encrypted at all.

### Sensitive Data Structures

#### Introduction

The structures in 12.3.2 define the presumptive internal representations
of the sensitive areas of the various entities. A TPM may store the
sensitive information in any desired format but when constructing a
TPM_PRIVATE, the formats in 12.3.2 shall be used.

#### TPM2B_PRIVATE_VENDOR_SPECIFIC

This structure is defined for coding purposes. For IO to the TPM, the
sensitive portion of the key will be in a canonical form. For an RSA
key, this will be one of the prime factors of the public modulus. After
loading, it is typical that other values will be computed so that
computations using the private key will not need to start with just one
prime factor. This structure can be used to store the results of such
vendor-specific calculations.

The value for PRIVATE_VENDOR_SPECIFIC_BYTES is determined by the vendor.

<span id="_Toc380749877" class="anchor"></span>Table 204 — Definition of
TPM2B_PRIVATE_VENDOR_SPECIFIC Structure

| Parameter                                      | Type   | Description |
|------------------------------------------------|--------|-------------|
| size                                           | UINT16 |             |
| buffer\[size\]{:PRIVATE_VENDOR_SPECIFIC_BYTES} | BYTE   |             |

#### TPMU_SENSITIVE_COMPOSITE

<span id="_Toc380749878" class="anchor"></span>Table 205 — Definition of
TPMU_SENSITIVE_COMPOSITE Union \<IN/OUT\>

|           |                               |                   |                                      |
|-----------|-------------------------------|-------------------|--------------------------------------|
| Parameter | Type                          | Selector          | Description                          |
| rsa       | TPM2B_PRIVATE_KEY_RSA         | TPM_ALG_RSA       | a prime factor of the public key     |
| ecc       | TPM2B_ECC_PARAMETER           | TPM_ALG_ECC       | the integer private key              |
| bits      | TPM2B_SENSITIVE_DATA          | TPM_ALG_KEYEDHASH | the private data                     |
| sym       | TPM2B_SYM_KEY                 | TPM_ALG_SYMCIPHER | the symmetric key                    |
| any       | TPM2B_PRIVATE_VENDOR_SPECIFIC |                   | vendor-specific size for key storage |

#### TPMT_SENSITIVE

*authValue* shall not be larger than the size of the digest produced by
the *nameAlg* of the object. *seedValue* shall be the size of the digest
produced by the *nameAlg* of the object.<span id="_Toc380749879"
class="anchor"></span>

Table 206 — Definition of TPMT_SENSITIVE Structure

<table>
<colgroup>
<col style="width: 22%" />
<col style="width: 31%" />
<col style="width: 45%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Parameter</td>
<td>Type</td>
<td>Description</td>
</tr>
<tr class="even">
<td>sensitiveType</td>
<td>TPMI_ALG_PUBLIC</td>
<td><p>identifier for the sensitive area</p>
<p>This shall be the same as the <em>type</em> parameter of the
associated public area.</p></td>
</tr>
<tr class="odd">
<td>authValue</td>
<td>TPM2B_AUTH</td>
<td><p>user authorization data</p>
<p>The authValue may be a zero-length string.</p></td>
</tr>
<tr class="even">
<td>seedValue</td>
<td>TPM2B_DIGEST</td>
<td>for a parent object, the optional protection seed; for other
objects, the obfuscation value</td>
</tr>
<tr class="odd">
<td>[sensitiveType]sensitive</td>
<td>TPMU_SENSITIVE_COMPOSITE</td>
<td>the type-specific private data</td>
</tr>
</tbody>
</table>

### TPM2B_SENSITIVE

The TPM2B_SENSITIVE structure is used as a parameter in
TPM2_LoadExternal(). It is an unencrypted sensitive area but it may be
encrypted using parameter encryption.

NOTE 1 When this structure is unmarshaled, the *sensitiveType*
determines what type of value is unmarshaled. Each value of
*sensitiveType* is associated with a TPM2B. It is the maximum size for
each of the TPM2B values that will determine if the unmarshal operation
is successful. Since there is no selector for the *any* or *vendor*
options for the union, the maximum input and output sizes for a
TPM2B_SENSITIVE are not affected by the sizes of those parameters.

NOTE 2 The unmarshaling function validates that *size* equals the size
of the value that is unmarshaled.

<span id="_Toc380749880" class="anchor"></span>Table 207 — Definition of
TPM2B_SENSITIVE Structure \<IN/OUT\>

|               |                |                                 |
|---------------|----------------|---------------------------------|
| Parameter     | Type           | Description                     |
| size          | UINT16         | size of the *private* structure |
| sensitiveArea | TPMT_SENSITIVE | an unencrypted sensitive area   |

### Encryption

A TPMS_SENSITIVE is the input to the encryption process. All
TPMS_ENCRYPT structures are CFB-encrypted using a key and Initialization
Vector (IV) that are derived from a seed value.

The method of generating the key and IV is described in “Protected
Storage” subclause “Symmetric Encryption.” in TPM 2.0 Part 1.

### Integrity

The integrity computation is used to ensure that a protected object is
not modified when stored in memory outside of the TPM.

The method of protecting the integrity of the sensitive area is
described in “Protected Storage” subclause “Integrity” in TPM 2.0 Part
1.

### \_PRIVATE

This structure is defined to size the contents of a TPM2B_PRIVATE. This
structure is not directly marshaled or unmarshaled.

For TPM2_Duplicate() and TPM2_Import(), the TPM2B_PRIVATE may contain
multiply encrypted data and two integrity values. In some cases, the
sensitive data is not encrypted and the integrity value is not present.

For TPM2_Load() and TPM2_Create(), *integrityInner* is always present.

If *integrityInner* is present, it and *sensitive* are encrypted as a
single block.

When an integrity value is not needed, it is not present and it is
<u>not</u> represented by an Empty Buffer.

<span id="_Ref227144447" class="anchor"></span>Table 208 — Definition of
\_PRIVATE Structure \<\>

|                |                 |                          |
|----------------|-----------------|--------------------------|
| Parameter      | Type            | Description              |
| integrityOuter | TPM2B_DIGEST    |                          |
| integrityInner | TPM2B_DIGEST    | could also be a TPM2B_IV |
| sensitive      | TPM2B_SENSITIVE | the sensitive area       |

### TPM2B_PRIVATE

The TPM2B_PRIVATE structure is used as a parameter in multiple commands
that create, load, and modify the sensitive area of an object.

When the TPM returns a TPM2B_PRIVATE structure, the TPM pads the
TPM2B_AUTH to its maximum size.

<span id="_Toc380749882" class="anchor"></span>Table 209 — Definition of
TPM2B_PRIVATE Structure \<IN/OUT\>

|                                     |        |                                 |
|-------------------------------------|--------|---------------------------------|
| Parameter                           | Type   | Description                     |
| size                                | UINT16 | size of the *private* structure |
| buffer\[size\] {:sizeof(\_PRIVATE)} | BYTE   | an encrypted private area       |

## Identity Object

### Description

An identity object is used to convey credential protection value (CV) to
a TPM that can load the object associated with the object. The CV is
encrypted to a storage key on the target TPM, and if the credential
integrity checks and the proper object is loaded in the TPM, then the
TPM will return the CV.

### TPMS\_ID_OBJECT

This structure is used for sizing the TPM2B_ID_OBJECT.

<span id="_Toc380749883" class="anchor"></span>Table 210 — Definition of
TPMS_ID_OBJECT Structure \<\>

<table>
<colgroup>
<col style="width: 21%" />
<col style="width: 24%" />
<col style="width: 54%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Parameter</td>
<td>Type</td>
<td>Description</td>
</tr>
<tr class="even">
<td>integrityHMAC</td>
<td>TPM2B_DIGEST</td>
<td>HMAC using the nameAlg of the storage key on the target TPM</td>
</tr>
<tr class="odd">
<td>encIdentity</td>
<td>TPM2B_DIGEST</td>
<td><p>credential protector information returned if name matches the
referenced object</p>
<p>All of the <em>encIdentity</em> is encrypted, including the size
field.</p>
<p>NOTE The TPM is not required to check that the size is not larger
than the digest of the <em>nameAlg</em>. However, if the size is larger,
the ID object may not be usable on a TPM that has no digest larger than
produced by <em>nameAlg</em>.</p></td>
</tr>
</tbody>
</table>

### TPM2B_ID_OBJECT

This structure is an output from TPM2_MakeCredential() and is an input
to TPM2_ActivateCredential().

<span id="_Toc380749884" class="anchor"></span>Table 211 — Definition of
TPM2B_ID_OBJECT Structure \<IN/OUT\>

|                                             |        |                                    |
|---------------------------------------------|--------|------------------------------------|
| Parameter                                   | Type   | Description                        |
| size                                        | UINT16 | size of the *credential* structure |
| credential\[size\]{:sizeof(TPMS_ID_OBJECT)} | BYTE   | an encrypted credential area       |

# NV Storage Structures

## TPM_NV_INDEX

A TPM_NV_INDEX is used to reference a defined location in NV memory. The
format of the Index is changed from TPM 1.2 in order to include the
Index in the reserved handle space. Handles in this range use the digest
of the public area of the Index as the Name of the entity in
authorization computations

The 32-bit TPM 1.2 NV Index format is shown in Figure 4. In order to
allow the Index to fit into the 24 bits available in the reserved handle
space, the Index value format is changed as shown in Figure 5.

<table>
<colgroup>
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
</colgroup>
<tbody>
<tr class="odd">
<td><p>3</p>
<p>1</p></td>
<td><p>3</p>
<p>0</p></td>
<td><p>2</p>
<p>9</p></td>
<td><p>2</p>
<p>8</p></td>
<td><p>2</p>
<p>7</p></td>
<td><p>2</p>
<p>6</p></td>
<td><p>2</p>
<p>5</p></td>
<td><p>2</p>
<p>4</p></td>
<td><p>2</p>
<p>3</p></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td><p>1</p>
<p>6</p></td>
<td><p>1</p>
<p>5</p></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td><p>0</p>
<p>0</p></td>
</tr>
<tr class="even">
<td>T</td>
<td>P</td>
<td>U</td>
<td>D</td>
<td colspan="4">reserved</td>
<td colspan="8">Purview</td>
<td colspan="16">Index</td>
</tr>
</tbody>
</table>

<span id="_Ref235403879" class="anchor"></span>Figure 4 — TPM 1.2
TPM_NV_INDEX

<table style="width:100%;">
<colgroup>
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 4%" />
<col style="width: 2%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
<col style="width: 3%" />
</colgroup>
<tbody>
<tr class="odd">
<td><p>3</p>
<p>1</p></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td><p>2</p>
<p>4</p></td>
<td><p>2</p>
<p>3</p></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td></td>
<td><p>0</p>
<p>0</p></td>
</tr>
<tr class="even">
<td colspan="8">TPM_HT_NV_INDEX</td>
<td colspan="22">Index</td>
</tr>
</tbody>
</table>

<span id="_Ref235403989" class="anchor"></span>Figure 5 — TPM 2.0
TPM_NV_INDEX

NOTE This TPM_NV_INDEX format does not retain the Purview field and the
D bit is not a part of an Index handle as in TPM 1.2. The
TPMA_NV_PLATFORMCREATE attribute is a property of an Index that provides
functionality similar to the D bit.

A valid Index handle will have an MSO of TPM_HT_NV_INDEX.

NOTE This structure is not used. It is defined here to indicate how the
fields of the handle are assigned. The exemplary unmarshaling code
unmarshals a TPM_HANDLE and validates that it is in the range for a
TPM_NV_INDEX.

<span id="_Toc380749885" class="anchor"></span>Table 212 — Definition of
(UINT32) TPM_NV_INDEX Bits \<\>

|       |       |                                                                 |
|-------|-------|-----------------------------------------------------------------|
| Bit   | Name  | Definition                                                      |
| 23:00 | index | The Index of the NV location                                    |
| 31:24 | RH_NV | constant value of TPM_HT_NV_INDEX indicating the NV Index range |

Some prior versions of this specification contained a table here
(Options for space Field of TPM_NV_INDEX) that assigned subsets of the
index field to different entities. Since this assignment was a
convention and not an architectural element of the TPM, the table was
removed and the information is now contained in a registry document that
is maintained by the TCG.<span id="_Toc432512476" class="anchor"></span>

## TPM_NT

This table lists the values of the TPM_NT field of a TPMA_NV. See Table
215 for usage.

<span id="_Ref443726496" class="anchor"></span>Table 213 — Definition of
TPM_NT Constants

| Name            | Value | Description                                                                                                                                                  |
|-----------------|-------|--------------------------------------------------------------------------------------------------------------------------------------------------------------|
| TPM_NT_ORDINARY | 0x0   | Ordinary – contains data that is opaque to the TPM that can only be modified using TPM2_NV_Write().                                                          |
| TPM_NT_COUNTER  | 0x1   | Counter – contains an 8-octet value that is to be used as a counter and can only be modified with TPM2_NV_Increment()                                        |
| TPM_NT_BITS     | 0x2   | Bit Field – contains an 8-octet value to be used as a bit field and can only be modified with TPM2_NV_SetBits().                                             |
| TPM_NT_EXTEND   | 0x4   | Extend – contains a digest-sized value used like a PCR. The Index can only be modified using TPM2_NV_Extend(). The extend will use the nameAlg of the Index. |
| TPM_NT_PIN_FAIL | 0x8   | PIN Fail - contains *pinCount* that increments on a PIN authorization failure and a *pinLimit*                                                               |
| TPM_NT_PIN_PASS | 0x9   | PIN Pass - contains *pinCount* that increments on a PIN authorization success and a *pinLimit*                                                               |

All other TPM_NT values are reserved and TPM2_NV_DefineSpace() returns
TPM_RC_ATTRIBUTES.

NOTE 1 These values are compatible with previous versions of this
specification, which used a bit map for this field.

NOTE 2 This field described by Table 213 is 4 bits.

## TPMS_NV_PIN_COUNTER_PARAMETERS

This is the data that can be written to and read from a TPM_NT_PIN_PASS
or TPM_NT_PIN_FAIL non-volatile index. *pinCount* is the most
significant octets. *pinLimit* is the least significant
octets.<span id="_Toc432512694" class="anchor"></span>

Table 214 — Definition of TPMS_NV_PIN_COUNTER_PARAMETERS Structure

|           |        |                                                                                                                                                                                                                                  |
|-----------|--------|----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| Parameter | Type   | Description                                                                                                                                                                                                                      |
| pinCount  | UINT32 | This counter shows the current number of successful authValue authorization attempts to access a TPM_NT_PIN_PASS index or the current number of unsuccessful authValue authorization attempts to access a TPM_NT_PIN_FAIL index. |
| pinLimit  | UINT32 | This threshold is the value of *pinCount* at which the authValue authorization of the host TPM_NT_PIN_PASS or TPM_NT_PIN_FAIL index is locked out.                                                                               |

## TPMA_NV (NV Index Attributes)

This structure allows the TPM to keep track of the data and permissions
to manipulate an NV Index.

The platform controls (TPMA_NV_PPWRITE and TPMA_NV_PPREAD) and owner
controls (TPMA_NV_OWNERWRITE and TPMA_NV_OWNERREAD) give the platform
and owner access to NV Indexes using Platform Authorization or Owner
Authorization rather than the *authValue* or *authPolicy* of the Index.

If access to an NV Index is to be restricted based on PCR, then an
appropriate *authPolicy* shall be provided.

NOTE *platformAuth* or *ownerAuth* can be provided in any type of
authorization session or as a password.

If TPMA_NV_AUTHREAD is SET, then the Index may be read if the Index
*authValue* is provided. If TPMA_NV_POLICYREAD is SET, then the Index
may be read if the Index *authPolicy* is satisfied.

At least one of TPMA_NV_PPREAD, TPMA_NV_OWNERREAD, TPMA_NV_AUTHREAD, or
TPMA_NV_POLICYREAD shall be SET.

If TPMA_NV_AUTHWRITE is SET, then the Index may be written if the Index
*authValue* is provided. If TPMA_NV_POLICYWRITE is SET, then the Index
may be written if the Index *authPolicy* is satisfied.

At least one of TPMA_NV_PPWRITE, TPMA_NV_OWNERWRITE TPMA_NV_AUTHWRITE,
or TPMA_NV_POLICYWRITE shall be SET.

If TPMA_NV_WRITELOCKED is SET, then the Index may not be written. If
TPMA_NV_WRITEDEFINE is SET, TPMA_NV_WRITELOCKED may not be CLEAR except
by deleting and redefining the Index. If TPMA_NV_WRITEDEFINE is CLEAR,
then TPMA_NV_WRITELOCKED will be CLEAR on the next
TPM2_Startup(TPM_SU_CLEAR).

NOTE If TPMA_NV_WRITELOCKED is SET, but TPMA_NV_WRITTEN is CLEAR, then
TPMA_NV_WRITELOCKED is CLEAR by TPM Reset or TPM Restart. This action
occurs even if the TPMA_NV_WRITEDEFINE attribute is SET. This action
prevents an NV Index from being defined that can never be written, and
permits a use case where an Index is defined, but the user wants to
prohibit writes until after a reboot.

If TPMA_NV_READLOCKED is SET, then the Index may not be read.
TPMA_NV_READLOCKED will be CLEAR on the next TPM2_Startup(TPM_SU_CLEAR).

NOTE The TPM is expected to maintain indicators to indicate that the
Index is temporarily locked. The state of these indicators is reported
in the TPMA_NV_READLOCKED and TPMA_NV_WRITELOCKED attributes.

If the TPM_NT is TPM_NT_EXTEND, then writes to the Index will cause an
update of the Index using the extend operation with the *nameAlg* used
to create the digest.

If TPM_NT is TPM_NT_PIN_FAIL, TPMA_NV_NO_DA must be SET. This removes
ambiguity over which Dictionary Attack defense protects a
TPM_NV_PIN_FAIL's *authValue*.

When the Index is created (TPM2_NV_DefineSpace()), TPMA_NV_WRITELOCKED,
TPMA_NV_READLOCKED, and TPMA_NV_WRITTEN shall all be CLEAR in the
parameter that defines the attributes of the created Index.

<span id="_Ref402873547" class="anchor"></span>Table 215 — Definition of
(UINT32) TPMA_NV Bits

<table>
<colgroup>
<col style="width: 7%" />
<col style="width: 30%" />
<col style="width: 61%" />
</colgroup>
<thead>
<tr class="header">
<th>Bit</th>
<th>Name</th>
<th>Description</th>
</tr>
</thead>
<tbody>
<tr class="odd">
<td>0</td>
<td>TPMA_NV_PPWRITE</td>
<td><p><strong>SET (1):</strong> The Index data can be written if
Platform Authorization is provided.</p>
<p><strong>CLEAR (0):</strong> Writing of the Index data cannot be
authorized with Platform Authorization.</p></td>
</tr>
<tr class="even">
<td>1</td>
<td>TPMA_NV_OWNERWRITE</td>
<td><p><strong>SET (1):</strong> The Index data can be written if Owner
Authorization is provided.</p>
<p><strong>CLEAR (0):</strong> Writing of the Index data cannot be
authorized with Owner Authorization.</p></td>
</tr>
<tr class="odd">
<td>2</td>
<td>TPMA_NV_AUTHWRITE</td>
<td><p><strong>SET (1):</strong> Authorizations to change the Index
contents that require USER role may be provided with an HMAC session or
password.</p>
<p><strong>CLEAR (0):</strong> Authorizations to change the Index
contents that require USER role may not be provided with an HMAC session
or password.</p></td>
</tr>
<tr class="even">
<td>3</td>
<td>TPMA_NV_POLICYWRITE</td>
<td><p><strong>SET (1):</strong> Authorizations to change the Index
contents that require USER role may be provided with a policy
session.</p>
<p><strong>CLEAR (0):</strong> Authorizations to change the Index
contents that require USER role may not be provided with a policy
session.</p>
<p>NOTE TPM2_NV_ChangeAuth() always requires that authorization be
provided in a policy session.</p></td>
</tr>
<tr class="odd">
<td>7:4</td>
<td>TPM_NT</td>
<td><p>The type of the index.</p>
<p>NOTE A TPM is not required to support all TPM_NT values</p></td>
</tr>
<tr class="even">
<td>9:8</td>
<td>Reserved</td>
<td><p>shall be zero</p>
<p>reserved for future use</p></td>
</tr>
<tr class="odd">
<td>10</td>
<td>TPMA_NV_POLICY_DELETE</td>
<td><p><strong>SET (</strong>1<strong>):</strong> Index may not be
deleted unless the <em>authPolicy</em> is satisfied using
TPM2_NV_UndefineSpaceSpecial().</p>
<p><strong>CLEAR (0):</strong> Index may be deleted with proper platform
or owner authorization using TPM2_NV_UndefineSpace().</p>
<p>NOTE An Index with this attribute and a policy that cannot be
satisfied (e.g., an Empty Policy) cannot be deleted.</p></td>
</tr>
<tr class="even">
<td>11</td>
<td>TPMA_NV_WRITELOCKED</td>
<td><p><strong>SET (1):</strong> Index cannot be written.</p>
<p><strong>CLEAR (0):</strong> Index can be written.</p></td>
</tr>
<tr class="odd">
<td>12</td>
<td>TPMA_NV_WRITEALL</td>
<td><p><strong>SET (1):</strong> A partial write of the Index data is
not allowed. The write size shall match the defined space size.</p>
<p><strong>CLEAR (0):</strong> Partial writes are allowed. This setting
is required if the .<em>dataSize</em> of the Index is larger than
NV_MAX_BUFFER_SIZE for the implementation.</p></td>
</tr>
<tr class="even">
<td>13</td>
<td>TPMA_NV_WRITEDEFINE</td>
<td><p><strong>SET (1):</strong> TPM2_NV_WriteLock() may be used to
prevent further writes to this location.</p>
<p><strong>CLEAR (0):</strong> TPM2_NV_WriteLock() does not block
subsequent writes if TPMA_NV_WRITE_STCLEAR is also CLEAR.</p></td>
</tr>
<tr class="odd">
<td>14</td>
<td>TPMA_NV_WRITE_STCLEAR</td>
<td><p><strong>SET (1):</strong> TPM2_NV_WriteLock() may be used to
prevent further writes to this location until the next TPM Reset or TPM
Restart.</p>
<p><strong>CLEAR (0):</strong> TPM2_NV_WriteLock() does not block
subsequent writes if TPMA_NV_WRITEDEFINE is also CLEAR.</p></td>
</tr>
<tr class="even">
<td>15</td>
<td>TPMA_NV_GLOBALLOCK</td>
<td><p><strong>SET (1):</strong> If TPM2_NV_GlobalWriteLock() is
successful, TPMA_NV_WRITELOCKED is set.</p>
<p><strong>CLEAR (0):</strong> TPM2_NV_GlobalWriteLock() has no effect
on the writing of the data at this Index.</p></td>
</tr>
<tr class="odd">
<td>16</td>
<td>TPMA_NV_PPREAD</td>
<td><p><strong>SET (1):</strong> The Index data can be read if Platform
Authorization is provided.</p>
<p><strong>CLEAR (0):</strong> Reading of the Index data cannot be
authorized with Platform Authorization.</p></td>
</tr>
<tr class="even">
<td>17</td>
<td>TPMA_NV_OWNERREAD</td>
<td><p><strong>SET (1):</strong> The Index data can be read if Owner
Authorization is provided.</p>
<p><strong>CLEAR (0):</strong> Reading of the Index data cannot be
authorized with Owner Authorization.</p></td>
</tr>
<tr class="odd">
<td>18</td>
<td>TPMA_NV_AUTHREAD</td>
<td><p><strong>SET (1):</strong> The Index data may be read if the
<em>authValue</em> is provided.</p>
<p><strong>CLEAR (0):</strong> Reading of the Index data cannot be
authorized with the Index <em>authValue</em>.</p></td>
</tr>
<tr class="even">
<td>19</td>
<td>TPMA_NV_POLICYREAD</td>
<td><p><strong>SET (1):</strong> The Index data may be read if the
<em>authPolicy</em> is satisfied.</p>
<p><strong>CLEAR (0):</strong> Reading of the Index data cannot be
authorized with the Index <em>authPolicy</em>.</p></td>
</tr>
<tr class="odd">
<td>24:20</td>
<td>Reserved</td>
<td><p>shall be zero</p>
<p>reserved for future use</p></td>
</tr>
<tr class="even">
<td>25</td>
<td>TPMA_NV_NO_DA</td>
<td><p><strong>SET (1):</strong> Authorization failures of the Index do
not affect the DA logic and authorization of the Index is not blocked
when the TPM is in Lockout mode.</p>
<p><strong>CLEAR (0):</strong> Authorization failures of the Index will
increment the authorization failure counter and authorizations of this
Index are not allowed when the TPM is in Lockout mode.</p></td>
</tr>
<tr class="odd">
<td>26</td>
<td>TPMA_NV_ORDERLY</td>
<td><p><strong>SET (1):</strong> NV Index state is only required to be
saved when the TPM performs an orderly shutdown (TPM2_Shutdown()).</p>
<p><strong>CLEAR (0):</strong> NV Index state is required to be
persistent after the command to update the Index completes successfully
(that is, the NV update is synchronous with the update
command).</p></td>
</tr>
<tr class="even">
<td>27</td>
<td>TPMA_NV_CLEAR_STCLEAR</td>
<td><p><strong>SET (1):</strong> TPMA_NV_WRITTEN for the Index is CLEAR
by TPM Reset or TPM Restart.</p>
<p><strong>CLEAR (0):</strong> TPMA_NV_WRITTEN is not changed by TPM
Restart.</p>
<p>NOTE This attribute may only be SET if TPM_NT is not
TPM_NT_COUNTER.</p></td>
</tr>
<tr class="odd">
<td>28</td>
<td>TPMA_NV_READLOCKED</td>
<td><p><strong>SET (1):</strong> Reads of the Index are blocked until
the next TPM Reset or TPM Restart.</p>
<p><strong>CLEAR (0):</strong> Reads of the Index are allowed if proper
authorization is provided.</p></td>
</tr>
<tr class="even">
<td>29</td>
<td>TPMA_NV_WRITTEN</td>
<td><p><strong>SET (1):</strong> Index has been written.</p>
<p><strong>CLEAR (0):</strong> Index has not been written.</p></td>
</tr>
<tr class="odd">
<td>30</td>
<td>TPMA_NV_PLATFORMCREATE</td>
<td><p><strong>SET (1):</strong> This Index may be undefined with
Platform Authorization but not with Owner Authorization.</p>
<p><strong>CLEAR (0):</strong> This Index may be undefined using Owner
Authorization but not with Platform Authorization.</p>
<p>The TPM will validate that this attribute is SET when the Index is
defined using Platform Authorization and will validate that this
attribute is CLEAR when the Index is defined using Owner
Authorization.</p></td>
</tr>
<tr class="even">
<td>31</td>
<td>TPMA_NV_READ_STCLEAR</td>
<td><p><strong>SET (1):</strong> TPM2_NV_ReadLock() may be used to SET
TPMA_NV_READLOCKED for this Index.</p>
<p><strong>CLEAR (0):</strong> TPM2_NV_ReadLock() has no effect on this
Index.</p></td>
</tr>
</tbody>
</table>

## TPMS_NV_PUBLIC

This structure describes an NV Index.

<span id="_Toc380749887" class="anchor"></span>Table 216 — Definition of
TPMS_NV_PUBLIC Structure

<table>
<colgroup>
<col style="width: 32%" />
<col style="width: 23%" />
<col style="width: 44%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Name</td>
<td>Type</td>
<td>Description</td>
</tr>
<tr class="even">
<td>nvIndex</td>
<td>TPMI_RH_NV_INDEX</td>
<td>the handle of the data area</td>
</tr>
<tr class="odd">
<td>nameAlg</td>
<td>TPMI_ALG_HASH</td>
<td>hash algorithm used to compute the name of the Index and used for
the <em>authPolicy.</em> For an extend index, the hash algorithm used
for the extend.</td>
</tr>
<tr class="even">
<td>attributes</td>
<td>TPMA_NV</td>
<td>the Index attributes</td>
</tr>
<tr class="odd">
<td>authPolicy</td>
<td>TPM2B_DIGEST</td>
<td><p>optional access policy for the Index</p>
<p>The policy is computed using the <em>nameAlg</em></p>
<p>NOTE Shall be the Empty Policy if no authorization policy is
present.</p></td>
</tr>
<tr class="even">
<td>dataSize{:MAX_NV_INDEX_SIZE}</td>
<td>UINT16</td>
<td><p>the size of the data area</p>
<p>The maximum size is implementation-dependent. The minimum maximum
size is platform-specific.</p></td>
</tr>
<tr class="odd">
<td>#TPM_RC_SIZE</td>
<td></td>
<td>response code returned when the requested size is too large for the
implementation</td>
</tr>
</tbody>
</table>

## TPM2B_NV_PUBLIC

This structure is used when a TPMS_NV_PUBLIC is sent on the TPM
interface.

<span id="_Toc380749888" class="anchor"></span>Table 217 — Definition of
TPM2B_NV_PUBLIC Structure

|          |                |                    |
|----------|----------------|--------------------|
| Name     | Type           | Description        |
| size=    | UINT16         | size of *nvPublic* |
| nvPublic | TPMS_NV_PUBLIC | the public area    |

# Context Data

## Introduction

Clause 14 defines the contents of the TPM2_ContextSave() response
parameters and TPM2_ContextLoad() command parameters.

If the parameters provided by the caller in TPM2_ContextLoad() do not
match the values returned by the TPM when the context was saved, the
integrity check of the TPM2B_CONTEXT will fail and the object or session
will not be loaded.

## TPM2B_CONTEXT_SENSITIVE

This structure holds the object or session context data. When saved, the
full structure is encrypted.

NOTE This is an informative table that is included in the specification
only to allow calculation of the maximum size for TPM2B_CONTEXT_DATA.

<span id="_Toc380749889" class="anchor"></span>Table 218 — Definition of
TPM2B_CONTEXT_SENSITIVE Structure \<IN/OUT\>

|                                   |        |                    |
|-----------------------------------|--------|--------------------|
| Parameter                         | Type   | Description        |
| size                              | UINT16 |                    |
| buffer\[size\]{:MAX_CONTEXT_SIZE} | BYTE   | the sensitive data |

## TPMS_CONTEXT_DATA

This structure holds the integrity value and the encrypted data for a
context.

NOTE This is an informative table that is included in the specification
only to allow calculation of the maximum size for TPM2B_CONTEXT_DATA.

<span id="_Toc380749890" class="anchor"></span>Table 219 — Definition of
TPMS_CONTEXT_DATA Structure \<IN/OUT\>

|           |                         |                     |
|-----------|-------------------------|---------------------|
| Parameter | Type                    | Description         |
| integrity | TPM2B_DIGEST            | the integrity value |
| encrypted | TPM2B_CONTEXT_SENSITIVE | the sensitive area  |

## TPM2B_CONTEXT_DATA

This structure is used in a TPMS_CONTEXT.

<span id="_Toc380749891" class="anchor"></span>Table 220 — Definition of
TPM2B_CONTEXT_DATA Structure \<IN/OUT\>

|                                             |        |             |
|---------------------------------------------|--------|-------------|
| Parameter                                   | Type   | Description |
| size                                        | UINT16 |             |
| buffer\[size\] {:sizeof(TPMS_CONTEXT_DATA)} | BYTE   |             |

## TPMS_CONTEXT

This structure is used in TPM2_ContextLoad() and TPM2_ContextSave(). If
the values of the TPMS_CONTEXT structure in TPM2_ContextLoad() are not
the same as the values when the context was saved (TPM2_ContextSave()),
then the TPM shall not load the context.

Saved object contexts shall not be loaded as long as the associated
hierarchy is disabled.

Saved object contexts are invalidated when the Primary Seed of their
hierarchy changes. Objects in the Endorsement hierarchy are invalidated
when either the EPS or SPS is changed.

When an object has the *stClear* attribute, it shall not be possible to
reload the context or any descendant object after a TPM Reset or TPM
Restart.

NOTE 1 The reference implementation prevents reloads after TPM Restart
by including the current value of a *clearCount* in the saved object
context. When an object is loaded, this value is compared with the
current value of the *clearCount* if the object has the *stClear*
attribute. If the values are not the same, then the object cannot be
loaded.

A sequence value is contained within *contextBlob*, the
integrity-protected part of the saved context. The sequence value is
repeated in the *sequence* parameter of the TPMS_CONTEXT structure. The
*sequence* parameter, along with other values, is used in the generation
the protection values of the context.

NOTE 2 The reference implementation prepends the *sequence* value to the
*contextBlob* before, for example, the SESSION structure for sessions or
the OBJECT structure for transient objects.

If the integrity value of the context is valid, but the *sequence* value
of the decrypted context does not match the value in the *sequence*
parameter, then TPM shall enter the failure mode because this is
indicative of a specific type of attack on the context values.

NOTE 3 If the integrity value is correct, but the decryption fails and
produces the wrong value for sequence, this implies that either the TPM
is faulty or an external entity is able to forge an integrity value for
the context but they have insufficient information to know the
encryption key of the context. Since the TPM generated the valid
context, then there is no reason for the sequence value in the context
to be decrypted incorrectly other than the TPM is faulty or the TPM is
under attack. In either case, it is appropriate for the TPM to enter
failure more.

<span id="_Toc380749892" class="anchor"></span>Table 221 — Definition of
TPMS_CONTEXT Structure

<table>
<colgroup>
<col style="width: 21%" />
<col style="width: 32%" />
<col style="width: 46%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Name</td>
<td>Type</td>
<td>Description</td>
</tr>
<tr class="even">
<td>sequence</td>
<td>UINT64</td>
<td><p>the sequence number of the context</p>
<p>NOTE Transient object contexts and session contexts used different
counters.</p></td>
</tr>
<tr class="odd">
<td>savedHandle</td>
<td>TPMI_DH_SAVED</td>
<td>a handle indicating if the context is a session, object, or sequence
object (see Table 222 — Context Handle Values</td>
</tr>
<tr class="even">
<td>hierarchy</td>
<td>TPMI_RH_HIERARCHY+</td>
<td>the hierarchy of the context</td>
</tr>
<tr class="odd">
<td>contextBlob</td>
<td>TPM2B_CONTEXT_DATA</td>
<td>the context data and integrity HMAC</td>
</tr>
</tbody>
</table>

## Parameters of TPMS_CONTEXT

### *sequence*

The *sequence* parameter is used to differentiate the contexts and to
allow the TPM to create a different encryption key for each context.
Objects and sessions use different sequence counters. The sequence
counter for objects (transient and sequence) is incremented when an
object context is saved, and the sequence counter for sessions
increments when a session is created or when it is loaded
(TPM2_ContextLoad()). The session sequence number is the *contextID*
counter.

For a session, the sequence number also allows the TRM to find the
“older” contexts so that they may be refreshed if the *contextID* are
too widely separated.

If an input value for *sequence* is larger than the value used in any
saved context, the TPM shall return an error (TPM_RC_VALUE) and do no
additional processing of the context.

If the context is a session context and the input value for sequence is
less than the current value of *contextID* minus the maximum range for
sessions, the TPM shall return an error (TPM_RC_VALUE) and do no
additional processing of the context.

### *savedHandle*

For a session, this is the handle that was assigned to the session when
it was created. For a transient object, the handle will have one of the
values shown in Table 222.

If the handle type for *savedHandle* is TPM_HT_TRANSIENT, then the low
order bits are used to differentiate static objects from sequence
objects.

If an input value for handle is outside of the range of values used by
the TPM, the TPM shall return an error (TPM_RC_VALUE) and do no
additional processing of the context.

<span id="_Ref307386359" class="anchor"></span>Table 222 — Context
Handle Values

|            |                                                     |
|------------|-----------------------------------------------------|
| Value      | Description                                         |
| 0x02xxxxxx | an HMAC session context                             |
| 0x03xxxxxx | a policy session context                            |
| 0x80000000 | an ordinary transient object                        |
| 0x80000001 | a sequence object                                   |
| 0x80000002 | a transient object with the *stClear* attribute SET |

### *hierarchy*

This is the hierarchy (TPMI_RH_HIERARCHY) for the saved context and
determines the proof value used in the construction of the encryption
and integrity values for the context. For session and sequence contexts,
the hierarchy is TPM_RC_NULL. The hierarchy for a transient object may
be TPM_RH_NULL but it is not required.

## Context Protection

### Context Integrity

The integrity of the context blob is protected by an HMAC. The integrity
value is constructed such that changes to the component values will
invalidate the context and prevent it from being loaded.

Previously saved contexts for objects in the Platform hierarchy shall
not be loadable after the PPS is changed.

Previously saved contexts for objects in the Storage hierarchy shall not
be loadable after the SPS is changed.

Previously saved contexts for objects in the Endorsement hierarchy shall
not be loadable after either the EPS or SPS is changed.

Previously saved sessions shall not be loadable after the SPS changes.

Previously saved contexts for objects that have their *stClear*
attribute SET shall not be loadable after a TPM Restart. If a Storage
Key has its *stClear* attribute SET, the descendants of this key shall
not be loadable after TPM Restart.

Previously saved contexts for a session and objects shall not be
loadable after a TPM Reset.

A saved context shall not be loaded if its HMAC is not valid. The
equation for computing the HMAC for a context is found in “Context
Integrity Protection” in TPM 2.0 Part 1.

### Context Confidentiality

The context data of sessions and objects shall be protected by symmetric
encryption using CFB. The method for computing the IV and encryption key
is found in “Context Confidentiality Protection” in TPM 2.0 Part 1.

# Creation Data

## TPMS_CREATION_DATA

This structure provides information relating to the creation environment
for the object. The creation data includes the parent Name, parent
Qualified Name, and the digest of selected PCR. These values represent
the environment in which the object was created. Creation data allows a
relying party to determine if an object was created when some
appropriate protections were present.

When the object is created, the structure shown in Table 223 is
generated and a ticket is computed over this data.

If the parent is a permanent handle (TPM_RH_OWNER, TPM_RH_PLATFORM,
TPM_RH_ENDORSEMENT, or TPM_RH_NULL), then *parentName* and
*parentQualifiedName* will be set to the parent handle value and
*parentNameAlg* will be TPM_ALG_NULL.

<span id="_Ref236972116" class="anchor"></span>Table 223 — Definition of
TPMS_CREATION_DATA Structure \<OUT\>

<table>
<colgroup>
<col style="width: 20%" />
<col style="width: 25%" />
<col style="width: 54%" />
</colgroup>
<tbody>
<tr class="odd">
<td>Parameter</td>
<td>Type</td>
<td>Description</td>
</tr>
<tr class="even">
<td>pcrSelect</td>
<td>TPML_PCR_SELECTION</td>
<td>list indicating the PCR included in <em>pcrDigest</em></td>
</tr>
<tr class="odd">
<td>pcrDigest</td>
<td>TPM2B_DIGEST</td>
<td><p>digest of the selected PCR using <em>nameAlg</em> of the object
for which this structure is being created</p>
<p><em>pcrDigest.size</em> shall be zero if the <em>pcrSelect</em> list
is empty.</p></td>
</tr>
<tr class="even">
<td>locality</td>
<td>TPMA_LOCALITY</td>
<td>the locality at which the object was created</td>
</tr>
<tr class="odd">
<td>parentNameAlg</td>
<td>TPM_ALG_ID</td>
<td><em>nameAlg</em> of the parent</td>
</tr>
<tr class="even">
<td>parentName</td>
<td>TPM2B_NAME</td>
<td><p>Name of the parent at time of creation</p>
<p>The size will match digest size associated with
<em>parentNameAlg</em> unless it is TPM_ALG_NULL, in which case the size
will be 4 and <em>parentName</em> will be the hierarchy handle.</p></td>
</tr>
<tr class="odd">
<td>parentQualifiedName</td>
<td>TPM2B_NAME</td>
<td><p>Qualified Name of the parent at the time of creation</p>
<p>Size is the same as <em>parentName.</em></p></td>
</tr>
<tr class="even">
<td>outsideInfo</td>
<td>TPM2B_DATA</td>
<td><p>association with additional information added by the key
creator</p>
<p>This will be the contents of the <em>outsideInfo</em> parameter in
TPM2_Create() or TPM2_CreatePrimary().</p></td>
</tr>
</tbody>
</table>

## TPM2B_CREATION_DATA

This structure is created by TPM2_Create() and TPM2_CreatePrimary(). It
is never entered into the TPM and never has a size of zero.

<span id="_Toc380749895" class="anchor"></span>Table 224 — Definition of
TPM2B_CREATION_DATA Structure \<OUT\>

|              |                    |                           |
|--------------|--------------------|---------------------------|
| Parameter    | Type               | Description               |
| size=        | UINT16             | size of the creation data |
| creationData | TPMS_CREATION_DATA |                           |

# Attached Component Structures

## TPM_AT

These constants are used in TPM2_AC_GetCapability() to indicate the
first tagged value returned from an attached component.

TPM_AT values of 0x80000000 through 0xFFFFFFFF are reserved for
vendor-specific values.

<span id="_Ref473897953" class="anchor"></span>Table 225 — Definition of
(UINT32) TPM_AT Constants

| Name         | Value      | Comments                                                                                                              |
|--------------|------------|-----------------------------------------------------------------------------------------------------------------------|
| TPM_AT_ANY   | 0x00000000 | in a command, a non-specific request for AC information; in a response, indicates that *outputData* is not meaningful |
| TPM_AT_ERROR | 0x00000001 | indicates a TCG defined, device-specific error                                                                        |
| TPM_AT_PV1   | 0x00000002 | indicates the most significant 32 bits of a pairing value for the AC                                                  |
| TPM_AT_VEND  | 0x80000000 | value added to a TPM_AT to indicate a vendor-specific tag value                                                       |

## TPM_AE

These constants are the TCG-defined error values returned by an AC.

<span id="_Toc516155335" class="anchor"></span>Table 226 — Definition of
(UINT32) TPM_AE Constants \<OUT\>

| Name        | Value      | Comments                                                                                                              |
|-------------|------------|-----------------------------------------------------------------------------------------------------------------------|
| TPM_AE_NONE | 0x00000000 | in a command, a non-specific request for AC information; in a response, indicates that *outputData* is not meaningful |

## TPMS_AC_OUTPUT

TPMS_AC_OUTPUT is used to return information about an AC. The *tag*
structure parameter indicates the type of the *data* value*.*

<span id="_Toc516155336" class="anchor"></span>Table 227 — Definition of
TPMS_AC_OUTPUT Structure \<OUT\>

|           |        |                                       |
|-----------|--------|---------------------------------------|
| Parameter | Type   | Description                           |
| tag       | TPM_AT | tag indicating the contents of *data* |
| data      | UINT32 | the data returned from the AC         |

## TPML_AC_CAPABILITIES

This list is only used in TPM2_AC_GetCapability().

The values in the list are returned in TPM_AT order (see Table 225) with
vendor-specific values returned after TCG defined values.

NOTE MAX_AC_CAPABILITIES = MAX_CAP_DATA / sizeof(TPMS_AC_OUTPUT)

<span id="_Toc470518291" class="anchor"></span>Table 228 — Definition of
TPML_AC_CAPABILITIES Structure \<OUT\>

|                                                |                |                                                         |
|------------------------------------------------|----------------|---------------------------------------------------------|
| Parameter                                      | Type           | Description                                             |
| count                                          | UINT32         | number of values in the *acCapabilities* list; may be 0 |
| acCapabilities\[count\] {:MAX_AC_CAPABILITIES} | TPMS_AC_OUTPUT | a list of AC values                                     |
