using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Media
{
    class Movies : MediaBase
    {        
        private int _timesWatched;

        public Movies(string title, Genre genre)
        {
            Title = title;
            Genre = genre;
            _timesWatched = 1;
        }

        public void Watch()
        {
            _timesWatched += 1;
            Console.WriteLine($"You have watched the {Genre} movie, {Title}, {_timesWatched} times.");
        }
    }
}
