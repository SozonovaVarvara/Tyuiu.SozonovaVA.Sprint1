using Tyuiu.SozonovaVA.Sprint1.Task2.V1.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнила: Созонова В. А. | АСОиУб-25-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнила: Созонова Варвара Андреевна | АСОиУб-25-1                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя данные,          *");
        Console.WriteLine("* выполняет указанные расчёты и печатает результат на экране.             *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int m;

        Console.WriteLine("Введите значение X:");
        m = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Расстояние в милях = " + ds.ConvertKmToM(m));
        Console.ReadLine();
    }

}