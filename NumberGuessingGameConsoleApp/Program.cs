namespace NumberGuessingGameConsoleApp;

internal class Program
{
    static void Main(string[] args)
    {
        //Döngüler 
        Console.WriteLine("Hi, My name is Number Guessing Game!");
        Console.WriteLine("and I want to play a game.");
        Console.WriteLine("I'll pick a number in my mind and I want you to guess that number.");
        Console.WriteLine("If you are ready, let's start");

        Random random = new Random(); //classların instance türetmesi ya da newlenmesi, ya da örneğinin türetilmesi

        int guessNumber = random.Next(1,100);
        Console.WriteLine("My number is: " + guessNumber);

        while (true) 
        {
        
        
        Console.WriteLine("Take a guess, the number I picked is from 1 to 100?");
        string response = Console.ReadLine();


        int responseTypeNumber = 0;
        bool isConvertSuccess = int.TryParse(response, out responseTypeNumber);

            if (!isConvertSuccess)
            {
                Console.WriteLine("Your answer is not a number!");

            }
            else
            {
                if (responseTypeNumber == guessNumber)
                {
                    Console.WriteLine("Congratulations! You are have found the number that I've guessed.");
                    break;
                }
                else
                {
                    Console.WriteLine("Your answer is wrong!");
                }
            }   
        }

    }
}
