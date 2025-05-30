/* Functional Programming:
 * So basically functional programming can be easily describe as the programming set of rules that helps programmer to write the code 
 * in more clean and readable way. It is a programming paradigm that treats computation as the evaluation of mathematical functions 
 * and avoids changing state and mutable data. For example, in this program all the functions are pure functions, meaning they
 * do not have side effects and always produce the same output for the same input. It does not changes the global state or mutable data.
 * similarly it does not use any loops or mutable data structures, instead it uses LINQ to filter and transform the data. It also doesnot 
 * modifies/mutates the input data, rather it creates new data structures with the desired output.
 */
using System;
using System.Net;

public class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        Func<int, bool> isEven = n => n % 2 == 0;
        Func<int, int> doubleIt = n => n * 2;

        var result = numbers.Where(isEven)
                            .Select(doubleIt)
                            .Sum();

        Console.WriteLine($"The sum of double of even numbers is: {result}");

    }
}