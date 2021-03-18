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
    public class CSVController : ApiController
    {
        // GET: api/CSV
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/CSV/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/CSV
        public void Post([FromBody]string value)
        {
            foreach (Information i in CSV_treatment.Convert(value))
            {
                dbInfo.Add(i);
            }
        }

        // PUT: api/CSV/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CSV/5
        public void Delete(int id)
        {
        }
    }
}
