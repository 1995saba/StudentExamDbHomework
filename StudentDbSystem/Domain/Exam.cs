using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDbSystem.Domain
{
    public class Exam
    {
        public int ExamId { get; set; }
        public string SubjectName { get; set; }
        public string TeacherName { get; set; }
        public DateTime ExamDate { get; set; }
        public virtual ICollection<StudentExam> Students { get; set; }
    }

    public class ExamConfiguration : EntityTypeConfiguration<Exam>
    {
        public ExamConfiguration()
        {
            HasKey(p => p.ExamId);
        }
    }
}
