namespace SeriesOne;

public class A_DataTypeAndVariable
{
    /* Variable, wadah untuk menyimpan nilai atau value
     * DataType, menentukan format penyimpanan nilai yang dapat berisi tipe atau rentang tertentu
     * Value, nilai yang dapat dimanipulasi oleh program (dinamis)
     * 
     * Penulisan variable 
     * Explicit
     * Format : 
     * DataType Variable;
     * Variable = Value;
     * 
     * Implicit
     * Format :
     * DataType Variable = Value;
     */

    public static void Variable()
    {
        // Deklarasi
        int umur;
        float ipk;
        bool isActive;
        string nama;

        // Inisialisasi
        umur = 22;
        ipk = 3.8f;
        isActive = true;
        nama = "Han";

        // Print
        Console.WriteLine(nama);
        Console.WriteLine(umur);
        Console.WriteLine(ipk);
        Console.WriteLine(isActive);

        //Deklarasi + Inisialisasi
        int umur2 = 22;
        float ipk2 = 3.8f;
        bool isActive2 = false;
        string nama2 = "Han";

        // Print
        Console.WriteLine(nama2);
        Console.WriteLine(umur2);
        Console.WriteLine(ipk2);
        Console.WriteLine(isActive2);

        nama2 = "Hanif";
        Console.WriteLine("Data yang sudah dirubah");
        Console.WriteLine(nama2);
    }

    public static void Array()
    {
        /* Array, dapat menampung beberapa nilai dengan tipe data yang sama
         * Array dibagi menjadi 3 yaitu indexed, multidimensional, associative (next series)
         * Panjang pada array bersifat tetap pada saat inialisasi dan tidak bisa ditambah/ dikurang
         * 
         * Saat menampilkan array diikuti dengan [index] index selalu dimulai dengan angka 0
         */

        // indexed arrays
        string[] prodiImplicit = { "IF", "TI", "SI" };

        string[] prodiExplicit;
        prodiExplicit = new string[2];

        prodiExplicit[0] = "TE";
        prodiExplicit[1] = "TK";
        //prodiExplicit[2] = "MNJ"; // Akan terjadi error karena data yang di assign melebih batas 

        Console.WriteLine(prodiExplicit[0]);
        Console.WriteLine(prodiExplicit[1]);
        //Console.WriteLine(prodiExplicit[2]); // Index was outside the bounds of the array.

        // multidimensional arrays
        string[,] names = {
            {"Mr. ", "Mrs. ", "Ms. "},
            {"Smith", "Jones", "Larisa"}
        };

        Console.WriteLine(names[0, 1]);
        Console.WriteLine(names[2, 2]);
    }
}
