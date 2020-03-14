using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Critters
{
    class Pets : CritterBase
    {
        public string Name;
        public int Age;
        
        public Pets(string petName, int currentAge, Species petType)
        {
            Age = currentAge;
            Name = petName;
            Species = petType;
        }

        public void Birthday()
        {
            Age += 1;
            Console.WriteLine($"{Age} years old!  Happy Birthday {Name}!!!");
        }

    }
}
