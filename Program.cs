using System;

namespace switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int month = DateTime.Now.Month;

            // expression 
            switch (month)
            {
                case 1:
                    System.Console.WriteLine("Ocak ayındasınız.");
                    break;
                case 2:
                    System.Console.WriteLine("Şubat Ayındasınız.");
                    break;
                case 3:
                    System.Console.WriteLine("mart Ayındasınız.");
                    break;
                case 4:
                    System.Console.WriteLine("nisan Ayındasınız.");
                    break;
                case 5:
                    System.Console.WriteLine("mayıs Ayındasınız.");
                    break;
                case 6:
                    System.Console.WriteLine("haziran Ayındasınız.");
                    break;
                case 7:
                    System.Console.WriteLine("temmuz Ayındasınız.");
                    break;
                case 8:
                    System.Console.WriteLine("ağustos Ayındasınız.");
                    break;
                case 9:
                    System.Console.WriteLine("eylül Ayındasınız.");
                    break;
                case 10:
                    System.Console.WriteLine("ekim Ayındasınız.");
                    break;
                case 11:
                    System.Console.WriteLine("kasım Ayındasınız.");
                    break;
                case 12:
                    System.Console.WriteLine("aralık Ayındasınız.");
                    break;
                
                default:
                    System.Console.WriteLine("yanlış veri girdiniz");
                break;

            }

            switch (month)
            {
                case 12:
                case 1:
                case 2:
                    System.Console.WriteLine("Kış ayındasınız.");
                    break;
                case 3:
                case 4:
                case 5:
                    System.Console.WriteLine("ilkbahar ayındasınız");
                    break;
                case 6:
                case 7:
                case 8:
                    System.Console.WriteLine("yaz ayındasınız");
                    break;
                case 9:
                case 10:
                case 11:
                    System.Console.WriteLine("sonbahar ayındasınız");
                    break;
                default:
                break;

            }
            
        }
    }
}
