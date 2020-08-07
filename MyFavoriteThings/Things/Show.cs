using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Things
{
    class Show
    {
        string Series { get; set; }
        int Episodes { get; set; }
        string MainCharacter { get; set; }

        public Show(string series, int episodes, string mainCharacter)
        {
            Series = series;
            Episodes = episodes;
            MainCharacter = mainCharacter;
            Console.WriteLine($"{Series} is a show about {MainCharacter} with {Episodes} episodes.");
        }

        public void HowManyEpisodes()
        {
            Console.WriteLine($"This show has {Episodes} episodes so far.");
        }

        public void NewEpisodes()
        {
            Console.WriteLine("How many new episodes have been added?");
            var response = Console.ReadLine();
            response = response.Trim();
            Episodes += int.Parse(response);
            Console.WriteLine($"{response} have been added.");
            Console.WriteLine($"There are now {Episodes} episodes.");
        }
    }
}
