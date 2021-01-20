using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri
            {
                No = 4515414,
                Adi = "Furkan",
                SoyAdi = "Bozkurt",
                TcNo = "4877484517",
                TelNo = "+905445448787",
                KrediNotu = 8.75
            };

            Musteri musteri2 = new Musteri
            {
                Adi = "Selma",
                SoyAdi = "Olkan",
                TcNo = "1564154554545",
                No = 1252151,
                TelNo = "+90544984851",
                KrediNotu = 8.3

            };

            Musteri musteri3 = new Musteri
            {
                Adi = "Gökay",
                SoyAdi = "Malzeme",
                TelNo = "+90545485412",
                TcNo = "4545479847",
                No = 4554878,
                KirmiziKalem = true,
                KrediNotu = 2.5,

            };

            Musteri musteri4 = new Musteri
            {
                Adi = "Berkay",
                SoyAdi = "Bilgin",
                TelNo = "+905548872",
                TcNo = "45448996637",
                No = 100475589,
                KrediNotu = 7.7,

            };

            Musteri musteri5 = new Musteri
            {
                Adi = "Engin",
                SoyAdi = "Demiroğ",
                TelNo = "+90577487742",
                TcNo = "7815697632119651",
                No = 471545,
                KrediNotu = 9.9,
            };

            MusteriManager musteriManager = new MusteriManager();

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4, musteri5 };
            foreach (Musteri musteri in musteriler)
            {
                musteriManager.Listeleme(musteri);
            }

            while (true)
            {
                Console.WriteLine("Müşteri Eklemek İstermisiniz. Çıkmak 'H' & 'h' Tuşuna basınız");
                if (Console.Read() == 104 || Console.Read() == 72)
                    break;
                else
                {
                    musteriManager.Ekleme();
                }
            }

            musteriManager.Silme(musteri3);
             
            Console.WriteLine("Çıkış Yaptınız.");
        }
    }
}