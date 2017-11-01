using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HesapMakinesi
{
    class Program
    {
        static void Main(string[] args)
        {
            string gelenMetin = Console.ReadLine();
            string[] gelenMetinDizisi = gelenMetin.Split(' ');
            string[] varOlanKelimeler = new string[gelenMetinDizisi.Length];
            int[] gelenMetindekiKelimelerinSayilari = new int[gelenMetinDizisi.Length];
            int KelimeninSayisi = 0;
            int enCokKelime = 0;
            int enAzKelime = gelenMetinDizisi.Length;
            int EnCokKelimeIndeksi = 0;
            int enAzKelimeIndeksi = 0;

            //a c a d r a
            for (int i = 0; i < gelenMetinDizisi.Length; i++)
            {
                KelimeninSayisi = 0;

                if (!varOlanKelimeler.Contains(gelenMetinDizisi[i]))
                {
                    for (int j = 0; j < gelenMetinDizisi.Length; j++)
                    {
                        if (gelenMetinDizisi[i] == gelenMetinDizisi[j])
                        {
                            KelimeninSayisi++;
                        }
                    }
                    if (KelimeninSayisi > enCokKelime)
                    {
                        EnCokKelimeIndeksi = i;
                        enCokKelime = KelimeninSayisi;
                    }
                    else if (KelimeninSayisi < enAzKelime)
                    {
                        enAzKelimeIndeksi = i;
                        enAzKelime = KelimeninSayisi;
                    }
                    gelenMetindekiKelimelerinSayilari[i] = KelimeninSayisi;
                    varOlanKelimeler[i] = gelenMetinDizisi[i];
                    Console.WriteLine(gelenMetinDizisi[i] + " kelimesinin sayısı: " + KelimeninSayisi);
                }
            }

            Console.WriteLine("Metinde en çok geçen kelime: " + gelenMetinDizisi[EnCokKelimeIndeksi] + " \nMetinde en az bulunan kelime: " + gelenMetinDizisi[enAzKelimeIndeksi]);
            Console.WriteLine("NOT: Eşitlik kontrolü yapılmadığından metinde en çok geçen kelime eşitlik olduğunda ilk bulunan kelimedir. Ez az bulunan kelime eşitlik durummunda yine ilk bulunan kelimedir.");

            //int enCokOlanKelimeSayisi = gelenMetindekiKelimelerinSayilari.Min();
            //int enCokOlanKelimeIndeksi = 0;
            //int enAzOlanKelimeSayisi = gelenMetindekiKelimelerinSayilari.Max();
            //int enAzolanKelimeIndeksi = 0;

            //for (int i = 0; i < gelenMetindekiKelimelerinSayilari.Length; i++)
            //{
            //    if (gelenMetindekiKelimelerinSayilari[i] > enCokOlanKelimeSayisi)
            //    {
            //        enCokOlanKelimeSayisi = gelenMetindekiKelimelerinSayilari[i];
            //        enCokOlanKelimeIndeksi = i;
            //    }
            //    if (gelenMetindekiKelimelerinSayilari[i] < enAzOlanKelimeSayisi)
            //    {
            //        enAzOlanKelimeSayisi = gelenMetindekiKelimelerinSayilari[i];
            //        enAzolanKelimeIndeksi = i;
            //    }
            //}

            //Console.WriteLine($"En fazla bulunan kelime = {gelenMetinDizisi[enCokOlanKelimeIndeksi]} En az bulunan kelime = {gelenMetinDizisi[enAzolanKelimeIndeksi]}");
            Console.ReadLine();

            //while (true)
            //{
            //    string islem = Console.ReadLine();
            //    char[] operatorler = new char[] { '+', '-', '*', '/' };
            //    char islemTipi = ' ';

            //    //for (int i = 0; i < operatorler.Length; i++)
            //    //{                  
            //    //    if (sonuc != null)
            //    //    {
            //    //        switch (operatorler[i])
            //    //        {
            //    //            case '+': Console.WriteLine(int.Parse(sonuc[0]) + int.Parse(sonuc[1])); break;
            //    //            case '-': Console.WriteLine(int.Parse(sonuc[0]) - int.Parse(sonuc[1])); break;
            //    //            case '*': Console.WriteLine(int.Parse(sonuc[0]) * int.Parse(sonuc[1])); break;
            //    //            case '/': Console.WriteLine(int.Parse(sonuc[0]) / int.Parse(sonuc[1])); break;

            //    //            default: Console.WriteLine("İşlem operatorü geçersiz"); break;
            //    //        }
            //    //    }
            //    //}
            //    for (int i = 0; i < operatorler.Length; i++)
            //    {
            //        for (int j = 0; j < islem.Length; j++)
            //        {
            //            if (islem[j] == operatorler[i])
            //            {
            //                islemTipi = operatorler[i];
            //                break;
            //            }
            //        }
            //        if (islemTipi != ' ')
            //        {
            //            break;
            //        }
            //    }
            //    var sonuc = islem.Split(islemTipi);
            //    switch (islemTipi)
            //    {
            //        case '+': Console.WriteLine(int.Parse(sonuc[0]) + int.Parse(sonuc[1])); break;
            //        case '-': Console.WriteLine(int.Parse(sonuc[0]) - int.Parse(sonuc[1])); break;
            //        case '*': Console.WriteLine(int.Parse(sonuc[0]) * int.Parse(sonuc[1])); break;
            //        case '/': Console.WriteLine(int.Parse(sonuc[0]) / int.Parse(sonuc[1])); break;

            //        default: Console.WriteLine("İşlem operatorü geçersiz"); break;
            //    }

            //    Console.WriteLine("Tamam mı, (T) yaz, devam mı (D) yaz");
            //    string neYapak = Console.ReadLine();
            //    if (neYapak == "T")
            //    {
            //        return;
            //    }
            //    else if (neYapak == "D")
            //    {

            //    }
            //    else
            //    {
            //        Console.WriteLine("O zaman devam");
            //    }
            //}
        }
    }
}
