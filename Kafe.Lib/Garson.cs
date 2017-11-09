using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeYonetim.Lib
{
    public class Garson : Calisan
    {
        public Garson(string i, DateTime g, Kafe k) : base(i, g, k)
        {

        }

        public void MasaAc()
        {
            Console.WriteLine("Masa açıldı.");
        }
        Asci asci;
        public void SiparisAl(Siparis siparis)
        {
            Siparisler.Add(siparis);
            asci = Kafe.UygunAsciBul(CalisanDurum.Uygun);//OVERLOAD
            asci.SiparisiHazirla(siparis);

            Console.WriteLine("Sipariş alındı.");
        }

        public void SiparisiServisEt(SiparisDurum durum)
        {
            if (durum == SiparisDurum.Hazir)
            {
                Console.WriteLine("Sipariş servis edildi.");
            }
            else
            {
                Console.WriteLine("Hazırlanıyor..");
            }
        }

        public void OdemeAl()
        {
            Console.WriteLine("Ödeme alındı.");
        }
    }
}
