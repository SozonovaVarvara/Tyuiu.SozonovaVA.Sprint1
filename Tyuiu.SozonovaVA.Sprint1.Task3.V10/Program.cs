using Tyuiu.SozonovaVA.Sprint1.Task3.V10.Lib;
{
    DataService ds = new DataService();

    Console.Title = " Спринт #1 |Выполнила: Созонова В. А. | АСОиУб-25-1 ";
    //Длина строки 75 символов
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("*Спринт #1                                                                *");
    Console.WriteLine("*Тема: Операторы составного присваивания                                  *");
    Console.WriteLine("*Задание #3                                                               *");
    Console.WriteLine("*Вариант #10                                                              *");
    Console.WriteLine("*Выполнила: Созонова Варвара Андреевна | АСОиУб-25-1                      *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("*УСЛОВИЕ:                                                                 *");
    Console.WriteLine("*Написать программу, которая запрашивает у пользователя исходные данные,  *");
    Console.WriteLine("*выполняет указанные расчёты и печатает результат на экране.              *");
    Console.WriteLine("*                                                                         *");
    Console.WriteLine("***************************************************************************");
    Console.WriteLine("*ИСХОДНЫЕ ДАННЫЕ:                                                         *");
    Console.WriteLine("***************************************************************************");

    double number;
    Console.WriteLine("Введите дробное число ->");
    number = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("***************************************************************************");
    Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
    Console.WriteLine("***************************************************************************");

    double cop = Math.Round(number % 1 * 100);
    double rub = number - (number % 1);

    Console.WriteLine(number + " руб - это " + rub + " руб. " + cop + " коп. ");

    Console.ReadLine();
}