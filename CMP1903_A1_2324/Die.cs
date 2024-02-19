using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
       

            /*
             * The Die class should contain one property to hold the current die value,
             * and one method that rolls the die, returns and integer and takes no parameters.
             * and one method that rolls the die, returns an integer and takes no parameters.
             */

            //Property

            // Creates an encapsulated private variable for the number rolled
            private int _RollNumber = 0;

            // Creates the setter and getter for the private variable so it is encapsulated
            public int RollNumber
            {
                get { return _RollNumber; }
                set { _RollNumber = value; }
            }


            //Method
            public int Roll()
            {
                // Instantiates an instance of the class random
                Random rnd = new Random();
                // Creates a random number between 1 and 6 for the dice roll
                RollNumber = rnd.Next(1, 7);
                // returns the value stored by the dice roll in the private variable
                return RollNumber;
            }

    }
}
