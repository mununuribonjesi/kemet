using AMF.Data.Interfaces.Repositories;
using AMF.Entities.DTOs;
using AMF.Infrastructure.Interfaces;
using System.Collections.Generic;

namespace AMF.Infrastructure.Services
{
    public class CountriesService :ICountriesService
    {
        private readonly ICountriesRepository _cr;

        public CountriesService(ICountriesRepository cr)
        {
            _cr = cr;
        }

        public IEnumerable<Countries> GetCountries()
        {
            return _cr.GetAll();
        }
    }
}
