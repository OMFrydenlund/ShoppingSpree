using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    internal class ClothingItem : InventoryItem, ISellable
    {
        public ClothingItem(string name, int amount, int price, double vat, string size, string color, bool sale) : base(name, amount, price, vat, sale)
        {
            Size = size;
            Color = color;
        }

        public string Size { get; set; }
        public string Color { get; set; }

        public void show()
        {
            Console.WriteLine($"{Name} {Amount} in stock Price: {calculatePrice()}  Vat: {VAT}  Size: {Size}  Color: {Color}");
        }
    }
}
