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

            // An array of strings, and populating it differently, the number inside the initialization specifies how many elements we want to fit into the array eventually
            string[] magicalTraits = new string[4];
            // Populating the array
            magicalTraits[0] = "Sorcery";
            magicalTraits[1] = "Pointy hat";
            magicalTraits[2] = "Musty tome";
            magicalTraits[3] = "Crooked staff";

            // Accessing one of the indexes of the array of strings
            Console.WriteLine(magicalTraits[2]);

            // How to access an index of an array in C#, in this case the third index or 37
            Console.WriteLine(luckyNumbers[3]);

            // How to change the value of an index, changing 52 to 14 here
            Console.WriteLine(luckyNumbers[4]);
            luckyNumbers[4] = 14;
            Console.WriteLine(luckyNumbers[4]);


            Console.ReadLine();
        }
    }
}
