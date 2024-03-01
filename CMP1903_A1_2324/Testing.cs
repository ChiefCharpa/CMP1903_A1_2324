using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CMP1903_A1_2324
{
    internal class Testing
    {
        /*
         * This class should test the Game and the Die class.
         * Create a Game object, call the methods and compare their output to expected output.
         * Create a Die object and call its method.
         * Use debug.assert() to make the comparisons and tests.
         */

        //Method
        public void TestCode()
        {

            // Tests to ensure that the roll method produces numbers in the acceptable range of integers 

            // Creates instance of the Die Class
            Console.WriteLine("Die Test");
            Die Die1 = new Die();
            // The expected output is between 1 - 6
            Die1.Roll();
            Debug.Assert(0 < Die1.RollNumber && Die1.RollNumber < 7);
            // The actual number is between 1 - 6 so matches the expectation



            // Tests to ensure that the 3 rolls and given total are correct to the expected range and values.
            Console.WriteLine("Game Test");
            // Creates an instance of the Game class
            Game game = new Game();
            // Calls the RollingContinous method and passing a second parameter to run the testing code
            game.RollingContinuous(true,true);

            /*
             * prints 3 rolled dice with the correct total being displayed
             */


            // Tests to ensure that the statistical functions calculate the expected outputs for the known array
            Console.WriteLine("Statistic Test");
            // Test array so we can determine that the logic works correctly
            int[] TestingRolls = { 1, 2, 2, 2, 3, 4, 6, 6 };

            // Creates an instance of Statistics class
            // calls the Mean method passing a bool to run the testing code
            game.Mean(TestingRolls,true);
            // Calls and prints the Mode method along with passing booln variable to call the testing code
            Console.WriteLine($"The current mode of the dice is: {game.Mode(TestingRolls, true)}");

            /*
             * Expected Values
             * Mean = 3
             * Median = 2
             * Mode = 2
             * 
             * The codes output matches the expected values
             * 
             */

        }
    }
}   


