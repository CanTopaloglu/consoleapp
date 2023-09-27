namespace DersTekrar;

internal class Program
{
    static void Main(string[] args)
    {

        /*
         * string = metin değerlerini tutar
         * int / integer = numaritik değerleri / tam sayı değerlerini tutar
         * double - decimal = ondalıklı ve tam sayı değerlerini tutar
         * bool / boolean = 1-0 // TRUE - FALSE / DOĞRU YALNIŞ
         * Datetime = zamanı tutan
         * List<string>, 
         * var = veri tipi atandığı değere göre değişen veri türüdür.
         *
         * 
         */

        //string degiskenMetin = "Metine çeviriyor";

        string ad = "Emre";
        string soyad = "Topaloglu";
        string degiskenMetin = ad + " " + soyad;
        string degiskenMetin2 = $"{ad} {soyad}";

        Console.WriteLine(degiskenMetin2);


        int sayi1 = 5;

        int sayi2 = 15;

        uint sayi3 = 25;

        Console.WriteLine(sayi1.ToString());

        // int --> +2 147 483 648 / - 2 147 483 648

        int topla = sayi1 + sayi2;

        int taksitTutar = (sayi1 + sayi2) * Convert.ToInt32(sayi3);

        Console.WriteLine(topla);

        // curreny format #. ##0, 00
        double sayi5 = 1000.10;
        decimal sayi4 = 10.100213M;

        decimal sayi6 = Convert.ToDecimal(sayi5) + sayi4;

        Console.WriteLine(string.Format("{0:C3}", sayi6));


        //Bool boolean

        bool dogruMu = true;
        bool yanlisMi = false;

        DateTime date = Convert.ToDateTime("27.09.2023 13:01:50");

        date = DateTime.Now;
        date = date.AddDays(-10);

        //TimeSpan ts = date.Subtract(date);

        TimeSpan ts;


        DateTime date1 = Convert.ToDateTime("01.07.2023");
        DateTime date2 = DateTime.Now;

        ts = date2 - date1;

        Console.WriteLine(date.ToString(ts.ToString()));

        Console.WriteLine(date.ToShortDateString());

        //.toLongDateString())
        //.toLongTimeString())
        //date.Year ya Month da olabilir. Day 'de olabilir.


        List<string> list = new List<string>();

        string alisVeris1 = "Domates";
        string alisVeris2 = "Salatalik";
        string alisVeris3 = "Marul";

        list.Add(alisVeris1);
        list.Add(alisVeris2);
        list.Add(alisVeris3);

        Console.WriteLine(list[0]);

        List <int> list2 = new List<int>();
        list2.Add(Convert.ToInt32("10"));
        list2.Add(30);

        string[] list3 = new string[3];
        list3[0] = alisVeris1;
        list3[1] = alisVeris2;
        list3[2] = alisVeris3;

        // VAR VERI TIPI

        var metin = 10.20;
       
        // IF BLOKLARI 




    } 
        
}
