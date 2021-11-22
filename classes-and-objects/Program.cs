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
            /* Uncomment and use this example first, then comment it again for the constructors method of creating the same instances of Book

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
                Console.WriteLine(book1.title); */

            // Creating the same code as above, but cleaner, by using constructors
            Book book1 = new Book("Miss", "The witch in the woods", "Meta", 1337, "Young Adult");
            Book book2 = new Book("Mister", "The bubbly cauldron", "Jack Pickleson", 69, "Adult");
            // Proving that because we created a second constructor with no parameters, we can still make one, with no parameters, without any errors
            Book book3 = new Book();

            // Update any of the values simply by doing things like book2.title = "Humbug"
            // Test that the classes/objects, the instances of Book, were created correctly
            Console.WriteLine(book1.title + ", " + book2.title + ", " + book2);

            // Test our LongRead() method and see which book is long or short 
            Console.WriteLine(book1.LongRead());
            Console.WriteLine(book2.LongRead());

            // The demographic attribute is private, and therefore if we typed something like Console.WriteLine(book2.demographic); here we would have a build error.
            // Try to set an invalid attribute to test our security for the demographic. Notice we now have to use the capitalized version of the attribute, because outside of the class file itself, we must use our getter and setter methods, since it is private. This should return unknown, since we tried an invalid set.

            Console.WriteLine(book2.Demographic);
            book2.Demographic = "bingbong";
            Console.WriteLine(book2.Demographic);

            Console.ReadLine();
        }
    }
}
