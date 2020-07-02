using System;

namespace BerlinClock.Classes.Input
{
    public interface ITimeParser
    {
        TimeSpan Parse(string aTime);
    }
}
