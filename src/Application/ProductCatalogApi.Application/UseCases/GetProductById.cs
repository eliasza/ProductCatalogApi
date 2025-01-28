using ProductCatalogApi.Application.Interfaces;
using ProductCatalogApi.Domain.Entities;

namespace ProductCatalogApi.Application.UseCases
{
    public class GetProductById
    {
        private readonly IProductRepository _productRepository;

        public GetProductById(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public Product Execute(int id)
        {
            return _productRepository.GetById(id);
        }
    }
}
