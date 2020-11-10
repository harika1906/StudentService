using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace StudentData.StudentDetails
{
   [Table("Student")]
   public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public int Rollno { get; set; }
        public int Class { get; set; }
        public string School { get; set; }
    }
}
