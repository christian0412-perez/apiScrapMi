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
    
    public partial class MovementDetail
    {
        public int MovementID { get; set; }
        public int WorkOrderID { get; set; }
        public string ProductSKU { get; set; }
        public string SubProductSKU { get; set; }
        public int BinID { get; set; }
        public int Quantity { get; set; }
        public string CreateUser { get; set; }
        public System.DateTime CreateDate { get; set; }
    }
}
