using System;

namespace BerlinClock.Classes.BusinessLogic
{
    public interface IMatrixConverter
    {
        LampMatrix FromTimeSpan(TimeSpan time);
    }
}