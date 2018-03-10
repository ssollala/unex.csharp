using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooInterface
{
    public class Lion : Animal
    {
        private static string animalType = "Lion";

        public Lion(string name, DateTime dob, decimal cost,
                    int weight, int id, int cageNumber, string animalType)
            : base(name, dob, cost, weight, id, cageNumber, animalType)
        {
        }

        
        public override string ToString()
        {
            return $"{ID,-7} {AnimalType,-15} {Name,-15} {Weight,-8} " +
                    $"{GetAge(),-5} {PurchaseCost,-16:C} {CageNumber,-10:####}";
        }

        
    }
}

