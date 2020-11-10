using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentData.StudentDetails
{
   public class StudentCourse
    {
        [Key]
        public int ID { get; set; }
        public int CourseCode { get; set; }
        public  virtual Student StudentID { get; set; }
    }
}
