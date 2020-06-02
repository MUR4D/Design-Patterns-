using System.Collections.Generic;

namespace Observer
{
    class Library : IObservable
    {

        List<Book> books = new List<Book>();
        List<IReader> readers;
        public Library()
        {
            readers = new List<IReader>();
        }
        public void AddReader(IReader reader)
        {
            readers.Add(reader);
        }

        public void NotifyReaders(Book book)
        {
            books.Add(book);
            foreach (var reader in readers)
            {
                reader.Update(this,book);
            }
        }

        public void SellBook(Book book)
        {
            books.Remove(book);
        }
        public void RemoveReader(IReader reader)
        {
            readers.Remove(reader);
        }
    }
}
