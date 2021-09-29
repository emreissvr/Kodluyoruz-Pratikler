using System;

namespace Hata_Yönetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            try
            {
                System.Console.WriteLine("Bir sayı giriniz : ");
                int sayi = Convert.ToInt32(System.Console.WriteLine(Console.ReadLine());)
                Console.WriteLine("Girmiş olduğunuz sayı: " + sayi);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine("hata: " + ex.Message.ToString);
                
            }
            finally
            {
                Console.Write("işlem tamamlandı.");
            }
            
            */


            try
            {
                //  int a = int.Parse(null);
                // int a = int.Parse("text");
                int a = int.Parse("-20000000000000");
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Boş değer girdiniz");
                System.Console.WriteLine(ex);
                
            }
            catch(FormatException ex)
            {
                Console.WriteLine("Veri tipi uygun değil.");
                System.Console.WriteLine(ex);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("çok küçük yada çok büyük bir değer girdiniz.");
                System.Console.WriteLine(ex);
            }
            finally
            {
                System.Console.WriteLine("işlem başarıyal tamamlandı.");
            }

        }
    }
}
