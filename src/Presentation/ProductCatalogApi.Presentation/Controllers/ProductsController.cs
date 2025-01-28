using Microsoft.AspNetCore.Mvc;
using ProductCatalogApi.Application.UseCases;
using ProductCatalogApi.Domain.Entities;

namespace ProductCatalogApi.Presentation.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly GetAllProducts _getAllProducts;
        private readonly GetProductById _getProductById;
        private readonly AddProduct _addProduct;
        private readonly UpdateProduct _updateProduct;
        private readonly DeleteProduct _deleteProduct;

        public ProductsController(GetAllProducts getAllProducts, GetProductById getProductById, AddProduct addProduct, UpdateProduct updateProduct, DeleteProduct deleteProduct)
        {
            _getAllProducts = getAllProducts;
            _getProductById = getProductById;
            _addProduct = addProduct;
            _updateProduct = updateProduct;
            _deleteProduct = deleteProduct;
        }

        // GET: api/products
        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return Ok(_getAllProducts.Execute());
        }

        // GET: api/products/5
        [HttpGet("{id}")]
        public ActionResult<Product> Get(int id)
        {
            var product = _getProductById.Execute(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        // POST: api/products
        [HttpPost]
        public ActionResult<Product> Post([FromBody] Product product)
        {
            _addProduct.Execute(product);
            return CreatedAtAction(nameof(Get), new { id = product.Id }, product);
        }

        // PUT: api/products/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Product product)
        {
            if (id != product.Id)
            {
                return BadRequest();
            }

            _updateProduct.Execute(product);
            return NoContent();
        }

        // DELETE: api/products/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            var product = _getProductById.Execute(id);
            if (product == null)
            {
                return NotFound();
            }

            _deleteProduct.Execute(id);
            return NoContent();
        }
    }
}
