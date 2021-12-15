using System;

namespace Enum
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine(Gunler.Pazar);
            System.Console.WriteLine((int)Gunler.Cumartesi);

            int sıcaklık = 32;

            if(sıcaklık <= (int)HavaDurumu.Normal){
                System.Console.WriteLine("dışarıya çıkmak için havanın biraz daha ısınmasını bekleyelim.");
            }
            else if(sıcaklık  >= (int)HavaDurumu.Sıcak){
                System.Console.WriteLine("Dışarıya çıkmak için çok sıcak bir gün");
            }
            else if (sıcaklık >= (int)HavaDurumu.Normal && sıcaklık <(int)HavaDurumu.CokSıcak ){
                System.Console.WriteLine("hadi dışarıya çıkalım.");
            }

        }
    }


    enum Gunler
    {
        Pazartesi,
        Sali ,
        Carsamba,
        Persembe,
        Cuma = 23,
        Cumartesi,
        Pazar
    }

    enum HavaDurumu{
        Soguk = 5,
        Normal = 20,
        Sıcak = 25,
        CokSıcak = 30
    }
}
