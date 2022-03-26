using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestsTasks
{
    public class TwoToOne
    {
        public static string Longest(string s1, string s2)
        {
            string newVariable;
            if (s1.Length > s2.Length)
            {
                newVariable = s1;
            }
            else newVariable = s2;

            char[] tempArray = newVariable.ToCharArray();

            Array.Sort(tempArray);

            return new string(tempArray);
            // Sorting code from internet, didn't know how to do that
            // But Tests didn't pass it
        }
    }
}
