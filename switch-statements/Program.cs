using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_statements
{
    internal class Program
    {
        static void Main(string[] args)
        { // Create a switch statement that returns the day of the week corresponding to the user input number
          // Store the user input number in a variable to be passed through our GetDay() method
            Console.WriteLine("Enter a number to find out which day of the week to which it corresponds: ");
            int num = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(GetDay(num));
            Console.ReadLine();
        }

        static string GetDay(int dayNum)
        {
            // Declare the result we will eventually assign in our switch statement
            string dayName;
            // Check if the number is less than 0 or greater than 6, and if so return an error
            if (dayNum < 0 || dayNum > 6)
            {
                return ("Invalid number. Enter a number from 0-6.");
            }

            // If input is valid, use a switch statement to decide which day of the week to return using the dayNum as our input
            switch (dayNum)
            {
                case 0: 
                    dayName = "Sunday"; 
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;
            }

            return dayName;

        }
    }
}
