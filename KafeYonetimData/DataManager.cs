using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeYonetimData
{
    public class DataManager
    {
        public void KafeBilgisiniYazdir()
        {
            var connection = new SqlConnection("Data Source=DESKTOP-S3O5AOR; Initial Catalog=KafeYonetim; Integrated Security=true");

            connection.Open();

            var command = new SqlCommand("Select Top 1 * from Kafe", connection);

            var result = command.ExecuteReader();


            result.Read();
            Console.WriteLine($"Kafe Adı: {result["Ad"]}");
            Console.WriteLine($"Kafe Durumu: {result["Durum"]}");

            result.Close();
            connection.Close();

            Console.ReadLine();
        }

        public void UrunListesiniYazdir()
        {
            var connection = new SqlConnection("Data Source=DESKTOP-S3O5AOR; Initial Catalog=KafeYonetim; Integrated Security=true");

            connection.Open();

            var command = new SqlCommand("Select * from Urunler", connection);

            var result = command.ExecuteReader();

            while (result.Read())
            {
                Console.Write($"{result["Ad"]} ");
                Console.Write($"{result["Fiyat"]} ");
                Console.Write($"{result["StoktaVarMi"]}");
                Console.WriteLine();
            }

            result.Close();
            connection.Close();

            Console.ReadLine();
        }

        public void UrunFiyatiniGetir()
        {
            var connection = new SqlConnection("Data Source=DESKTOP-S3O5AOR;Initial Catalog=KafeYonetim;Integrated Security=True");

            connection.Open();

            Console.WriteLine("Ürün adı yazınız: ");
            string urunAdi = Console.ReadLine();

            //var command = new SqlCommand($"SELECT Fiyat FROM Urunler WHERE Ad = '{urunAdi}' ", connection);

            var command = new SqlCommand($"SELECT Fiyat FROM Urunler WHERE Ad = @Ad", connection);

            command.Parameters.AddWithValue("@Ad", urunAdi);

            var result = (double)command.ExecuteScalar();

            Console.WriteLine($"{urunAdi} ürününün fiyatı: {result}");

            connection.Close();

            Console.ReadLine();

        }        

        public void DegerdenYuksekFiyatliUrunleriGetir()
        {
            var connection = new SqlConnection("Data Source=DESKTOP-S3O5AOR;Initial Catalog=KafeYonetim;Integrated Security=True");

            connection.Open();

            Console.Write("Bir değer giriniz: ");
            var deger = Console.ReadLine();

            var command = new SqlCommand("SELECT * FROM Urunler WHERE fiyat > @deger", connection);
            command.Parameters.AddWithValue("@deger", double.Parse(deger));

            var result = command.ExecuteReader();

            while (result.Read())
            {
                Console.Write($"{result["ad"]}");
                Console.Write($"{result["Fiyat"]}");
                Console.WriteLine();
            }

            result.Close();
            connection.Close();

            Console.ReadLine();

        }

        public void UrunGir()
        {
            var connection = new SqlConnection("Data Source=DESKTOP-S3O5AOR;Initial Catalog=KafeYonetim;Integrated Security=True");

            connection.Open();

            Console.Write("Ürün Adını giriniz: ");
            var ad = Console.ReadLine();

            Console.Write("Ürün fiyatını giriniz: ");
            var fiyat = double.Parse(Console.ReadLine());

            Console.Write("Ürün stokta var mı? (e/h): ");
            var stok = (Console.ReadLine() == "e") ? true : false;

            var command = new SqlCommand("INSERT INTO Urunler (ad, fiyat, stoktavarmi) VALUES (@ad, @fiyat, @stoktaVarMi)", connection);
            command.Parameters.AddWithValue("@ad", ad);
            command.Parameters.AddWithValue("@fiyat", fiyat);
            command.Parameters.AddWithValue("@stoktaVarMi", stok);

            var result = command.ExecuteNonQuery();


            if (result > 0)
            {
                Console.WriteLine("Kayıt eklendi.");
            }

            connection.Close();

            Console.ReadLine();

        }

        //public void YuksekFiyatliyiGetir()
        //{
        //    var connection = new SqlConnection("Data Source=DESKTOP-S3O5AOR; Initial Catalog=KafeYonetim; Integrated Security=true");

        //    connection.Open();

        //    double fiyat = double.Parse(Console.ReadLine());
        //    var command = new SqlCommand("Select * from Urunler where fiyat > @Fiyat", connection);

        //    command.Parameters.AddWithValue("@Fiyat", fiyat);

        //    var result = command.ExecuteReader();
        //    while (result.Read())
        //    {
        //        Console.WriteLine($"Adı: {result["Ad"]}, Fiyatı: {result["Fiyat"]}");
        //    }

        //    result.Close();
        //    connection.Close();

        //    Console.ReadLine();
        //}

        //public void UrunEkle()
        //{
        //    string Adi = Console.ReadLine();
        //    double Fiyat = double.Parse(Console.ReadLine());
        //    byte VarMi = byte.Parse(Console.ReadLine());

        //    var connection = new SqlConnection("Data Source=DESKTOP-S3O5AOR; Initial Catalog=KafeYonetim; Integrated Security=true");

        //    connection.Open();

        //    var command = new SqlCommand("insert into Urunler (Ad, Fiyat, StoktaVarMi) values(@ad, @fiyat, @StokVarMi)", connection);

        //    command.Parameters.AddWithValue("@ad", Adi);
        //    command.Parameters.AddWithValue("@fiyat", Fiyat);
        //    command.Parameters.AddWithValue("@StokVarMi", VarMi);

        //    command.ExecuteNonQuery();

        //    connection.Close();

        //    Console.WriteLine("Eklendi");

        //    UrunListesiniYazdir();
        //}
    }
}
