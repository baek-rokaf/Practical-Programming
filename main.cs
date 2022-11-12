using System;

namespace CSharpExample
{
    public class Student
    {
        public string Name { get; private set; }
        public string ID { get; private set; }
        public Student(string name, string id)
        {
            Name = name;
            ID = id;
        }

        public bool TryChangeName(string name)
        {
            if (Name != name)
            {
                Name = name;
                return true;
            }
            return false;
        }
    }
}

namespace CSharpExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Pope Kim", "a123456");
            student.TryChangeName("Babo Kim");

            Console.WriteLine("Student name: {0}\n Student ID: {1}", student.Name, student.ID);
        }
    }
}