using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ödev2
{
    class Program
    {
        public static bool asalmi(int sayi)
        {
            bool durum = false;
            int kontrol = 0;

            for (int i = 2; i < sayi; i++)
            {
                if (sayi % i == 0)
                {
                    kontrol = 1;
                    break;
                }
            }

            if (kontrol == 1)
            {
                durum = false;
            }
            else
            {
                durum = true;
            }
            return durum;
        }







        static void Main(string[] args)
        {
            int toplam = 0, ortalama = 0;
            ArrayList asal = new ArrayList();
            ArrayList asalolmayan = new ArrayList();

            for (int i = 0; i < 20; i++)
            {

                try
                {

                    Console.Write("Lütfen {0}. Sayıyı Girin : ", i + 1);
                    var s = Convert.ToInt32(Console.ReadLine());


                    if (s % 1 == 0 && s != 0 && s != 1 && s > 0)
                    {
                        toplam += s;
                        if (asalmi(s))
                        {
                            asal.Add(s);
                        }
                        else
                        {
                            asalolmayan.Add(s);
                        }
                    }



                    else
                    {
                        Console.WriteLine("negatif sayıları ve 0 ve 1  girmeyiniz!!");
                        i--;
                    }


                }
                catch (Exception)
                {
                    Console.WriteLine("lütfen numerik bir sayı giriniz");
                    i--;

                }

            }




            Console.WriteLine("===========================");
            Console.WriteLine("ASAL SAYILAR");
            asal.Sort();
            foreach (int sayi in asal)
            {
                Console.WriteLine(sayi + "    ");
                toplam += sayi;
                ortalama++;
            }
            Console.WriteLine("Sayıların Adedi:" + ortalama + "  Sayıların ortalaması:" + toplam / ortalama);







            Console.WriteLine("ASAL OLMAYAN SAYILAR");
            Console.WriteLine("===========================");

            asalolmayan.Sort();
            toplam = 0; ortalama = 0;
            foreach (int sayi in asalolmayan)
            {
                Console.WriteLine(sayi + "    ");
                toplam += sayi;
                ortalama++;
            }
            Console.WriteLine("Sayıların Adedi:" + ortalama + "  Sayıların ortalaması:" + toplam / ortalama);

            Console.ReadLine();
        }
    }
}
