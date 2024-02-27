using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CMP1903_A1_2324
{
    internal class Statistics
    {
       
        /* Mean method which can take 2 parameters (1 array and one possible bool),
        * and process the given array to calculate and outputs the mean and median
        */

        public void Mean(int[] DiceRollArray,bool Testing = false)
        {
            // The function initially uses the sort function to arrange the values in acsending order
            Array.Sort(DiceRollArray);
            // The variables Total and Count are instantiated for later use
            int Total = 0;
            int Count = 0;
            // It then iterates for each value in the array passing each given value to the vaiable DiceRoll
            foreach(int DiceRoll in DiceRollArray) 
            {
                // Adds the given value to The Total variable
                Total += DiceRoll;
                // Adds 1 to count
                Count++;
            }
            // Calculates the mean by dividing the mean by the total
            float Mean = Total / Count;
            // Outputs the calculated mean in the console
            Console.WriteLine($"The average mean of the dice is: {Mean}");
            // Calculates the midpoint in the array and stores value in the variable midpoint 
            int midpoint = Count / 2;
            // Instantiates the variable median
            int median;
            // For if the midpoint is even or odd the middle most value is called
            if (Count % 2 != 0)
            {
                median = DiceRollArray[midpoint];
            }
            else 
            {
                median = DiceRollArray[midpoint - 1];
            }
            // Outputs the calculated median into the console window
            Console.WriteLine($"The median of the dice is: {median}");
            // if testing is true it validates to make sure that both mean and median are in an acceptable range
            if (Testing)
            {
                Debug.Assert(median > 0 && median < 7);
                Debug.Assert(Mean > 0 && Mean < 7);
            }
        }

        /* Mode method takes 2 parameters (1 an array and one a bool variable) 
         * and calculates the given mode for the array returning the mode from the method
         */
        public int Mode(int [] DiceRollArray, bool Testing = false)
        {
            // The method initially uses the sort function to arrange the values in acsending order
            Array.Sort(DiceRollArray);
            // Initiallises 2 variables mode and Most
            int mode = 0;
            int Most = 0;
            // Iterates through the array storing the current value as j
            foreach (int j in DiceRollArray)
            {
                // instantiatescount seting it to 0
                int count = 0;
                // iterates through the list storing the values as i
                foreach (int i in DiceRollArray)
                {
                    // for each instance i and j are the same, increment count
                    if (i == j)
                    {
                        count++;
                        // if count exceeds most mode is set to the current value of j and sets Most to count
                        if (count > Most)
                        {
                            mode = j;
                            Most = count;
                        }
                    }
                }
            }
            // if testing is set to true then it tests to ensure mode is in its acceptable range
            if (Testing)
            {
                Debug.Assert(mode > 0 && mode < 7);
            }
            // returns the value of mode 
            return mode;
            
        }

    }
}
