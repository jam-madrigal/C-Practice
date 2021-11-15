using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mad_lib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Making a mad lib sotry pulling variable values from user input, similar to what we did with the simple calculator exercise

            // Declaring the variables to be used in the story
            string name, job, monster, place;

            // Prompting the user and then using their input to initialize the variable with a value
            Console.Write("Enter a name: ");
            name = Console.ReadLine();

            Console.Write("Enter a job for {name}: ");
            job = Console.ReadLine();

            Console.Write("Enter a monster: ");
            monster = Console.ReadLine();

            Console.Write("Enter a place: ");
            place = Console.ReadLine();

            // Using the story with variables
            Console.WriteLine("There once was a " + job + " named " + name + ".");
            Console.WriteLine(name + " was quite the powerful " + job + ".");
            Console.WriteLine("Once, a "  + monster + " came to attack the village, but feared " + name + " and fled to " + place + ".");
            Console.WriteLine(name + " just wanted to be friends with the " + monster + " and was quite saddened.");

            Console.ReadLine();



        }
    }
}
