using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ
{ 
    class Program
    {
        static void Main(string[] args)
        {
            var videoGames = new List<string> { "Sonic","Tetris", "Super Mario", "Super Smash Brothers" };

            var GameNameLength = videoGames.OrderByDescending(game=>game.Length);

            foreach( var game in GameNameLength)
            {
                Console.WriteLine(game);
            }

           /* var Length = from gameX in VideoGames
                         orderby gameX.Length ascending
                         select gameX;
            foreach (string game in VideoGames)
            {
                Console.WriteLine("gameX");
            }*/

        }
    }
}