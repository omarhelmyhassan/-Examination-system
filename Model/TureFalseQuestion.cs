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
    
    public partial class TureFalseQuestion
    {
        public int TF_Q_ID { get; set; }
        public Nullable<bool> TF_Correct_Ans { get; set; }
        public Nullable<int> Question_Pool_ID { get; set; }
    
        public virtual QuestionPool QuestionPool { get; set; }
    }
}
