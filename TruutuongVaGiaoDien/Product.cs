using System;


namespace TruutuongVaGiaoDien
{
    public abstract class Product
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        public Product(string name, decimal price, int stock)
        {
            Name = name;
            Price = price;
            Stock = stock;
        }

        public abstract void DisplayProductInfo();
        public abstract void ApplyDiscount(decimal percentage);
    }
}
