using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Temel Dizi Örnekleri
            /*   string[] colors = new string[4];

               colors[0] = "Kırmızı";
               colors[1] = "Sarı";
               colors[2] = "mavi";
               colors[3] = "yeşil";

               Console.WriteLine(colors[2]);*/

            //string[] cities = { "İstanbul", "Prag", "Atina", "Ankara", "Bursa" };
            //Console.WriteLine(cities[2]);

            #endregion

            #region Dizideki Tüm Elemanları Listeleme

            //string[] colors = { "sarı", "kırmızı", "beyaz", "mavi", "yeşil", "turuncu", "pembe" };
            //for (int i = 0; i < colors.Length; i++)
            //{
            //    Console.WriteLine(colors[i]);
            //}
            //int[] numbers = { 22, 23, 78, 98, 79, 96, 789, 5465, 123, 963, 982 };
            //for (int i = 0; i < numbers.Length; i++) {
            //    if (numbers[i] % 3 == 0)
            //    {
            //        Console.WriteLine(numbers[i]);  
            //    }

            //}

            //int[] numbers = { 22, 23, 78, 98, 79, 96, 789, 5465, 123, 963, 982 ,99999};
            //int maksNumber=numbers[0];
            //for (int i = 1; i < numbers.Length; i++)
            //{
            //if (numbers[i] > maksNumber)
            //    {
            //        maksNumber = numbers[i];
            //    }

            //   }
            //Console.WriteLine(maksNumber);

            // int[] numbers = { 22, 23, 78, 98, 79, 96, 789, 5465, 123, 963, 982, 99999 };
            //Array.Sort(numbers);
            // for (int i = 1; i < numbers.Length; i++)
            // { 
            // Console.WriteLine(numbers[i]);
            // }
            #endregion

            #region Dizi Metotlar
            //string[] customers = { "ali", "veli","aysegul","merve","çınar","kaya" };
            //int index = Array.IndexOf(customers, "merve");
            //Console.WriteLine(index);

            #endregion

            #region Kullanıcıdan Değer Alma

            //  string[] cities = new string[5];
            //  for (int i = 0; i < cities.Length; i++)
            //  { 
            //  Console.Write($"lütfen {i+1}.şehri giriniz:");
            //      cities[i]=Console.ReadLine();
            //  }


            //Console.WriteLine();
            //  Console.WriteLine("----------------");
            //  for (int i = 0; i < cities.Length; i++) 
            //  {
            //      Console.WriteLine(cities[i]);
            //}
          //  int[] numbers = { 1, 2, 56, 588 };
          //  int sum = 0;

          //  for (int i = 0; i < numbers.Length; i++) 
          //  {
          //  sum += numbers[i];
          //  }
          //Console.WriteLine(sum);


            
            #endregion
            Console.Read();
        }
    }
}
