// Inheritance
using MyFirstWebAPI;

Student student = new Student();
student.Name = "Ram";
student.Age = 20;
student.GPA = 3.5;
student.Introduce();
student.ShowGPA();

Teacher teacher = new Teacher();
teacher.Name = "Mr. Sharma";
teacher.Age = 35;
teacher.Subject = "Math";
teacher.Introduce();
teacher.ShowSubject();