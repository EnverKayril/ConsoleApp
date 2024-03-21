using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2
{
    public abstract class Personel
    {
        public string Ad { get; set; }
        public string Unvan { get; set; }

        public abstract double MaasHesapla(double calismaSaati, double saatlikUcret, double mesai);

    }
}
