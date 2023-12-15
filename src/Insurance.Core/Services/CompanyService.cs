using AutoMapper;
using Insurance.Core.Interfaces;
using Insurance.Core.Models;
using Insurance.Infrastructure.Interfaces;

namespace Insurance.Core.Services
{
    public class CompanyService : ICompanyService
    {
        private readonly ICompanyRepository _companyRepository;
        private readonly IMapper _mapper;

        public CompanyService(ICompanyRepository companyRepository, IMapper mapper)
        {
            _companyRepository = companyRepository;
            _mapper = mapper;
        }

        public CompanyDTO GetCompany(int id) =>
            _mapper.Map<CompanyDTO>(_companyRepository.GetCompany(id));
    }
}
