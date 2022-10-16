using ClassMethodDemo;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriAdSoyad = "Mücahit YİĞİT";
            musteri1.MusteriYas = 25;
            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriAdSoyad = "Emre YİĞİT";
            musteri2.MusteriYas = 24;
            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.MusteriAdSoyad = "Reyhan YİĞİT";
            musteri3.MusteriYas = 22;
            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.MusteriListele(musteriler);

        }
    }
}
