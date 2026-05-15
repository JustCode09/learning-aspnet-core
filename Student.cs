namespace MyFirstWebAPI
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double GPA { get; set; }

        public void Introduce()
        {
            Console.WriteLine($"Hi, I am {Name}, Age: {Age}, GPA: {GPA}");
        }
    }
}