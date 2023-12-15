using Insurance.Infrastructure.Entities;

namespace Insurance.Infrastructure.Interfaces
{
    public interface IClaimTypeRepository
    {
        IEnumerable<ClaimType> GetAll();
    }
}
