using Tyuiu.NovikovaVA.Sprint1.Task3.V15.Lib;
namespace Tyuiu.NovikovaVA.Sprint1.Task3.V15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Новикова В. А. | ИСТНб-24-1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #1                                                               *");
            Console.WriteLine("* Тема: Базовые навыки работы в C#                                        *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #15                                                             *");
            Console.WriteLine("* Выполнил: Новикова Валерия Александровна | ИСТНб-24-1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Написать программу, решающую следующую задачу: два автомобиля           *");
            Console.WriteLine("* имеют скорости V1 км/ч и V2 км/ч соответственно, находятся              *");
            Console.WriteLine("* на расстоянии S км друг от друга и движутся в противоположные стороны.  *");
            Console.WriteLine("* Определить расстояние между ними через T часов.                         *");
            Console.WriteLine("*                                                                         *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");
            double v1 = 20;
            double v2 = 7;
            double S = 10;
            double T = 6;
            Console.WriteLine("Скорость первого автомобиля = "+v1);
            Console.WriteLine("Скорость второго автомобиля = " + v2);
            Console.WriteLine("Расстояние между ними = " + S);
            Console.WriteLine("Время = " + T);
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine(" Hасстояние между ними через T часов = " + ds.DistanceOverTime(v1, v2, S, T));
            Console.ReadKey();


        }
    }
}
