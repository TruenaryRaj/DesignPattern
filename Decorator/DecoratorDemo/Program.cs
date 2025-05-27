
public interface IKhaja
{
    string GetDescription();
    double GetCost();
}

public class Khaja : IKhaja
{
    public string GetDescription()
    {
        return "Khaja set";
    }
    public double GetCost()
    {
        return 10.0;
    }
}

public abstract class KhajaDecorator : IKhaja
{
    protected IKhaja _khaja;
    public KhajaDecorator(IKhaja khaja)
    {
        _khaja = khaja;
    }
    public virtual string GetDescription()
    {
        return _khaja.GetDescription();
    }
    public virtual double GetCost()
    {
        return _khaja.GetCost();
    }
}

public class ChickenDecorator : KhajaDecorator
{
    public ChickenDecorator(IKhaja khaja) : base(khaja) { }
    public override string GetDescription()
    {
        return _khaja.GetDescription() + ", with Chicken";
    }
    public override double GetCost()
    {
        return _khaja.GetCost() + 5.0;
    }
}

public class EggDecorator : KhajaDecorator
{
    public EggDecorator(IKhaja khaja) : base(khaja) { }
    public override string GetDescription()
    {
        return _khaja.GetDescription() + ", with Egg";
    }
    public override double GetCost()
    {
        return _khaja.GetCost() + 3.0;
    }
}

public class Progeam
{
    static void Main()
    {
        IKhaja khaja = new Khaja();
        Console.WriteLine($"{khaja.GetDescription()} costs {khaja.GetCost()}");
        khaja = new ChickenDecorator(khaja);
        Console.WriteLine($"{khaja.GetDescription()} costs {khaja.GetCost()}");
        khaja = new EggDecorator(khaja);
        Console.WriteLine($"{khaja.GetDescription()} costs {khaja.GetCost()}");
    }
}