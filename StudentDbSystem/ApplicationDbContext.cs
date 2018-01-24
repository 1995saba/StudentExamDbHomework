using StudentDbSystem.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDbSystem
{
    public class ApplicationDbContext:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<StudentExam> StudentExams { get; set; }
        public DbSet<StudentExamDocument> Documents { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new StudentConfiguration());
            modelBuilder.Configurations.Add(new ExamConfiguration());
            modelBuilder.Configurations.Add(new StudentExamConfiguration());
            modelBuilder.Configurations.Add(new StudentExamDocumentConfiguration());
            base.OnModelCreating(modelBuilder);
        }
        public ApplicationDbContext():base("name=ConnectionString")
        {

        }
    }
}
