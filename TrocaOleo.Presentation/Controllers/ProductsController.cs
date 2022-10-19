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
        public async Task<IActionResult> GetProductsForManufacturer(Guid productManufacturerId)
        {
            var products = await _service.ProductService.GetAllAsync(productManufacturerId, trackChanges: false);

            return Ok(products);
        }

        [HttpGet("{id:guid}", Name = "GetProductForManufacturer")]
        public async Task<IActionResult> GetProductForManufacturer(Guid productManufacturerId, Guid id)
        {
            var productDto = await _service.ProductService.GetByIdAsync(productManufacturerId, id, trackChanges: false);

            return Ok(productDto);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductForProductManufacturer(
            Guid productManufacturerId, [FromBody] ProductForCreationDto product)
        {
            if (product is null)
                return BadRequest("ProductForCreationDto object is null");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            var productToReturn = await _service.ProductService
                .CreateProductForProductManufacturerAsync(productManufacturerId, product, trackChanges: false);

            return CreatedAtRoute("GetProductForManufacturer", 
                new { productManufacturerId, id = productToReturn.Id }, productToReturn);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpdateProductForProductManufacturer(Guid productmanufacturerId, Guid id,
            [FromBody] ProductForUpdateDto product)
        {
            if (product is null)
                return BadRequest("ProductForUpdateDto object is null");

            if (!ModelState.IsValid)
                return UnprocessableEntity(ModelState);

            await _service.ProductService.UpdateProductForProductManufacturerAsync(
                productmanufacturerId, id, product, manufTrackChanges: false, prodTrackChanges: true);
            
            return NoContent();
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteProductForProductmanufacturer(Guid productmanufacturerId, Guid id)
        {
            await _service.ProductService.DeleteProductForProductManufacturerAsync(productmanufacturerId, id, trackChanges: false);

            return NoContent();
        }
    }
}
