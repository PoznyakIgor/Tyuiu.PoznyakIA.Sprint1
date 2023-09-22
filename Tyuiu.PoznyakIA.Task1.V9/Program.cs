using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PoznyakIA.Sprint1.Task1.V9.Lib;


namespace Tyuiu.PoznyakIA.Sprint1.Task1.V9
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
            Console.WriteLine(" Задание #0                                                              ");
            Console.WriteLine(" Вариант #12                                                             ");
            Console.WriteLine(" Выполнил: Позняк Игорь Андреевич | ИСТНб-23-1                       ");
            Console.WriteLine("");
            Console.WriteLine("* УСЛОВИЕ:                                                                ");
            Console.WriteLine(" Написать программу, которая запрашивает у пользователя исходные данные,   ");
            Console.WriteLine("вычисляет результат по формуле (1+3*x)/(4*y) и печатает результат на экране.");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        ");
            Console.WriteLine("");
            double x, y;
            Console.WriteLine("Введение значение X:");
            x = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("Введение значение Y:");
            y = Convert.ToDouble(Console.ReadLine());
                            
            Console.WriteLine("**");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                               ");
            Console.WriteLine("**");

            Console.WriteLine(ds.Calculate(x,y));

            Console.ReadLine();
        }
    }
}
