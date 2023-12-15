using AutoMapper;
using Insurance.Core.Interfaces;
using Insurance.Core.Models;
using Insurance.Infrastructure.Interfaces;
using Microsoft.Extensions.Logging;

namespace Insurance.Core.Services
{
    public class ClaimsService : IClaimService
    {
        private readonly IClaimRepository _claimsRepository;
        private readonly IMapper _mapper;
        private readonly ILogger<ClaimsService> _logger;

        public ClaimsService(IClaimRepository claimsRepository, IMapper mapper, ILogger<ClaimsService> logger)
        {
            _claimsRepository = claimsRepository;
            _mapper = mapper;
            _logger = logger;
        }

        public ClaimDTO GetCompanyClaim(int companyId, string ucr) =>
                _mapper.Map<ClaimDTO>(_claimsRepository.GetCompanyClaim(companyId, ucr));

        public IEnumerable<ClaimDTO> GetCompanyClaims(int id) =>
                _mapper.Map<IEnumerable<ClaimDTO>>(_claimsRepository.GetCompanyClaims(id)) ?? Enumerable.Empty<ClaimDTO>();

        public ClaimDTO UpdateCompanyClaim(int companyId, string ucr, UpdateClaimDTO updatedClaim)
        {
            var claim = _claimsRepository.GetCompanyClaim(companyId, ucr);

            if (claim is null)
            {
                _logger.LogError("No claims found for companyId: {companyId} and claim reference: {ucr}", companyId, ucr);
                throw new ArgumentNullException();
            }

            claim.ClaimDate = updatedClaim.ClaimDate;
            claim.LossDate = updatedClaim.LossDate;
            claim.AssuredName = updatedClaim.AssuredName;
            claim.IncurredLoss = updatedClaim.IncurredLoss;
            claim.Closed = updatedClaim.Closed;

            return _mapper.Map<ClaimDTO>(_claimsRepository.UpdateCompanyClaim(claim));
        }
    }
}
