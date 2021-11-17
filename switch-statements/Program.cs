using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_statements
{
    internal class Program
    {
        static void Main(string[] args)
        { // Create a switch statement that returns the day of the week corresponding to the user input number

            Console.ReadLine();
        }

        static string GetDay(int dayNum)
        {
            // Check if the number is less than 0 or greater than 7, and if so return an error
            if (dayNum < 0 || dayNum > 7)
            {
                Console.WriteLine("Invalid day number");
            }

        }
    }
}
