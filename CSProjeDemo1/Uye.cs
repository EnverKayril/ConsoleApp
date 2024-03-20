using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public class Uye : IUye
    {
        public Uye(string id, string name, string lastName, int age)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            Age = age;
            Email = $"{Converter(Name)}.{Converter(lastName)}@mail.com";
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public static List<Kitap> UyeninAldigiKitaplar { get; set; }

        private static string Converter(string name)
        {
            string newName = name.ToLower().
                Replace('ğ', 'g').
                Replace('ç', 'c').
                Replace('ı', 'i').
                Replace('ö', 'o').
                Replace('ü', 'u').
                Replace('ş', 's');

            return newName;
        }

        public static void UyeSorgula(List<OduncVerilenKitaplar> liste)
        {
            Console.WriteLine("Uye Adı veya Id giriniz: ");
            string uyeInfo = Console.ReadLine();
            List<OduncVerilenKitaplar> uyeninKitaplari = new List<OduncVerilenKitaplar>();
            foreach (var item in liste)
            {
                if (item.MemberID == uyeInfo || item.MemberName == uyeInfo)
                {
                    uyeninKitaplari.Add(item);
                }
            }
            if (uyeninKitaplari.Count == 0)
            {
                Console.WriteLine("Bu üye henüz kitap almadı.");
            }
            else
            {
                Console.WriteLine($"{"ISBN",-9}{"Kitap Adı",-30}{"Uye Id",-9}{"Uye Adı",-15}{"Soyadı",-15}");
                foreach (OduncVerilenKitaplar item in uyeninKitaplari)
                {
                    Console.WriteLine($"{item.BookId,-9}{item.BookName,-30}{item.MemberID,-9}{item.MemberName,-15}{item.MemberLastName,-15}");
                }
            }


        }


    }
        
}
