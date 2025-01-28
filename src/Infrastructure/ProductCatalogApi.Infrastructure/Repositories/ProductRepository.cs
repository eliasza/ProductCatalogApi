using ProductCatalogApi.Application.Interfaces;
using ProductCatalogApi.Domain.Entities;

namespace ProductCatalogApi.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly Product _product = new Product();
        private int _nextId = 1;

        public IEnumerable<Product> GetAll()
        {
            return _product.ListProdctsMock();
        }

        public Product GetById(int id)
        {
            return _product.ListProdctsMock().FirstOrDefault(p => p.Id == id);
        }

        public void Add(Product product)
        {
            product.Id = _nextId++;
            _product.ListProdctsMock().Add(product);
        }

        public void Update(Product product)
        {
            var existingProduct = _product.ListProdctsMock().FirstOrDefault(p => p.Id == product.Id);
            if (existingProduct != null)
            {
                existingProduct.Name = product.Name;
                existingProduct.Price = product.Price;
                existingProduct.Description = product.Description;
            }
        }

        public void Delete(int id)
        {
            var product = _product.ListProdctsMock().FirstOrDefault(p => p.Id == id);
            if (product != null)
            {
                _product.ListProdctsMock().Remove(product);
            }
        }
    }
}
