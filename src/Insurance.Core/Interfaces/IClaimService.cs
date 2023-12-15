using Insurance.Core.Models;

namespace Insurance.Core.Interfaces
{
    public interface IClaimService
    {
        ClaimDTO GetCompanyClaim(int id, string ucr);
        IEnumerable<ClaimDTO> GetCompanyClaims(int id);
        ClaimDTO UpdateCompanyClaim(int companyId, string ucr, UpdateClaimDTO companyDTO);
    }
}
