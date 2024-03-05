using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // initially initialises a boolean variable valid setting it to false
            bool valid = false;
            // Whilst the value is false iterate through the code
            while (!valid)
            {
                // A string variable InputtedValue is instantiated as an empty string
                string InputtedValue = "";
                // An output is produced in the console window asking if the user wants to run a test
                Console.WriteLine("Do you want to run the test: Y or N");
                // Try is used to ensure the user inputs a valid input and prevents any possible crashes
                try
                {
                    // The users input is taken and is attempted to be stored as a string in InputtedValue
                    InputtedValue = Console.ReadLine();
                    // The input is compared with the two valid answers and if it does valid is set to true
                    if (InputtedValue == "Y" || InputtedValue == "N")
                    {
                        valid = true;
                    }
                    else
                    {
                        Console.WriteLine("Invalid character. Must be Y or X. ");
                    }
                }
                // If an error is produced in try no code will be executed repeating the while loop
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid input, must be a character and be Y or X.");
                }

                // if the input was valid then the input is compared otherwise the code skips to the start of the while loop
                if (valid)
                {
                    // Compares the players input and if the value matches run the nested code
                    if (InputtedValue == "Y")
                    {
                        // Instaniates an object of the class testing
                        Testing testing = new Testing();
                        // the testing method test code is called
                        testing.TestCode();
                    }
                    // Create a Game object and call the RollingContinous method
                    Game game = new Game();
                    game.RollingContinuous(true);
                }
            }


        }
    }
}
