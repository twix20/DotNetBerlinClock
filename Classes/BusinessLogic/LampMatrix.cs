using System;
using System.Collections.Generic;
using System.Linq;
using BerlinClock.Classes.BusinessLogic.Lamps;

namespace BerlinClock.Classes.BusinessLogic
{
    public class LampMatrix
    {
        public Lamp OddSecondsLamp => Rows[0][0];
        public IEnumerable<Lamp[]> RowsExceptOddSecondsLamp => Rows.Skip(1);

        public Lamp[][] Rows { get; } =
        {
            new Lamp[]
            {
                new YellowLamp(TimeSpan.Zero),
            },
            new Lamp[]
            {
                new RedLamp(TimeSpan.FromHours(5)),
                new RedLamp(TimeSpan.FromHours(5)),
                new RedLamp(TimeSpan.FromHours(5)),
                new RedLamp(TimeSpan.FromHours(5)),
            },
            new Lamp[]
            {
                new RedLamp(TimeSpan.FromHours(1)),
                new RedLamp(TimeSpan.FromHours(1)),
                new RedLamp(TimeSpan.FromHours(1)),
                new RedLamp(TimeSpan.FromHours(1)),
            },
            new Lamp[]
            {
                new YellowLamp(TimeSpan.FromMinutes(5)),
                new YellowLamp(TimeSpan.FromMinutes(5)),
                new RedLamp(TimeSpan.FromMinutes(5)),
                new YellowLamp(TimeSpan.FromMinutes(5)),
                new YellowLamp(TimeSpan.FromMinutes(5)),
                new RedLamp(TimeSpan.FromMinutes(5)),
                new YellowLamp(TimeSpan.FromMinutes(5)),
                new YellowLamp(TimeSpan.FromMinutes(5)),
                new RedLamp(TimeSpan.FromMinutes(5)),
                new YellowLamp(TimeSpan.FromMinutes(5)),
                new YellowLamp(TimeSpan.FromMinutes(5)),
            },
            new Lamp[]
            {
                new YellowLamp(TimeSpan.FromMinutes(1)),
                new YellowLamp(TimeSpan.FromMinutes(1)),
                new YellowLamp(TimeSpan.FromMinutes(1)),
                new YellowLamp(TimeSpan.FromMinutes(1))
            },
        };
    }
}
