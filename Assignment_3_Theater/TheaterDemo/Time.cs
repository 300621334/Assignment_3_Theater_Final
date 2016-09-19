using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheaterDemo
{
    class Time
    {
        public int Hours { get; private set; }
        public int Minutes { get; private set; }
        public int Seconds { get; private set; }
        public override string ToString()
        {
            return string.Format("{0:d2}:{1:d2}:{2:d2}", Hours, Minutes, Seconds);
        }

        public Time(int h, int m, int s)
        { Hours = h; Minutes = m; Seconds = s; }
    }
}
