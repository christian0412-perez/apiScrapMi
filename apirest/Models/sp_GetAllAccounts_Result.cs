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
    
    public partial class sp_GetAllAccounts_Result
    {
        public int Id { get; set; }
        public string NameComplete { get; set; }
        public string Names { get; set; }
        public string Surnames { get; set; }
        public Nullable<int> EmployeeNumbr { get; set; }
        public string Email { get; set; }
        public Nullable<int> DepartmentId { get; set; }
        public string Description { get; set; }
        public string Position { get; set; }
        public bool IsRoot { get; set; }
        public bool IsActive { get; set; }
        public bool IsFirstUse { get; set; }
        public string BlockDate { get; set; }
        public string RegisterDate { get; set; }
        public Nullable<int> LocationID { get; set; }
        public string LocationName { get; set; }
        public string WarehouseCode { get; set; }
    }
}
