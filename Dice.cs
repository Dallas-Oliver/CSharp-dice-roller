using System;
using System.Collections.Generic;
using System.Text;

namespace DiceRoller
{
    public class Dice
    {
        public int sidesValue;
        public int[] possibleSides = { 4, 6, 8, 10, 12, 20 };
        
        public Dice(int number)
        {
            sidesValue = number;

        }

        public int rollDie()
        {
            Random random = new Random();
            return random.Next(1, sidesValue);
        }




    }
}
