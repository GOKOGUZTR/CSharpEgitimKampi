using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Void Methotlar
            //void CustomerList() 
            //{
            //    Console.WriteLine("Ali Yıldız");
            //    Console.WriteLine("Ayşe Yıldız");
            //    Console.WriteLine("Hakan Çınar");
            //    Console.WriteLine("Merve Öztürk");
            //}
            //CustomerList();



            #endregion
            #region Geriye Değer Döndürmeyen Parametreli Metotlar
            //void WriteMethod(string customerName)
            //{ 
            //Console.WriteLine(customerName);
            //}
            //WriteMethod("Mehmet Yıldırım");

            //void CustomerCard(string name,string surName) 
            //{
            //Console.WriteLine("müşteri: "+name+" "+surName);

            //}
            //CustomerCard("mehmet", "yıldız");
            //CustomerCard("ayşegül","kaya");


            #endregion

            #region Geriye Değer Döndürmeyen Int Parametreli Metotlar
            //void Sum(int number1,int number2,int number3) 
            //{
            //int result=number1+number2 + number3;
            //    Console.WriteLine(result);

            //}
            //Sum(4, 5, 6);

            #endregion

            #region Geriye Değer Döndüren Metotlar

            //string StudentCart()
            //{
            //    string name = "ali";
            //    string surName = "kaya";
            //    return name + " " + surName;
            //}
            //Console.WriteLine(StudentCart());


            #endregion

            #region Geriye Değer Döndüren String Parametreli Metotlar

            //string CountryCard(string Countryname,string capital,string flagColor)
            //{
            //    string cardInfo = "Ülke: " + Countryname + "- Başkent: " + capital + "-Bayrak Rengi";
            //    return cardInfo;

            //}

            //string x, y, z;
            //Console.Write("ülke adını giriniz: ");
            //x= Console.ReadLine();
            //Console.Write("başkenti giriniz: ");
            //y = Console.ReadLine();
            //Console.Write("bayrak rengini giriniz: ");
            //z = Console.ReadLine();

            //Console.WriteLine(CountryCard(x, y, z));
            #endregion

            #region Geriye Değer Döndüren Int Parametreli Metotlar
            //int sum(int number1,int number2) { 
            //int result=number1 + number2;
            //    return result;
            //}
            //    Console.WriteLine(sum(1,24));
            //Console.WriteLine(sum(45, 28));
            //Console.WriteLine(sum(18, 46));
            //Console.WriteLine(sum(18, 25));
            //Console.WriteLine(sum(17, 42));


            #endregion

            #region Örnek Uygulama 
            //string ExamResult(string student,int exam1,int exam2,int exam3)
            //{
            //    int result = (exam1 + exam2 + exam3) / 3;
            //    if (result >= 50)
            //    {
            //        return student+ " isimli Öğrenci Sınavı Tamamladı ortalaması: "+ result;

            //    }
            //    else 
            //    {
            //        return " isimli Öğrenci Sınavı Tamamlayamadı";
            //    }
            //}
            //Console.WriteLine(ExamResult("BATUHAN", 85, 91, 86));
            //Console.WriteLine(ExamResult("AYŞE", 95, 50, 13));


            #endregion
            Console.Read();
        }
    }
}
