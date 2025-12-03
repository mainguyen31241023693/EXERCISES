using System;
using System.Net;
internal class Exercise8
{
    static void Main(string[]args)
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
    //1. Write a program in C# Sharp to input a string and print it.
    static void ex1()
    {
        Console.Write("Hay nhap vao mot chuoi: ");
        string chuoi = Console.ReadLine();
        Console.WriteLine(chuoi);
    }
    //2. Write a C# Sharp program to find the length of a string without using a library function.
    static void ex2()
    {
        Console.Write("Hay nhap vao mot chuoi: ");
        string chuoi = Console.ReadLine();
        int dem = 0;
        foreach (char c in chuoi)
        {
            dem++;
        }
        Console.WriteLine($"Do dai cua chuoi vua nhap bang {dem}");
    }
    //3. Write a C# Sharp program to separate individual characters from a string. 
    static void ex3()
    {
            Console.Write("Hay nhap vao mot chuoi: ");
            string chuoi = Console.ReadLine();
            foreach (char c in chuoi)
            {
                Console.Write(c+" ");
            }    
    }
    //4. Write a program in C# Sharp to print individual characters of the string in reverse order.
    static void ex4()
    {
        Console.Write("Hay nhap vao mot chuoi: ");
        string chuoi = Console.ReadLine();
        for (int i = chuoi.Length-1; i>0; i--)
        {
            Console.Write(chuoi[i]+" ");
        }    
    }
    //5. Write a program in C# Sharp to count the total number of words in a string. 
    static void ex5()
    {
        Console.Write("Hay nhap vao mot chuoi: ");
        string chuoi = Console.ReadLine();
        chuoi = chuoi.Trim();
        string[] str = chuoi.Split(new char[] { ' ' });
        Console.WriteLine($"Tong so tu trong chuoi: {str.Length}");
    }
    //6. Write a program in C# Sharp to compare two strings without using a string library functions.
    static void ex6()
    {
        Console.Write("Hay nhap vao chuoi thu nhat: ");
        string chuoi1 = Console.ReadLine();
        Console.Write("Hay nhap vao chuoi thu hai: ");
        string chuoi2 = Console.ReadLine();
        int dem1 = 0;
        int dem2 = 0;
        foreach (char c in chuoi1)
        {
            dem1++;
        }
        foreach (char c in chuoi2)
        {
            dem2++;
        }
        bool kt = true;
        if (dem1 < dem2)
        {
            Console.WriteLine("Chuoi 1 nho hon chuoi 2");
        }
        else if (dem2 < dem1)
        {
            Console.WriteLine("Chuoi 2 nho hon chuoi 1");
        }
        else
        {
            for (int i = 0; i < dem1;i++)
            {
                if (chuoi1[i] != chuoi2[i])
                {
                    kt = false;
                    break;
                }    
            }  
            
        }
        if (kt==true)
        {
            Console.WriteLine("Do dai của hai chuoi bang nhau va hai chuoi bang nhau");
        }
        else
        {
            Console.WriteLine("Do dai cua hai chuoi bang nhau nhung hai chuoi khong bang nhau");
        }
    }
    //7. Write a program in C# Sharp to count the number of alphabets, digits and special characters in a string.
    static void ex7()
    {
        Console.Write("Hay nhap vao mot chuoi: ");
        string chuoi = Console.ReadLine();
        int demchu = 0;
        int demso = 0;
        int demktdacbiet = 0;
        foreach (char c in chuoi)
        {
            if (char.IsDigit(c))
            {
                demso++;
            }    
            else if (char.IsLetter(c))
            {
                demchu++;
            }
            else
            {
                demktdacbiet++;
            }
        }
        Console.WriteLine($"So chu cai la {demchu}, so chu so la {demso}, so ki tu dac biet la {demktdacbiet}");
    }
    //8. Write a program in C# Sharp to copy one string to another string. 
    static void ex8()
    {
        Console.Write("Hay nhap vao mot chuoi: ");
        string chuoi = Console.ReadLine();
        string chuoi1 = "";
        for (int i = 0; i < chuoi.Length; i++)
        {
            chuoi1 += chuoi[i];
        }
        Console.WriteLine($"Chuoi dau tien la: {chuoi}");
        Console.WriteLine($"Chuoi thu hai la: {chuoi1}");
        Console.WriteLine($"So ki tu sao chep la: {chuoi.Length}");
    }
    //9. Write a C# Sharp program to count the number of vowels or consonants in a string.
    static void ex9()
    {
        Console.Write("Hay nhap vao mot chuoi: ");
        string chuoi = Console.ReadLine();
        int demnguyenam = 0;
        int demphuam = 0;
        foreach (char c in chuoi)
        {
            if (char.IsLetter(c))
            {
                switch (c)
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        demnguyenam++;
                        break;
                    default:
                        demphuam++;
                        break;
                }

            }    
        }
        Console.WriteLine($"Tong so nguyen am trong chuoi: {demnguyenam}");
        Console.WriteLine($"Tong so phu am trong chuoi: {demphuam}");
    }
    //10. Write a C# Sharp program to find the maximum number of characters in a string.
    static void ex10() 
    {
        Console.Write("Hay nhap vao mot chuoi: ");
        string chuoi = Console.ReadLine();
        int demMax = 0;
        char kitu = ' ';
        for (int i = 0; i < chuoi.Length; i++)
        {
            int dem = 0;

            for (int j = 0; j < chuoi.Length; j++)
            {
                if (chuoi[i] == chuoi[j])
                    dem++;
            }
            if (dem > demMax)
            {
                demMax = dem;
                kitu = chuoi[i];
            }
        }
        Console.WriteLine($"Ky tu {kitu} xuat hien nhieu lan nhat voi {demMax} lan");
    }
}
