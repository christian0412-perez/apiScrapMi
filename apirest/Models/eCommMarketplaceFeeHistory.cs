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
    
    public partial class eCommMarketplaceFeeHistory
    {
        public int eCommMarketplaceFeeHistoryID { get; set; }
        public int eCommMarketplaceFeeID { get; set; }
        public int ConceptID { get; set; }
        public decimal Percentage { get; set; }
        public string LastUpdateUser { get; set; }
        public System.DateTime LastUpdate { get; set; }
    }
}
