using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using AMF.Entities.DTOs;

namespace AMF.Entities.Models
{
    public class DatabaseContext: DbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
        :base(options)
        {


        }

        public virtual DbSet<Customer> Customers { get; set; }

    }
}
