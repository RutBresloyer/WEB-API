using Entities;

namespace Service
{
    public interface IProdactService
    {
        Task<IEnumerable<Product>> getProdactsByCategory(int categoryId);
    }
}