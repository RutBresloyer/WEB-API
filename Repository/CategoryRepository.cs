using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class CategoryRepository : ICategoryReposery
    {


        //string path = "M:/API/API/wwwroot/users.txt";
        //string path = "M:/API/API/wwwroot/users.txt";
        private readonly Manager326239886Context _managerContext;
        public CategoryRepository(Manager326239886Context managerContext)
        {
            _managerContext = managerContext;
        }

        public async Task<Category> addUCategory(Category category)
        {
            await _managerContext.Categories.AddAsync(category);
            await _managerContext.SaveChangesAsync();
            return category;

        }
        public async Task<IEnumerable<Category>> getCategoreis()
        {
            return await _managerContext.Categories.ToListAsync();
        }

        public async Task<Category> getCategoreisById(int id)
        {
            return await _managerContext.Categories.FindAsync(id);
        }

        public async Task<Category> editCategory(Category categoryToUpdate)
        {
            _managerContext.Categories.Update(categoryToUpdate);
            await _managerContext.SaveChangesAsync();
            return categoryToUpdate;

        }
        public async Task deleteCategory(int id)
        {
            var category = await _managerContext.Categories.FindAsync(id);
            _managerContext.Remove(category);
            _managerContext.SaveChangesAsync();
        }

    }
}


