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
        public IActionResult GetById(Guid id)
        {
            var pmDto = _service.ProductManufacturerService.GetById(id, trackChanges: false);

            return Ok(pmDto);
        }

        [HttpGet]
        public IActionResult GetCreditCardBrands()
        {
            var pmsDto = _service.ProductManufacturerService.GetAll(trackChanges: false);

            return Ok(pmsDto);
        }

        [HttpGet("collection/({ids})", Name = "ProductManufacturerCollection")]
        public IActionResult GetProductManufacturerCollection(IEnumerable<Guid> ids)
        {
            var companies = _service.ProductManufacturerService.GetByIds(ids, trackChanges: false);

            return Ok(companies);
        }

        [HttpPost]
        public IActionResult CreateProductManufacturer([FromBody] ProductManufacturerForCreationDto productManufacturer)
        {
            if (productManufacturer is null)
                return BadRequest("ProductManufacturerCreationDto object is null");

            var createdPM = _service.ProductManufacturerService.CreateProductManufacturer(productManufacturer);

            return CreatedAtRoute("GetById", new { id = createdPM.Id }, createdPM);
        }

        [HttpPost("collection")]
        public IActionResult CreateProductManufacturerCollection(
            [FromBody] IEnumerable<ProductManufacturerForCreationDto> productManufacturerCollection)
        {
            var result = _service.ProductManufacturerService
                .CreateProductManufacturerCollection(productManufacturerCollection);

            return CreatedAtRoute("ProductManufacturerCollection", new { result.ids }, result.productManufactures);
        }
    }
}
