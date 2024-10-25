using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProg
{
    internal class Kyu7_3
    {
        //В этой задаче вам нужно возвести в квадрат каждую цифру числа и объединить их.
        //Например, если мы пропустим 9119 через функцию, получится 811181,
        //потому что 92 — это 81, а 12 — это 1. (81-1-1-81)
        public static int SquareDigits(int n)
        {
            string rersult = "";
            foreach (char v in n.ToString())
            {
                int temp = int.Parse(v.ToString());
                rersult += (temp * temp).ToString();
            }
            return int.Parse(rersult);

        }
    }
}
