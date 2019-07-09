using AMF.Data.Interfaces.Repositories;
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
        private readonly IMailingListRepository _mlr;

        public MailingListService(IMailingListRepository mlr)
        {
            _mlr = mlr;
        }

        public void Add(Subscribers Mail)
        {
            _mlr.Add(Mail);
        }

        public IEnumerable<Subscribers> GetMailingList()
        {
            return _mlr.GetAll();
        }
    }
}