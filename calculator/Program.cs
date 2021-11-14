using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // Demonstrating how to convert a string to a number, there are many Convert methods
            int num = Convert.ToInt32("24");
            // Of course, we can only add numbers together, strings would just concatenate so this conversion makes this operation possible: 
            Console.WriteLine(num + 6);



            Console.ReadLine();
        }
    }
}
