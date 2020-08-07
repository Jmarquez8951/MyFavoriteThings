using System;
using System.Collections.Generic;
using System.Text;

namespace MyFavoriteThings.Things
{
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Genre { get; set; }

        public Book(string title, string author, string genre)
        {
            Title = title;
            Author = author;
            Genre = genre.ToLower();
            Console.WriteLine($"'{Title},' by {Author} is a {Genre} book.");
        }

        public void ChangeGenre(string newGenre)
        {
            Genre = newGenre;
            Console.WriteLine($"The book called '{Title}' has been changed to a different genre. It is now a {Genre}.");
        }

        public void GoodBookByAuthor()
        {
            if (Author.ToLower() == "ernest cline" || Author.ToLower() == "patrick rothfuss")
            {
                Console.WriteLine("This author is a very good writer.");
            }
            else
            {
                Console.WriteLine("They're an ok writer.");
            }
        }
    }
}
