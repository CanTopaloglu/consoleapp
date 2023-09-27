using System.Threading.Channels;

namespace StudentAttendanceConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        List<int> studentList = new List<int>() { 1, 2, 3, 4 };
        List<int> attendance = new List<int>();

        Console.WriteLine("Hello, this is my students");
        Console.WriteLine("01. Emre");
        Console.WriteLine("02. Can");
        Console.WriteLine("03. Mehmet");
        Console.WriteLine("04. Alp");
        Console.WriteLine("Tell me who is in class?");

        while (attendance.Count < 4)
        {
            string result = Console.ReadLine();
            int studentID = 0;
            bool parseResult = int.TryParse(result, out studentID);

            if (parseResult)
            {
                for (int i = 0; i < studentList.Count; i++)
                {
                    if (studentList[i] == studentID)   
                    {
                        if (attendance.Count == 0)
                        {
                            attendance.Add(studentID);
                            Console.WriteLine($"{studentID} marked as present, who else is in class?");
                        }
                        else
                        {
                            for (int j = 0; j < attendance.Count; j++)
                            {
                                if (attendance[j] == studentID)
                                {
                                    Console.WriteLine("Student already marked present.");
                                }
                                else if (j == attendance.Count - 1)
                                {
                                    attendance.Add(studentID);
                                    Console.WriteLine($"{studentID} marked as present, who else is in class?");

                                    break;
                                }
                            }
                        }

                        break;
                    }
                    else if (i == studentList.Count - 1)
                    {
                        Console.WriteLine("Could not found a student with given ID.");
                    }
                }
            }
            else if (parseResult == false)
            {
                Console.WriteLine("Wrong input, tell me who is in class?");
            }
        }

        Console.WriteLine("All students are markes as present in the class");
        Console.WriteLine("Press any key to exit");
        Console.ReadLine();

        //studentTotal = int.Parse(result);


        //int kontrolü ile sınıftaki öğrenicnin numarasını isteyin - OK
        //int değer girilmezse hata fırlatın - OK
        //değer int ise sınıftaki öğrenci numaralarında bu değeri arayın ve eğer böyle numaralı bir öğrenci yoksa hata fırlatın - OK
        //eğer öğrenci varsa ekranda şu öğrenci sınıfta olarak işaretlendi yazsın ve sonra başka kim sınıfta diye sorsun -OK

        //Bonus ödev: Eğer öğrenci zaten sınıfta işaretlendiyse o zaman tekrar işaretlenmesin ve hata versin. (zaten bunu söyledin gibi bir hata versin eğer varsa yani).
        //ARRAY YA DA LİSTE KULLANMAM LAZIM BONUS ÖDEVLER İÇİN.
        // Bonus ödev: tüm öğrenciler sınıfta olarak işaretlenirse uygulama herkes sınıfta desin ve kapansın. 



    }
}
