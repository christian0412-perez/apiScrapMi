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
    
    public partial class fn_TGetPriceCalculationsByCategorySKU_Result
    {
        public int PriceCalculationID { get; set; }
        public int CompanyID { get; set; }
        public int ConceptID { get; set; }
        public string Type { get; set; }
        public string SKU { get; set; }
        public decimal FloorPrice { get; set; }
        public int CountryID { get; set; }
        public string Code { get; set; }
        public decimal Freight { get; set; }
        public bool Apply_IGI { get; set; }
        public Nullable<decimal> PIGI { get; set; }
        public Nullable<decimal> IGI { get; set; }
        public bool Apply_IVA { get; set; }
        public Nullable<decimal> PIVA { get; set; }
        public Nullable<decimal> IVA { get; set; }
        public decimal DocOverhead { get; set; }
        public decimal eComShipping { get; set; }
        public decimal Other { get; set; }
        public Nullable<decimal> SubTotal { get; set; }
        public decimal PeComMarketplaceFee { get; set; }
        public Nullable<decimal> eComMarketplaceFee { get; set; }
        public Nullable<decimal> TotalFloor { get; set; }
        public Nullable<decimal> ExchageRate { get; set; }
        public Nullable<decimal> TotalFloorLocal { get; set; }
        public string LastUpdateUser { get; set; }
        public System.DateTime LastUpdate { get; set; }
    }
}