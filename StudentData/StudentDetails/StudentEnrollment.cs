using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace StudentData.StudentDetails
{
   public class StudentEnrollment
    {
        [Key]
        public int ID { get; set; }
        public string Category { get; set; }
        public string CourseTitle { get; set; }
        public virtual Student StudentId { get; set; }
    }
}
