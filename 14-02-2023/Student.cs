using System;
using System.Collections.Generic;
using System.Text;

namespace _14_02_2023
{
    internal class Student
    {
        public string FullName;
        public string GroupNo;
        public int Age;

        public static bool CheckGroupNo(string no)
        {
            if (no != null)
            {
                if (no.Length == 4)
                {
                    if (char.IsUpper(no[0]) && char.IsDigit(no[1]) && char.IsDigit(no[2]) && char.IsDigit(no[3]))
                        return true;


                }

            }
            return false;
        }

        //public static bool CheckFullName(string fullName)
        //{
        //    if (fullName != null)
        //    {

        //    }
        //}

        
    }
}
