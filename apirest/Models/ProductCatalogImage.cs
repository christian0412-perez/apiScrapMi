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
    
    public partial class ProductCatalogImage
    {
        public int ID { get; set; }
        public int CompanyID { get; set; }
        public string ProductSKU { get; set; }
        public string ImageName { get; set; }
        public bool isThumbnail { get; set; }
    }
}