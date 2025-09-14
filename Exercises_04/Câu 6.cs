using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_04
{
    internal class Câu_6
    {
        public static void Main(string[] args)
        {
            string s = "The quick brown fox jumps over the lazy dog";
            bool ketQua = kiemTraPangram(s);
            if (ketQua)
              {
                  Console.WriteLine($"\"{s}\" la mot pangram.");
              }
            else
              {
                  Console.WriteLine($"\"{s}\" khong phai la mot pangram.");
              }
        }
        //Write a C# function to check whether a string is a pangram or not.
        static bool kiemTraPangram(string s)
        {
            string alp = " ";
            for (int i = 'a'; i <= 'z'; i++)
            {
                alp += (char)i;
            }
            s=s.ToLower();
            foreach (char c in alp)
            {
                if (!s.Contains(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
