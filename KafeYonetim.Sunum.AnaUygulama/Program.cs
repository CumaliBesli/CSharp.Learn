using KafeYonetim.Data;
using KafeYonetim.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeYonetim.Sunum.AnaUygulama
{
    class Program
    {
        static void Main(string[] args)
        {

            //DataManager.KafeBilgisiniYazdir();

            //dataManager.UrunListesiniYazdir();

            //dataManager.KafeAdiniGetir();

            //DataManager.UrunFiyatiniGetir();

            //dataManager.DegerdenYuksekFiyatliUrunleriGetir();            

            //dataManager.UrunGir();

            // dataManager.KapatilmamimsBaglanti();

            //dataManager.SecilenUrunleriSil();

            //Console.Write("Ürün Adı: ");
            //string adi = Console.ReadLine();

            //Console.Write("Fiyatı: ");
            //float fiyat = float.Parse(Console.ReadLine());

            //Console.Write("Stokta Var mı?(var/yok): ");
            //bool stokDurumu = (Console.ReadLine() == "var") ? true : false;

            //Console.WriteLine(DataManager.UrunGir(adi, fiyat, stokDurumu));

            TumUrunleriListele();
            FiyattanBuyukUrunleriListele();
        }

        static void UrunListele(List<Urun> UrunListesi)
        {
            Console.WriteLine($"{"Isim".PadRight(33)} {"Fiyat".PadRight(25)} Stok Durumu");
            foreach (var urun in UrunListesi)
            {
                Console.WriteLine("".PadRight(60, '='));
                Console.WriteLine($"Adı: {urun.Ad.PadRight(25)}, Fiyatı: {urun.Fiyat.ToString().PadRight(15)}, Stok Durumu: {urun.StoktaVarmi}");
            }
            Console.ReadLine();
        }

        static void TumUrunleriListele()
        {
            UrunListele(DataManager.UrunListesiniYazdir());
        }

        static void FiyattanBuyukUrunleriListele()
        {
            Console.Write("Bir değer giriniz: ");            
            UrunListele(DataManager.DegerdenYuksekFiyatliUrunleriGetir(Console.ReadLine()));
        }

    }
}
