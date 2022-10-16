using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace TrocaOleo.Presentation.Controllers
{
    [Route("api/productmanufactures/{productManufacturerId}/products")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IServiceManager _service;

        public ProductsController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult GetProductsForManufacturer(Guid productManufacturerId)
        {
            var products = _service.ProductService.GetAll(productManufacturerId, trackChanges: false);

            return Ok(products);
        }

        [HttpGet("{id:guid}", Name = "GetProductForManufacturer")]
        public IActionResult GetProductForManufacturer(Guid productManufacturerId, Guid id)
        {
            var productDto = _service.ProductService.GetById(productManufacturerId, id, trackChanges: false);

            return Ok(productDto);
        }

        [HttpPost]
        public IActionResult CreateProductForProductManufacturer(
            Guid productManufacturerId, [FromBody] ProductForCreationDto product)
        {
            if (product is null)
                return BadRequest("ProductForCreationDto object is null");

            var productToReturn = _service.ProductService
                .CreateProductForProductManufacturer(productManufacturerId, product, trackChanges: false);

            return CreatedAtRoute("GetProductForManufacturer", 
                new { productManufacturerId, id = productToReturn.Id }, productToReturn);
        }
    }
}
