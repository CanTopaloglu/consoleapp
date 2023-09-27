namespace MyFirstConsoleApp;

internal class Program
{
    static void Main(string[] args)
    { //blok , code bloğu denir.
        Console.WriteLine("Hello, World!");

        // Değişkenler =
        // string - int - decimal - double - float - boolean - datetime - object
        // type degisken_adi = degeri; //degisken syntax yapısı // syntax hatası => kodlama yaparken kodda yapılan harf ya da tanımlama hatası

        string nameLastname = "Emre Can Topaloğlu";

        int age = 27;
        decimal salary = 47500.20m;
        bool isActive = true;  // false olumsuz -- 0 => false / 1 => true 
        DateTime startDate = DateTime.Now; //September 26, 2023 21:23.10,000

        string name = "Emre";

        Console.WriteLine("Merhaba " + name);
        string readLine = Console.ReadLine();
        Console.WriteLine("Yazdığın şey: " + readLine);

    }
}