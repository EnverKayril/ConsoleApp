using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public class Kutuphane
    {
        public List<Kitap> booksList { get; set; }
        public List<Uye> memberList { get; set; }

        public static OduncVerilenKitaplar KitapOduncVer(Kitap secilenKitap,Uye secilenUye)
        {
            OduncVerilenKitaplar oduncVerilenKitap = new OduncVerilenKitaplar(secilenKitap.ISBN,secilenKitap.BookName,secilenUye.Id,secilenUye.Name,secilenUye.LastName);
            secilenKitap.Piece--;
            return oduncVerilenKitap;
        }

        public static Kitap KitapSec(List<Kitap> bookList)
        {
            Console.Write("\nKitap Numarası Giriniz: ");
                Kutuphane.PrintBooks(bookList);
                string secim2 = Console.ReadLine();
                Kitap secilenKitap = null;
                foreach (Kitap Kitap in bookList)
                {
                    if (Kitap.ISBN == secim2)
                    {
                    secilenKitap = Kitap;
                    }
                }
                if (secilenKitap == null)
                {
                Console.WriteLine("Kitap mevcut değil.");
                }
                else
                {
                Console.WriteLine($"{secilenKitap.ISBN,-9}{secilenKitap.BookName,-30}{secilenKitap.Writer,-25}{secilenKitap.Availability,-20}");
                }
            return secilenKitap;
        }

        public static Uye UyeSec(List<Uye> memberList)
        {
            Console.Write("Uye Id giriniz: ");
            Kutuphane.PrintMember(memberList);
            string secim3 = Console.ReadLine();
            Uye secilenUye = null;
            foreach (Uye Uye in memberList)
            {
                if (Uye.Id == secim3)
                {
                    secilenUye = Uye;
                }
            }
            if (secilenUye == null)
            {
                Console.WriteLine("Uye mevcut değil.");
            }
            else
            {
                Console.WriteLine($"{secilenUye.Id,-9}{secilenUye.Name,-15}{secilenUye.LastName,-15}{secilenUye.Age,-9}{secilenUye.Email,-40}");
            }
            return secilenUye;
        }

        public static void PrindBorrowedBooks(List<Kitap> borrowedList)
        {
            Console.WriteLine($"{"ISBN",-9}{"Kitap Adı",-30}{"Yazar",-25}{"Durumu",-20}");
            foreach (Kitap book in borrowedList)
            {
                Console.WriteLine($"{book.ISBN,-9}{book.BookName,-30}{book.Writer,-25}{book.Availability,-20}");
            }
        }

        public static void PrintMember(List<Uye> memberList)
        {
                Console.WriteLine($"{"ID",-9}{"Adı",-15}{"Soyadı",-15}{"Yaş",-9}{"Email",-40}");
            foreach (Uye member in memberList)
            {
                Console.WriteLine($"{member.Id,-9}{member.Name,-15}{member.LastName,-15}{member.Age,-9}{member.Email,-40}");
            }
        }
        public static void PrintBooks(List<Kitap> bookList)
        {
            Console.WriteLine($"{"ISBN",-9}{"Kitap Adı",-30}{"Yazar",-25}{"Durumu",-20}");
            foreach (Kitap book in bookList)
            {
                Console.WriteLine($"{book.ISBN,-9}{book.BookName,-30}{book.Writer,-25}{book.Availability,-20}{"Adet: " + book.Piece}");
            }
        }
        public static void PrintBorrowedBooks(List<OduncVerilenKitaplar> borrowed)
        {
            Console.WriteLine($"{"ISBN",-9}{"Kitap Adı",-30}{"Uye Id",-9}{"Uye Adı",-15}{"Soyadı",-15}");
            foreach (OduncVerilenKitaplar item in borrowed)
            {
                Console.WriteLine($"{item.BookId,-9}{item.BookName,-30}{item.MemberID,-9}{item.MemberName,-15}{item.MemberLastName,-15}");
            }
        }

    }

}
