using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_MakingDecision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region If Else ( KARAR YAPILARI )

            //Console.WriteLine("Lütfen Şİfreyi Giriniz:");
            //string password = "abcd";
            //password=Console.ReadLine();
            //if (password =="abcd")
            //{
            //    Console.WriteLine("Şİfre Doğru");

            //}
            //else
            //{
            //    Console.WriteLine("Şifre Yanlış");
            //}



            //string capital, country;
            //Console.WriteLine("Başkenti Giriniz: ");
            //capital = Console.ReadLine();

            //Console.WriteLine("Ülkeyi Giriniz: ");
            //capital = Console.ReadLine();

            //if (capital == "ankara" & capital == "türkiye")
            //{
            //    Console.WriteLine("Veriler Doğrulandı");

            //}
            //else {
            //    Console.WriteLine("Veriler Doğrulanamadı");
            //}

            //int number;

            //Console.WriteLine("Sayıyı giriniz: ");

            //number=int.Parse(Console.ReadLine());
            //if (number == 5)
            //{

            //    Console.WriteLine("Sayı Doğru: ");

            //}
            //else {
            //    Console.WriteLine("Sayı Yanlış: ");
            //}



            //int exam1, exam2,exam3,average;
            //string result="HATALI GİRİŞ";

            //Console.WriteLine("Sınav1: ");
            //exam1=int.Parse(Console.ReadLine());

            //Console.WriteLine("Sınav2: ");
            //exam2 = int.Parse(Console.ReadLine());

            //Console.WriteLine("Sınav3: ");
            //exam3 = int.Parse(Console.ReadLine());

            //average = (exam1 + exam2 + exam3) / 3;
            //Console.WriteLine("Sınavların ortalaması: "+average);

            //if(average>0 & average <= 50)
            //{
            //    result="Berbat";
            //}
            //if (average > 50 & average <= 70)
            //{
            //    result= "Sonuç Orta";
            //}
            //if (average > 70 & average <= 84) 
            //{
            //    result="Sonuç İyi";
            //}

            //if (average > 84)
            //{
            //    result = "Sonuç Çok İyi";

            //}
            //Console.WriteLine(result);  




            //string şehir;

            //Console.Write("Şehir girişi yapınız: ");

            //şehir=Console.ReadLine();

            //if (şehir=="mersin" | şehir=="hatay" | şehir == "istanbul")
            //{
            //    Console.WriteLine("şehir mevcut");
            //}
            //else
            //{
            //    Console.WriteLine("şehir mevcut değil");
            //}
            //Console.Read();
            #endregion

            #region Char ve Mod İşlemleri

            //Console.WriteLine("Lütfen birinci sayıyı giriniz: ");
            //int number1=int.Parse(Console.ReadLine());

            //Console.WriteLine("Lütfen ikinci sayıyı giriniz: ");
            //int number2 = int.Parse(Console.ReadLine());
            //int result = number1 % number2;

            //Console.WriteLine("1.sayının 2.sayıya bölümünden kalan değer: "+result);

            //Console.Write("sayı giriniz: ");

            //int input=int.Parse(Console.ReadLine());


            //if (input == 0) {
            //    Console.Write("sayı çifttir: ");

            //}
            //else 
            //{
            //    Console.Write("sayı tektir: ");
            //}

            #endregion
            #region Örnek Proje Uygulaması

            //Console.Write("C# EĞİTİM KAMPI RESTAURANT");
            //Console.WriteLine();
            //Console.WriteLine("--------------------------");
            //Console.WriteLine("1- Ana Yemekler");
            //Console.WriteLine("2- Çorbalar");
            //Console.WriteLine("3- Pizzalar");
            //Console.WriteLine("4- İçecekler");
            //Console.WriteLine("5- Tatlılar");
            //Console.WriteLine("--------------------------");
            //Console.WriteLine();

            //Console.WriteLine(" LÜTFEN!! 1'den 5'e Kadar Sayı Giriniz. ");
            //Console.WriteLine();
            //string menuItem;
            //Console.WriteLine("Detayını Görmek İstediğiniz Menü Seçimi: ");
            //menuItem = Console.ReadLine();

            //if (menuItem == "1")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------- ANA YEMEKLER -------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Köri Soslu Tavuk");
            //    Console.WriteLine("2-Kızartma Tabağı");
            //    Console.WriteLine("3-Fasülye Pilav");
            //    Console.WriteLine("4-Fırında Somon");
            //    Console.WriteLine("5-Patlıcan Musakka");
            //    Console.WriteLine("------------- ANA YEMEKLER -------------");
            //}

            //if (menuItem == "2")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------- ÇORBALAR -------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Tarhana Çorbası");
            //    Console.WriteLine("2-Mercimek Çorbası");
            //    Console.WriteLine("3-Kelle Paça Çorbası");
            //    Console.WriteLine("4-Ezogelin Çorbası");
            //    Console.WriteLine("5-Domates Çorbası");
            //    Console.WriteLine("------------- ÇORBALAR -------------");
            //}
            //if (menuItem == "3")
            //{
            //    Console.WriteLine("------------- PİZZALAR -------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Sosis Salamlı Pizza");
            //    Console.WriteLine("2-Mantarlı Pizaa");
            //    Console.WriteLine("3-Jambonlu Pizza");
            //    Console.WriteLine("4-Etli Pizza");
            //    Console.WriteLine("5-Balık Etli Pizza");
            //    Console.WriteLine();
            //    Console.WriteLine("------------- PİZZALAR -------------");
            //}
            //if (menuItem == "4")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------- İÇECEKLER -------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Coca Cola");
            //    Console.WriteLine("2-Fanta");
            //    Console.WriteLine("3-Sprite");
            //    Console.WriteLine("4-Osmanlı Şerbeti");
            //    Console.WriteLine("5-Su");
            //    Console.WriteLine();
            //    Console.WriteLine("------------- İÇECEKLER -------------");
            //}
            //if (menuItem == "5")
            //{
            //    Console.WriteLine();
            //    Console.WriteLine("------------- TATLILAR -------------");
            //    Console.WriteLine();
            //    Console.WriteLine("1-Tiriliçe");
            //    Console.WriteLine("2-Baklava");
            //    Console.WriteLine("3-Sütlaç");
            //    Console.WriteLine("4-Künefe");
            //    Console.WriteLine("5-Soğuk Baklava");
            //    Console.WriteLine();
            //    Console.WriteLine("------------- TATLILAR -------------");
            //}  
            #endregion
            #region Switch Case

            //Console.Write("Lütfen Ay Girişi Yapınız: ");
            //int monthNumber=int.Parse(Console.ReadLine());

            //switch (monthNumber)
            //{
            //    case 1:Console.WriteLine("Ocak"); break;
            //    case 2: Console.WriteLine("Şubat"); break;
            //    case 3: Console.WriteLine("Mart"); break;
            //    case 4: Console.WriteLine("Nisan"); break;
            //    case 5: Console.WriteLine("Mayıs"); break;
            //    case 6: Console.WriteLine("Haziran"); break;
            //    case 7: Console.WriteLine("Ağustos"); break;
            //    case 8: Console.WriteLine("Temmuz"); break;
            //    case 9: Console.WriteLine("Eylül"); break;
            //    case 10: Console.WriteLine("Ekim"); break;
            //    case 11: Console.WriteLine("Kasım"); break;
            //    case 12: Console.WriteLine("Aralık"); break;
            //    default: Console.WriteLine("Hatalı Veri Girişi"); break ;
            // }
            #endregion
            #region Switch Case İle Hesap Makinesi
            
            //int number1, number2,result;
            //char symbol;

            //Console.Write("1.Sayıyı yazınız: ");
            //number1=int.Parse(Console.ReadLine());
            
            //Console.Write("2.Sayıyı Giriniz: ");
            //number2=int.Parse(Console.ReadLine());
            
            //Console.Write("Lütfen yapmak istediğiniz işlemi giriniz (+,-,*,/): ");
            //symbol = char.Parse(Console.ReadLine());
            

            //switch (symbol)
            //{
            //    case '+':
            //        result=number1 + number2;
            //        Console.WriteLine("Sayıların Toplamı: "+result);

            //        break;
            //    case '-':
            //        result=number1 - number2;
            //        Console.WriteLine("Sayıların Farkı: " + result);
            //        break;
            //    case '*':
            //        result = number1 * number2;
            //        Console.WriteLine("Sayıların Çarpımı: " + result);
            //        break;
            //    case '/':
            //        result = number1 - number2;
            //        Console.WriteLine("Sayıların Bölümü: " + result);
            //        break;
           
            //}

            #endregion
                                                                                                       
            
            
            
            
            
            
            Console.Read();

        }
    }
}
