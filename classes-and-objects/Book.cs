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
        // Let's make the demographic attribute private. Only code inside of the Book class will be able to access it.
        private string demographic;

        // We can use static attributes to define attributes which are intrinsic to the Book class itself, and are not unique to each individual book object. Let's make one to count how many books have been created. We could access this with Book.bookCount, static attributes belong to the class itself
        
        public static int bookCount = 0;

        // Static methods can also be created, and they are methods that exist within the class itself just like the static attributes. As such, we can call it without creating an instance of the class. 
        // A simple static method that returns my favorite book
        public static void favoriteBook()
        {
            Console.WriteLine("The witch in the woods by Meta");
        }

        // Let's create book instances another way, with constructors
        // A method like this is a constructor, the method public Book()
        // We can give the constructor the parameters to give the book properties and data just like we did above. Now we can pass in a parameter in our new Book() method

        // The a in the parameters/arguments stands for argument, so argumentName etc.
        public Book(string aName, string aTitle, string aAuthor, int aPages, string aDemographic)
        {
            name = aName;
            title = aTitle;
            author = aAuthor;
            pages = aPages;
            // To make this private attribute more secure capitalize it so it is set through our setter in our Demographic method
            Demographic = aDemographic;

            // Every time a book is created with this constructor, increment the bookCount static attribute by 1
            bookCount++;

            // Every time a book is created, this code will be ran. Try running the main program to see it print the following name attribute for as many books are created above. When we call new Book() in the main program we're actually calling this constructor method, and this illustrates that by running the code at the end of the constructor method.
            Console.WriteLine(name);
        }

        // We can still have another constructor with no parameters, so we can still create it without having to pass in any right away
        public Book()
        {
            // Making sure we still incresae the book count when a book is created with no arguments
            bookCount++;
        }

        // Let's make a method we can use in our Book class. Let's return a method that tells us if a book is longer than 100 pages and can be classified as a long read.

        // Return true if the book is longer than 100 pages, false if not. Notice how we do not need to specify the parameters or the .pages attribute beyond calling it pages, as this is a Book method, it already knows it will be used for an object within this class. For example, by doing book1.LongRead(); it will use all of the information in the book1 object. book1.pages, etc.
        public bool LongRead()
        {
            // Access the pages attribute and return true if it is greater than or equal to 100, and false if lower than 100
            if (pages >= 100)
            {
                return true;
            }
            return false;
        }

        // Getters and setters can be used to control access to the attributes in our classes. They can be used to make them more secure, for example. Let's say our books will be sorted only into 4 categories for their demographics: Kids, Young Adult, Adult, and All Ages. We can use getters and setters to enforce that this attribute is only one of these by closing off access to the demographic attribute.
        // Making a property, which is a specil kind of method for defining getters and setters. We can use these to define rules for how certain attributes are set. This way, there won't be an invalid demographic value.

        // You can also make a getter method to get a static attribute using an individual object. For example, now we can call book1.getBookCount(); if needed.
        public int getBookCount()
        {
            return Book.bookCount;
        }
        public string Demographic
        {
            // How to get the demographic attribute when it is private
            get { return demographic; }
            // Only allow the demographic value to be one of these four, then if it is, set it equal to the one passed through our method. If something else is tried to be set as the demographic value, set the value to unknown.
            set {
                if (value == "Adult" || value == "Young Adult" || value == "Kids" || value == "All Ages")
                {
                    demographic = value;
                } else
                {
                    demographic = "Unknown";
                }
            }
        }
    }
}
