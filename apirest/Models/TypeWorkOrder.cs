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
    
    public partial class TypeWorkOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TypeWorkOrder()
        {
            this.WorkOrders = new HashSet<WorkOrder>();
        }
    
        public int WOTypeID { get; set; }
        public string WOName { get; set; }
        public bool isActive { get; set; }
        public string CreateUser { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string ChangeUser { get; set; }
        public Nullable<System.DateTime> ChangeDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}
