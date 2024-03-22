using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2
{
    public class DosyaOku
    {
        public static List<Personel> GetPersons(string path)
        {
            List<Personel> personeller = new List<Personel>();
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.EndOfStream != true)
                {
                    string line = sr.ReadLine();
                    string[] addPerson = line.Split('-');
                    Personel personel = CreatePerson(addPerson);
                    personeller.Add(personel);
                }
            }
            return personeller;
        }

        private static Personel CreatePerson(string[] addPerson)
        {
            string title = addPerson[1].Trim();
            if (title == "Yönetici")
            {
                return new PersonelYonetici
                {
                    Ad = addPerson[0],
                    Unvan = addPerson[1]
                };
            }
            else if (title == "Memur")
            {
                return new PersonelMemur
                {
                    Ad = addPerson[0],
                    Unvan = addPerson[1]
                };
            }
            else return null;
        }

    }
    
}
