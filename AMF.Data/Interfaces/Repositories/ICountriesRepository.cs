﻿
using AMF.Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMF.Data.Interfaces.Repositories
{
    public interface ICountriesRepository:IRepository<Countries>
    {
        new IEnumerable<Countries> GetAll();
    }
}
