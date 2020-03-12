using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Media
{
    abstract class MediaBase
    {
        public Genre Genre { get; set; }
        public string Title { get; set; }
        public decimal Rating { get; set; }

        public void Rate(decimal rating)
        {
            Rating = rating;
            Console.WriteLine($"You have updated the rating of {Title} to {Rating} stars!");
        }
    }
}
