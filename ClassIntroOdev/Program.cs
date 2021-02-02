using System;

namespace ClassIntroOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun u1 = new Urun();
            u1.KategoriAdi = "Ayakkabı";
            u1.Adi = "Adidas Spor Ayakkabı";
            u1.Renk = "Kırmızı";
            u1.Fiyati = 120;

            Urun u2 = new Urun();
            u2.KategoriAdi = "Ayakkabı";
            u2.Adi = "Nike Spor Ayakkabı";
            u2.Renk = "Siyah";
            u2.Fiyati = (float)300;


            Urun u3 = new Urun();
            u3.KategoriAdi = "Ayakkabı";
            u3.Adi = "Puma Spor Ayakkabı";
            u3.Renk = "Lacivert";
            u3.Fiyati = (float)450;

            Urun[] urunler = new Urun[] { u1, u2, u3 };
            
            //for başlangıcı
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine("Kategori Adı:" + urunler[i].KategoriAdi + " - " + "Ürün Adı:" + urunler[i].Adi + " - " + "Rengi:" + urunler[i].Renk + " - " + "Fiyatı:" + urunler[i].Fiyati);
            }
            Console.WriteLine("foreach başlangıcı");
            foreach (Urun item in urunler)
            {
                Console.WriteLine("Kategori Adı:" + item.KategoriAdi + " - " + "Ürün Adı:" + item.Adi + " - " + "Renk:" + item.Renk + " - " +"Fiyatı:"+ item.Fiyati);
            }
            Console.WriteLine("while başlangıcı");
            int x = 0;
            while (x<urunler.Length)
            {
                Console.WriteLine("Kategori Adı:" + urunler[x].KategoriAdi + " - " + "Ürün Adı:" + urunler[x].Adi + " - " + "Rengi:" + urunler[x].Renk + " - " + "Fiyatı:" + urunler[x].Fiyati);
                x++;
            }
            Console.WriteLine("do while başlangıcı");
            int y = 0;
            do
            {
                Console.WriteLine("Kategori Adı:" + urunler[y].KategoriAdi + " - " + "Ürün Adı:" + urunler[y].Adi + " - " + "Rengi:" + urunler[y].Renk + " - " + "Fiyatı:" + urunler[y].Fiyati);
                y++;
            } while (y<urunler.Length);

        }
    }

    class Urun
    {
        public string KategoriAdi { get; set; }
        public string Adi { get; set; }
        public string Renk { get; set; }
        public float Fiyati { get; set; }

    }
}
