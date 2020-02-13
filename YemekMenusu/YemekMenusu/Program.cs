using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekMenusu
{
    class Program
    {
        static void Main(string[] args)
        {
            char secim;
            double toplam = 0;
            do
            {
                Console.WriteLine("1- sandviç - 12.50TL");
                Console.WriteLine("2- pizza - 14.50TL");
                Console.WriteLine("3- kebap - 11.50TL");
                Console.WriteLine("4- çorba - 8.50TL");
                Console.WriteLine("5- tost - 6.50TL");
                Console.WriteLine("6- çıkış");
                Console.WriteLine("Seçiminizi yapın");
                secim = Convert.ToChar(Console.ReadLine());
                Console.Clear();
                switch (secim)
                {
                    case '1':
                        toplam += 12.50;
                        Console.WriteLine("Şu anki hesap {0} TL", toplam);
                        break;
                    case '2':
                        toplam += 14.50;
                        Console.WriteLine("Şu anki hesap {0} TL", toplam);
                        break;
                    case '3':
                        toplam += 11.50;
                        Console.WriteLine("Şu anki hesap {0} TL", toplam);
                        break;
                    case '4':
                        toplam += 8.50;
                        Console.WriteLine("Şu anki hesap {0} TL", toplam);
                        break;
                    case '5':
                        toplam += 6.50;
                        Console.WriteLine("Şu anki hesap {0} TL", toplam);
                        break;
                    case '6':
                        Console.WriteLine("Alışverişiniz tamamlanmıştır.");
                        break;
                    default:
                        Console.WriteLine("1-6 arası seçim yapınız.");
                        break;
                }
            } while (secim != '6');
            Console.WriteLine("Toplam hesabınız {0} TL\nYine Bekleriz..",toplam);
            Console.Read();
        }
    }
}
