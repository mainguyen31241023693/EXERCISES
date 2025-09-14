using System;
using static System.Net.Mime.MediaTypeNames;
namespace Exercise_04
    {
    class Câu_1
    {
        public static void Main(string[] args)
        {
            int max = soLonNhat(25, 70, 64);
            Console.WriteLine($"So lon nhat trong 3 so la: {max}");
            int maxVarArg = timSoLonNhat(55, 30, 80, 10, 20, 5, 65);
            Console.WriteLine($"So lon nhat trong cac so la: {maxVarArg}");
        }   
        //Write a C# function to find the largest number of the three numbers.
         static int soLonNhat(int soThuNhat, int soThuHai, int soThuBa)
        {
            int max = soThuNhat;
            if (soThuHai > max)
            { 
                max = soThuHai;
            }
            if (soThuBa > max)
            {
                max = soThuBa;
            }
            return max;
        }
        //Improve the next version that accept at least 1 parameter. (varArg)
        static int timSoLonNhat(params int[] numb)
        {
            if (numb.Length == 0)
            {
                throw new ArgumentException("Yeu cau can co it nhat mot so");
            }
            int max = numb[0];
            foreach (int n in numb)
            {
                if (n > max)
                {
                    max = n;
                }
            }
            return max;
        }
    }
}