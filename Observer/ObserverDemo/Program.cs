/* Observer Design Pattern Example:
 *  Observer design pattern is a behavioral design pattern that defines a one-to-many dependency between objects so that 
 *  when one object changes state, all its dependents are notified and updated automatically. Similatly in this program also 
 *  there are two interfaces IObserver and ISubject. Those interface defines the method for respective classes and we can create 
 *  required classes that implements those interfaces according to it's type. We have to add the observer to the subject so that the 
 *  observer gets notified when the subject changes its state. In this example, we have a School as the subject and teacher and student
 *  as observers. When the school notifies a message, both the teacher and student receive the message.
 */
public interface IObserver
{
    void Update(string message);
}

public interface ISubject
{
    void RegisterObserver(IObserver observer);
    void UnregisterObserver(IObserver observer);
    void NotifyObservers(string message);
}

public class  Student : IObserver
{
    public void Update(string message)
    {
        Console.WriteLine($"Student received message: {message}");
    }
}
public class Teacher : IObserver
{
    public void Update(string message)
    {
        Console.WriteLine($"Teacher received message: {message}");
    }
}

public class  School : ISubject
{
    private List<IObserver> observers = new List<IObserver>();
    public void RegisterObserver(IObserver observer)
    {
        observers.Add(observer);
    }
    public void UnregisterObserver(IObserver observer)
    {
        observers.Remove(observer);
    }
    public void NotifyObservers(string message)
    {
        foreach (var observer in observers)
        {
            observer.Update(message);
        }
    }
}

public class  Program 
{
    static void Main()
    {
        School school =new School();
        
        Student student1 = new Student();
        Teacher teacher1 = new Teacher();
        
        school.RegisterObserver(student1);
        school.RegisterObserver(teacher1);
        
        school.NotifyObservers("School is closed today due to weather conditions.");
        
        school.UnregisterObserver(student1);
        
        school.NotifyObservers("School will reopen tomorrow.");
    }
    
}

