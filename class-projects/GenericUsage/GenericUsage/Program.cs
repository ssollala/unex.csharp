using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericUsage
{
    class Program
    {
        static void Main(string[] args)
        {
            int i1 = 42, i2 = 2;
            Console.WriteLine($"Before swap: {i1}, {i2}");
            Utilities.Swap<int>(ref i1, ref i2);
            Console.WriteLine($"After swap: {i1}, {i2}");

            Person p1 = new Person("Jose", "Gonzales", 20);
            Person p2 = new Person("Kim", "Lee", 31);
            Console.WriteLine($"Before swap: {p1}, {p2}");
            Utilities.Swap<Person>(ref p1, ref p2);
            Console.WriteLine($"After swap: {p1}, {p2}");

            bool b1 = true, b2 = false;
            Console.WriteLine($"Before swap: {b1}, {b2}");
            Utilities.Swap<bool>(ref b1, ref b2);
            Console.WriteLine($"After swap: {b1}, {b2}");

            Console.WriteLine("\nPress <Enter> to quit...");
            Console.ReadKey();  
        }
    }
}
