using Entities;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class CategoryService : ICategoryService
    {

        private readonly ICategoryReposery _categoryRepository;
        public CategoryService(ICategoryReposery categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }


        public async Task<Category> addUCategory(Category category)
        {

            return await _categoryRepository.addUCategory(category);
        }

        public async Task<IEnumerable<Category>> getCategoreis()
        {
            return await _categoryRepository.getCategoreis();
        }

        public async Task<Category> getCategoreisById(int id)
        {
            return await _categoryRepository.getCategoreisById(id);
        }
    }


}
