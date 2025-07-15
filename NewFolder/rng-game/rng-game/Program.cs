using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rng_game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // initialize variables
            int tries = 3;
            int guess = 0;
            int secretVal = 0;

            bool isCorrectGuess = false;

            // generate random number to be used in 
            Random ranNum = new Random();

            // print title card and rules of the game 
            // function: WriteLine
            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("------------------------------------\n");

            Console.WriteLine("A number between 1 & 10 will be generated");
            Console.WriteLine("If you guess correctly you win, but you only have 3 tries!");
            Console.WriteLine("----------------------------------------------------------\n");

            secretVal = ranNum.Next(1, 11);
            Console.WriteLine(secretVal);

            // Console.WriteLine(numGuess) debug statement 

            // write conditional to check if answer is valid and correct or not
            while (!isCorrectGuess && tries > 0)
            {
                Console.WriteLine($"Please Enter your guess\n Number of tries remaining:{tries}");
                guess = Convert.ToInt32(Console.ReadLine());

                if (guess > secretVal)
                {
                    tries--;
                    Console.WriteLine($"Number is too high! {tries} tries remaining.");
                }
                else if (guess < secretVal)
                {
                    tries--;
                    Console.WriteLine($"Number to low! {tries} tries remaining.");
                }
                else
                {
                    Console.WriteLine($"You picked the right number with {tries} tries remaining! You Win!");
                    isCorrectGuess = true;
                }


            }

            if (tries < 1)
            {
                Console.WriteLine("Sorry you ran out of guesses.");
            }

            Console.ReadKey();

        }
    }
}
