using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public class KitapBilim : Kitap
    {
        public KitapBilim(string isbn, string bookName, string writer, int publishYear, int piece) : base(isbn, bookName, writer, publishYear, piece)
        {
        }
    }
}
