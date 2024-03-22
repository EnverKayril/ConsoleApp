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

        public static void PrintYoneticiMaaslari(List<Personel> personeller)
        {
            Console.WriteLine("YÖNETİCİ LİSTESİ");
            foreach (Personel personel in personeller)
            {
                if (personel is PersonelYonetici)
                {
                    PersonelYonetici yonetici = (PersonelYonetici)personel;
                    Console.WriteLine($"" +
                        $"Personel İsmi : {yonetici.Ad}\n" +
                        $"Çalışma Saati : {yonetici.CalismaSaati}\n" +
                        $"Saatlik Ücret : {yonetici.SaatlikUcret} TL\n" +
                        $"Bonus         : {yonetici.Bonus} TL\n" +
                        $"Toplam Ödeme  : {yonetici.MaasHesapla(yonetici.CalismaSaati, yonetici.SaatlikUcret, yonetici.Bonus)} TL\n");
                }
            }

        }
    }
}
