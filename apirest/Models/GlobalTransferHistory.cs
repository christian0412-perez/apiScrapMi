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
    
    public partial class GlobalTransferHistory
    {
        public int GlobalTransferHistoryID { get; set; }
        public int GlobalTransferID { get; set; }
        public byte StatusID { get; set; }
        public string RegisteredBy { get; set; }
        public System.DateTime RegisteredDate { get; set; }
    
        public virtual GlobalTransfer GlobalTransfer { get; set; }
        public virtual GlobalTransferStatu GlobalTransferStatu { get; set; }
    }
}
