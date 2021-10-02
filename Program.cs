using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dizi tanımlama
            string[] renkler = new string[5];
            string[] hayvanlar = {"kedi","köpek","kuş","maymun"};

            int[] dizi;
            dizi = new int[5];
            // dizilere değer atama ve erişim
            renkler[0] = "mavi";
            dizi[3] = 10;

            System.Console.WriteLine(hayvanlar[1]);
            System.Console.WriteLine(dizi[3]);
            System.Console.WriteLine(renkler[0]);

            // döngülerle dizi kullanımı 
            // klavyeden girilen n tane sayının ortalamasını hesaplayan program
            System.Console.Write("Lütfen dizinin eleman sayısını giriniz:");
            int diziuzunlugu = int.Parse(Console.ReadLine());
            int[] sayidizisi = new int[diziuzunlugu];

            for (int i = 0; i < diziuzunlugu; i++)
            {
                System.Console.WriteLine("Lütfen {0}. sayıyı giriniz:",i+1);
                sayidizisi[i] = int.Parse(Console.ReadLine());

            }

            int toplam = 0;
            foreach (var sayi in sayidizisi)
            {
                toplam += sayi;
            }
            System.Console.WriteLine("Ortalama: " + toplam/diziuzunlugu);
        }
    }
}
