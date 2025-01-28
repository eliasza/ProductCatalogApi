using ProductCatalogApi.Application.Interfaces;
using ProductCatalogApi.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductCatalogApi.Application.UseCases
{
    public class DeleteProduct
    {
        private readonly IProductRepository _productRepository;

        public DeleteProduct(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public void Execute(int id)
        {
            _productRepository.Delete(id);
        }
    }
}
