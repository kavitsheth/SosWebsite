using System.Collections.Generic;
using System.Threading.Tasks;
using SosWebsite.Models;
using System.Linq;
using System;

namespace SosWebsite.Repository
{
  public class MockProductRepository : ISwordsRepository<Product, string>
  {
    private IEnumerable<Product> Products = new List<Product>()
      {
          new Product { ProductId = "450039", Description = "Crucials #01 Garlic & Mayo Squeezy Sauce (GF) (VT) 500ml", Size = "500g", CaseSize = 12, ExpiryDate = new DateTime(year: 2021, month: 6, day: 30), FreeStock = -10_071, Stock = 1_197, AllocatedStock = 11_268, StockOnOrder = 4_968 },
          new Product { ProductId = "450040", Description = "Crucials #01 Yoghurt & Mint Squeezy Sauce (VT)(GF) 500ml", Size = "500g", CaseSize = 12, ExpiryDate = new DateTime(year: 2021, month: 6, day: 30), FreeStock = -6_683, Stock = 2_896, AllocatedStock = 11_268, StockOnOrder = 4104 },
          new Product { ProductId = "500500", Description = "Dr Magic Snatch A Dye Colour Catcher 20s",                 Size = "20's", CaseSize = 12, ExpiryDate = new DateTime(year: 2050, month: 12, day: 31), FreeStock = -93, Stock = 95, AllocatedStock = 2, StockOnOrder = 0 },
          new Product { ProductId = "451307", Description = "Tetley Decaf PM £1.75 40's",                               Size = "40's", CaseSize = 6,  ExpiryDate = new DateTime(year: 2020, month: 8, day: 31), FreeStock = -376, Stock = 447, AllocatedStock = 71, StockOnOrder = 0 }
      };
    public async Task<IEnumerable<Product>> GetAllAsync()
    {
      await Task.Delay(100);
      return Products;
    }

    public async Task<Product> GetByIdAsync(string id)
    {
      await Task.Delay(100);
      var product = Products.FirstOrDefault(p => p.ProductId == id);
      return product;
    }

    #region Unused CRUD Methods

    public Task Insert(Product entity)
    {
      throw new System.NotImplementedException();
    }
    public Task Update(Product entity)
    {
      throw new System.NotImplementedException();
    }
    public Task Delete(string id)
    {
      throw new System.NotImplementedException();
    }

    #endregion
  }
}