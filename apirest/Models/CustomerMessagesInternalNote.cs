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
    
    public partial class CustomerMessagesInternalNote
    {
        public int Id { get; set; }
        public int CustomerMessages_Id { get; set; }
        public string Note { get; set; }
        public System.DateTime RegisterDate { get; set; }
        public string CreatedBy { get; set; }
    
        public virtual CustomerMessage CustomerMessage { get; set; }
    }
}
