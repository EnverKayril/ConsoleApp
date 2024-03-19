using System.ComponentModel;
using System.Security.Principal;

namespace CSProjeDemo1
{
    public class Program
    {
        static void Main(string[] args)
        {
            int secim1 = 1;
            int secim2 = 1;
            bool isRun = true;
            #region Üyeler
            List<Uye> uyeListesi = new List<Uye>();
            Uye uye1 = new Uye("201", "Enver", "Kayrıl", 31);
            Uye uye2 = new Uye("202", "Hakan", "Gökçer", 19);
            Uye uye3 = new Uye("203", "Beşir", "Önal", 33);
            Uye uye4 = new Uye("204", "Nihal", "Ermiş", 25);
            Uye uye5 = new Uye("205", "Firdevs", "Yöreoğlu", 26);
            Uye uye6 = new Uye("206", "Adnan", "Ziyagil", 22);
            Uye uye7 = new Uye("207", "Çetin", "Özder", 29);
            Uye uye8 = new Uye("208", "Hilmi", "Önal", 34);
            uyeListesi.Add(uye1);
            uyeListesi.Add(uye2);
            uyeListesi.Add(uye3);
            uyeListesi.Add(uye4);
            uyeListesi.Add(uye5);
            uyeListesi.Add(uye6);
            uyeListesi.Add(uye7);
            uyeListesi.Add(uye8);
            #endregion
            #region Kitaplar
            List<Kitap> kitapListesi = new List<Kitap>();
            KitapRoman kitap1 = new KitapRoman("11234", "Bülbülü Öldürmek", "Harper Lee", 1960, 2);
            KitapRoman kitap2 = new KitapRoman("11235", "Gurur ve Önyargı", "Jane Austen", 1813, 1);
            KitapRoman kitap3 = new KitapRoman("11236", "Muhteşem Gatsby", "F.Scott Fitzgerald", 1813, 2);
            KitapRoman kitap4 = new KitapRoman("11237", "1984", "George Oewell", 1813, 3);
            KitapRoman kitap5 = new KitapRoman("11238", "Çavdar Tarlasında Çocuklar", "J.D. Salinger", 1813, 1);
            KitapBilim kitap6 = new KitapBilim("11239", "Kainatın Yüreği", "Carl Sagan", 1977, 1);
            KitapBilim kitap7 = new KitapBilim("11240", "Zamanın Kısa Tarihi", "Stephan Hawking", 1988, 2);
            KitapBilim kitap8 = new KitapBilim("11241", "Varoluşun Kısa Tarihi", "Yuval Noah Harari", 2014, 1);
            KitapBilim kitap9 = new KitapBilim("11242", "Uzay Arkeolojisi", "Sarah Parcaj", 2019, 1);
            KitapBilim kitap10 = new KitapBilim("11243", "Evrenin Öyküsü", "Brian Greene", 2014, 1);
            KitapTarih kitap11 = new KitapTarih("11244", "Tarih Nedir?", "Edward Hallett Carr", 1961, 1);
            KitapTarih kitap12 = new KitapTarih("11245", "Türk Tarihi", "İlber Ortaylı", 2001, 1);
            KitapTarih kitap13 = new KitapTarih("11246", "Ortaçağ Tarihi", "Halil İnalcık", 2000, 1);
            KitapTarih kitap14 = new KitapTarih("11247", "Fransız Devrimi", "George Rude", 1959, 1);
            KitapTarih kitap15 = new KitapTarih("11248", "Tarihin Efsaneleri", "Peter Burke", 1973, 1);
            kitapListesi.Add(kitap1);
            kitapListesi.Add(kitap2);
            kitapListesi.Add(kitap3);
            kitapListesi.Add(kitap4);
            kitapListesi.Add(kitap5);
            kitapListesi.Add(kitap6);
            kitapListesi.Add(kitap7);
            kitapListesi.Add(kitap8);
            kitapListesi.Add(kitap9);
            kitapListesi.Add(kitap10);
            kitapListesi.Add(kitap11);
            kitapListesi.Add(kitap12);
            kitapListesi.Add(kitap13);
            kitapListesi.Add(kitap14);
            kitapListesi.Add(kitap15);
            #endregion
            List<OduncVerilenKitaplar> oduncVerilenKitaplar = new List<OduncVerilenKitaplar>();
            Kutuphane kutuphane = new Kutuphane();
            kutuphane.memberList = uyeListesi;
            kutuphane.booksList = kitapListesi;

            //Kutuphane.PrintMember(kutuphane.memberList);
            //Kutuphane.PrintBooks(kutuphane.booksList);

            Console.WriteLine("Kütüphaneye Hoşgeldiniz\n");

            while (isRun)
            {
                Console.Write(
                    "\nKitap Ödünç vermek için [1]\n" +
                    "Kitap İadesi almak için [2]\n" +
                    "Ödünç verilen tüm kitapların sorgulaması [3]\n" +
                    "Üye Sorgulama için [4]\n" +
                    "Seçim Yapınız: ");
                try
                {
                secim1 = int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Hatalı giriş yaptınız.\n");
                    continue;
                }
                if (secim1 < 0 || secim1 > 4)
                {
                    Console.WriteLine("Liste dışı seçim yaptınız.\n");
                    continue;
                }
                else if (secim1 == 0)
                {
                    Console.WriteLine("Çıkış yapılıyor...");
                    break;
                }
                else if (secim1 == 1)
                {
                    oduncVerilenKitaplar.Add( Kutuphane.KitapOduncVer(Kutuphane.KitapSec(kitapListesi), Kutuphane.UyeSec(uyeListesi)));
                    
                }


                else if (secim1 == 3)
                {
                    Kutuphane.PrintBorrowedBooks(oduncVerilenKitaplar);
                }



            }
            //        Kutuphane.KitapOduncVer(Kutuphane.KitapSec(kitapListesi),Kutuphane.UyeSec(uyeListesi));

            //Console.WriteLine("**");
            //Kutuphane.PrintBooks(kutuphane.booksList);
            
        }
    }
}
