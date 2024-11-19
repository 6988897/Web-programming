using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProg
{
    public class SnailSolution
    {
        // Учитывая массив n x n , верните элементы массива, расположенные от крайних элементов
        // к среднему элементу по часовой стрелке.
        public static int[] Snail(int[][] array)
        {
            if (array.Length == 0 || array[0].Length == 0)
            {
                return new int[0];
            }

            int n = array.Length;
            int[] result = new int[n * n];
            int index = 0;
            int top = 0, bottom = n - 1, left = 0, right = n - 1;

            while (top <= bottom && left <= right)
            {
                for (int i = left; i <= right; i++)
                {
                    result[index++] = array[top][i];
                }
                top++;

                for (int i = top; i <= bottom; i++)
                {
                    result[index++] = array[i][right];
                }
                right--;

                if (top <= bottom)
                {
                    for (int i = right; i >= left; i--)
                    {
                        result[index++] = array[bottom][i];
                    }
                    bottom--;
                }

                if (left <= right)
                {
                    for (int i = bottom; i >= top; i--)
                    {
                        result[index++] = array[i][left];
                    }
                    left++;
                }
            }

            return result;
        }
    }
}
