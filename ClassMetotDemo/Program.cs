using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 001685424;
            musteri1.Who = "Berkecan Arslan";
            musteri1.Adress = "İzmir";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 001688647;
            musteri2.Who = "Aslı Güngördü";
            musteri2.Adress = "Antalya";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 0016845329;
            musteri3.Who = "Mehmet Güzelyatan";
            musteri3.Adress = "Diyarbakır";

            Musteri musteri4 = new Musteri();
            musteri4.Id = 00168753216;
            musteri4.Who = "Ömer Ahmet Dikduran";
            musteri4.Adress = "İstanbul";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };
            foreach (var musteri in musteriler)
            {
                Console.WriteLine("---Müşteri Bilgileri---");
                Console.WriteLine("Müşteri Id Numarası: " + musteri.Id);
                Console.WriteLine("Müşteri Bilgisi: " + musteri.Who);
                Console.WriteLine("Musteri Adresi: " + musteri.Adress);
            }

            MusteriManager musteriEkle = new MusteriManager();
            musteriEkle.addMusteri(musteri1);
            musteriEkle.addMusteri(musteri2);

            MusteriManager musteriSil = new MusteriManager();
            musteriSil.deleteMusteri(musteri3);
            musteriSil.deleteMusteri(musteri4);
        }
    }
}
