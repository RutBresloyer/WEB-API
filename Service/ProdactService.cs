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

    }
}
