using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Media
{
    class Movies
    {
        public Genre MovieGenre { get; }
        public string Title { get; }
        public decimal Rating { get; set; }
        private int _timesWatched;

        public Movies(string title, Genre genre)
        {
            Title = title;
            MovieGenre = genre;
            _timesWatched = 1;
        }

        public void Watch()
        {
            _timesWatched += 1;
            Console.WriteLine($"You have watched the {MovieGenre} movie, {Title}, {_timesWatched} times.");
        }

        public void Rate(decimal rating)
        {
            Rating = rating;
            Console.WriteLine($"You have updated the rating of {Title} to {Rating} stars!");
        }
    }
}
