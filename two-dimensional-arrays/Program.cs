using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace two_dimensional_arrays
{
    internal class Program
    {
        static void Main(string[] args)
        { // A two-dimensional array is an array, where every element within it is an array. It's like making an array as normal, but with a comma inside the data type.
            int[,] numberGrid = { 
                { 1, 2, 3 }, 
                { 4, 5, 6 }, 
                { 6, 7, 8 } 
            };

            // Access the second index of the second array and return the value of 5. The first number after numberGrid in brackets is the index in the overarching array, and the second is the index within that index element
            Console.WriteLine(numberGrid[1, 1]);

            // Make an array without any data in it, specifying the number of indexes and indexes within the inner arrays. It can be thought of as rows and columns based on the code appearance of the numbersGrid above
            int[,] numberGrid2 = new int[2, 3];

            Console.ReadLine();
        }
    }
}
