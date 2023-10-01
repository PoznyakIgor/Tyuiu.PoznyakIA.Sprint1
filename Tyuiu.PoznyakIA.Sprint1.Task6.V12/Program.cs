using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PoznyakIA.Sprint1.Task6.V12.Lib;

namespace Tyuiu.PoznyakIA.Sprint1.Task6.V12
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
            Console.WriteLine(" Задание #6                                                               ");
            Console.WriteLine(" Вариант #12                                                              ");
            Console.WriteLine(" Выполнил: Позняк Игорь Андреевич | ИСТНб-23-1                            ");
            Console.WriteLine("                                                                          ");
            Console.WriteLine("* УСЛОВИЕ:                                                                ");
            Console.WriteLine(" Написать программу: пользователь вводит текст.                           ");
            Console.WriteLine("Проверить, что последнее слово строки входит в нее еще раз.               ");
            Console.WriteLine("                                                                          ");
            Console.WriteLine("                                                                          ");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        ");
            Console.WriteLine("                                                                          ");



            Console.WriteLine("Введите число текст: ");
            string value = Console.ReadLine();


            Console.WriteLine("*                                                                        *");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                ");
            Console.WriteLine("*                                                                        *");


            Console.WriteLine(ds.CheckLastWordRepetiton(value));

            Console.ReadLine();
        }
    }
}
