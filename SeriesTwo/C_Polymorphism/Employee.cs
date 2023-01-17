namespace SeriesTwo.C_Polymorphism;

// Person, Parent or Super Class
// Employee, Child or Sub Class
public class Employee : Person
{
    public string id, role;
    public int salary;

    public Employee(string name, int age, string id, string role, int salary)
        // [Alt1]
        : base(name, age)
    {
        // [Alt2]
        //base.name = name;
        //base.age = age;

        this.id = id;
        this.role = role;
        this.salary = salary;
    }

    public override void Introduction()
    {
        Console.WriteLine("Hai nama saya : " + name);
        Console.WriteLine("Umur : " + age);
        Console.WriteLine("Employee ID : " + id);
        Console.WriteLine("Role : " + role);
        Console.WriteLine("Salary : " + salary);
    }
}
