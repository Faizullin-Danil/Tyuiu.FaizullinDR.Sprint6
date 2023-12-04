using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.FaizullinDR.Sprint6.Task4.V20.Lib
{
    public class DataService : ISprint6Task4V20
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] arr = new double[stopValue - startValue + 1];
            int i = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                arr[i] = Math.Round((Math.Sin(x) - 2 * x) / (3 * x - 1) + Math.Sin(x) - 3 * x + 2,2);
                i++;
            }
            return arr;
        }
    }
}
