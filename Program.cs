using System;


namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Dice die = new Dice(20);
            for (int i = 0; i < 100; i++)
            {

            Console.WriteLine(die.rollDie());
            }
           


            Console.ReadLine();
            
        }

    }
}
