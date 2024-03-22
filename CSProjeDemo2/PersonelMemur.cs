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
                if (CalismaSaati > 180)
                {
                    return (CalismaSaati - 180) * SaatlikUcret * 1.5;
                }
                else return 0;
            }
        }
        public double SaatlikUcret
        {
            get
            {
                if (Kademe == 1) return 500;
                else if (Kademe == 2) return 400;
                else if (Kademe == 3) return 300;
                else return 0;
            }
        }

        public override double MaasHesapla(double calismaSaati, double saatlikUcret, double mesai)
        {
            return (calismaSaati * saatlikUcret) + mesai;
        }

        public static void PrintMemurMaaslari(List<Personel> personeller)
        {
            Console.WriteLine("MEMUR LİSTESİ");
            foreach (Personel personel in personeller)
            {
                if (personel is PersonelMemur)
                {
                    PersonelMemur memur = (PersonelMemur)personel;

                    Console.WriteLine($"" +
                        $"Personel İsmi : {memur.Ad}\n" +
                        $"Kademesi      : {memur.Kademe}\n" +
                        $"Çalışma Saati : {memur.CalismaSaati}\n" +
                        $"Saatlik Ücret : {memur.SaatlikUcret} TL\n" +
                        $"Mesai Ücreti  : {memur.Mesai} TL\n" +
                        $"Toplam Ödeme  : {memur.MaasHesapla(memur.CalismaSaati, memur.SaatlikUcret, memur.Mesai)} TL\n");
                }
            }
        }
        public static void AzCalisanPersonel(List<Personel> personeller)
        {
            Console.WriteLine("\nMEMUR LİSTESİ\n");
            foreach (Personel personel in personeller)
            {
                if (personel is PersonelMemur)
                {
                    PersonelMemur memur = (PersonelMemur)personel;
                    if (memur.CalismaSaati <= 10)
                    {
                    Console.WriteLine($"" +
                        $"Personel İsmi : {memur.Ad}\n" +
                        $"Kademesi      : {memur.Kademe}\n" +
                        $"Çalışma Saati : {memur.CalismaSaati}\n" +
                        $"Saatlik Ücret : {memur.SaatlikUcret} TL\n" +
                        $"Mesai Ücreti  : {memur.Mesai} TL\n" +
                        $"Toplam Ödeme  : {memur.MaasHesapla(memur.CalismaSaati, memur.SaatlikUcret, memur.Mesai)} TL\n");
                    }
                }
            }
        }
    }
}
