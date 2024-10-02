using Stripe;
using System;
using System.Xml.Linq;


namespace TruutuongVaGiaoDien
{
    public class MobilePhone : Product, ISellable
    {
        public MobilePhone(string name, decimal price, int stock)
        : base(name, price, stock) { }

        public override void DisplayProductInfo()
        {
            Console.WriteLine($"MobilePhone: {Name}, Price: {Price}, Stock: {Stock}");
        }

        public override void ApplyDiscount(decimal percentage)
        {
            Price -= Price * percentage / 100;
        }

        public void Sell(int quantity)
        {
            if (quantity <= Stock)
            {
                Stock -= quantity;
            }
            else
            {
                Console.WriteLine("Not enough stock to sell.");
            }
        }

        public bool IsInStock()
        {
            return Stock > 0;
        }
    } 
}
