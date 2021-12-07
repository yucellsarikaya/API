using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Properties
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private IPersonService service;

        public PersonsController(IPersonService service)
        {
            this.service = service;
        }

        [HttpGet("getall")]
        public IActionResult GetList() //tüm listeyi getirir
        {
            var result = service.GetList();
            return Ok(result); //işem başarılı ise result dondorulur
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int id) //girilen id ye göre veri getirir
        {
            var result = service.GetById(id);
            return Ok(result);
        }

        [HttpPost("add")]
        public void Add(Person person)
        {
            service.Add(person);
        }

        [HttpPost("update")]
        public void Update(Person person)
        {
            service.Update(person);
        }

        [HttpPost("delete")]
        public void Delete(Person person)
        {
            service.Delete(person);
        }
    }
}
