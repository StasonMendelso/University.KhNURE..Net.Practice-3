using Practice3.entity;
using Practice3.entity.task6;
using Practice3.entity.task7;

namespace Practice3;

public class Solver
{
    public void Task1()
    {
        PrintHeaderTask(1);
        Television television = new Television();
        television.Display();
        television.NextChannel();
        television.NextChannel();
        television.Display();
        television.PreviousChannel();
        television.PreviousChannel();
        television.PreviousChannel();
        television.Display();
        television.SetChannel(40);
        television.Display();
        television.SetChannel(0);
    }

    public void Task2()
    {
        PrintHeaderTask(2);
        Student student = new Student("Jame");
        student.Display();
        student = new Student("Jack", 5);
        student.Display();
        student = new Student("John", 3, true);
        student.Display();
    }

    public void Task3()
    {
        PrintHeaderTask(3);
        AudioPlayer audioPlayer = new AudioPlayer();
        Console.WriteLine("Гучність аудіоплеєру після створення класу: {0}", audioPlayer.Volume);
        audioPlayer.Volume = 50;
        Console.WriteLine("Гучність аудіоплеєру після встановлення значення 50: {0}", audioPlayer.Volume);
        audioPlayer.Volume = 120;
    }

    public void Task4()
    {
        PrintHeaderTask(4);
        Circle circle = new Circle();
        Console.WriteLine("Об'єкт Circle після створення за допомогою конструктора без параметрів \n{0}", circle);
        circle = new Circle(1.5, 2.0, 2.5);
        Console.WriteLine("Об'єкт Circle після створення за допомогою конструктора з параметрами \n{0}", circle);

        Console.WriteLine("Довжина кола дорівнює {0}", circle.CalculateLength());
        Console.WriteLine("Довжина кола з радіусом 10 дорівнює {0}", circle.CalculateLength(10));

        Circle clonedCircle = circle.GetObject();
        if (circle != clonedCircle)
        {
            Console.WriteLine("Метод GetObject() повернув наступний клон \n{0}", clonedCircle);
        }
        else
        {
            Console.WriteLine("Метод GetObject() повернув оригінальний об'єкт \n{0}", circle);
        }

        circle = circle.GetObject(5, 6, 3);
        Console.WriteLine("Метод GetObject з переданими параметрами (x=5,y=6,radius=3) повернув наступний об'єкт\n{0}",
            circle);


        CheckPointInCircle(circle, 5, 8);
        CheckPointInCircle(circle, 8, 6);
        CheckPointInCircle(circle, 5, 6);
        CheckPointInCircle(circle, 10, 10);
    }

    private void CheckPointInCircle(Circle circle, double x, double y)
    {
        Console.WriteLine(circle.IsPointInCircle(x, y)
            ? $"Точка({x},{y}) належить колу:\n{circle}"
            : $"Точка({x},{y}) не належить колу:\n{circle}");
    }

    public void Task5()
    {
        PrintHeaderTask(5);
        Shape shape = new CircleShape(3, 5, 10.25);
        Console.WriteLine(
            "Результат виклику метода Draw після ініціалізування змінної типу Shape об'єктом CircleShape:");
        shape.Draw();
        shape = new TriangleShape(2, 3, 3, 4, 5);
        Console.WriteLine(
            "Результат виклику метода Draw після ініціалізування змінної типу Shape об'єктом TriangleShape:");
        shape.Draw();
    }

    public void Task6()
    {
        PrintHeaderTask(6);
        Square square = new Cube(10);
        Console.WriteLine(
            $"Периметр для куба, який перевизначив метод для отримання периметра у класса Square: {square.CalculatePerimeter()}");
    }

    public void Task7()
    {
        PrintHeaderTask(7);
        Object obj1 = new Rectangle(10, 10, 20, 20);
        Object obj2 = new Rectangle(10, 10, 20, 20);
        Console.WriteLine($"obj1.ToString() = {obj1}");
        Console.WriteLine($"obj2.ToString() = {obj2}");
        Console.WriteLine($"obj1.GetHashCode() = {obj1.GetHashCode()}");
        Console.WriteLine($"obj2.GetHashCode() = {obj2.GetHashCode()}");
        Console.WriteLine($"obj1.Equals(obj2) = {obj1.Equals(obj2)}");
    }

    private void PrintHeaderTask(int number)
    {
        Console.WriteLine("Task {0}", number);
    }
}