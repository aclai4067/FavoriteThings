using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Critters
{
    public enum Species
    {
        Parrot,
        Kingfisher,
        SongBird
    }

    class Birds
    {
        private int _totalDistance;
        public string state { get; set; }
        public Species Species { get; set; }
        

        public void Sing(Species sp)
        {
            switch (sp)
            {
                case Species.Kingfisher:
                    Console.WriteLine("Laugh");
                    break;
                case Species.SongBird:
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
