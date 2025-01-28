using ProductCatalogApi.Application.Interfaces;
using ProductCatalogApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogApi.Application.UseCases
{
    public class UpdateProduct
    {
        private readonly IProductRepository _productRepository;

        public UpdateProduct(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Execute(Product product)
        {
            _productRepository.Update(product);
        }
    }
}
