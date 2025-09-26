using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.ShaykhelislamovaDA.Sprint1.Task7.V9.Lib
{
    public class DataService : ISprint1Task7V9
    {
        public double Calculate(double x, double y)
        {
            return Math.Round(Math.Pow(Math.E, x) - (y * y + Math.Cos(x * x * x) + 12 * x * y - 3 * x * x) / (Math.Cos(x * x * x + 3) + 18 * y - 1), 3);
        }
    }
}
