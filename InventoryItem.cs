using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    internal class InventoryItem
    {
        public string Name { get; set; }

        public int Amount { get; set; }

        public int Price { get; set; }

        protected double VAT;

        public bool Sale { get; set; }

        public InventoryItem(string name, int amount, int price, double vat, bool sale)
        {
            Name = name;
            Amount = amount;
            Price = price;
            VAT = vat;
            Sale = sale;
        }
        public double calculatePrice()
        {
            if (Sale)
            {
                var salePrice = Price * VAT * discountPercent();
                Console.WriteLine($"Pris: {salePrice} ");
            }
            return (double) Price * VAT;

        }

        public double discountPercent()
        {
            Console.WriteLine("Butikken kjører en event der du maximum en gang får en rabattkupong mellom 0 til 30%. Eventet varer fra 01.01.24 til 10.01.2024.");
            Random rand = new Random();
            var randomNumber = rand.Next(70, 101);
            Console.WriteLine($"Dette er kupongen: {100 - randomNumber}%");

            return (double) randomNumber / 100;
        }

        public InventoryItem()
        {

        }

    }

}
