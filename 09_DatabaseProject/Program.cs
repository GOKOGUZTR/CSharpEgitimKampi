    using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_DatabaseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** Veri Tabanlı Ürün-Kategori Bilgi Sistemi *****");
            Console.WriteLine();
            Console.WriteLine();

            string tableNumber;
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("1-Kategoriler");
            Console.WriteLine("1-Ürünler");
            Console.WriteLine("1-Siparişler");
            Console.WriteLine("1-Çıkış Yağ");
            Console.Write("Lütfen getirmek istediğiniz tablo numarasaını giriniz: ");
            tableNumber = Console.ReadLine();
            Console.WriteLine("-----------------------------------------");

            SqlConnection connection = new SqlConnection(" Data Source= DESKTOP-FBG2IBT;initial Catalog=EğitimKampiDb;integrated security=true ");
            connection.Open();
            SqlCommand command = new SqlCommand("Select * from TblCategory", connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            connection.Close();

            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {

                    Console.Write(item.ToString());
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
