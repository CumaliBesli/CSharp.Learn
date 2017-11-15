using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeYonetim.Lib
{
    public class Asci: Calisan
    {
        public Asci(string i, DateTime g, Kafe k, string gorev): base(i, g, k, gorev)
        {

        }

        public void SiparisiHazirla(Siparis siparis)
        {
            Siparisler.Add(siparis);

            foreach (var kalem in siparis.Kalemler)
            {
                kalem.Durum = SiparisDurum.Hazirlaniyor;
            }

            Console.WriteLine("Sipariş Hazırlandı.");
        }

        public void SiparisHazirlandi(Siparis siparis)
        {
            foreach (var kalem in siparis.Kalemler)
            {
                kalem.Durum = SiparisDurum.Hazirlandi;
            }

            siparis.SiparisiAlanGarson.SiparisiServisEt(siparis);
            siparis.SiparisiHazirlayanAsci = null;
        }
    }
}
