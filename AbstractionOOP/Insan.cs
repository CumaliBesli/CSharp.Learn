using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionOOP
{
    class Insan:Canli
    {
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public int Yas { get; set; }
        public bool evliMi { get; set; }

        public void Yuru()
        {
            Console.WriteLine("Yürüyorum..");
        }

        public void Uyu()
        {
            Console.WriteLine("Uyuyorum..");
        }

        public void Kos()
        {
            Console.WriteLine("Kosuyorum..");
        }

        public void Uyan()
        {
            Console.WriteLine("5 dakka daha..");
        }

        public string KendiniTanit()
        {
            return $"Adım {Adi + " " + Soyadi}, {Yas} yaşındayım..";
        }
    }
}
