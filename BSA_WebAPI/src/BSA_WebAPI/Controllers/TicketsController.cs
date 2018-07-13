using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DAL.Models;
using BusinessLigic;
using BusinessLigic.Interfaces;

namespace BSA_WebAPI.Controllers
{
    [Route("api/tickets")]
    public class TicketsController : Controller
    {
        public readonly ITicketService service;

        public TicketsController(ITicketService service)
        {
            this.service = service;
        }

        // GET: api/tickets

        [HttpGet]
        public IEnumerable<Ticket> Get()
        {
            return service.Get();
        }

        // GET api/tickets/id
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Ticket ticket = null;
            try
            {
                ticket = service.GetById(id);

            }
            catch (Exception)
            {

                return BadRequest($"Ticket with id:{id} is not found!");
            }

            return Ok(ticket);
        }

        // POST api/tickets
        [HttpPost]
        public void Post([FromBody]Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                service.Create(ticket);
            }
        }

        // PUT api/tickets/id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Ticket ticket)
        {
            if (ModelState.IsValid)
            {
                service.Update(id, ticket);
            }
        }

        // DELETE api/tickets
        [HttpDelete]
        public void Delete()
        {
            service.Delete();
        }

        // DELETE api/tickets/id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service.Delete(id);
        }
    }
}
