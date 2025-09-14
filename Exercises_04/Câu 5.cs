using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_04
{
    internal class Câu_5
    {
        public static void Main(string[] args)
        {
            Console.Write("So hoan hao nho hon 1000 la: ");   
            inSoHoanHao(1000);
        }
        //Write a C# function to check whether a number is "Perfect" or not. Then print all perfect number that less than 1000.
        static bool kiemTraSoHoanHao(int num)
        {
            int tong = 0;
            for (int i = 1; i <= num / 2; i++)
            {
                if (num % i == 0)
                {
                    tong += i;
                }
            }
            return tong == num;
        }
        static void inSoHoanHao(int n)
        {
            for (int i = 1; i < n; i++)
            {
                if (kiemTraSoHoanHao(i))
                {
                    Console.Write(i + " ");
                }
            }
            Console.WriteLine();
        }
    }
}
