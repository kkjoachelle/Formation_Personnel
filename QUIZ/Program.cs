using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUIZ
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int> { 4, 5, 1, 2, 3 };
            var number = numbers.Single(n =>n==10);
            Console.WriteLine("Voici le resultat "+number);
            Console.ReadKey();

            dynamic n= 5;
            var m = n;
            }
    }
}
