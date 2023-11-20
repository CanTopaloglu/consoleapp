namespace TimerConsoleApp;
internal class Program
{
    static void Main(string[] args)
    {
        //.NET NUgget kütüphane olarak geçer.

        Timer timer = new(TimerCallback, null, 0, 1000);
        Console.WriteLine("Press any button to exit");
        Console.ReadLine();
    }

    static void TimerCallback(object state) 
    {
        Console.WriteLine($"Saat: {DateTime.Now}");
    }
}
