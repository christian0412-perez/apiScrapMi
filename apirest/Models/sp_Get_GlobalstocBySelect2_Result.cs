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
    
    public partial class sp_Get_GlobalstocBySelect2_Result
    {
        public int id { get; set; }
        public int CompanyId { get; set; }
        public string NameReport { get; set; }
        public Nullable<int> Inventory { get; set; }
        public Nullable<int> Warehouse { get; set; }
        public string WharehouseName { get; set; }
        public Nullable<int> Location { get; set; }
        public string LocationName { get; set; }
        public Nullable<int> Binid { get; set; }
        public string BinName { get; set; }
        public string Search { get; set; }
        public string Condition { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Size { get; set; }
        public string Category { get; set; }
        public bool IsDefault { get; set; }
        public bool IsActive { get; set; }
        public string CreateDate { get; set; }
        public string CreateUser { get; set; }
    }
}
