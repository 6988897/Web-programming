using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProg
{
    internal class Kyu7_1
    {
        //Реализуйте функцию, которая принимает два числа m и n и возвращает массив
        //первых m кратных вещественного числа n. Предположим,
        //что m — это положительное целое число.
        public static double[] Multiples(int m, double n)
        {

            double[] results = new double[m];
            for (int i = 0; i < m; i++)
            {
                results[i] = n * (i + 1);
            }

            return results;
        }
    }
}
