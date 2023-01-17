using SeriesTwo.E_Abstraction.Abstract;

namespace SeriesTwo.E_Abstraction;

public class Example05
{
    public static void Main()
    {
        AbstractCalculator cal = new ImplementCalculator();
        Console.WriteLine(cal.Penjumlahan(2, 3));
    }
}
