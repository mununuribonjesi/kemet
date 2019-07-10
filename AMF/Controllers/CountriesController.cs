using AMF.Entities.DTOs;
using AMF.Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;

namespace AMF.Controllers
{
    [Route("api/[controller]")]
    public class CountriesController : Controller
    {
        private readonly ICountriesService _countriesService;

        public CountriesController(ICountriesService countriesService)
        {
            _countriesService = countriesService;
        }

        [HttpGet("getCountries")]
        public IActionResult GetCountries()
        {
            try
            {
                return Ok(_countriesService.GetCountries());
            }
            catch (Exception exception)
            {
                return StatusCode(500, exception);
            }
        }
    }
}