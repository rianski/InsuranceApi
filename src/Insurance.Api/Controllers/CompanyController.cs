using Insurance.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Insurance.Api.Controllers
{
    [ApiController]
    [Route("api/company")]
    public class CompanyController : Controller
    {
        private readonly ICompanyService _companyService;

        public CompanyController(ICompanyService companyService)
        {
            _companyService = companyService ?? throw new ArgumentNullException(nameof(companyService));
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var company = _companyService.GetCompany(id);

            if (company == null)
            {
                return NotFound(id);
            }

            return Ok(company);
        }
    }
}
