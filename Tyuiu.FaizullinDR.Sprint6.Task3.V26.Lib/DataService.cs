using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.FaizullinDR.Sprint6.Task3.V26.Lib
{
    public class DataService : ISprint6Task3V26
    {
        public int[,] Calculate(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if ((i == 2) && (matrix[i, j] % 2 == 0))
                        matrix[i, j] = 0;
                }
            }
            return matrix;
        }
    }
}
