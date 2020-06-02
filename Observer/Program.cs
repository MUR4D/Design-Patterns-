using System.Net.Http.Headers;

namespace Observer
{

    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            ClassicReaders classic = new ClassicReaders();

            TechReaders tech = new TechReaders();

            Book book1 = new TecnicalBook { Name = "Programming", Genre = "Technical" };
            Book book2 = new ClassicBook { Name = "War and Peace", Genre = "Classica" };
            library.NotifyReaders(book1);
            library.AddReader(classic);
            library.AddReader(tech);
            library.NotifyReaders(book2);
            
        }
    }
}
