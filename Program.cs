using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 2;
            int b = 3;

            int sonuc = Topla(a,b);
            Console.WriteLine(sonuc);

            
            metotlar instance = new metotlar();
            instance.ekranaYazdir(Convert.ToString(sonuc));
            
            int sonuc2 = instance.ArttırVeTopla(ref a,ref b); 
            instance.ekranaYazdir(Convert.ToString(sonuc2));
            instance.ekranaYazdir(Convert.ToString(a+b));  // a ve b referans tip olduğu için a=3 ve b=4 oldu çünkü bellekteki orjinal adresleri değişti 
        }

        static int Topla(int a,int b)
        {
            return (a+b);
        }
    }

    class metotlar
    {
        public void ekranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public int ArttırVeTopla(ref int deger1,ref int deger2)
        {
            deger1+=1;
            deger2+=1;
            return deger1+deger2;

        }
    }
}

