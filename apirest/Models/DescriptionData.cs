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
    
    public partial class DescriptionData
    {
        public int DescriptionID { get; set; }
        public string SKU { get; set; }
        public int CompanyID { get; set; }
        public int LanguageID { get; set; }
        public string Title60 { get; set; }
        public string Title80 { get; set; }
        public string Title200 { get; set; }
        public string Bullet1 { get; set; }
        public string Bullet2 { get; set; }
        public string Bullet3 { get; set; }
        public string Bullet4 { get; set; }
        public string Bullet5 { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
        public string SearchTerms { get; set; }
        public bool isActive { get; set; }
        public string EnteredBy { get; set; }
        public System.DateTime EnteredDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual LanguageCode LanguageCode { get; set; }
    }
}