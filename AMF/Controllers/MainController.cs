using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AMF.Controllers
{

    [Route("api/[Controller]")]
    public class MainController : Controller
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {

            return new string[] {"value 1", "value2"};
        }

        [HttpGet("{id}")]

        public string Get(int id)
        {

            return "value";
        }

        [HttpPost]

        public string Get([FromBody]string value)
        {

            return "value";
        }

    }
}