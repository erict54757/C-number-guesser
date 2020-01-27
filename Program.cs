using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{


    //mainClass
    class Program


    {


        static int LetterToNumber(string args)
        {

            int userGuessNumber = Int32.Parse(args);
            return userGuessNumber;


        }
        // entryPoint for program
        static void Main(string[] args)
        {
            //start here
            string startOver = "";
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Eric Taft";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}:Version {1} by {2}", appName, appVersion, appAuthor);
            

            Console.ResetColor();

            //ask the user's name
            Console.WriteLine("What is your name?");
            //store line in variable
            string input = Console.ReadLine();

            Console.WriteLine("Hello " + input + ", Want to play a game? Press Y for Yes or N for No.");

            string play = Console.ReadLine();

            // Conditional to see if you want to play or not
            void playThis()
            {
                if (play == "y" || play == "Y")
                {

                    Console.WriteLine("Guess a number between 1 and 10");
                    int RandomNumber(int min, int max)
                    {
                        Random random = new Random();
                        return random.Next(min, max);
                    }

                    int rand = RandomNumber(1, 10);

                    int guess = LetterToNumber(Console.ReadLine());
                    // run until user guess equals random number
                    while (guess != rand)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Sorry, that is not correct! Guess again...");
                        Console.ResetColor();
                        guess = LetterToNumber(Console.ReadLine());
                    }


                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Random number between 1 and 10 is {rand} your guess was {guess}!");
                    Console.WriteLine($"Congratulations, Would you like to play again? Hit Y for Yes or any other key for No.");
                    Console.ResetColor();




                    startOver = Console.ReadLine();
                    
                }
                else
                {
                    Console.WriteLine("Ok, bye go away then!");
                    Console.ReadLine();

                }


            }
            playThis();
            while (startOver == "y" || startOver == "Y")
            {
                play = "y";
                playThis();

            }
        }


    }
}
