using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WebProg
{
    internal class Kyu7_2
    {
        //Ваша задача — написать функцию, которая принимает строку
        //и возвращает новую строку без гласных.
        public static string Disemvowel(string str)
        {
            string pattern = "[aeiouAEIOU]";
            str = Regex.Replace(str, pattern, "");
            return str;
        }
    }
}
