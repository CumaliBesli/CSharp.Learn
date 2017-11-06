using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionOOP
{
    class Bitki:Canli
    {
        public bool AgactaMiYetisir { get; set; }
        public string Cinsi { get; set; }

        public void FotosentezYap()
        {
            Console.WriteLine("Karbondioksit aaal, oksijen veer..");
        }
    }
}
