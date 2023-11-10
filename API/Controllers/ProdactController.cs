using Entities;
using Microsoft.AspNetCore.Mvc;
using Service;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProdactController : ControllerBase
    {



        IProdactService _prodactService;

        public ProdactController(IProdactService prodactService)
        {
            _prodactService = prodactService;
        }
        // GET: api/<ProdactController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "hhhh" };
        }

        // GET api/<ProdactController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<IEnumerable<Product>>> Get(int id)
        {
            List<Product> products = (List<Product>)await _prodactService.getProdactsByCategory(id);


            if (products.Count() == 0)
            {
                return NoContent();
            }
            return Ok(products);


        }

        //// POST api/<ProdactController>
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        //// PUT api/<ProdactController>/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody] string value)
        //{
        //}

        //// DELETE api/<ProdactController>/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
