using System;

namespace Exercises_03
{
    internal class Bai_2
    {
        static void Main(string[] args)
        {
            dice_game();
        }
        public static void dice_game()
        {
            Console.WriteLine("CHAO MUNG DEN VOI TRO CHOI TAI XIU\n");
            int tienquy = 100;
            int sovanthang = 0;
            int sovanthua = 0;
            Console.WriteLine("LUAT CHOI\nMay tinh tung 2 xuc xac va lay tong cua chung\n\tLon hon 5 la \"Tai\",\n\tNho hon 5 là \"Xiu\",\n\tBang 5 là truong hop dac biet.");
            Console.WriteLine("Moi van doan dung/sai tai/xiu ban se duoc +5$ hoac -5$.\nRieng truong hop dac biet, doan dung ban se duoc cong gap 3, sai -5$");
            Console.WriteLine($"So tien ban co ban dau la: {tienquy}$");
            Console.WriteLine("\nTRO CHOI BAT DAU");
            do
            {
                Random rnd = new Random();
                int die_1 = rnd.Next(6) + 1;
                int die_2 = rnd.Next(6) + 1;
                int pair_of_dice = die_1 + die_2;
                Console.Write("Ban doan ket qua la gi? (Tai/Xiu/5) \nKet qua ban doan: ");
                string user_guess = Console.ReadLine().ToLower();
                while (user_guess != "tai" && user_guess != "xiu" && user_guess != "5")
                {
                    Console.Write("Vui long nhap lai ket qua ban doan (Tai/Xiu/5): ");
                    user_guess = Console.ReadLine().ToLower();
                }
                Console.WriteLine($"Ket qua 2 xuc sac la: {die_1} va {die_2}, tong la: {pair_of_dice}");
                if ((pair_of_dice > 5 && user_guess == "tai") || (pair_of_dice < 5 && user_guess == "xiu") || (pair_of_dice == 5 && user_guess == "5"))
                {
                    sovanthang = sovanthang + 1;
                    if (pair_of_dice == 5)
                    {
                        Console.WriteLine("Chuc mung ban da doan dung truong hop dac biet va thang gap 3 lan!");
                        tienquy = tienquy + 15;
                    }
                    else
                    {
                        Console.WriteLine("Chuc mung ban da doan dung!");
                        tienquy = tienquy + 5;
                    }
                }
                else
                {
                    sovanthua = sovanthua + 1;
                    Console.WriteLine("Rat tiec ban da doan sai. Chuc ban may man lan sau!");
                    tienquy = tienquy - 5;
                }
                Console.WriteLine($"So tien hien tai ban co la: {tienquy}$");

                if (tienquy <= 0)
                {
                    Console.WriteLine("\nBAN DA HET TIEN TRONG QUY. TRO CHOI KET THUC.\nBYE. HEN GAP LAI!");
                    break;
                }
                Console.Write("\nBan co muon choi lai khong? (y/n): ");
                string tl = Console.ReadLine();
                while (!tl.ToLower().Equals("y") && !tl.ToLower().Equals("n"))
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
            Console.WriteLine($"\nBAO CAO TONG HOP\nSo tien ban con lai trong quy la: {tienquy}$");
            Console.WriteLine($"So van ban da thang la: {sovanthang}");
            Console.WriteLine($"So van ban da thua la: {sovanthua}");
        }
    }
}