﻿using Entities;

namespace Repository
{
    public interface IProdactRepository
    {
        Task<IEnumerable<Product>> getProdactsByCategory(int categoryId);
        Task<IEnumerable<Product>> getProducts(int position, int skip, string? desc, int? minPrice, int? maxPrice, int?[] categoryIds);
    }
}