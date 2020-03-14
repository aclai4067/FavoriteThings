using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Critters
{
    abstract class CritterBase
    {
        public Species Species { get; set; }


        public void Speak()
        {
            switch (Species)
            {
                case Species.Cat:
                    {
                        Console.WriteLine("Meow");
                        break;
                    }
                case Species.Dog:
                    {
                        Console.WriteLine("Woof");
                        break;
                    }
                case Species.Snake:
                    {
                        Console.WriteLine("Hiss");
                        break;
                    }
                case Species.Kingfisher:
                    {
                        Console.WriteLine("Laugh");
                        break;
                    }
                case Species.SongBird:
                    {
                        Console.WriteLine("Tweet");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Squawk");
                        break;
                    }
            }
        }

    }
}