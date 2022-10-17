using ders3Method;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayac = 1;
            Urun urun1 = new Urun();
            urun1.Adi = "Karpuz";
            urun1.Aciklama = "Çök Esma çök";
            urun1.Fiyati = 60;
            urun1.urunsayaci = 1;

            Urun urun2 = new Urun();
            urun2.Adi = "Erik";
            urun2.Aciklama = "İmam Eriği";
            urun2.Fiyati = 25;
            urun2.urunsayaci = 2;


            Urun urun3 = new Urun();
            urun3.Adi = "Çilek";
            urun3.Aciklama = "Zaman geriye aksın";
            urun3.Fiyati = 25;
            urun3.urunsayaci = 3;

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine("Ürün Numarası(Sınıftan alınan propla yazılan değer):" + urun.urunsayaci);
                Console.WriteLine("Ürün Numarası(Harici oluşturulan sayaçtan gelen değer):" + sayac);
                Console.WriteLine("ürün adı: " + urun.Adi);
                Console.WriteLine("ürün açıklaması: " + urun.Aciklama);
                Console.WriteLine("ürün fiyatı: " + urun.Fiyati);
                Console.WriteLine("    ");
                Console.WriteLine("*********************************");
                sayac++;


            }

            Console.WriteLine("------------------------------------Metot--------------------------------------------");
            MarketManager sepet = new MarketManager();
            sepet.Ekle(urun1);
            sepet.Ekle(urun2);
            sepet.cıkar(urun3);

            








            Console.ReadKey();
        }
    }
}