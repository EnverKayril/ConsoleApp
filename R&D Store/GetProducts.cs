using R_D_Store.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_D_Store
{
    public class GetProducts : Product
    {
        public static List<Product> GetProduct()
        {
            List<Product> productList = new List<Product>();
            string path = @"C:\Users\oscar\OneDrive\Masaüstü\ProductList.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.EndOfStream != true)
                {
                    string line = sr.ReadLine();
                    string[] addline = line.Split('-');
                    Product product = CreateProduct(addline);
                    productList.Add(product);
                }
            }
            return productList;
        }

        public static Product CreateProduct(string[] addline)
        {
            string category = addline[1].Trim();
            if (category == "Kitap")
            {
                return new Books
                {
                    UDI = int.Parse(addline[0]),
                    pName = addline[2],
                    pExTax = double.Parse(addline[3]),
                    taxRate = 0.10,
                };
            }
            else if (category == "Elektronik")
            {
                return new Electronics
                {
                    UDI = int.Parse(addline[0]),
                    pName = addline[2],
                    pExTax = double.Parse(addline[3]),
                    taxRate = 0.10,
                };
            }
            else if (category == "Giyim")
            {
                return new Clothes
                {
                    UDI = int.Parse(addline[0]),
                    pName = addline[2],
                    pExTax = double.Parse(addline[3]),
                    taxRate = 0.10,
                };
            }
            else if (category == "Ev")
            {
                return new HomeStuffs
                {
                    UDI = int.Parse(addline[0]),
                    pName = addline[2],
                    pExTax = double.Parse(addline[3]),
                    taxRate = 0.10,
                };
            }
            else if (category == "Oyuncak")
            {
                return new Toys
                {
                    UDI = int.Parse(addline[0]),
                    pName = addline[2],
                    pExTax = double.Parse(addline[3]),
                    taxRate = 0.10,
                };
            }
            else if (category == "Spor")
            {
                return new Sports
                {
                    UDI = int.Parse(addline[0]),
                    pName = addline[2],
                    pExTax = double.Parse(addline[3]),
                    taxRate = 0.10,
                };
            }
            else if (category == "FilmveMüzik")
            {
                return new MoviesAndMusic
                {
                    UDI = int.Parse(addline[0]),
                    pName = addline[2],
                    pExTax = double.Parse(addline[3]),
                    taxRate = 0.10,
                };
            }
            else if (category == "BilgisayarOyunları")
            {
                return new PcGames
                {
                    UDI = int.Parse(addline[0]),
                    pName = addline[2],
                    pExTax = double.Parse(addline[3]),
                    taxRate = 0.10,
                };
            }
            else if (category == "KutuOyunları")
            {
                return new BoardGames
                {
                    UDI = int.Parse(addline[0]),
                    pName = addline[2],
                    pExTax = double.Parse(addline[3]),
                    taxRate = 0.10,
                };
            }
            else if (category == "MüzikAletleri")
            {
                return new Instruments
                {
                    UDI = int.Parse(addline[0]),
                    pName = addline[2],
                    pExTax = double.Parse(addline[3]),
                    taxRate = 0.10,
                };
            }
            else if (category == "HobiMalzemeleri")
            {
                return new Hobby
                {
                    UDI = int.Parse(addline[0]),
                    pName = addline[2],
                    pExTax = double.Parse(addline[3]),
                    taxRate = 0.10,
                };
            }
            else return null;
        }





     //while (sr.EndOfStream != true)
     //           {
     //               string line = sr.ReadLine();
     //               string[] addline = line.Split('-');
     //               if (addline[1] == " Kitap ")
     //               {
     //                   Books product = new Books()
     //                   {
     //                       UDI = int.Parse(addline[0]),
     //                       pName = addline[2],
     //                       pExTax = double.Parse(addline[3]),
     //                       taxRate = 0.10,
     //                   };
     //                   productList.Add(product);
     //               }
     //               else if (addline[1] == " Elektronik ")
     //               {
     //                   Electronics product = new Electronics()
     //                   {
     //                       UDI = int.Parse(addline[0]),
     //                       pName = addline[2],
     //                       pExTax = double.Parse(addline[3]),
     //                       taxRate = 0.10,
     //                   };
     //                   productList.Add(product);
     //               }
     //               else if (addline[1] == " Giyim ")
     //               {
     //                   Clothes product = new Clothes()
     //                   {
     //                       UDI = int.Parse(addline[0]),
     //                       pName = addline[2],
     //                       pExTax = double.Parse(addline[3]),
     //                       taxRate = 0.10,
     //                   };
     //                   productList.Add(product);
     //               }
     //             }

    }
}