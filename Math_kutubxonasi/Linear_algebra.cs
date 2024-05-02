using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math_kutubxonasi
{
    internal class Linear_algebra: Math_lib
    {
        public double[,] AddMatrix(double[,] matrix1, double[,] matrix2)
        {
            int n = matrix1.GetLength(0), m = matrix1.GetLength(1);
            var answer = matrix1;
            for (int i = 0; i < n; i ++)
                for (int j = 0; j < m; j ++)
                    answer[i,j] += matrix2[i, j];
            
            return answer;
        }
    }
}
