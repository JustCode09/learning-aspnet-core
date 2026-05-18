using Microsoft.AspNetCore.Mvc;
using MyFirstWebAPI.Models;

namespace MyFirstWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        // Our fake database for now
        private static List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Ram", Age = 20, GPA = 3.9 },
            new Student { Id = 2, Name = "Sita", Age = 22, GPA = 3.4 },
            new Student { Id = 3, Name = "Hari", Age = 21, GPA = 3.7 }
        };

        // GET api/students → get all students
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            return Ok(students);
        }
    }
}