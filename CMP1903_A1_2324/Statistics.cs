using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903_A1_2324
{
    internal class Statistics
    {
        private int[] DiceRollArray = { };

        public void AddDice(int DiceRolled)
        {
            DiceRollArray.Append(DiceRolled);
        }






        public void Mean(int i, int j)
        {
            float Mean = j / i;
            Console.WriteLine($"The average mean of the dice is: {Mean}");
        }

        public int Mode()
        {
            Array.Sort(DiceRollArray);
            foreach (int j in DiceRollArray) 
            {
                foreach (int i in DiceRollArray)
                {
                    if (i == j)
                    {
                        
                    }
                }
            }
            
        }

    }
}
