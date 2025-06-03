/* SOLID Principles Demonstration:
 * As SOLID is a set of principle for object-oriented design, S stands for Single Responsibility Principle (SRP) in this program each class 
 * has single responsibility. O stands for open/closedn as the program is open for extension but closed for modification,
 * L stands for Liskov Substitution Principle (LSP) as derived classes can be used in place of base classes, 
 * I stands for Interface Segregation Principle (ISP) as interfaces are segregated and D stands for Dependency
 * Inversion Principle (DIP) as high-level modules do not depend on low-level modules it depends on abstraction.
 */
public interface IPayroll
{
    void ProcessPayroll();
}

public class FullTime : IPayroll
{
    private int _salary;
    public FullTime(int salary)
    {
        _salary = salary;
    }
    public void ProcessPayroll()
    {
        Console.WriteLine($"Processing payroll for FullTime employee with salary: {_salary}");
    }
}

public class PartTime : IPayroll
{
    private int _hourlyRate;
    private int _hoursWorked;
    public PartTime(int hourlyRate, int hoursWorked)
    {
        _hourlyRate = hourlyRate;
        _hoursWorked = hoursWorked;
    }
    public void ProcessPayroll()
    {
        Console.WriteLine($"Processing payroll for PartTime employee rate: {_hourlyRate * _hoursWorked}");
    }
}
public interface ILogger
{
    void Log(IPayroll payroll, string message);
    void DisplayLog();
}


public class Logger : ILogger
{
    private Dictionary<IPayroll, string> _logs = new Dictionary<IPayroll, string>();

    public void Log(IPayroll payroll, string message)
    {
        _logs[payroll] = message;
    }

    public void DisplayLog()
    {
        foreach (var log in _logs)
        {
            Console.WriteLine($"{log.Key.GetType().Name}: {log.Value}");
        }
    }
}

public class ProcessPayroll
{
    private IPayroll _payroll;
    private ILogger _log;
    public ProcessPayroll(IPayroll payroll, ILogger log)
    {
        _payroll = payroll;
        _log = log;
    }

    public void Execute()
    {
        _payroll.ProcessPayroll();
        _log.Log(_payroll, $"Payroll processed for {_payroll.GetType().Name} at {DateTime.Now}");
    }
}

public class Program
{
    static void Main()
    {
        IPayroll full = new FullTime(5000);
        IPayroll part = new PartTime(20, 160);

        ILogger logger = new Logger();

        ProcessPayroll fullProcessor = new ProcessPayroll(full, logger);
        ProcessPayroll partProcessor = new ProcessPayroll(part, logger);

        fullProcessor.Execute();
        partProcessor.Execute();

        logger.DisplayLog();
    }
}
