using Microsoft.AspNetCore.Mvc
using MyFirstWebAPI.Models;
using MyFirstWebAPI.Services;

namespace MyFirstWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        // Controller doesn't create service itself
        // .NET gives it automatically
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        // CREATE
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            var newStudent = _studentService.AddStudent(student);
            return CreatedAtAction(nameof(GetStudent),
                                   new { id = newStudent.Id },
                                   newStudent);
        }

        // READ ALL
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            return Ok(_studentService.GetAllStudents());
        }

        // READ ONE
        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            var student = _studentService.GetStudentById(id);
            if (student == null)
            {
                return NotFound($"Student with ID {id} not found");
            }
            return Ok(student);
        }

        // UPDATE
        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, Student updatedStudent)
        {
            var student = _studentService.UpdateStudent(id, updatedStudent);
            if (student == null)
            {
                return NotFound($"Student with ID {id} not found");
            }
            return Ok(student);
        }

        // DELETE
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var result = _studentService.DeleteStudent(id);
            if (!result)
            {
                return NotFound($"Student with ID {id} not found");
            }
            return Ok("Student deleted successfully");
        }
    }
}
