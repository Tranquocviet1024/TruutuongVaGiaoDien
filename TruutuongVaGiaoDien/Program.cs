using System;
namespace TruutuongVaGiaoDien
{
    class Program {
        public static void Main(string[] args)
        {
            // Khởi tạo các đối tượng
            MobilePhone phone = new MobilePhone("iPhone 14", 999.99m, 10);
            Laptop laptop = new Laptop("MacBook Pro", 1999.99m, 5);
            Accessory accessory = new Accessory("AirPods", 199.99m, 20);

            // Hiển thị thông tin sản phẩm
            phone.DisplayProductInfo();
            laptop.DisplayProductInfo();
            accessory.DisplayProductInfo();

            // Thực hiện bán hàng
            phone.Sell(2);
            laptop.Sell(1);
            accessory.Sell(5);

            // Kiểm tra tồn kho
            Console.WriteLine(phone.IsInStock() ? "Phone is in stock" : "Phone is out of stock");
            Console.WriteLine(laptop.IsInStock() ? "Laptop is in stock" : "Laptop is out of stock");
            Console.WriteLine(accessory.IsInStock() ? "Accessory is in stock" : "Accessory is out of stock");

            // Áp dụng giảm giá
            phone.ApplyDiscount(10);
            laptop.ApplyDiscount(15);

            // Hiển thị thông tin sau giảm giá
            phone.DisplayProductInfo();
            laptop.DisplayProductInfo();
        }
    }

}
