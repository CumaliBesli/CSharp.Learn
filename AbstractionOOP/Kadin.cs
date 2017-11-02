using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionOOP
{
    class Kadin : Insan
    {
        public string kizlikSoyadi { get; set; }

        public void DirdirYap()
        {
            Console.WriteLine("Boyun posun devrilmeye..");
        }

        public void EviToparla()
        {
            Console.WriteLine("Kim uğraşacak..");
        }

        public void YemekYap()
        {
            Console.WriteLine("Akşam malta çorbası var..");
        }
    }
}
