using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    class InventoryItem
    {
        protected string Name;
        protected int Amount;
        protected int Price;
        protected double Vat;
        protected bool Sale;

        protected InventoryItem(string name, int amount, int price, double vat, bool sale)
        {
            Name = name;
            Amount = amount;
            Price = price;
            Vat = vat;
            Sale = sale;
        }

        public double CalculatePrice()
        {
            if (Sale)
            {
                var salePrice = Price * Vat * DiscountPercent();
                Console.WriteLine($"Pris: {salePrice} ");
            }

            return Price * Vat;
        }

        public double DiscountPercent()
        {
            Console.WriteLine(
                "Butikken kjører en event der du maximum en gang får en rabattkupong mellom 0 til 30%. Eventet varer fra 01.01.24 til 10.01.2024.");
            Random rand = new Random();
            var randomNumber = rand.Next(70, 101);
            Console.WriteLine($"Dette er kupongen: {100 - randomNumber}%");

            return (double)randomNumber / 100;
        }
    }
}