using System;

namespace Observer
{
    class TechReaders : IReader
    {
        public void Update(Library library, Book book)
        {
            if (book.Genre=="Techical")
            {
                library.SellBook(book);
            Console.WriteLine("A new technical literature already in library!"); ;

            }
        }
    }
}
