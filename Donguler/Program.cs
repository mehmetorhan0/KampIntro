using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //Döngüler: Birbirine benzeyen işlemleri tekrar etmek için kullanırız.
            /* for (int i = 1; i < 10; i++)
             {
                 Console.WriteLine(i);
             }
            */
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Programlama başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C++";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);
            Console.WriteLine(kurs4);

            //array - dizi
            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kampı", "Programlama başlangıç için temel kurs", "Java","C#" };


            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine((i + 1) + "-" + kurslar[i]);
            }
            Console.WriteLine("For bitti");
           
            //foreach: Dizi temelli yapıları tek tek dönmeye yarıyor.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("Sayfa Sonu - footer");



            
        }
    }
}
