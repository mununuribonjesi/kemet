using AMF.Entities.DTOs;


namespace AMF.Entities.Models
{
    public class DatabaseContext: DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options)
        :base(options)
        {
        }

        public virtual DbSet<Subscribers> Subscribers { get; set; }
        public virtual DbSet<Countries> Countries { get; set; }
        public virtual DbSet<SubscribedEmails> SubscribedEmails { get; set; }
    }
}
