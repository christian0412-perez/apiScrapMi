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
    
    public partial class POWorkOrder
    {
        public int WorkOrderID { get; set; }
        public string SourceOrderID { get; set; }
        public int CompanyID { get; set; }
        public bool NeedTRGID { get; set; }
        public string ValuePO { get; set; }
    }
}
