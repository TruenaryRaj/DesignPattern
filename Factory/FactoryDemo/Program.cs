/*Factory Pattern:
 * This program demonstrate the example of factory design pattern. This pattern defines an public interface for creating an object
 * but lets subclasses alter the type of objects that will be created. We define a factory method that returns an instance of a class,
 * from that instance we override the method to return the name of the class. 
 */

public interface ICollege
{
    void PrintName();
}

public class Student : ICollege
{
    public void PrintName()
    {
         Console.WriteLine("student name");
    }
}

public class Teacher : ICollege
{
    public void PrintName()
    {
        Console.WriteLine("teacher name");
    }
}

public class CollegeFactory
{
    public ICollege GetDetail(string shapeType)
    {
        switch (shapeType.ToLower())
        {
            case "student":
                return new Student();
            case "teacher":
                return new Teacher();
            default:
                throw new ArgumentException("invalid type class");
        }
    }
}

public class Program
{
    static void Main()
    {
        CollegeFactory factory = new CollegeFactory();

        ICollege student = factory.GetDetail("student");
        student.PrintName();
        ICollege teacher = factory.GetDetail("teacher");
        teacher.PrintName();
    }
}