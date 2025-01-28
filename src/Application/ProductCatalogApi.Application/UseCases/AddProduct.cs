using ProductCatalogApi.Application.Interfaces;
using ProductCatalogApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogApi.Application.UseCases
{
    public class AddProduct
    {
        private readonly IProductRepository _productRepository;

        public AddProduct(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Execute(Product product)
        {
            _productRepository.Add(product);
        }
    }
}
