using System.ComponentModel;

namespace TaskWithTimerConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        List<Task> tasks = new List<Task>();
        Console.WriteLine("Merhaba, zamanlanmış Görevlere hoş geldiniz! Ben TaskAI.");
    
    yeniTaskSonrasiZiplamaNoktasi:;
        foreach (var task in tasks)
        {
            Timer timer = new Timer(DoTask, task.Description, 0, task.Duration);
        }

        while (true)
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçin.");
            Console.WriteLine("1. Yeni Task Ata");
            Console.WriteLine("2. Mevcut Taskın Süresini Değiştir");
            Console.WriteLine("3. Taskı Sil");

            string selectString = Console.ReadLine();
            int select = 0;
            var response = int.TryParse(selectString, out select);
            if (response == false)
            {
                Console.WriteLine("Geçerli bir seçim yapmadınız. Lütfen tekrar deneyin!");
                continue;
            }
            if (select > 3)
            {
                Console.WriteLine("Liste dışından bir seçim yaptınız. Lütfen liste içinden seçim yapınız.");
                continue;
            }
            if (select == 1)
            {
                Console.WriteLine("Task Adını yazın...");
                string taskAdi = Console.ReadLine();
                Console.WriteLine("Task Açıklamasını yazın...");
                string taskAciklamasi = Console.ReadLine();

            taskSuresiZiplamaNoktasi:;
                Console.WriteLine("Task süresini milisaniye cinsinden yazın...");
                string taskSuresiString = Console.ReadLine();
                int taskSuresi = 0;
                var response1 = int.TryParse(taskSuresiString, out taskSuresi);
                if (response1 == false)
                {
                    Console.WriteLine("Lütfen geçerli bir task süresi girin!.");
                    goto taskSuresiZiplamaNoktasi;
                }

                tasks.Add(new Task() { Name = taskAdi, Description = taskAciklamasi, Duration = taskSuresi });
                goto yeniTaskSonrasiZiplamaNoktasi;
            }
        }

    }
    static void DoTask(object state)
    {
        Console.WriteLine((string)state);
    } 
}

public class Task
{
    public string Name { get; set; } // Hepsiburada
    public string Description { get; set; } //Hepsiburadaki stoklar kontrol ediliyor
    public int Duration { get; set; } //10000 
}
