namespace SeriesOne;

public class D_Looping
{
    public static void ForLoop()
    {
        // Format
        // for (initialization; termination; increment/decrement) {
        //      statement(s)
        // }

        // For Loop
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Counter : " + i);
        }

        // For-each
        int[] listAngka = { 5, 2, 9, 12, 4 };
        foreach (int item in listAngka)
        {
            Console.WriteLine("Angka : " + item);
        }
    }

    public static void WhileLoop()
    {
        int counter = 0;

        // While - do
        while (counter < 10)
        {
            Console.WriteLine("Counter : " + counter);
            counter++;
        }

        // Do - While
        counter = 10;
        do
        {
            Console.WriteLine("Counter : " + counter);
            counter++;
        } while (counter < 10);
    }
}
