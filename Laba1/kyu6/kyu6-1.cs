using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProg
{
    internal class kyu6_1
    {
        //Вам будет дано число, и вам нужно будет вернуть его в виде строки в расширенной форме. Например:
        // 12 --> "10 + 2"; 70304 --> "70000 + 300 + 4"
        public static string ExpandedForm(long num)
        {
            string result = "";
            int[] mass = new int[num.ToString().Length];
            for (int i = 0; i < mass.Length; i++)
            {
                mass[i] = (int)(num % 10);
                num /= 10;
            }
            for (int i = mass.Length - 1; i >= 0; i--)
            {
                if (mass[i] != 0)
                {
                    result += mass[i].ToString();
                    for (int j = i; j > 0; j--)
                    {
                        result += "0";
                    }
                    result += " + ";
                }
            }
            if (result.EndsWith(" + "))
            {
                result = result.Substring(0, result.Length - 3);
            }
            return result;
        }

    }
}
