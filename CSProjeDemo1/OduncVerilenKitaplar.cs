﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo1
{
    public class OduncVerilenKitaplar : Kutuphane
    {
        public string BookId { get; set; }
        public string BookName { get; set; }
        public string MemberID { get; set; }
        public string MemberName { get; set; }
        public string MemberLastName { get; set; }
        public OduncVerilenKitaplar(string bookID, string bookName, string memberId, string memberName, string memberLastName)
        {
            BookId = bookID;
            BookName = bookName;
            MemberID = memberId;
            MemberName = memberName;
            MemberLastName = memberLastName;
        }
        public static OduncVerilenKitaplar KitapOduncVer(Kitap secilenKitap, Uye secilenUye)
        {
            OduncVerilenKitaplar oduncVerilenKitap = new OduncVerilenKitaplar(secilenKitap.ISBN, secilenKitap.BookName, secilenUye.Id, secilenUye.Name, secilenUye.LastName);
            secilenKitap.Piece--;
            return oduncVerilenKitap;
        }

        public static void KitapIadeAl(List<OduncVerilenKitaplar> oduncKitap, List<Kitap> kitapListesi)
        {
            Console.Write("Uye Id giriniz: ");
            string uyeId = Console.ReadLine();
            Console.Write("Kitap Id giriniz: ");
            string kitapId = Console.ReadLine();

            List<OduncVerilenKitaplar> silinecekler = new List<OduncVerilenKitaplar>();

            foreach (var item in oduncKitap)
            {
                if (item.MemberID == uyeId && item.BookId == kitapId)
                {
                    silinecekler.Add(item);
                }
            }

            foreach (var silinecek in silinecekler)
            {
                oduncKitap.Remove(silinecek);
            }

            foreach (var kitap in kitapListesi)
            {
                if (kitap.ISBN == kitapId)
                {
                    kitap.Piece++;
                    break;
                }
            }
        }
    }
}
