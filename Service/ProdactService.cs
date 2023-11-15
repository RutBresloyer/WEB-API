using Entities;
using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ProdactService : IProdactService
    {

        public IProdactRepository _prodactRepository;
        public ProdactService(IProdactRepository prodactRepository)
        {
            _prodactRepository = prodactRepository;
        }


        public async Task<IEnumerable<Product>> getProdactsByCategory(int categoryId)
        {
            return await _prodactRepository.getProdactsByCategory(categoryId);
        }

        public async Task<IEnumerable<Product>> getProducts(int position, int skip, string? desc, int? minPrice,
          int? maxPrice, int?[] categoryIds)
        {
            return await _prodactRepository.getProducts(position, skip, desc, minPrice, maxPrice, categoryIds);
        }

    }
}
