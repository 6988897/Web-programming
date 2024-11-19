using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebProg
{
    public class HumanTimeFormat
    {
        //Функция должна принимать неотрицательное целое число.
        //Если оно равно нулю, функция просто возвращает "now".
        //В противном случае продолжительность выражается комбинацией years,
        //days, hours, minutes и seconds.
        public static string FormatDuration(int seconds)
        {
            if (seconds == 0) return "now";

            int years = seconds / (365 * 24 * 3600);
            seconds %= 365 * 24 * 3600;
            int days = seconds / (24 * 3600);
            seconds %= 24 * 3600;
            int hours = seconds / 3600;
            seconds %= 3600;
            int minutes = seconds / 60;
            seconds %= 60;

            string result = "";

            if (years > 0) result += years + " year" + (years > 1 ? "s" : "") + ", ";
            if (days > 0) result += days + " day" + (days > 1 ? "s" : "") + ", ";
            if (hours > 0) result += hours + " hour" + (hours > 1 ? "s" : "") + ", ";
            if (minutes > 0) result += minutes + " minute" + (minutes > 1 ? "s" : "") + ", ";
            if (seconds > 0) result += seconds + " second" + (seconds > 1 ? "s" : "") + ", ";

            if (result.EndsWith(", ")) result = result.Substring(0, result.Length - 2);

            int lastCommaIndex = result.LastIndexOf(", ");
            if (lastCommaIndex != -1)
            {
                result = result.Substring(0, lastCommaIndex) + " and" + result.Substring(lastCommaIndex + 1);
            }

            return result;
        }
    }
}
