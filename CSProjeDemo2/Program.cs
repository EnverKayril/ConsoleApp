using Newtonsoft.Json;
using System.ComponentModel;
using System.IO.Pipes;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

namespace CSProjeDemo2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\oscar\source\repos\EnverKayril\ConsoleApp\CSProjeDemo2\Personeller.txt";
            string secim = "";
            bool isRun = true;
            List<Personel> personeller = new List<Personel>();

            Console.WriteLine("Personel Maaş Hesaplayıcı");

            while (isRun)
            {
                Console.WriteLine("\n" +
                    "Personel maaş hesaplama \t [1]\n" +
                    "Personel maaş görüntüleme\t [2]\n" +
                    "10 saatten az çalışan personelleri görüntüleme [3]\n" +
                    "Bilgileri kaydetmek için\t [4]\n" +
                    "Çıkış yapmak için [0]\n");

                Console.Write("Seçim yapınız: ");
                secim = Console.ReadLine();
                switch (secim)
                {
                    case "0":
                        isRun = false;
                        Console.WriteLine("Çıkış Yapılıyor...");
                        break;
                    case "1":
                        personeller = DosyaOku.GetPersons(path);
                        MaasBordro.MaasHesapla(personeller);
                        Console.WriteLine("Bilgiler başarıyla kaydedildi.");
                        break;

                    case "2":
                        if (personeller.Count == 0)
                        {
                            Console.WriteLine("Liste henüz oluşturulmadı.");
                        }
                        else
                        {
                        Console.WriteLine("Personel bilgileri yazdırılıyor.\n");
                        Console.WriteLine($"{DateTime.Now.ToString("MMMM")}  {DateTime.Now.Year}");
                        PersonelYonetici.PrintYoneticiMaaslari(personeller);
                        PersonelMemur.PrintMemurMaaslari(personeller);
                        }
                        break;

                    case "3":
                        if (personeller.Count == 0)
                        {
                            Console.WriteLine("Liste henüz oluşturulmadı.");
                        }
                        else
                        {
                            PersonelMemur.AzCalisanPersonel(personeller);
                        }
                        break;

                    case "4":
                        if (personeller.Count == 0)
                        {
                            Console.WriteLine("Liste henüz oluşturulmadı.");
                        }
                        else
                        {
                        MaasBordro.WriteSalary(personeller);
                        }
                        break;
                }
            }
        }
    }
}
