using Catalog.Application.DTOs;

namespace Catalog.Application.Interfaces
{
    public interface IProductService
    {
        Task<IEnumerable<ProductDto>> GetAllAsync();
    }
}
