using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type safe -- tip güvenli
            foreach (Urun item in urunler)
            {
                Console.WriteLine(item.Adi);
                Console.WriteLine(item.Fiyati);
                Console.WriteLine(item.Aciklama);
                Console.WriteLine("-------------");
            }

            Console.WriteLine("----------Metotlar---------");
            //instance - örnek
            //encapsulation
            SepetManager sepetManager = new SepetManager();//instance - örnek almak.
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle2("Armut", "Yeşil", 12);
        }
    }
}

//Dont repeat yourself(DRY): Kendini tekrar etme.
//Clean Code: Temiz Kod.
//Best Practice: En iyi uygulama teknikleri.