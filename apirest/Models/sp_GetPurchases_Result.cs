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
    
    public partial class sp_GetPurchases_Result
    {
        public int PurchaseID { get; set; }
        public string LoadID { get; set; }
        public string BTSLoadID { get; set; }
        public string LoadDate { get; set; }
        public string ValuePurchases { get; set; }
        public Nullable<bool> hasWorkPlan { get; set; }
    }
}