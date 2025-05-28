/* FacadeDemo:
 *  Facade design pattern simplifies the code into a single interface to communicate with multiple subsystems. In this code we 
 *  have 2 subsystems: VAT and TSC. The TaxCalculator class acts as a facade that provides a simple interface to calculate the total tax.
 *  The Facade class has implement the CalculateTotalTax method which internally calls the CalculateVAT and CalculateTSC methods of the VAT
 *  and TSC classes respectively. This way, the client code does not need to know about the details of how VAT and TSC are calculated.
 */

public class VAT
{   
    public double CalculateVAT(double amount)
    {
        return amount * 0.20;
    }
}

public class  TSC
{
    public double CalculateTSC(double amount)
    {
        return amount * 0.10;
    }
}

public class TaxCalculator
{
    private VAT _vat;
    private TSC _tsc;
    public TaxCalculator()
    {
        _vat = new VAT();
        _tsc = new TSC();
    }
    public double CalculateTotalTax(double amount)
    {
        double vat = _vat.CalculateVAT(amount);
        double tsc = _tsc.CalculateTSC(amount);
        return vat + tsc;
    }
}

public class Program
{
    static void Main()
    {
        double amount = 1000.0;
        TaxCalculator taxCalculator = new TaxCalculator();
        double totalTax = taxCalculator.CalculateTotalTax(amount);
        Console.WriteLine($"Total tax on {amount:C} is {totalTax:C}");
    }
}