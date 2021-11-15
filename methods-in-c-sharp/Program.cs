using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods_in_c_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create a method to say hi to the user and call it, this has to be done outside of the static void Main() method
            SayHi();
            Console.ReadLine();
        }

        // Where we create new methods
        // Use the keyword static (explanation to come later), then specify the "return type", this will be void which basically means this method will not return any information, a simpler kind of method, then we name the method. In C#, we generally use capital letters for the names.
        static void SayHi()
        {
            // All the code for the method iinside the curly braces, of course
            Console.WriteLine("Hello user");

        }
    }
}
