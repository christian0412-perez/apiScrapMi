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
    
    public partial class WarehouseLocation
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WarehouseLocation()
        {
            this.AuditWarehouseLocations = new HashSet<AuditWarehouseLocation>();
            this.Bins = new HashSet<Bin>();
            this.WarehouseLocationsForCompanies = new HashSet<WarehouseLocationsForCompany>();
        }
    
        public int LocationID { get; set; }
        public string LocationName { get; set; }
        public int WarehouseID { get; set; }
        public bool isActive { get; set; }
        public string EnteredBy { get; set; }
        public System.DateTime EnteredDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AuditWarehouseLocation> AuditWarehouseLocations { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Bin> Bins { get; set; }
        public virtual Warehouse Warehouse { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WarehouseLocationsForCompany> WarehouseLocationsForCompanies { get; set; }
    }
}