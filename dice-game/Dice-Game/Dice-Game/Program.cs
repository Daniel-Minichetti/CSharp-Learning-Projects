using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Serialization;


namespace Dice_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int randomNum;
            int enemyRandomNum;

            Random val = new Random();

            int playerPoints = 0;
            int enemyPoints = 0;
          

            for (int i = 0; i < 10; i++) 
            {
                // Print title card 
                // functions: WriteLine 
                Console.WriteLine("\nWelcome to the dice game! Press any key to roll the dice");
                
                Console.ReadKey();
                
                // generates a random between 1 & 6
                randomNum = val.Next(1, 7);
                Console.WriteLine($"You rolled a {randomNum}");
                playerPoints += randomNum;
                Console.WriteLine($"Current player total is {playerPoints}.");

                // adds tension by waiting 1000ms or 1 second for the enemy AI to display 
                Console.WriteLine("...");
                System.Threading.Thread.Sleep(1000);

                enemyRandomNum = val.Next(1, 7);
                Console.WriteLine($"Enemy AI rolled a {enemyRandomNum}");
                enemyPoints += enemyRandomNum;
                Console.WriteLine($"Current enemy total is {enemyPoints}.");

            }
            Console.ReadKey();
            // write a conditional to declare victor between player and AI 
            if (playerPoints > enemyPoints)
            {
                Console.WriteLine($"player wins with {playerPoints} by {playerPoints - enemyPoints} points!");
            }
            else if (enemyPoints > playerPoints)
            {
                Console.WriteLine($"enemy AI wins with {enemyPoints} by {enemyPoints - playerPoints} points!");
            }
            else
            {
                Console.WriteLine($"Both player and AI tied with {playerPoints} & {enemyPoints} respectively.");
            }

        }
    }
}
