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
    
    public partial class AuditWarehouseLocation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AuditWarehouseLocation()
        {
            this.AuditWarehouseLocationsDetails = new HashSet<AuditWarehouseLocationsDetail>();
        }
    
        public int AuditID { get; set; }
        public int LocationID { get; set; }
        public int CompanyID { get; set; }
        public bool AuditComplete { get; set; }
        public bool isActive { get; set; }
        public string Comment { get; set; }
        public string EnteredBy { get; set; }
        public System.DateTime EnteredDate { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual WarehouseLocation WarehouseLocation { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AuditWarehouseLocationsDetail> AuditWarehouseLocationsDetails { get; set; }
    }
}