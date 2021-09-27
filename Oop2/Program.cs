using System;
using System.Collections.Generic;

namespace Oop2
{
    class Program
    {
        private static List<string> tuzelmusteriler;

        static void Main(string[] args)
        {
            //Engin Demirog

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demirog";
            musteri1.TcNo = "123123";

            // Kodlama.io

            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "112233";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "32304477";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri1);

        }
    }
}