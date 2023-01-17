namespace SeriesOne;

public class B_Operators
{
    public static void Arithmetic()
    {
        int x = 3;
        int y = 2;

        Console.WriteLine(x + y);
        Console.WriteLine(x - y);
        Console.WriteLine(x / y);
        Console.WriteLine(x * y);
        Console.WriteLine(x % y);

        int angka = 5;
        // angka = angka + 1
        Console.WriteLine("Post-Increment " + angka++);
        angka = 5;
        Console.WriteLine("Pre-Increment " + ++angka);
        angka = 5;
        // angka = angka - 1
        Console.WriteLine("post-decrement " + angka--);
        angka = 5;
        Console.WriteLine("pre-decrement " + --angka);
    }

    public static void Assignment()
    {
        // Cascade
        int x, y, z;
        x = y = z = 5;

        Console.WriteLine(x); // 5
        Console.WriteLine(y); // 5
        Console.WriteLine(z); // 5

        x += 2; // x = x+2
        Console.WriteLine(x);
        x -= 2; // x = x-2
        Console.WriteLine(x);
        x *= 2; // x = x*2
        Console.WriteLine(x);
        x /= 2; // x = x/2
        Console.WriteLine(x);
        x %= 2; // x = x%2
        Console.WriteLine(x);
    }

    public static void Comparison()
    {
        int x = 7;
        int y = 3;

        bool isEqual = x == y;
        Console.WriteLine(isEqual);
        Console.WriteLine(x != y);
        Console.WriteLine(x > y);
        Console.WriteLine(x < y);
        Console.WriteLine(x >= y);
        Console.WriteLine(x <= y);
    }


    public static void Logical()
    {
        int x = 7;
        int y = 3;

        // True && True
        // > True
        // True && False
        // > False
        bool myCondition = (x == 7) && (y == 3);
        Console.WriteLine(myCondition);

        // True || False
        // > True
        // False || False
        // > False
        myCondition = x == y || true;
        Console.WriteLine(myCondition);

        myCondition = !(x == y);
        Console.WriteLine(myCondition);
    }
}
