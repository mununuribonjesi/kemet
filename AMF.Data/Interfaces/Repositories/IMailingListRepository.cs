using AMF.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMF.Data.Interfaces.Repositories
{
    public interface IMailingListRepository: IRepository<Subscribers>
    {
        new void Add(Subscribers Mail);
        new IEnumerable<Subscribers> GetAll();
    }
}
