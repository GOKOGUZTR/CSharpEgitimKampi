using System;
using System.Collections.Generic;
using System.Linq;
<<<<<<< HEAD
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Loops
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
=======
using System.Text;
using System.Threading.Tasks;

namespace _04_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region For Döngüsü
            //int i;
            //for (i = 1; i <= 5; i++) { 
            //Console.WriteLine("C# Eğitim Kampi");          
            //}
            /* int i;
              for (i = 3; i <= 50; i+=3)
              {
                  Console.WriteLine(i);
              }
             */
            /*  Console.WriteLine("Lütfen ekrana yazılmasınu istediğiniz adedi giriniz");
              int finishValue=int.Parse(Console.ReadLine());
              for (i = 0; i <= finishValue; i++)
              {
                  Console.WriteLine("Yaşasın Cumhuriyet");
              }
                 */
            #endregion
            #region For Döngüsü İle Karar Yapıları
            /*  int i;
              for ( i =1 ; i <= 100 ; i++)
              {
                  if (i % 5 == 0)
                  {
                      Console.WriteLine(i);
                  }
              }*/
            /*  int totalvalue = 0;
              for(int i = 1; i <= 10; i++)
              {
                  totalvalue += i;
              }
              Console.WriteLine(totalvalue);*/
            /*   
               int totalValue = 0;
               for (int i = 1 ; i <= 20; i++)
               {

                   if(i%2==0)
                     {
                   totalValue += i;
                     Console.WriteLine(i);
                   }
               }
                Console.WriteLine("----------");
               Console.WriteLine(totalValue);
               */
            /* int i;
             int count = 0;
             for (i = 1; i < 50; i++)
             {
                 if (i % 7 == 0)
                 {
                     count++;                  
                 }                          
             }
             Console.WriteLine(count);*/

            /*  int bacterium = 1;
              for (int i = 1; i <= 24; i++) { 

              bacterium*=2;

              Console.WriteLine(i+".Saat Sonunda: "+bacterium);

              } */
            #endregion
            #region While Döngüsü
            //int i = 1;
            //while (i <= 10) { 
            //Console.WriteLine("Merhaba Döngüler");
            //i++;
            //}
            //int i = 1;
            //while (i <=10) {
            //    if (i % 3 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    i++;
            //}
            /*  int i = 1;
              int sum = 0;

              while (i <= 10)
              {
                  sum += i;
                  i++;
              }  
              Console.WriteLine(sum); */
            #endregion
            #region Örnek Sınav Sorusu
            // Klavyeden Girilen 3 basamaklı Sayının basamakları toplamı hesaplayan kodu yazınız
            ///456
           /* Console.WriteLine("Bir sayı girininiz");
            int number= int.Parse(Console.ReadLine());
            int ones, tens, hundreads;
            int sum;
            ones = number % 10;
            tens = (number % 100) / 10;
            hundreads = number / 100;
           
            sum=ones+tens+hundreads;
            
            Console.WriteLine("sonuç= "+(ones+tens+hundreads));
            */
            
            #endregion
        
>>>>>>> Variable dosyasına yorum satırı eklendi.
        }
    }
}
