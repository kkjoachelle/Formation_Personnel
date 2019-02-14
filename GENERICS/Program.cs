using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GENERICS
{
    class Program
    {
        // where T : IComparable
        // where T : Product
        // where T : Struct
        // where T : Class
        // where T : new()

        static void Main(string[] args)
        {
            var book = new Book
            {
                Isbn = "1111", Title ="C sharp Advenced"
            };

            //var number = new List();
            //number.Add(10);

            //var books = new BookList();
            //books.Add(book);

            var number = new Genericlist<int>();
            number.Add(10);

            var books = new Genericlist<Book>();
            books.Add(new Book());

            var dictionary = new GenericDitionary<string, Book>();
            dictionary.Add("11122", new Book());

            var number1 = new Nullable<int>(5);
            System.Console.WriteLine("Has value : "+number1.HasValue);
            System.Console.WriteLine("Value : " +number1.GetValueOrdeDefault());
        }
    }
}

