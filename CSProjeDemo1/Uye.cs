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



    }
        
}
