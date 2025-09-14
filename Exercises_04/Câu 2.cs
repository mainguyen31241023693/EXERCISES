using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_04
{
    internal class Câu_2
    {
        public static void Main(string[] args)
        {
            Console.Write("Nhap mot so nguyen khong am: ");
            string inp_num = Console.ReadLine();
            int num;
            while (!int.TryParse(inp_num, out num) || num < 0)
            {
                Console.WriteLine("Vui long nhap lai mot so nguyen khong am. ");
                Console.Write("Nhap lai: ");
                inp_num = Console.ReadLine();
            }
            long ketQua = giaiThua(num);
            Console.WriteLine($"Giai thua cua {num} la: {ketQua}");
        }
        //Write a C# function to calculate the factorial of a number (a non-negative integer).
        static long giaiThua(int num)
        {
                long ketQua = 1;
                for (int i = 1; i <= num; i++)
                    ketQua *= i;
                return ketQua;
        }
    }
}
