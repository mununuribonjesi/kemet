using AMF.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMF.Infrastructure.Interfaces
{
    public interface IMailingListService
    {
      void Add(MailingList Mail);
      IEnumerable<MailingList> GetMailingList();
    }
}
