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
            DataManager dataManager = new DataManager();
            //dataManager.KafeBilgisiniYazdir();

            //dataManager.UrunListesiniYazdir();

            //dataManager.YuksekFiyatliyiGetir();

            dataManager.UrunEkle();

            Console.ReadLine();
        }
    }
}
