using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        readonly double azamiKrediNotu = 5.3;
        public void Ekleme()
        {
            Musteri musteri = new Musteri();

            Console.WriteLine("Yeni Müşteri Girişi");

            Console.Write("Lütfen Tc No Giriniz :");
            musteri.TcNo = Console.ReadLine();

            Console.Write("Lütfen Müşteri Adını Giriniz : ");
            musteri.Adi = Console.ReadLine();

            Console.Write("Lütfen Müşteri Soyadını Giriniz : ");
            musteri.SoyAdi = Console.ReadLine();

            Console.Write("Lütfen Müşteri Telefon Numarasını Giriniz : ");
            musteri.TelNo = Console.ReadLine();

            Random random = new Random();
            musteri.No = random.Next(1000000, 9999999);

            Console.WriteLine("------------------------------");
            Console.WriteLine(musteri.Adi+" "+musteri.SoyAdi+" Hoşgeldiniz");

            musteri.KrediNotu = 7;

            Listeleme(musteri);  
        }
        public void Listeleme(Musteri musteri)
        {
            Console.WriteLine("------------------------------");
            if (musteri.KirmiziKalem)
                Console.WriteLine("Bu Müşteri Kırmızı Kalem Yemiştir !!!");
            if (musteri.KrediNotu<azamiKrediNotu)
                Console.WriteLine("Banka Müdürü ile Görüşülecektir. Kredi Notu 10/" + musteri.KrediNotu);
            Console.WriteLine("Müşteri Numarası : " + musteri.No);
            Console.WriteLine(musteri.Adi + " " + musteri.SoyAdi);
            Console.WriteLine("Müşteri TC Kimlik Numarası : " +musteri.TcNo);
            Console.WriteLine("Müsteri Telefon Numarası : " + musteri.TelNo);
            Console.WriteLine("Kredi Notu 10/" + musteri.KrediNotu);
          
        }
        public void Silme (Musteri musteri)
        {

            Console.WriteLine(musteri.No+" Numaralı müşteri sistemden silinmiştir.");
            musteri.Adi = null;
            musteri.SoyAdi = null;
            musteri.TcNo = null;
            musteri.TelNo = null;
            musteri.No = 0;
            musteri.KrediNotu = 0.0;
        }
    }
}