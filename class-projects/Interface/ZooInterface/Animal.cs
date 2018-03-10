using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooInterface
{
    public class Animal : IZoo
    {
        private int weight;
        private DateTime dob;
        private int id;
        private decimal purchaseCost;
        private int cageNumber;
        private int age;
        private string animalType;

        public Animal(string inName, DateTime dob, decimal cost,
                        int weight, int id, int cageNumber, string animalType)
        {
            Name = inName;
            DOB = dob;
            PurchaseCost = cost;
            Weight = weight;
            ID = id;
            CageNumber = cageNumber;
            Age = GetAge();
            AnimalType = animalType;
        }

        // properties
        public string Name { get; set; }
        public int ID
        {
            get
            {
                return id;
            }
            set
            {
                if (value > 0)
                    id = value;
                else
                    id = 0;
            }
        }
        public decimal PurchaseCost
        {
            get
            {
                return purchaseCost;
            }
            set
            {
                if (value > 0.0M)
                    purchaseCost = value;
                else
                    purchaseCost = 0.0M;
            }
        }
        public int CageNumber
        {
            get
            {
                return cageNumber;
            }
            set
            {
                if (value > 0)
                    cageNumber = value;
                else
                    cageNumber = 0;
            }
        }
        public int Weight
        {
            get
            {
                return weight;
            }
            set
            {
                if (value > 0)
                {
                    weight = value;
                }
                else
                    weight = 0;
            }
        }

        public DateTime DOB
        {
            get
            {
                return dob;
            }
            set
            {
                if (value < DateTime.Now)
                {
                    dob = value;
                }
                else
                {
                    dob = DateTime.MinValue;        // signals unknown value
                }
            }
        }
        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }
        public string AnimalType
        {
            get
            {
                return animalType;
            }
            set
            {
                animalType = value;
            }
       
        }
        // default sorting method
        // ID -> Cage Number -> Purchase Cost
        public int CompareTo(IZoo other)
        {
            if (other == null)
            {
                return 1; // i.e. this is greater than other (null)
            }
            int compareValue = 0;

            // Next determine your logical sort variables for your application
            // For this application ID could be used as the first sort variable
            compareValue = ID.CompareTo(other.ID);
            if (compareValue == 0)
            {
                // Nest another sort comparison based on your application needs…
                // For this application you could use cage number or maybe cost. Choose based
                // on your needs for the application
                compareValue = CageNumber.CompareTo(other.CageNumber);
                if (compareValue == 0)
                {
                    compareValue = PurchaseCost.CompareTo(other.PurchaseCost);
                    if (compareValue == 0)
                    {
                        compareValue = Name.CompareTo(other.Name);
                    }
                }
            }
            return compareValue;
        }

        // Sorting the data by the purchase cost
        public class SortPurchaseCostAscending : IComparer<IZoo>
        {
            public int Compare(IZoo x, IZoo y)
            {
                return x.PurchaseCost.CompareTo(y.PurchaseCost);             
            }
        }


        // 2. sorting the data weight and date of birth
        public class SortWeightAndDOBAscending : IComparer<IZoo>
        {
            public int Compare(IZoo x, IZoo y)
            {               
                int compareValue = x.Weight.CompareTo(y.Weight);

                if(compareValue == 0)
                {
                    return DateTime.Compare(y.DOB, x.DOB);
                }

                return compareValue;
                
            }
        }

        // sorting the data by cage number, purchase cost, animal name, ID. 
        public class SortCageNumberPurchaseCostNameIdAscending : IComparer<IZoo>
        {
            public int Compare(IZoo x, IZoo y)
            {
                int compareValue = x.CageNumber.CompareTo(y.CageNumber);

                if (compareValue == 0)
                {
                    int secondCompareValue = x.PurchaseCost.CompareTo(y.PurchaseCost);
                    if(secondCompareValue == 0)
                    {
                        int thirdCompareValue = String.Compare(x.Name, y.Name);
                        if(thirdCompareValue == 0)
                        {
                            return x.ID.CompareTo(y.ID);
                        }
                        return thirdCompareValue;
                    }
                    return secondCompareValue;
                }
                return compareValue;
            }
        }

        // sorting the data by the animal’s age and then weight(Descending)
        public class SortAgeWeightDescending : IComparer<IZoo>
        {
            public int Compare(IZoo x, IZoo y)
            {
                int compareValue = y.Age.CompareTo(x.Age);

                if (compareValue == 0)
                {
                    return y.Weight.CompareTo(x.Weight);
                }
                return compareValue;
            }
        }

        // sorting the data by animal type(lion and giraffe), purchase cost, cage number, and name
        public class SortAnimalTypePurchaseCostCageNumberNameAscending : IComparer<IZoo>
        {
            public int Compare(IZoo x, IZoo y)
            {
                int compareValue = String.Compare(x.AnimalType, y.AnimalType);
                if(compareValue == 0)
                {
                    int secondCompareValue = x.PurchaseCost.CompareTo(y.PurchaseCost);
                    if(secondCompareValue == 0)
                    {
                        int thirdCompareValue = x.CageNumber.CompareTo(y.CageNumber);
                        if(thirdCompareValue == 0)
                        {
                            return String.Compare(x.Name, y.Name);
                        }
                        return thirdCompareValue;
                    }
                    return secondCompareValue;
                }
                return compareValue;

            }
        }


        public int GetAge()
        {
            DateTime currentDate = DateTime.Now;

            int years = currentDate.Year - DOB.Year;
            if((currentDate.Month < DOB.Month) ||
                ((currentDate.Month == DOB.Month) &&
                (currentDate.Day < DOB.Day)))
            {
                --years;
            }
            return years;
        }

        public override string ToString()
        {
            return $"{Weight,7} {GetAge(),4}";
        }
    }
}
