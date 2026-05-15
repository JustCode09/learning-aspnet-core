// Creating student objects
using MyFirstWebAPI;

Student student1 = new Student();
student1.Id = 1;
student1.Name = "Ram";
student1.Age = 20;
student1.GPA = 3.5;

Student student2 = new Student();
student2.Id = 2;
student2.Name = "Sita";
student2.Age = 22;
student2.GPA = 3.8;

// Call the method
student1.Introduce();
student2.Introduce();

// Print individual properties
Console.WriteLine($"Student 1 ID: {student1.Id}");
Console.WriteLine($"Student 2 Name: {student2.Name}");