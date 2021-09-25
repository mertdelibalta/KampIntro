using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdı = "Elma";
            urun1.Fiyat = 14;
            urun1.Aciklama = "Amasya Elma";
            urun1.StokAdedi = 22;

            Urun urun2 = new Urun();
            urun2.UrunAdı = "Çilek";
            urun2.Fiyat = 14;
            urun2.Aciklama = "Kırmızı Çilekler";
            urun2.StokAdedi = 33;

            Urun[] urunler = new Urun[] { urun1, urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.UrunAdı);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.StokAdedi);
                Console.WriteLine("------------");
            }

            Console.WriteLine("-----Metotlar-------");

            SepetManager sepetmanager = new SepetManager();
            sepetmanager.Ekle(urun1);
            sepetmanager.Ekle(urun2);
          
        }
    }
}
