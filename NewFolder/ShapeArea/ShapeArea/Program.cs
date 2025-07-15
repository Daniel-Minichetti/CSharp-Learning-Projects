using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace ShapeArea
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // variables 
            string shapeChoice = "";
            bool isValid = false;

            // title card 
            // function: WriteLine
            Console.WriteLine("Welcome to the Rectangle & Circle Area Calculator!");
            Console.WriteLine("==================================================\n");

            // get user input 
            // we want to prompt the user if they want to find the area of a rectangle or circle (r or c) 
            // functions: WriteLine, ReadLine 
            Console.WriteLine("What shape would you like to find the area of?");
            Console.WriteLine("Enter 'r' for rectangle or 'c' for circle (press 'q' to quit)\n");

            shapeChoice = Console.ReadLine();
            
            // *IMPORTANT* without this uppercase letters would return invalid, we want 
            // the user to be free to use either. 
                // functions: Tolower()
            shapeChoice = shapeChoice.ToLower();

            // validate user input 
            while (!isValid) 
            {
                if (shapeChoice == "r")
                {
                    isValid = true;
                    RectangleArea();

                }
                else if (shapeChoice == "c")
                {
                    isValid = true;
                    CircleArea();
                }
                else if (shapeChoice == "q")
                {
                    isValid = true;
                    Console.WriteLine("Goodbye");
                    Environment.Exit(0);
                }
                else
                {
                    isValid = false;
                    Console.WriteLine("Invalid Input, Please try again");
                    shapeChoice = Console.ReadLine();

                }
            }
            if (shapeChoice == "q")
            {
                return;
            }
        } 

        // functions 
            // here I'll create some local functions to calculate the area of a rectangle or circle 

        public static float CircleArea()
        {
            // variables for circle area calculations 
            float area, radius;
            //float pi = 3.14f;

            // prompt user for radius 
            // function: WriteLine, Parse, ReadLine
            Console.WriteLine("Please enter the radius.");
            radius = float.Parse(Console.ReadLine());

            // logic for calculating the area of the circle
            area = (float)Math.PI * (radius * radius);

            // print output
            Console.WriteLine("======================================");
            Console.WriteLine($"| The area of the circle is {area} |");
            Console.WriteLine("======================================");

            // return area once calculated
            return area;

        }

        public static float RectangleArea()
        {
            // declare variables for rectangle
            float area,length,width;

            // prompt user for width 
            // function: WriteLine, Parse, ReadLine
            Console.WriteLine("Please enter the width.");
            width = float.Parse(Console.ReadLine());

            // prompt the user for length 
            // functions: Parse, ReadLine 
            Console.WriteLine("Please enter the length.");
            length = float.Parse(Console.ReadLine());

            // calculations for area of rectangle
            area = width * length;

            Console.WriteLine($"The area of the rectangle is {area}");

            // return statement
            return area;
        }



    }
}
