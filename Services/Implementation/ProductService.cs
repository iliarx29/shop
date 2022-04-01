using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Core.Entities;
using Core.Specification;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Services.DTOs;
using Services.Interfaces;

namespace Services.Implementation
{
    public class ProductService : IProductService
    {
        private readonly ApplicationContext _context;
        private readonly IMapper _mapper;

        public ProductService(ApplicationContext context, IMapper mapper)
        {
            _mapper = mapper;
            _context = context;
        }

        public async Task<IReadOnlyList<ProductToReturn>> FindProductsWithSpec(ISpecification<Product> spec)
        {
            var products = await SpecificationEvaluator<Product>.GetQuery(_context.Set<Product>().AsQueryable(), spec)
                                .ToListAsync();

            return _mapper.Map<IReadOnlyList<Product>, IReadOnlyList<ProductToReturn>>(products); 
        }

        public async Task<ProductToReturn?> FindProductWithSpec(ISpecification<Product> spec)
        {
            var product = await SpecificationEvaluator<Product>.GetQuery(_context.Set<Product>().AsQueryable(), spec)
                                .FirstOrDefaultAsync();
                                
            return _mapper.Map<Product, ProductToReturn>(product);
        }
    }
}