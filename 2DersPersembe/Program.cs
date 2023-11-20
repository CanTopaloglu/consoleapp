namespace _2DersPersembe;

internal class Program
{
    static void Main(string[] args)
    {
        List<Student> students = new()
        {
            new Student()
            {
                No = 1,
                Name = "Emre Can",
                Class = "2A",
                DateOfBirth = Convert.ToDateTime("05.01.1996")

            }, 
           new Student()
           {
               No= 2,
               Name = "Ahmet Kırkalı",
               Class = "2A",
               DateOfBirth = Convert.ToDateTime("01.01.1996")
           }
           
        };

        var student = new Student()
        {
            No = 3,
            Name = "Emre Can Topaloglu",
            Class = "2A",
            DateOfBirth = Convert.ToDateTime("02.05.1996")
        };
        
        students.Add(student);

        //ARRAY :  string[] students = new string[3] { "Emre", "Alp", "Can" };
        Console.WriteLine("Hello, this is my students");
        foreach (var s in students)
        {
            //Console.WriteLine("Öğrenci Numarası: " + s.No + "Öğrenci Adı: " + s.Name);
            //Console.WriteLine($"Öğrenci Numarası: {s.No}\nÖğrenci Adı: {s.Name}\n-------------");

            Console.WriteLine($@"
Number: {s.No}
Name: {s.Name}
Class: {s.Class}
Date Of Birth: {s.DateOfBirth}
-------------");
        }

        while(true) 
        {   
            //Tüm öğrenciler sınıfta mı kontrolü yapıyoruz.
            foreach (var s in students)
            {
                if(s.IsInClass == false) 
                {
                    goto start; //start yazdıgım yere kodu zıplattım
                }
            }
            Console.WriteLine("Tüm Öğrenciler Sınıfta!");
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
                Console.WriteLine("Please write a number!");
                continue;
            }
            //Burada yazılan değerin numaratik olup olmadığını kontrol ediyoruz

            //Burada yazdığımız numaraya ait bir öğrencinin olup olmadığını kontrol ediyoruz
            result = students.Any(x=> x.No==no); //lambda expression
            if(!result) 
            {
                Console.WriteLine("The number you entered doesn't belong to our class! Please try again!");
                continue;

            }
            //Burada yazdığımız numaraya ait bir öğrenci olup olmadığını kontrol ediyoruz.

            //Yazdığımız numaraya ait öğrencinin zaten sınıfta olarak işaretlenip işaretlenmediğini kontrol ediyoruz
            Student st = students.FirstOrDefault(p=> p.No==no);
            if (st.IsInClass) 
            {
                Console.WriteLine("This student already in class!");
                continue;
            }
            //Yazdığımız numaraya ait öğrencinin zaten sınıfta olarak işaretlenip işaretlenmediğini kontrol ediyoruz

            //Öğrenciyi sınıfta olarak işaretliyoruz
            st.IsInClass = true;
            Console.WriteLine($"{st.Name} marked as present.)");
            //Öğrenciyi sınıfta olarak işaretliyoruz
        }


    }
}

//access modifier => erişim belirleyicisi
internal class Student
{
    public int No { get; set; }
    public string Name { get; set; } //property
    public string Class { get; set; }
    public DateTime DateOfBirth { get; set; }
    public bool IsInClass { get; set; } = false;
}