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
    
    public partial class PurchasePalletDetail
    {
        public int PurchasePalletDetailID { get; set; }
        public int PurchasePalletID { get; set; }
        public int PurchaseID { get; set; }
        public int CompanyID { get; set; }
        public string LicensePlateNumber { get; set; }
        public int WorkCenterID { get; set; }
        public string EnteredBy { get; set; }
        public System.DateTime EnteredDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }
}