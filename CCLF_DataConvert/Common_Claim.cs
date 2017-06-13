using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Nest;
using Nest.Aggregations;

namespace EntityClass
{
    [ElasticsearchType(Name = "claim", IdProperty = "ID")]
    public class Claim
    {
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string ID { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string BeneficiaryDualStatusText { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string AdmissionTypeText { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string PatientFederalIDTaxNumberTypeText { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string QueryText { get; set; }
        [Number(NumberType.Double, Index = NonStringIndexOption.NotAnalyzed)]
        public Nullable<double> TotalChargeAmount { get; set; }//string changed to double for UI
       
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string DispositionCodeSystemVersion { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string PatientFederalIDTaxNumberTypeCodeSystem { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string BillClassificationCodeSystem { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string StatusCodeSystemVersion { get; set; }
        [Date(Format = "yyyyMMdd", Index = NonStringIndexOption.NotAnalyzed)]
        public Nullable<System.DateTime> PaidDate { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string PrimaryPayerCodeSystemVersion { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string PrincipalDiagnosisCode { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string PayerContractID { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string AdmittingClaimDiagnosisID { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string AdmissionSourceCode { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string BillingTypeCodeSystem { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string PersonID { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string BeneficiaryPatientStatusCode { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string SourceFeedName { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string BeneficiaryDualStatusCode { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string StatusChangeReasonCode { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string PrimaryPayerCodeSystem { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string NonPaymentReasonCodeSystem { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string BeneficiaryMedicareStatusCodeSystem { get; set; }
        [Number(NumberType.Double, Index = NonStringIndexOption.NotAnalyzed)]
        public Nullable<double> TotalAllowedAmount { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string DispositionCode { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string StatusCode { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string ProcessingIndicatorCodeSystem { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string NonPaymentReasonCode { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string OutpatientServiceTypeText { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string BillClassificationCode { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string AdjustmentTypeCode { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string BeneficiaryPatientStatusText { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string BeneficiaryMedicareStatusCodeSystemVersion { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string BeneficiaryPatientStatusCodeSystemVersion { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string CurrencyCode { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string TypeCodeSystemVersion { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string StatusChangeReasonCodeSystemVersion { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string NCHPrimaryPayerCodeSystemVersion { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string AdmissionTypeCodeSystemVersion { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string CarrierPaymentDenialCode { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string CarrierPaymentDenialText { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string BeneficiaryOriginalEntitlementReasonCode { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string ProcessingIndicatorCodeSystemVersion { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string PrincipalClaimProcedureID { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string DispositionCodeSystem { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string BeneficiaryOriginalEntitlementReasonCodeSystemVersion { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string BillFrequencyText { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string EncounterID { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string DiagnosisRelatedGroupID { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string AdjustmentTypeCodeSystemVersion { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string NonPaymentReasonText { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string BeneficiaryPatientStatusCodeSystem { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string PrimaryPayerCode { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string BeneficiaryHICNumber { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string BillFrequencyCodeSystem { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string OutpatientServiceTypeCodeSystemVersion { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string BillingTypeCode { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string PatientLiabilityAmount { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string PrincipalProcedureCodeSystem { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string NCHPrimaryPayerCodeSystem { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string NCHPrimaryPayerCode { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string DispositionText { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string TypeCodeSystem { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string StatusText { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string StatusChangeReasonText { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string AdjustmentTypeText { get; set; }
        [Date(Format = "yyyyMMdd", Index = NonStringIndexOption.NotAnalyzed)]
        public Nullable<System.DateTime> CoveredPeriodEndDate { get; set; }
        [Boolean(Index = NonStringIndexOption.NotAnalyzed, NullValue = false, Store = true)]
         public Nullable<bool> IsInNetwork { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string QueryCodeSystem { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string PrincipalProcedureText { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string QueryCodeSystemVersion { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string PrincipalClaimDiagnosisID { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string QueryCode { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string PatientFederalIDTaxNumber { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string CarrierPaymentDenialCodeSystem { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string BeneficiaryDualStatusCodeSystemVersion { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string PatientFederalIDTaxNumberTypeCode { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string BalanceDueAmount { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string AdmissionSourceCodeSystemVersion { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string BillClassificationText { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string BillFrequencyCodeSystemVersion { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string NCHPrimaryPayerText { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string ProcessingIndicatorCode { get; set; }
        [Date(Format = "yyyyMMdd", Index = NonStringIndexOption.NotAnalyzed)]
        public Nullable<System.DateTime> LastUpdateDateTime { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string NonPaymentReasonCodeSystemVersion { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string BeneficiaryOriginalEntitlementReasonText { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string BeneficiaryMedicareStatusText { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string BeneficiaryMedicareStatusCode { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string AdmissionSourceCodeSystem { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string PrincipalDiagnosisCodeSystemVersion { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string CarrierPaymentDenialCodeSystemVersion { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string PrincipalProcedureCode { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string PrimaryPayerText { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string OutpatientServiceTypeCode { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string StatusChangeReasonCodeSystem { get; set; }
        [Date(Format = "yyyyMMdd", Index = NonStringIndexOption.NotAnalyzed)]
        public Nullable<System.DateTimeOffset> IDRLoadDateTime { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string TypeCode { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string ProcessingIndicatorText { get; set; }
        [Number(NumberType.Double, Index = NonStringIndexOption.NotAnalyzed)]
        public Nullable<double> TotalPaidAmount { get; set; }//string changed to double for UI
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string TypeText { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string PrincipalDiagnosisText { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string PrincipalProcedureCodeSystemVersion { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string PrincipalDiagnosisCodeSystem { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string AdmissionSourceText { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string AdmissionTypeCodeSystem { get; set; }
        [Date(Format = "yyyyMMdd", Index = NonStringIndexOption.NotAnalyzed)]
        public Nullable<System.DateTime> CoveredPeriodStartdate { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string BeneficiaryOriginalEntitlementReasonCodeSystem { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string BeneficiaryDualStatusCodeSystem { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string BillingTypeText { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string PatientAccountNumber { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string OutpatientServiceTypeCodeSystem { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string AdjustmentTypeCodeSystem { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string StatusCodeSystem { get; set; }
        [Number(NumberType.Long, Index = NonStringIndexOption.NotAnalyzed)]
        public Nullable<long> MessageSequenceNumber { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string BillingTypeCodeSystemVersion { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string BillClassificationCodeSystemVersion { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string AdmissionTypeCode { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string BillFrequencyCode { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string BeneficiaryEquitableBICHICNNumber { get; set; }
        [Date(Format = "yyyyMMdd", Index = NonStringIndexOption.NotAnalyzed)]
        public Nullable<System.DateTimeOffset> EffectiveDateTime { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string PatientFederalIDTaxNumberTypeCodeSystemVersion { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string Status { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public byte[] RowRevisionID { get; set; }
        [Number(NumberType.Double, Index = NonStringIndexOption.NotAnalyzed)]
        public Nullable<double> PaidAmount { get; set; }//added to store TotalPaidAmount according to the AdjustmentTypeText
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string ClaimID { get; set; }//added to store ClaimLineUniqueId
        [Nest.Nested(Store = true, IncludeInAll = true)]
        //[String(Index = FieldIndexOption.NotAnalyzed)]
        public List<ClaimLine> ClaimLines { get; set; } = new List<ClaimLine>();//added to store Claimlines having same claimid of Claim
        [Nest.Nested(Store = true, IncludeInAll = true)]
        //[String(Index = FieldIndexOption.NotAnalyzed)]
        public List<Procedure> Procedures { get; set; } = new List<Procedure>();//added to store Procedures having same claimid of Claim

        [Nest.Nested(Store = true, IncludeInAll = true)]
        //[String(Index = FieldIndexOption.NotAnalyzed)]
        public List<Diagnosis> Diagnoses { get; set; } = new List<Diagnosis>();//added to store Diagnoses having same claimid of Claim

    }

    [ElasticsearchType(Name = "claimline")]
    public class ClaimLine
    {
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string RenderingProviderID { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string LineID { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string ClaimID { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string ServiceFunctionalTypeText { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string ServiceFunctionalTypeCodeSystem { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string ServiceFunctionalTypeCodeSystemVersion { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string StatusCode { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string CurrencyText { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string StatusText { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string AdjustmentCodeSystemVersion { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string ServiceFunctionalTypeCode { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string CurrencyCode { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string PaidAmount { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string AdjustmentCode { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string RevenueCodeSystemVersion { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string ServiceCodeSystem { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string RenderingProviderIDTypeCodeSystemVersion { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string ServiceMonetaryAmount { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string EmergencyIndicator { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string EarlyPeriodicScreenDiagnosisTreatmentInvolvementIndicator { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string PayerContractID { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string SourceFeedName { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string StatusChangeReasonCode { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string ServiceUnitCount { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string PlaceOfServiceName { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string RenderingProviderIDTypeCode { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string DateOfService { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string AdjustmentText { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string AdjustmentCodeSystem { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string PlaceofServiceCodeSystemVersion { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public Nullable<System.DateTimeOffset> InstitutionalRevenueCenterDateTime { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string PatientLiabilityAmount { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string StatusChangeReasonText { get; set; }
        [Number(NumberType.Long, Index = NonStringIndexOption.NotAnalyzed)]
        public Nullable<long> MessageSequenceNumber { get; set; }
        [Date(Format = "yyyyMMdd", Index = NonStringIndexOption.NotAnalyzed)]
        public Nullable<System.DateTime> ServiceDate { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string StatusChangeReasonCodeSystemVersion { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string PlaceOfServiceText { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public Nullable<System.DateTimeOffset> ThruDateTime { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string RevenueCodeSystem { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string CurrencyCodeSystemVersion { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string EncounterID { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public Nullable<System.DateTimeOffset> FromDateTime { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string StatusCodeSystemVersion { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string ServiceCode { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string RevenueText { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string PersonID { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string RenderingProviderIDTypeCodeSystem { get; set; }
        [Number(NumberType.Double, Index = NonStringIndexOption.NotAnalyzed)]
        public Nullable<double> ChargeAmount { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public Nullable<System.DateTime> LastUpdateDateTime { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string ServiceCodeSystemVersion { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string PlaceofServiceCodeSystem { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string RenderingProviderIDTypeText { get; set; }
        [Number(NumberType.Double, Index = NonStringIndexOption.NotAnalyzed)]
        public Nullable<double> AllowedChargesAmount { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string StatusCodeSystem { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string StatusChangeReasonCodeSystem { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string NonCoveredChargeAmount { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string RevenueCode { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string PlaceOfServiceCode { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string CurrencyCodeSystem { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string ServiceText { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public byte[] RowRevisionID { get; set; }
      
    }
    [ElasticsearchType(Name = "procedure")]
    public class Procedure
    {
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string EncounterID { get; set; }
        [Date(Format = "yyyyMMdd", Index = NonStringIndexOption.NotAnalyzed)]
        public Nullable<DateTime> LastUpdateDateTime { get; set; }
        [Number(NumberType.Long, Index = NonStringIndexOption.NotAnalyzed)]
        public Nullable<long> MessageSequenceNumber { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string ProcedureCode { get; set; }//Lookups.usf_Terminology_CustomConvertCodeToICDCodeProc(CSV_5,CSV_11)
        [Date(Format = "yyyyMMdd", Index = NonStringIndexOption.NotAnalyzed)]
        public Nullable<DateTime> ProcedureDateTime { get; set; }//CSV_6
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string ProcedureID { get; set; }//ConcatenateStringList(EMPICompID,ProcedureCode,CSV_9)
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string ProcedureText { get; set; }//Lookups.usf_Terminology_CustomConvertCodeToICDCodeProc(CSV_5,CSV_11)
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string SourceFeedName { get; set; }//CCLF3
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string ClaimID { get; set; }//added to store ClaimLineUniqueId
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string ClaimProcedureID{ get; set; }//ConcatenateStringList(ClaimID, CSV_4)
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string Code{ get; set; }//Lookups.usf_Terminology_CustomConvertCodeToICDCodeProc(CSV_5,CSV_11)
        [Date(Format = "yyyyMMdd", Index = NonStringIndexOption.NotAnalyzed)]
        public string Date { get; set; }//CSV_6
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string Text { get; set; }//Lookups.usf_Terminology_CustomConvertCodeToICDCodeProc(CSV_5,CSV_11)
        //from Procedures
        //public Nullable<decimal> AnesthesiaMinutes { get; set; }
        //public string AnesthesiologistID { get; set; }
        //public string AnesthesiologistName { get; set; }
        //public string AssociatedDiagnosisCode { get; set; }
        //public string AssociatedDiagnosisCodeSystem { get; set; }
        //public string AssociatedDiagnosisCodeSystemVersion { get; set; }
        //public string AssociatedDiagnosisText { get; set; }
        //public string DataSourceName { get; set; }
        //public string HCPCSFifthModifierCode { get; set; }
        //public string HCPCSFirstModifierCode { get; set; }
        //public string HCPCSFourthModifierCode { get; set; }
        //public string HCPCSModifierCodeSystem { get; set; }
        //public string HCPCSModifierCodeSystemVersion { get; set; }
        //public string HCPCSSecondModifierCode { get; set; }
        //public string HCPCSThirdModifierCode { get; set; }
        //public string PersonID { get; set; }
        //public string PractitionerID { get; set; }
        //public string PractitionerName { get; set; }
        //public Nullable<int> PriorityID { get; set; }
        //public string ProcedureCleansedCode { get; set; }
        //public string ProcedureCleansedCodingSystem { get; set; }
        //public string ProcedureCleansedText { get; set; }
        //public string ProcedureCode_CPT4 { get; set; }
        //public string ProcedureCode_ICD10PCS { get; set; }
        //public string ProcedureCode_ICD9 { get; set; }
        //public string ProcedureCode_SNOMED { get; set; }
        //public string ProcedureCodingSystem { get; set; }
        //public string ProcedureCodingSystemVersion { get; set; }
        //public Nullable<DateTimeOffset> ProcedureDateTime_o { get; set; }
        //public string ProcedureIdentifier { get; set; }
        //public string ProcedureMediumText { get; set; }
        //public Nullable<decimal> ProcedureMinutes { get; set; }
        //public Nullable<int> ProcedurePriority { get; set; }
        //public string ProcedureShortText { get; set; }
        //public string Status { get; set; }
        //public string StatusChangeReasonCode { get; set; }
        //public string StatusChangeReasonCodeSystem { get; set; }
        //public string StatusChangeReasonCodeSystemVersion { get; set; }
        //public string StatusChangeReasonText { get; set; }
        //public string StatusCode { get; set; }
        //public string StatusCodeSystem { get; set; }
        //public string StatusCodeSystemVersion { get; set; }
        //public string StatusNormalized { get; set; }
        //public string StatusText { get; set; }
        //public string SurgeonID { get; set; }
        //public string SurgeonName { get; set; }
        //public string Type { get; set; }
        //public string TypeCode { get; set; }
        //public string TypeCodeSystem { get; set; }
        //public string TypeCodeSystemVersion { get; set; }
        //public string TypeNormalized { get; set; }

        //from ClaimProcedures
        //ClaimID
        //ClaimLineID
        //ClaimProcedureID
        //Code
        //CodeSystem
        //CodeSystemVersion
        //Date
        //EncounterID
        //HCPCSFifthModifierCode
        //HCPCSFifthModifierText
        //HCPCSFirstModifierCode
        //HCPCSFirstModifierText
        //HCPCSFourthModifierCode
        //HCPCSFourthModifierText
        //HCPCSModifierCodeSystem
        //HCPCSModifierCodeSystemVersion
        //HCPCSSecondModifierCode
        //HCPCSSecondModifierText
        //HCPCSThirdModifierCode
        //HCPCSThirdModifierText
        //LastUpdateDateTime
        //MessageSequenceNumber
        //PersonID
        //PriorityID
        //ProcedureID
        //ProcedureMediumText
        //ProcedureShortText
        //ProcedureTypeCode
        //ProcedureTypeCodeSystem
        //ProcedureTypeCodeSystemVersion
        //ProcedureTypeText
        //ProviderRole
        //SourceFeedName
        //StatusChangeReasonCode
        //StatusChangeReasonCodeSystem
        //StatusChangeReasonCodeSystemVersion
        //StatusChangeReasonText
        //StatusCode
        //StatusCodeSystem
        //StatusCodeSystemVersion
        //StatusText
        //Text
        //ValueSequenceNumber
    }
    [ElasticsearchType(Name = "diagnosis")]
    public class Diagnosis
    {
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string ClaimID { get; set; }
        //public string AppPerspectiveSourceCode { get; set; }
        //public string AppPerspectiveSourceCodeSystem { get; set; }
        //public string AppPerspectiveSourceCodeSystemVersion { get; set; }
        //public string AppPerspectiveSourceText { get; set; }
        //public string AppPerspectiveStatusChangeReasonCode { get; set; }
        //public string AppPerspectiveStatusChangeReasonCodeSystem { get; set; }
        //public string AppPerspectiveStatusChangeReasonCodeSystemVersion { get; set; }
        //public string AppPerspectiveStatusChangeReasonText { get; set; }
        //public string AppPerspectiveStatusCode { get; set; }
        //public string AppPerspectiveStatusCodeSystem { get; set; }
        //public string AppPerspectiveStatusCodeSystemVersion { get; set; }
        //public string AppPerspectiveStatusText { get; set; }
        //public string ConfidentialIndicator { get; set; }
        //public string DataSourceName { get; set; }
        //public string DiagnosedByProviderID { get; set; }
        //public string DiagnosedByProviderName { get; set; }
        //public string DiagnosisCleansedCode { get; set; }
        //public string DiagnosisCleansedCodingSystem { get; set; }
        //public string DiagnosisCleansedText { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string DiagnosisCode { get; set; }
        //public string DiagnosisCode_ICD10 { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string DiagnosisCode_ICD9 { get; set; }
        //public string DiagnosisCode_SNOMED { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string DiagnosisCodingSystem { get; set; }
        //public string DiagnosisCodingSystemVersion { get; set; }
        [Date(Format = "yyyyMMdd", Index = NonStringIndexOption.NotAnalyzed)]
        public Nullable<DateTime> DiagnosisDateTime { get; set; }
        //public Nullable<DateTimeOffset> DiagnosisDateTime_o { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string DiagnosisID { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string DiagnosisMediumText { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string DiagnosisShortText { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string DiagnosisText { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string EncounterID { get; set; }

        //public string LastModifiedBy { get; set; }
        [Date(Format = "yyyyMMdd", Index = NonStringIndexOption.NotAnalyzed)]
        public Nullable<DateTime> LastUpdateDateTime { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string MajorDiagnosticCategory { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string MajorDiagnosticCategoryDescription { get; set; }
        [Number(NumberType.Long, Index = NonStringIndexOption.NotAnalyzed)]
        public Nullable<long> MessageSequenceNumber { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string PersonID { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string PresentOnAdmissionIndicatorCode { get; set; }
        //public string PresentOnAdmissionIndicatorCodeSystem { get; set; }
        //public string PresentOnAdmissionIndicatorCodeSystemVersion { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string PresentOnAdmissionIndicatorText { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string PriorityID { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string SourceFeedName { get; set; }
        //public string StatusChangeReasonCode { get; set; }
        //public string StatusChangeReasonCodeSystem { get; set; }
        //public string StatusChangeReasonCodeSystemVersion { get; set; }
        //public string StatusChangeReasonText { get; set; }
        //public string StatusCode { get; set; }
        //public string StatusCodeSystem { get; set; }
        //public string StatusCodeSystemVersion { get; set; }
        //public string StatusText { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string Type { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string TypeCode { get; set; }
        //public string TypeCodeSystem { get; set; }
        //public string TypeCodeSystemVersion { get; set; }
        //public string TypeNormalized { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string TypeText { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string Text { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string ClaimDiagnosisID { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string Code { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string CodeSystem{ get; set; }
        [Date(Format = "yyyyMMdd", Index = NonStringIndexOption.NotAnalyzed)]
        public DateTime Date { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string MajorDiagnosticCategoryCode { get; set; }
        [String(Index = FieldIndexOption.NotAnalyzed)]
        public string MajorDiagnosticCategoryText { get; set; }

    }
    //public class Allergy
    //{
    //    public string EncounterID { get; set; }
    //    public string PersonID { get; set; }
    //    public string ReportedByProviderID { get; set; }
    //    public string TreatmentProviderID { get; set; }
    //    public string AllergyID { get; set; }
    //    public string TypeText { get; set; }
    //    public string TypeCodingSystem { get; set; }
    //    public string DescriptionCleansedCode { get; set; }
    //    public string StatusChangeReasonCode { get; set; }
    //    public string SeverityCodingSystemVersion { get; set; }
    //    public string ReportedRelationshipToPatientCodingSystem { get; set; }
    //    public string SeverityCode_ICD9 { get; set; }
    //    public string DescriptionCodingSystem { get; set; }
    //    public string SeverityCodingSystem { get; set; }
    //    public string ReactionNormalized { get; set; }
    //    public string SeverityCode_SNOMED { get; set; }
    //    public Nullable<System.DateTime> InactivatedDateTime { get; set; }
    //    public string StatusChangeReasonCodeSystemVersion { get; set; }
    //    public Nullable<System.DateTime> LastUpdateDateTime { get; set; }
    //    public string DataSourceName { get; set; }
    //    public string TypeCleansedCode { get; set; }
    //    public string DescriptionText { get; set; }
    //    public string IdentificationDatePeriod { get; set; }
    //    public string Status { get; set; }
    //    public string ReportedRelationshipToPatientText { get; set; }
    //    public string ReportedRelationshipToPatientCode { get; set; }
    //    public string StatusText { get; set; }
    //    public Nullable<System.DateTime> ModifiedDateTime { get; set; }
    //    public Nullable<long> MessageSequenceNumber { get; set; }
    //    public string DescriptionCode { get; set; }
    //    public string TypeCode_UNII { get; set; }
    //    public Nullable<int> SetID { get; set; }
    //    public string InactivatedByPerson { get; set; }
    //    public Nullable<System.DateTime> IdentificationDate { get; set; }
    //    public string SourceFeedName { get; set; }
    //    public string StatusChangeReasonText { get; set; }
    //    public string ReportedByProviderName { get; set; }
    //    public string TypeCode_SNOMED { get; set; }
    //    public string SeverityCleansedCodingSystem { get; set; }
    //    public string TreatmentProviderName { get; set; }
    //    public string SeverityCode { get; set; }
    //    public string ReportedRelationshipToPatientCodingSystemVersion { get; set; }
    //    public string GroupCodingSystemVersion { get; set; }
    //    public string ReportedByName { get; set; }
    //    public string TypeCode_ICD10 { get; set; }
    //    public string TypeCode { get; set; }
    //    public string SeverityCode_ICD10 { get; set; }
    //    public string DescriptionCodingSystemVersion { get; set; }
    //    public string GroupCode { get; set; }
    //    public string GroupCodingSystem { get; set; }
    //    public Nullable<System.DateTimeOffset> IdentificationDate_o { get; set; }
    //    public string TypeCodingSystemVersion { get; set; }
    //    public string DescriptionCleansedText { get; set; }
    //    public string SeverityCleansedCode { get; set; }
    //    public string StatusCodeSystemVersion { get; set; }
    //    public string InitiallyRecordedByPerson { get; set; }
    //    public string SeverityText { get; set; }
    //    public string DescriptionCleansedCodingSystem { get; set; }
    //    public string TypeCleansedText { get; set; }
    //    public string TypeCode_ICD9 { get; set; }
    //    public Nullable<System.DateTime> ReportedDateTime { get; set; }
    //    public string StatusCode { get; set; }
    //    public Nullable<System.DateTime> InitiallyRecordedDateTime { get; set; }
    //    public string StatusCodeSystem { get; set; }
    //    public string GroupCodeText { get; set; }
    //    public string ReactionCode { get; set; }
    //    public string ModifiedByPerson { get; set; }
    //    public string StatusNormalized { get; set; }
    //    public string TypeCleansedCodingSystem { get; set; }
    //    public string StatusChangeReasonCodeSystem { get; set; }
    //    public string SeverityCleansedText { get; set; }
    //    public byte[] RowRevisionID { get; set; }
    //}

}
