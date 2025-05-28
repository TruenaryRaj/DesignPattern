/* SingletonDemo:
 * This program demonstrates the Singleton design pattern in C#. In this program there is a Singleton class that have it's private static 
 * instance so that it would not be instantiated multiple times. The Singleton class has a private constructor to prevent instantiation 
 * from outside the class. The GetInstance method checks if the instance is null, and if so, creates a new instance. 
 * In the main program we create two instances of the Singleton class and display a message to show that both instances are the same.
 * 
 */
public class Singleton
{
    private static Singleton _instance;

    private Singleton()
    {
        Console.WriteLine("Singleton instance created.");
    }

    public static Singleton GetInstance()
    {
        if (_instance == null)
        {
            _instance = new Singleton();
        }
        return _instance;
    }
    public void DisplayMessage()
    {
        Console.WriteLine("Hello from Singleton!");
    }

}

public class Program
{
    public static void Main(string[] args)
    {

        Singleton instance1 = Singleton.GetInstance();
        instance1.DisplayMessage();
        Singleton instance2 = Singleton.GetInstance();
        instance2.DisplayMessage();
        if (instance1 == instance2)
        {
            Console.WriteLine("Both instances are the same.");
        }
        else
        {
            Console.WriteLine("Instances are different.");
        }
    }
}
