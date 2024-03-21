using Newtonsoft.Json;
using System.IO.Pipes;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;

namespace CSProjeDemo2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\oscar\source\repos\EnverKayril\ConsoleApp\CSProjeDemo2\Personeller.json";
            while (true)
            {
                List<Personel> personeller = DosyaOku.JsonDosyadanOku(path);
                foreach (Personel personel in personeller)
                {
                    Console.WriteLine($"Ad: {personel.Ad}, Unvan: {personel.Unvan}");
                }
            }

        }
    }
}
