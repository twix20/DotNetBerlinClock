using System;

namespace BerlinClock.Classes.Input
{
    public class TimeParser : ITimeParser
    {
        public const char TimeSeparator = ':';

        public TimeSpan Parse(string aTime)
        {
            var timeChunks = aTime.Split(TimeSeparator);

            if (timeChunks.Length != 3)
            {
                throw new ArgumentException($"{nameof(aTime)} must be in format hh{TimeSeparator}mm{TimeSeparator}ss");
            }

            var hours = int.Parse(timeChunks[0]);
            var minutes = int.Parse(timeChunks[1]);
            var seconds = int.Parse(timeChunks[2]);
            var days = hours / 24;
            hours %= 24;

            return new TimeSpan(days, hours, minutes, seconds);
        }
    }
}