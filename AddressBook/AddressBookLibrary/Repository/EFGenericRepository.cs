using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace AddressBookLibrary.Repository
{
    public class EfGenericRepository<T> : IRepository<T> where T : class
    {
        private readonly DbContext _context;
        private readonly DbSet<T> _dbSet;

        public EfGenericRepository(DbContext context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public List<T> GetAll()
        {
            return _dbSet.AsNoTracking().ToList();
        }

        public T Add(T item)
        {
            _context.Entry(item).State = EntityState.Added;
            _dbSet.Add(item);
            _context.SaveChanges();
            return item;
        }

        public T Update(T item)
        {
            //_context.Entry(item).State = EntityState.Modified;
            _dbSet.Update(item);
            _context.Update(item);
            _context.SaveChanges();
            return item;
        }

        public T Remove(T item)
        {
            _context.Entry(item).State = EntityState.Deleted;
            _dbSet.Remove(item);
            _context.SaveChanges();
            return item;
        }
    }
}