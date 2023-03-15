using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Practica03.Utils.Extensions
{
    public static class StringExtensions
    {
        public static bool IsText(this string text)
        {
            bool result;
            result = (Regex.IsMatch(text, @"^[a-zA-Z/\s]*$"))? true:false;  
            return result;
        }

        public static bool IsDigit(this string text)
        {
            bool result;
            result = (Regex.IsMatch(text, "^[0-9]{1}$")) ? true : false;
            return result;
        }

    }
}
