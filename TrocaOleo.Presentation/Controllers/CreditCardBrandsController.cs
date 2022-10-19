using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace TrocaOleo.Presentation.Controllers
{
    [Route("api/creditcardbrands")]
    [ApiController]
    public class CreditCardBrandsController : ControllerBase
    {
        private readonly IServiceManager _service;

        public CreditCardBrandsController(IServiceManager service)
        {
            _service = service;
        }

        [HttpGet("{id:guid}")]
        public async Task<IActionResult> GetCreditCardBrand(Guid id)
        {
            var creditCardBrand = await _service.CreditCardBrandService.GetAsync(id, trackChanges: false);

            return Ok(creditCardBrand);
        }

        [HttpGet]
        public async Task<IActionResult> GetCreditCardBrands()
        {
            var creditCardbrands = await _service.CreditCardBrandService.GetAllAsync(trackChanges: false);

            return Ok(creditCardbrands);
        }
    }
}
