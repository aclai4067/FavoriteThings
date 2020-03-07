using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Critters
{
    class Birds
    {
        private int _totalDistance;
        public string state;
         public enum species
        {
            Parrot,
            Kingfisher,
            SongBird
        }

        public void Sing(species sp)
        {
            switch (sp)
            {
                case species.Kingfisher:
                    Console.WriteLine("Laugh");
                    break;
                case species.SongBird:
                    Console.WriteLine("Tweet");
                    break;
                default:
                    Console.WriteLine("Squawk");
                    break;
            }
        }
        public void Fly(int distance)
        {
            _totalDistance += distance;
            Console.WriteLine($"The bird flew {distance} feet in {state}, {_totalDistance} total!");
        }
    }
}
