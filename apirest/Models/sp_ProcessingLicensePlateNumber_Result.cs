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
    
    public partial class sp_ProcessingLicensePlateNumber_Result
    {
        public Nullable<bool> wasInserted { get; set; }
        public string MessageReturn { get; set; }
        public string LicensePlateNumber { get; set; }
        public string LPNLabel { get; set; }
        public string AccessoriesListLabel { get; set; }
        public string CommentsLabel { get; set; }
        public Nullable<bool> needAccessories { get; set; }
        public Nullable<bool> hasOpenCell { get; set; }
        public string OpenCellPrint { get; set; }
        public Nullable<bool> hasCustomer { get; set; }
        public string CustomerCode { get; set; }
        public string TvVersion { get; set; }
    }
}
