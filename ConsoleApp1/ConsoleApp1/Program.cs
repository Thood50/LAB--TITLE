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

            byte correctAnswers = 0;

            Console.WriteLine("Hello, welcome to another boring console quiz about someone you dont care about xD");

            Questions(correctAnswers);

            //Favorite Color
            //Age
            //Bilingual
            //Number Dogs
            //Where was I born/raised
        }

        static string Questions(byte total)
        {
            Console.WriteLine("First Questions: ");
            Console.WriteLine("What is Tylers Favorite Color?");
            Answers(Console.ReadLine());

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
        
        static byte Total()
    {

    }
    }
}
