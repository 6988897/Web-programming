using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProg
{
    public class Intervals
    {
        //Напишите функцию, которая принимает массив интервалов и возвращает сумму длин интервалов.
        public static int SumIntervals((int, int)[] intervals)
        {
            if (intervals.Length == 0) return 0;

           
            var sortedIntervals = intervals.OrderBy(interval => interval.Item1).ToList();

            int totalLength = 0;
            int currentStart = sortedIntervals[0].Item1;
            int currentEnd = sortedIntervals[0].Item2;

            foreach (var interval in sortedIntervals)
            {
                if (interval.Item1 <= currentEnd)
                {
                   
                    currentEnd = Math.Max(currentEnd, interval.Item2);
                }
                else
                {
                    totalLength += currentEnd - currentStart;
                    currentStart = interval.Item1;
                    currentEnd = interval.Item2;
                }
            }
            
            totalLength += currentEnd - currentStart;
            return totalLength;
        }
    }
}
