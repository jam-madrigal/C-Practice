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
            // Declare a variable to store the user's guess
            string userGuess = "";

            // Use a loop to check if the user guessed the word guess the word. If they guess incorrectly, loop the question until they guess correctly, then return a message stating they won the game and break out of the loop
            while (userGuess != secretWord)
            {

                Console.Write("Guess the secret word: ");
                // Storing the user input and setting it to lower case so the guess is not case sensitive
                userGuess = Console.ReadLine().ToLower();
            }

            Console.WriteLine("You guessed the secret word!");

            Console.ReadLine();

        }
    }
}
