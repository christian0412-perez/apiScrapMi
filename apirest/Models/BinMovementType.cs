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
    
    public partial class BinMovementType
    {
        public int BinMovementTypeID { get; set; }
        public string BinMovementType1 { get; set; }
        public int CompanyID { get; set; }
        public int Action { get; set; }
        public bool isActive { get; set; }
        public bool isCommentRequired { get; set; }
        public bool isCommentOptional { get; set; }
        public bool isNumeric { get; set; }
        public bool isTransferMovement { get; set; }
        public bool isPrintNeed { get; set; }
        public string EnteredBy { get; set; }
        public System.DateTime EnteredDate { get; set; }
        public string Icon { get; set; }
        public string IconColor { get; set; }
    }
}
