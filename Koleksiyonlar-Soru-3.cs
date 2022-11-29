using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] sesliler = { 'a', 'e', 'ı', 'i', 'o', 'ö', 'u', 'ü' };
            List<char> arr = new List<char>() { };
            Console.Write("Lütfen Cümle giriniz: ");
            string bul = Console.ReadLine().ToLower();
            foreach (char karakter in bul)
            {
                foreach (char item in sesliler)
                {
                    if (karakter == item)
                    {
                        arr.Add(karakter);
                    }
                }
            }
            foreach (char item in arr)
            {
                Console.Write( item+"-");
            }
            Console.ReadLine();

        }
    }
    }

