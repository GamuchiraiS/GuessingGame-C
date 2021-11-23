using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2
{
    //interface
    interface IGuessGame
    {
        void PlayGame();
        void PlayAgain();
    }
    public class GuessGame: IGuessGame
    {
        //fields
        public int userGuess, score, guessCounter, guessLimit, ranNum;
        public int   minRange, maxRange;
        public bool play;
        public string option;
        Random rand = new Random(); //instantiate Random clas
        //constructor
        public GuessGame(int maxR, int minR)
        {
            maxRange = maxR;
            minRange = minR;
            userGuess = 0;
            score = 0;
            guessCounter = 0;
            guessLimit = 5;
            option = "";
            play = true;
        } 
        //method for playing the game
        public void PlayGame()
        {
            while (play)
            {
                //generate random number 
                ranNum = rand.Next(minRange, maxRange);
                /*for loop to control the amount
                 * of tries the user has 
                 */
                for (int i = 0; i < 5; i++)
                {
                    //let user take a guess
                    Console.Write("Please guess a number: ");
                    //store user guess in userGuess variable
                    userGuess = Convert.ToInt32(Console.ReadLine());
                    /* If the user's guess is higher than the random number
                        * tell the user than their guess is too high
                        * Else, tell them that their guess is too low
                        * Else if, userGuess == ranNum, inform 
                        * the user that their guess was correct
                        */
                    if (userGuess == ranNum)
                    {
                        /*if the user gets the answer correct
                        * increment their score
                        */
                        score++;
                        Console.WriteLine("\nCongratulations, that is the correct answer!");
                        Console.WriteLine("The random number was {0}", ranNum);
                        Console.WriteLine("Your score is = {0}", score);
                        break;
                    }
                    else if (userGuess < ranNum)
                    {
                        Console.WriteLine("Too low!");
                    }
                    else if (userGuess > ranNum)
                    {
                        Console.WriteLine("Too high!");
                    }
                    guessLimit--;
                    guessCounter++;
                    
                }
                if (guessLimit == 0)
                {
                    Console.WriteLine("\nYou have no more tries.");
                    Console.WriteLine("The random number was {0}", ranNum);
                    Console.WriteLine("Your score = {0}", score);
                }
                break;
            }
        }
        public void PlayAgain()
        {
            //ask user if they would like to play again
            if (guessLimit == 0 || userGuess == ranNum)
            {
                Console.Write("\nDo you wish to play again? Y/N ");
                option = Console.ReadLine();
                /*If the user wants to play again
                 * call the main method and playGame method
                 */
                if (option == "Y" || option == "y")
                {
                    Program.Main(null);
                    PlayGame();
                }
                /* Else, see you later bruv.
                 * 
                 */
                else
                {
                    Console.WriteLine("See you next time :)");
                }
            }
        }
    }
}
