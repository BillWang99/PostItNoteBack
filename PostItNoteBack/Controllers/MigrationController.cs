using Microsoft.AspNetCore.Mvc;
using PostItNoteBack.Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PostItNoteBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MigrationController : ControllerBase
    {
        // GET: api/<MigrationController>
        [HttpGet]
        public string Get()
        {
            MigrationService.ApplyUpDateDB();
            return "Ready to Work";
        }

        // GET api/<MigrationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<MigrationController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<MigrationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<MigrationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
