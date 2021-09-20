using System;

namespace Operatorler
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // atama ve işlemli atama

            int x = 3;
            int y = 3;
            y = y+2;
            System.Console.WriteLine(y);
            y +=2;
            System.Console.WriteLine(y);

            y /= 1;
            System.Console.WriteLine(y);
            x +=2;
            System.Console.WriteLine(x);


            // MANTIKSAL OPERATÖRLER
            bool isSuccess = true;
            bool isCompleted = false;
            if(isSuccess && isCompleted)
                Console.WriteLine("Perfect");
            if(isSuccess || isCompleted)
                Console.WriteLine("Great!");
            if(isSuccess && !isCompleted)
                Console.WriteLine("Fine!");
            
            // ilişkisel operatörler
            // <,>,<=,>=
            int a = 3;
            int b = 4;
            bool sonuc = a<b;
            Console.WriteLine(sonuc);
            sonuc = a>b;
            Console.WriteLine(sonuc);
            sonuc = a>=b;
            Console.WriteLine(sonuc);
            sonuc = a==b;
            Console.WriteLine(sonuc);
            sonuc = a!=b;
            Console.WriteLine(sonuc);


            // aritmetik operatörler
            // /,+,-,*
            int number1 = 24;
            int number2 = 8;
            int result1 = number1/number2;
            System.Console.WriteLine(result1);
            result1 = number1+number2;
            System.Console.WriteLine(result1);
            result1 = number1+number2;
            System.Console.WriteLine(result1);
            resulr1 = number1 ++;
            System.Console.WriteLine(result1);

            // % : mod alır
            int result2 = 20%3;
            Console.WriteLine(result2);
            
         }
    }
}
