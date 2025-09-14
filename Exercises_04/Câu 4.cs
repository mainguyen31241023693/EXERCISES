using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_04
{
    internal class Câu_4
    {
        public static void Main(string[] args)
        {
            int num;
            Console.Write("Nhap mot so: ");
            string inp_num = Console.ReadLine();
            while (!int.TryParse(inp_num, out num) || num <= 0)
            {
                Console.WriteLine("Vui long nhap lai mot so nguyen duong. ");
                Console.Write("Nhap lai: ");
                inp_num = Console.ReadLine();
            }
            Console.Write($"Cac so nguyen to nho hon {num} la: ");
            inSoNguyenTo(num);
            Console.Write($"{num} so nguyen to dau tien la: ");
            inNSoNguyenToDauTien(num);
        }
        static bool kiemTraSoNguyenTo(long num)
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
        //Write a C# function to print all prime numbers that less than a number (enter prompt keyboard).
        static void inSoNguyenTo(long num)
        {
            
            for (int i = 2; i < num; i++)
            {
                if (kiemTraSoNguyenTo(i))
                {
                    Console.Write(i + ",");
                }
            }
            Console.WriteLine();
        }
        //Write a C# function to print the first N prime numbers
        static void inNSoNguyenToDauTien(int n)
        {
            int dem = 0;
            long num = 2; 
            while (dem <= n)
            {
                if (kiemTraSoNguyenTo(num))
                {
                    Console.Write(num + ",");
                    dem++;
                }
                num++;
            }
            Console.WriteLine();
        }
    }
}
