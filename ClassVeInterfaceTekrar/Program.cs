namespace ClassVeInterfaceTekrar;

internal class Program
{
    static void Main(string[] args)
    {   
        //Private ise sadece aynı class'ta çağırılabilir.
        //Internal sadece aynı projede çağırabilir.
        //Public her yerden erişilebilir.


        OrnekClass ornekClass = new OrnekClass("Taner");
        ornekClass.Id = 0;

        //Console.WriteLine(ornekClass.DegiskenE);

        ornekClass.Add();
        ornekClass.update();
    }
    //Implement ediyorum
    // class'a interface'i dahil ederseniz ismi implement oluyor.
    //inherit
    //class'a class dahil ederseniz ismi inherit oluyor.
    class OrnekClass : DenemeClass, OrnekInterface, OrnekInterface2
    {
        //constructor

        public OrnekClass(string name)
        {
            DegiskenE = name;     
        }
        //property tutabiliyoruz içerisinde
        //metodları tutabiliyoruz.

        //propertyler
        //değişkenlerin {get : set } bloklarıyla çalışır.

        public string DegiskenE {  get; set; }

        public void Add()
        {
            Console.WriteLine("Deneme interface metot");
        }

        public void Add2()
        {
            Console.WriteLine("Deneme interface2 metot");
        }
    }
    interface OrnekInterface
    {
        //Property ya da metot tutuculardır.

        void Add();
    }

    interface OrnekInterface2 
    {
        void Add2();
    }

    class DenemeClass 
    {
        public int Id { get; set; }

       public void update()
        {
            Console.WriteLine("Update metotu çalıştı");
        }
    }

}
