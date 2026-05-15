using MyFirstWebAPI;

List<Student> students = new List<Student>
{
    new Student { Id = 1, Name = "Ram", Age = 20, GPA = 3.9 },
    new Student { Id = 2, Name = "Sita", Age = 22, GPA = 3.4 },
    new Student { Id = 3, Name = "Hari", Age = 21, GPA = 3.7 },
    new Student { Id = 4, Name = "Gita", Age = 20, GPA = 2.9 },
    new Student { Id = 5, Name = "Mohan", Age = 23, GPA = 3.6 }
};

// 1. Where - students with GPA above 3.5
Console.WriteLine("=== Top Students (GPA > 3.5) ===");
var topStudents = students.Where(s => s.GPA > 3.5).ToList();
foreach (var s in topStudents)
{
    Console.WriteLine($"{s.Name} - GPA: {s.GPA}");
}

// 2. FirstOrDefault - find by ID
Console.WriteLine("\n=== Find Student ID 3 ===");
var found = students.FirstOrDefault(s => s.Id == 3);
if (found == null)
{
    Console.WriteLine("Not found");
}
else
{
    Console.WriteLine($"Found: {found.Name}");
}

// 3. OrderBy - sort by name
Console.WriteLine("\n=== Students Sorted A-Z ===");
var sorted = students.OrderBy(s => s.Name).ToList();
foreach (var s in sorted)
{
    Console.WriteLine(s.Name);
}

// 4. Count with condition
int topCount = students.Count(s => s.GPA > 3.5);
Console.WriteLine($"\nTotal top students: {topCount}");