using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;
using Microsoft.Extensions.Caching.Redis;
using Wowu88.Business;
using Wowu88.Business.Cache;
using Wowu88.Business.Entity;
using Wowu88.Business.Repositoies;

namespace Wowu88_Mobile.Controllers
{
    [Route("api/[controller]")]
    public class PropertyController : Controller
    {
        private CacheByRedis redis = new CacheByRedis();
        // GET api/values
        [HttpGet]
        public IEnumerable<Property> Get()
        {
            var service = new PropertyRepository();
            var property = redis.Read<IEnumerable<Property>>("property", 0);
            if (property.Count()==0)
            {
                return service.GetProperties();
            }
            return property;
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
