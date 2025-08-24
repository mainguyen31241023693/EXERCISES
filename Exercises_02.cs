using System;
internal class Exercise2
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
    }
    //EX_01
    /// <summary>
    /// 1.Convert Celsius to Kelvin and Fahrenheit
    /// </summary>
    static void Ex01()
    {
        Console.WriteLine("Day la EX_01\n");
        Console.Write("Nhap vao do C: ");
        string input = Console.ReadLine();
        int doC;
        while (!int.TryParse(input, out doC))
        {
            Console.WriteLine("Vui long nhap lai 1 so. ");
            Console.Write("Nhap lai:  ");
            input = Console.ReadLine();
        }
            double doK = doC + 273;
            double doF = doC * 18 / 10 + 32;
            Console.WriteLine($"Kelvin = {doK} ");
            Console.WriteLine($"Fahrenheit = {doF}\n");
    }
    /// <summary>
    /// 2.Calculate the surface and volume of a sphere with a given radius
    /// </summary>
    static void Ex02()
    {
        Console.Write("Nhap vao ban kinh: ");
        string input = Console.ReadLine();
        double banKinh;
        while (!double.TryParse(input, out banKinh))
        {
            Console.WriteLine("Vui long nhap lai 1 so. ");
            Console.Write("Nhap lai:  ");
            input = Console.ReadLine();
        }
        double surface = 4 * Math.PI * Math.Pow(banKinh,2);
        Console.WriteLine($"Surface: {surface}");
        double volume = 4 / 3 * Math.PI * Math.Pow(banKinh, 3);
        Console.WriteLine($"Volume: {volume}\n");
    }
    /// <summary>
    /// 3.Calculates the result of adding, subtracting, multiplying and dividing two numbers entered by the user
    /// </summary>
    static void Ex03()
    {
        Console.Write("Nhap vao so thu nhat: ");
        string input1 = Console.ReadLine();
        int soThuNhat;
        while (!int.TryParse(input1, out soThuNhat))
        {
            Console.WriteLine("Vui long nhap lai 1 so. ");
            Console.Write("Nhap lai:  ");
            input1 = Console.ReadLine();
        }
        Console.Write("Nhap vao so thu hai: ");
        string input2 = Console.ReadLine();
        int soThuHai;
        while (!int.TryParse(input2, out soThuHai))
        {
            Console.WriteLine("Vui long nhap lai 1 so. ");
            Console.Write("Nhap lai:  ");
            input2 = Console.ReadLine();
        }
        Console.WriteLine($"So thu nhat la: {soThuNhat}");
        Console.WriteLine($"So thu hai la: {soThuHai}");
        Console.WriteLine($"{soThuNhat} + {soThuHai} = {soThuNhat + soThuHai}");
        Console.WriteLine($"{soThuNhat} - {soThuHai} = {soThuNhat - soThuHai}");
        Console.WriteLine($"{soThuNhat} * {soThuHai} = {soThuNhat * soThuHai}");
        Console.WriteLine($"{soThuNhat} / {soThuHai} = {soThuNhat / soThuHai}");
        Console.WriteLine($"{soThuNhat} mod {soThuHai} = {soThuNhat % soThuHai}\n\n\n");
    }
    //EX_02
    /// <summary>
    /// 1.Takes two numbers as input and performs an operation (+,-,*,/,%) on them
    /// </summary>
    static void Ex04()
    {
        Console.WriteLine("Day la EX_02\n");
        Console.Write("Nhap vao so thu nhat: ");
        string input1 = Console.ReadLine();
        int soThuNhat;
        while (!int.TryParse(input1, out soThuNhat))
        {
            Console.WriteLine("Vui long nhap lai 1 so. ");
            Console.Write("Nhap lai:  ");
            input1 = Console.ReadLine();
        }
        Console.Write("Nhap vao so thu hai: ");
        string input2 = Console.ReadLine();
        int soThuHai;
        while (!int.TryParse(input2, out soThuHai))
        {
            Console.WriteLine("Vui long nhap lai 1 so. ");
            Console.Write("Nhap lai:  ");
            input2 = Console.ReadLine();
        }
        Console.WriteLine($"So thu nhat la: {soThuNhat}");
        Console.WriteLine($"So thu hai la: {soThuHai}");
        Console.WriteLine($"{soThuNhat} + {soThuHai} = {soThuNhat + soThuHai}");
        Console.WriteLine($"{soThuNhat} - {soThuHai} = {soThuNhat - soThuHai}");
        Console.WriteLine($"{soThuNhat} * {soThuHai} = {soThuNhat * soThuHai}");
        Console.WriteLine($"{soThuNhat} / {soThuHai} = {soThuNhat / soThuHai}");
        Console.WriteLine($"{soThuNhat} % {soThuHai} = {soThuNhat % soThuHai}\n");
    }
    /// <summary>
    /// 2.Display certain values of the function x = y2 + 2y + 1 (using integer numbers for y, ranging from - 5 to + 5)
    /// </summary>
    static void Ex05()
    {
        int y;
        Console.Write("Nhap vao y: ");
        string input = Console.ReadLine();
        while (!int.TryParse(input, out y) || y < -5 || y > 5)
        {
            Console.WriteLine("Vui long nhap lai 1 so trong khoang tu -5 den 5. ");
            Console.Write("Nhap lai:  ");
            input = Console.ReadLine();
        }
        int x = y * y  + 2 * y + 1;
        Console.WriteLine($"Khi y = {y}, x = y2 + 2y + 1 = {x}\n");
    }
    /// <summary>
    /// 3.Program that takes distance and time (hours, minutes, seconds) as input and displays speed in kilometers per hour (km/h) and miles per hour (miles/h).
    /// </summary>
    static void Ex06()
    {
        Console.Write("Nhap vao khoang cach (don vi: km): ");
        string inputKcach = Console.ReadLine();
        double khoangCach;
        while (!double.TryParse(inputKcach, out khoangCach) || khoangCach < 0)
        {
            Console.WriteLine("Vui long nhap lai khoang cach. ");
            Console.Write("Nhap lai:  ");
            inputKcach = Console.ReadLine();
        }
        Console.WriteLine("Nhap vao thoi gian. ");
        Console.Write("Nhap vao so gio: ");
        string inputGio = Console.ReadLine();
        int gio;
        while (!int.TryParse(inputGio, out gio) || gio < 0)
        {
            Console.WriteLine("Vui long nhap so gio. ");
            Console.Write("Nhap lai:  ");
            inputGio = Console.ReadLine();
        }
        Console.Write("Nhap vao so phut: ");
        string inputPhut = Console.ReadLine();
        int phut;
        while (!int.TryParse(inputPhut, out phut) || phut < 0 || phut >= 60)
        {
            Console.WriteLine("Vui long nhap so phut (0-59). ");
            Console.Write("Nhap lai:  ");
            inputPhut = Console.ReadLine();
        }
        Console.Write("Nhap vao so giay: ");
        string inputGiay = Console.ReadLine();
        int giay;
        while (!int.TryParse(inputGiay, out giay) || giay < 0 || giay >= 60)
        {
            Console.WriteLine("Vui long nhap so giay (0-59). ");
            Console.Write("Nhap lai:  ");
            inputGiay = Console.ReadLine();
        }
        Console.WriteLine($"Khoang cach la: {khoangCach} km");
        Console.WriteLine($"Thoi gian la: {gio} gio, {phut} phut, {giay} giay");
        double tongSoGio = gio + (phut / 60.0) + (giay / 3600.0);
        double kmh = khoangCach / tongSoGio;
        double milesh = kmh * 0.621371; 
        Console.WriteLine($"Toc do theo km/h la: {kmh} ");
        Console.WriteLine($"Toc do theo miles/h la: {milesh}\n");
    }
    /// <summary>
    /// 4.Program that takes the radius of a sphere as input and calculates the surface and volume of the sphere
    /// </summary>
    static void Ex07()
    {
        Console.Write("Nhap vao ban kinh: ");
        string input = Console.ReadLine();
        double banKinh;
        while (!double.TryParse(input, out banKinh))
        {
            Console.WriteLine("Vui long nhap lai ban kinh.");
            Console.Write("Nhap lai:  ");
            input = Console.ReadLine();
        }
        double surface = 4 * Math.PI * Math.Pow(banKinh, 2);
        Console.WriteLine($"Dien tich la: {surface}");
        double volume = 4 / 3 * Math.PI * Math.Pow(banKinh, 3);
        Console.WriteLine($"The tich la: {volume}\n");
    }
    /// <summary>
    ///  5.Program that takes a character as input and checks if it is a vowel, a digit, or any other symbol
    /// </summary>
    static void Ex08()
    {
        Console.Write("Nhap vao 1 ky tu: ");
        string input = Console.ReadLine();
        char kyTu;
        while (!char.TryParse(input, out kyTu))
        {
            Console.WriteLine("Vui long nhap lai 1 ky tu. ");
            Console.Write("Nhap lai:  ");
            input = Console.ReadLine();
        }
        if ((kyTu == 'a') || (kyTu == 'e') || (kyTu == 'i') ||
                    (kyTu == 'o') || (kyTu == 'u') || (kyTu == 'A') || (kyTu == 'E') || (kyTu == 'I') ||
                    (kyTu == 'O') || (kyTu == 'U'))
        {
            Console.WriteLine($"Ky tu {kyTu} la nguyen am.");
        }
        else if ((kyTu >= '0') && (kyTu <= '9'))
        {
            Console.WriteLine($"Ky tu {kyTu} la chu so.");
        }
        else
        {
            Console.WriteLine($"Ky tu {kyTu} la ky tu khac.");
        }
    }
}