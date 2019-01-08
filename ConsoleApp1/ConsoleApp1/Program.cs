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

            Console.ReadLine();
            //Favorite Color
            //Age
            //Bilingual
            //Number Dogs
            //Where was I born/raised
        }

        static void Questions(int total)
        {
            try
            {
                FavColor(total);

                Age(total);

                Console.WriteLine("Third Question: ");
                Console.WriteLine("Can Tyler speak two languages?");
                if (Answers(Console.ReadLine()) == true)
                {
                    Console.WriteLine("Well I speak german, I dont english good though xD");
                    total = Total(total);
                }
                else
                {
                    Console.WriteLine("Wow, you think im uncultured, ill remember that....");
                }
                Console.WriteLine("Forth Question: ");
                Console.WriteLine("How many puppies do I have?");
                if (Answers(Console.ReadLine()) == true)
                {
                    Console.WriteLine("Well they are actually fully grown, but they will forever be puppies to me!!");
                    total = Total(total);
                }
                else
                {
                    Console.WriteLine("Yes, I have a pulse....gosh");
                }
                Console.WriteLine("Last Question I swear: ");
                Console.WriteLine("Where was I born/raised?");
                if (Answers(Console.ReadLine()) == true)
                {
                    Console.WriteLine("Its really creepy that you knew that!");
                    total = Total(total);
                }
                else
                {
                    Console.WriteLine("Actually really glad you got it wrong, that would be creepy if you knew that!");
                }
                Console.WriteLine(QuizResults(total));
            }

            catch (Exception e)
            {
                Console.WriteLine($"oops, {e.Message} in the Question Method! sorry to interrupt your invigorating quiz....");
            }
        }//closing Questions method

        static bool Answers(string guess)
        {
            if(guess == "Blue")
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

        }//closing Answers method
        
        static int Total(int oldTotal)
        {
            return oldTotal + 1;

        }//closing Total method

        static string QuizResults(int total)
        {
            if (total <= 3)
            {
                string response = $"Welp, you got {total} right, glad to know we're complete strangers to one another xD";
                return response;
            }
            else
            {
                string response = $"Uh, its wierd that you got {total} right.....dont ask me to take your quiz, I wont do that well....";
                return response;
            }
        }//closing QuezResults method

        static int FavColor(int total)
        {
            Console.WriteLine("First Question: ");
            Console.WriteLine("What is Tylers Favorite Color?");
            if (Answers(Console.ReadLine()) == true)
            {
                Console.WriteLine("hmmmm.....you must be cheating");
                total = Total(total);
                return total;
            }
            else (Answers(Console.ReadLine()) == false)
                {
                Console.WriteLine("its fine not to care.");
                return total;
            }
        }//closing FavColor method

        static int Age(int total)
        {
            Console.WriteLine("Second Question: ");
            Console.WriteLine("How old is Tyler");
            if (Answers(Console.ReadLine()) == true)
            {
                Console.WriteLine("Luckiest guess of your life");
                total = Total(total);
                return total;
            }
            else
            {
                Console.WriteLine("The odds were against you anyways");
                return total;
            }
        }
    }
}
