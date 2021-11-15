using System;

namespace Built_in_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string degisken = "dersimiz charp. hoşgeldiniz";
            string degisken2 = "dersimiz charp. ";


            // length
            Console.WriteLine(degisken.Length);

            // ToUpper - ToLower
            Console.WriteLine(degisken.ToUpper());
            Console.WriteLine(degisken.ToLower());
            
            // Concat
            Console.WriteLine(string.Concat(degisken,"merhaba!"));
            
            // compare 
            Console.WriteLine(degisken.CompareTo(degisken2));
            Console.WriteLine(string.Compare(degisken,degisken2,true)); // true ignore case dir büyük küçük harf duyarsız

            // contains
            Console.WriteLine(degisken.Contains(degisken2));    // değişken in içinde değisken2 var mı?
            Console.WriteLine(degisken.EndsWith("Hosgeldiniz!"));   
            Console.WriteLine(degisken.StartsWith("Merhaba!"));   

            // IndexOf
            Console.WriteLine(degisken.IndexOf("ch"));   
            
            // Insert
            Console.WriteLine(degisken.Insert(0,"Merhaba "));   
            Console.WriteLine(degisken.LastIndexOf("i"));

            // PadLeft - PadRight   
            Console.WriteLine(degisken + degisken2.PadLeft(30));  // 30 boşluk bırakır sol tarafına
            Console.WriteLine(degisken2.PadRight(30) + degisken);  // 30 boşluk bırakır sol tarafına

            // Remove

            Console.WriteLine(degisken.Remove(10)); // 10. indexten sonrasını siler
            Console.WriteLine(degisken.Remove(5,3)); // 5. İNDEXTEN başla 3 karakter sil
            Console.WriteLine(degisken.Remove(0,1)); 
            
            // replace 
            Console.WriteLine(degisken.Replace("charp","c#")); 

            // split
            Console.WriteLine(degisken.Split(' ')[1]); 

            // substring
            Console.WriteLine(degisken.Substring(4)); 
            Console.WriteLine(degisken.Substring(4,6)); // 4. indexten itibaren 6 karakter alır
        


        }
    }
}
