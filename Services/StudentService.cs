using MyFirstWebAPI.Data;
using MyFirstWebAPI.Models;

namespace MyFirstWebAPI.Services
{
    public class StudentService : IStudentService
    {
        // Door to database
        private readonly AppDbContext _context;

        // .NET gives us database automatically
        public StudentService(AppDbContext context)
        {
            _context = context;
        }

        // CREATE
        public Student AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }

        // READ ALL
        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        // READ ONE
        public Student GetStudentById(int id)
        {
            return _context.Students
                   .FirstOrDefault(s => s.Id == id);
        }

        // UPDATE
        public Student UpdateStudent(int id, Student updatedStudent)
        {
            var student = _context.Students
                          .FirstOrDefault(s => s.Id == id);
            if (student == null) return null;

            student.Name = updatedStudent.Name;
            student.Age = updatedStudent.Age;
            student.GPA = updatedStudent.GPA;

            _context.SaveChanges();
            return student;
        }

        // DELETE
        public bool DeleteStudent(int id)
        {
            var student = _context.Students
                          .FirstOrDefault(s => s.Id == id);
            if (student == null) return false;

            _context.Students.Remove(student);
            _context.SaveChanges();
            return true;
        }
    }
}