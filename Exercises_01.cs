using System.Threading.Channels;

internal class Exercises01
{
    static void Main()
    {
        Ex01();
        Ex02();
        Ex03();
        Ex04();
        Ex05();
        Ex06();
        Ex07();
        Ex08();
        Ex09();
        Ex10();
    }
    /// <summary>
    /// 1. to Add/Sum Two Numbers
    /// </summary>
    static void Ex01()
    {
        int a = 5, b = 7;
        int c = a + b;
        Console.WriteLine("Ex01: Add/Sum Two Numbers");
        Console.WriteLine($"So thu nhat la: {a}");
        Console.WriteLine($"So thu hai la: {b}");
        Console.WriteLine($"Tong hai so la: {a} + {b} = {c}");
    }
    /// <summary>
    ///  to Swap Values of Two Variables
    /// </summary>
    static void Ex02()
    {
        int a = 5, b = 7;
        Console.WriteLine("Ex02: Swap Values of Two Variables");
        Console.WriteLine($"Truoc khi doi a = {a}, b = {b}");
        int tam = a;
        a = b;
        b = tam;
        Console.WriteLine($"Sau khi doi a = {a}, b = {b}");
    }
    /// <summary>
    ///  to Multiply two Floating Point Numbers
    /// </summary>
    static void Ex03()
    {
        float a = 4.8f, b = 5.6f;
        float c = a * b;
        Console.WriteLine("Ex03: Multiply two Floating Point Numbers");
        Console.WriteLine($"So thu nhat la: {a}");
        Console.WriteLine($"So thu hai la: {b}");
        Console.WriteLine($"Tich hai so la: {a} * {b} = {c}");
    }
    /// <summary>
    /// to convert feet to meter
    /// </summary>
    static void Ex04()
    {
        const float oneft = 0.3048f;
        float a = 2f;
        float b = oneft * a;
        Console.WriteLine("Ex04: Convert feet to meter");
        Console.WriteLine($"{a} feet = {b} meter");
    }
    /// <summary>
    ///  to convert Celsius to Fahrenheit and vice versa
    /// </summary>
    static void Ex05()
    {
        double doC = 0, doF = 32;
        double f = doC * 1.8 + 32;
        double c = (doF - 32) * 1.8;
        Console.WriteLine("Ex05: Convert Celsius to Fahrenheit and vice versa");
        Console.WriteLine($"{doF} do F = {c} do C");
        Console.WriteLine($"{doC} do C = {f} do F");
    }
    /// <summary>
    /// to find the Size of data types
    /// </summary>
    static void Ex06()
    { Console.WriteLine("Ex06: Find the Size of data types");
        Console.WriteLine($"Kich thuoc cua int: {sizeof(int)} bytes");
        Console.WriteLine($"Kich thuoc cua float: {sizeof(float)} bytes");
        Console.WriteLine($"Kich thuoc cua double: {sizeof(double)} bytes");
        Console.WriteLine($"Kich thuoc cua char: {sizeof(char)} bytes");
        Console.WriteLine($"Kich thuoc cua bool: {sizeof(bool)} bytes");
    }
    /// <summary>
    ///  to Print ASCII Value
    /// </summary>
    static void Ex07()
    {
        Console.WriteLine("Ex07: Print ASCII Value");
        int input;
        Console.Write("Nhap vao mot ky tu: ");
        input = Console.Read();
        Console.WriteLine($"Gia tri ASCII cua ky tu vua nhap la: {input}");
    }
    /// <summary>
    /// 
    /// to Calculate Area of Circle
    /// </summary>
    static void Ex08()
    {
        Console.WriteLine("Ex08: Calculate Area of Circle"); 
        const double pi = 3.14;
        double banKinh = 2.8;
        Console.WriteLine($"So do ban kinh hinh tron la: {banKinh}");
        double dienTich = pi * banKinh * banKinh;
        Console.WriteLine($"Dien tich hinh tron co ban kinh {banKinh} la: {dienTich}");
    }
    /// <summary>
    /// to Calculate Area of Square
    /// </summary>
    static void Ex09()
    {
        Console.WriteLine("Ex09: Calculate Area of Square");
        double canh = 4.8;
        Console.WriteLine($"So do canh hinh vuong la: {canh}");
        double dienTich = canh * canh;
        Console.WriteLine($"Dien tich hinh vuong co canh bang {canh} la: {dienTich}");
    }
    /// <summary>
    /// to convert days to years, weeks and days
    /// </summary>
    static void Ex10()
    {
        Console.WriteLine("Ex10: Convert days to years, weeks and days");
        int soNgay = 436;
        int nam = soNgay / 365;
        int tuan = (soNgay % 365) / 7;
        int ngay = (soNgay % 365) % 7;
        Console.WriteLine($"{soNgay} ngay bang: {nam} nam, {tuan} tuan, {ngay} ngay.");
    }
}