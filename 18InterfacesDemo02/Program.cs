using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18InterfacesDemo02
{
    class Program
    {
        static void Main(string[] args)
        {
            MFP m = new MFP();
            m.Copy();
            m.Fax();
            m.Print();
            m.Scan();

            IFax f = new MFP();
            f.Fax();

            ((ICopy)f).Copy();//type casting;


        }
    }
    interface IScan
    {
        void Scan();
    }
    interface ICopy
    {
        void Copy();
    }
    interface IFax
    {
        void Fax();
    }
    abstract class Printer
    {
        public abstract void Print();
    }

    class MFP : Printer, IScan, ICopy, IFax
    {
        public void Copy()
        {
            Console.WriteLine("Copy Function");
        }

        public void Fax()
        {
            Console.WriteLine("Fax Function");
        }

        public override void Print()
        {
            Console.WriteLine("Print Function");
        }

        public void Scan()
        {
            Console.WriteLine("Scan Function");
        }
    }
}
