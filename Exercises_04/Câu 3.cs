using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_04
{
    internal class Câu_3
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap mot so: ");
            string inp_num = Console.ReadLine();
            int num;
            while (!int.TryParse(inp_num, out num))
            {
                Console.WriteLine("Vui long nhap lai mot so. ");
                Console.Write("Nhap lai: ");
                inp_num = Console.ReadLine();
            }
            bool ketQua = kiemTraSoNguyenTo(num);
            if (ketQua)
            {
                Console.WriteLine($"{num} la so nguyen to.");
            }
            else
            {
                Console.WriteLine($"{num} khong phai la so nguyen to.");
            }
        }
        //Write a C# function that takes a number as a parameter and checks whether the number is prime or not.
        static bool kiemTraSoNguyenTo(int num)
        {
            if (num <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
