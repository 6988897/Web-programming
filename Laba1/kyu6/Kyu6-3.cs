using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProg
{
    internal class Kyu6_3
    {
        public static int DigitalRoot(long n)
        {
            if (n < 10)
            {
                return Convert.ToInt32(n);
            }

            int sum = 0;
            while (n > 0)
            {
                sum += Convert.ToInt32(n % 10);
                n /= 10;
            }

            return DigitalRoot(sum);
        }
    }
}
