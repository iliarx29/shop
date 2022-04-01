using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Core.Entities;
using Core.Specification;
using Services.DTOs;

namespace Services.Interfaces
{
    public interface IProductService
    {
       Task<ProductToReturn?> FindProductWithSpec(ISpecification<Product> spec);
        Task<IReadOnlyList<ProductToReturn>> FindProductsWithSpec(ISpecification<Product> spec);
    }
}