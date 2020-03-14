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
            var Kookaburra = new Birds()
            {
                state = "Queensland",
                Species = Species.Kingfisher
            };
            Kookaburra.Speak();
            Kookaburra.Fly(40);

            var Cockatoo = new Birds()
            {
                state = "Western Australia",
                Species = Species.Parrot
            };
            Cockatoo.Speak();
            Cockatoo.Fly(100);

            Kookaburra.Fly(15);

            // Pets
            var Tabby = new Pets("Bundaberg", 12, Species.Cat);
            Tabby.Birthday();
            Tabby.Speak();

            var Mutt = new Pets("Murphy", 13, Species.Dog);
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
            MaryRoach.Rate(4.8m);

            var BillBryson = new Books("Down Under", Genre.Biography, 250);
            BillBryson.Read(30);
            BillBryson.ChangeStatus();
            BillBryson.Read(23);
            BillBryson.Rate(4.1m);

            Console.ReadKey();
        }
    }
}
