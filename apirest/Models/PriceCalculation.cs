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
    
    public partial class PriceCalculation
    {
        public int PriceCalculationID { get; set; }
        public int CompanyID { get; set; }
        public int ConceptID { get; set; }
        public string SKU { get; set; }
        public decimal FloorPrice { get; set; }
        public decimal Freight { get; set; }
        public decimal DocOverhead { get; set; }
        public decimal eComShipping { get; set; }
        public decimal Other { get; set; }
        public string LastUpdateUser { get; set; }
        public System.DateTime LastUpdate { get; set; }
    }
}
