using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace modul8_1302201137.Controllers
{
    
    [Route("api/[controller]")]
    public class MovieController : Controller
    {
       
        private string[] SemuaMovies = new[]
        {
            "Insidious", "The Batman", "Star Wars"
        };

        [HttpGet]
        public IEnumerable<string> Get()
        {
           
            return SemuaMovies;
        }

       
        [HttpGet("{id}")]
        public string Get(int id)
        {
          
            return SemuaMovies[id];
        }

       
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

       
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

       
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
