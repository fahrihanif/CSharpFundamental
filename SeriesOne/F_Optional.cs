namespace SeriesOne;

public class F_Optional
{
    public static void UnexpectedHandling()
    {
        // try - catch - finally
        try
        {
            object o2 = null;
            int i2 = (int)o2;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    public static void Extra()
    {
        // Shortcut Type cw + tab + tab
        Console.WriteLine("Hello");

        // Input text
        string text = Console.ReadLine();
        Console.WriteLine("Ketikan : " + text);

        // Input Numeric
        int num = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ketikan : " + num + ".");

        // String interpolation
        Console.WriteLine($"Ketikan : {num}.");
    }
}
