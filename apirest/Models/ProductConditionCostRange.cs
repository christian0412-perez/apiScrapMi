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
    
    public partial class ProductConditionCostRange
    {
        public int ProductConditionCostRangeID { get; set; }
        public string SKU { get; set; }
        public int ConditionID { get; set; }
        public decimal CostMin { get; set; }
        public decimal CostMax { get; set; }
        public string CreateBy { get; set; }
        public System.DateTime CreateAt { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateAt { get; set; }
    }
}
