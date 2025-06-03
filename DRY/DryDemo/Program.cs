/*class Program
{
    static void Main()
    {
        double applePrice = 1.2;
        double appleTax = applePrice * 0.07;
        double appleTotal = applePrice + appleTax;
        Console.WriteLine($"Apple total: {appleTotal}");

        double bananaPrice = 0.8;
        double bananaTax = bananaPrice * 0.07;
        double bananaTotal = bananaPrice + bananaTax;
        Console.WriteLine($"Banana total: {bananaTotal}");

        double orangePrice = 1.5;
        double orangeTax = orangePrice * 0.07;
        double orangeTotal = orangePrice + orangeTax;
        Console.WriteLine($"Orange total: {orangeTotal}");
    }

Question for dry principle
So DRY principle states that instead of repeating code, we should abstract it out into a method or class. 
}*/

public interface ICalculator
{
    double CalculateTotal(double price, double taxRate);

}

public class TaxCalculator : ICalculator
{
    public double CalculateTotal(double price, double taxRate)
    {
        double tax = price * taxRate;
        return price + tax;
    }
}

public class Program
{
    static void Main()
    {
        TaxCalculator calculator = new TaxCalculator();
        Console.WriteLine($"Apple total: {calculator.CalculateTotal(1.2,1.2):f2}");
        Console.WriteLine($"Banana total: {calculator.CalculateTotal(0.8, 0.8):f2}");
        Console.WriteLine($"Orange total: {calculator.CalculateTotal(1.5, 1.5):f2}");
    }
}