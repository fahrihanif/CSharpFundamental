namespace SeriesTwo.E_Abstraction.Abstract;

//Abstract Class -> Partial Abstraction, isinya bisa abstract method
//bisa method biasa, bisa juga menampung attribute
public abstract class AbstractCalculator
{
    int result;  //attribute

    public abstract int Penjumlahan(int a, int b); //abstract method

    int Pengurangan(int a, int b) //method biasa
    {
        result = a - b;
        return result;
    }
}
