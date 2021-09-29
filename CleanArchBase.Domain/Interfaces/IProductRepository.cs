using CleanArchBase.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchBase.Domain.Interfaces
{
    public interface IProductRepository
    {    
        Task CreateAsync(Product product);
        Task UpdateAsync(Product product);
        Task RemoveAsync(Product product);
        Task<IEnumerable<Product>> GetProductsAsync();
        Task<Product> GetByIdAsync(int? id);
    }
}
