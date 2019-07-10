using AMF.Data.Interfaces.Repositories;
using AMF.Entities.DTOs;
using AMF.Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace AMF.Data.Repositories
{
    public class MailingListRepository : Repository<Subscribers>, IMailingListRepository
    {
        public MailingListRepository(DatabaseContext context)
        : base(context)
        { }

       public new void Add(Subscribers Mail)
        {
            Context.Set<Subscribers>().Add(Mail);
        }

        public new IEnumerable<Subscribers> GetAll()
        {
            return Context.Set<Subscribers>().ToList();
        }
    }
}
