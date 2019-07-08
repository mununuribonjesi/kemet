using AMF.Data.Repositories;
using AMF.Entities.DTOs;
using AMF.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMF.Infrastructure.Services
{
    public class MailingListService : IMailingListService
    {
        private readonly MailingListRepository MLR;

        public void Add(MailingList Mail)
        {
            MLR.Add(Mail);
        }

        public IEnumerable<MailingList> GetMailingList()
        {
            return MLR.GetAll();
        }
    }
}