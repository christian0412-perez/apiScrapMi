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
    
    public partial class sp_BulkMovementsTrasnsferByCompanyBulkId_Result
    {
        public int Id { get; set; }
        public bool IsReceive { get; set; }
        public string EnteredDate { get; set; }
        public int BinMovementsID { get; set; }
        public Nullable<int> FromBinID { get; set; }
        public string FromBin { get; set; }
        public Nullable<int> ToBinID { get; set; }
        public string ToBin { get; set; }
        public string ProductSKU { get; set; }
        public int Qty { get; set; }
        public Nullable<bool> IsOnStock { get; set; }
    }
}
