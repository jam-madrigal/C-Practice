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

            // This can be restructured into a different kind of while loop as well, known as a do while loop. Let's say the index value is never less than or equal to 5, so in the above circumstance, our code in the loop would never run. However, we can run it like so. It will run t he code before it checks the condition. In this example it will at least print the index once, so we are aware of what is happening when it immediately stops.
            int index2 = 6;

            do
            {
                Console.WriteLine("The current index is " + index);
                index++;
            } while (index2 <= 5);


            Console.ReadLine();
        }
    }
}
