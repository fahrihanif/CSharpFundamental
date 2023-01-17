namespace SeriesOne;

public class E_Method
{
    //void method
    public static void perkenalkanDiri()
    {
        Console.WriteLine("Hai saya Hanif");
    }

    public static void perkenalkanDiriParameter(string nama)
    {
        Console.WriteLine("Hai saya : " + nama);
    }

    //non-void method
    public static int penjumlahan(int a, int b)
    {
        return a + b;
    }

    public static float pembagian(float a, float b)
    {
        return a / b;
    }
}
