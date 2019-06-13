using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMF.Entities.Models
{
    public class DatabaseContext: DbContext
    {

        public DatabaseContext(DbContextOptions<DatabaseContext> options)
        :base(options)
        {


        }

    }
}
