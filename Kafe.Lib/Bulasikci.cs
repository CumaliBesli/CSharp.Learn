using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeYonetim.Lib
{
    public class Bulasikci : Calisan
    {
        public int Prim { get; set; }

        public Bulasikci(string i, DateTime igt, Kafe k) : base(i, igt, k)
        {

        }

        public string bulasiklariYika()
        {
            return "Bulaşıklar yıkanıyor..";
        }
    }
}
