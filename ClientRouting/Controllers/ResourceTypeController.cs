using ClientRouting.Business;
using ClientRouting.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ClientRouting.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResourceTypeController : ControllerBase
    {
        private readonly ILogger<ResourceTypeController> _logger;
        private readonly IResourceTypeService _resourceTypeService;

        public ResourceTypeController(ILogger<ResourceTypeController> logger, IResourceTypeService resourceTypeService)
        {
            _logger = logger;
            _resourceTypeService= resourceTypeService;
        }
        // GET: api/<ResourceTypeController>
        [HttpGet]
        public IEnumerable<ResourceType> Get()
        {
            return _resourceTypeService.GetResourceTypes();
        }

        // GET api/<ResourceTypeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ResourceTypeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ResourceTypeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ResourceTypeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
