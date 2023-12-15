using Insurance.Infrastructure.Context;
using Insurance.Infrastructure.Entities;
using Insurance.Infrastructure.Interfaces;

namespace Insurance.Infrastructure.Repositories
{
    public class ClaimTypeRepository : IClaimTypeRepository
    {
        public ClaimTypeRepository()
        {
            ClaimTypeCollection = InsuranceStore.InMemoryClaimTypes;
        }

        private IEnumerable<ClaimType> ClaimTypeCollection { get; }

        public IEnumerable<ClaimType> GetAll()
        {
            return ClaimTypeCollection;
        }
    }
}
