using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace TrocaOleo.Presentation.Controllers
{
    [Route("api/creditcardbrands")]
    [ApiController]
    public class CreditCardBrandController : ControllerBase
    {
        private readonly IServiceManager _service;

        public CreditCardBrandController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet("{id:guid}")]
        public IActionResult GetCreditCardBrand(Guid id)
        {
            var creditCardBrand = _service.CreditCardBrandService.Get(id, trackChanges: false);

            return Ok(creditCardBrand);
        }

        [HttpGet]
        public IActionResult GetCreditCardBrands()
        {
            var creditCardbrands = _service.CreditCardBrandService.GetAll(trackChanges: false);

            return Ok(creditCardbrands);
        }
    }
}
