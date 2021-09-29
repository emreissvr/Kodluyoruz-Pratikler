using System;

namespace if_else_elseif
{
    class Program
    {
        static void Main(string[] args)
        {
            int time = DateTime.Now.Hour;
            System.Console.WriteLine("Günaydın1");
            if (time >= 6 && time < 11)
            {
                
            }
            else if(time <= 18)
            {
                System.Console.WriteLine("iyi günler");
            }
            else
            {
                System.Console.WriteLine("iyi geceler!");
            }
            string sonuc = time<=18 ? "iyi günler " : "iyi geceler";
            sonuc = time <= 11 ? "Günaydın" : time <= 18 ?  "iyi günler" : "iyi geceler"; 
            
            System.Console.WriteLine(sonuc);
        }
    }
}
