using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PoznyakIA.Sprint1.Task2.V9.Lib;

namespace Tyuiu.PoznyakIA.Sprint1.Task2.V9
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Позняк И.А. | ИСТНб-23-1";

            Console.WriteLine("");
            Console.WriteLine(" Спринт #1                                                               ");
            Console.WriteLine(" Тема: Базовые навыки работы в С#                                        ");
            Console.WriteLine(" Задание #2                                                              ");
            Console.WriteLine(" Вариант #9                                                             ");
            Console.WriteLine(" Выполнил: Позняк Игорь Андреевич | ИСТНб-23-1                       ");
            Console.WriteLine("");
            Console.WriteLine("* УСЛОВИЕ:                                                                ");
            Console.WriteLine(" Написать программу, которая запрашивает у пользователя исходные данные,    ");
            Console.WriteLine("выполняет указанные расчёты и печатает результат на экране.               ");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        ");
            Console.WriteLine("");
            int r;
            Console.WriteLine("Введение радиус окружности");
            r = Convert.ToInt32(Console.ReadLine());
         
            Console.WriteLine("**");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("**");

            Console.WriteLine("Объем шара равен:" + ds.CalculateVolumeCircle(r));

            Console.ReadLine();
        }
    }
}
