# LAB--TITLE

This project is the A typical personal quiz on Tyler Hood, the most ordinary person you can imagen.  This quiz is going to ask you questions that you have no business knowing
all for a chance to prove just how much you dont care about my life xD.

Setup: 
- 
-Open VS community   
-Create new project   
-Go to File  
-New  
-New Project  
-In the window on the left you will see a .NET Core option under Visual C# make sure you have that selected  
-Now in the middle section select Console App (.NET Core)  
-Next in the bottom change the name to your choice and change path if you want and then click "Ok"  
-Next click view  
-Then Solution Explorer  
-If it wasnt already there it will open a tab on the right side showing your Solution Explorer  
-Next click on the tiny folder tab in the Solution explorer tab the change to Solution Explorer - Folder View  
-Navigate to Program.cs file and double click to open it  
-Once you have that open copy and paste the source code below into the Program.cs file    
-Hit control S to save the source code you pasted into your file  
-Now go back up to the Solution Explorer - Folder View and hit the little folder tab to change back to the just the Solution Explorer  
-Now its time to run the code in the top nav bar hit Debug
-Then Click Start Debug to start the quiz!

Source Code:  
-
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
                Console.WriteLine($"Oops, {e.Message} Sorry to interrupt your invigorating quiz....");
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
