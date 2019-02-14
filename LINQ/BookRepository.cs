using System.Collections.Generic;

namespace LINQ
{
    public class BookRepository
    {
        public  IEnumerable<Book> GetBook()
        {
            return new List<Book>
        {
            new Book () {Title = "ADO.Net", Price = 5},
            new Book () {Title = "SP.Net", Price = 9.75f},
            new Book () {Title = "ASP.Net", Price = 12},
            new Book () {Title = "C SHARP", Price = 7},
            new Book () {Title = "C SHARP Advency Topic", Price = 9}
        };
        }
    }
}
