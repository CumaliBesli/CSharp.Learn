using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionOOP
{
    class Canli
    {
        public string yasamAlani { get; set; }

        public void ye()
        {
            Console.WriteLine("Yemek yiyoruz..");
        }

        public void ic()
        {
            Console.WriteLine("Çay içiyoruz..");
        }

        public void TuvaleteGit()
        {
            Console.WriteLine("...");
        }

        public void SolunumYap()
        {
            if (yasamAlani == "Su")
            {
                Console.WriteLine("Hava solumuyoruz.."); 
            }
            else if (yasamAlani == "Kara")
            {
                Console.WriteLine("Hava soluyoruz..");
            }
        }
    }
}
