// ===== CLASSES =====
// Abstract = can't do "new Product()" (abstraction)
public abstract class Product
{
    public string Name;
    private decimal _price; // hidden real storage
    public decimal Price// public gate that protects it (encapsulation)
    {
        get => _price;
        set => _price = value < 0 ? 0 : value;// block negatives
    }
    public abstract void DisplayInfo(); // subclasses must define this
}
