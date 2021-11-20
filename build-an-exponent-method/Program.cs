using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace build_an_exponent_method
{
    internal class Program
    {
        static void Main(string[] args)
        { // Build a method which will take in two numbers: A base number and a power number, and take the base number to the power of the power number
            Console.WriteLine(Exponential(4, 3));
            Console.ReadLine();
        }
        // Create a function that returns an integer and takes in two integers, base and power  as parameters
        static int Exponential(int baseNum, int powNum) 
        {
            // Create a loop that multiplies baseNum by itself, stores that in a variable, then multiplies itself by baseNum and re-initializes itself with the resulting value, for as long as a variable i is not equal to powNum, increasing powNum by one each iteration

            // Create the variable to store the number exponentially created
            int baseSquared = baseNum * baseNum;
            // We start with i equal to 3, so our baseSquared value is not multiplied by itself a few extra times as it approaches the specified exponent. We know it will always start approaching powNum >= 3, because if the powNum is 0, 1, or 2, it will always have a value of 1, itself, or itself multiplied by itself.
            for (int i = 3; i <= powNum; i++)
            {
                // Checks for if the powNum is 0, 1, or 2, and does not require additional operations
                if (powNum == 0)
                {
                   baseSquared = 1;
                }
                if (powNum == 1)
                {
                   baseSquared = baseNum;
                } 
                if (powNum == 2)
                {
                    baseSquared = baseNum * baseNum;
                }
                // If the powNum is equal to or higher than 3, then we know we need to multiply the baseNum to the power of 2 by the baseNum as many times as it takes to equal the specified exponent powNum
                else
                {
                    baseSquared = baseSquared * baseNum;
                }
            }
            // Return the baseSquared value after it is multiplied as many times as powNum specifies
            return baseSquared;
        }

    }
}
