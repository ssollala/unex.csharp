using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooInterface
{
    class Program
    {
        static void Main(string[] args)
        {
            Lion aLion = new Lion("Leo", DateTime.Parse("4/04/2012"), 2500, 360, 1, 9, "Lion");
            Giraffe aGiraffe = new Giraffe("Amber", DateTime.Parse("3/23/2013"), 4500, 1400, 2, 25, "Giraffe");
            Giraffe aSecondGiraffe = new Giraffe("Charlie", DateTime.Parse("5/2/2012"), 3600, 2600, 3, 25, "Giraffe");
            
            // Add some more test cases
            Giraffe thirdGiraffe = new Giraffe("Shirley", DateTime.Parse("3/23/2016"),
             4500, 1400, 0, 25, "Giraffe");
            Giraffe fourthGiraffe = new Giraffe("George", DateTime.Parse("5/2/2014"),
             3600, 2600, 0, 25, "Giraffe");
            Giraffe fifthGiraffe = new Giraffe("Tess", DateTime.Parse("1/23/2013"),
             4500, 1400, 0, 25, "Giraffe");
            Giraffe sixthGiraffe = new Giraffe("Carol", DateTime.Parse("5/2/2012"),
             4500, 2600, 0, 25, "Giraffe");


            Lion secondLion = new Lion("Ashly", DateTime.Parse("10/11/2015"),
                4000, 300, 10, 21, "Lion");
            Lion thirdLion = new Lion("Ross", DateTime.Parse("8/15/2011"), 2900, 1000, 13, 21, "Lion");
            Lion fourthLion = new Lion("Ashly", DateTime.Parse("1/1/2014"), 4000, 2000, 4, 21, "Lion");
            Lion fifthLion = new Lion("Griffith", DateTime.Parse("4/10/2016"), 4000, 2000, 7, 21, "Lion");

            List<Animal> aZoo = new List<Animal>();

            aZoo.Add(aLion);
            aZoo.Add(aGiraffe);
            aZoo.Add(aSecondGiraffe);
            aZoo.Add(thirdGiraffe);
            aZoo.Add(fourthGiraffe);
            aZoo.Add(fifthGiraffe);
            aZoo.Add(sixthGiraffe);
            aZoo.Add(secondLion);
            aZoo.Add(thirdLion);
            aZoo.Add(fourthLion);
            aZoo.Add(fifthLion);

            Console.WriteLine("List - Before sorting");
            Console.WriteLine(PrintReportHeader());
            foreach (Animal animalData in aZoo)
            {
                Console.WriteLine($"{animalData}");          
            }

            // default sort method- ID -> Cage Number -> Purchase Cost(Ascending)
            aZoo.Sort();
            Console.WriteLine("\nList - Sorted by default sorting: ID -> Cage Number -> Purchase Cost(Ascending) ");
            Console.WriteLine(PrintReportHeader());
            foreach (Animal animalData in aZoo)
            {
                Console.WriteLine($"{animalData}");
               
                /*
                // optional problem
                output.WriteLine(animalData);
                */
            }

            // #1
            Console.WriteLine("\nList - Sorted by PurchaseCost(Ascending)");
            aZoo.Sort(new Animal.SortPurchaseCostAscending());
            Console.WriteLine(PrintReportHeader());
            foreach (Animal animalData in aZoo)
            {
                Console.WriteLine($"{animalData}");
            }

            // #2
            Console.WriteLine("\nList - Sorted by Weight and DOB(Ascending)");
            aZoo.Sort(new Animal.SortWeightAndDOBAscending());
            Console.WriteLine(PrintReportHeader());
            foreach (Animal animalData in aZoo)
            {
                Console.WriteLine($"{animalData}");
            }

            // #3
            Console.WriteLine("\nList - Sorted by cage number, purchase cost, animal name, ID(Ascending)");
            aZoo.Sort(new Animal.SortCageNumberPurchaseCostNameIdAscending());
            Console.WriteLine(PrintReportHeader());
            foreach (Animal animalData in aZoo)
            {
                Console.WriteLine($"{animalData}");
            }

            // #4. 
            Console.WriteLine("\nList - Sorted by animal’s age and then weight(Descendig)");
            aZoo.Sort(new Animal.SortAgeWeightDescending());
            Console.WriteLine(PrintReportHeader());
            foreach (Animal animalData in aZoo)
            {
                Console.WriteLine($"{animalData}");
            }
            
            // #5
            Console.WriteLine("\nList - Sorted by  animal type (lion and giraffe), purchase cost, " +
                "cage number, and name(Ascending)");
            aZoo.Sort(new Animal.SortAnimalTypePurchaseCostCageNumberNameAscending());
            Console.WriteLine(PrintReportHeader());
            foreach (Animal animalData in aZoo)
            {
                Console.WriteLine($"{animalData}");
            }

            //output.Close();

            Console.WriteLine("\nPress <Enter> to quit...");
            Console.ReadKey();

        }

        private static string PrintReportHeaderForFile()
        {
            return $"{"ID",-7} {"Animal Type",-15} {"Name",-15} {"Weight",-8}" +
                    $"{"Age",-5} {"Purchase Cost",-16} {"Cage No.",-10}";
        }

        private static string PrintReportHeader()
        {
            return $"{"ID",-7} {"Animal Type",-15} {"Name",-15} {"Weight",-8}" +
                    $"{"Age",-5} {"Purchase Cost",-16} {"Cage No.",-10}\n" +
                    $"{"==",-7} {"===========",-15} {"====",-15} {"======",-8}" +
                    $"{"===",-5} {"=============",-16} {"========",-10}";
        }
    }
}
