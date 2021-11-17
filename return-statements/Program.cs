using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace return_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Calling our cube function
            // Calling the method alone
            Console.WriteLine(cube(3));

            Console.ReadLine();
        }
        // Creating another method that cubes a number, and returns the number, the second part of declaring this is the return type, this time instead of "void" we will specify a data type we are going to return, and the method will take in an integer as the variable "num"
        static int cube(int num)
        {
            // Storing the num variable cubed in an integer variable called result
            int result = num * num * num;
            // Returning the stored result and breaking us out of the method
            return result;
        }
        
    }
}
