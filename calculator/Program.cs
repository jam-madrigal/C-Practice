using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // Demonstrating how to convert a string to a number, there are many Convert methods
            int num = Convert.ToInt32("24");
            // Of course, we can only add numbers together, strings would just concatenate so this conversion makes this operation possible: 
            Console.WriteLine(num + 6);

            // Wait for a user to enter two numbers and store them in a variable. It will return an error if we use Console.ReadLine() alone because it will try to store a string as a number
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            // Return the sum on a new line
            Console.WriteLine(num1 + num2);


            Console.ReadLine();
        }
    }
}
