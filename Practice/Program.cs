using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// The namespace basically specifies the project that we're using. We are in the "Practice" project. More on what it's really doing later.
namespace Practice
{
    // The "internal keyword" here is an access modifier. In this case, it means access is limited to the current assembly. Assemblies are basically the "types and resources"; the compiled code; that make up the .exe and .dll files that make up a .NET application. An assembly can be built from multiple source code files in .NET or .NET framework. Having an internal access modifier here will be useful in allowing groups of components to cooperate privately, as they will not be exposed to the rest of the application code. You can imagine how not having this could create unintended errors or just make a mess of things in some cases. If you were to try to instantiate the internal class Program from this file in another file, it would produce an error. Changing it to "public" can make it accessible.

    // In most cases, according to a user on stackoverflow, an assembly corresponds and is equal to one file on the disk. "In a multifile assembly there would still be only one assembly manifest in a DLL or EXE and the MSIL code in multiple netmodule files." I will take this part with a grain of salt for now.

    // A class is essentially a container in which we can store code. Inside of a class, we can write all the code for our program and be able to execute it. More to come about that later as well.
    internal class Program
    {
        // This is the main method or function, as we're used to. Another container in which we can put code for our program to run.
        static void Main(string[] args)
        {
            // Code can go here, for the line 17 comment. Any code we're going to write inside of our .cs (C#) file we want to put here, inside this main block

            // Note about strings: single quotes can only encapsulate a single character. Double quotes are for multiple, in C#. In this case, use the unicode character for a quotation mark and concatenate.
            Console.WriteLine("Hello I am a powerful mage. " +'\u0022' + "Hello world" + '\u0022' + " is boring and expected.");

            // Making a shape with Console.WriteLine(); I wanna say it's a witch hat.
            Console.WriteLine("       /|");
            Console.WriteLine("      / |");
            Console.WriteLine("     /  |");
            Console.WriteLine("    /   |");
            Console.WriteLine("___/____|___");

            // If we run this code as is, the console window will open and immediately close. To remedy that, we need to add the following code which keeps the console window open until we press enter.
            Console.ReadLine();

        }
    }
}