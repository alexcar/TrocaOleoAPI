using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

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

        [HttpGet("{id:guid}")]
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
    }
}
