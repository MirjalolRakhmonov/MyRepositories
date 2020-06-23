﻿using System;
using Npgsql;
namespace NpgSqlIntroduction
{
    public class Program
    {
        public static void Main(string[]args)
        {
            // Simple fetch from database
            MovieRecord mr = MovieRecord.GetByID(2);
            Console.WriteLine(mr.ToString());

            // New object is created
            mr = new MovieRecord(123, "The Last Samurai", 2003, 10);
            // Before the object was only in the memory. We need to save it, to store it in the persistence layer
            mr.Save();
            Console.WriteLine(MovieRecord.GetByID(123).ToString());

            // We adjust the price
            mr.ChangePrice(4.5);
            // Price is changed both in the in-memory object and in the persistence layer
            Console.WriteLine(MovieRecord.GetByID(123).ToString());



            // Object is removed from the database
            mr.Remove();
            if (MovieRecord.GetByID(123) == null)
            {
                Console.WriteLine("Object is removed from the database");
            }
        }
    }
}
