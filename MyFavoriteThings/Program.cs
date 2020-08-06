using MyFavoriteThings.Things;
using System;

namespace MyFavoriteThings
{
    class Program
    {
        static void Main()
        {
            var favMovie = new Movie("Ready Player One", "fiction", Critic.good);

            favMovie.Critique(Critic.meh);

            favMovie.Critique(Critic.fantastic);

            favMovie.Type();
        }
    }
}
