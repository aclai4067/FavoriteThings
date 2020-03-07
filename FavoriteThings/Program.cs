using System;
using FavoriteThings.Critters;
using FavoriteThings.Media;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            var Kookaburra = new Birds();
            Kookaburra.state = "Queensland";
            Kookaburra.Sing(Birds.species.Kingfisher);
            Kookaburra.Fly(40);

            var Cockatoo = new Birds();
            Cockatoo.state = "Western Australia";
            Cockatoo.Sing(Birds.species.Parrot);
            Cockatoo.Fly(100);

            Kookaburra.Fly(15);

            var Tabby = new Pets("Bundaberg", Pets.petSpecies.Cat.ToString(), 12);
            Tabby.Birthday();

            var Mutt = new Pets("Murhy", Pets.petSpecies.Dog.ToString(), 13);
            Mutt.Birthday();

            Console.ReadKey();
        }
    }
}
