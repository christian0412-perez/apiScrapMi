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
    
    public partial class HistoryWorkOrder
    {
        public int HistoryID { get; set; }
        public int WorkOrderID { get; set; }
        public int StatusID { get; set; }
        public string Comment { get; set; }
        public string CreateUser { get; set; }
        public System.DateTime CreateDate { get; set; }
    
        public virtual StatusWorkOrder StatusWorkOrder { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
    }
}
