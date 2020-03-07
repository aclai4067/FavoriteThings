using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Critters
{
    class Pets
    {
        public string name;
        public string kindOfPet;
        public int age;
        
        public Pets(string petName, string petType, int currentAge)
        {
            age = currentAge;
            kindOfPet = petType;
            name = petName;
        }

        public enum petSpecies
        {
            Cat,
            Dog,
            Snake
        }

        public void Birthday()
        {
            age += 1;
            Console.WriteLine($"{age} years old!  Happy Birthday {name}!!!");
        }

        public void Speak()
        {
            switch (kindOfPet)
            {
                case petSpecies.Cat.ToString():
                    { 
                        Console.WriteLine("Meow");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("Hello");
                        break;
                    }
            }
        }
    }
}
