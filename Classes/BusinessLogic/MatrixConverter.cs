using BerlinClock.Classes.BusinessLogic.Lamps;
using System;

namespace BerlinClock.Classes.BusinessLogic
{
    public class MatrixConverter : IMatrixConverter
    {
        public LampMatrix FromTimeSpan(TimeSpan time)
        {
            var matrix = new LampMatrix();
            matrix.OddSecondsLamp.Enabled = IsBlinking(time);

            foreach (var rowLamps in matrix.TimeIndicatorLampRows)
            {
                foreach (var lamp in rowLamps)
                {
                    if (ShouldEnableLamp(time, lamp))
                    {
                        time = EnableLamp(time, lamp);
                    }
                }
            }

            return matrix;
        }

        private static TimeSpan EnableLamp(TimeSpan time, Lamp lamp)
        {
            time -= lamp.Time;
            lamp.Enabled = true;

            return time;
        }

        private static bool ShouldEnableLamp(TimeSpan time, Lamp lamp) => time - lamp.Time >= TimeSpan.Zero;

        private static bool IsBlinking(TimeSpan time) => time.Seconds % 2 == 0;
    }
}