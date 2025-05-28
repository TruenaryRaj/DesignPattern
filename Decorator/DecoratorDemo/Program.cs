/* Decorator Design Pattern Example:
   This example demonstrates the Decorator Design Pattern by allowing dynamic addition of ingredients to a Khaja set.
   The base Khaja can be decorated with Chicken and Egg, each adding its own cost and description. so as the ingredients 
    is added to the khaja set, the cost and description of the khaja set is updated accordingly.
 */
public interface IKhaja
{
    string GetDescription();
    double GetCost();
}

public class Khaja : IKhaja
{
    public string Name;
    public int Cost;
    public Khaja(string name, int cost)
    {
        Name = name;
        Cost = cost;
    }
    public string GetDescription()
    {
        return Name;
    }
    public double GetCost()
    {
        return Cost;
    }
}

public abstract class KhajaDecorator : IKhaja
{
    protected IKhaja Khaja;
    public KhajaDecorator(IKhaja khaja)
    {
        Khaja = khaja;
    }
    public virtual string GetDescription()
    {
        return Khaja.GetDescription();
    }
    public virtual double GetCost()
    {
        return Khaja.GetCost();
    }
}

public class ChickenDecorator : KhajaDecorator
{
    public ChickenDecorator(IKhaja khaja) : base(khaja) { }
    public override string GetDescription()
    {
        return Khaja.GetDescription() + ", chicken";
    }
    public override double GetCost()
    {
        return Khaja.GetCost() + 100;
    }
}

public class EggDecorator : KhajaDecorator
{
    public EggDecorator(IKhaja khaja) : base(khaja) { }
    public override string GetDescription()
    {
        return Khaja.GetDescription() + ", egg";
    }
    public override double GetCost()
    {
        return Khaja.GetCost() + 60;
    }
}

public class Progeam
{
    static void Main()
    {
        IKhaja khaja = new Khaja("plain khaja", 60);
        Console.WriteLine($"{khaja.GetDescription()} costs {khaja.GetCost()}");
        khaja = new ChickenDecorator(khaja);
        Console.WriteLine($"{khaja.GetDescription()} costs {khaja.GetCost()}");
        khaja = new EggDecorator(khaja);
        Console.WriteLine($"{khaja.GetDescription()} costs {khaja.GetCost()}");
    }
}