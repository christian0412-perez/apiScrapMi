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
    
    public partial class sp_FilterBinList_Result
    {
        public int BinID { get; set; }
        public string BinCode { get; set; }
        public int BinTypeID { get; set; }
        public string BinTypeName { get; set; }
        public int LocationID { get; set; }
        public string LocationName { get; set; }
        public int WarehouseID { get; set; }
        public string WarehouseName { get; set; }
        public string WarehouseCode { get; set; }
        public bool isActive { get; set; }
        public string EnteredBy { get; set; }
        public string EnteredDate { get; set; }
    }
}
