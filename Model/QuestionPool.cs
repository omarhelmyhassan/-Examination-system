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
    
    public partial class QuestionPool
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public QuestionPool()
        {
            this.Instructor_Exam_Degree = new HashSet<Instructor_Exam_Degree>();
            this.MCQ_Multi_Ans = new HashSet<MCQ_Multi_Ans>();
            this.MCQuestions = new HashSet<MCQuestion>();
            this.TextQuestions = new HashSet<TextQuestion>();
            this.TureFalseQuestions = new HashSet<TureFalseQuestion>();
        }
    
        public int Question_ID { get; set; }
        public string Question { get; set; }
        public Nullable<int> Course_ID { get; set; }
        public Nullable<int> Default_Degree { get; set; }
        public string Q_Type { get; set; }
    
        public virtual Cours Cours { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Instructor_Exam_Degree> Instructor_Exam_Degree { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MCQ_Multi_Ans> MCQ_Multi_Ans { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MCQuestion> MCQuestions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TextQuestion> TextQuestions { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TureFalseQuestion> TureFalseQuestions { get; set; }
    }
}
