using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.FaizullinDR.Sprint6.Task1.V14.Lib
{
    public class DataService : ISprint6Task1V14
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] res = new double[stopValue - startValue + 1];
            int x = -5;
            for (int i = 0; i <= res.Length-1; i++)
            {
                res[i] = Math.Round((2 * x + 6) / (Math.Cos(x) + x) - 3,2);
                x++;
            }
            return res;
        }
    }
}
