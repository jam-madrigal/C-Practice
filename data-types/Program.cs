using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// This project explains the basic and most common data types. There are more advanced and specific/obscure ones, however
namespace data_types
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            // Declaring and initializing string
            string phrase = "Spooky stuff.";
            // Declaring a single character, no more than one, not the single quotation marks instead of "
            char grade = 'A';
            // An integer, aka no decimals, can also be negative no problem
            int age = 28;
            // Decimal numbers are stored in 1 of 3 data types: float, double, or decimal. These get progressively more specific and accurate, in that order. Use decimal if you want to be really precise, for example. Like for money, or anything that has to be extremely exact. For now, we'll be focusing on double in initial C# practice, something of a middle-ground
            double gpa = 3.4;
            // True or false statements are just as we knew 'em from JavaScript, booleans, declared as such
            bool isMagical = true;

            Console.ReadLine();
        }
    }
}
