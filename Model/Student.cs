//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace test.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Student()
        {
            this.Student_Answer = new HashSet<Student_Answer>();
            this.Student_Result = new HashSet<Student_Result>();
        }
    
        public int Student_ID { get; set; }
        public string Student_Name { get; set; }
        public Nullable<int> Track_ID { get; set; }
        public Nullable<int> Intake_ID { get; set; }
        public Nullable<int> Login_ID { get; set; }
    
        public virtual Intake Intake { get; set; }
        public virtual Login Login { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Answer> Student_Answer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Student_Result> Student_Result { get; set; }
        public virtual Track Track { get; set; }
    }
}
