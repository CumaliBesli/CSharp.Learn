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
        private static string connStr = "Data Source=DESKTOP-S3O5AOR; Initial Catalog=KafeYonetim; Integrated Security=true";
        private static SqlConnection CreateConnection()
        {
            var connection = new SqlConnection(connStr);
            connection.Open();

            return connection;
        }
        public static void KafeBilgisiniYazdir()
        {
            //var connection = new SqlConnection("Data Source=DESKTOP-S3O5AOR; Initial Catalog=KafeYonetim; Integrated Security=true");

            //connection.Open();

            //var command = new SqlCommand("Select Top 1 * from Kafe", connection);

            //var result = command.ExecuteReader();


            //result.Read();
            //Console.WriteLine($"Kafe Adı: {result["Ad"]}");
            //Console.WriteLine($"Kafe Durumu: {result["Durum"]}");

            //result.Close();
            //connection.Close();

            //Console.ReadLine();
            using (var connection = CreateConnection())
            {
                var command = new SqlCommand("Select Top 1 * from Kafe", connection);

                using (var result = command.ExecuteReader())
                {
                    result.Read();
                    Console.WriteLine($"Kafe Adı: {result["Ad"]}");
                    Console.WriteLine($"Kafe Durumu: {result["Durum"]}");
                }
            }
            Console.ReadLine();
        }

        public static void UrunListesiniYazdir()
        {
            //var connection = new SqlConnection("Data Source=DESKTOP-S3O5AOR; Initial Catalog=KafeYonetim; Integrated Security=true");

            //connection.Open();

            //var command = new SqlCommand("Select * from Urunler", connection);

            //var result = command.ExecuteReader();

            //while (result.Read())
            //{
            //    Console.Write($"Id: {result["Id"].ToString().PadRight(20)}");
            //    Console.Write($"Adı: {result["Ad"].ToString().PadRight(20)} ");
            //    Console.Write($"Fiyatı: {result["Fiyat"].ToString().PadRight(20)} ");
            //    Console.Write($"Stok Durumu: {result["StoktaVarMi"]}");
            //    Console.WriteLine();
            //}

            //result.Close();
            //connection.Close();

            //Console.ReadLine();

            using (var connection = CreateConnection())
            {
                var command = new SqlCommand("Select * from Urunler", connection);
                using (var result = command.ExecuteReader())
                {
                    while (result.Read())
                    {
                        Console.Write($"Id: {result["Id"].ToString().PadRight(20)}");
                        Console.Write($"Adı: {result["Ad"].ToString().PadRight(20)} ");
                        Console.Write($"Fiyatı: {result["Fiyat"].ToString().PadRight(20)} ");
                        Console.Write($"Stok Durumu: {result["StoktaVarMi"]}");
                        Console.WriteLine();
                    }
                }
                Console.ReadLine();
            }
        }

        public static void UrunFiyatiniGetir()
        {
            //var connection = new SqlConnection("Data Source=DESKTOP-S3O5AOR;Initial Catalog=KafeYonetim;Integrated Security=True");

            //connection.Open();

            //Console.WriteLine("Ürün adı yazınız: ");
            //string urunAdi = Console.ReadLine();

            ////var command = new SqlCommand($"SELECT Fiyat FROM Urunler WHERE Ad = '{urunAdi}' ", connection);

            //var command = new SqlCommand($"SELECT Fiyat FROM Urunler WHERE Ad = @Ad", connection);

            //command.Parameters.AddWithValue("@Ad", urunAdi);

            //var result = (double)command.ExecuteScalar();

            //Console.WriteLine($"{urunAdi} ürününün fiyatı: {result}");

            //connection.Close();

            //Console.ReadLine();

            using (var connection = CreateConnection())
            {
                Console.WriteLine("Ürün adı yazınız: ");
                string urunAdi = Console.ReadLine();
                var command = new SqlCommand($"SELECT Fiyat FROM Urunler WHERE Ad = @Ad", connection);

                command.Parameters.AddWithValue("@Ad", urunAdi);

                var result = (double)command.ExecuteScalar();

                Console.WriteLine($"{urunAdi} ürününün fiyatı: {result}");
            }
            Console.ReadLine();

        }

        public static void DegerdenYuksekFiyatliUrunleriGetir()
        {
            //var connection = new SqlConnection("Data Source=DESKTOP-S3O5AOR;Initial Catalog=KafeYonetim;Integrated Security=True");

            //connection.Open();

            //Console.Write("Bir değer giriniz: ");
            //var deger = Console.ReadLine();

            //var command = new SqlCommand("SELECT * FROM Urunler WHERE fiyat > @deger", connection);
            //command.Parameters.AddWithValue("@deger", double.Parse(deger));

            //var result = command.ExecuteReader();

            //while (result.Read())
            //{
            //    Console.Write($"{result["ad"]}");
            //    Console.Write($"{result["Fiyat"]}");
            //    Console.WriteLine();
            //}

            //result.Close();
            //connection.Close();

            //Console.ReadLine();

            using (var connection = CreateConnection())
            {
                var command = new SqlCommand("SELECT * FROM Urunler WHERE fiyat > @deger", connection);
                Console.Write("Bir değer giriniz: ");
                var deger = Console.ReadLine();
                command.Parameters.AddWithValue("@deger", double.Parse(deger));
                using (var result = command.ExecuteReader())
                {
                    while (result.Read())
                    {
                        Console.Write($"{result["ad"]}");
                        Console.Write($"{result["Fiyat"]}");
                        Console.WriteLine();
                    }
                }
                Console.ReadLine();
            }

        }

        public static void UrunGir()
        {
            //var connection = new SqlConnection("Data Source=DESKTOP-S3O5AOR;Initial Catalog=KafeYonetim;Integrated Security=True");

            //connection.Open();

            //Console.Write("Ürün Adını giriniz: ");
            //var ad = Console.ReadLine();

            //Console.Write("Ürün fiyatını giriniz: ");
            //var fiyat = double.Parse(Console.ReadLine());

            //Console.Write("Ürün stokta var mı? (e/h): ");
            //var stok = (Console.ReadLine() == "e") ? true : false;

            //var command = new SqlCommand("INSERT INTO Urunler (ad, fiyat, stoktavarmi) VALUES (@ad, @fiyat, @stoktaVarMi)", connection);
            //command.Parameters.AddWithValue("@ad", ad);
            //command.Parameters.AddWithValue("@fiyat", fiyat);
            //command.Parameters.AddWithValue("@stoktaVarMi", stok);

            //var result = command.ExecuteNonQuery();


            //if (result > 0)
            //{
            //    Console.WriteLine("Kayıt eklendi.");
            //}

            //connection.Close();

            //Console.ReadLine();

            using (var connection = CreateConnection())
            {
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
            }
            Console.ReadLine();
        }

        public static void UrunSil()
        {
            //UrunListesiniYazdir();
            //var connection = new SqlConnection("Data Source=DESKTOP-S3O5AOR; Initial Catalog=KafeYonetim; Integrated Security=True");
            //connection.Open();
            //Console.WriteLine("Silmek istediğiniz ürünlerin Id'lerini giriniz..");
            //string[] Idler = Console.ReadLine().Split(',');
            //var command = new SqlCommand("Delete from Urunler Where Id =@ID", connection);
            //command.Parameters.Add(new SqlParameter("@ID", System.Data.SqlDbType.Int));
            //for (int i = 0; i < Idler.Length; i++)
            //{
            //    command.Parameters["@ID"].Value = int.Parse(Idler[i]);
            //    command.ExecuteNonQuery();
            //}


            //connection.Close();
            //Console.WriteLine("Kayıtlar Silindi");
            //UrunListesiniYazdir();

            UrunListesiniYazdir();
            using (var connection = CreateConnection())
            {
                Console.WriteLine("Silmek istediğiniz ürünlerin Id'lerini giriniz..");
                string[] Idler = Console.ReadLine().Split(',');
                var command = new SqlCommand("Delete from Urunler Where Id =@ID", connection);
                command.Parameters.Add(new SqlParameter("@ID", System.Data.SqlDbType.Int));
                for (int i = 0; i < Idler.Length; i++)
                {
                    command.Parameters["@ID"].Value = int.Parse(Idler[i]);
                    command.ExecuteNonQuery();
                }
            }
            UrunListesiniYazdir();
        }

        public static void UrunGuncelle()
        {
            using (var connection = CreateConnection())
            {
                UrunListesiniYazdir();
                Console.WriteLine("Güncellemek istediğiniz ürürnün Id'sini yazın..");
                var ID = Console.ReadLine();
                var command = new SqlCommand("Update Urunler set Ad=@Adi,Fiyat=@Fiyat, StoktaVarMi=@VarMi where Id=@ID", connection);
                Console.Write("Yeni Adı: ");
                string YeniAdi = Console.ReadLine();
                Console.Write("Yeni Fiyat: ");
                float YeniFiyat = float.Parse(Console.ReadLine());
                Console.Write("Yeni Stok Durumu: ");
                bool YeniVarMi = bool.Parse(Console.ReadLine());

                command.Parameters.AddWithValue("@ID", ID);
                command.Parameters.AddWithValue("@Adi", YeniAdi);
                command.Parameters.AddWithValue("@Fiyat", YeniFiyat);
                command.Parameters.AddWithValue("@VarMi", YeniVarMi);

                command.ExecuteNonQuery();

                Console.WriteLine("Ürün Güncellendi");

                UrunListesiniYazdir();

            }
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
