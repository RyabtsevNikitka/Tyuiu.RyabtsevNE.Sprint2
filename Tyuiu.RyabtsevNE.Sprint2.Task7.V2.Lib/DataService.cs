using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.RyabtsevNE.Sprint2.Task7.V2.Lib
{
    public class DataService : ISprint2Task7V2
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if ((y <= ((double)(x / 2))) && ((Math.Pow(x, 2) + Math.Pow(y, 2)) <= 1))
            {
                return true;
            }
            else
            {
                return false;
            }
    }
}
