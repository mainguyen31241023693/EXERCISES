using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_05
{
    internal class Bài_2
    {
        public static void Main(string[] args)
        {
            // Phan 1: Sap xep mang tang dan su dung thuat toan Bubble Sort
            int n = 10;
            int[] a = new int[n];
            Console.WriteLine($"Nhap vao {n} phan tu cua mang.");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhap vao phan tu thu {i}: ");
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Mang vua nhap la: ");
            print_arr(a, n);
            Console.WriteLine("Mang sau khi sap xep la: ");
            bubble_sort(a, n);
            print_arr(a, n);
            // Phan 2: Tim kiem tu trong cau bang thuat toan Linear Search
            Console.WriteLine("Nhap vao mot cau:");
            string s = Console.ReadLine();
            Console.WriteLine("Nhap vao mot tu can tim:");
            string search_word = Console.ReadLine();
            string[] str = s.Split(' ');
            int index = linear_search(str, search_word);
            if (index != -1)
            {
                Console.WriteLine($"Tu '{search_word}' xuat hien o vi tri thu {index} trong cau");
            }
            else
            {
                Console.WriteLine($"Khong tim thay tu '{search_word}' trong cau");
            }
        }
        /// <summary>
        /// In mang 
        /// </summary>
        /// <param name="a">mang cac phan tu</param>
        /// <param name="n">so luong phan tu cua mang</param>
        static void print_arr (int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
        /// <summary>
        /// 1. Sap xep mang tang dan su dung thuat toan Bubble Sort
        /// </summary>
        /// <param name="a">mang cac phan tu</param>
        /// <param name="n">so luong phan tu cua mang</param>
        static void bubble_sort(int[] a, int n)
        {
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (a[j] > a[j + 1])
                    {
                        int temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
                }
            }
        }
        /// <summary>
        /// 2. Tim kiem tu trong cau bang thuat toan Linear Search
        /// </summary>
        /// <param name="str">mang chua cac tu trong cau</param>
        /// <param name="element">tu can tim kiem</param>
        /// <returns>tra ve vi tri xuat hien trong cau neu co hoac -1 neu khong co</returns>
        static int linear_search(string [] str, string element)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i].ToLower() == element.ToLower())
                {
                    return i;
                }
            }
            return -1;
        }

    }
}
