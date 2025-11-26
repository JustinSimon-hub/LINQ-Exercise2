using System.Runtime.Intrinsics.X86;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>()
            {
                "The Legend of Zelda: Breath of the Wild",
                "Super Mario Odyssey",
                "Red Dead Redemption 2",
                "The Witcher 3: Wild Hunt",
                "God of War",
                "Minecraft",
                "Fortnite",
                "Overwatch",
                "Halo Infinite",
                "Cyberpunk 2077"
            };
            var orderedGames = videoGames.OrderBy(game => game.Length);
            Console.WriteLine("Video games ordered by length of name:");
            foreach (var game in orderedGames)
            {
                Console.WriteLine(game);
            }

        }
    }
}


//## Exercise 2:

//Use the list of [Linq methods] (https://portal.truecoders.io/course/1/lecture/62/lesson) for help

//+Create a list of video game names...
//+ Order the list of games by length of the game name.
//+ Use the lambda expression in this exercise as well.
//+ use Method Syntax for this exercise