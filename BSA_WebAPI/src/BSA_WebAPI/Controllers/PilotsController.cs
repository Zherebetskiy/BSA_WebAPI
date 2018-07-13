using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BusinessLigic;
using DAL.Models;
using BusinessLigic.Interfaces;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace BSA_WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class PilotsController : Controller
    {
        public readonly IPilotService service;

        public PilotsController(IPilotService service)
        {
            this.service = service;
        }

        // GET: api/pilots
        [HttpGet]
        public IEnumerable<Pilot> Get()
        {
            return service.Get();
        }

        // GET api/pilots/id
        [HttpGet("{id}")]
        public Pilot Get(int id)
        {
            return service.GetById(id);
        }

        // POST api/pilots
        [HttpPost]
        public void Post([FromBody]Pilot pilot)
        {
            if (ModelState.IsValid)
            {
                service.Create(pilot);
            }
        }

        // PUT api/pilots/id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Pilot pilot)
        {
            if (ModelState.IsValid)
            {
                service.Update(id, pilot);
            }
        }

        // DELETE api/pilots
        [HttpDelete]
        public void Delete()
        {
            service.Delete();
        }

        // DELETE api/pilots/id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service.Delete(id);
        }
    }
}
