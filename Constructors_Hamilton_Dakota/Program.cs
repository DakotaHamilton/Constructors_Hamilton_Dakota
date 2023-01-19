using System;

namespace Constructors_Hamilton_Dakota
{
    class Program
    {
        static void Main(string[] args) // Main Method
        {
            Game myGame = new Game("Fortnite", "T for Teen"); // Class Variables

            Console.WriteLine($"My favorite game is {myGame.title} and it is rated {myGame.genre}!"); // Writes to the Console the Message with the Variable Values

            Game myOtherGame = new Game(); // Default Class 

            Console.WriteLine($"My favorite game is {myOtherGame.title} and it is rated {myOtherGame.genre}!"); // Writes to the Console the Default Class
        }
    }
}
