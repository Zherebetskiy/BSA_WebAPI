using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BusinessLigic;
using DAL.Models;
using BusinessLigic.Interfaces;
using Shared.DTO;

namespace BSA_WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class DeparturesController : Controller
    {
        public readonly IDepartureService service;

        public DeparturesController(IDepartureService service)
        {
            this.service = service;
        }

        // GET: api/departures

        [HttpGet]
        public IEnumerable<Departure> Get()
        {
            return service.Get();
        }

        // GET api/departures/id
        [HttpGet("{id}")]
        public Departure Get(int id)
        {
            return service.GetById(id);
        }

        // POST api/departures
        [HttpPost]
        public void Post([FromBody]DepartureDTO departure)
        {
            if (ModelState.IsValid)
            {
                service.Create(departure);
            }
        }

        // PUT api/departures/id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]DepartureDTO departure)
        {
            if (ModelState.IsValid)
            {
                service.Update(id, departure);
            }
        }

        // DELETE api/departures
        [HttpDelete]
        public void Delete()
        {
            service.Delete();
        }

        // DELETE api/departures/id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service.Delete(id);
        }
    }
}
