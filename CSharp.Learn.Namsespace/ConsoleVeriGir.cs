using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Learn.Namsespace
{
    class ConsoleVeriGir
    {
        public void GirilenDegeriAl()
        {
            while (true)
            {
                Console.Write("Veri gir: ");
                string girilenDeger = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(girilenDeger))
                {
                    Console.WriteLine("Geçerli bir veri gir..");
                }
                else
                {
                    Console.WriteLine(girilenDeger.Trim());
                    return;
                }
            }
        }

        public void EnUzunKelime()
        {
            Console.WriteLine("Cümle girin");
            string gelenCumle = Console.ReadLine();
            string aritilmisCumle = gelenCumle.Replace(",", " ").Replace(".", " ").Replace(";", " ").Replace("/", " ");
            string[] kelimeDizisi = aritilmisCumle.Split(' ');
            string enUzunKelime = "";

            for (int i = 0; i < kelimeDizisi.Length; i++)
            {
                string kelime = kelimeDizisi[i];
                if (kelime.Length > enUzunKelime.Length)
                {
                    enUzunKelime = kelime;
                }
            }
            Console.WriteLine("En uzun kelime = "+ enUzunKelime);
        }

    }
}
