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
        public async Task<ActionResult<IEnumerable<Product>>> Get(string? desc, int? minPrice, int? maxPrice, [FromQuery] int?[] categoryIds, int position = 1, int skip = 8)
        {
            List<Product> products = (List<Product>)await _prodactService.getProducts(position, skip, desc, minPrice, maxPrice, categoryIds);
            if (products.Count() == 0)
            {
                return NoContent();
            }
            return Ok(products);
        }
    }
}
