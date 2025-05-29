/*Builder Pattern:
 * The builder pattern is a creational pattern which is used to create a complex object step by step. in simple words it's 
 * a design pattern that allows you to construct a complex object by specifying its type and content. In this program, we have
 * a class Person which has properties like Id, Name, and Email. We also have an interface IPerson which defines methods to set these properties.
 * person can have different types og attributes and we can create different builders for different types of persons according to our need.
 */
public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }

    public void DisplayInfo()
    {
        Console.WriteLine($"Id: {Id}, Name: {Name}, Email: {Email}");
    }
}

public interface IPerson
{
    void SetId();
    void SetName();
    void SetEmail();
    Person Build();
}

public class  Student : IPerson 
{
    private Person _person=new Person();

    public void SetId()
    {
        _person.Id=10;
    }
    public void SetName()
    {
        _person.Name = "Ram";
    }
    public void SetEmail()
    {
        _person.Email = "ram@gmail.com";
    }
    public Person Build()
    {
        return _person;
    }   
}
public class Director
{
    private IPerson _personBuilder;
    public Director(IPerson personBuilder)
    {
        _personBuilder = personBuilder;
    }
    public Person Build()
    {
        _personBuilder.SetId();
        _personBuilder.SetName();
        _personBuilder.SetEmail();
        return _personBuilder.Build();
    }
}

public class Program
{
    static void Main()
    {
        IPerson studentbuilder = new Student();
        Director director = new Director(studentbuilder);
        Person student= director.Build();
        student.DisplayInfo();
    }
}