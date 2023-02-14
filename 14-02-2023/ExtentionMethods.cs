using System;
using System.Collections.Generic;
using System.Text;

namespace _14_02_2023
{
    internal static class ExtentionMethods
    {
        public static string ToCapitalize(this string str)
        {
            string newStr = Char.ToUpper(str[0]) + str.Substring(1).ToLower();
            return newStr;
        }


        public static bool IsEven(this int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public static bool Odd(this int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public static bool IsContainsDigit(this string str)
        {
            if (str == null) return false;
            foreach (var cr in str)
            {
                if (char.IsDigit(cr))
                {
                    return true;
                }
            }
            return false;
        }

        //public static int[] GetValueIndexes(this string str, char cr)
        //{
        //    int[] arr = new int[0];
        //    if (true)
        //    {

        //    }
        //}
    }
}
