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
    
    public partial class Teacher
    {
        public Teacher()
        {
            this.CourseAssigns = new HashSet<CourseAssign>();
        }
    
        public int teacherID { get; set; }
        public string teacherName { get; set; }
        public string teacherAddress { get; set; }
        public string teacherEmail { get; set; }
        public Nullable<long> teacherContactNo { get; set; }
        public Nullable<double> CreditToBeTaken { get; set; }
        public string depCode { get; set; }
        public Nullable<int> DesignationID { get; set; }
    
        public virtual ICollection<CourseAssign> CourseAssigns { get; set; }
        public virtual Department Department { get; set; }
        public virtual Designation Designation { get; set; }
    }
}