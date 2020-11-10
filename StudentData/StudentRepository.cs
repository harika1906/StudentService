using Microsoft.EntityFrameworkCore;
using StudentData.Context;
using StudentData.Model;
using StudentData.StudentDetails;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentData
{
    public class StudentRepository : IStudentRepository
    {
        private readonly IStudentContext _studentContext;
        public StudentRepository(IStudentContext studentContext)
        {
            _studentContext = studentContext;
        }
        public Student GetStudent(int id)
        {
            var student=_studentContext.Students.FirstOrDefault(x => x.StudentID == id);
            return student;
        }

        

        public List<CourseDto> GetCoursesById(int id)
        {
            var optionsBuilder = new DbContextOptionsBuilder<StudentContext>();
            optionsBuilder.UseSqlServer("Data Source=StudentDb.db");
            using (var db = new StudentContext(optionsBuilder.Options))
            {

                var courses = (from  st in db.Students
                           join course in db.studentCourses
                           on st.StudentID equals course.StudentID
                           into stcourse
                           from course in stcourse.DefaultIfEmpty()

                           where st.StudentID == id
                           select new CourseDto
                           {
                               Studentid=st.StudentID,
                               CourseNo=course.CourseCode,
                               Id=course.ID,
                               school=st.School

                           }).ToList();
                return courses;



            }
        }

    }
    

    
    public interface IStudentRepository
    {
        Student GetStudent(int id);
    }
    
}
