//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace apirest.Models
{
    using System;
    
    public partial class sp_GetWorkPlanPackagingReport_Result
    {
        public int PackagingID { get; set; }
        public int ItemQuantity { get; set; }
        public bool wasTransferred { get; set; }
        public string BinWarehouseLocation { get; set; }
        public bool isActive { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<int> WorkCenterID { get; set; }
        public string WorkCenterName { get; set; }
        public string ClassificationName { get; set; }
        public string EnteredBy { get; set; }
        public string EnteredDate { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedDate { get; set; }
    }
}