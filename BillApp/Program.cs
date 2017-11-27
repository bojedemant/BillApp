using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Bil b = new Bil();
            b.BilId = 1;
            b.Model = "dyt";
            b.AntalCylindre = 40;


            LastBil l = new LastBil() { BilId = 2, Model = "Last", AntalCylindre = 4 };

            b.Print();
            l.Print();

            PersonBil p = new PersonBil() { Model = "Z" };
            p.Print();

            Bil[] biler = new Bil[4];
            biler[0] = b;
            biler[1] = l;
            biler[2] = p;
            biler[3] = new Bil(4) ;
            foreach (var bil in biler)
                bil.Print();



        }

    }
}

