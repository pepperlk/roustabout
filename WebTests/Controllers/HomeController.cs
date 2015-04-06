using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebTests.Controllers
{
    public class StringService
    {
        public StringService(HttpClient cli)
        {

        }


        public string[] Get()
        {
            return new string[] { "value1", "value2" };
        }
    }

    public class HomeController : ApiController
    {
        private StringService _svc;
        public HomeController(StringService svc)
        {
            _svc = svc;
        }

        // GET: api/Home
        public IEnumerable<string> Get()
        {
            return _svc.Get();
        }

        // GET: api/Home/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Home
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Home/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Home/5
        public void Delete(int id)
        {
        }
    }
}
