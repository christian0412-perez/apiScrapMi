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
    
    public partial class WorkCenter
    {
        public int WorkCenterID { get; set; }
        public int CompanyID { get; set; }
        public string WorkCenterName { get; set; }
        public string Nomenclature { get; set; }
        public bool isActive { get; set; }
        public Nullable<bool> IsProcess { get; set; }
        public string EnteredBy { get; set; }
        public System.DateTime EnteredDate { get; set; }
    
        public virtual Company Company { get; set; }
    }
}
