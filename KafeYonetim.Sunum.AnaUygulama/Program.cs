using KafeYonetimData;
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
            //var dataManager = new DataManager();

            //dataManager.KafeBilgisiniYazdir();

            //dataManager.UrunListesiniYazdir();

            //dataManager.UrunFiyatiniGetir();

            //dataManager.DegerdenYuksekFiyatliUrunleriGetir();

            //dataManager.UrunGir();

            //dataManager.UrunSil();

            //DataManager.KafeBilgisiniYazdir();
            //DataManager.UrunListesiniYazdir();
            //DataManager.UrunFiyatiniGetir();
            //DataManager.DegerdenYuksekFiyatliUrunleriGetir();
            //DataManager.UrunGir();
            //DataManager.UrunSil();
            DataManager.UrunGuncelle();

            Console.ReadLine();
        }
    }
}