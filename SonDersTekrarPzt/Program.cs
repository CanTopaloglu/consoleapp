namespace SonDersTekrarPzt;

internal class Program
{
    static void Main(string[] args)
    {
        //string[] students = new string[4]; //array yönetimi
        List<Student> students = new()
        {
            //bura sadece class alabilir içine
            new Student()
            {
             No =1,
             Name= "Emre Can",
             Class= "1A",
             DateOfBirth= Convert.ToDateTime("05.01.1996")
             
            },
            new Student()
            {
                No=2,
                Name="Ahmet Yalvac",
                Class= "2A",
                DateOfBirth= Convert.ToDateTime("01.01.1995")
            }

        };

        var student = new Student()
        {
            No = 3,
            Name = "Mehmet Can Ünaldı",
            Class = "2A",
            DateOfBirth = Convert.ToDateTime("01.02.1994")
        };
        students.Add(student);

        Console.WriteLine("Hello,this is my students!");
        foreach (var s in students)
        {
            //Console.WriteLine("Öğrenci Numarası: " + s.No + " Öğrenci Adı: " + s.Name); daha prof için aşağıdaki
            Console.WriteLine($@"
Number: {s.No}
Name: {s.Name}
Class: {s.Class}
Date of Birth: {s.DateOfBirth}
-------------------");
            //Console.WriteLine($"{s.No}.{s.Name}"); bu daha temiz karısıklıktan az gösterebilir.
                
        }
        while(true)
        {
            //Tüm öğrenciler sınıfta mı kontrolü yapıyoruz.
            foreach (var s in students)
            {
                if(s.IsInClass == false)
                {
                    goto start;
                }
            }
            Console.WriteLine("Tüm öğrenciler sınıfta!");
            break;
        //Tüm öğrenciler sınıfta mı kontrolü yapıyoruz.

        start:;
            Console.WriteLine("Tell me who is in class?");
            string noString = Console.ReadLine();
            int no = 0;
            //Burada yazılan değerin numaratik olup olmadığını kontrol ediyoruz.
            bool result = int.TryParse(noString, out no);

            if (!result)
            {
                Console.WriteLine("Please enter a number!");
                continue;
            }
            //Burada yazılan değerin numaratik olup olmadığını kontrol ediyoruz.

            //Burada yazdığımız numaranın bir öğrenci olup olmadığını kontrol ediyoruz.
            result = students.Any(x => x.No == no); //lambda expression
            if (!result)
            {
                Console.WriteLine("The Number you entered doesn't belong to our class. Please try again!");
                continue;
            }
            //Burada yazdığımız numaranın bir öğrenci olup olmadığını kontrol ediyoruz.

            //Yazdığımız numaraya ait Öğrencinin zaten sınıfta olarak işaretlenip, işaretlenmediğini kontrol ediyoruz.
            Student st = students.FirstOrDefault(p=>p.No == no);
            if (st.IsInClass)
            {
                Console.WriteLine("This student already in class!");
                continue;
            }
            //Yazdığımız numaraya ait Öğrencinin zaten sınıfta olarak işaretlenip, işaretlenmediğini kontrol ediyoruz.


            //Öğrenciyi sınıfta var olarak işaretliyoruz.
            st.IsInClass = true;
            Console.WriteLine($"{st.Name} sınıfta olarak işaretlendi.");
            //Öğrenciyi sınıfta var olarak işaretliyoruz.
        }

    }
}

//Acess modifier => erişim belirleyicisi
internal class Student 
{
    public string Name { get; set; } //property, Title Case
    public int No { get; set; }
    public string Class { get; set; }
    public DateTime DateOfBirth { get; set; }
    public bool IsInClass { get; set; } = false;




}
