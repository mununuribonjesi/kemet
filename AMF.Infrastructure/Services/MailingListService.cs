using AMF.Data.Interfaces.Repositories;
using AMF.Entities.DTOs;
using AMF.Infrastructure.Interfaces;
using System.Collections.Generic;

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
    }
}