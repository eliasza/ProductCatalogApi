using ProductCatalogApi.Application.Interfaces;
using ProductCatalogApi.Domain.Entities;

namespace ProductCatalogApi.Application.UseCases
{
    public class GetAllProducts
    {
        private readonly IProductRepository _productRepository;

        public GetAllProducts(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public IEnumerable<Product> Execute()
        {
            return _productRepository.GetAll();
        }
    }
}
