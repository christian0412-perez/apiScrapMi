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
    
    public partial class CostHistory
    {
        public int CostID { get; set; }
        public int PurchaseDetailID { get; set; }
        public int CompanyID { get; set; }
        public string SKU { get; set; }
        public decimal Cost { get; set; }
        public System.DateTime EnteredDate { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual PurchaseDetail PurchaseDetail { get; set; }
    }
}