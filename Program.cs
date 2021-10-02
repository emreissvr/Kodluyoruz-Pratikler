using System;

namespace ArrayClassMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // sort
            int[] sayiDizisi = {23,12,4,67,31,56,42,34};
            foreach (var sayi in sayiDizisi)
            {
                System.Console.WriteLine(sayi);
            }

            System.Console.WriteLine("****sıralı dizi****");
            Array.Sort(sayiDizisi);
            foreach (var sayi in sayiDizisi)
            {
                System.Console.WriteLine(sayi);
            }
           
            // Clear
            System.Console.WriteLine("**** Array Clear ****");
            Array.Clear(sayiDizisi,2,2);

            foreach (var sayi in sayiDizisi)
            {
                System.Console.WriteLine(sayi);
            }

            // Reverse 
            System.Console.WriteLine("**** Array Reverse ****");
            Array.Reverse(sayiDizisi);

            foreach (var sayi in sayiDizisi)
            {   
                System.Console.WriteLine(sayi);
            }


            // IndexOf
            System.Console.WriteLine("**** Array IndexOf ****");
            Array.IndexOf(sayiDizisi,23);

            foreach (var sayi in sayiDizisi)
            {
                System.Console.WriteLine(sayi);

            }
            // Resize
            System.Console.WriteLine(" **** Array Resize ****");
            Array.Resize<int>(ref sayiDizisi,9);
            sayiDizisi[8] = 90;
            foreach (var sayi in sayiDizisi)
            {
                System.Console.WriteLine(sayi);
            }
        }



    }
}
