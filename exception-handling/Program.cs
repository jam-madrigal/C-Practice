using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exception_handling
{
    internal class Program
    {
        static void Main(string[] args)
        { // An exception basically tells you that your code had something C# couldn't handle. This usually leads to crashes, an exception is thrown, and the program will terminate. You wouldn't want an exception to crash after an exception gets thrown if the code is something that is supposed to run for a very long time, like months, so there are ways to keep the program running in that situation.

            // This program simply takes in two numbers and divides them, then prints out the result in the console. We can cause exceptions in this program by dividing by 0. We can also break it by typing a character that is not a number.

            // We can use exception handlers with try catch blocks to move on through these exceptions if they occur. We put any code we think can break the program in the try block, and if that code does break the program, it will execute what is in the catch block instead of terminating.
            try
            {
                // Try running this code inside and outside of the try block and breaking it in both situations
                Console.Write("Enter a number: ");
                int num1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Enter a second number: ");
                int num2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(num1 / num2);
            }
            /* catch
            {
                // If the program breaks... return this message and continue
                Console.WriteLine("Error");

            } */

            // We can also do a catch like this, take in an exception parameter as variable e, and this will give us more information, if we return e.Message, about the specific error. If instead of using an Exception parameter, we use specifically a DivideByZeroException, it will only catch those exceptions. ie catch {DivideByZeroException e} It will not catch things like a FormatException, like inputting a letter instead of a number, but we can make further catch blocks after this one to do this. In this way, we can return a different message depending on the type of exception that is being handled. It is often a better way to do it this way, so the user can have more specific feedback or be prompted again to use a correct input.
            catch (Exception e)
            {
                // If the program breaks... return an error message
                Console.WriteLine(e.Message);

            }
            // Any code we put in this finally block is executed no matter what. Even if there is an exception, this will run. It is not always necessary.
            finally
            {

            }

            Console.ReadLine();
        }
    }
}
