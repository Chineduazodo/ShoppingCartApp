// Holds products, doesn't inherit from Product (composition)
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
    public List<Product> GetItems()
    {
        return _items;
    }
}

