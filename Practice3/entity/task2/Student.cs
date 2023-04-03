namespace Practice3.entity;

public class Student
{
    private string _name;
    private byte _course;
    private bool _isStipend;

    public Student(string name, byte course, bool isStipend)
    {
        _name = name;
        _course = course;
        _isStipend = isStipend;
    }

    public Student(string name, byte course) : this(name, course, false)
    {
    }

    public Student(string name) : this(name, 1, false)
    {
    }

    public void Display()
    {
        Console.WriteLine("Student має наступні значення:");
        Console.WriteLine($"name = {_name}");
        Console.WriteLine($"course = {_course}");
        Console.WriteLine($"isStipend = {_isStipend}");
    }
}