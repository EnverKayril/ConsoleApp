using R_D_Store.NewFolder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace R_D_Store
{
    public abstract class Product
    {
        //private double Ptax;

        public int UDI { get; set; }
        public string pName { get; set; }
        public double pExTax { get; set; }
        public double taxRate { get; set; }
        public double pTax { get { return taxRate * pExTax; } }
        public double pWithTax { get { return pExTax + pTax; } }

        public virtual void printInfo()
        {
            Console.WriteLine($"{UDI,-8}{pName,-60}{pExTax,8}{pTax,8}{pWithTax,8} ");
        }
    }
}
