using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrays_in_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Demonstrating how to make an array in C#
            // First specify the type of data the array will hold, that we're making an array instead of a variable with [], give it a name, and then initialize
            int[] luckyNumbers = { 3, 13, 24, 37, 52};

            // How to access an index of an array in C#, in this case the third index or 37
            Console.WriteLine(luckyNumbers[3]);


            Console.ReadLine();
        }
    }
}
