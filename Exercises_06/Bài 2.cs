using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises_06
{
    internal class Bài_2
    {
        static void Main()
        {
            gen_arr();
            while (true)
            {
                Console.WriteLine("\t\tMENU");
                Console.WriteLine("1. In ra thong tin tat ca cac thanh vien");
                Console.WriteLine("2. In ra thong tin cua thanh vien khi biet ID ");
                Console.WriteLine("3. In ra thanh vien hoan thanh nhieu nhiem vu nhat");
                Console.WriteLine("4. Thoat");
                Console.Write("Ban chon tac vu nao? (1/2/3/4)\t");
                Console.Write("Ban chon: ");
                string input_choice = Console.ReadLine();
                int choice;
                while (!int.TryParse(input_choice, out choice) || choice < 1 || choice > 4)
                {
                    Console.WriteLine("Vui long nhap so hop le (1/2/3/4). ");
                    Console.Write("Nhap lai: ");
                    input_choice = Console.ReadLine();
                }

                switch (choice)
                {
                    case 1:
                        print_all_members();
                        break;
                    case 2:
                        Console.Write("Nhap vao ID: ");
                        string id = Console.ReadLine();
                        print_member_id(id);
                        break;
                    case 3:
                        print_max_task_member();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Tac vu khong hop le");
                        break;
                }
                Console.WriteLine("Ban co muon tiep tuc khong? (Y/N)");
                Console.Write("Cau tra loi cua ban: ");
                string rep = Console.ReadLine();
                while (rep.ToLower() != "y" && rep.ToLower() != "n")
                {
                    Console.WriteLine("Vui long nhap Y hoac N");
                    rep = Console.ReadLine();
                }
                if (rep.ToLower() == "n")
                    break;
            }
        }
        static string[][][] a;
        // 1. Tao mang luu thong tin cac thanh vien
        static void gen_arr()
        {
            a = new string[3][][];
            // Nhom 1: 5 thanh vien
            a[0] = new string[5][];
            a[0][0] = new string[] { "101", "A", "12" };
            a[0][1] = new string[] { "102", "B", "18" };
            a[0][2] = new string[] { "103", "C", "15" };
            a[0][3] = new string[] { "104", "D", "10" };
            a[0][4] = new string[] { "105", "E", "19" };
            // Nhom 2: 3 thanh vien
            a[1] = new string[3][];
            a[1][0] = new string[] { "201", "F", "27" };
            a[1][1] = new string[] { "202", "G", "21" };
            a[1][2] = new string[] { "203", "H", "23" };
            // Nhom 3: 6 thanh vien
            a[2] = new string[6][];
            a[2][0] = new string[] { "301", "I", "4" };
            a[2][1] = new string[] { "302", "J", "6" };
            a[2][2] = new string[] { "303", "K", "8" };
            a[2][3] = new string[] { "304", "L", "16" };
            a[2][4] = new string[] { "305", "M", "19" };
            a[2][5] = new string[] { "306", "N", "20" };
        }
        /// <summary>
        /// 2. In danh sach tat ca cac thanh vien
        /// </summary>
        static void print_all_members()
        {
            Console.WriteLine("\n--- Tat ca cac thanh vien ---");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine($"Nhom {i + 1}:");
                for (int j= 0; j < a[i].Length; j++)
                {
                    Console.WriteLine($"ID: {a[i][j][0]}, Ten: {a[i][j][1]}, Nhiem vu da hoan thanh: {a[i][j][2]}");
                }
            }
        }
        /// <summary>
        /// 3. In thong tin thanh vien khi biet ID
        /// </summary>
        /// <param name="id">so ID cua thanh vien</param>
        static void print_member_id(string id)
        {
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    if (a[i][j][0].ToLower() == id.ToLower())
                    {
                        Console.WriteLine($"ID: {a[i][j][0]}, Ten: {a[i][j][1]}, Nhiem vu da hoan thanh: {a[i][j][2]}");
                        return;
                    }
                }
            }
            Console.WriteLine($"Khong tim thay thanh vien voi ID {id}");
        }
        /// <summary>
        /// 4. In thanh vien hoan thanh nhieu nhiem vu nhat
        /// </summary>
        static void print_max_task_member()
        {
            string[] max = a[0][0];
            int max_tasks = int.Parse(max[2]);
            for (int i = 0; i < a.Length; i++)
            {
                for (int j = 0; j < a[i].Length; j++)
                {
                    int tasks = int.Parse(a[i][j][2]);
                    if (tasks > max_tasks)
                    {
                        max_tasks = tasks;
                        max = a[i][j];
                    }
                }
            }
            Console.WriteLine("Thanh vien hoan thanh nhieu nhiem vu nhat la: ");
            Console.WriteLine($"ID: {max[0]}, Ten: {max[1]}, Nhiem vu da hoan thanh: {max[2]}");
        }
    }
}

