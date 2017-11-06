using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionOOP
{
    class Hayvan:Canli
    {
        public string Cinsi { get; set; }
        public string Adi { get; set; }
        public int Yasi { get; set; }

        public void Yuru()
        {
            Console.WriteLine("Yürüyor..");
        }

        public void Uyu()
        {
            Console.WriteLine("Uyuyor..");
        }

        public void Kos()
        {
            Console.WriteLine("Kosuyor..");
        }

        public void Uyan()
        {
            Console.WriteLine("Kalkıyor..");
        }
    }
}
