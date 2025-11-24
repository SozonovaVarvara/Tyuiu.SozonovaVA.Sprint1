using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SozonovaVA.Sprint1.Task2.V1.Lib
{
    public class DataService : ISprint1Task2V1
    {
        public double ConvertKmToM(int m)
        {
            double result = m * 1.609;
            return Math.Round(result, 3);
        }
    }
}
