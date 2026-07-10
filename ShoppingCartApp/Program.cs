using System.Collections.Generic;
    Console.WriteLine("Hello, World!");
ShoppingCart cart = new ShoppingCart();
DigitalProduct book = new DigitalProduct();
public abstract class Product
{
    public string Name;
    private decimal _price;
    public decimal Price
    {
        get => _price;
        set => _price = value < 0 ? 0 : value;
    }
    public abstract void DisplayInfo();
}

    public class DigitalProduct : Product
    {
        public string DownloadUrl;
        public override void DisplayInfo()
        {
            Console.WriteLine($"product:{Name}  |price:#{Price:N2}  |link:{DownloadUrl}");
        }
    }

public class PhysicalProduct : Product
{
    public double Weight;

    public override void DisplayInfo()
    {
        Console.WriteLine($"product:{Name} |price: #{Price:N2}|weight: {Weight}kg");
    }
}
public class ShoppingCart
{
    private List<Product> _items = new List<Product>();

    public void AddProduct(Product p)
    {
        _items.Add(p);
    }

    public decimal CalculateTotal()
    {
        decimal total = 0;
        foreach (Product p in _items)
        {
            total += p.Price;
        }
        return total;
    }
}

