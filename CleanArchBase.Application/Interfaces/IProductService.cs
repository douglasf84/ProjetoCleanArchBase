using CleanArchBase.Application.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CleanArchBase.Application.Interfaces
{
    public interface IProductService
    {
        Task CreateAsync(ProductViewModel product);
        Task UpdateAsync(ProductViewModel product);
        Task RemoveAsync(int? id);
        Task<IEnumerable<ProductViewModel>> GetProductsAsync();
        Task<ProductViewModel> GetByIdAsync(int? id);
    }
}
