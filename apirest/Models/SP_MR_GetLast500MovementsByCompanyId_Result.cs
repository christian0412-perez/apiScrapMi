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
    
    public partial class SP_MR_GetLast500MovementsByCompanyId_Result
    {
        public int BinMovementID { get; set; }
        public int BinMovementTypeID { get; set; }
        public string BinMovementType { get; set; }
        public int Action { get; set; }
        public string ActionType { get; set; }
        public string CompanyName { get; set; }
        public string FromWarehouseCode { get; set; }
        public string FromBin { get; set; }
        public string FromTypeBin { get; set; }
        public string FromLocation { get; set; }
        public string ToWarehouseCode { get; set; }
        public string ToBin { get; set; }
        public string ToBinType { get; set; }
        public string ToLocation { get; set; }
        public string ProductSKU { get; set; }
        public int Qty { get; set; }
        public string Comments { get; set; }
        public string MovementDate { get; set; }
        public string MovementBy { get; set; }
    }
}
