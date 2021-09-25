using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "C#";
            string kurs2 = "Java";
            string kurs3 = "phyton";

            string[] kurslar = new string[] { "C#", "Java", "phyton" , "yazılım", ".net"};

            for (int i = 0; i < kurslar.Length ; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("Sayfa sonu - footer");
        }
    }
}
