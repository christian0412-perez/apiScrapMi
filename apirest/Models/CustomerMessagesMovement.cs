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
    
    public partial class CustomerMessagesMovement
    {
        public int Id { get; set; }
        public int CustomerMessages_Id { get; set; }
        public bool IsOpen { get; set; }
        public System.DateTime RegisterDate { get; set; }
        public string RegisterBy { get; set; }
    
        public virtual CustomerMessage CustomerMessage { get; set; }
    }
}