using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace better_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        { // Create a calculator which prompts the user for two numbers and what kind of comparison or operation they want to do
            // Prompt the user to enter two numbers and store those numbers in a variable. Remember to convert the response from a string to an integer.

            // Of course, this can be improved with checks to verify the user actually enters a number or string when needed, otherwise there will just be an error if they do not enter a valid data type
            Console.Write("Enter a number: ");
            double num1 = Convert.ToDouble(Console.ReadLine());

            // Prompt the user for an operator and store it in a variable
            Console.Write("Enter Operator: ");
            string op = Console.ReadLine();

            // Prompt the user for the second number
            Console.Write("Enter a number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Use if statements to return a result as specified by the user
            if (op == "+")
            {
                Console.Write(num1 + num2);
            } 
            else if (op == "-")
            {
                Console.Write(num1 - num2);
            } 
            else if (op == "*")
            {
                Console.Write(num1 * num2);
            } 
            else if (op == "/")
            {
                Console.Write(num1 / num2);
            }
            else
            {
                Console.WriteLine("Invalid operator.");
            }


            Console.ReadLine();
        }
    }
}
