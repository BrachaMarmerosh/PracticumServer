using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Interfaces
{
  public interface IdataRepository<T>
  {
    Task<List<T>> GetAll();
    Task<T> GetByTZ(string TZ);
    Task<T> Add(T entity);

  }
}
