using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    class Program
    {
        public static void Main(string[] args)
        {
            //variables
            int maxRange, minRange;
            /*Asking the user to enter a min and max 
             * for the range 
             */
            Console.WriteLine("Welcome to The Guessing Game! \nYou have a total of 5 guess to " +
                "guess the computer generated number. Best of luck!");
            Console.Write("\nPlease enter a minimum value for the range: ");
            minRange = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter a maximum value for the range: ");
            maxRange = Convert.ToInt32(Console.ReadLine());
            GuessGame game = new GuessGame(maxRange, minRange); //instantiate class
            //call methods
            game.PlayGame();
            game.PlayAgain();
            Console.ReadKey();
        }
    }
}
