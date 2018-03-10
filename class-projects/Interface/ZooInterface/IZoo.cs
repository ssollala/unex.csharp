using System;

namespace ZooInterface
{
    public interface IZoo : IComparable<IZoo>
    {
        int Weight { get; set; }
        DateTime DOB { get; set; }
        int ID { get; set; }
        string Name { get; set; }
        decimal PurchaseCost { get; set; }
        int CageNumber { get; set; }
        int Age { get; set; }
        string AnimalType { get; set; }
       

    }
}
