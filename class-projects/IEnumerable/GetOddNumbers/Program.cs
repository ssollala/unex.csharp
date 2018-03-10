using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Odd Numbers in Data:");
            foreach(int iData in GetEvenNumbers())
            {

            }
            foreach(int iData in GetOddNumbers())
            {
                Console.WriteLine("\t{0}", iData.ToString());
            }

            Console.WriteLine("Even Numbers in Data:");
            foreach (int iData in GetEvenNumbers())
            {
                Console.WriteLine("\t{0}", iData.ToString());
            }

            Console.WriteLine("\nPress <Enter> to quit...");
            Console.ReadKey();
        }

        private static IEnumerable<int> GetEvenNumbers()
        {
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            foreach (int iData in numbers)
            {
                if (iData % 2 == 0)
                    yield return iData;
            }
        }

        // IEnumerable interface => returns the collection of data
        private static IEnumerable<int> GetOddNumbers()
        {
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            
            foreach(int iData in numbers)
            {
                if (iData % 2 == 1)
                    yield return iData;
            }


        }
    }
}
