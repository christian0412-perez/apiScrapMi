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
    
    public partial class Customer_History
    {
        public int Customer_History_Id { get; set; }
        public int Customer_Id { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string CreateUser { get; set; }
        public string Change { get; set; }
    }
}
