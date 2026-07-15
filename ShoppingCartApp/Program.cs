//This line allows us to access items from the list 
    using System.Collections.Generic;
   //===MAIN===
ShoppingCart cart = new ShoppingCart();//Creates the cart object

DigitalProduct book = new DigitalProduct();
book.Name = "The Potters Wheel";
book.Price = 5000;//// validated by Price's setter
book.DownloadUrl = "www.search.com";

PhysicalProduct Laptop = new PhysicalProduct();
Laptop.Name = "Dell";
Laptop.Price = 50000;
Laptop.Weight = 15.5;
// add both products to the cart
cart.AddProduct(book);
cart.AddProduct(Laptop);

Console.WriteLine("======SHOPPING CART ITEMS======");


foreach (Product p in cart.GetItems())
{
    p.DisplayInfo();  // runs the correct override automatically (polymorphism)
}
Console.WriteLine("=============");
Console.WriteLine($"Total cart value:#{cart.CalculateTotal():N2}");

