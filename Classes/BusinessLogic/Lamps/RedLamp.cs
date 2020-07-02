using System;

namespace BerlinClock.Classes.BusinessLogic.Lamps
{
    public class RedLamp : Lamp
    {
        public RedLamp(TimeSpan time) : base(time, "R")
        {
        }
    }
}