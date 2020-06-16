using Microsoft.AspNetCore.Mvc;
using SosWebsite.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SosWebsite.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ProductsController : ControllerBase
  {
    public ProductsController()
    {

    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Product>>> GetAll()
    {
        return Ok();
    }


    [HttpGet("{id")]
    public async Task<ActionResult<Product>> GetById(string id)
    {
        return Ok();
    }
  }
}