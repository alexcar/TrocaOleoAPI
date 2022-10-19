using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace TrocaOleo.Presentation.Controllers
{
    [Route("api/productmanufactures")]
    [ApiController]
    public class ProductManufacturesController : ControllerBase
    {
        private readonly IServiceManager _service;

        public ProductManufacturesController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet("{id:guid}", Name = "GetById")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var pmDto = await _service.ProductManufacturerService.GetByIdAsync(id, trackChanges: false);

            return Ok(pmDto);
        }

        [HttpGet]
        public async Task<IActionResult> GetCreditCardBrands()
        {
            var pmsDto = await _service.ProductManufacturerService.GetAllAsync(trackChanges: false);

            return Ok(pmsDto);
        }

        [HttpGet("collection/({ids})", Name = "ProductManufacturerCollection")]
        public async Task<IActionResult> GetProductManufacturerCollection(IEnumerable<Guid> ids)
        {
            var companies = await _service.ProductManufacturerService.GetByIdsAsync(ids, trackChanges: false);

            return Ok(companies);
        }

        [HttpPost]
        public async Task<IActionResult> CreateProductManufacturer([FromBody] ProductManufacturerForCreationDto productManufacturer)
        {
            if (productManufacturer is null)
                return BadRequest("ProductManufacturerCreationDto object is null");

            var createdPM = await _service.ProductManufacturerService.CreateProductManufacturerAsync(productManufacturer);

            return CreatedAtRoute("GetById", new { id = createdPM.Id }, createdPM);
        }

        [HttpPost("collection")]
        public async Task<IActionResult> CreateProductManufacturerCollection(
            [FromBody] IEnumerable<ProductManufacturerForCreationDto> productManufacturerCollection)
        {
            var result = await _service.ProductManufacturerService
                .CreateProductManufacturerCollectionAsync(productManufacturerCollection);

            return CreatedAtRoute("ProductManufacturerCollection", new { result.ids }, result.productManufactures);
        }

        [HttpPut("{id:guid}")]
        public async Task<IActionResult> UpdateProductManufacturer(
            Guid id, [FromBody] ProductManufacturerForUpdateDto productManufacturer)
        {
            if (productManufacturer is null)
                return BadRequest("ProductManufacturerForUpdateDto object is null");

            await _service.ProductManufacturerService.UpdateProductManufacturerAsync(id, productManufacturer, trackChanges: true);

            return NoContent();
        }

        [HttpDelete("{id:guid}")]
        public async Task<IActionResult> DeleteProductManufacturer(Guid id)
        {
            await _service.ProductManufacturerService.DeleteProductManufacturerAsync(id, trackChanges: false);

            return NoContent();
        }
    }
}
