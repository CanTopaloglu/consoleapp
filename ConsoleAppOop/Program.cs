namespace ConsoleAppOop;

class Program : User
{
    static void Main(string[] args)
    {
        //Taner taner = new();
        //taner.SetAge();

        //taner.Name = "Test";

        //User user = new();
        //var result = user.Calc(1,2,3,4,5,6,7,8,9);
        //Console.WriteLine(result);

        User user = new();
        int age = 5;
        int age2;
        Console.WriteLine(age);

        user.SetAge(ref age);
        Console.WriteLine(age);

        user.SetAge2(out age2);
        Console.WriteLine(age2);
        Console.WriteLine("Hello, World!");
    }
}
