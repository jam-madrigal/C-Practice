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

            // Create our condition, and the code that will run if it is met, if it is false, it will not run. Business as usual.
            if (isMagical)
            {
                Console.WriteLine("You are magical");
            } else
            {
                Console.WriteLine("You are not magical");
            }

            Console.ReadLine();
        }
    }
}
