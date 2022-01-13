using AutoMapper;
using BookStore.Models;
using BookStore.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Services
{
    public class ProductService : IProductService
    {
        #region Fields
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;

        #endregion

        #region Ctor

        /// <summary>
        /// Ctor
        /// </summary>
        public ProductService(ICategoryRepository categoryRepository, IMapper mapper)
        {
            _categoryRepository = categoryRepository;
            _mapper = mapper;
        }
        #endregion

        public Task<ProductDto> AddProduct(ProductDto request)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> DeleteProduct(int productid)
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductDto>> GetAllSubProduct()
        {
            throw new NotImplementedException();
        }

        public Task<List<ProductDto>> GetProduct()
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> GetProductById(int productid)
        {
            throw new NotImplementedException();
        }

        public Task<ProductDto> UpdateProduct(ProductDto request)
        {
            throw new NotImplementedException();
        }
    }
}
