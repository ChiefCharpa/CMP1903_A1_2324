using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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


            // Creates instance of the Die Class
            Die Die1 = new Die();
            // The expected output is between 1 - 6
            Die1.Roll();
            Debug.Assert(0 < Die1.RollNumber && Die1.RollNumber < 7);
            // The actual number is between 1 - 6 so matches the expectation

            Game game = new Game();

        }
    }
}   


