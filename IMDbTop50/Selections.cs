using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDbTop50
{
    public partial class Movies
    {
        public static void SelectMovie(List<Movies> list)
        {
            int select = 1;
            int select3 = 1;
            try
            {
                select = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Hatalı seçim yaptınız.");
            }
            if (select <= 0 || select > list.Count)
            {
                Console.WriteLine("Liste dışı seçim yaptınız");
            }
            var select2 = list[select - 1];
            Console.WriteLine($"{"Sıra No",-10}{"Film",-55}{"Yönetmen",-40}{"IMDb Puanı",-13}");
            var selectedMovie = $"{select2.sNumber,-10}{select2.movie,-55}{select2.director,-40}{select2.IMDb,-13}";
            Console.WriteLine(selectedMovie);

            Console.WriteLine("Filmi izlemek için [1] \nMenüye dönmek için [2]");
            try
            {
                select3 = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Hatalı seçim yaptınız.");
            }
            if (select3 <= 0 || select3 > 2)
            {
                Console.WriteLine("Liste dışı seçim yaptınız");
            }
            else if (select3 == 1)
            {
                WatchMovie(list, select);
                Console.WriteLine("İzlenenler listesine eklendi");
            }
            else{}
        }
        public static void WatchMovie(List<Movies> list, int select)
        {
            var select2 = list[select - 1];
            using (StreamWriter sw = new StreamWriter(@"C:\Users\oscar\source\repos\EnverKayril\ConsoleApp\IMDbTop50\Txt\WatchedMovies.txt",true))
            {
                sw.WriteLine($"{select2.sNumber,-10}-{select2.movie,-55}-{select2.director,-40}-{select2.IMDb,-13}");
            };
        }
    }
}
