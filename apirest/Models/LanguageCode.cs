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
    
    public partial class LanguageCode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LanguageCode()
        {
            this.DescriptionDatas = new HashSet<DescriptionData>();
        }
    
        public int LanguageID { get; set; }
        public int CompanyID { get; set; }
        public string LanguageCode1 { get; set; }
        public bool isActive { get; set; }
        public string EnteredBy { get; set; }
        public System.DateTime EnteredDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DescriptionData> DescriptionDatas { get; set; }
    }
}