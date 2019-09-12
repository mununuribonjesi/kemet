using AMF.Entities.DTOs;

namespace AMF.Data.Interfaces.Repositories
{
    public interface IEmailRepository: IRepository<SubscribedEmails>
    {
        new void Add(SubscribedEmails Mail);
    }
}
