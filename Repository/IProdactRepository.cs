using Entities;

namespace Repository
{
    public interface IProdactRepository
    {
        Task<IEnumerable<Product>> getProdactsByCategory(int categoryId);
    }
}