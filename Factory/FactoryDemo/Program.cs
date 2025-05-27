/*Factory Pattern:
 */

public interface ICollege
{
    void GetName();
}

public class Student : ICollege
{
    public void GetName()
    {
         Console.WriteLine("student name");
    }
}

public class Teacher : ICollege
{
    public void GetName()
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
        student.GetName();
        ICollege teacher = factory.GetDetail("teacher");
        teacher.GetName();
    }
}