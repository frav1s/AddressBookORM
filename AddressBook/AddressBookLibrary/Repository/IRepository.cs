using System.Collections.Generic;

namespace AddressBookLibrary.Repository
{
    public interface IRepository<T> where T : class
    {
        List<T> GetAll();

        T Add(T item);

        T Update(T item);

        T Remove(T item);
    }
}