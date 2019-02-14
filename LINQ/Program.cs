using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            var books = new BookRepository().GetBook();
            var cheapBooks = new List<Book>();
            //-----------------------------------------------------------

            Console.WriteLine("Affichage de l'ensemble des books sans condition");
            foreach (var item in books)
            {
                Console.WriteLine(item.Title +" " + item.Price);
            }
            Console.WriteLine(" ");
            //-----------------------------------------------------------

            foreach (var book in books)
            {
                if (book.Price<10)
                {
                    cheapBooks.Add(book);
                }
            }
            Console.WriteLine("Affichage de l'ensemble des books après la  condition");
            foreach (var item in cheapBooks)
            {
               Console.WriteLine(item.Title + " " + item.Price);
            }

            ////////////////////////////////////////////////////////////////////////
            
               /*
                books.Single()
                books.Sum()
                books.SingleOrDefault()
                books.First()
                books.Last()
                books.LastOrDefault()
                books.Max()
                books.Min()
                books.Count()
                books.Average()
                books.Skip(5).Take(3)
                */

            Console.WriteLine("UTILISATION DU LINQ");
            Console.WriteLine(" ****** POSSIBILITE 1  ***** ");
            //-----------------------------------------------------------

            var booker = books.Single(s=> s.Title == "ASP.Net"); // vec single si la liste est vide il y a un exception
           // var booker = books.SingleOrDefault(s => s.Title == "ASP.Net");
            Console.WriteLine(booker.Title);

            //-----------------------------------------------------------
            Console.WriteLine(" ****** POSSIBILITE 2  ***** ");
            //Linq Query Operator
            var cheapOp = 
                    from b in books
                    where b.Price < 10
                    orderby b.Price
                    select b.Title;
            foreach (var item in books)
            Console.WriteLine(item.Title);

            //-----------------------------------------------------------
            Console.WriteLine(" ****** POSSIBILITE 3  ***** ");
            //Linq Extension Methods
            var cheapBooksLINQ = books.Where(b => b.Price < 10).OrderBy(b =>b.Price);
             foreach (var item in cheapBooksLINQ)
             Console.WriteLine(item.Title + " " + item.Price);

            //-----------------------------------------------------------
            Console.WriteLine(" ****** POSSIBILITE 4  ***** ");
            /*var cheapBooksLINQ = books
                                       .Where(b => b.Price < 10)
                                       .OrderBy(b =>b.Price)
                                       .Select(b=>b.Title);
            foreach (var item in cheapBooksLINQ)
            Console.WriteLine(item.Title);*/
            //-----------------------------------------------------------
            ////////////////////////////////////////////////////////////////////////

            Console.ReadKey();
        }
    }
}
