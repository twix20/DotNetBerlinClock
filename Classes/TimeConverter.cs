using BerlinClock.Classes.BusinessLogic;
using BerlinClock.Classes.Input;
using BerlinClock.Classes.Output;

namespace BerlinClock.Classes
{
    public class TimeConverter : ITimeConverter
    {
        private readonly ITimeParser _parser;
        private readonly IMatrixConverter _converter;
        private readonly IMatrixPrinter _printer;

        public TimeConverter(ITimeParser parser, IMatrixConverter converter, IMatrixPrinter printer)
        {
            _parser = parser;
            _converter = converter;
            _printer = printer;
        }

        public string ConvertTime(string aTime)
        {
            var time = _parser.Parse(aTime);
            var matrix = _converter.FromTimeSpan(time);

            return _printer.ToString(matrix);
        }
    }
}