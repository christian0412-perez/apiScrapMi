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
    
    public partial class ProductCondition
    {
        public int Id { get; set; }
        public string ConditionName { get; set; }
        public string Suffix { get; set; }
        public bool IsByDefault { get; set; }
        public int CompanyID { get; set; }
        public bool IsActive { get; set; }
        public Nullable<System.DateTime> RegisterDate { get; set; }
    
        public virtual Company Company { get; set; }
    }
}
