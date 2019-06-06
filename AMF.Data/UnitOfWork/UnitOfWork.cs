using Microsoft.EntityFrameworkCore;

namespace AMF.Data.UnitOfWork
{
    public class UnitOfWork :DbContext
    {
        public UnitOfWork(DbContextOptions<UnitOfWork> options) :base(options)
        {
        }
    }
}
