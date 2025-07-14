using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // int variables used to collect user input
            int firstNumber;
            int secondNumber;
            int numAnswer = 0;

            string answer;

            // Print title 
                // functions: WriteLine, Readkey
            Console.WriteLine("Welcome to the Calculator.");
            Console.WriteLine("Please enter your first number.");

            // collect user input for first number 
                // since ReadLine only takes characters, we must cast 
                // firstNumber back into an int 
                    // functions: ToInt32, ReadLine
            firstNumber = Convert.ToInt32(Console.ReadLine());

            // prompt user for their second number and cast back to int
            // functions: ToInt32, ReadLine, WriteLine
            Console.WriteLine("Please enter your second number.");
            secondNumber = Convert.ToInt32(Console.ReadLine());

            // get user input for what operation to perform (+, -, /, *)  

            Console.WriteLine("What type of operation would you like to do?");
            Console.WriteLine("Please enter + for addition, - for subtraction, * for multiplication, and / for division");


            answer = Console.ReadLine();
            if (answer == "+")
            {
                numAnswer = firstNumber + secondNumber;
            }
            else if (answer == "-")
            {
                numAnswer = firstNumber - secondNumber;
            }
            else if (answer == "*")
            {
                numAnswer = firstNumber * secondNumber;
            }
            else if (answer == "/")
            {
                numAnswer = firstNumber / secondNumber;
            }
            else
            {
                Console.WriteLine("Please try again and enter a valid operator.");
            }

            // display output of program 
            // Functions: WriteLine 
            Console.WriteLine($"The answer of your problem is {numAnswer}");

            Console.ReadKey();
            
        }
    }
}
