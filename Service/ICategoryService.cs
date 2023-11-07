using Entities;

namespace Service
{
    public interface ICategoryService
    {
        Task<Category> addUCategory(Category category);
        Task<IEnumerable<Category>> getCategoreis();
        Task<Category> getCategoreisById(int id);
    }
}