using System;

namespace WhileAndForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.Write("Lütfen bir sayı giriniz:");
        //    int sayi = int.Parse(Console.ReadLine());
        //    int sayac = 1;
        //    int toplam = 0;
        //    while(sayac <= sayi)
        //    {
        //        toplam += sayac;
        //        sayac ++;
        //    }
        //     Console.WriteLine(toplam/sayi);

        //     // a dan z ye kadar tüm karakterleri yaz
        //     char character = 'a';
        //     while(character < 'z')
        //     {
        //         Console.Write(character);
        //         character++;
        //     }
            System.Console.WriteLine("****** foreach ******");
            string[] arabalar = {"BMW","Ford","Toyota","Nissan"};

            foreach (var araba in arabalar)
            {
                System.Console.WriteLine(araba);
            }
        }
    }
}
