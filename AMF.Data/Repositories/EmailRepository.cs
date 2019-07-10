using AMF.Data.Interfaces.Repositories;
using AMF.Entities.DTOs;
using AMF.Entities.Models;

namespace AMF.Data.Repositories
{
    public class EmailRepository : Repository<SubscribedEmails>, IEmailRepository
    {
        public EmailRepository(DatabaseContext context)
         : base(context)
        { }

        public new void Add(SubscribedEmails Mail)
        {
            Context.Set<SubscribedEmails>().Add(Mail);
            Context.SaveChanges();
        }
    }
}
