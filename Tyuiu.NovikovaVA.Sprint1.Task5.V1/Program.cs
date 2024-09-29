using Tyuiu.NovikovaVA.Sprint1.Task5.V1.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        Console.Title = "Спринт #1 | Выполнил: Новикова В. А. | ИСТНб-24-1";
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* Спринт #1                                                               *");
        Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
        Console.WriteLine("* Задание #5                                                              *");
        Console.WriteLine("* Вариант #1                                                              *");
        Console.WriteLine("* Выполнил: Новикова Валерия Александровна | ИСТНб-24-1                   *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* УСЛОВИЕ:                                                                *");
        Console.WriteLine("* Написать программу, которая решает следующую задачу:                    *");
        Console.WriteLine("* Найти расстояние между двумя точками с заданными координатами (x, y).   *");
        Console.WriteLine("* и печатает его на экране.                                               *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("Введите X1: ");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите Y1: ");
        double y1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите X2: ");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите Y2: ");
        double y2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("***************************************************************************");
        Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
        Console.WriteLine("***************************************************************************");
        int res = ds.DistanceBetweenDots(x1, y1, x2, y2);
        Console.WriteLine(res);
        Console.ReadKey();
    }
}