using System;

namespace TipDonusumlerı
{
    class Program
    {
        static void Main(string[] args)
        {
            // Implicit Conversion (Bilinçsiz Dönüşüm)
            byte  a =5;
            sbyte b = 30;
            short c = 10;
            int d = a+b+c;
            System.Console.WriteLine("d: " + d);

            long h = d;
            Console.WriteLine("h:"+h);

            float i = h;
            System.Console.WriteLine("i:" + i);

            string e = "zikriye";
            char f = 'k';
            object g = e+f+d;
            Console.WriteLine("g:" + g);

            // explicit Conversion (bilinçli dönüşüm)

            int x = 4;
            byte y = (byte)x;
            System.Console.WriteLine("y:" + y);

            int z = 100;
            byte t = (byte)z;
            System.Console.WriteLine("t:" + t);

            float w = 10.3f;
            byte v = (byte)w;
            System.Console.WriteLine("t:" + t);

            // ToString Metodu
            int xx = 6;
            string yy = xx.ToString();
            System.Console.WriteLine("yy:" + yy);

            // string zz = 12.5f.ToString();
            // System.Console.WriteLine("zz:" + zz);

            // System.Convert 
            
            string s1 = "10", s2="20";
            int sayi1, sayi2;
            int Toplam;

            sayi1 = Convert.ToInt32(s1);
            sayi2 = Convert.ToInt32(s2);

            Toplam = sayi1 + sayi2;
            System.Console.WriteLine("Toplam: "+ Toplam);


            // Parse
            ParseMethod();

        }

        public static void ParseMethod()
        {
            string metin1 = "10";
            string metin2 = "10.25";
            int rakam1;
            double double1;

            rakam1 = Int32.Parse(metin1);
            double1 = double.Parse(metin2);
            
            
            Console.WriteLine("rakam1 : " + rakam1);
            Console.WriteLine("double1 : " + double1);
            
        }



    }
}
