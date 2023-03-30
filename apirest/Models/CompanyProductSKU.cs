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
    
    public partial class CompanyProductSKU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CompanyProductSKU()
        {
            this.BinContents = new HashSet<BinContent>();
            this.BinMovements = new HashSet<BinMovement>();
        }
    
        public int CompanyID { get; set; }
        public string ProductSKU { get; set; }
        public string ProductDescription { get; set; }
        public string SupplierSKU { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public decimal UnitCost { get; set; }
        public bool isActive { get; set; }
        public bool isNotSynchronized { get; set; }
        public string EnteredBy { get; set; }
        public System.DateTime EnteredDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BinContent> BinContents { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BinMovement> BinMovements { get; set; }
    }
}