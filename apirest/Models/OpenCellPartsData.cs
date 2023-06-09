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
    
    public partial class OpenCellPartsData
    {
        public int Id { get; set; }
        public int CompanyId { get; set; }
        public int WorkCenterId { get; set; }
        public int CategoryId { get; set; }
        public string LCN { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string SKU { get; set; }
        public int ScreenSize { get; set; }
        public string SerialNumber { get; set; }
        public string Version { get; set; }
        public string Opencell { get; set; }
        public string Main { get; set; }
        public string TCon { get; set; }
        public bool IsActive { get; set; }
        public string EnteredBy { get; set; }
        public System.DateTime EnteredDate { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    }
}
