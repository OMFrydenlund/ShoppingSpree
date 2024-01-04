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
        private string Dimensions { get; set; }
        private string Color { get; set; }
        private bool Insurance { get; set; }
        private int Wattage { get; set; }

        public ElectronicItem(string name, int amount, int price, string dimensions, string color, bool insurance,
            int wattage, bool sale) : base(name, amount, price, 1.25, sale)
        {
            Dimensions = dimensions;
            Color = color;
            Insurance = insurance;
            Wattage = wattage;
        }

        public void Show()
        {
            Console.WriteLine(
                $"Name: {Name}  {Amount} in stock  Price: {CalculatePrice()}  Dimensions: {Dimensions}  Color: {Color}  Insurance: {Insurance}  Wattage: {Wattage}");
        }
    }
}