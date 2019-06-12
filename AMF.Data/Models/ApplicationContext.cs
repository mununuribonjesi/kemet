using Microsoft.EntityFrameworkCore;
using AMF.Data.UnitOfWork.Models.ModelConfigurations;

namespace AMF.Data.UnitOfWork.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new TodoConfiguration());

        }

    }
}
