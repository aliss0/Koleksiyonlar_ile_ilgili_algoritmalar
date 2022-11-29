using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            int bort = 0, kort = 0, orttoplam = 0;
            int[] sayilar = new int[10];
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Lütfen {0}. Sayıyı Girin : ", i + 1);
                sayilar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("-----------------------------");
            Array.Sort(sayilar);
            Console.WriteLine($"Dizinin 1. En Büyük Sayısı : {sayilar[9]}  \nDizinin 2. En Büyük Sayısı : {sayilar[8]} \nDizinin 3. En Büyük Sayısı : {sayilar[7]}");
            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Dizinin 1. En Küçük Sayısı : {sayilar[0]}  \nDizinin 2. En Küçük Sayısı : {sayilar[1]} \nDizinin 3. En Küçük Sayısı : {sayilar[2]}");

            bort = (sayilar[9] + sayilar[8] + sayilar[7])/3;
            Console.WriteLine(" 3 En Büyük Sayıların Ortalaması =" + bort);
            kort = (sayilar[0] + sayilar[1] + sayilar[2]) / 3;
            Console.WriteLine(" 3 En Küçük Sayıların Ortalaması =" + kort);
            orttoplam = bort + kort;
            Console.WriteLine("Ortalamaların Toplamları = "+orttoplam);

            Console.ReadLine();
        }
    }
}
