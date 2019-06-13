using System;
using System.Collections.Generic;
using System.Text;
using AMF.Data.Interfaces.UnitOfWork;
using AMF.Entities.Models;

namespace AMF.Data.UnitOfWork
{
    public class UnitOfWork:IUnitOfWork
    {
        private readonly DatabaseContext _context;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }

        public int Complete()
        {
           return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
