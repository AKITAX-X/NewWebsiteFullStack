using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VerbindingDatabase;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FullStackDoorloopFFF
{
    [Route("api/[controller]")]
    [ApiController]
    public class KlantController : ControllerBase
    {
        private KlantContext _db;

        public KlantController(KlantContext db)
        {
            _db = db;
        }

        // GET: api/<KlantController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "Iets van jezelf" };
        }

        // GET api/<KlantController>/5
        [HttpGet("mijnkeuze")]
        public Klant mijnKeuzeMehtode(int id)
        {
            Klant klant = new Klant();
            klant.Naam = "Ronny";
            klant.Leeftijd = 23;
            _db.Add(klant);
            _db.SaveChanges();
            return klant;
            
        }

        // POST api/<KlantController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        // PUT api/<KlantController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<KlantController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
