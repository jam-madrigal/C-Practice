using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace while_loops
{
    internal class Program
    {
        static void Main(string[] args)
        { // Finally getting more into the meat of it with some loops.. One of the most powerful tools in code. The code will continue to loop while a condition is true.

            // First let's make a variable to hold an index for our loops
            int index = 1;

            // Making our while loop with the condition in parentheses
            while (index <= 5)
            {
                // Making a loop that states the current index and increments it up by one after each execution
                Console.WriteLine("The current index is " + index);
                index++;
            }


            Console.ReadLine();
        }
    }
}
