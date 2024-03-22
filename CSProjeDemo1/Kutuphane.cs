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
        public static Kitap KitapSec(List<Kitap> bookList)
        {
            while (true)
            {
                Kutuphane.PrintBooks(bookList);
                Console.Write("\nKitap Numarası Giriniz: ");
                string secim2 = Console.ReadLine();
                Kitap secilenKitap = null;
                foreach (Kitap Kitap in bookList)
                {
                    if (Kitap.ISBN == secim2)
                    {
                        if (Kitap.Piece == 0)
                        {
                            Console.WriteLine("Kitap stokta yok. ");
                            break;
                        }
                        secilenKitap = Kitap;
                    }

                }
                if (secilenKitap == null)
                {
                    Console.WriteLine("Kitap mevcut değil.");
                    continue;
                }
                else
                {
                    Console.WriteLine($"{secilenKitap.ISBN,-9}{secilenKitap.BookName,-30}{secilenKitap.Writer,-25}{secilenKitap.Availability,-20}");
                }
                return secilenKitap;
            }
        }

        public static Uye UyeSec(List<Uye> memberList)
        {
            while (true)
            {
                Kutuphane.PrintMember(memberList);
                Console.Write("\nUye Id giriniz: ");
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
                    continue;
                }
                else
                {
                    Console.WriteLine($"{secilenUye.Id,-9}{secilenUye.Name,-15}{secilenUye.LastName,-15}{secilenUye.Age,-9}{secilenUye.Email,-40}");
                }
                return secilenUye;
            }
        }

        public static void PrintMember(List<Uye> memberList)
        {
                Console.WriteLine($"\n{"ID",-9}{"Adı",-15}{"Soyadı",-15}{"Yaş",-9}{"Email",-40}");
            foreach (Uye member in memberList)
            {
                Console.WriteLine($"{member.Id,-9}{member.Name,-15}{member.LastName,-15}{member.Age,-9}{member.Email,-40}");
            }
        }
        public static void PrintBooks(List<Kitap> bookList)
        {
            Console.WriteLine($"\n{"ISBN",-9}{"Kitap Adı",-30}{"Yazar",-25}{"Durumu",-20}{"Adet",-10}");
            foreach (Kitap book in bookList)
            {
                Console.WriteLine($"{book.ISBN,-9}{book.BookName,-30}{book.Writer,-25}{book.Availability,-20}{book.Piece,-10}");
            }
        }
        public static void PrintBorrowedBooks(List<OduncVerilenKitaplar> borrowed)
        {
            Console.WriteLine($"\n{"ISBN",-9}{"Kitap Adı",-30}{"Uye Id",-9}{"Uye Adı",-15}{"Soyadı",-15}");
            foreach (OduncVerilenKitaplar item in borrowed)
            {
                if (item != null)
                {
                Console.WriteLine($"{item.BookId,-9}{item.BookName,-30}{item.MemberID,-9}{item.MemberName,-15}{item.MemberLastName,-15}");
                }
            }
        }

    }

}
