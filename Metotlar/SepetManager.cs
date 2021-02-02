using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {

        //naming convention - Yazım kuralı
        //syntax
        public void Ekle(Urun urun)//Bir yerde normal parantez görüyorsanız anlayın ki orda bir metot vardır.
        {
            Console.WriteLine("Tebrikler. Sepete eklendi!"+urun.Adi);

        }
        public void Ekle2(string urunAdi,string aciklama, double fiyat)
        {
            Console.WriteLine("Tebrikler Sepete eklendi:"+urunAdi);
        }
    }
}
