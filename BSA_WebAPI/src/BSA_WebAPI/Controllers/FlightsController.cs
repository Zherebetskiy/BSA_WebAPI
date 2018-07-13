using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using BusinessLigic;
using DAL.Models;
using DAL;
using BusinessLigic.Interfaces;
using Shared.DTO;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace BSA_WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class FlightsController : Controller
    {
        public readonly IFlightService service;

        public FlightsController(IFlightService service)
        {
            this.service = service;
        }

        // GET: api/flights

        [HttpGet]
        public IEnumerable<Flight> Get()
        {
            return service.Get();
        }

        // GET api/flights/id
        [HttpGet("{id}")]
        public Flight Get(int id)
        {
            return service.GetById(id);
        }

        // POST api/flights
        [HttpPost]
        public void Post([FromBody]FlightDTO flight)
        {
            if (ModelState.IsValid)
            {
                service.Create(flight);
            }
        }

        // PUT api/flights/id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]FlightDTO flight)
        {
            if (ModelState.IsValid)
            {
                service.Update(id, flight);
            }
        }

        // DELETE api/flights
        [HttpDelete]
        public void Delete()
        {
            service.Delete();
        }

        // DELETE api/flights/id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service.Delete(id);
        }
    }
}
