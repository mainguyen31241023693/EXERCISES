using System;
namespace Exercises_03
{
    class Bai_1
    {
        static void Main(string[] args)
        {
            game_engine();
        }
        static void game_engine()
        {
            Console.WriteLine("CHAO MUNG DEN VOI TRO CHOI DOAN SO\n");
            int tienquy = 100;
            int sovanthang = 0;
            int sovanthua  = 0; 
            Console.WriteLine($"So tien ban co ban dau la: {tienquy}$\n");
            do
            {
                int tienconthua;
                Console.WriteLine("Level:\n\tKho: 4 lan choi\n\tTrung binh: 7 lan choi\n\tDe: 10 lan choi");
                Console.Write("Ban chon cap do nao? (1-Kho, 2-Trung binh, 3-De): ");
                string inputlevel = Console.ReadLine();
                int level;
                while (!int.TryParse(inputlevel, out level) || level < 1 || level > 3)
                {
                    Console.WriteLine("Vui long nhap lai cap do ban chon. (1/2/3)");
                    Console.Write("Ban chon cap do nao? (1-Kho, 2-Trung binh, 3-De): ");
                    inputlevel = Console.ReadLine();
                }
                int solanchoi = 10;
                solanchoi = level == 1 ? 4 : (level == 2 ? 7 : 10);
                Random rnd = new Random();
                int comp_num = rnd.Next(0, 100) + 1;
                Console.WriteLine($"\n\tMoi van thang/thua ban se duoc/mat {solanchoi}$\n");
                Console.WriteLine("TRO CHOI BAT DAU\n\t");
                bool is_won = false;
                for (int i = 0; i < solanchoi; i++)
                {
                    Console.Write($"{i + 1}. Nhap so ban doan [1-100]: ");
                    string inputuser_num = Console.ReadLine();
                    int user_num;
                    while (!int.TryParse(inputuser_num, out user_num) || user_num < 1 || user_num > 100)
                    {
                        Console.WriteLine("Vui long nhap lai so ban doan [1-100]. ");
                        Console.Write("Nhap so ban doan: ");
                        inputuser_num = Console.ReadLine();
                    }
                    if (user_num == comp_num)
                    {
                        Console.WriteLine($"Chuc mung ban da doan dung so {comp_num} trong {i + 1} lan choi!");
                        is_won = true;
                        tienconthua = tienquy + solanchoi;
                        tienquy = tienconthua;
                        sovanthang = sovanthang + 1;
                        break;
                    }
                    else if (user_num < comp_num)
                    {
                        Console.WriteLine("So ban doan nho hon so may nghi.");
                    }
                    else
                    {
                        Console.WriteLine("So ban doan lon hon so may nghi.");
                    }
                }
                if (!is_won)
                {
                    Console.WriteLine($"Ban da het so lan choi. So may nghi la {comp_num}");
                    tienconthua = tienquy - solanchoi;
                    tienquy = tienconthua;
                    sovanthua = sovanthua + 1;
                }
                Console.WriteLine($"So tien hien tai ban co la: {tienquy}$");
                if (tienquy <= 0)
                {
                    Console.WriteLine("\nBAN DA HET TIEN TRONG QUY. TRO CHOI KET THUC.\nBYE. HEN GAP LAI!");
                    break;
                }
                Console.Write("\nBan co muon choi lai khong? (y/n): ");
                string tl = Console.ReadLine();
                while (tl.ToLower() != "y" && tl.ToLower() != "n")
                {
                    Console.Write("Vui long nhap lai cau tra loi cua ban (y/n): ");
                    tl = Console.ReadLine();
                }
                if (tl.ToLower().Equals("n"))
                {
                    Console.WriteLine("\nBYE. HEN GAP LAI!");
                    break;
                }
            }
            while (true);
            Console.WriteLine($"\nTONG KET\nSo tien ban con lai trong quy la: {tienquy}$");
            Console.WriteLine($"So van ban da thang la: {sovanthang}");
            Console.WriteLine($"So van ban da thua la: {sovanthua}");
        }
    }
}