using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDbSystem.Domain
{
    public class StudentExamDocument
    {
        public int DocumentId { get; set; }
        public string DocumentName { get; set; }
        public int StudentId { get; set; }
        public int ExamId { get; set; }
        public StudentExam Exam { get; set; }
    }

    public class StudentExamDocumentConfiguration : EntityTypeConfiguration<StudentExamDocument>
    {
        public StudentExamDocumentConfiguration()
        {
            HasKey(p => p.DocumentId);

            HasRequired(p => p.Exam)
                .WithMany(p => p.Documents)
                .HasForeignKey(p => new { p.StudentId, p.ExamId });
        }
    }
}
