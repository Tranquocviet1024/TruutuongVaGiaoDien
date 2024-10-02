using System;

namespace TruutuongVaGiaoDien
{
    internal class Laptop : Product, ISellable
    {
        public Laptop(string name, decimal price, int stock) : base(name, price, stock) { }
        public override void DisplayProductInfo()
        {
            Console.WriteLine($"Laptop: {Name}, Price: {Price:C}, Stock: {Stock}");
        }

        public override void ApplyDiscount(decimal percentage)
        {
            Price -= Price * (percentage / 100);
        }

        public void Sell(int quantity)
        {
            if (Stock >= quantity)
            {
                Stock -= quantity;
                Console.WriteLine($"{quantity} {Name}(s) sold. Remaining stock: {Stock}");
            }
            else
            {
                Console.WriteLine($"Not enough stock for {Name}");
            }
        }

        public bool IsInStock()
        {
            return Stock > 0;
        }
    }
}
