using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etudiant
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Etudiant().add(new int[] {12, 20, 14, 45, 47, 8 });
            Console.WriteLine("Le resultat est {0}", result);
            Console.ReadKey();
        }
    }
}
