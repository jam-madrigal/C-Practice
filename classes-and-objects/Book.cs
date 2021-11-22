using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_and_objects
{
    internal class Book
    {
        // We will create variables that reprsent all the attributes of a book. These are called class attributes.
        public string name;
        public string title;
        public string author;
        public int pages;

        // Let's create book instances another way, with constructors
        // A method like this is a constructor, the method public Book()
        // We can give the constructor the parameters to give the book properties and data just like we did above. Now we can pass in a parameter in our new Book() method

        // The a in the parameters/arguments stands for argument, so argumentName etc.
        public Book(string aName, string aTitle, string aAuthor, int aPages)
        {
            name = aName;
            title = aTitle;
            author = aAuthor;
            pages = aPages;

            // Every time a book is created, this code will be ran. Try running the main program to see it print for as many books are created above. When we call new Book() in the main program we're actually calling the constructor method. It is directly linked to this method.
            Console.WriteLine(name);
        }

        // We can still have another constructor with no parameters, so we can still create it without having to pass in any right away
        public Book()
        {

        }

        // Let's make a method we can use in our Book class. Let's return a method that tells us if a book is longer than 100 pages and can be classified as a long read.

        // Return true if the book is longer than 100 pages, false if not. Notice how we do not need to specify the parameters or the .pages attribute beyond calling it pages, as this is a Book method, it already knows it will be used for this class.
        public bool LongRead()
        {
            // Access the pages attribute and return true if it is greater than or equal to 100, and false if lower than 100
            if (pages >= 100)
            {
                return true;
            }
            return false;
        }
    }
}
