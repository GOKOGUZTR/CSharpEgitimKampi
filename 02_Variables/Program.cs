using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Double Değişkenler

            //Console.WriteLine("***** Fiyat Listesi *****");
            //Console.WriteLine();

            //double applePrice, orangePrice, strawberyPrice, potatoPrice, tomatoPrice;
            //applePrice = 14.85;
            //orangePrice = 15.85;
            //strawberyPrice = 33.96;
            //potatoPrice = 10.13;
            //tomatoPrice=14.83;

            //Console.WriteLine("-----Elmanın Birim Fiyatı:" + applePrice + " TL");
            //Console.WriteLine("-----Portakalın Birim Fiyatı:" +orangePrice + " TL");
            //Console.WriteLine("-----Çilek Birim Fiyatı:" + strawberyPrice + " TL");
            //Console.WriteLine("-----Patates Birim Fiyatı:" + potatoPrice + " TL");
            //Console.WriteLine("-----Domates Birim Fiyatı:" + tomatoPrice + " TL");

            //double appleGram, orangeGram, strawberyGram, potatoGram, tomatoGram;
            //appleGram = 1.508;
            //orangeGram = 5.694;
            //strawberyGram = 2.369;
            //potatoGram = 4.369;
            //tomatoGram = 4.998;

            //double appleTotalPrice, orangeTotalPrice, strawberyTotalPrice,potatoTotalPrice, tomatoTotalPrice;
            //appleTotalPrice = appleGram * applePrice;
            //orangeTotalPrice = orangeGram * orangeGram;
            //strawberyTotalPrice = strawberyGram *  strawberyPrice;
            //tomatoTotalPrice = tomatoGram * tomatoPrice;
            //potatoTotalPrice = potatoGram *potatoPrice;

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Alınan Ürün : Elma" + " - Birim Fiyat : " + applePrice + " - Gramaj " + appleGram + " - Toplam Tutar : " + appleTotalPrice);

            //Console.WriteLine("Alınan Ürün : Portakal" + " - Birim Fiyat : " + orangePrice + " - Gramaj " + orangeGram + " - Toplam Tutar : " + orangeTotalPrice);

            //Console.WriteLine("Alınan Ürün : Çilek" + " - Birim Fiyat : " + strawberyPrice + " - Gramaj " + strawberyGram + " - Toplam Tutar : " + strawberyTotalPrice);

            //Console.WriteLine("Alınan Ürün : Domates" + " - Birim Fiyat : " + tomatoPrice + " - Gramaj " + tomatoGram + " - Toplam Tutar : " + tomatoTotalPrice);

            //Console.WriteLine("Alınan Ürün : Patates" + " - Birim Fiyat : " + potatoPrice + " - Gramaj " + potatoGram + " - Toplam Tutar : " + potatoTotalPrice);

            //double shoppingTotalPrice = appleTotalPrice + orangeTotalPrice + strawberyTotalPrice + tomatoTotalPrice + potatoTotalPrice;
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine(" Alışveriş Toplam Tutarı : " + shoppingTotalPrice+ " TL");

            #endregion
            #region Klavyeden Veri Girişleri String Değişkenler

            //Console.WriteLine("***** CHARP HAVA YOLLARI YOLCU BİİLGİSİ ******");

            //string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //Console.Write("Yolcu Adı: ");
            //passengerName = Console.ReadLine();


            //Console.Write("Yolcu Soyadı:");
            //passengerSurname = Console.ReadLine();

            //Console.Write("İlçe Bilgisi:");
            //passengerDistrict = Console.ReadLine();

            //Console.Write("Şehir Bilgisi: ");
            //passengerCity = Console.ReadLine();

            //Console.Write("Yaş Bİlgisi: ");
            //passengerAge = Console.ReadLine();

            //Console.Write("Yolcu TC kimlik No: ");
            //passengerIdentityNumber = Console.ReadLine();

            //Console.WriteLine();


            //Console.WriteLine("-------------------------");
            //Console.WriteLine("Yolcu TC Kimlik No:" + passengerIdentityNumber + "  " + "Yolcu Adı Soyadı:" + passengerName + " " + passengerSurname + " " + passengerDistrict + " " + passengerCity + " " + passengerAge);




            #endregion

            #region Klavyeden Tam Sayı Girişleri Ve Dönüşümler
            //int shoePrice, computerPrice, chairPrice, tvPrice;
            //shoePrice = 1000;
            //computerPrice = 2000;
            //chairPrice = 5000;
            //tvPrice = 12000;

            //int shoesCount, computerCount, chairCount, tvcount;

            //Console.Write("lütfen Aldığınız Ayakkabı Sayısını Giriniz: ");
            //shoesCount = int.Parse(Console.ReadLine());

            //Console.Write("lütfen Aldığınız Bilgisayar Sayısını Giriniz: ");
            //computerCount=int.Parse(Console.ReadLine());

            //Console.Write("lütfen Aldığınız Sandalye Sayısını Giriniz: ");
            //chairCount=int.Parse(Console.ReadLine());

            //Console.Write("lütfen Aldığınız Televizyon Sayısını Giriniz: ");
            //tvcount=int.Parse(Console.ReadLine());

            //Console.WriteLine();
            //Console.WriteLine();

            //int totalPrice=shoesCount*shoePrice+computerCount*computerPrice+chairCount*chairPrice+tvcount*tvPrice;
            //Console.WriteLine("Toplam Ücret:" + totalPrice);




            #endregion

            #region Klavyeden Ondalıklı Sayı Girişleri Ve Dönüşümleri
            double exam1, exam2,exam3,result;
            Console.Write("1.Sayıyı Giriniz: ");
            exam1=double.Parse(Console.ReadLine());
            
            Console.Write("2.Sayıyı Giriniz: ");
            exam2 = double.Parse(Console.ReadLine());
            
            Console.Write("3.Sayıyı Giriniz: ");
            exam3 = double.Parse(Console.ReadLine());
          
            result=exam1+exam2+exam3/3;
            
            Console.Write("Sınav Sonucunuz: "+result);
            
            
            
            
            #endregion












            Console.Read();



        }
    }
}
