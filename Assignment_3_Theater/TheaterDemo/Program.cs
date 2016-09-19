using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TheaterDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            Movie terminator = new Movie("Judgement Day", 105);
            terminator.AddActor("Arnold Schwarzenegger");
            terminator.SetGenre(MovieGenre.Horror | MovieGenre.Action); //[Flags] allows to assign more than one enum at a time. But have to use powers of 2 always with flags.
            terminator.AddActor("Linda Hamilton");
            Show s1 = new Show(terminator, MovieDay.Mon, 5.95, new Time(11, 35, 0));

            Console.WriteLine(s1);
            Theater eglinton = new Theater("Cineplex");
            eglinton.AddShow(s1);
            eglinton.PrintShows();

            Movie godzilla = new Movie("Godzilla 2014", 123);
            godzilla.AddActor("Aaron Johnson");
            godzilla.AddActor("Ken Watanabe");
            godzilla.AddActor("Elizabeth Olsen");
            godzilla.SetGenre(MovieGenre.Action);
            //I added line below as godzilla was NOT added to eglinton in MS-word--file
            eglinton.AddShow(new Show(godzilla, MovieDay.Fri, 6.99, new Time(10, 5, 0)));


            Movie trancendence = new Movie("Transendence", 120);
            trancendence.AddActor("Johnny Depp");
            trancendence.AddActor("Morgan Freeman");
            trancendence.SetGenre(MovieGenre.Comedy);
            eglinton.AddShow(new Show(trancendence, MovieDay.Sun, 7.87, new Time(18, 5, 0)));

            Movie m1 = new Movie("The Shawshank Redemption", 120);
            m1.AddActor("Tim Robbins");
            m1.AddActor("Morgan Freeman");
            m1.SetGenre(MovieGenre.Action);
            eglinton.AddShow(new Show(m1, MovieDay.Sun, 8.87, new Time(14, 5, 0)));


            m1 = new Movie("Olympus Has Fallen", 120);
            m1.AddActor("Gerard Butler");
            m1.AddActor("Morgan Freeman");
            m1.SetGenre(MovieGenre.Action);
            eglinton.AddShow(new Show(m1, MovieDay.Sun, 8.87, new Time(16, 5, 0)));


            Show s2 = new Show(godzilla, MovieDay.Mon, 6.89, new Time(13, 15, 0));
            eglinton.AddShow(s2);

            s2 = new Show(godzilla, MovieDay.Sun, 6.89, new Time(14, 15, 0));
            eglinton.AddShow(s2);

            s2 = new Show(godzilla, MovieDay.Sun, 6.89, new Time(16, 55, 0));
            eglinton.AddShow(s2);

            eglinton.PrintShows();

            eglinton.PrintShows(MovieDay.Sun);

            eglinton.PrintShows(MovieGenre.Action);

            eglinton.PrintShows("Morgan Freeman");
            Console.WriteLine("******");
            eglinton.PrintShows(new Time(14, 30, 0));

        }
    }
}
