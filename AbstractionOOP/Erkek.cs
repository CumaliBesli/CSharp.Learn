using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionOOP
{
    class Erkek : Insan
    {
        public bool issizMi { get; set; }        

        public void EveYuru()
        {
            Console.WriteLine("Eve gidiyom..");
        }

        public void BakkalaGit()
        {
            Console.WriteLine("Bakkala gidiyom..");
        }

    }
}
