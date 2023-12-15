using Insurance.Core.Interfaces;
using Insurance.Core.Models;
using Microsoft.AspNetCore.Mvc;

namespace Insurance.Api.Controllers
{
    [ApiController]
    [Route("api/claims")]
    public class ClaimController : Controller
    {
        private readonly IClaimService _claimService;

        public ClaimController(IClaimService claimService)
        {
            _claimService = claimService ?? throw new ArgumentNullException(nameof(claimService));
        }

        [HttpGet("getClaimsForCompany{companyId}")]
        public IActionResult GetClaimsForCompany(int companyId)
        { 
            var claims = _claimService.GetCompanyClaims(companyId);

            if (!claims.Any())
            {
                return NotFound(companyId);
            }

            return Ok(claims);
        }

        [HttpGet("getCompanyClaim/{companyId}/{ucr}")]
        public IActionResult GetClaimForCompany(int companyId, string ucr)
        {
            var claim = _claimService.GetCompanyClaim(companyId, ucr);

            if (claim == null)
            {
                return NotFound(ucr);
            }

            return Ok(claim);
        }


        [HttpPut("getCompanyClaim/{companyId}/{ucr}")]
        public IActionResult UpdateCompanyClaim(int companyId, string ucr, UpdateClaimDTO claimDTO)
        {
            var claim = _claimService.UpdateCompanyClaim(companyId, ucr, claimDTO);

            if (claim == null)
            {
                return NotFound(ucr);
            }

            return Ok(claim);
        }
    }
}
