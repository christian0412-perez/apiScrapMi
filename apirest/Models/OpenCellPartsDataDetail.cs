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
    
    public partial class OpenCellPartsDataDetail
    {
        public int PartsdataDetailID { get; set; }
        public int CompanyID { get; set; }
        public int PartsDataID { get; set; }
        public int WorkCenterID { get; set; }
        public string SerialNumber { get; set; }
        public string Opencell { get; set; }
        public bool IsActive { get; set; }
        public string EnteredBy { get; set; }
        public System.DateTime EnteredDate { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
    }
}
