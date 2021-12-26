 using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "Value2", "Value3", "Value4", "Value5" };
        }

        [HttpGet("{id}")]

        public string Get(int id)
        {
            return "The value is" + id;
        }












    }
}
