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
    
    public partial class sp_GetPurchasePalletQtyReceived_Result
    {
        public int PurchaseID { get; set; }
        public string PONumber { get; set; }
        public string SupplierName { get; set; }
        public string LoadDate { get; set; }
        public int TotalQtyOrdered { get; set; }
        public int TotalQtyReceived { get; set; }
        public int TotalPalletQtyReceived { get; set; }
        public int TotalInspectionQtyReceived { get; set; }
        public string PurchasePallets { get; set; }
    }
}