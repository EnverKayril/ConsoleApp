using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMDbTop50
{
    public partial class Movies
    {
        public int sNumber { get; set; }
        public string movie { get; set; }
        public string director { get; set; }
        public string IMDb { get; set; }

        public static string Path(int secim)
        {
            if (secim == 1)
            {
                return @"C:\Users\oscar\source\repos\ConsoleApp\IMDbTop50\bin\Debug\net6.0\Txt\MovieList.txt";
            }
            else if (secim == 2)
            {
                return @"C:\Users\oscar\source\repos\ConsoleApp\IMDbTop50\bin\Debug\net6.0\Txt\WatchedMovies.txt";
            }
            else
            {
                Console.WriteLine("Hatalı seçim.");
                return "";
            }
        }

        public static List<Movies> GetMovies(string path)
        {
            List<Movies> movieList = new List<Movies>();
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.EndOfStream != true)
                {
                    string line = sr.ReadLine();
                    string[] addmovie = line.Split('-');
                    if (addmovie.Length == 4)
                    {
                        Movies movies = new Movies
                        {
                            sNumber = int.Parse(addmovie[0]),
                            movie = addmovie[1],
                            director = addmovie[2],
                            IMDb = addmovie[3]
                        };
                        movieList.Add(movies);
                    }
                }
            }
                return movieList;
        }

        public static void PrintList(List<Movies> x)
        {
            Console.WriteLine($"{"Sıra No",-10}{"Film",-55}{"Yönetmen",-40}{"IMDb Puanı",-13}");
            foreach (Movies movie in x)
            {
                Console.WriteLine($"{movie.sNumber,-10}{movie.movie,-55}{movie.director,-40}{movie.IMDb,-13}");
            }
        }
    }
}
