using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpLab251003_2
{
    public abstract class LocalTime
    {
        protected DateTime LondonTime;            // the London time entered by the user

        protected LocalTime(DateTime londonTime)  // base stores it
        {
            LondonTime = londonTime;
        }

        protected abstract string City { get; }   // city label
        protected abstract int OffsetHours { get; } // hours relative to London (winter)

        public virtual void DisplayTimeAndCity()
        {
            var local = LondonTime.AddHours(OffsetHours);
            Console.WriteLine($"{City}: {local:HH:mm}");
        }
    }
}
