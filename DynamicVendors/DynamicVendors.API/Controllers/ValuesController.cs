using DynamicVendors.Models;
using DynamicVendors.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DynamicVendors.API.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<Admin> Get()
        {
            DynamicVendor data = new DynamicVendor();
            return data.GetAdmin();
           
        }

        // GET api/values/5
        public Admin Get(int id)
        {
            DynamicVendor data = new DynamicVendor();
            return data.GetAdmin(id);



           // return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
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
