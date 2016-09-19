using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterDemo
{
    //enum w small-letter-"e" --- NOT Cap Enum.
    //this [Flags] this is new
    //[Flags] allows to assign more than one enum at a time. 
    //Assign powers of 2 to each enum in order
    [Flags] public enum MovieGenre
    { Unrated=0, Action=1, Romance=2, Documentry=4, Mystry=8, Musical=16, Horror=32, Comedy=64 }
    class Movie
    {
        public List<string> Cast { get; private set; }
        public MovieGenre Genre { get; private set; }
        public int Length { get; private set; }
        public string Title { get; private set; }

        //constructor
        public Movie(string t, int l)
        { Title = t; Length = l; Cast = new List<string>();
        }

        public void AddActor(string actor)
        { Cast.Add(actor); }

        public void SetGenre(MovieGenre genre)
        { Genre = genre; }

        public override string ToString()
        {
            string actorNames = "";
            foreach(string x in Cast)
            { actorNames += x + ","; }
            return string.Format("Movie {0} \nDuration: {1} minutes \nGenre:{2} \nFeaturing: {3}", Title, Length, Genre, actorNames);
        }
    }
}
