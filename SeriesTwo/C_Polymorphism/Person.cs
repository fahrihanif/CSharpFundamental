namespace SeriesTwo.C_Polymorphism;

// Contructor 1 & 2 => Method Overloading
// Introduction 1 & 2 => Method Overloading
// Karakteristik 1 kelas sama, nama method sama, beda parameter input
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

    // virtual, syntax supaya method bisa di ovveride pada sub class
    public virtual void Introduction()
    {
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Age : " + age);
    }

    public void Introduction(string name, int age)
    {
        Console.WriteLine("Name : " + name);
        Console.WriteLine("Age : " + age);
    }
}
