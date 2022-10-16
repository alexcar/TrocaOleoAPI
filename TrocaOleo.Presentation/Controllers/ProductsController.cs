using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

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

        [HttpGet("{id:guid}")]
        public IActionResult GetProductForManufacturer(Guid productManufacturerId, Guid id)
        {
            var productDto = _service.ProductService.GetById(productManufacturerId, id, trackChanges: false);

            return Ok(productDto);
        }
    }
}
