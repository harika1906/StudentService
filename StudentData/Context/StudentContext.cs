using Microsoft.EntityFrameworkCore;
using StudentData.StudentDetails;
using System;
using System.Collections.Generic;

using System.Text;

namespace StudentData.Context
{
   public class StudentContext:DbContext,IStudentContext
    {
      

        public StudentContext(DbContextOptions<StudentContext>options):base(options)
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> studentCourses { get; set; }
        public DbSet<StudentEnrollment> studentEnrollments { get; set; }

       
    }
    public interface IStudentContext
    {
        DbSet<Student> Students { get; set; }
        DbSet<StudentCourse> studentCourses { get; set; }
        DbSet<StudentEnrollment> studentEnrollments { get; set; }

    }
}
