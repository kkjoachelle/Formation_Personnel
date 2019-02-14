using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DYNAMIC
{
    class Program
    {
        static void Main(string[] args)
        {
            dynamic name = "kouadioo";
            name = 1236;
            Console.WriteLine(" le resultat est :" + name);
            

            int? nuc = null;
            Console.WriteLine("rrrrrrrrrrrr :" + nuc.GetValueOrDefault());

            Console.ReadKey();
        }
    }
}
