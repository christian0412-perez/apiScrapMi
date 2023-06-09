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
    
    public partial class WorkPlanPackaging
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WorkPlanPackaging()
        {
            this.WorkPlanPackagingDetails = new HashSet<WorkPlanPackagingDetail>();
        }
    
        public int PackagingID { get; set; }
        public int CompanyID { get; set; }
        public int ItemQuantity { get; set; }
        public bool wasTransferred { get; set; }
        public bool isActive { get; set; }
        public string EnteredBy { get; set; }
        public System.DateTime EnteredDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> WorkCenterID { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<int> BinId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkPlanPackagingDetail> WorkPlanPackagingDetails { get; set; }
    }
}
