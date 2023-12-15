using Insurance.Infrastructure.Context;
using Insurance.Infrastructure.Entities;
using Insurance.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Infrastructure.Repositories
{
    public class ClaimRepository : IClaimRepository
    {
        public ClaimRepository()
        {
            ClaimsCollection = InsuranceStore.InMemoryClaims;
        }

        private IList<Claim> ClaimsCollection { get; set; }

        public Claim GetCompanyClaim(int companyId, string ucr) =>
            ClaimsCollection.SingleOrDefault(c => c.CompanyId == companyId && c.UCR == ucr);

        public IEnumerable<Claim> GetCompanyClaims(int companyId) =>
            ClaimsCollection.Where(c => c.CompanyId == companyId);

        public Claim UpdateCompanyClaim(Claim updatedClaim)
        {
            if (updatedClaim == null)
            {
                throw new ArgumentNullException();
            }

            var existingClaim = ClaimsCollection.SingleOrDefault(c => c.UCR == updatedClaim.UCR);

            if (existingClaim != null)
            {
                ClaimsCollection = ClaimsCollection.Except(new List<Claim> { existingClaim }).ToList();
                ClaimsCollection.Add(updatedClaim);

                existingClaim = updatedClaim;
            }

            return existingClaim;
        }
    }
}
