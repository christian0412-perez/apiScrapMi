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
    
    public partial class WorkPlanRepair
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WorkPlanRepair()
        {
            this.WorkPlanRepairApplieds = new HashSet<WorkPlanRepairApplied>();
            this.WorkPlanRepairAwaitings = new HashSet<WorkPlanRepairAwaiting>();
            this.WorkPlanRepairHistories = new HashSet<WorkPlanRepairHistory>();
        }
    
        public int RepairID { get; set; }
        public int CompanyID { get; set; }
        public string LicensePlateNumber { get; set; }
        public int StatusID { get; set; }
        public bool isActive { get; set; }
        public string RepairingBy { get; set; }
        public System.DateTime RepairingDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkPlanRepairApplied> WorkPlanRepairApplieds { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkPlanRepairAwaiting> WorkPlanRepairAwaitings { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkPlanRepairHistory> WorkPlanRepairHistories { get; set; }
        public virtual WorkPlanRepairStatu WorkPlanRepairStatu { get; set; }
    }
}