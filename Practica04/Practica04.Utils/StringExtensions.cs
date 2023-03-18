using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practica04.Utils
{
    public static class StringExtensions
    {
        public static bool IsText(this string text)
        {
            bool result;
            result = (Regex.IsMatch(text, "^[a-zA-Z]*$"))? true:false;  
            return result;
        }

        public static bool IsNum(this string text, int numStart, int numEnd )
        {
            bool result=false;
            if (Regex.IsMatch(text,"^[0-9]+$"))
            {
                int num = Convert.ToInt32(text);
                if (num>=numStart && num <= numEnd) result = true;
            }
            return result;
        }

    }
}
