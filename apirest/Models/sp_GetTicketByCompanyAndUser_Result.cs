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
    
    public partial class sp_GetTicketByCompanyAndUser_Result
    {
        public int Ticket_Id { get; set; }
        public string CreateUser { get; set; }
        public string CreateDate { get; set; }
        public string UpdateUser { get; set; }
        public string UpdateDate { get; set; }
        public bool Active { get; set; }
        public int Company_Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Nullable<int> RequiredByUser_Id { get; set; }
        public Nullable<int> RequiredByDepartament_Id { get; set; }
        public string RequiredByDepartament { get; set; }
        public int ForApartment_Id { get; set; }
        public string ForApartment { get; set; }
        public Nullable<int> Priority_Id { get; set; }
        public Nullable<int> Weight { get; set; }
        public Nullable<System.DateTime> DeliverDate { get; set; }
        public int Status_id { get; set; }
        public string StatusName { get; set; }
        public string ForApartment1 { get; set; }
        public string AssignedUsers { get; set; }
        public string StatusChanges { get; set; }
        public string Comments { get; set; }
        public string Attachments { get; set; }
        public string Tags { get; set; }
    }
}
