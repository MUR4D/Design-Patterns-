using System;

namespace Observer
{
    class ClassicReaders : IReader
    {
        public void Update(Library library,Book book)
        {
            if (book.Genre=="Classica")
            {
                library.SellBook(book);
            Console.WriteLine("A new classic literature already in library!"); 
                

            }
        }
    }
}
