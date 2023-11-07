using Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class ProdactRepository : IProdactRepository
    {
        private readonly Manager326239886Context _managerContext;
        public ProdactRepository(Manager326239886Context managerContext)
        {
            _managerContext = managerContext;
        }


        public async Task<IEnumerable<Product>> getProdactsByCategory(int categoryId)
        {
            return await _managerContext.Products.Where(p => p.CategoryId == categoryId).ToListAsync();
        }
    }
}
