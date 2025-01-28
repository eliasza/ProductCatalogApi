
namespace ProductCatalogApi.Domain.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }

        public List<Product> ListProdctsMock()
        {
            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Nike", Price = 800.0m, Description = "Tenis para corrida" },
                new Product { Id = 2, Name = "Kichute", Price = 900.0m, Description = "Tenis para corrida, jogar bola e trabalhar" }
            };

            return products;
        }
    }
}
