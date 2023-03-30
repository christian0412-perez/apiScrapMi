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
    
    public partial class GlobalTransferStatu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GlobalTransferStatu()
        {
            this.GlobalTransferHistories = new HashSet<GlobalTransferHistory>();
            this.GlobalTransfers = new HashSet<GlobalTransfer>();
        }
    
        public byte StatusID { get; set; }
        public string StatusName { get; set; }
        public byte ProcessSequence { get; set; }
        public System.DateTime EnteredDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GlobalTransferHistory> GlobalTransferHistories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<GlobalTransfer> GlobalTransfers { get; set; }
    }
}
