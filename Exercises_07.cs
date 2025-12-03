using System;
namespace EX07
{
    internal class mutilarr
    {
        static void Main(string[] args)
        {
            ex1();
            ex2();
            ex3();
            ex4();
            ex5();
            ex6();
            ex7();
            ex8();
            ex9();
            ex10();
        }
        
        //1. Write a program in C# Sharp for a 2D array of size 3x3 and print the matrix.
        static void ex1()
        {
            int[,] a1 = new int[3, 3];
            for (int i=0; i<a1.GetLength(0); i++)
                {
                for (int j=0; j<a1.GetLength(1); j++)
                    {
                    Console.WriteLine($"a[{i},{j}] = ");
                    a1[i, j] = int.Parse(Console.ReadLine());
                    }
                }
            for (int i = 0; i < a1.GetLength(0); i++)
            {
                 for (int j = 0; j < a1.GetLength(1); j++)
                 {
                    Console.Write(a1[i, j] + " ");
                 }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        //2. Write a C# Sharp program for adding two matrices of the same size
        static void ex2()
        {
            Console.Write("Nhap kich thuoc ma tran vuong: ");
            string input_n = Console.ReadLine();
            int n;
            while (!int.TryParse(input_n, out n) || n>=5)
            {
                Console.Write( "Nhap lai: ");
                input_n = Console.ReadLine();
            }
            int[,] a = new int[n, n];
            Console.WriteLine("Nhap Mang 1");
            for (int i=0; i<a.GetLength(0); i++)
            {
                for (int j=0; j<a.GetLength(1);j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }    
            }
            Console.WriteLine("Mang 1");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i,j]}"+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Nhap Mang 2");
            int[,] b = new int[n, n];
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write($"b[{i},{j}] = ");
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Mang 2");
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write($"{b[i, j]}" + " ");
                }
                Console.WriteLine();
            }
            int[,] c = new int[n, n];
            for (int i=0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    c[i,j] = a[i, j] + b[i,j];
                }

            }
            Console.WriteLine("Mang 3");
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    Console.Write( c[i, j] +" ");
                }
                Console.WriteLine();
            }
        }
        //3. Write a C# Sharp program for the subtraction of two matrixes.
        static void ex3()
        {
            Console.Write("Nhap kich thuoc ma tran vuong: ");
            string input_n = Console.ReadLine();
            int n;
            while (!int.TryParse(input_n, out n) || n >= 5)
            {
                Console.Write("Nhap lai: ");
                input_n = Console.ReadLine();
            }
            int[,] a = new int[n, n];
            Console.WriteLine("Nhap Mang 1");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Mang 1");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]}" + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Nhap Mang 2");
            int[,] b = new int[n, n];
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write($"b[{i},{j}] = ");
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Mang 2");
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write($"{b[i, j]}" + " ");
                }
                Console.WriteLine();
            }
            int[,] c = new int[n, n];
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    c[i, j] = a[i, j] - b[i, j];
                }

            }
            Console.WriteLine("Mang 3");
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        //4. Write a C# Sharp program for multiplication of two square matrices.
        static void ex4()
        {
            Console.Write("Nhap kich thuoc ma tran vuong: ");
            string input_n = Console.ReadLine();
            int n;
            while (!int.TryParse(input_n, out n) || n >= 5)
            {
                Console.Write("Nhap lai: ");
                input_n = Console.ReadLine();
            }
            int[,] a = new int[n, n];
            Console.WriteLine("Nhap Mang 1");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Mang 1");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]}" + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Nhap Mang 2");
            int[,] b = new int[n, n];
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write($"b[{i},{j}] = ");
                    b[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Mang 2");
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Console.Write($"{b[i, j]}" + " ");
                }
                Console.WriteLine();
            }
            int[,] c = new int[n, n];
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    c[i, j] = 0;
                    for (int k = 0; k < n; k++)
                    {
                        c[i, j] += a[i, k] * b[k, j];
                    }
                }

            }
            Console.WriteLine("Mang 3");
            for (int i = 0; i < c.GetLength(0); i++)
            {
                for (int j = 0; j < c.GetLength(1); j++)
                {
                    Console.Write(c[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        //5. Write a C# Sharp program to find the transpose of a given matrix.
        static void ex5()
        {
            Console.Write("Nhap vao so dong cua ma tran: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so cot cua ma tran: ");
            int cols = int.Parse(Console.ReadLine());
            int[,] a = new int[rows, cols];
            for (int i=0; i<rows;i++)
            {
                for (int j=0;j<cols;j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine() );
                }    
            }
            Console.WriteLine("Mang truoc khi chuyen vi.");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(a[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Mang sau khi chuyen vi.");
            for (int i=0; i< cols;i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(a[j,i]+" ");
                } 
                Console.WriteLine();
            }    
        }
        //6. Write a C# Sharp program to find the sum of the right diagonals of a matrix.
        static void ex6()
        {
            Console.Write("Nhap kich thuoc ma tran vuong: ");
            string input_n = Console.ReadLine();
            int n;
            while (!int.TryParse(input_n, out n))
            {
                Console.Write("Nhap lai: ");
                input_n = Console.ReadLine();
            }
            int[,] a = new int[n, n];
            Console.WriteLine("Nhap Mang");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Mang vua nhap");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{a[i, j]}" + " ");
                }
                Console.WriteLine();
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + a[i, n - 1 - i];
            }
            Console.WriteLine($"Tong duong cheo phu la: {sum}");
        }
        //7. Write a C# Sharp program to find the sum of the left diagonals of a matrix.
        static void ex7()
        {
            Console.Write("Nhap kich thuoc ma tran vuong: ");
            string input_n = Console.ReadLine();
            int n;
            while (!int.TryParse(input_n, out n))
            {
                Console.Write("Nhap lai: ");
                input_n = Console.ReadLine();
            }
            int[,] a = new int[n, n];
            Console.WriteLine("Nhap Mang");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Mang vua nhap");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"{a[i, j]}" + " ");
                }
                Console.WriteLine();
            }
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                sum = sum + a[i, i];
            }
            Console.WriteLine($"Tong duong cheo chinh la: {sum}");
        }
        //8. Write a C# Sharp program to find the sum of rows and columns in a matrix.
        static void ex8()
        {
            Console.Write("Nhap vao so dong cua ma tran: ");
            int rows = int.Parse(Console.ReadLine());
            Console.Write("Nhap vao so cot cua ma tran: ");
            int cols = int.Parse(Console.ReadLine());
            int[,] a = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Mang vua nhap.");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(a[i, j] + " ");
                    
                }
                Console.WriteLine();
            }
            int sumrows, sumcols;
            for (int i = 0; i < rows; i++)
            {
                sumrows = 0;
                for (int j = 0; j < cols; j++)
                {
                    sumrows=sumrows+a[i, j];
                }
                Console.WriteLine($"Tong hang {i} la: {sumrows} ");
            }
       
            for (int i=0;i<cols; i++)
            {
                sumcols = 0;
                for (int j=0; j< rows;j++)
                {
                    sumcols=sumcols+a[j,i];
                }
                Console.WriteLine($"Tong cot {i} la: {sumcols} ");
            }    
        }
        //9. Write a program in C# Sharp to print or display the lower triangular of a given matrix.
        static void ex9()
        {
            Console.Write("Nhap kich thuoc ma tran vuong: ");
            int n = int .Parse(Console.ReadLine());
            int[,] a = new int[n, n];
            Console.WriteLine("Nhap Mang.");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Mang vua nhap");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]}" + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Ma tran dang tam giac duoi.");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i>j)
                    {
                        a[i, j] = 0;
                        Console.Write($"{a[i, j]}" + " ");
                    }
                    else
                    {
                        Console.Write($"{a[i, j]}" + " ");
                    } 
                }
                Console.WriteLine();
            }
        }
        //10. Write a C# Sharp program to print or display an upper triangular matrix.
        static void ex10()
        {
            Console.Write("Nhap kich thuoc ma tran vuong: ");
            int n = int.Parse(Console.ReadLine());
            int[,] a = new int[n, n];
            Console.WriteLine("Nhap Mang.");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"a[{i},{j}] = ");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Mang vua nhap");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    Console.Write($"{a[i, j]}" + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Ma tran dang tam giac tren.");
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    if (i < j)
                    {
                        a[i, j] = 0;
                        Console.Write($"{a[i, j]}" + " ");
                    }
                    else
                    {
                        Console.Write($"{a[i, j]}" + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}