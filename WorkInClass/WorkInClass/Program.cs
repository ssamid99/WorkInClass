using System;

namespace WorkInClass
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.name = "Book 1 Name";
            book1.author = "Book 1 Author";
            book1.Price = -5;

            Console.WriteLine(book1.Price);
        }

    }
}
