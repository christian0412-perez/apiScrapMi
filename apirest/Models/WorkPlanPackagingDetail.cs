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
    using System.Collections.Generic;
    
    public partial class WorkPlanPackagingDetail
    {
        public int PackagingDetialID { get; set; }
        public int CompanyID { get; set; }
        public int PackagingID { get; set; }
        public string LicensePlateNumber { get; set; }
        public Nullable<int> BinMovementID { get; set; }
        public bool isActive { get; set; }
        public string EnteredBy { get; set; }
        public System.DateTime EnteredDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string SKU { get; set; }
        public Nullable<int> ClassificationID { get; set; }
    
        public virtual WorkPlan WorkPlan { get; set; }
        public virtual WorkPlanPackaging WorkPlanPackaging { get; set; }
    }
}
