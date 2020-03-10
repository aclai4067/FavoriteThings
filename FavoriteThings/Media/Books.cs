using System;
using System.Collections.Generic;
using System.Text;

namespace FavoriteThings.Media
{
    enum Status
    {
        ToRead = 1,
        Reading,
        GaveUp,
        Read
    }

    class Books
    {
        public Genre BookGenre { get; }
        public string BookTitle { get; }
        public int PageLength { get; }
        public int PagesRead { get; set; }
        public Status BookStatus { get; set; }

        public Books(string title, Genre genre, int length)
        {
            BookTitle = title;
            BookGenre = genre;
            PageLength = length;
        }

        public void Read (int pages)
        {
            PagesRead += pages;
            Console.WriteLine($"You have read {PagesRead} out of {PageLength} in {BookTitle}");
        }

        public void ChangeStatus()
        {
            Console.WriteLine($"Enter your status code for {BookTitle} (1 = Want to Read; 2 = Currently Reading; 3 = Gave Up Reading; 4 = Finished Reading)");
            var status = Int32.Parse(Console.ReadLine());
            BookStatus = (Status)status;
            switch (BookStatus)
            {
                case Status.ToRead:
                    {
                        Console.WriteLine($"You want to read {BookTitle}");
                        break;
                    }
                case Status.Reading:
                    {
                        Console.WriteLine($"Enjoy reading {BookTitle}!");
                        break;
                    }
                case Status.GaveUp:
                    {
                        Console.WriteLine("Quitter");
                        break;
                    }
                case Status.Read:
                    {
                        Console.WriteLine($"Congrats! You finished {BookTitle}");
                        break;
                    }
                default:
                    {
                        Console.WriteLine("You did not enter a valid status for your book.");
                        break;
                    }
            }
        }
    }
}
