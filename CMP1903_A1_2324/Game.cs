using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
        private int[] storedRolls = { };




        //Methods
        public int Rolling (int i)
        {
            Die die = new Die();
            die.Roll();
            int DieRoll = die.RollNumber;
            storedRolls.Append(DieRoll);
            Console.WriteLine(DieRoll);
            int Total = 0;
            if (i > 1) 
            { 
                Total = Rolling (i-1);
            }
            //Die Die1 = new Die();
            //Die Die2 = new Die();
            //Die Die3 = new Die();

            //int Die1Roll = Die1.Roll();
            return Total ;
        }

        public void RollingContinuous(bool Val)
        {
            
            while (Val == true)
            {
                Die die = new Die();
                Statistics statistics = new Statistics();
                for (int i = 0; i < 3; i++) 
                {
                    die.Roll();
                    int DieRoll = die.RollNumber;
                    storedRolls = storedRolls.Append(DieRoll).ToArray();
                    Console.WriteLine();
                    Console.WriteLine($"Dice {storedRolls.Count()} rolled a {DieRoll}");
                }
                int Total = 0;
                foreach (int previousRoll in storedRolls)
                {
                    Total = Total + previousRoll;
                }
                Console.WriteLine();
                Console.WriteLine($"The current total of the dice is: {Total}");
                statistics.Mean(storedRolls);
                Console.WriteLine($"The current mode of the dice is: {statistics.Mode(storedRolls)}");
                Console.WriteLine();
                Console.WriteLine("Do you want to roll 3 more dice: X to quit");
                try
                {
                    string InputtedValue = Console.ReadLine();
                    if (InputtedValue == "x" || InputtedValue == "X") 
                    {
                        Val = false;
                    }
                }
                catch (Exception ex) 
                {}
                
            }
        }

    }
}
