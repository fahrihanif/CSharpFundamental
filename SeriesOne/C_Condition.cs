namespace SeriesOne;

public class C_Condition
{
    public static void IF()
    {
        bool isActive = true;
        float ipk = 3.9f;
        float durasiPendidikan = 5;

        // #1 if
        if (isActive)
        {
            Console.WriteLine("Aktif");
        }

        // #2 if-else
        if (!isActive)
        {
            Console.WriteLine("Tidak Aktif");
        }
        else
        {
            Console.WriteLine("Aktif");
        }

        // #3 if-elseif-else
        if (ipk > 3.9f)
        {
            Console.WriteLine("Mendapatkan beasiswa 100%");
        }
        else if (ipk > 3.5f) // True
        {
            Console.WriteLine("Mendapatkan beasiswa 80%");
        }
        else
        {
            Console.WriteLine("Tidak mendapatkan beasiswa");
        }

        // #4 nestedIf
        if (durasiPendidikan < 4)
        {
            if (ipk > 3.9f)
            {
                Console.WriteLine("Lulus Cumlaude");
            }
            else if (ipk > 3.5f)
            {
                Console.WriteLine("Lulus berprestasi");
            }
        }
        else if (durasiPendidikan == 4)
        {
            Console.WriteLine("Lulus Normal");
        }
        else
        {
            Console.WriteLine("Lulus sedikit terlambat");
        }
    }

    public static void SwitchCase()
    {
        //int month = 8;
        //if (month == 1)
        //{
        //    Console.WriteLine("January");
        //}
        //else if (month == 2)
        //{
        //    Console.WriteLine("February");
        //}
        // ... and so on

        int month = 6;
        string monthString;
        switch (month) // 8
        {
            case 1:
                monthString = "January";
                break;
            case 2:
                monthString = "February";
                break;
            case 3:
                monthString = "March";
                break;
            case 4:
                monthString = "April";
                break;
            case 5:
                monthString = "May";
                break;
            case 6:
                monthString = "June";
                break;
            case 7:
                monthString = "July";
                break;
            case 8:
                monthString = "August";
                break;
            case 9:
                monthString = "September";
                break;
            case 10:
                monthString = "October";
                break;
            case 11:
                monthString = "November";
                break;
            case 12:
                monthString = "December";
                break;
            default:
                monthString = "Invalid month";
                break;
        }
        Console.WriteLine(monthString);
    }
}
