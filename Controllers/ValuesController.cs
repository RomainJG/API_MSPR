using MSPR_API.Controllers.classes;
using MSPR_API.Controllers.db;
using MSPR_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MSPR_API.Controllers
{
    public class ValuesController : ApiController
    {
        List<Information> infos = new List<Information>();

        

        // GET api/values
        public List<Information> Get()
        {
            return new List<Information>();
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post(string value)
        {
            
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
