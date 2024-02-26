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
            bool valid = false;
            while (!valid)
            {
                Console.WriteLine("Do you want to run the test: Y or N");
                try
                {
                    string InputtedValue = Console.ReadLine();
                    if (InputtedValue == "Y" || InputtedValue == "X")
                    {
                        
                    }
                }
                catch (Exception ex)
                { }
            }
            Testing testing = new Testing();
            testing.TestCode();
            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */
            Game game = new Game();
            game.RollingContinuous(true);

        }
    }
}
