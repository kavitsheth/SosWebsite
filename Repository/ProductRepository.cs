using System.Collections.Generic;
using System.Threading.Tasks;
using SosWebsite.Models;

namespace SosWebsite.Repository
{
  public class ProductRepository : ISwordsRepository<Product, string>
  {
    public Task Delete(string id)
    {
      throw new System.NotImplementedException();
    }

    public Task<IEnumerable<Product>> GetAll()
    {
      throw new System.NotImplementedException();
    }

    public Task<Product> GetById(string id)
    {
      throw new System.NotImplementedException();
    }

    public Task Insert(Product entity)
    {
      throw new System.NotImplementedException();
    }

    public Task Update(Product entity)
    {
      throw new System.NotImplementedException();
    }
  }
}