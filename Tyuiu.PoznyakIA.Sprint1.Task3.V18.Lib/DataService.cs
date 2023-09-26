using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.PoznyakIA.Sprint1.Task3.V9.Lib
{
    public class DataService : ISprint1Task3V9
    {
        public double Calculate()
        {
           return (150 / 60) + (150 % 60) / 100.0;
        }
    }
}
