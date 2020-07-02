using System;

namespace BerlinClock.Classes.BusinessLogic.Lamps
{
    public class YellowLamp : Lamp
    {
        public YellowLamp(TimeSpan time) : base(time, "Y")
        {
        }
    }
}