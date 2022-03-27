using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTestsTasks
{
    public class Kata
    {
        
        public static string Battle(string x, string y)
        {
            string[] Alphabet = { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            int resultOfX=0;
            int resultOfY=0;
            for (int i = 0; i < x.Length; i++)
            {
                resultOfX += Array.IndexOf(Alphabet, x[i].ToString());
            }

            for (int i = 0; i < y.Length; i++)
            {
                resultOfY += Array.IndexOf(Alphabet, y[i].ToString());
            }

            if (resultOfX > resultOfY)
            {
                return x;
            }
            if (resultOfX < resultOfY)
            {
                return y;
            }
            if (resultOfX == resultOfY)
            {
                return "Tie!";
            }

            return "X";

        }
    }
}
