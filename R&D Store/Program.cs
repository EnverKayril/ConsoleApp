using R_D_Store.NewFolder;
using System;

namespace R_D_Store
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = GetProducts.GetProduct();
            //Product product = new Books()
            //{
            //    UDI = 54261,
            //    pName = "Harry",
            //    pExTax = 22.50,
            //    taxRate = 0.10,
            //};

            foreach (Product product in products)
            {
                product.printInfo();
            }

        }
    }
}
