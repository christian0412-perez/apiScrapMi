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
    
    public partial class CategoryComment
    {
        public int CommentID { get; set; }
        public int CompanyID { get; set; }
        public int CategoryID { get; set; }
        public string LabelValue { get; set; }
        public Nullable<int> ClassificationID { get; set; }
        public bool isActive { get; set; }
        public string EnteredBy { get; set; }
        public System.DateTime EnteredDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string ErrorCode { get; set; }
    
        public virtual Company Company { get; set; }
        public virtual CompanyCategory CompanyCategory { get; set; }
    }
}
