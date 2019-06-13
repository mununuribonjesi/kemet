using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AMF.Data.Interfaces.Repositories;
using AMF.Entities.DTOs;
using AMF.Entities.Models;
using Microsoft.EntityFrameworkCore;

namespace AMF.Data.Repositories
{
    public class CustomerRepository: Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(DatabaseContext context) 
            :base(context)
        {}

        public IEnumerable<Customer> GetCustomersByID(int id)
        {
            yield return Context.Customers.Include(a => a.FirstName).SingleOrDefault(a => a.Id == id);
        }

        public DatabaseContext Context
        {
            get { return Context as DatabaseContext; }
        }


    }
}
