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
    
    public partial class Result
    {
        public int resultID { get; set; }
        public Nullable<int> StudentID { get; set; }
        public Nullable<int> CourseID { get; set; }
        public Nullable<int> gradeID { get; set; }
    
        public virtual Course Course { get; set; }
        public virtual Grade Grade { get; set; }
        public virtual Student Student { get; set; }
    }
}