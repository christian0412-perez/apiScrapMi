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
    
    public partial class WorkOrderHistory
    {
        public int HistoryID { get; set; }
        public int WorkOrderID { get; set; }
        public string WOType { get; set; }
        public int CompanyID { get; set; }
        public int StatusID { get; set; }
        public string Comment { get; set; }
        public string EnteredBy { get; set; }
        public System.DateTime EnteredDate { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
        public virtual WorkOrderStatu WorkOrderStatu { get; set; }
    }
}
