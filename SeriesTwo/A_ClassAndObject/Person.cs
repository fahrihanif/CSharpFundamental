namespace SeriesTwo.A_ClassAndObject;

public class Person
{
    // Attribute or Properties
    public string name;
    public int age;

    // Constructor
    public Person()
    {
        Console.WriteLine("Create New Object");
    }

    // Constructor with Parameter
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // Behavior or Method
    public void Introduction()
    {
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Name : " + age);
    }
}
