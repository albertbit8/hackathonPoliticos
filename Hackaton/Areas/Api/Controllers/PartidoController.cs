using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Hackaton.Areas.Api.Controllers
{
    public class PartidoController : ApiController
    {
        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "PT", "PSDB" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "PT";
        }
    }
}