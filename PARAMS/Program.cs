using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARAMS
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] tab = new int[4];
            //var tab1 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //var tab2 =new int[] { 3, 4, 5, 6, 7, 8, 9 };
            //var tab3 = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9,10,11,12,13,14,15,16,17 }; 

            var rest = add(2,3,4,5,6,7,8,9);
            Console.WriteLine("Voici le resultat "+rest);
            Console.WriteLine(" ");
            var re = add(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17);
            Console.WriteLine(value: "Voici le second resultat " + re);
            Console.ReadKey();

            
        }
    static int add(params int[] tab)
    {
        int sum = 0;
        foreach (int n in tab)
        {
            sum = sum + n;
        }
        return sum;
    }
}

}
