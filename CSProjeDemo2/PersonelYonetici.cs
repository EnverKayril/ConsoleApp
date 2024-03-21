using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2
{
    public class PersonelYonetici : Personel
    {

        public double CalismaSaati { get; set; }
        public double SaatlikUcret { get; set; }
        public double Bonus { get; set; }

        public override double MaasHesapla(double calismaSaati, double saatlikUcret, double bonus)
        {
            return (calismaSaati * saatlikUcret) + bonus;
        }
    }
}
