using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DAL.Models;
using BusinessLigic;
using Shared.DTO;
using AutoMapper;
using BusinessLigic.Interfaces;

namespace BSA_WebAPI.Controllers
{
    [Route("api/[controller]")]
    public class AirplanesController : Controller
    {
        public readonly IAirplaneService service;

        public AirplanesController(IAirplaneService service)
        {
            this.service = service;
        }

        // GET: api/airplanes
        [HttpGet]
        public IEnumerable<Airplane> Get()
        {
            return service.Get();
        }

        // GET api/airplanes/id
        [HttpGet("{id}")]
        public Airplane Get(int id)
        {
            return service.GetById(id);
        }

        // POST api/airplanes
        [HttpPost]
        public void Post([FromBody]AirplaneDTO airplane)
        {
            if (ModelState.IsValid)
            {
                service.Create(airplane);
            }
        }

        // PUT api/airplanes/id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]AirplaneDTO airplane)
        {
            if (ModelState.IsValid)
            {
                service.Update(id, airplane);
            }
        }

        // DELETE api/airplanes
        [HttpDelete]
        public void Delete()
        {
            service.Delete();
        }

        // DELETE api/airplanes/id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service.Delete(id);
        }
    }
}
