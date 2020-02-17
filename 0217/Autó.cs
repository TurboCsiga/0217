using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0217
{
    class Autó
    {
        private string marka;
        private string modell;
        private int evjarat;
        private int megtett;
        private string uzemenyag;
        private int ar;        

        public Autó(string marka, string modell, int evjarat, int megtett, string uzemenyag, int ar)
        {
            this.marka = marka;
            this.modell = modell;
            this.evjarat = evjarat;
            this.megtett = megtett;
            this.uzemenyag = uzemenyag;
            this.ar = ar;
        }

        public string Marka { get => marka; set => marka = value; }
        public string Modell { get => modell; set => modell = value; }
        public int Evjarat { get => evjarat; set => evjarat = value; }
        public int Megtett { get => megtett; set => megtett = value; }
        public string Uzemenyag { get => uzemenyag; set => uzemenyag = value; }
        public int Ar { get => ar; set => ar = value; }

        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}", marka, modell, evjarat, megtett, uzemenyag, ar);
        }
    } 
} 
