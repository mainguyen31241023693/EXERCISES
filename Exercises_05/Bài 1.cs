using System;
using System.ComponentModel.DataAnnotations;
internal class Bài_01
{
    public static void Main(string[] args)
    {
        // Tao mang
        Console.Write("Nhap vao so phan tu cua mang: ");
        string input_n = Console.ReadLine();
        int n;
        while (!int.TryParse(input_n, out n))
        {
            Console.WriteLine("Vui long nhap lai 1 so hop le. ");
            Console.Write("Nhap lai:  ");
            input_n = Console.ReadLine();
        }
        Random rnd = new Random();
        int[] a = new int[n];
        for (int i = 0; i < n; i++)
        {
            a[i] = rnd.Next(1, 100)+1;
            Console.Write(a[i] + " ");
        }
        Console.WriteLine();
        // 1.Tinh trung binh cong cua mang
        float avr;
        avr = trungBinh(a, n);
        Console.WriteLine($"Trung binh cong cua mang la: {avr}");
        // 2.Kiem tra mot gia tri co ton tai trong mang hay khong
        Console.Write("Nhap vao mot gia tri: ");
        int value = Convert.ToInt32(Console.ReadLine());
        if (kiemTraPhanTu(a, value))
        {
            Console.WriteLine($"Gia tri {value} co ton tai trong mang");
        }
        else
        {
            Console.WriteLine($"Gia tri {value} khong ton tai trong mang");
        }
        // 3.Tim chi so cua mot phan tu trong mang
        Console.Write("Nhap vao mot phan tu cua mang: ");
        string input_element = Console.ReadLine();
        int element;
        while (!int.TryParse(input_element, out element))
        {
            Console.WriteLine("Vui long nhap lai 1 so hop le. ");
            Console.Write("Nhap lai:  ");
            input_element = Console.ReadLine();
        }
        int index = timChiSoPhanTu(a, element);
        if (index == -1)
        {
            Console.WriteLine($"Khong tim thay phan tu {element} trong mang");
        }
        else
        {
            Console.WriteLine($"Phan tu {element} xuat hien o vi tri {index} trong mang");
        }
        // 4.Xoa mot phan tu khoi mang
        Console.Write("Nhap vao phan tu can xoa: ");
        string input_remove_value = Console.ReadLine();
        int remove_value;
        while (!int.TryParse(input_remove_value, out remove_value))
        {
            Console.WriteLine("Vui long nhap lai 1 so hop le. ");
            Console.Write("Nhap lai:  ");
            input_remove_value = Console.ReadLine();
        }
        xoaPhanTu(a, remove_value, ref n);
        Console.WriteLine("Mang sau khi xoa phan tu:");
        printArray(a, n);
        // 5.Tim gia tri lon nhat va nho nhat trong mang
        timMaxMin(a);
        // 6. Dao nguoc mang cac gia tri nguyen
        daoNguocMang(a,n);
        Console.WriteLine("Mang sau khi dao nguoc:");
        printArray(a, n);
        // 7.Tim cac gia tri trung nhau trong mang
        Console.Write("Cac gia tri trung nhau trong mang la: ");
        timGiaTriTrung(a, n);
        // 8.Xoa cac gia tri trung nhau trong mang
        Console.WriteLine("Mang sau khi xoa cac gia tri trung nhau:");
        xoaGiaTriTrung(a, ref n);
        printArray(a, n);
        Console.ReadLine();
    }
    static void printArray(int[] a,int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write(a[i] + " ");
        }
        Console.WriteLine();
    }
    /// <summary>
    /// 1.Tinh trung binh cong cua mang
    /// </summary>
    /// <param name="a">mang cac gia tri</param>
    /// <param name="n">so phan tu cua mang</param>
    /// <returns>gia tri trung binh cua tong cac phan tu trong mang</returns>
    static float trungBinh (int[] a, int n)
    {
        float tong = 0f;
        for (int i = 0; i < n; i++)
        {
            tong = tong + a[i];
        }
        float avr;
        avr = tong / n;
        return avr;
    }
    /// <summary>
    /// 2.Kiem tra mot gia tri co ton tai trong mang hay khong
    /// </summary>
    /// <param name="a">mang cac gia tri</param>
    /// <param name="value">gia tri cu the muon kiem tra</param>
    /// <returns>tra ve true neu gia tri muon kiem tra co trong mang va nguoc lai</returns>
    static bool kiemTraPhanTu (int[] a, int value)
    {
       
        for (int i =0; i <a.Length; i ++)
        {
            if (a[i] == value)
            {
                return true;
            }
        }
        return false;
    }
    /// <summary>
    /// 3.Tim chi so cua mot phan tu trong mang
    /// </summary>
    /// <param name="a">mang cac gia tri</param>
    /// <param name="element">gia tri can tim</param>
    /// <returns>vi tri xuat hien cua phan tu can tim hoac -1 neu khong tim thay</returns>
    static int timChiSoPhanTu(int[] a, int element)
    {
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] == element)
            {
                return i;
            }
        }
        return -1;
    }
    /// <summary>
    /// 4.Xoa mot phan tu khoi mang
    /// </summary>
    /// <param name="a">mang cac gia tri</param>
    /// <param name="remove_value">phan tu can xoa</param>
    /// <param name="n">so luong phan tu cua mang</param>
    static void xoaPhanTu(int[] a, int remove_value, ref int n)
        {
        //int n = a.Length;
        for (int i = 0; i < n; i++)
        {
            if (a[i] == remove_value)
            {
                for (int j = i; j < n - 1; j++)
                {
                    a[j] = a[j + 1];
                }
            }
        }
        n--;
    }
    /// <summary>
    /// 5.Tim gia tri lon nhat va nho nhat trong mang
    /// </summary>
    /// <param name="a">mang cac gia tri</param>
    /// <returns>giá tri lon nhat va gia tri nho nhat</returns>
    static (int,int) timMaxMin(int[] a)
    {
        int max = a[0];
        int min= a[0];
        for (int i = 1; i < a.Length; i++)
        {
            if (a[i] > max)
            {
                max = a[i];
            }
            if (a[i] < min)
            {
                min = a[i];
            }
        }
        Console.WriteLine($"Gia tri lon nhat cua mang: {max}");
        Console.WriteLine($"Gia tri nho nhat cua mang: {min}");
        return ( max, min);
    }
    /// <summary>
    /// 6. Dao nguoc mang cac gia tri nguyen
    /// </summary>
    /// <param name="a">mang cac gia tri</param>
    /// <param name="n">so luong phan tu cua mang</param>
    static void daoNguocMang(int[] a, int n)
    {
        for (int i = 0; i < n / 2; i++)
        {
            int temp = a[i];
            a[i] = a[n - i - 1];
            a[n - i - 1] = temp;
        }
    }
    /// <summary>
    /// 7.Tim cac gia tri trung nhau trong mang
    /// </summary>
    /// <param name="a">mang cac gia tri</param>
    /// <param name="n">so luong phan tu trong mang</param>
    static void timGiaTriTrung(int[] a, int n)
    {
        
        bool found = false;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (a[i] == a[j])
                {
                    Console.Write(a[i] + " ");
                    found = true;
                    break;
                }
            }
        }
        if (!found)
        {
            Console.Write("Khong co. ");
        }
        Console.WriteLine();
    }
    /// <summary>
    /// 8.Xoa cac gia tri trung nhau trong mang
    /// </summary>
    /// <param name="a">mang cac gia tri</param>
    /// <param name="n">so luong phan tu cua mang</param>
    static void xoaGiaTriTrung(int[] a, ref int n)
    {
        bool found = false;
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (a[i] == a[j])
                {
                    found = true;
                    for (int k = j; k < n - 1; k++)
                    {
                        a[k] = a[k + 1];
                    }
                    n--;
                    j--;
                }
            }
        }
        if (!found)
        {
            Console.Write("Khong co gia tri trung nhau de xoa. ");
            Console.WriteLine();
        }
    }
}
