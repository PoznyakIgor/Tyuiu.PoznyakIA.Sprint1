﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PoznyakIA.Sprint1.Task0.V3.Lib;

namespace Tyuiu.PoznyakIA.Sprint1.Task0.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Ворошилов Н.А. | ИСТНб-23-1";

            Console.WriteLine("**");
            Console.WriteLine(" Спринт #1                                                               ");
            Console.WriteLine(" Тема: Базовые навыки работы в С#                                        ");
            Console.WriteLine(" Задание #0                                                              ");
            Console.WriteLine(" Вариант #12                                                             ");
            Console.WriteLine(" Выполнил: Ворошилов Никита Андреевич | ИСТНб-23-1                       ");
            Console.WriteLine("**");
            Console.WriteLine("* УСЛОВИЕ:                                                                ");
            Console.WriteLine(" Написать программу, которая вычисляет выражение (52-2)/43             ");
            Console.WriteLine(" и печатает результат на экране.                                         ");
            Console.WriteLine("                                                                         ");
            Console.WriteLine("**");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        ");
            Console.WriteLine("**");
            Console.WriteLine("(52-2)/4*3                                                              ");
            Console.WriteLine("**");
            Console.WriteLine("*РЕЗУЛЬТАТ:                                                               *");
            Console.WriteLine("***");

            Console.WriteLine(ds.Calculate());

            Console.ReadLine();

        }
    }
}
