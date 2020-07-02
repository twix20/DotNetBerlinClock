using System;

namespace BerlinClock.Classes.BusinessLogic.Lamps
{
    public abstract class Lamp
    {
        public const string DisabledLampSign = "O";

        /// <summary>
        /// Time duration of the Lamp
        /// </summary>
        public TimeSpan Time { get; }

        /// <summary>
        /// Color of turned ON lamp
        /// </summary>
        public string Color { get; }

        /// <summary>
        /// Is lamp turned ON
        /// </summary>
        public bool Enabled { get; set; } = false;

        /// <summary>
        /// Effective Lamp Sign
        /// </summary>
        public string LampSign => Enabled ? Color : DisabledLampSign;

        protected Lamp(TimeSpan time, string color)
        {
            Time = time;
            Color = color;
        }
    }
}