using System.Collections.Generic;

namespace LINQPractice
{
    public class BookRepository
    {
        public IEnumerable<Book> GetBooks()
        {
            return new List<Book>
            {
                new Book() {Title = "Node.JS Course", Price = 20},
                new Book() {Title = "Entity Framework in Depth 6", Price = 18.9f},
                new Book() {Title = "ASP.NET MVC Course", Price = 22}
            };
        }
    }
}