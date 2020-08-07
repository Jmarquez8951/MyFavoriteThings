using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace MyFavoriteThings.Things
{
    class Game
    {
        public string Title { get; set; }
        public int Level { get; set; }
        public bool IsMultiplayer { get; set; }

        public Game(string title, int level, bool isMultiplayer)
        {
            Title = title;
            Level = level;
            IsMultiplayer = isMultiplayer;
            if (IsMultiplayer == true)
            {
                Console.WriteLine($"I am level {Level} in {Title} the multiplayer game.");
            } else
            {
                Console.WriteLine($"I am level {Level} in {Title}.");
            }
        }

        public void Multiplayer()
        {
            if (IsMultiplayer == true)
            {
                Console.WriteLine("I can play with other people. Yay!");
            } else
            {
                Console.WriteLine("I can't play with my friends.");
            }
        }

        public void Leveling()
        {
            string response;
            do
            {
                Console.WriteLine("Fight the dragon or fight the minions?(Type dragon, minion, or quit)");
                response = Console.ReadLine();
                Random rnd = new Random();

                if (response == "dragon")
                {
                    if (Level > rnd.Next(100))
                    {
                        Console.WriteLine(@"You defeated the dragon!
                                            +4");
                        Level += 4;
                    }
                    else
                    {
                        Console.WriteLine(@"You were killed by the dragon.
                                            Level -5");
                        Level -= 5;
                    }
                }
                else if (response == "minions")
                {
                    Console.WriteLine(@"You slayed all the minions!
                                        Level +1");
                    Level += 1;
                }
            } while (response != "quit");
            
        }

    }
}
