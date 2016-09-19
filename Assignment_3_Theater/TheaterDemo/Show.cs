using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterDemo
{
    //enum w small-letter-"e" --- NOT Cap Enum.
    public enum MovieDay
    { Sun, Mon, Tue, Thu, Fri, Sat }

    class Show
    {
        public MovieDay Day {get; private set;}
        public Movie Movie { get; private set; }
        public double Price { get; private set; }
        public Time Time { get; private set; }

        public Show(Movie m, MovieDay d, double p, Time t)
        { Movie = m;Day = d;Price = p;Time = t; }

        public override string ToString()
        {
            return Movie + "\nPlaying on " +Day+ "\nAt: " + Time + "\nTotal Cost: $"+Price+"\n";
        }
    }
}
