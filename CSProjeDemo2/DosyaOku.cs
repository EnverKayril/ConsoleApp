using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2
{
    public class DosyaOku
    {
        public static List<Personel> JsonDosyadanOku(string path)
        {
            string json = File.ReadAllText(path);
            List<Personel> personelListesi = JsonConvert.DeserializeObject<List<Personel>>(json);
            return personelListesi;
        }
        

    }
    
}
