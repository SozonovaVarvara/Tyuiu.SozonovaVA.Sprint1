using Tyuiu.SozonovaVA.Sprint1.Task1.V1.Lib;
DataService ds = new DataService();

Console.Title = "Спринт #1 | Выполнила: Созонова В. А. | АСОиУБ-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #1                                                               *");
Console.WriteLine("* Тема: Базовые навыки работы в С#                                        *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #1                                                              *");
Console.WriteLine("* Выполнила: Созонова Варвара Андреевна | АСОиУБ-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ                                                                 *");
Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные  *");
Console.WriteLine("* вычисляет результат по формуле x/3/y+6*a и печатает его на экран.       *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

double a, x, y;

Console.WriteLine("Введите значени A:");
a = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значени X:");
x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите значени Y:");
y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine(ds.Calculate(a, x, y));

Console.ReadLine();