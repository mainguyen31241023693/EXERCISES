using System;
internal class Bài1
{
    public static void Main(string[] args)
    {
        // EX01
        ex01();
        // EX02
        // Tao mang jagged voi gia tri ngau nhien
        Console.Write("Nhap vao so dong cua mang: ");
        string input_rows = Console.ReadLine();
        int rows;
        while (!int.TryParse(input_rows, out rows) || rows <= 0)
        {
            Console.WriteLine("Vui long nhap so hop le. ");
            Console.Write("Nhap lai: ");
            input_rows = Console.ReadLine();
        }
        int[][] a = new int[rows][];
        for (int i =0; i<rows; i++)
        {
            Console.Write($"Nhap vao so cot cua dong thu {i}: ");
            string input_cols = Console.ReadLine();
            int cols;
            while (!int.TryParse(input_cols, out cols) || cols <= 0)
            {
                Console.WriteLine("Vui long nhap so hop le. ");
                Console.Write("Nhap lai: ");
                input_cols = Console.ReadLine();
            }
            a[i] = new int[cols];
        }
        gen_arr(a);
        Console.WriteLine("Mang duoc tao la: ");
        print_arr(a);
        // 1.Tim va in ra gia tri lon nhat cua tung dong va gia tri lon nhat cua mang
        print_largest_row_and_array(a);
        // 2.Sap xep tung dong cua mang
        Console.WriteLine("Mang sau khi sap xep theo tung dong");
        sort_each_row(a);
        // 3.In ra cac so nguyen to trong mang
        Console.Write("Cac so nguyen to co trong mang la: ");
        print_prime_number(a);
        // 4.Tim kiem mot so trong mang va in ra vi tri neu tim thay
        Console.Write("Nhap vao mot so bat ki de tim trong mang: ");
        string input_num = Console.ReadLine();
        int num;
        while (!int.TryParse(input_num, out num))
        {
            Console.WriteLine("Vui long nhap so hop le. ");
            Console.Write("Nhap lai: ");
            input_num = Console.ReadLine();
        }
        search_number(a, num);
    }
    /// <summary>
    /// Tao mang jagged theo yeu cau
    /// </summary>
    static void ex01()
    {
        int[][] a = new int[4][];
        a[0] = new int[5] { 1, 1, 1, 1, 1 };
        a[1] = new int[2] { 2, 2 };
        a[2] = new int[4] { 3, 3, 3, 3 };
        a[3] = new int[2] { 4, 4 };
        int rows = a.Length;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < a[i].Length; j++)
            {
                Console.Write(a[i][j] + " ");
            }
            Console.WriteLine();
        }
       
    }
    /// <summary>
    /// Tao mang jagged voi gia tri ngau nhien
    /// </summary>
    /// <param name="a">mang cac gia tri</param>
    static void gen_arr (int[][] a)
    {
        int rows = a.Length;
        Random rnd = new Random();
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < a[i].Length; j++)
            {
                a[i][j] = rnd.Next(1, 100);
            }
        }
    }
    /// <summary>
    /// In ra mang jagged
    /// </summary>
    /// <param name="a">mang cac gia tri</param>
    static void print_arr(int[][] a)
    {
        int rows = a.Length;
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < a[i].Length; j++)
            {
                Console.Write(a[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
    /// <summary>
    /// Tim va in ra gia tri lon nhat cua tung dong va gia tri lon nhat cua mang
    /// </summary>
    /// <param name="a">mang cac gia tri</param>
    static void print_largest_row_and_array(int[][] a)
    {
        
        int max_array = a[0][0];
        for (int i = 0; i < a.Length; i++)
        {
            int max_row = a[i][0];
            for (int j = 1; j < a[i].Length; j++)
            {
                
                if (a[i][j] > max_row)
                {
                    max_row = a[i][j];
                }
            }
            Console.WriteLine($"Gia tri lon nhat cua dong thu {i} la: {max_row}");
            if (max_row > max_array)
            {
                max_array = max_row ;
            }
        }
        Console.WriteLine($"Gia tri lon nhat cua mang la: {max_array}");
    }
    /// <summary>
    /// Sap xep tung dong cua mang
    /// </summary>
    /// <param name="a">mang cac gia tri</param>
    static void sort_each_row(int[][] a)
    {
        for (int i =0; i < a.Length ; i++) 
        {
            for (int j = 0; j < a[i].Length; j++)
            {
                for (int k = j + 1; k < a[i].Length; k++)
                {
                    if (a[i][j] > a[i][k])
                    {
                        int temp = a[i][j];
                        a[i][j] = a[i][k];
                        a[i][k] = temp;
                    }
                }
            }    
        } 
        print_arr(a);
    }
    /// <summary>
    /// Kiem tra so nguyen to
    /// </summary>
    /// <param name="num">so can kiem tra</param>
    /// <returns>tra ve true neu la so nguyen to va false neu khong phai</returns>
    static bool is_prime (int num)
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
    /// <summary>
    /// In ra cac so nguyen to trong mang
    /// </summary>
    /// <param name="a">mang cac gia tri</param>
    static void print_prime_number(int[][] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a[i].Length; j++)
            {
                if (is_prime(a[i][j]))
                {
                    Console.Write(a[i][j] +" ");
                }
            }
        }
        Console.WriteLine();
    }
    /// <summary>
    /// Tim kiem mot so trong mang va in ra vi tri neu tim thay
    /// </summary>
    /// <param name="a">mang cac gia tri</param>
    /// <param name="num">so can tim</param>
    static void search_number(int[][] a, int num)
    {
        bool found = false;
        for (int i = 0; i < a.Length; i++)
        {
            for (int j = 0; j < a[i].Length; j++)
            {
                if (a[i][j] == num)
                {   
                    Console.WriteLine($"So {num} xuat hien tai dong {i}, cot {j}");
                    found = true;
                }
            }
        }
        if (!found)
        {
            Console.WriteLine($"Khong tim thay so {num} trong mang");
        }
    }
}