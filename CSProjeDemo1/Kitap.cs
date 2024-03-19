using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public abstract class Kitap
    {
        private Durum availability;
        private int piece;
        protected Kitap(string isbn, string bookName, string writer, int publishYear, int piece )
        {
            ISBN = isbn;
            BookName = bookName;
            Writer = writer;
            PublicationYear = publishYear;
            Piece = piece;
        }

        public string ISBN { get; set; }
        public string BookName { get; set; }
        public string Writer { get; set; }
        public int PublicationYear { get; set; }
        public int Piece
        {
            get { return piece; }
            set
            {
                piece = value;
                if ( piece == 0 )
                {
                    Availability = Durum.OduncVerildi;
                }
                else if ( piece >= 1 )
                {
                    Availability = Durum.OduncAlinabilir;
                }
            }
        }
        public Durum Availability { get; private set; }
    }
}
