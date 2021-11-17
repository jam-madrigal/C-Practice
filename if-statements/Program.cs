using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Make a variable to check our if statement
            bool isMagical = true;
            // Add another variable to check 
            bool isWitch = true;

            // Create our condition, and the code that will run if it is met, if it is false, it will not run. Business as usual.
            // Check if they are magical and a witch
            if (isMagical && isWitch)
            {
                Console.WriteLine("You are a magical witch.");
            }
            // Check if they are magical, but not a witch, using a negation operator
            else if (isMagical && !isWitch) 
            {
                Console.WriteLine("You are magical, but not a witch.");
            } 
            else if (!isMagical && isWitch)
            {
                Console.WriteLine("You are a witch, but not magical. Fancy that.");
            }
            // What to return if they are neither magical or a witch
            else
            {
                Console.WriteLine("You are not magical or a magical witch.");
            }

            // Testing out GetMax() method
            Console.WriteLine(GetMax(13, 37));
            Console.ReadLine();
        }
        // Making another method that will compare numbers, its return type is an integer and it takes in two integers as parameters
        static int GetMax(int num1, int num2)
        {
            // Declaring an integer result that will be our output later
            int result;

            // Return the integer which is greater, using if statements to compare
            if (num1 > num2)
            {
                result = num1;
            } else
            {
                result = num2;
            }

            return result;
        }
    }
}
