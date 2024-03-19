using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public class KitapRoman : Kitap
    {
        public KitapRoman(string isbn, string bookName, string writer, int publishYear, int piece) : base(isbn, bookName, writer, publishYear, piece)
        {
        }
    }
}
