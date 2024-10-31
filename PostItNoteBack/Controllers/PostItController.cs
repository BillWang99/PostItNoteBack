using Microsoft.AspNetCore.Mvc;
using PostItNoteBack.Interface;
using PostItNoteBack.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PostItNoteBack.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class PostItController : ControllerBase
    {
        private readonly IPostItService _postItService;

        public PostItController(IPostItService postItService)
        {
            _postItService = postItService;
        }

        // GET: api/<PostItController>
        [HttpGet]
        public IEnumerable<PostIt> Get()
        {
            var result = _postItService.AllPost();

            return result;
        }

        [HttpGet]
        public IEnumerable<PostIt> AllDeletePost()
        {
            var result = _postItService.AllDeletePost();

            return result;
        }

        // GET api/<PostItController>/5
        [HttpGet("{Id}")]
        public PostIt Get(int Id)
        {
            var result = _postItService.GetPost(Id);

            return result;
        }

        // POST api/<PostItController>
        [HttpPost]
        public void Post([FromBody] PostIt data)
        {
            _postItService.AddPost(data.Message);
        }

        // PUT api/<PostItController>/5
        [HttpPut("{Id}")]
        public void Put(int Id)
        {
            _postItService.RemovePost(Id);
        }

        [HttpPut("{Id}")]
        public void RollBack(int Id)
        {
            _postItService.RollBackPost(Id);
        }

        // DELETE api/<PostItController>/5
        [HttpDelete("{Id}")]
        public void Delete(int Id)
        {
            _postItService.DeletePost(Id);
        }

    }
}
