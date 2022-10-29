using Entities.Responses;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;
using Shared.DataTransferObjects;
using TrocaOleo.Presentation.ActionFilters;
using TrocaOleo.Presentation.Extensions;
using TrocaOleo.Presentation.ModelBinders;

namespace TrocaOleo.Presentation.Controllers
{
    [Route("api/companies")]
    [ApiController]
    [ApiExplorerSettings(GroupName = "v1")]
    public class CompaniesController : ControllerBase //ApiControllerBase
    {
        private readonly IServiceManager _service;

        public CompaniesController(IServiceManager service)
        {
            _service = service;
        }

        /// <summary>
        /// Get the list of all Companies
        /// </summary>
        /// <returns>The companies list</returns>
        [HttpGet]
        // [Authorize(Roles = "Manager")]
        public async Task<IActionResult> GetCompanies()
        {
            var companies = await _service
                    .CompanyService.GetAllCompaniesAsync(trackChanges: false);

            return Ok(companies);
        }

        [HttpGet("{id:guid}", Name = "CompanyById")]
        public async Task<IActionResult> GetCompany(Guid id)
        {
            var company = await _service.CompanyService.GetCompanyAsync(id, trackChanges: false);

            return Ok(company);
        }

        [HttpGet("collection/({ids})", Name = "CompanyCollection")]
        public async Task<IActionResult> GetCompanyCollection([ModelBinder(BinderType = typeof(ArrayModelBinder))] IEnumerable<Guid> ids)
        {
            var companies = await _service.CompanyService.GetByIdsAsync(ids, trackChanges: false);

            return Ok(companies);
        }

        [HttpPost]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateCompany([FromBody] CompanyForCreationDto company)
        {
            //if (company is null)
            //    return BadRequest("CompanyForCreationDto object is null");

            //if (!ModelState.IsValid)
            //    return UnprocessableEntity(ModelState);

            var createdCompany = await _service.CompanyService.CreateCompanyAsync(company);

            return CreatedAtRoute("CompanyById", new { id = createdCompany.Id }, createdCompany);
        }

        [HttpPost("collection")]
        [ServiceFilter(typeof(ValidationFilterAttribute))]
        public async Task<IActionResult> CreateCompanyCollection([FromBody] IEnumerable<CompanyForCreationDto> companyCollection)
        {
            var result = await _service.CompanyService.CreateCompanyCollectionAsync(companyCollection);

            return CreatedAtRoute("CompanyCollection", new { result.ids }, result.companies);
        }

        //[HttpGet("getcompanies2")]
        //public IActionResult GetCompanies2()
        //{
        //    var baseResult = _service.CompanyService.GetAllCompanies(trackChanges: false);
        //    var companies = baseResult.GetResult<IEnumerable<CompanyDto>>();

        //    return Ok(companies);
        //}

        //[HttpGet("{id:guid}", Name = "getcompany2")]
        //public IActionResult GetCompany2(Guid id)
        //{
        //    var baseResult = _service.CompanyService.GetCompany(id, trackChanges: false);

        //    if (!baseResult.Success)
        //        return ProcessError(baseResult);

        //    var company = baseResult.GetResult<CompanyDto>();

        //    return Ok(company);
        //}
    }
}
