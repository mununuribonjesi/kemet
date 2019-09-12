using AMF.Data.Interfaces.Repositories;
using AMF.Entities.DTOs;
using AMF.Infrastructure.Interfaces;

namespace AMF.Infrastructure.Services
{
    public class EmailService: IEMailService
    {

        private readonly IEmailRepository _emr;

        public EmailService(IEmailRepository emr)
        {
            _emr = emr;
        }

        public void Add(SubscribedEmails Mail)
        {
            _emr.Add(Mail);
        }

    }
}
