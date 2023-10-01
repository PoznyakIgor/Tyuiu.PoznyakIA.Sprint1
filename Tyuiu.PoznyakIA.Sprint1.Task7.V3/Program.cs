using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PoznyakIA.Sprint1.Task7.V3.Lib;

namespace Tyuiu.PoznyakIA.Sprint1.Task7.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Позняк И.А. | ИСТНб-23-1";

            Console.WriteLine("                                                                          ");
            Console.WriteLine(" Спринт #1                                                                ");
            Console.WriteLine(" Тема: Алгоритмы линейной структуры                                       ");
            Console.WriteLine(" Задание #7                                                               ");
            Console.WriteLine(" Вариант #3                                                               ");
            Console.WriteLine(" Выполнил: Позняк Игорь Андреевич | ИСТНб-23-1                            ");
            Console.WriteLine("                                                                          ");
            Console.WriteLine("* УСЛОВИЕ:                                                                ");
            Console.WriteLine(" Написать программу, которая вычисляет математическое выражение по исходным значениям данных, ");
            Console.WriteLine("вводимых пользователем. Ответ округлите до 3 знаков после запятой.        ");
            Console.WriteLine("                                                                          ");
            Console.WriteLine("                                                                          ");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        ");
            Console.WriteLine("                                                                          ");

            double x, y;

            Console.WriteLine("Введите число x: ");
            x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите число y: ");
            y = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("*                                                                        *");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                ");
            Console.WriteLine("*                                                                        *");


            Console.WriteLine(ds.Calculate(x, y));

            Console.ReadLine();
        }
    }
}
