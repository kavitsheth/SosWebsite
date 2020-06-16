using System.Collections.Generic;
using System.Threading.Tasks;

namespace SosWebsite.Repository
{
  public interface ISwordsRepository<T, TKey>
  {
    Task<IEnumerable<T>> GetAllAsync();
    Task<T> GetByIdAsync(TKey id);
    Task Insert(T entity);
    Task Update(T entity);
    Task Delete(TKey id);
  }
}