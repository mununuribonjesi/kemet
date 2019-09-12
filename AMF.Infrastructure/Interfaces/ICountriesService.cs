using AMF.Entities.DTOs;
using System;
using System.Collections.Generic;

namespace AMF.Infrastructure.Interfaces
{
    public interface ICountriesService
    {
        IEnumerable<Countries> GetCountries();
    }
}
