using MyFirstWebAPI.Models;

namespace MyFirstWebAPI.Services
{
    public class StudentService : IStudentService
    {
        // Our fake database
        private static List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Ram",  Age = 20, GPA = 3.9 },
            new Student { Id = 2, Name = "Sita", Age = 22, GPA = 3.4 },
            new Student { Id = 3, Name = "Hari", Age = 21, GPA = 3.7 }
        };

        // CREATE
        public Student AddStudent(Student student)
        {
            student.Id = students.Count + 1;
            students.Add(student);
            return student;
        }

        // READ ALL
        public List<Student> GetAllStudents()
        {
            return students;
        }

        // READ ONE
        public Student GetStudentById(int id)
        {
            return students.FirstOrDefault(s => s.Id == id);
        }

        // UPDATE
        public Student UpdateStudent(int id, Student updatedStudent)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student == null) return null;

            student.Name = updatedStudent.Name;
            student.Age = updatedStudent.Age;
            student.GPA = updatedStudent.GPA;
            return student;
        }

        // DELETE
        public bool DeleteStudent(int id)
        {
            var student = students.FirstOrDefault(s => s.Id == id);
            if (student == null) return false;

            students.Remove(student);
            return true;
        }
    }
}