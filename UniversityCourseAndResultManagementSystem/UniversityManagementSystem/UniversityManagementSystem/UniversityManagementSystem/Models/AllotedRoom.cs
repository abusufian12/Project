//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UniversityManagementSystem.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AllotedRoom
    {
        public int allotedRoomID { get; set; }
        public string depCode { get; set; }
        public Nullable<int> CourseID { get; set; }
        public Nullable<int> roomID { get; set; }
        public Nullable<int> dayID { get; set; }
        public string fromTime { get; set; }
        public string toTime { get; set; }
        public bool Assign { get; set; }
    
        public virtual AllotedDay AllotedDay { get; set; }
        public virtual Course Course { get; set; }
        public virtual Department Department { get; set; }
        public virtual Room Room { get; set; }
    }
}