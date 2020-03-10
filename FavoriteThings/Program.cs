using System;
using FavoriteThings.Critters;
using FavoriteThings.Media;

namespace FavoriteThings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Birds
            var Kookaburra = new Birds();
            Kookaburra.state = "Queensland";
            Kookaburra.Sing(Species.Kingfisher);
            Kookaburra.Fly(40);

            var Cockatoo = new Birds();
            Cockatoo.state = "Western Australia";
            Cockatoo.Sing(Species.Parrot);
            Cockatoo.Fly(100);

            Kookaburra.Fly(15);

            // Pets
            var Tabby = new Pets("Bundaberg", 12, PetSpecies.Cat);
            Tabby.Birthday();
            Tabby.Speak();

            var Mutt = new Pets("Murphy", 13, PetSpecies.Dog);
            Mutt.Birthday();
            Mutt.Speak();

            // Movies
            var HungerGames = new Movies("Hunger Games", Genre.Distopian);
            HungerGames.Watch();
            HungerGames.Rate(4.5m);

            var WeddingCrashers = new Movies("Wedding Crashers", Genre.Comdey);
            WeddingCrashers.Watch();
            WeddingCrashers.Rate(4m);

            // Books
            var MaryRoach = new Books("Bonk", Genre.Science, 280);
            MaryRoach.Read(25);
            MaryRoach.ChangeStatus();

            var BillBryson = new Books("Down Under", Genre.Biography, 250);
            BillBryson.Read(30);
            BillBryson.ChangeStatus();
            BillBryson.Read(23);

            Console.ReadKey();
        }
    }
}
