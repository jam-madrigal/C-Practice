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

    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}