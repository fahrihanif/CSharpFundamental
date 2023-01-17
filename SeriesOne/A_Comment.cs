namespace SeriesOne; // Namespace

class A_Comment // Class name
{
    // didalam blok class disebut Commands atau Methods
    static void Main()
    {
        /*  Ini adalah comment multi-line [Shortcut ctrl+shift+/]
         *  Komentar, bagian yang tidak akan dieksekusi oleh komputer
         *  Fungsi komentar biasanya untuk membuat keterangan pada kode program
         *  Penggunaan komentar yang baik : https://stackoverflow.blog/2021/12/23/best-practices-for-writing-code-comments/
         */

        // Comment single-line [Shortcut ctrl+k+c] & uncomment [Shortcut ctrl+k+u]

        E_Method.perkenalkanDiri();
        E_Method.perkenalkanDiriParameter("Violet");

        int jumlah = E_Method.penjumlahan(5, 6);
        Console.WriteLine(jumlah);

        F_Optional.Extra();
    }
}