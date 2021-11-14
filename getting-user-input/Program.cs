using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace getting_user_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Console.Write(); will print on the same line, instead of a new one like Console.WriteLine();, and this will let the user make sense of where their input is going in this case
            Console.Write("Enter your name: ");
            // Store the line of text the user enters in a variable
            string name = Console.ReadLine();
            // Ask for their class/profession, and store that in a variable as well
            Console.Write("Enter your class/profession: ");
            string userClass = Console.ReadLine(); 

            // Write a greeting to the user based on the input and display it in the console
            Console.Write("Hello " + name + " the " + userClass + ".");

            // We can use Console.ReadLine(); to get user input
            Console.ReadLine();
        }
    }
}
