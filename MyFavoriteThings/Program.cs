using MyFavoriteThings.Things;
using System;

namespace MyFavoriteThings
{
    class Program
    {
        static void Main()
        {
            
            var favMovie = new Movie("Ready Player One", "fiction", Critic.good);
            favMovie.Critique(Critic.fantastic);
            favMovie.Type();

            var favBook = new Book("The Name of the Wind", "Patrick Rothfuss", "Fiction");
            favBook.ChangeGenre("Nonfiction");
            favBook.GoodBookByAuthor();

            var favGame = new Game("Overwatch", 20, true);
            favGame.Multiplayer();
            favGame.Leveling();

            var favShow = new Show("The Flash", 40, "Barry Allen");
            favShow.HowManyEpisodes();
            favShow.NewEpisodes();

        }
    }
}
