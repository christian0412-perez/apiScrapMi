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
    
    public partial class sp_GetCompatibilityOC_ByModel_Result
    {
        public string ManufacturerPN { get; set; }
        public string PartNumber { get; set; }
        public int SKU { get; set; }
        public Nullable<int> QOH { get; set; }
        public string Customers { get; set; }
        public Nullable<bool> hasInventory { get; set; }
    }
}