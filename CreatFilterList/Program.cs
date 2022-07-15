using List.Models;
using System;
using System.Collections.Generic;

namespace List1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();

            Book book = new Book()
            {
                Name = "7 gozel",
                Author = "Nizami",
                Price = 20

            };

            Book book1 = new Book()
            {
                Name = "Leyli Mecnun",
                Author = "Nizami Gencevi",
                Price = 30
            };

            books.Add(book1);
            books.Add(book);

           Filtire<Book> data = new Filtire<Book>();
            var result = data.Filtr(books, 10, 50);
            foreach (var item in result)
            {
                Console.WriteLine(item.Name);
            }


        }
    }
}
