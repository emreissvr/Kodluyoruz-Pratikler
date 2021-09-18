using System;

namespace Console_Programlama
{
    class Program
    {
        public static void Main(string[] args)
        {
            // main methodu bir programın başladığı ve bittiği yerdir.
            // main methodu default olarak publictir 
            // public - erişim belirteci = bu methoda heryerden erişebilirsin demek 
            // static - keyword = bir nesne yaratılmadan bu main methoduna erişebileceğini söylüyor
            // void - geri dönüş tipini belirtir ve geriye hiçbirşey dönmeyeceği anlamına gelir
            // string[] args - komut satırlarından çalıştırabilmek için 
            // console system namespace'i altında var olan bir classtır 
            // writeline = console classının altındaki method dur. 
            Console.WriteLine("Hello World!");
            Console.WriteLine("İsminizi girin:");
            string name = Console.ReadLine();    
            Console.WriteLine("Soyisminizi Girin:");
            string surname = Console.ReadLine();

            Console.WriteLine("Merhaba " + name + " " + surname);


        }
    }
}
