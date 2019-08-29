using System;
using System.Linq;


namespace DiceRoller
{
    class Program
    {
        static void Main(string[] args)
        { 
            numberOfDiceRolled(8, 1);
  
            Console.ReadLine();
            
        }

        static void numberOfDiceRolled(int sidesValue, int number)
        {
            Dice die = new Dice(sidesValue);

            Console.WriteLine(die.rollDie() + rollModifier(2)); 
        }
    

        static int rollModifier(int modifierValue)
        {
            return modifierValue;
        }

    }
}
