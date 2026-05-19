using Microsoft.AspNetCore.Mvc;
using MyFirstWebAPI.Models;

namespace MyFirstWebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private static List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Ram", Age = 20, GPA = 3.92 },
            new Student { Id = 2, Name = "Sita", Age = 22, GPA = 3.4 },
            new Student { Id = 3, Name = "Hari", Age = 21, GPA = 3.7 }
        };

        [HttpGet]
        public IActionResult GetAllStudents()
        {
            return Ok(students);
        }

        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                return NotFound($"Student with ID {id} not found");
            }
            return Ok(student);
        }

        [HttpPost]
        public IActionResult AddStudent(Student student)
        {
            student.Id = students.Count + 1;
            students.Add(student);
            return CreatedAtAction(nameof(GetStudent),
                                  new { id = student.Id },
                                  student);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, Student updatedStudent)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                return NotFound($"Student with ID {id} not found");
            }
            student.Name = updatedStudent.Name;
            student.Age = updatedStudent.Age;
            student.GPA = updatedStudent.GPA;
            return Ok(student);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student == null)
            {
                return NotFound($"Student with ID {id} not found");
            }
            students.Remove(student);
            return Ok($"Student {student.Name} deleted successfully");
        }
    }
}
