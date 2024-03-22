using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2
{
    public class MaasBordro
    {
        public static void MaasHesapla(List<Personel> personeller)
        {
            foreach (Personel personel in personeller)
            {
                Console.WriteLine("");
                if (personel is PersonelYonetici)
                {
                    PersonelYonetici yonetici = (PersonelYonetici)personel;
                    Console.WriteLine($"Lütfen '{yonetici.Ad}' isimli yöneticinin bilgilerini giriniz. ");
                    while (true)
                    {
                        try
                        {
                            Console.Write("Çalışma saati: ");
                            yonetici.CalismaSaati = double.Parse(Console.ReadLine());
                            Console.Write("Saatlik ücreti: ");
                            double saatlikUcret = double.Parse(Console.ReadLine());
                            if (saatlikUcret < 500)
                            {
                                Console.WriteLine("Yöneticinin saatlik ücreti '500'ün altında olamaz.");
                                continue;
                            }
                            yonetici.SaatlikUcret = saatlikUcret;

                            Console.Write("Bonus giriniz: ");
                            yonetici.Bonus = double.Parse(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Hatalı giriş yaptınız.");
                        }
                    }
                }
                else if (personel is PersonelMemur)
                {
                    PersonelMemur memur = (PersonelMemur)personel;
                    while (true)
                    {

                        Console.WriteLine($"Lütfen '{memur.Ad}' isimli memurun bilgilerini giriniz. ");
                        try
                        {
                            Console.Write("Kademesi: ");
                            memur.Kademe = int.Parse(Console.ReadLine());
                            Console.Write("Çalışma saati: ");
                            memur.CalismaSaati = double.Parse(Console.ReadLine());
                            break;
                        }
                        catch
                        {
                            Console.WriteLine("Hatalı giriş yaptınız. ");
                        }
                    }
                }
            }
        }
        public static void WriteSalary(List<Personel> personeller)
        {
            string memurPath = @"C:\Users\oscar\source\repos\EnverKayril\ConsoleApp\CSProjeDemo2\MaasMemur.txt";
            string yoneticiPath = @"C:\Users\oscar\source\repos\EnverKayril\ConsoleApp\CSProjeDemo2\MaasYonetici.txt";

            using (StreamWriter memurSW = new StreamWriter(memurPath))
            using (StreamWriter yoneticiSW = new StreamWriter(yoneticiPath))
            {
                foreach (Personel personel in personeller)
                {
                    if (personel is PersonelMemur)
                    {
                        PersonelMemur memur = (PersonelMemur)personel;
                        memurSW.WriteLine($"" +
                            $"Personel İsmi : {memur.Ad}\n" +
                            $"Kademesi      : {memur.Kademe}\n" +
                            $"Çalışma Saati : {memur.CalismaSaati}\n" +
                            $"Saatlik Ücret : {memur.SaatlikUcret} TL\n" +
                            $"Mesai Ücreti  : {memur.Mesai} TL\n" +
                            $"Toplam Ödeme  : {memur.MaasHesapla(memur.CalismaSaati, memur.SaatlikUcret, memur.Mesai)} TL\n");
                    }
                    else if (personel is PersonelYonetici)
                    {
                        PersonelYonetici yonetici = (PersonelYonetici)personel;
                        yoneticiSW.WriteLine($"" +
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
}