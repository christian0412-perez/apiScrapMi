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
    
    public partial class sp_FilterSupplierByCompanyOrAvailability_Result
    {
        public int SupplierID { get; set; }
        public string SupplierName { get; set; }
        public string ContactName { get; set; }
        public string Email { get; set; }
        public string ContactPhone { get; set; }
        public string Address { get; set; }
        public int CompanyID { get; set; }
        public string CompanyName { get; set; }
        public bool isActive { get; set; }
        public string EnteredBy { get; set; }
        public string EnteredDate { get; set; }
    }
}
