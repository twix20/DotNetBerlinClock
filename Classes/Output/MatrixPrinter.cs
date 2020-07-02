using System.Text;
using BerlinClock.Classes.BusinessLogic;

namespace BerlinClock.Classes.Output
{
    public class MatrixPrinter : IMatrixPrinter
    {
        private const string NewLine = "\r\n";

        public string ToString(LampMatrix matrix)
        {
            var sb = new StringBuilder();

            foreach (var rowLamps in matrix.Rows)
            {
                foreach (var lamp in rowLamps)
                {
                    sb.Append(lamp.LampSign);
                }

                sb.Append(NewLine);
            }

            sb.Length -= NewLine.Length;

            return sb.ToString();
        }
    }
}