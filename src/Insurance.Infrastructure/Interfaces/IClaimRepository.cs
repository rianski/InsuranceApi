using Insurance.Infrastructure.Entities;

namespace Insurance.Infrastructure.Interfaces
{
    public interface IClaimRepository
    {
        Claim GetCompanyClaim(int companyId, string ucr);
        IEnumerable<Claim> GetCompanyClaims(int companyId);
        Claim UpdateCompanyClaim(Claim updatedClaim);
    }
}
