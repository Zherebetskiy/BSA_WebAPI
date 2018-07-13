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
    public class AirplaneTypesController : Controller
    {
        public readonly IAirplaneTypeService service;

        public AirplaneTypesController(IAirplaneTypeService service)
        {
            this.service = service;
        }

        // GET: api/airplaneTypes

        [HttpGet]
        public IEnumerable<AirplaneType> Get()
        {
            return service.Get();
        }

        // GET api/airplaneTypes/id
        [HttpGet("{id}")]
        public AirplaneType Get(int id)
        {
            return service.GetById(id);
        }

        // POST api/airplaneTypes
        [HttpPost]
        public void Post([FromBody]AirplaneType airplaneType)
        {
            if (ModelState.IsValid)
            {
                service.Create(airplaneType);
            }            
        }

        // PUT api/airplaneTypes/id
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]AirplaneType airplaneType)
        {
            if (ModelState.IsValid)
            {
                service.Update(id, airplaneType);
            }
        }

        // DELETE api/airplaneTypes
        [HttpDelete]
        public void Delete()
        {
            service.Delete();
        }

        // DELETE api/airplaneTypes/id
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            service.Delete(id);
        }
    }
}
