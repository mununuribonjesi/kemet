using System;
using System.Collections.Generic;

namespace AMF.Data.Interfaces
{
    public interface IRepository<T> where T : class
    {
        void Add(T entity);
        T GetById(Guid id);

        IEnumerable<T> Get();

        void Remove(Guid id);

        void Save();

        void Update(T entity);
    }
}
