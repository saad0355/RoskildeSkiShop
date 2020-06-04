using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RoskildeSkiShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SkiShopController : ControllerBase
    {
        List<SkiShopService> SkiListe = new List<SkiShopService>()
                    
        {
            
        };
    

       
        // GET: api/SkiShop
        [HttpGet]
        public  List<SkiShopService> Get()
        {
            return SkiListe;
           
        }

        // GET: api/SkiShop/5
        [HttpGet("{id}")]
        public SkiShopService Get(int id)
        {
            return SkiListe.Find(i => i.Id == id);
        }

        [HttpGet("{SkitType}")]
        public SkiShopService Get(string SkiType)
        {
            return SkiListe.Find(i => i.SkiType==SkiType);
        }

      
        // POST: api/SkiShop
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/SkiShop/5
        //[HttpPut("{id}")]
        //public SkiShopService Put(int id, [FromBody] SkiShopService value)
        //{
        //    SkiShopService i = Get(id);
        //}

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
