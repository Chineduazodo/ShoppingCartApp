// Inherits Name, Price, DisplayInfo from Product
public class DigitalProduct : Product
{
    public string DownloadUrl;
    public override void DisplayInfo()  // its own version (polymorphism)

    {
        Console.WriteLine($"product:{Name}  |price:#{Price:N2}  |link:{DownloadUrl}");
    }
}
