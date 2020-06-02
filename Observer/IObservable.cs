namespace Observer
{
    interface IObservable
    {
        void AddReader(IReader reader);

        void RemoveReader(IReader reader);

        void NotifyReaders(Book book);
    }
}
