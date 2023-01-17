namespace SeriesTwo.D_Encapsulation;

public class Employee
{
    private string id;

    public void setId(string id)
    {
        this.id = id;
    }

    public string Name { get; private set; }
    public int Age { get; set; }
    public string Role { get; set; }
    public int Salary { private get; set; }

    public Employee()
    {

    }

    public Employee(string name)
    {
        Name = name;
    }

    public void Introduction()
    {
        Console.WriteLine("Employee ID : " + id);
        Console.WriteLine("Name : " + Name);
        Console.WriteLine("Umur : " + Age);
        Console.WriteLine("Role : " + Role);
        Console.WriteLine("Salary : " + Salary);
    }
}
