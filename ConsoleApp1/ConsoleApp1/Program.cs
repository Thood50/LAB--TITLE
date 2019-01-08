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
                int one = FavColor(total);

                int two = Age(one);

                int three = Bilingual(two);

                int four = Dogs(three);

                int five = Born(four);

                Console.WriteLine(QuizResults(five));
            }

            catch (Exception e)
            {
                Console.WriteLine($"Oops, {e.Message} Sorry to interrupt your invigorating quiz....please close the Consule and report the bug to Tyler!");
            }
        }//closing Questions method

        static bool Answers(string guess)
        {
            try
            {
                if (guess == "Blue" || guess == "blue")
                {
                    return true;
                }

                if (guess == "yes" || guess == "Yes" || guess == "True" || guess == "true")
                {
                    return true;
                }

                if (guess == "Chelan" || guess == "chelan" || guess == "Lake Chelan" || guess == "lake chelan")
                {
                    return true;
                }

                if (Convert.ToInt32(guess) == 2)
                {
                    return true;
                }

                if (Convert.ToInt32(guess) == 24)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (FormatException)
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
            else
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
        }//closing Age method

        static int Bilingual(int total)
        {
            Console.WriteLine("Third Question: ");
            Console.WriteLine("Can Tyler speak two languages?");
            if (Answers(Console.ReadLine()) == true)
            {
                Console.WriteLine("Well I speak german, I dont english good though xD");
                total = Total(total);
                return total;
            }
            else
            {
                Console.WriteLine("Wow, you think im uncultured, ill remember that....");
                return total;
            }
        }//closing Bilingual method

        static int Dogs(int total)
        {
            Console.WriteLine("Forth Question: ");
            Console.WriteLine("How many puppies do I have?");
            if (Answers(Console.ReadLine()) == true)
            {
                Console.WriteLine("Well they are actually fully grown, but they will forever be puppies to me!!");
                total = Total(total);
                return total;
            }
            else
            {
                Console.WriteLine("Yes, I have a pulse....gosh");
                return total;
            }
        }//closing Dogs method

        static int Born(int total)
        {
            Console.WriteLine("Last Question I swear: ");
            Console.WriteLine("Where was I born/raised?");
            if (Answers(Console.ReadLine()) == true)
            {
                Console.WriteLine("Its really creepy that you knew that!");
                total = Total(total);
                return total;
            }
            else
            {
                Console.WriteLine("Actually really glad you got it wrong, that would be creepy if you knew that!");
                return total;
            }
        }//closing Born method
    }
}
