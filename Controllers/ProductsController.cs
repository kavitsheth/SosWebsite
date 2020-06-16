using Microsoft.AspNetCore.Mvc;
using SosWebsite.Models;
using System.Threading.Tasks;
using System.Collections.Generic;
using SosWebsite.Repository;

namespace SosWebsite.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class ProductsController : ControllerBase
  {

    private ISwordsRepository<Product, string> _repository;
    public ProductsController(ISwordsRepository<Product,string> repository)
    {
      _repository = repository;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Product>>> GetAllAsync()
    {
      return Ok();
    }


    [HttpGet("{id")]
    public async Task<ActionResult<Product>> GetByIdAsync(string id)
    {
      return Ok();
    }
  }
}