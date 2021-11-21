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
        public string title;
        public string author;
        public int pages;

        // Let's create book instances another way, with constructors
        // A method like this is a constructor, the method public Book()
        // We can give the constructor the parameters to give the book properties and data just like we did above. Now we can pass in a parameter in our new Book() method
        public Book(string name)
        {
            // Every time a book is created, this code will be ran. Try running the main program to see it print for as many books are created above. When we call new Book() in the main program we're actually calling the constructor method. It is directly linked to this method.
            Console.WriteLine(name);
        }
    }
}
