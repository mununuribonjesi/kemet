using AMF.Data.Interfaces;
using AMF.Data.UnitOfWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AMF.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationContext context;

        public Repository(ApplicationContext _context)
            => context = _context;

        public void Add(T entity)
            => context.Set<T>().Add(entity);

        public IEnumerable<T> Get()
            => context.Set<T>().ToList();

        public T GetById(Guid id)
        => context.Set<T>().Find(id);

        public void Remove(Guid id)
        {
            var type = context.Set<T>().Find(id);
            context.Remove(type);
        }

        public void Save()
        {
            context.SaveChanges();
        }

        public void Update(T entity)
            => context.Set<T>().Attach(entity);
    }
}
