using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using Nest;
using Nest.Aggregations;
using EntityClass;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


namespace CCLF_DataConvert
{
    public partial class Form1 : Form
    {
        
        List<Claim> ClaimData;
        List<ClaimLine> ClaimLineData;
        List<Procedure> ProcedureData;
        List<Diagnosis> DiagnosisData;

        public Form1()
        {
            InitializeComponent();
        }

  /// <summary>
  /// Maps Claims Data
  /// </summary>
  /// <param name="v"></param>
  /// <param name="value"></param>
        public void AddClaims(Claim v, string[] value)
        {
            v.ID = value[2] + "|" + value[1] + "|" + value[4] + "|" + value[5]; //NaturalKey-EMPICompID-here BenehicId|CSV_2|CSV_5|CSV_6
            //v.ID = value[2]+"|"+value[0];//refered from DB 
            v.ClaimID = value[0];
            //v.BeneficiaryDualStatusText = value[1];
            v.AdmissionTypeText = value[25]; //Lookups.usf_LookUpCodedValues_New("CLM_ADMSN_TYPE_CD", CSV_26)
            //v.PatientFederalIDTaxNumberTypeText = value[3];
            //v.QueryText = FormatDate(value[4]);
            //v.TotalChargeAmount = FormatDate(value[5]);
            //v.DispositionCodeSystemVersion = value[6];
            //v.PatientFederalIDTaxNumberTypeCodeSystem = value[7];
            v.BillClassificationCodeSystem = "V13";
            //v.StatusCodeSystemVersion = value[9];
            //v.PaidDate = value[10];
            //v.PrimaryPayerCodeSystemVersion = Convert.ToDecimal(value[11]);
            v.PrincipalDiagnosisCode = value[12];//Lookups.usf_Terminology_CustomConvertCodeToICDCode(CSV_9,CSV_30,"Code")
            //v.PayerContractID = value[13];
            v.BeneficiaryPatientStatusCode = value[14];
            //v.AdmittingClaimDiagnosisID = value[15];
            v.AdmissionSourceCode = value[26];
            //v.BillingTypeCodeSystem = value[17];
            //v.PersonID = value[18];
            //v.BeneficiaryPatientStatusCode = value[19];
            v.SourceFeedName = "CCLF1";
            //v.BeneficiaryDualStatusCode = value[21];
            //v.StatusChangeReasonCode = FormatDate(value[22]);
            //v.PrimaryPayerCodeSystem = FormatDate(value[23]);
            v.BeneficiaryEquitableBICHICNNumber = value[24];
            //v.NonPaymentReasonCodeSystem = value[25];
            //v.BeneficiaryMedicareStatusCodeSystem = value[26];
            //v.TotalAllowedAmount = value[27];
            v.DispositionCode = value[14];
            //v.StatusCode = 
            //v.ProcessingIndicatorCodeSystem = v.ClaimPaymentAmount;  
            // v.NonPaymentReasonCode = value[1]; 
            //v.OutpatientServiceTypeText = value[25];
            v.BillClassificationCode = value[7];
            v.AdjustmentTypeCode = value[21];
            v.BeneficiaryPatientStatusText = value[14];//Lookups.usf_LookUpCodedValues_New("DischargeDisposition",CSV_15)
            //v.BeneficiaryMedicareStatusCodeSystemVersion = 
            v.BeneficiaryPatientStatusCodeSystemVersion = "V13";   
            //v.CurrencyCode= value[25];
            //v.TypeCodeSystemVersion = value[25];
            //v.StatusChangeReasonCodeSystemVersion = value[26];
            //v.NCHPrimaryPayerCodeSystemVersion = value[27];
            v.AdmissionTypeCodeSystemVersion = "V13";
            //v.CarrierPaymentDenialCode = 
            //v.CarrierPaymentDenialText = 
            //v.BeneficiaryOriginalEntitlementReasonCode=value[25];
            //v.ProcessingIndicatorCodeSystemVersion = value[25];
            //v.PrincipalClaimProcedureID = value[26];
            //v.DispositionCodeSystem = value[27];
            //v.BeneficiaryOriginalEntitlementReasonCodeSystemVersion = value[28];
            v.BillFrequencyText = value[27]; //Lookups.usf_LookUpCodedValues_New("CLM_BILL_FREQ_CD", CSV_28)
            //v.EncounterID = v.ClaimPaymentAmount;  
            v.DiagnosisRelatedGroupID= value[2] + "|" + value[1] + "|" + value[4] + "|" + value[5]; ;//Naturalkey-EMPICompID|CSV_2|CSV_5|CSV_6
            v.AdjustmentTypeCodeSystemVersion = "V13";
            //v.NonPaymentReasonText = value[26];
            //v.BeneficiaryPatientStatusCodeSystem = value[27];
            //v.PrimaryPayerCode = value[28];
            v.BeneficiaryHICNumber = value[2];
            //v.BillFrequencyCodeSystem = v.ClaimPaymentAmount;  
            //v.OutpatientServiceTypeCodeSystemVersion =
            v.BillingTypeCode = value[3];
            //v.PatientLiabilityAmount = value[26];
            //v.PrincipalProcedureCodeSystem = value[27];
            //v.NCHPrimaryPayerCodeSystem = value[28];
            //v.NCHPrimaryPayerCode = 
            //v.DispositionText =
            //v.TypeCodeSystem = 
            //v.StatusText = value[25];
            //v.StatusChangeReasonText = value[26];
            v.AdjustmentTypeText = value[21];//Lookups.usf_LookUpCodedValues_New("CLM_ADJSMT_TYPE_CD",CSV_22)
            v.CoveredPeriodEndDate = Convert.ToDateTime(value[5]);//datetime2
            v.IsInNetwork = Convert.ToBoolean(1);//IsInNetwork-bit
            //v.QueryCodeSystem = 
            //v.PrincipalProcedureText = 
            //v.QueryCodeSystemVersion = value[25];
            //v.PrincipalClaimDiagnosisID = value[26];
            //v.QueryCode = value[27];
            //v.PatientFederalIDTaxNumber = value[28];
            //v.CarrierPaymentDenialCodeSystem = 
            //v.BeneficiaryDualStatusCodeSystemVersion = 
            //v.PatientFederalIDTaxNumberTypeCode =
            //v.BalanceDueAmount = value[25];
            v.AdmissionSourceCodeSystemVersion ="V13";
            v.BillClassificationText = value[7]; //Lookups.usf_LookUpCodedValues_New("CLM_POS_CD",CSV_8)
            v.BillFrequencyCodeSystemVersion = "V13";
            //v.NCHPrimaryPayerText = 
            //v.ProcessingIndicatorCode =  
            v.LastUpdateDateTime = System.DateTime.Now;//datetime2
            //v.NonPaymentReasonCodeSystemVersion = value[26];
            //v.BeneficiaryOriginalEntitlementReasonText = value[27];
            //v.BeneficiaryMedicareStatusText = value[28];
            //v.BeneficiaryMedicareStatusCode = 
            //v.AdmissionSourceCodeSystem = value[26];
            v.PrincipalDiagnosisCodeSystemVersion = "V13";
            //v.CarrierPaymentDenialCodeSystemVersion = value[28];
            //v.PrincipalProcedureCode = 
            //v.PrimaryPayerText = value[26];
            //v.OutpatientServiceTypeCode = value[27];
            //v.StatusChangeReasonCodeSystem = value[28];
            v.IDRLoadDateTime = Convert.ToDateTime(value[23]);
            //v.TypeCode = value[26];
            //v.ProcessingIndicatorText = value[27];
            v.TotalPaidAmount = double.Parse(value[11]);
            v.TotalChargeAmount = double.Parse(value[11]);
            v.TypeText = value[2]+ "|" + value[0] ;//|EMPICompID-here BenehicID|CSV_1
            v.PrincipalDiagnosisText = value[26];//Lookups.usf_Terminology_CustomConvertCodeToICDCode(PrincipalDiag,CSV_30,"Text")
            //v.PrincipalProcedureCodeSystemVersion = value[27];
            v.PrincipalDiagnosisCodeSystem = value[29];//PrincipalDiag,CSV_30,"CommonCodeSystem"
            v.AdmissionSourceText = value[26]; //Lookups.usf_LookUpCodedValues_New("CLM_ADMSN_SRC_CD",CSV_27)
            //v.AdmissionTypeCodeSystem = value[26];
            v.CoveredPeriodStartdate = Convert.ToDateTime(value[4]);//datetime2
            //v.BeneficiaryOriginalEntitlementReasonCodeSystem = value[28];
            //v.BeneficiaryDualStatusCodeSystem = 
            v.BillingTypeText = value[3];//Lookups.usf_LookUpCodedValues_New("CLM_TYPE_CD",CSV_4)
            //v.PatientAccountNumber = value[27];
            //v.OutpatientServiceTypeCodeSystem = value[28];
            // v.AdjustmentTypeCodeSystem = 
            //v.StatusCodeSystem = 
            v.MessageSequenceNumber = 0;//bigint
            v.BillingTypeCodeSystemVersion = "V13";
            v.BillClassificationCodeSystemVersion = "V13";
            v.AdmissionTypeCode = value[25];
            v.BillFrequencyCode = value[27];
            //v.BeneficiaryEquitableBICHICNNumber = value[24];
            v.EffectiveDateTime = Convert.ToDateTime(value[22]);//datetimeoffset
            //v.PatientFederalIDTaxNumberTypeCodeSystemVersion = value[28];
            //v.Status = value[28];
            //v.RowRevisionID = value[28];
            v.PaidAmount = v.TotalPaidAmount;  //if AdjustmentTypeText=0 or 2 then same amount 
            if (int.Parse(v.AdjustmentTypeText) == 1)
                v.PaidAmount = v.TotalPaidAmount * -1; //else negative-cancellation
            v.ClaimLines = ClaimLineData.Where(p => p.ClaimID == v.ClaimID).ToList();
            v.Procedures = ProcedureData.Where(p => p.ClaimID == v.ClaimID).ToList();
            v.Diagnoses = DiagnosisData.Where(p => p.ClaimID == v.ClaimID).ToList();
        }
        /// <summary>
        /// Maps ClaimLines
        /// </summary>
        /// <param name="v"></param>
        /// <param name="value"></param>
        public void AddClaimLines(ClaimLine v,string[] value)
        {
            v.RenderingProviderID = value[10];
            v.LineID = value[0]+"|"+value[1]; //ClaimId|csv_2 -nvarchar
            v.ClaimID = value[0];
            //v.ServiceFunctionalTypeText = value[2];
            //v.ServiceFunctionalTypeCodeSystem = value[3];
            //v.ServiceFunctionalTypeCodeSystemVersion = FormatDate(value[4]);
            //v.StatusCode = FormatDate(value[5]);
            //v.CurrencyText = value[6];
            //v.StatusText = FormatDate(value[7]);
            //v.AdjustmentCodeSystemVersion = value[8];
            //v.ServiceFunctionalTypeCode = value[9];
            //v.CurrencyCode = value[10];
            v.PaidAmount =value[14];
            //v.AdjustmentCode = FormatDate(value[12]);
            //v.RevenueCodeSystemVersion = value[13];
            //v.ServiceCodeSystem = Convert.ToDecimal(value[14]);
            //v.RenderingProviderIDTypeCodeSystemVersion = value[15];
            v.ServiceMonetaryAmount = value[0];//refer CLM_LINE_CVRD_PD_AMT
            //v.EmergencyIndicator = value[17];
            //v.EarlyPeriodicScreenDiagnosisTreatmentInvolvementIndicator = value[18];
            //v.PayerContractID = value[19];
            v.SourceFeedName = "CCLF2";
            //v.StatusChangeReasonCode = FormatDate(value[11]);
            v.ServiceUnitCount = value[13];//refer
            //v.PlaceOfServiceName = value[13];
            //v.RenderingProviderIDTypeCode = Convert.ToDecimal(value[14]);
            v.DateOfService = value[11];
            //v.AdjustmentText = value[16];
            //v.AdjustmentCodeSystem = value[17];
            //v.PlaceofServiceCodeSystemVersion = value[18];
            //v.InstitutionalRevenueCenterDateTime = value[19];
            //v.PatientLiabilityAmount = Convert.ToDecimal(value[14]);
            //v.StatusChangeReasonText = value[15];
            //v.ClaimID = value[16];//NaturalKey refer//2nd-EMPICompID|CSV_2|CSV_5|CSV_6
            v.MessageSequenceNumber = 0;//bigint
            v.ServiceDate = Convert.ToDateTime(value[11]);//refer ClaimFromDate datetime
            //v.StatusChangeReasonCodeSystemVersion = value[19];
            //v.PlaceOfServiceText = Convert.ToDecimal(value[14]);
            v.ThruDateTime = Convert.ToDateTime(value[5]);
            //v.RevenueCodeSystem = value[16];
            //v.CurrencyCodeSystemVersion = value[17];
            //v.EncounterID = value[18];
            v.FromDateTime = Convert.ToDateTime(value[11]);//datetimeoffset
            //v.StatusCodeSystemVersion = Convert.ToDecimal(value[14]);
            v.ServiceCode = value[8];
            //v.RevenueText = value[16];
            //v.PersonID = value[17];
            //v.RenderingProviderIDTypeCodeSystem = value[18];
            //v.ChargeAmount = value[19];
            v.LastUpdateDateTime = System.DateTime.Now;
            //v.ServiceCodeSystemVersion = value[15];
            //v.PlaceofServiceCodeSystem = value[16];
            //v.RenderingProviderIDTypeText = value[17];
            v.AllowedChargesAmount = Convert.ToDouble(value[14]);//double
            //v.StatusChangeReasonCodeSystem = Convert.ToDecimal(value[14]);
            //v.NonCoveredChargeAmount = value[15];
            v.RevenueCode = value[6];
            //v.PlaceOfServiceCode = value[17];
            //v.CurrencyCodeSystem = value[18];
            //v.ServiceText = value[19];
            //v.RowRevisionID = value[19];
        }
        public void AddProcedures(Procedure v, string[] value)
        {
            v.EncounterID = value[0];
            v.LastUpdateDateTime = System.DateTime.Now;
            v.MessageSequenceNumber = 0;
            v.ProcedureCode = value[0];//Lookups.usf_Terminology_CustomConvertCodeToICDCodeProc(CSV_5,CSV_11)
            v.ProcedureDateTime = Convert.ToDateTime(value[5]);//CSV_6
            v.ProcedureID = value[1]+"|"+v.ProcedureCode+"|"+value[8];//ConcatenateStringList(EMPICompID-here BenehicId,ProcedureCode-Lookupcode,CSV_9)
            v.ProcedureText = value[0];//Lookups.usf_Terminology_CustomConvertCodeToICDCodeProc(CSV_5,CSV_11)
            v.SourceFeedName = "CCLF3";
            v.ClaimID = value[0];//added to store ClaimLineUniqueId
            v.ClaimProcedureID = value[0]+"|"+value[3];//ConcatenateStringList(ClaimID, CSV_4)
            v.Code = value[0];//Lookups.usf_Terminology_CustomConvertCodeToICDCodeProc(CSV_5,CSV_11)
            v.Date = value[5];//CSV_6
            v.Text = value[0];//Lookups.usf_Terminology_CustomConvertCodeToICDCodeProc(CSV_5,CSV_11)

    }
        public void AddDiagnosis(Diagnosis v, string[] value)
        {
            v.EncounterID = value[0];
            v.LastUpdateDateTime = System.DateTime.Now;
            v.MessageSequenceNumber = 0;
            v.Text= value[0];//Lookups.usf_GetDiagnosisDetails(CSV_6)
            v.TypeCode= "85097005";//"85097005"
            v.TypeText= "Secondary";//"Secondary"
            v.DiagnosisCode= "0";//Lookups.usf_Terminology_CustomConvertCodeToICDCode(CSV_6,CSV_12)
            v.DiagnosisCode_ICD9= "0";//Lookups.usf_Terminology_CustomConvertCodeToICDCode(CSV_6,CSV_12)
            v.DiagnosisCodingSystem= "0";//Transforms.MessageHelpers.CheckICDDiagCode(DiagCode,CSV_12,"CodeSystem")
            v.DiagnosisDateTime= Convert.ToDateTime(value[8]);//CSV_9
            v.DiagnosisID= value[1]+"|"+v.Code+"|"+value[8];//ConcatenateStringList(EMPICompID-here benehicId|DiagCode|CSV_9)
            v.DiagnosisText= "0";//Lookups.usf_Terminology_CustomConvertCodeToICDCode(DiagCode,CSV_12)
            v.EncounterID= value[0];//refer-VisitCompID__AmalgaID__EncounterStringId
         
            v.MajorDiagnosticCategory= value[0];//Lookups.usf_GetDiagnosisDetails(CSV_6)
            v.MajorDiagnosticCategoryDescription= value[0];//Lookups.usf_GetDiagnosisDetails(CSV_6)
            v.MessageSequenceNumber= 0;
            v.PersonID= value[0];//VisitCompID__AmalgaID__PersonStringId-refer
            v.SourceFeedName= "CCLF4";
            v.Type = "Secondary";//"Secondary"

            v.ClaimDiagnosisID=value[0]+"|"+value[4]; //ConcatenateStringList(ClaimID | CSV_5)
            v.Code="0";//Lookups.usf_Terminology_CustomConvertCodeToICDCode(CSV_6,CSV_12)
            v.CodeSystem = v.Code+value[11]+"CodeSystem";//MessageHelpers.CheckICDDiagCode(DiagCode,CSV_12,"CodeSystem")
            v.Date = Convert.ToDateTime(value[8]);//CSV_9
            v.DiagnosisMediumText = "0";//Lookups.usf_GetDiagnosisDetails(CSV_6)
            v.DiagnosisShortText = "0";//Lookups.usf_GetDiagnosisDetails(CSV_6)

            v.MajorDiagnosticCategoryCode = "0";//Lookups.usf_GetDiagnosisDetails(CSV_6)
            v.MajorDiagnosticCategoryText = "0"; //Lookups.usf_GetDiagnosisDetails(CSV_6)

            v.PresentOnAdmissionIndicatorCode = value[10];//csv_11
            v.PresentOnAdmissionIndicatorText = value[0];//Lookups.usf_LookUpCodedValues_New("CLM_POA_IND",CSV_11)
            v.PriorityID = "2";
            v.ClaimID = value[0];
        }
        /// <summary>
        /// Groupby ID(Natural Key) and sum the TotalPaidAmounts into finalAmount
        /// </summary>
        public void AddFinalAmountClaim()
        {
            var lines = ClaimData; //  List<Claim>
            var grouped = (from y in lines
                           group y by new { y.ID } into z
                           select new
                           {
                               groupID = z.Key,
                               maxDate = z.Max(a => a.EffectiveDateTime),
                               finalAmountSum = z.Sum(s => s.PaidAmount),
                           });
          
            foreach (var v in grouped)
            {
                for (int i = ClaimData.Count - 1; i >= 0; i--)
                {
                    if (ClaimData[i].ID.ToString().Trim() == Convert.ToString(v.groupID.ID.Trim()))
                    {
                        if (ClaimData[i].EffectiveDateTime.ToString() == v.maxDate.ToString())
                            ClaimData[i].TotalPaidAmount = v.finalAmountSum;//sum of all PaidAmounts
                        else
                            ClaimData.RemoveAt(i); //remove extra claimlines from Claims
                    }
                }
            }
        }
        private void Process_Click(object sender, EventArgs e)
        {
            string[] values;
            List<string> listCCLF1;
            List<string> listCCLF2;
            List<string> listCCLF3;
            List<string> listCCLF4;
            //read ClaimLine(CCLF2)deIdentified csv
            listCCLF2 = File.ReadAllLines("F:\\CCLF Files\\Files\\Delimitedsorted\\April17\\test2_1.csv").ToList();
            
            Status.AppendText("Reading ClaimLines..." + Environment.NewLine);
            ClaimLineData = new List<ClaimLine>();
            foreach (var item in listCCLF2)
            {
                values = item.Split(',');
                var val = new ClaimLine();
                //if(values.Length>0)
                AddClaimLines(val, values); //Add data to ClaimLine object
                ClaimLineData.Add(val); //Add ClaimLine object to List
            }
            //read Procedure(CCLF3)data deIdentified csv
            listCCLF3 = File.ReadAllLines("F:\\CCLF Files\\Files\\Delimitedsorted\\April17\\test3_1.csv").ToList();
            Status.AppendText("Reading Procedures..." + Environment.NewLine);
            ProcedureData = new List<Procedure>();
            foreach (var item in listCCLF3)
            {
                values = item.Split(',');
                var val = new Procedure();
                //if(values.Length>0)
                AddProcedures(val, values); //Add data to Procedure object
                ProcedureData.Add(val); //Add Procedure object to List
            }

            //read Diagnosis(CCLF4)data deIdentified csv
            listCCLF4 = File.ReadAllLines("F:\\CCLF Files\\Files\\Delimitedsorted\\April17\\test4_1.csv").ToList();
            Status.AppendText("Reading Diagnoses..." + Environment.NewLine);
            DiagnosisData = new List<Diagnosis>();
            foreach (var item in listCCLF4)
            {
                values = item.Split(',');
                var val = new Diagnosis();
                //if(values.Length>0)
                AddDiagnosis(val, values); //Add data to Diagnosis object
                DiagnosisData.Add(val); //Add Diagnosis object to List
            }
            //read Claim data from csv
            listCCLF1 = File.ReadAllLines("F:\\CCLF Files\\Files\\Delimitedsorted\\April17\\test1_1.csv").ToList();
            //group according to Natural Key and EffectiveDateTime
            var data = listCCLF1;
            //NaturalKey-EMPICompID-here BenehicId-CSV-3|CSV_2|CSV_5|CSV_6
            var sorted = data.Select(line1 => new
            {
                SortKey1 = line1.Split(',')[2],
                SortKey2 = line1.Split(',')[1],
                SortKey3 = line1.Split(',')[4],
                SortKey4 = line1.Split(',')[5],
                SortKey5 = line1.Split(',')[22],
                Line = line1
            })
                        .OrderBy(x => x.SortKey1).ThenBy(x => x.SortKey2).ThenBy(x => x.SortKey3).ThenBy(x => x.SortKey4).ThenByDescending(x => x.SortKey5)
                        .Select(x => x.Line);
            //elastic connection
            var local = new Uri("http://localhost:9200");
            var settings = new ConnectionSettings(local).DisableDirectStreaming();
            var elastic = new ElasticClient(settings); //ElasticClient 
           
            settings.DefaultIndex("claims30");

            Status.AppendText("Creating ClaimObject..." + Environment.NewLine);
            ClaimData = new List<Claim>();
            int index = 0;
            string curKey = "";
            int adjustmentTypeText = 0; 
            double paidAmount = 0.0;
            foreach (var item in sorted)
            {
                values = item.Split(',');
                curKey = values[2] + "|" + values[1] + "|" + values[4] + "|" + values[5];//getting ID

                if (index > 0)
                {
                    if (curKey == ClaimData.Last().ID)
                    {
                        adjustmentTypeText = Convert.ToInt16(values[21]);
                        paidAmount = (adjustmentTypeText == 1) ? (double.Parse(values[11]) * -1) : double.Parse(values[11]);//adjustment 
                        ClaimData.Last().TotalPaidAmount = ClaimData.Last().TotalPaidAmount + paidAmount;
                        continue;
                    }
                  
                }
               
                var val = new Claim();
                //if(values.Length!=0)
                AddClaims(val, values); //Add data to Claim object
                ClaimData.Add(val); //Add Claim object to List
                //search in elastic if any record exist for the same key
                var searchElastic = elastic.Search<Claim>(c => c.Index("claims30").Query(q => q.Match(m => m.Field(f => f.ID).Query(curKey))));
                for (int j = 0; j < searchElastic.Documents.Count(); j++)
                {
                    if (searchElastic.Documents.ElementAt(j).ID == curKey)
                    {
                        paidAmount = Convert.ToDouble(searchElastic.Documents.ElementAt(j).TotalPaidAmount);
                        ClaimData.Last().TotalPaidAmount = ClaimData.Last().TotalPaidAmount + paidAmount;
                        //delete the existing record from elastic
                        elastic.Delete<Claim>(searchElastic.Documents.ElementAt(j).ID);
                        break;
                    }
                }
                index++;
            }
           
            //AddFinalAmountClaim();
            Status.AppendText("Bulk Insert Start" + Environment.NewLine);
            Status.Refresh();
            CreateBulk(index);
            Status.AppendText("Bulk Insert Complete" + Environment.NewLine);
            Status.Refresh();
            
        }
        public void CreateBulk(int dataCount)
        {
            //string indexname1 = "claims30";
            int limit = 10000;
            int totalRecords = ClaimData.Count;
            int totalBatches = totalRecords / limit;
            int check = totalBatches * limit;
            if (dataCount != check)
                totalBatches++;
            int index = 0;
            var local = new Uri("http://localhost:9200");
            var settings = new ConnectionSettings(local);
            var elastic = new ElasticClient(settings); //ElasticClient 
            elastic.DeleteIndex("claims30");      
            var test1 = elastic.IndexExists("claims30");
            //if index do not exist in elastic
            if (test1.Exists == false)
                CreateIndex_CCLF(elastic, "claims30");
            for (int i = 0; i < totalBatches; i++)
            {
                var descriptor = new BulkDescriptor();
                descriptor.Index("claims30");
                int batchCount = limit;
                for (int y = 0; y < batchCount; y++)
                {
                    if (index >= totalRecords)
                        break;
                    var test = ClaimData[index];
                    descriptor.Index<Claim>(op => op.Document(test).Id(test.ID));
                    index++;
                }
                int cnt = ((i + 1) * limit);
                if (index >= totalRecords)
                    cnt = totalRecords;
                var bulkResult = elastic.Bulk(descriptor);
                Status.AppendText(cnt.ToString() + " Inserted" + Environment.NewLine);
                Status.AppendText(bulkResult.ToString() + Environment.NewLine);
                Status.Refresh();
                descriptor = null;
                GC.WaitForPendingFinalizers();
            }

        }
        public void CreateIndex_CCLF(ElasticClient client, string indexName)
        {
            indexName = "claims30";
            var descriptor = new CreateIndexDescriptor(indexName)
            .Mappings(ms => ms.Map<Claim>(m => m.AutoMap()).Map<ClaimLine>(m => m.AutoMap()).Map<Procedure>(m => m.AutoMap()).Map<Diagnosis>(m => m.AutoMap()));
            client.CreateIndex(descriptor);
        }
        /// <summary>
        /// to format the given date
        /// </summary>
        /// <param name="tempDate"></param>
        /// <returns></returns>
        public string FormatDate(string tempDate)
        {
            string[] format = { "yyyyMMdd" };
            string formattedDate = "";
            DateTime tempDate1;
            if (DateTime.TryParseExact(tempDate,
                           format,
                           System.Globalization.CultureInfo.InvariantCulture,
                           System.Globalization.DateTimeStyles.None,
                           out tempDate1))
            {
                formattedDate = tempDate1.ToString("yyyyMMdd");
            }
            else
            {
                formattedDate = System.DateTime.Now.ToString("yyyyMMdd");
            }
            return (formattedDate);

        }
        private void ProgressCount_TextChanged(object sender, EventArgs e)
        {

        }

    }

  
}
