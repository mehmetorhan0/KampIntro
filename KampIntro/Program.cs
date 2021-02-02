using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Değişkenler: Veri tutucular

            //type safety - Tip Güvenliği
            // Do not repeat yourself - Kendini tekrarlama.
            // değer tutucu, alias


            string kategoriEtiketi = "Kategori";
            int ogrenciSayisi = 32000; // tam sayı veri tipi
            double faizOrani = 1.45;// Ondalıklı sayı veri tipi
            bool sistemeGirisYapmisMi = false; // bool: true veya false dönderir.

            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi butonu");
            }



            if(sistemeGirisYapmisMi==true)
            {
                Console.WriteLine("Ayarlar butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);


        }
    }
}
