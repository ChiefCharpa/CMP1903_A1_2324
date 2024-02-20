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
            /*
             * Create a Game object and call its methods.
             * Create a Testing object to verify the output and operation of the other classes.
             */
            Game game = new Game();
            Statistics statistics = new Statistics();   
            int gameResult = game.Rolling(3);
            Console.WriteLine($"The total of the 3 dice is: {gameResult}");

            statistics.Mean(3, gameResult);

            Testing testing = new Testing();
            testing.runCode();
        }
    }
}
