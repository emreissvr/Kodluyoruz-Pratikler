using System;
using System.Collections;
using System.Collections.Generic;

namespace arrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste = new ArrayList();
            // liste.Add("Ayşe");
            // liste.Add(2);
            // liste.Add(true);
            // liste.Add('A');


            // // içerisinde  verilere erişim 
            // Console.WriteLine(liste[1]);

            // foreach (var item in liste)
            // {
            //     System.Console.WriteLine(item);
            // }

            // AddRange
            System.Console.WriteLine("******* Add Range *************");
            // string[] renkler = {"kırmızı","sarı","yesil"};
            
            List<int> sayılar = new List<int>{1,3,4,6,8,9};
            // liste.AddRange(renkler);
            liste.AddRange(sayılar);

            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }

            // sort        
            System.Console.WriteLine("************sort ********");
            liste.Sort(); // compile run'DA hata vermez ama runtime da hata verir arraylistin riskli tarafı bu 

            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }

            // binary Search 
            System.Console.WriteLine("********* Binary Search ************");
            System.Console.WriteLine(liste.BinarySearch(9));

            // reverse
            System.Console.WriteLine("****** reverse *******");
            liste.Reverse();

            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }

            // clear 
            System.Console.WriteLine("****** Clear *******");
            liste.Clear();

            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }


        }
    }
}
