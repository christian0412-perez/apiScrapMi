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
    
    public partial class vw_CompanyProductSKU
    {
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public string ProductSKU { get; set; }
        public string ProductDescription { get; set; }
        public Nullable<int> Qty { get; set; }
        public decimal UnitCost { get; set; }
        public Nullable<int> CategoryID { get; set; }
        public string CategoryName { get; set; }
    }
}
