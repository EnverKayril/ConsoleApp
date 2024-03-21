using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2
{
    public class PersonelMemur : Personel
    {
        private double _SaatlikUcret;
        private double _Mesai;

        public int Kademe { get; set; }
        public double CalismaSaati { get; set; }
        public double Mesai
        {
            get
            {
                return _Mesai;
            }
            set
            {
                if (CalismaSaati > 180)
                {
                    _Mesai = (CalismaSaati - 180) * (SaatlikUcret * 1.5);
                }
                else { _Mesai = 0; }
            }
        }
        public double SaatlikUcret
        {
            get
            {
                return _SaatlikUcret;
            }
            set
            {
                if (Kademe == 1) _SaatlikUcret = 500;
                else if (Kademe == 2) _SaatlikUcret = 400;
                else if (Kademe == 3) _SaatlikUcret = 300;
            }
        }

        public override double MaasHesapla(double calismaSaati, double saatlikUcret, double mesai)
        {
            return (calismaSaati * saatlikUcret) + mesai;
        }

    }
}
