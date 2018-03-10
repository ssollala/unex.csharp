using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericUsage
{
    public class Person
    {
        public int Age { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }

        public Person() { }
        public Person(string firstName, string lastName, int age)
        {
            Age = age;
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"(Name : {LastName}, {FirstName}, Age: {Age})";
        }


    }
}
