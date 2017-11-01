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
            int enCokOlanKelimeSayisi = 0;
            int enAzOlanKelimeSayisi = 0;

            //a c a d r a
            for (int i = 0; i < gelenMetinDizisi.Length; i++)
            {
                KelimeninSayisi = 0;

                for (int j = 0; j < gelenMetinDizisi.Length; j++)
                {
                    if (gelenMetinDizisi[i] == gelenMetinDizisi[j])
                    {
                        KelimeninSayisi++;
                    }
                }
                gelenMetindekiKelimelerinSayilari[i] = KelimeninSayisi;
                varOlanKelimeler[i] = gelenMetinDizisi[i];
            }

            for (int i = 0; i < gelenMetindekiKelimelerinSayilari.Length; i++)
            {
                if (gelenMetindekiKelimelerinSayilari[i] > enCokOlanKelimeSayisi)
                {
                    enCokOlanKelimeSayisi = i;
                }
                if (gelenMetindekiKelimelerinSayilari[i] < enAzOlanKelimeSayisi)
                {
                    enAzOlanKelimeSayisi = i;
                }
            }

            Console.WriteLine($"En fazla bulunan kelime = {gelenMetinDizisi[enCokOlanKelimeSayisi]} En az bulunan kelime = {gelenMetinDizisi[enCokOlanKelimeSayisi]}");
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
