using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace METHODS
{
    class Program
    {
        static void Main(string[] args)
        {
            var point = new Point(20,23);
            point.Move(20,30);
            Console.WriteLine("ok les resultats sont sont  {0} et {1}", point.X, point.Y);
            Console.WriteLine();

            point.Move(new Point(45,50));
            Console.WriteLine("Ok les seconds resultats sont {0} et {1}", point.X, point.Y);
            Console.ReadKey();
        }
    }
}
