using AMF.Data.Interfaces.Repositories;
using AMF.Entities.DTOs;
using AMF.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AMF.Data.Repositories
{
    public class MailingListRepository : Repository<MailingList>, IMailingListRepository
    {
        public MailingList Mail;

        public MailingListRepository(DatabaseContext context)
      : base(context)
        { }

       public new void Add(MailingList Mail)
        {
            Context.Set<MailingList>().Add(Mail);
        }

        public new IEnumerable<MailingList> GetAll()
        {

            return Context.Set<MailingList>().ToList();
        }
    }
}
