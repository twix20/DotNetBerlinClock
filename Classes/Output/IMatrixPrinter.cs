using BerlinClock.Classes.BusinessLogic;

namespace BerlinClock.Classes.Output
{
    public interface IMatrixPrinter
    {
        string ToString(LampMatrix matrix);
    }
}
