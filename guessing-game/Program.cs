using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guessing_game
{
    internal class Program
    {
        static void Main(string[] args)
        { // Create a guessing game
            // A word will be stored in a variable
            string secretWord = "witch";
            // Declare a variable to store the user's guess. C# will not let us use it undeclared in a while loop so let's just leave it an empty string.
            string userGuess = "";

            // Use a loop to check if the user guessed the word guess the word. If they guess incorrectly, loop the question until they guess correctly, then return a message stating they won the game and break out of the loop

            // Let's make it more challenging by only allowing the user to guess 3 times. My solution for doing that is creating a variable that is incremented during the while loop after the user guesses. If it increments to 3, we return a message saying they lost.
            int lossCounter = 0;

            while (userGuess != secretWord)
            {

                Console.Write("Guess the secret word: ");
                // Storing the user input and setting it to lower case so the guess is not case sensitive
                userGuess = Console.ReadLine().ToLower();
                lossCounter++;

                // If the user has guessed 3 times already, display a loss message, and return out of the program
                if (lossCounter == 3)
                {
                    Console.WriteLine("Sorry, you lose.");
                    Console.ReadLine();
                    return;
                }
            }

            Console.WriteLine("You guessed the secret word!");

            Console.ReadLine();

        }
    }
}
