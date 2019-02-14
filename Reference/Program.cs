using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reference
{
    class Program
    {
        static void Main(string[] args)
        {
            ///
            Console.WriteLine("PASSAGE PAR VLEUR");
            var a = 1;
            var res = new MyClass();
            res.MyMethod(a);
            ////
            Console.WriteLine("PAR REFERENCE");
            var a1 = 1;
            var res1 = new MyClassRef();
            res1.MyMethodRef(ref a1);
            ///
            Console.WriteLine("//////////////");
            int a2 ;
            var res2 = new MyClassOut();
            res2.MyMethodOut(out a2);
            Console.ReadKey();
        }
    }
}
