using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProg
{
    internal class Kyu6_2
    {
        public static int Solve(string s)
        {
            Dictionary<char, int> alphabet = new Dictionary<char, int>();
            for (int i = 0; i < 26; i++)
            {
                alphabet[(char)('a' + i)] = i + 1;
            }

            int sum = 0;
            int max = 0;

            foreach (char c in s)
            {
                if (!"aeiou".Contains(c))
                {
                    sum += alphabet[c];
                    if (sum > max)
                    {
                        max = sum;
                    }
                }
                else
                {
                  sum = 0;
                }
            }

            return max;
        }
    }
}
