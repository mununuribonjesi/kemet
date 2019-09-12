using AMF.Entities.DTOs;

namespace AMF.Infrastructure.Interfaces
{
    public interface IEMailService
    {
        void Add(SubscribedEmails Mail);
    }
}
