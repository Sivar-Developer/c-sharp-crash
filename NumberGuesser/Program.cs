using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            // string name = "Sivar Sarkawt";
            // 
            // Console.WriteLine("Hello "+ name);

            // Set app vars
            string appName = "NumberGuesser";
            string appVersion = "1.0.0";
            string appAuthor = "Sivar Sarkawt";

            // Change text color
            Console.ForegroundColor = ConsoleColor.DarkGreen;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset console text color
            Console.ResetColor();

            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game", inputName);

            // Set correct number
            // int correctNumber = 7;

            // Create new random object
            Random random = new Random();
            int correctNumber = random.Next(1, 10);

            // Init guess bar
            int guess = 0;

            // Ask user for a number
            Console.WriteLine("Guess a number between 1 and 10");

            // While guess is not correct
            while(guess != correctNumber)
            {
                // Get user input
                string input = Console.ReadLine();

                // Make sure its number
                if(!int.TryParse(input, out guess))
                {
                    // Change text color
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                    // Write out app info
                    Console.WriteLine("Please enter an actual number");

                    // Reset console text color
                    Console.ResetColor();

                    // Keep going
                    continue;
                }

                // Cast to int and put in guess
                guess = Int32.Parse(input);

                // Match guess to correct number
                if(guess != correctNumber)
                {
                    // Change text color
                    Console.ForegroundColor = ConsoleColor.DarkRed;

                    // Write out app info
                    Console.WriteLine("Wrong number, please try again");

                    // Reset console text color
                    Console.ResetColor();
                }
            }

            // Change text color
            Console.ForegroundColor = ConsoleColor.Yellow;

            // Tell user its right number
            Console.WriteLine("Wrong number, please try again");

            // Reset console text color
            Console.ResetColor();

            // Ask any key before close
            Console.WriteLine("Press any key to stop...");
            Console.ReadKey();

        }
    }
}
