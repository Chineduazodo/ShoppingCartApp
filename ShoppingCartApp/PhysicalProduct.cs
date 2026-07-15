public class PhysicalProduct : Product
{
    public double Weight;

    public override void DisplayInfo()
    {
        Console.WriteLine($"product:{Name} |price: #{Price:N2}|weight: {Weight}kg");
    }
}
