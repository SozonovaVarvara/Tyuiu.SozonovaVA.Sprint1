using Tyuiu.SozonovaVA.Sprint1.Task2.V1.Lib;
class Program
{
    static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.Title = "Спринт #1 | Выполнила: Созонова В. А. | АСОиУб-25-2";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Арифметические операторы в C#                                     *");
        Console.WriteLine("* Задание #2                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнила: Созонова Варвара Андреевна | АСОиУб-25-2                     *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, *");
        Console.WriteLine("* вычисляет расстояние в милях и печатает его на экране.                  *");
        Console.WriteLine("*                                                                         *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");

        int x;

        Console.WriteLine("Введите значение X:");
        x = Convert.ToInt32(Console.ReadLine());


        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");

        Console.WriteLine("Расстояние в милях = " + x / 1.6f);
        Console.ReadLine();
    }
}