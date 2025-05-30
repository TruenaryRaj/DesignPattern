namespace Calculator
{
    public class Program
    {
        public static Func<int, int, int> Add = (x, y) => x + y;
        
        public static Func<int, int, int> Subtract = (x, y) => x - y;
        
        public static Func<int, int, int> Multiply = (x, y) => x * y;
    
        public static Func<int, int, int> Division = (x, y) => x / y;
        static void Main()
        {
          /*  Console.WriteLine($"Addition: {Add(3, 0)}");
            Console.WriteLine($"Subtraction: {Subtract(3, 0)}");
            Console.WriteLine($"Multiplication: {Multiply(3, 0)}");
            Console.WriteLine($"Division: {Division(3, 1)}");*/
        }
    }
}