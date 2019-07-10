using AMF.Data.Interfaces.Repositories;
using AMF.Entities.DTOs;
using AMF.Entities.Models;
using System.Collections.Generic;
using System.Linq;

namespace AMF.Data.Repositories
{
    public class CountriesRepository : Repository<Countries>, ICountriesRepository
    {
        public CountriesRepository(DatabaseContext context)
        :base(context)
        { }

        public new IEnumerable<Countries> GetAll()
        {
            return Context.Set<Countries>().ToList();
        }
    }
}
