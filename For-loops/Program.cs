using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace For_loops
{
    internal class Program
    {
        static void Main(string[] args)
        { // For loops follow this convention. This loop will increment i by one, stating with int i = 0, and will loop for as long as i is less than 5. First we have our initalized variable, the condition under which it will run, and a line of code executed after every iteration of the loop, in this case i++.

            // Loop through an array and print the current index of the array
            int[] luckyNumbers = { 3, 6, 9, 13, 24, 37 };

            for (int i = 0; i < luckyNumbers.Length; i++)
            {
                Console.WriteLine(luckyNumbers[i]);
            }


            Console.ReadLine();
        }
    }
}
