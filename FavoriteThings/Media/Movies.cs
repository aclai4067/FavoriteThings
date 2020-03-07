using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Media
{
    class Movies
    {
        public Genre MovieGenre { get; }
        public string Title { get; }
        private int _timesWatched;

        public Movies(string title, Genre genre)
        {
            Title = title;
            MovieGenre = genre;
        }


    }
}
