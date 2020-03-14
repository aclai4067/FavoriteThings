using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Critters
{
    class Birds : CritterBase
    {
        private int _totalDistance;
        public string state { get; set; }
        

        public void Fly(int distance)
        {
            _totalDistance += distance;
            Console.WriteLine($"The bird flew {distance} feet in {state}, {_totalDistance} total!");
        }
    }
}
