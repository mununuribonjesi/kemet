using AMF.Data.Interfaces.Repositories;
using AMF.Entities.DTOs;
using AMF.Entities.Models;

namespace AMF.Data.Repositories
{
    public class CountriesRepository : Repository<Countries>, ICountriesRepository
    {
        public CountriesRepository(DatabaseContext context)
        :base(context)
        { }

    }
}
