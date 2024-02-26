using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Die
    {
       

            /*
             * The Die class should contain one property to hold the current die value,
             * and one method that rolls the die, returns an integer and takes no parameters.
             */

            //Property

            // Creates an encapsulated private variable for the number rolled by the Roll method
            private int _RollNumber = 0;

            // Creates the setter and getter for the private variable so it is encapsulated
            public int RollNumber
            {
                get { return _RollNumber; }
                set { _RollNumber = value; }
            }


            //Method

            /*
             * Roll is the method that will take no parameters and will roll 1 dice using random,
             * and will use the setter to store the given value in the private property
             */

            public void Roll()
            {
                /*
                * Due to random changing every clock tick a pause timer is required, 
                * so before calling random a timer of 200 miliseconds is called to allow a new random number tyo be generated
                */
                int millisecond = 200;
                Thread.Sleep(millisecond);
                // Instantiates an instance of the class random
                Random rnd = new Random();
                // Creates a random number between 1 and 6 for the dice roll and assigns the value to the private variable _RollNumber
                RollNumber = rnd.Next(1, 7);
            }

    }
}
