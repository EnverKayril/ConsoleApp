using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace IMDbTop50
{
    public partial class Movies
    {
        public static void Top50()
        {
        bool isRun = true;
            while (isRun)
            {
                Operator();
                string path = "";
                int select1 = 1;
                try
                {
                    select1 = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                    //Console.WriteLine("Geçersiz seçim yaptınız.");
                }
                if (select1 < 0 || select1 > 2)
                {
                    Console.WriteLine("Liste dışı seçim yaptınız.");
                }
                else if (select1 == 0)
                {
                    isRun = false;
                    break;
                }
                else if (select1 == 1)
                {
                    List<Movies> movies = GetMovies(Path(select1));
                    PrintList(movies);
                    SelectMovie(movies);
                    
                }
                else if (select1 == 2)
                {
                    List<Movies> movies = GetMovies(Path(select1));
                    PrintList(movies);
                }
            }
        }
        public static void Operator()
        {
            Console.Write("\n" +
                "Film listesi      [1]\n" +
                "İzlenen filmler   [2]\n" +
                "Çıkış için        [0]\n" +
                "Seçim Yapınız: " );
        }
    }
}
