using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class Dice
    {
        public int sides;
        
        public Dice(int number)
        {
            sides = number;

        }

        public int rollDie()
        {
            Random random = new Random();
            return random.Next(1, sides);
        }




    }
}
