namespace SeriesTwo.B_Inheritance;

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

    public void PerkenalanDiri()
    {
        // [Alt1]
        // Call Parent or Super Class Attribute
        Console.WriteLine("Hai nama saya : " + name);
        Console.WriteLine("Umur : " + age);

        // [Alt2]
        //base.Introduction();

        Console.WriteLine("Employee ID : " + id);
        Console.WriteLine("Role : " + role);
        Console.WriteLine("Salary : " + salary);
    }
}
