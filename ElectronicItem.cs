using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    //clean UP please
    internal class ElectronicItem : InventoryItem, ISellable
    {
        public ElectronicItem(string name, int amount, int price, string dimensions, string color, bool insurance, int wattage, bool sale) : base(name, amount, price, 1.25, sale)
        {
            Dimensions = dimensions;
            Color = color;
            Insurance = insurance;
            Wattage = wattage;
        }

        public string Dimensions { get; set; }
        public string Color { get; set; }
        public bool Insurance { get; set; }
        public int Wattage { get; set; }

        public void show()
        {
            Console.WriteLine($"Name: {Name}  {Amount} in stock  Price: {calculatePrice()}  Dimensions: {Dimensions}  Color: {Color}  Insurance: {Insurance}  Wattage: {Wattage}");
        }

    }
}
