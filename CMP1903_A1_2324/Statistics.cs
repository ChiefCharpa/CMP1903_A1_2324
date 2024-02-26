using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace CMP1903_A1_2324
{
    internal class Statistics
    {
       


        public void Mean(int[] DiceRollArray)
        {
            Array.Sort(DiceRollArray);
            int Total = 0;
            int Count = 0;
            foreach(int DiceRoll in DiceRollArray) 
            {
                Total += DiceRoll;
                Count++;
            }
            float Mean = Total / Count;
            Console.WriteLine($"The average mean of the dice is: {Mean}");
            int midpoint = Count / 2;
            int median = DiceRollArray[midpoint];
            Console.WriteLine($"The median of the dice is: {median}");
        }

        public int Mode(int [] DiceRollArray)
        {
            Array.Sort(DiceRollArray);
            int mode = 0;
            int Most = 0;
            foreach (int j in DiceRollArray) 
            {
                int current = j;
                int count = 0;
                foreach (int i in DiceRollArray)
                {
                    if (i == j)
                    {
                        count = count + 1;
                        if (count > Most)
                        {
                            mode = current;
                            Most = count;
                        }
                    }
                }
            }
            return mode;
        }

    }
}
