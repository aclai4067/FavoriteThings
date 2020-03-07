using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Critters
{
    public enum PetSpecies
    {
        Cat,
        Dog,
        Snake
    }

    class Pets
    {
        public string Name;
        public PetSpecies KindOfPet;
        public int Age;
        
        public Pets(string petName, int currentAge, PetSpecies petType)
        {
            Age = currentAge;
            Name = petName;
            KindOfPet = petType;
        }

        public void Birthday()
        {
            Age += 1;
            Console.WriteLine($"{Age} years old!  Happy Birthday {Name}!!!");
        }

        public void Speak()
        {
            switch (KindOfPet)
            {
                case PetSpecies.Cat:
                    {
                        Console.WriteLine("Meow");
                        break;
                    }
                case PetSpecies.Dog:
                    {
                        Console.WriteLine("Woof");
                        break;
                    }
                case PetSpecies.Snake:
                    {
                        Console.WriteLine("Hiss");
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
