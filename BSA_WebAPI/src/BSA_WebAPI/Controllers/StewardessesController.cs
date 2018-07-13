using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BusinessLigic;
using DAL.Models;
using BusinessLigic.Interfaces;

namespace BSA_WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class StewardessesController : Controller
    {
        public readonly IStewardessService service;

        public StewardessesController(IStewardessService service)
        {
            this.service = service;
        }

        // GET: api/stewardesses

        [HttpGet]
        public IEnumerable<Stewardess> Get()
        {
            return service.Get();
        }

        // GET api/stewardesses/id
        [HttpGet("{id}")]
        public Stewardess Get(int id)
        {
            return service.GetById(id);
        }

        // POST api/stewardesses
        [HttpPost]
        public void Post([FromBody]Stewardess stewardess)
        {
            if (ModelState.IsValid)
            {
                service.Create(stewardess);
            }
        }

        // PUT api/stewardesses/id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Stewardess stewardess)
        {
            if (ModelState.IsValid)
            {
                service.Update(id, stewardess);
            }
        }

        // DELETE api/stewardesses
        [HttpDelete]
        public void Delete()
        {
            service.Delete();
        }

        // DELETE api/stewardesses/id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service.Delete(id);
        }
    }
}
