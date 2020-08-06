using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Things
{
    class Movie
    {
        public Critic Rating { get; set; }
        public string Name { get; set; }
        public string Genre { get; set; }

        public Movie(string name, string genre, Critic rating)
        {
            Name = name;
            Genre = genre.ToLower();
            Rating = rating;
            Console.WriteLine($"{Name} is a {Genre} and it has {Rating} reviews.");
        }

        public void Critique(Critic rating)
        {
            Rating = rating;
            if (Rating == Critic.fantastic)
            {
                Console.WriteLine($"{Name} should have won an oscar for getting {Rating} reviews.");
            }
            else
            {
                Console.WriteLine($"{Name} actually got {Rating} reviews.");
            }
        }

        public void Type()
        {
            if (Genre == "comedy")
            {
                Console.WriteLine($"{Name} is super hilarious.");
            }
            else
            {
                Console.WriteLine($"{Name} is a {Genre} movie.");
            }
        }
    }

    enum Critic
    {
        terrible,
        bad,
        meh,
        good,
        fantastic
    }
}
