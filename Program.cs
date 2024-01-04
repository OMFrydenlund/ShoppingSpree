namespace ShoppingSpree
{
    internal class Program
    {
        static void Main()
        {
            List<ISellable> items = new List<ISellable>
            {
                new ElectronicItem("Nvidia RTX A6000", 256, 60000, "10.5 x 4.4 x 3.3", "Starship Gray", true, 300, true),
                new ClothingItem("Lee's Jeans", 40, 799, 1.25, "Large", "Light blue", true),
                new ClothingItem("Vero Moda Skirt", 15, 699, 1.25, "Medium", "Dark red", true),

            };

            foreach (var sellable in items)
            {
                sellable.show();
                Console.WriteLine();
            }

            var inventoryClass = new InventoryItem();
            inventoryClass.calculatePrice();

        }
    }
}
