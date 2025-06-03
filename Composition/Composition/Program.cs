/* Composition over inheritance:
 *  Composition over inheritance means instead of directly inheriting the class we can use composition i.e us that class as a member of another class.
 *  Similarly in this program we are using composition to create a Robot class that can have different behaviors and speaking capabilities.
 *  A Robot can either walk or fly and can speak in different ways.  
 */
public interface IBehavior
{
    void Move();
}

public interface ISpeak
{
    void Speak();
}

public class WalkBehaviour : IBehavior
{
    public void Move()
    {
        Console.WriteLine("Walking...");
    }
}

public class FlyBehaviour : IBehavior
{
    public void Move()
    {
        Console.WriteLine("Flying...");
    }
}

public class BeepSpeak : ISpeak
{
    public void Speak()
    {
        Console.WriteLine("Beep Beep!");
    }
}

public class HumanSpeak : ISpeak
{
    public void Speak()
    {
        Console.WriteLine("Hello!");
    }
}

public class Robot
{
    private IBehavior _behavior;
    private ISpeak _speak;

    public Robot(IBehavior behavior, ISpeak speak)
    {
        _behavior = behavior;
        _speak = speak;
    }

    public void Move()
    {
        _behavior.Move();
    }
    public void Speak()
    {
        _speak.Speak();
    }
}

public class Program
{
    static void Main()
    {
        WalkBehaviour walk = new WalkBehaviour();
        FlyBehaviour fly = new FlyBehaviour();
        BeepSpeak beep = new BeepSpeak();
        HumanSpeak human = new HumanSpeak();

        Robot robot1 = new Robot(walk, beep);
        robot1.Move();
        robot1.Speak();
        Robot robot2 = new Robot(fly, human);
        robot2.Move();
        robot2.Speak();
    }
}