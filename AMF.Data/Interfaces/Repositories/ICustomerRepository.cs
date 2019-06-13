using System;
using System.Collections.Generic;
using System.Text;
using AMF.Entities.DTOs;

namespace AMF.Data.Interfaces.Repositories
{
    public interface ICustomerRepository :IRepository<Customer>
    {

        IEnumerable<Customer> GetCustomersByID(int id);
    }
}
