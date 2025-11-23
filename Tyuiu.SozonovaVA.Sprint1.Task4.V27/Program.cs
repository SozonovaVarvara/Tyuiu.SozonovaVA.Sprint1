using System.Text;
using Tyuiu.SozonovaVA.Sprint1.Task4.V27.Lib;
{
    Console.OutputEncoding = Encoding.UTF8;

    Console.Title = "Спринт #1 | Выполнила: Созонова В. А. | АСОиУб-25-1";
    Console.WriteLine(new string('*', 75));
    Console.WriteLine("* Спринт #1                                                               *");
    Console.WriteLine("* Тема: Class Math                                                        *");
    Console.WriteLine("* Задание #4                                                              *");
    Console.WriteLine("* Вариант #27                                                             *");
    Console.WriteLine("* Выполнила: Созонова Варвара Андреевна | АСОиУ-25-1                      *");
    Console.WriteLine(new string('*', 75));
    Console.WriteLine("* УСЛОВИЕ: Написать программу, которая запрашивает у пользователя         *");
    Console.WriteLine("* исходные данные, вычисляет результат по формуле и печатает его на       *");
    Console.WriteLine("* экране. Ответ округлить до 3 знаков после запятой.                      *");
    Console.WriteLine(new string('*', 75));
    Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ: (1 + sinπx) / (x - √|y|)                               *");
    Console.WriteLine(new string('*', 75));

    var result = new DataService();

    Console.Write("x = ");
    int x = Convert.ToInt32(Console.ReadLine());

    Console.Write("y = ");
    int y = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine(new string('*', 75));
    Console.WriteLine("РЕЗУЛЬТАТ:");
    Console.WriteLine(result.Calculate(x, y).ToString());

    Console.WriteLine(new string('*', 75));
    Console.ReadKey();
}