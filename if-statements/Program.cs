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
            if (isMagical && isWitch)
            {
                Console.WriteLine("You are a magical witch");
            } else
            {
                Console.WriteLine("You are not a magical witch, or at least not magical or a witch. One of the two, at least.");
            }

            Console.ReadLine();
        }
    }
}
