using System;
using System.Collections.Generic;
using System.Text;

namespace Constructors_Hamilton_Dakota
{
    class Game
    {
        public string title, genre; // String Fields

        public Game(string titleparam = "Unknown Title", string genreParam = "Casual") // Class Constructor
        {
            title = titleparam; // String Param 1
            genre = genreParam; // String Param 2
        }
    }
}
