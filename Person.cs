namespace MyFirstWebAPI
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Introduce()
        {
            Console.WriteLine($"Hi, I am {Name}, Age: {Age}");
        }
    }

    public class Teacher : Person
    {
        public string Subject { get; set; }

        public void ShowSubject()
        {
            Console.WriteLine($"{Name} teaches {Subject}");
        }
    }
}