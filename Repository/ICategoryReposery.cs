using Entities;

namespace Repository
{
    public interface ICategoryReposery
    {
        Task<Category> addUCategory(Category category);
        Task deleteCategory(int id);
        Task<Category> editCategory(Category categoryToUpdate);
        Task<IEnumerable<Category>> getCategoreis();
        Task<Category> getCategoreisById(int id);
    }
}