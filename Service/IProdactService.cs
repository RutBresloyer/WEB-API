using Entities;

namespace Service
{
    public interface IProdactService
    {
        Task<IEnumerable<Product>> getProdactsByCategory(int categoryId);
        Task<IEnumerable<Product>> getProducts(int position, int skip, string? desc, int? minPrice, int? maxPrice, int?[] categoryIds);
    }
}