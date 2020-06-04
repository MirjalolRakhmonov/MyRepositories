using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            var books=new BookRepository().GetBooks();

            //LINQ Query Operator
             /*var expensivebooks=
                from b in books
                where b.Price >= 20
                orderby b.Title
                select b.Title;
            // always start from from and finish at select

            //LINQ Extension methods
            var expensivebooks = books
                .Where(b => b.Price >= 20)
                .OrderBy(b=>b.Title)
                .Select(b=>b.Title); */

            /*var cheapbooks=new List<Book>();
            foreach (var book in books)
            {
                if(book.Price<20)
                    cheapbooks.Add(book);
            }*/
            // we can simply achieve the result by LINQ

            //foreach (var book in expensivebooks)
            //    Console.WriteLine(book); 
            //Console.WriteLine(book.Title+ " "+ book.Price); 

            //LINQ Extension methods
            var book = books.Single(b => b.Title == "Entity Framework in Depth 6");
            Console.WriteLine(book.Title); 

            // we can use these : 
            books.Where()
            books.Single()
            books.SingleOrDefault()

            books.First()
            books.FirstOrDefault()

            books.Last()
            books.LastOrDefault()

            books.Min()
            books.Max()
            books.Count()
            books.Average()
            books
            books
        }
    }
}
