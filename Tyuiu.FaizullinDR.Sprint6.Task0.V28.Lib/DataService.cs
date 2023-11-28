using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.FaizullinDR.Sprint6.Task0.V28.Lib
{
    public class DataService : ISprint6Task0V28
    {
        public double Calculate(int x)
        {
            return Math.Round(6.1 * Math.Pow(x, 3) + 0.23 * x * x + 1.04 * x, 3);
        }
    }
}
