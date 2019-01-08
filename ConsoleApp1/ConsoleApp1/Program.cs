using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 5 Questions
            // include atleast 3 non-void methods
            // include atleast 3 different return types
            // atleast 1 try catch
            // start without code manipulation

            int correctAnswers = 0;

            Console.WriteLine("Hello, welcome to another boring console quiz about someone you dont care about xD");

            Questions(correctAnswers);

            //Favorite Color
            //Age
            //Bilingual
            //Number Dogs
            //Where was I born/raised
        }

        static string Questions(int total)
        {
            Console.WriteLine("First Questions: ");
            Console.WriteLine("What is Tylers Favorite Color?");
            if (Answers(Console.ReadLine()) == true)
            {
                Console.WriteLine("hmmmm.....you must be cheating");
                total = Total(total);
            }
            if (Answers(Console.ReadLine()) == false)
            {
                Console.WriteLine("its fine not to care.");
            }
            Console.WriteLine("Second Questions: ");
            Console.WriteLine("How old is Tyler");
            if(Answers(Console.ReadLine()) == true)
            {
                Console.WriteLine("Luckiest guess of your life");
                total = Total(total);
            }
            if (Answers(Console.ReadLine()) == false)
            {
                Console.WriteLine("The odds were against you anyways");
            }

        }

        static bool Answers(string guess)
        {
            if (guess == "Blue")
            {
                return true;
            }
            if (Convert.ToByte(guess) == 24)
            {
                return true;
            }
            if (guess == "yes" || guess == "true")
            {
                return true;
            }
            if (Convert.ToByte(guess) == 2)
            {
                return true;
            }
            if (guess == "Chelan" || guess == "Lake Chelan")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
        static int Total(int oldTotal)
    {
            return oldTotal + 1;
    }
    }
}
