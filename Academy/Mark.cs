//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Academy
{
    using System;
    using System.Collections.Generic;
    
    public partial class Mark
    {
        public int Id { get; set; }
        public int StudentId { get; set; }
        public int ExamId { get; set; }
        public int SubjectId { get; set; }
        public Nullable<int> Mark1 { get; set; }
        public string Pass { get; set; }
    
        public virtual Exam Exam { get; set; }
        public virtual User User { get; set; }
        public virtual Subject Subject { get; set; }
    }
}