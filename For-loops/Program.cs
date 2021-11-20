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
        { // For loops follow this convention. This loop will increment i by one, stating with int i = 0, and will loop for as long as i is less than 5.
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }


            Console.ReadLine();
        }
    }
}
