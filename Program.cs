using System;
using System.Collections.Generic;

namespace Example1_Algorithm_Questions_
{
    public class Program
    {
        public static void Main(string[] args)
        {


            // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). 
            // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin.
            //  Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın.


            // string number,number2;
            // List<string> evenNumbers = new List<string>();
            // Console.Write("Lütfen pozitif bir sayı girin: ");
            // number = Console.ReadLine();
            // Console.Write("Girdiğiniz bu sayı: " + number + "\n" + "Girdiğiniz bu sayı kadar ekrana sayı girin: ");
            // for(int i = 0; i < Int32.Parse(number); i++)
            // {
            //     number2 = Console.ReadLine();   
            //     evenNumbers.Add(number2);
            // }
            // for(int j = 0; j < evenNumbers.Count; j++)
            // {
            //     if(Int64.Parse(evenNumbers[j]) % 2 == 0){
            //         Console.Write(evenNumbers[j] + " ");
            //     }
            // }






            // Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). 
            // Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. 
            // Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.

            // string number,number2,number3;
            // List<string> evenNumbers = new List<string>();
            // Console.Write("Lütfen birinci sayıyı girin: ");
            // number = Console.ReadLine();
            // Console.WriteLine("Birinci sayı: "+ number);
            // Console.Write("Lütfen ikinci sayıyı girin: ");
            // number2 = Console.ReadLine();
            // Console.WriteLine("Girdiğiniz birinci sayı kadar sayı girin: ");
            // for(int i = 0; i < Int32.Parse(number); i++)
            // {
            //     number3 = Console.ReadLine();    
            //     evenNumbers.Add(number3);      
            // }
            // for(int j = 0; j < evenNumbers.Count; j++)
            // {
            //     if(Int64.Parse(evenNumbers[j]) == Int64.Parse(number2) || Int64.Parse(evenNumbers[j]) % Int64.Parse(number2) == 0){
            //         Console.Write(evenNumbers[j] + " ");
            //     }
            // }






            // Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). 
            // Sonrasında kullanıcıdan n adet kelime girmesi isteyin. 
            // Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.

            // string number,number2;
            // List<string> evenNumbers = new List<string>();
            // Console.Write("Lütfen bir sayı girin: ");
            // number = Console.ReadLine();
            // Console.WriteLine("Girdiğiniz birinci sayı kadar sayı girin: ");
            // for(int i = 0; i < Int32.Parse(number); i++)
            // {
            //     number2 = Console.ReadLine();    
            //     evenNumbers.Add(number2);
            // }
            // for(int j = evenNumbers.Count - 1 ; j >= 0 ; j--)
            // {
            //     Console.Write(evenNumbers[j] + " ");  
            // }


           












            // Count the total number of words in a string


            // string str;
            // int i, word, letter;
            // Console.Write("Lütfen bir cümle yazınız: ");
            // str = Console.ReadLine();

            // i = 0;
            // word = 1;
            // letter = 0;
            // while(i <= str.Length - 1){   
            //     if(str[i] == ' ' || str[i] == '\n' || str[i] == '\t' || str[i] == ',' || str[i] == '.')
            //     {
            //         word++;    
            //     }
            //     i++;
            // }
            // for(int j = 0; j<str.Length;j++){
            //     if(str[j] != ' ' && str[j] != ',' && str[j] != '.' && str[j] != '\t' && str[j] != '\n'){
            //         letter = letter + 1;
            //     }           
            // }
            // Console.Write("Total number of words in the string is : {0}\n", word);
            // Console.Write("Total number of letters in the string is : {0}\n", letter);

        }
    }
}
