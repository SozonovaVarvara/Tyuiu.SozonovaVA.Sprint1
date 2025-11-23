using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SozonovaVA.Sprint1.Task4.V27.Lib
{
    public class DataService : ISprint1Task4V27
    {
        public double Calculate(double x, double y)
        {
            double result = 1 + Math.Sin(Math.PI * x);
            result /= x - Math.Sqrt(Math.Abs(y));

            return Math.Round(result, 3);
        }

    }
}
