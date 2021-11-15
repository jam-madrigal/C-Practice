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
            // Create a method to say hi to the user and call it, this has to be done outside of the static void Main() method. If the method requires a parameter, it will return an error if no paremeters are passed through.
            SayHi("Meta", 28);
            Console.ReadLine();
        }

        // Where we create new methods
        // Use the keyword static (explanation to come later), then specify the "return type", this will be void which basically means this method will not return any information, a simpler kind of method, then we name the method. In C#, we generally use capital letters for the names.

        // For parameters, we specify the type of data and the name of the parameter, consecutive parameters are separated by commas
        static void SayHi(string name, int age)
        {
            // All the code for the method iinside the curly braces, of course
            Console.WriteLine("Hello " + name);
            Console.WriteLine("You are " + age + " years old");


        }
    }
}
