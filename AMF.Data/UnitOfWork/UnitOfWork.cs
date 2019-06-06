using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMF.Data.UnitOfWork
{
    public class UnitOfWork :DbContext
    {
        public UnitOfWork(DbContextOptions<UnitOfWork> options) :base(options)
        {
        }
    }
}
