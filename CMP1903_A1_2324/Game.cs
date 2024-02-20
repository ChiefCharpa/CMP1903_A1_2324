using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CMP1903_A1_2324
{
    internal class Game
    {
        /*
         * The Game class should create three die objects, roll them, sum and report the total of the three dice rolls.
         *
         * EXTRA: For extra requirements (these aren't required though), the dice rolls could be managed so that the
         * rolls could be continous, and the totals and other statistics could be summarised for example.
         */

        //Methods
        public int Rolling (int i)
        {
            Die die = new Die();
            int DieRoll = die.Roll();
            Console.WriteLine(DieRoll);
            int Total = 0;
            if (i > 1) 
            { 
                Total = Rolling (i-1);
            }
            Total = Total + DieRoll;
            //Die Die1 = new Die();
            //Die Die2 = new Die();
            //Die Die3 = new Die();

            //int Die1Roll = Die1.Roll();
            return Total ;
        }   

        public void Statistics (int i, int j) 
        {
            float Mean = j / i;
            Console.WriteLine($"The average mean of the dice is: {Mean}");
        }
    }
}
