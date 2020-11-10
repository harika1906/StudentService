using Microsoft.AspNetCore.Mvc;
using StudentData;
using StudentData.StudentDetails;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentService.Controllers
{
    [Route("api/[controller]")]
    public class StudentController:ControllerBase
    {
        private readonly IStudentRepository _studentRepository;
        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;

        }
        [HttpGet]
        [Route("click/{id}")]
        public IActionResult GetResult(int id)
        {

            var student = _studentRepository.GetStudent(id);
            return Ok(student);

        }
    }
}
