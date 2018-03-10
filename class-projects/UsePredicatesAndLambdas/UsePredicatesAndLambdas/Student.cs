using System.Collections.Generic;

namespace UsePredicatesAndLambdas
{
    public class Student
    {   
        public string Name { get; set; }
        public int Age { get; set; }

        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }

        public static List<Student> GetStudentData()
        {
            return new List<Student>()
            {
                new Student("Carol Smith", 15),
                new Student("Bruce Lee", 20),
                new Student("Anna Gonzalez", 15),
                new Student("Bill Burns", 24),
                new Student("Alice Jones", 24),
                new Student("Homer Smith", 18)
            };
        }

        public override string ToString()
        {
            return $"Name: {Name}, Age: {Age}";
        }

    }
}
