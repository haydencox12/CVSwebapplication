//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CVSwebapplication.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Registrations
    {
        public string RegistrationID { get; set; }
        public string StudentID { get; set; }
        public string CourseID { get; set; }
        public string TermID { get; set; }
        public Nullable<System.DateTime> RegistrationDate { get; set; }
    
        public virtual Courses Courses { get; set; }
        public virtual Students Students { get; set; }
        public virtual StudyTerms StudyTerms { get; set; }
    }
}
