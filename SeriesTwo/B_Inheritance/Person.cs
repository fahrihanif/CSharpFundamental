namespace SeriesTwo.B_Inheritance;

public class Person
{
    public string name;
    public int age;

    public Person()
    {
        Console.WriteLine("Create New Object");
    }

    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public void Introduction()
    {
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Name : " + age);
    }
}
