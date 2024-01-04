using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    internal class ClothingItem : InventoryItem, ISellable
    {
        public ClothingItem(string name, int amount, int price, double vat, string size, string color, bool sale) :
            base(name, amount, price, vat, sale)
        {
            Size = size;
            Color = color;
        }

        private string Size { get; set; }
        private string Color { get; set; }

        public void Show()
        {
            Console.WriteLine(
                $"{Name} {Amount} in stock Price: {CalculatePrice()}  Vat: {Vat}  Size: {Size}  Color: {Color}");
        }
    }
}