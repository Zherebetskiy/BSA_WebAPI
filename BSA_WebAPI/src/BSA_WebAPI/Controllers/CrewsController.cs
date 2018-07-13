using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BusinessLigic;
using DAL.Models;
using BusinessLigic.Interfaces;
using Shared.DTO;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace BSA_WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class CrewsController : Controller
    {
        public readonly ICrewService service;

        public CrewsController(ICrewService service)
        {
            this.service = service;
        }

        // GET: api/сrews

        [HttpGet]
        public IEnumerable<Crew> Get()
        {
            return service.Get();
        }

        // GET api/сrews/id
        [HttpGet("{id}")]
        public Crew Get(int id)
        {
            return service.GetById(id);
        }

        // POST api/сrews
        [HttpPost]
        public void Post([FromBody]CrewDTO сrew)
        {
            if (ModelState.IsValid)
            {
                service.Create(сrew);
            }
        }

        // PUT api/сrews/id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]CrewDTO сrew)
        {
            if (ModelState.IsValid)
            {
                service.Update(id, сrew);
            }
        }

        // DELETE api/сrews
        [HttpDelete]
        public void Delete()
        {
            service.Delete();
        }

        // DELETE api/сrews/id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service.Delete(id);
        }
    }
}
