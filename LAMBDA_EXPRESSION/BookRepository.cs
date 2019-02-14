using System.Collections.Generic;


namespace LAMBDA_EXPRESSION
{
    public class BookRepository 
         {
        public List<Book> GetBooks()
         {
            return new List<Book>
             {
                new Book() {Tilte =  "Tilte 1 ", Price =2},
                new Book() {Tilte = "Tilte 2 ", Price =10},
                new Book() {Tilte = "Tilte 3 ", Price =8},
                new Book() {Tilte = "Tilte 4 ", Price =15}
             };
        }
       }
}
