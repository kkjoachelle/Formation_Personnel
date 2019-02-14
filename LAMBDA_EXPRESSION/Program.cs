using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LAMBDA_EXPRESSION
{

    class Program
    {
        static void Main(string[] args)
        {
            //
            var ret = new BookRepository().GetBooks();

            var resFin = ret.FindAll(s=> s.Price<11);

            foreach (var item in resFin)
            {
                Console.WriteLine(item.Tilte);
            }

            Console.ReadKey();
        }
    }
}
