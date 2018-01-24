using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDbSystem.Domain
{
    public class StudentExam
    {
        public int StudentId { get; set; }
        public int ExamId { get; set; }
        public Student Student { get; set; }
        public Exam Exam { get; set; }
        public ICollection<StudentExamDocument> Documents { get; set; }
    }

    public class StudentExamConfiguration : EntityTypeConfiguration<StudentExam>
    {
        public StudentExamConfiguration()
        {
            HasKey(p => new { p.StudentId, p.ExamId });

            HasRequired(p => p.Student)
                .WithMany(p => p.Exams)
                .HasForeignKey(p => p.StudentId);

            HasRequired(p => p.Exam)
                .WithMany(p => p.Students)
                .HasForeignKey(p => p.ExamId);
        }
    }
}
