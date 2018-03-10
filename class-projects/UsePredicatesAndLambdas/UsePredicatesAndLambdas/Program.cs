using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsePredicatesAndLambdas
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = Student.GetStudentData();

            Student homer = null;

            foreach(Student s in students)
            {
                if(s.Name == "Homer Smith") {
                    homer = s;
                    break;
                }
               
            }
            if(homer != null)
            {
                Console.WriteLine($"Homer Smith is found: {homer}");
            }

            // Delegate usage...
            // Anonymous method with a delegate
            Student resultStudent = 
                students.Find(delegate (Student s){ return s.Name == "Homer Smith"; });

            Console.WriteLine($"Result of Find Homer Smoth Using a delegate: {resultStudent}");

            // Lambda expression
            var resultStudent2 = 
                students.Find(s => s.Name == "Homer Smith");

            Console.WriteLine($"Result of Find Homer Smoth Using a Lambda Expression: {resultStudent2}");


            // Predicate
            Predicate<Student> homerFinder =
                (Student s) => { return s.Name == "Homer Smith"; };

            var resultStudent3 = students.Find(homerFinder);

            Predicate<Student> fifthteenYearOldFinder =
                (Student s) => { return s.Age == 15; };
           
            // FindAll returns a list of Student       
            var resultStudent4 = students.FindAll(fifthteenYearOldFinder);

            Console.WriteLine($"Student who is 15 year old: ");
            foreach(Student s15 in resultStudent4)
            {
                Console.WriteLine(s15);
            }

            // Lambda Expression
            var result5 =
                students.FindAll(s => s.Age == 24);

            Console.WriteLine("Result of Find Student aged 24 Using a Lambda Expression:");
            foreach(Student s24 in result5)
            {
                Console.WriteLine(s24);
            }


            Console.WriteLine("\nPress <Enter> to quit...");
            Console.ReadKey();
        }
    }
}
