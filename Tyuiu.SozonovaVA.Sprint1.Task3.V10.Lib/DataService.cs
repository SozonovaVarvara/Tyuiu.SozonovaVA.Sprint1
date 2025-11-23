using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SozonovaVA.Sprint1.Task3.V10.Lib
{
    public class DataService : ISprint1Task3V10
    {
        public string NumberToMoney(double number)
        {
            int rubles = (int)number;
            int kopecks = (int)((number - rubles) * 100);

            string formattedNumber = number.ToString().Replace(',', '.');

            return $"{formattedNumber} руб. - это {rubles} руб. {kopecks} коп.".Trim();
        }
    }
}
