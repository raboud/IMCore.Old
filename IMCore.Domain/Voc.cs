using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace IMCore.Domain
{
    [Table("VOC")]
    public partial class VOC
    {
        [Column("Id")]
        public int Id { get; set; }
        public int? OrderId { get; set; }
        [Column("Pvendor_Nbr")]
        public short? PvendorNbr { get; set; }
        [Column("Pvendor_Name")]
        [StringLength(24)]
        public string PvendorName { get; set; }
        [Column("Project_Code")]
        public short? ProjectCode { get; set; }
        [Column("Project_Name")]
        [StringLength(50)]
        public string ProjectName { get; set; }
        [Column("Survey_Date", TypeName = "datetime")]
        public DateTime? SurveyDate { get; set; }
        [Column("Key_Rec_Date", TypeName = "datetime")]
        public DateTime? KeyRecDate { get; set; }
        [Column("Mvendor_Nbr")]
        public int? MvendorNbr { get; set; }
        [Column("Mvendor_Name")]
        [StringLength(24)]
        public string MvendorName { get; set; }
        [Column("Store_Nbr")]
        public short? StoreNbr { get; set; }
        [Column("PO_Nbr")]
        public int? PoNbr { get; set; }
        [Column("Overall_Sat")]
        public short? OverallSat { get; set; }
        public short? Referral { get; set; }
        public short? Loyalty { get; set; }
        [Column("Shopping_Overall")]
        public short? ShoppingOverall { get; set; }
        [Column("Measure_Consult_Overall")]
        public short? MeasureConsultOverall { get; set; }
        [Column("Product_Overall")]
        public short? ProductOverall { get; set; }
        [Column("Value_Overall")]
        public short? ValueOverall { get; set; }
        [Column("Installer_Overall")]
        public short? InstallerOverall { get; set; }
        [Column("Installer_On_Time")]
        public short? InstallerOnTime { get; set; }
        [Column("Installer_Courtesy")]
        public short? InstallerCourtesy { get; set; }
        [Column("Installer_Care")]
        public short? InstallerCare { get; set; }
        [Column("Installer_Appearance")]
        public short? InstallerAppearance { get; set; }
        [Column("Installer_Cleanup")]
        public short? InstallerCleanup { get; set; }
        [Column("Installer_Review_Project")]
        public short? InstallerReviewProject { get; set; }
        [Column("Installer_Complete_On_Time")]
        public short? InstallerCompleteOnTime { get; set; }
        [Column("Installer_Informing")]
        public short? InstallerInforming { get; set; }
        [Column("Installer_Other_Comments")]
        public string InstallerOtherComments { get; set; }
        [Column("Installer_Attributes_Aggregated")]
        public float? InstallerAttributesAggregated { get; set; }
        [Column("Workmanship_Overall")]
        public short? WorkmanshipOverall { get; set; }
        [Column("Communication_Overall")]
        public short? CommunicationOverall { get; set; }
        [Column("Complete_Within_Timeframe")]
        public short? CompleteWithinTimeframe { get; set; }
        [Column("After_Sales_Svc_Overall")]
        public short? AfterSalesSvcOverall { get; set; }
        [Column("Issue_Occurred")]
        public short? IssueOccurred { get; set; }
        [Column("Issue_Workmanship")]
        public short? IssueWorkmanship { get; set; }
        [Column("Issue_Material_Quality")]
        public short? IssueMaterialQuality { get; set; }
        [Column("Issue_Property_Damage")]
        public short? IssuePropertyDamage { get; set; }
        [Column("Issue_Installer_Professionalism")]
        public short? IssueInstallerProfessionalism { get; set; }
        [Column("Issue_Store_Support")]
        public short? IssueStoreSupport { get; set; }
        [Column("Issue_Damaged_Product")]
        public short? IssueDamagedProduct { get; set; }
        [Column("Issue_Incorrect_Measurement")]
        public short? IssueIncorrectMeasurement { get; set; }
        [Column("Issue_Customer_Service")]
        public short? IssueCustomerService { get; set; }
        [Column("Issue_Communication")]
        public short? IssueCommunication { get; set; }
        [Column("Issue_Completion_Time")]
        public short? IssueCompletionTime { get; set; }
        [Column("Issue_Other")]
        public string IssueOther { get; set; }
        [Column("Issue_Resolved")]
        public short? IssueResolved { get; set; }
        [Column("Issue_Handling_Overall")]
        public short? IssueHandlingOverall { get; set; }
        [Column("Final_Comments")]
        public string FinalComments { get; set; }
        [Column("General_Comment")]
        public string GeneralComment { get; set; }
        [Column("Intrvw_Fiscal_Week")]
        public short? IntrvwFiscalWeek { get; set; }
        [Column("Intrvw_Fiscal_Month")]
        public short? IntrvwFiscalMonth { get; set; }
        [Column("Intrvw_Fiscal_Quarter")]
        public short? IntrvwFiscalQuarter { get; set; }
        [Column("Intrvw_Fiscal_Year")]
        public short? IntrvwFiscalYear { get; set; }
        [Column("Division_Name")]
        [StringLength(50)]
        public string DivisionName { get; set; }
        [Column("Region_Name")]
        [StringLength(50)]
        public string RegionName { get; set; }
        [Column("Department_Nbr")]
        public short? DepartmentNbr { get; set; }
        [Column("Class_Nbr")]
        public short? ClassNbr { get; set; }
        [Column("Subclass_Nbr")]
        public short? SubclassNbr { get; set; }
        [Column("Reference_Nbr")]
        public long? ReferenceNbr { get; set; }
        [Column("Correct_Project")]
        public short? CorrectProject { get; set; }
        [Column("Market_Nbr")]
        public short? MarketNbr { get; set; }
        [Column("Market_Name")]
        [StringLength(50)]
        public string MarketName { get; set; }
        [Column("SKU")]
        public int? Sku { get; set; }

        [ForeignKey("OrderId")]
        [InverseProperty("Voc")]
        public virtual Order Order { get; set; }
    }
}
