using System.Collections.Generic;
using System.Threading.Tasks;
using SosWebsite.Models;
using System.Linq;

namespace SosWebsite.Repository
{
  public class ProductRepository : ISwordsRepository<Product, string>
  {
    public async Task<IEnumerable<Product>> GetAllAsync()
    {
      var products = await SwordsContext.GetProductsAsync();
      return products;
    }

    public async Task<Product> GetByIdAsync(string id)
    {
      var products = await SwordsContext.GetProductsAsync();
      var product = products.FirstOrDefault(p => p.ProductId == id);
      return product;
    }

    public Task Insert(Product entity) => throw new System.NotImplementedException();

    public Task Update(Product entity) => throw new System.NotImplementedException();

    public Task Delete(string id) => throw new System.NotImplementedException();

  }
}