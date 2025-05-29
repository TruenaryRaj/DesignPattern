/* Functional Programming:
 * This program is an simple demonstration of functional programming which means each method handles only one task
 * and all the output should be only dependend on the input parameters. So, each method in this program like CalculateEven,
 * DoubleNumbers, and SumNumbers is designed to perform a specific operation on a list of integers and only acts for a single task.
 */
using System;
using System.Net;

public class Calculation
{
    public List<int> GetEven(List<int> numbers)
    {
        return numbers.Where(n => n % 2 == 0).ToList();
    }

    public List<int> GetDouble(List<int> numbers)
    {
        return numbers.Select(n => n * 2).ToList();
    }

    public int GetSum(List<int> numbers)
    {
        return numbers.Sum();
    }

}

public class Program
{
    static void Main()
    {
        Calculation calculation = new Calculation();
        int result = calculation.GetSum(calculation.GetDouble(calculation.GetEven([1,2,3,4,5])));
        Console.WriteLine($"The sum of doubled even numbers is: {result}");
    }
}