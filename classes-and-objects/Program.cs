using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_and_objects
{
    internal class Program
    {
        static void Main(string[] args)
        { // Classes/objects can be used to represent things that are more complex than a single data type. They are like a complex data type we can create. Too create a class, right click our project in the solution explorer > Add > new item > class (name it with a capital letter, generally)

            // Here we can create a representation of a book using the Book class which defines the data type of "Book". An object is an instance of a class, and we can use objects to create a book in our main program.

            // Creating a book object, or an instance of the class Book. This is like a variable that is storing a book object.
            Book book1 = new Book("Miss");
            // Initializing the properties of the book as defined in the class
            book1.title = "The witch in the woods";
            book1.author = "Meta";
            book1.pages = 1337;

            Book book2 = new Book("Mister");
            book2.title = "The bubbly cauldron";
            book2.author = "Jack Pickleson";
            book2.pages = 69;


            // Accessing and printing the book's title
            Console.WriteLine(book1.title);



            Console.ReadLine();
        }
    }
}
