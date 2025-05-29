/* Iterator Design Pattern Example: 
 * This program is an example of the Iterator Design Pattern. In this example, we have a student class with attribute Name on it to store
 * the name of the student. We have a collection class called StudentCollection that implements IEnumerable to allow iteration
 * over a collection of Student objects. The StudentIterator class implements IEnumerator to provide the iteration logic.
 * So each time new Student is created it is added to the StudentCollection.
 */

using System.Collections;

public class Student
{
    public string Name { get; set; }
    public Student(string name)
    {
        Name = name;
    }
}

public class  StudentCollection : IEnumerable
{
    private List<Student> _students = new List<Student>();
    public void AddStudent(Student student)
    {
        _students.Add(student);
    }
    public IEnumerator GetEnumerator()
    {
        return new StudentIterator(_students.ToArray());
    }
}

public class StudentIterator : IEnumerator
{
    private Student[] _students; 
    private int _currentIndex = -1;

    public StudentIterator(Student[] students)
    {
        _students = students;
    }
    public void Reset()
    {
        _currentIndex = -1;
    }

    public bool MoveNext()
    {
        _currentIndex++;
        return (_currentIndex < _students.Length);
    }
    public object Current
    {
        get { return _students[_currentIndex]; }
    }
}

public class Program
{
    static void Main()
    {
        StudentCollection Collection = new StudentCollection();
        Collection.AddStudent(new Student("Ram"));
        Collection.AddStudent(new Student("Hari"));
        Collection.AddStudent(new Student("Sita"));

        foreach (Student student in Collection)
        {
            Console.WriteLine(student.Name);
        }

    }
}